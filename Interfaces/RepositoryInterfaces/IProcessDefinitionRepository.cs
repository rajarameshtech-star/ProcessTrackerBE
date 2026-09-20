// Interfaces/RepositoryInterfaces/IProcessDefinitionRepository.cs (UPDATED)
using ProcessTracker.Entities;

namespace ProcessTracker.Interfaces.RepositoryInterfaces
{
    public interface IProcessDefinitionRepository : IGenericRepository<ProcessDefinition>
    {
        Task<ProcessDefinition?> GetProcessDefinitionWithFieldsAsync(int processDefinitionId);
        Task<bool> HasActiveRecordsAsync(int processDefinitionId);
        Task<List<ProcessDefinition>> GetAllProcessDefinitionsAsync(int pageNumber, int pageSize);
        Task<int> GetTotalProcessDefinitionsCountAsync();
        Task<ProcessDefinition?> GetByCodeAsync(string code);

        // Interfaces/RepositoryInterfaces/IProcessDefinitionRepository.cs - ADD THESE METHODS
        Task<List<ProcessDefinition>> GetAllActiveProcessDefinitionsAsync(int pageNumber, int pageSize);
        Task<int> GetTotalActiveProcessDefinitionsCountAsync();
    }
}