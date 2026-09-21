// Repositories/ProcessFieldRepository.cs
using Microsoft.EntityFrameworkCore;
using ProcessTracker.Data;
using ProcessTracker.Entities;
using ProcessTracker.Interfaces.RepositoryInterfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessTracker.Repositories
{
    public class ProcessFieldRepository : GenericRepository<ProcessField>, IProcessFieldRepository
    {
        public ProcessFieldRepository(ApplicationDbContext context) : base(context) { }

        public async Task<List<ProcessField>> GetFieldsByProcessDefinitionAsync(int processDefinitionId)
        {
            return await _context.ProcessFields
                .Where(pf => pf.ProcessDefinitionId == processDefinitionId)
                .OrderBy(pf => pf.SortOrder)
                .ToListAsync();
        }

        public async Task<ProcessField?> GetFieldWithDefinitionAsync(int id)
        {
            return await _context.ProcessFields
                .Include(pf => pf.ProcessDefinition)
                .FirstOrDefaultAsync(pf => pf.Id == id);
        }

        public async Task<bool> HasRecordsAssociatedAsync(int fieldId)
        {
            var processField = await GetByIdAsync(fieldId);
            if (processField == null) return false;

            return await _context.ProcessRecords
                .AnyAsync(r => r.FieldValuesJson.Contains($"\"{processField.FieldName}\":"));
        }
    }
}
