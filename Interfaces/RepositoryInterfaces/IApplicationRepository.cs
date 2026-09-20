// Interfaces/RepositoryInterfaces/IApplicationRepository.cs
using ProcessTracker.Entities;

namespace ProcessTracker.Interfaces.RepositoryInterfaces
{
    public interface IApplicationRepository : IGenericRepository<Application>
    {
        Task<Application?> GetApplicationWithRecordsAsync(int applicationId);
        Task<int> GetRecordsCountAsync(int applicationId);
        Task<List<Application>> GetAllApplicationsAsync(int pageNumber, int pageSize);
        Task<int> GetTotalApplicationsCountAsync();
        // Interfaces/RepositoryInterfaces/IApplicationRepository.cs - ADD THIS METHOD
        Task<List<Application>> GetAllActiveApplicationsAsync(int pageNumber, int pageSize);
        Task<int> GetTotalActiveApplicationsCountAsync();
    }
}