// Services/RecordService.cs
using ProcessTracker.Data;
using ProcessTracker.Entities;
using ProcessTracker.Exceptions;
using ProcessTracker.Interfaces.RepositoryInterfaces;
using ProcessTracker.Interfaces.ServiceInterfaces;
using ProcessTracker.Requests;
using ProcessTracker.Responses;
using Microsoft.EntityFrameworkCore;

namespace ProcessTracker.Services
{
    public class RecordService : IRecordService
    {
        private readonly IRecordRepository _recordRepository;
        private readonly IValidationService _validationService;
        private readonly ApplicationDbContext _context;

        public RecordService(IRecordRepository recordRepository, IValidationService validationService, ApplicationDbContext context)
        {
            _recordRepository = recordRepository;
            _validationService = validationService;
            _context = context;
        }

        // Services/RecordService.cs - Update CreateRecordAsync (UPDATED)
        public async Task<RecordResponse> CreateRecordAsync(int processDefinitionId, int applicationId, CreateRecordRequest request)
        {
            // Check if Application is active
            var application = await _context.Applications.FindAsync(applicationId);
            if (application == null)
                throw new NotFoundException($"Application with ID {applicationId} not found");

            if (!application.IsActive)
                throw new InvalidOperationException("Cannot create record in an inactive Application");

            // Check if ProcessDefinition is active
            var processDefinition = await _context.ProcessDefinitions.FindAsync(processDefinitionId);
            if (processDefinition == null)
                throw new NotFoundException($"Process Definition with ID {processDefinitionId} not found");

            if (!processDefinition.IsActive)
                throw new InvalidOperationException("Cannot create record for an inactive Process Definition");

            var errors = await _validationService.ValidateRecordAsync(processDefinitionId, request.FieldValues);
            if (errors.Count > 0)
                throw new ValidationException(errors);

            var record = new ProcessRecord
            {
                ApplicationId = applicationId,
                ProcessDefinitionId = processDefinitionId,
                RecordStatus = "Draft",
                RecordNumber = GenerateRecordNumber(),
                CreatedDate = DateTime.UtcNow,
                ModifiedDate = DateTime.UtcNow
            };

            await _recordRepository.AddAsync(record);
            await _recordRepository.SaveChangesAsync();

            var fieldValues = new List<ProcessRecordFieldValue>();
            foreach (var fieldValue in request.FieldValues)
            {
                fieldValues.Add(new ProcessRecordFieldValue
                {
                    ProcessRecordId = record.Id,
                    ProcessFieldId = await GetProcessFieldIdAsync(processDefinitionId, fieldValue.Key),
                    FieldValue = fieldValue.Value,
                    CreatedDate = DateTime.UtcNow,
                    ModifiedDate = DateTime.UtcNow
                });
            }

            await _context.ProcessRecordFieldValues.AddRangeAsync(fieldValues);
            await _recordRepository.SaveChangesAsync();

            return MapToResponse(record, request.FieldValues);
        }


        public async Task<RecordResponse> GetRecordAsync(long recordId)
        {
            var record = await _recordRepository.GetRecordWithFieldsAsync(recordId);
            if (record == null)
                throw new NotFoundException($"Record with ID {recordId} not found");

            var fieldValues = record.FieldValues.ToDictionary(fv => fv.ProcessField.FieldName, fv => fv.FieldValue);
            return MapToResponse(record, fieldValues);
        }

        public async Task<RecordResponse> UpdateRecordAsync(long recordId, UpdateRecordRequest request)
        {
            var record = await _recordRepository.GetByIdAsync(recordId);
            if (record == null)
                throw new NotFoundException($"Record with ID {recordId} not found");

            if (record.RecordStatus != "Draft")
                throw new InvalidOperationException("Cannot update record in non-Draft status");

            var errors = await _validationService.ValidateRecordAsync(record.ProcessDefinitionId, request.FieldValues);
            if (errors.Count > 0)
                throw new ValidationException(errors);

            record.ModifiedDate = DateTime.UtcNow;
            if (!string.IsNullOrEmpty(request.Notes))
                record.Notes = request.Notes;

            _recordRepository.Update(record);

            var existingFieldValues = _context.ProcessRecordFieldValues
                .Where(pfv => pfv.ProcessRecordId == recordId)
                .ToList();

            foreach (var fieldValue in request.FieldValues)
            {
                var processFieldId = await GetProcessFieldIdAsync(record.ProcessDefinitionId, fieldValue.Key);
                var existing = existingFieldValues.FirstOrDefault(fv => fv.ProcessFieldId == processFieldId);

                if (existing != null)
                {
                    existing.FieldValue = fieldValue.Value;
                    existing.ModifiedDate = DateTime.UtcNow;
                }
                else
                {
                    await _context.ProcessRecordFieldValues.AddAsync(new ProcessRecordFieldValue
                    {
                        ProcessRecordId = recordId,
                        ProcessFieldId = processFieldId,
                        FieldValue = fieldValue.Value,
                        CreatedDate = DateTime.UtcNow,
                        ModifiedDate = DateTime.UtcNow
                    });
                }
            }

            await _recordRepository.SaveChangesAsync();

            var updatedRecord = await _recordRepository.GetRecordWithFieldsAsync(recordId);
            var fieldValuesDict = updatedRecord.FieldValues.ToDictionary(fv => fv.ProcessField.FieldName, fv => fv.FieldValue);
            return MapToResponse(updatedRecord, fieldValuesDict);
        }

