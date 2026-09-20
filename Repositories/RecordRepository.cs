// Repositories/RecordRepository.cs
using Microsoft.EntityFrameworkCore;
using ProcessTracker.Data;
using ProcessTracker.Entities;
using ProcessTracker.Interfaces.RepositoryInterfaces;

namespace ProcessTracker.Repositories
{
    public class RecordRepository : GenericRepository<ProcessRecord>, IRecordRepository
    {
        public RecordRepository(ApplicationDbContext context) : base(context) { }

        public async Task<ProcessRecord?> GetRecordWithFieldsAsync(long recordId)
        {
            return await _context.ProcessRecords
                .Include(pr => pr.FieldValues)
                .Include(pr => pr.ProcessDefinition)
                .ThenInclude(pd => pd.Fields)
                .FirstOrDefaultAsync(pr => pr.Id == recordId);
        }


        // Repositories/RecordRepository.cs - GetRecordsByProcessDefinitionAsync (CORRECTED)
        public async Task<List<ProcessRecord>> GetRecordsByProcessDefinitionAsync(int processDefinitionId, int pageNumber, int pageSize, string? status = null)
        {
            int skip = (pageNumber - 1) * pageSize;

            var query = _context.ProcessRecords
                .Where(pr => pr.ProcessDefinitionId == processDefinitionId);

            if (!string.IsNullOrEmpty(status))
                query = query.Where(pr => pr.RecordStatus == status);

            return await query
                .Include(pr => pr.FieldValues)
                .ThenInclude(fv => fv.ProcessField)
                .OrderByDescending(pr => pr.CreatedDate)
                .Skip(skip)
                .Take(pageSize)
                .ToListAsync();
        }

        public async Task<int> GetTotalRecordsCountAsync(int processDefinitionId, string? status = null)
        {
            var query = _context.ProcessRecords.Where(pr => pr.ProcessDefinitionId == processDefinitionId);

            if (!string.IsNullOrEmpty(status))
                query = query.Where(pr => pr.RecordStatus == status);

            return await query.CountAsync();
        }


        // Repositories/RecordRepository.cs - GetRecordsByProcessDefinitionWithFiltersAsync (CORRECTED)
        // Repositories/RecordRepository.cs - GetRecordsByProcessDefinitionWithFiltersAsync (COMPLETE)
        public async Task<List<ProcessRecord>> GetRecordsByProcessDefinitionWithFiltersAsync(int processDefinitionId, Dictionary<string, object> filters, int pageNumber, int pageSize)
        {
            int skip = (pageNumber - 1) * pageSize;

            var query = _context.ProcessRecords
                .Include(pr => pr.FieldValues)
                .ThenInclude(fv => fv.ProcessField)
                .Where(pr => pr.ProcessDefinitionId == processDefinitionId);

            // Get all process fields for type checking
            var processFields = await _context.ProcessFields
                .Where(pf => pf.ProcessDefinitionId == processDefinitionId)
                .ToListAsync();

            // Parse dates and numbers upfront
            var parsedFilters = new Dictionary<string, (FieldType type, object? value)>();

            foreach (var filter in filters)
            {
                var fieldName = filter.Key;
                var filterValue = filter.Value;

                var processField = processFields.FirstOrDefault(pf => pf.FieldName == fieldName);
                if (processField == null)
                    continue;

                if (processField.FieldType == FieldType.Date || processField.FieldType == FieldType.DateTime)
                {
                    var dateRange = ConvertToDictionary(filterValue);
                    if (dateRange != null)
                    {
                        DateTime.TryParse(dateRange["startDate"]?.ToString(), out var startDate);
                        DateTime.TryParse(dateRange["endDate"]?.ToString(), out var endDate);
                        parsedFilters[fieldName] = (processField.FieldType, new { startDate, endDate });
                    }
                }
                else if (processField.FieldType == FieldType.Number)
                {
                    var numberRange = ConvertToDictionary(filterValue);
                    if (numberRange != null)
                    {
                        decimal.TryParse(numberRange["min"]?.ToString(), out var min);
                        decimal.TryParse(numberRange["max"]?.ToString(), out var max);
                        parsedFilters[fieldName] = (processField.FieldType, new { min, max });
                    }
                }
                else
                {
                    parsedFilters[fieldName] = (processField.FieldType, filterValue);
                }
            }

            // Apply string/dropdown filters at DB level first
            foreach (var parsedFilter in parsedFilters)
            {
                var processField = processFields.FirstOrDefault(pf => pf.FieldName == parsedFilter.Key);
                var (fieldType, value) = parsedFilter.Value;

                if (fieldType == FieldType.Text || fieldType == FieldType.TextArea ||
                    fieldType == FieldType.Email || fieldType == FieldType.Url || fieldType == FieldType.Phone)
                {
                    var searchValue = value?.ToString() ?? "";
                    query = query.Where(pr => pr.FieldValues
                        .Any(fv => fv.ProcessFieldId == processField.Id &&
                             fv.FieldValue.Contains(searchValue)));
                }
                else if (fieldType == FieldType.Dropdown || fieldType == FieldType.Checkbox)
                {
                    var exactValue = value?.ToString() ?? "";
                    query = query.Where(pr => pr.FieldValues
                        .Any(fv => fv.ProcessFieldId == processField.Id &&
                             fv.FieldValue == exactValue));
                }
            }

            // Fetch from DB with ordering
            var allRecords = await query
                .OrderByDescending(pr => pr.CreatedDate)
                .ToListAsync();

            // Apply Date/Number filters in memory (client-side evaluation)
            foreach (var parsedFilter in parsedFilters)
            {
                var processField = processFields.FirstOrDefault(pf => pf.FieldName == parsedFilter.Key);
                var (fieldType, value) = parsedFilter.Value;

                if (fieldType == FieldType.Date || fieldType == FieldType.DateTime)
                {
                    if (value != null)
                    {
                        dynamic dateObj = value;
                        DateTime startDate = dateObj.startDate;
                        DateTime endDate = dateObj.endDate;

                        allRecords = allRecords.Where(pr => pr.FieldValues
                            .Any(fv => fv.ProcessFieldId == processField.Id &&
                                 DateTime.TryParse(fv.FieldValue, out var parsedDate) &&
                                 parsedDate >= startDate && parsedDate <= endDate)).ToList();
                    }
                }
                else if (fieldType == FieldType.Number)
                {
                    if (value != null)
                    {
                        dynamic numObj = value;
                        decimal min = numObj.min;
                        decimal max = numObj.max;

                        allRecords = allRecords.Where(pr => pr.FieldValues
                            .Any(fv => fv.ProcessFieldId == processField.Id &&
                                 decimal.TryParse(fv.FieldValue, out var parsedNum) &&
                                 parsedNum >= min && parsedNum <= max)).ToList();
                    }
                }
            }

            // Apply pagination
            return allRecords.Skip(skip).Take(pageSize).ToList();
        }

        private Dictionary<string, object>? ConvertToDictionary(object? value)
        {
            if (value is Dictionary<string, object> dict)
                return dict;

            if (value is System.Text.Json.JsonElement jsonElement)
            {
                var result = new Dictionary<string, object>();
                foreach (var property in jsonElement.EnumerateObject())
                {
                    result[property.Name] = property.Value;
                }
                return result;
            }

            return null;
        }
        
    }
}