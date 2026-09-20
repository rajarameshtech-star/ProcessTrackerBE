// Interfaces/RepositoryInterfaces/IRecordRepository.cs
using ProcessTracker.Entities;

namespace ProcessTracker.Interfaces.RepositoryInterfaces
{
    public interface IRecordRepository : IGenericRepository<ProcessRecord>
    {
        Task<ProcessRecord?> GetRecordWithFieldsAsync(long recordId);
        Task<List<ProcessRecord>> GetRecordsByProcessDefinitionAsync(int processDefinitionId, int skip, int take, string? status = null);
        Task<int> GetTotalRecordsCountAsync(int processDefinitionId, string? status = null);

        // Interfaces/RepositoryInterfaces/IRecordRepository.cs - ADD THIS METHOD
        Task<List<ProcessRecord>> GetRecordsByProcessDefinitionWithFiltersAsync(int processDefinitionId, Dictionary<string, object> filters, int pageNumber, int pageSize);
    }
}