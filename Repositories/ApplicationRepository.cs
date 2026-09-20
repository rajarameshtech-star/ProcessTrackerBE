// Repositories/ApplicationRepository.cs
using Microsoft.EntityFrameworkCore;
using ProcessTracker.Data;
using ProcessTracker.Entities;
using ProcessTracker.Interfaces.RepositoryInterfaces;

namespace ProcessTracker.Repositories
{
    public class ApplicationRepository : GenericRepository<Application>, IApplicationRepository
    {
        public ApplicationRepository(ApplicationDbContext context) : base(context) { }

        public async Task<Application?> GetApplicationWithRecordsAsync(int applicationId)
        {
            return await _context.Applications
                .Include(a => a.ProcessRecords)
                .FirstOrDefaultAsync(a => a.Id == applicationId);
        }

        public async Task<int> GetRecordsCountAsync(int applicationId)
        {
            return await _context.ProcessRecords
                .Where(pr => pr.ApplicationId == applicationId)
                .CountAsync();
        }

        public async Task<List<Application>> GetAllApplicationsAsync(int pageNumber, int pageSize)
        {
            int skip = (pageNumber - 1) * pageSize;
            return await _context.Applications
                .OrderByDescending(a => a.CreatedDate)
                .Skip(skip)
                .Take(pageSize)
                .ToListAsync();
        }

        public async Task<int> GetTotalApplicationsCountAsync()
        {
            return await _context.Applications.CountAsync();
        }

        // Repositories/ApplicationRepository.cs - ADD THESE METHODS
        public async Task<List<Application>> GetAllActiveApplicationsAsync(int pageNumber, int pageSize)
        {
            int skip = (pageNumber - 1) * pageSize;
            return await _context.Applications
                .Where(a => a.IsActive)
                .OrderByDescending(a => a.CreatedDate)
                .Skip(skip)
                .Take(pageSize)
                .ToListAsync();
        }

        public async Task<int> GetTotalActiveApplicationsCountAsync()
        {
            return await _context.Applications.Where(a => a.IsActive).CountAsync();
        }
    }
}