        public async Task DeleteRecordAsync(long recordId)
        {
            var record = await _recordRepository.GetByIdAsync(recordId);
            if (record == null)
                throw new NotFoundException($"Record with ID {recordId} not found");

            if (record.RecordStatus != "Draft")
                throw new InvalidOperationException("Cannot delete non-Draft record");

            _recordRepository.Delete(record);
            await _recordRepository.SaveChangesAsync();
        }

        public async Task<RecordResponse> SubmitRecordAsync(long recordId, SubmitRecordRequest request)
        {
            var record = await _recordRepository.GetRecordWithFieldsAsync(recordId);
            if (record == null)
                throw new NotFoundException($"Record with ID {recordId} not found");

            if (record.RecordStatus != "Draft")
                throw new InvalidOperationException("Only Draft records can be submitted");

            var fieldValues = record.FieldValues.ToDictionary(fv => fv.ProcessField.FieldName, fv => fv.FieldValue);
            var errors = await _validationService.ValidateRecordAsync(record.ProcessDefinitionId, fieldValues, isSubmit: true);

            if (errors.Count > 0)
                throw new ValidationException(errors);

            record.RecordStatus = "Submitted";
            record.SubmittedDate = DateTime.UtcNow;
            record.ModifiedDate = DateTime.UtcNow;
            if (!string.IsNullOrEmpty(request.Notes))
                record.Notes = request.Notes;

            _recordRepository.Update(record);
            await _recordRepository.SaveChangesAsync();

            return MapToResponse(record, fieldValues);
        }

        // Services/RecordService.cs - Updated Method
        public async Task<PaginatedResponse<RecordResponse>> GetRecordsByProcessAsync(int processDefinitionId, int pageNumber, int pageSize, string? status = null)
        {
            var records = await _recordRepository.GetRecordsByProcessDefinitionAsync(processDefinitionId, pageNumber, pageSize, status);
            var totalCount = await _recordRepository.GetTotalRecordsCountAsync(processDefinitionId, null, status);

            var responses = records.Select(r =>
            {
                var fieldValues = r.FieldValues.ToDictionary(fv => fv.ProcessField.FieldName, fv => fv.FieldValue);
                return MapToResponse(r, fieldValues);
            }).ToList();

            int pageCount = (int)Math.Ceiling(totalCount / (double)pageSize);

            return new PaginatedResponse<RecordResponse>
            {
                PageNumber = pageNumber,
                PageSize = pageSize,
                TotalCount = totalCount,
                PageCount = pageCount,
                Records = responses
            };
        }

        private RecordResponse MapToResponse(ProcessRecord record, Dictionary<string, string?> fieldValues)
        {
            return new RecordResponse
            {
                Id = record.Id,
                ApplicationId = record.ApplicationId,
                ProcessDefinitionId = record.ProcessDefinitionId,
                RecordStatus = record.RecordStatus,
                RecordNumber = record.RecordNumber,
                CreatedDate = record.CreatedDate,
                ModifiedDate = record.ModifiedDate,
                SubmittedDate = record.SubmittedDate,
                Notes = record.Notes,
                FieldValues = fieldValues
            };
        }

        private async Task<int> GetProcessFieldIdAsync(int processDefinitionId, string fieldName)
        {
            var field = await _context.ProcessFields
                .FirstOrDefaultAsync(pf => pf.ProcessDefinitionId == processDefinitionId && pf.FieldName == fieldName);

            if (field == null)
                throw new NotFoundException($"Field '{fieldName}' not found in process");

            return field.Id;
        }

        private string GenerateRecordNumber()
        {
            return $"REC-{DateTime.UtcNow:yyyyMMdd}-{Guid.NewGuid().ToString().Substring(0, 8).ToUpper()}";
        }

        // Services/RecordService.cs - ADD THIS METHOD
        public async Task<PaginatedResponse<RecordResponse>> GetRecordsByProcessWithFiltersAsync(int processDefinitionId, int? applicationId, Dictionary<string, object> filters, int pageNumber, int pageSize)
        {
            var records = await _recordRepository.GetRecordsByProcessDefinitionWithFiltersAsync(processDefinitionId, applicationId, filters, pageNumber, pageSize);
            var totalCount = await _recordRepository.GetTotalRecordsCountAsync(processDefinitionId, applicationId, null);

            var responses = records.Select(r =>
            {
                var fieldValues = r.FieldValues.ToDictionary(fv => fv.ProcessField.FieldName, fv => fv.FieldValue);
                return MapToResponse(r, fieldValues);
            }).ToList();

            int pageCount = (int)Math.Ceiling(totalCount / (double)pageSize);

            return new PaginatedResponse<RecordResponse>
            {
                PageNumber = pageNumber,
                PageSize = pageSize,
                TotalCount = totalCount,
                PageCount = pageCount,
                Records = responses
            };
        }
    }
}