// Repositories/ProcessDefinitionRepository.cs (UPDATED)
using Microsoft.EntityFrameworkCore;
using ProcessTracker.Data;
using ProcessTracker.Entities;
using ProcessTracker.Interfaces.RepositoryInterfaces;

namespace ProcessTracker.Repositories
{
    public class ProcessDefinitionRepository : GenericRepository<ProcessDefinition>, IProcessDefinitionRepository
    {
        public ProcessDefinitionRepository(ApplicationDbContext context) : base(context) { }

        public async Task<ProcessDefinition?> GetProcessDefinitionWithFieldsAsync(int processDefinitionId)
        {
            return await _context.ProcessDefinitions
                .Include(pd => pd.Fields)
                .Include(pd => pd.Records)
                .FirstOrDefaultAsync(pd => pd.Id == processDefinitionId);
        }

        public async Task<bool> HasActiveRecordsAsync(int processDefinitionId)
        {
            return await _context.ProcessRecords
                .AnyAsync(pr => pr.ProcessDefinitionId == processDefinitionId);
        }

        public async Task<List<ProcessDefinition>> GetAllProcessDefinitionsAsync(int pageNumber, int pageSize)
        {
            int skip = (pageNumber - 1) * pageSize;
            return await _context.ProcessDefinitions
                .OrderByDescending(pd => pd.CreatedDate)
                .Skip(skip)
                .Take(pageSize)
                .ToListAsync();
        }

        public async Task<int> GetTotalProcessDefinitionsCountAsync()
        {
            return await _context.ProcessDefinitions.CountAsync();
        }

        public async Task<ProcessDefinition?> GetByCodeAsync(string code)
        {
            return await _context.ProcessDefinitions
                .FirstOrDefaultAsync(pd => pd.Code == code);
        }

        // Repositories/ProcessDefinitionRepository.cs - ADD THESE METHODS
        public async Task<List<ProcessDefinition>> GetAllActiveProcessDefinitionsAsync(int pageNumber, int pageSize)
        {
            int skip = (pageNumber - 1) * pageSize;
            return await _context.ProcessDefinitions
                .Where(pd => pd.IsActive)
                .OrderByDescending(pd => pd.CreatedDate)
                .Skip(skip)
                .Take(pageSize)
                .ToListAsync();
        }

        public async Task<int> GetTotalActiveProcessDefinitionsCountAsync()
        {
            return await _context.ProcessDefinitions.Where(pd => pd.IsActive).CountAsync();
        }
    }
}