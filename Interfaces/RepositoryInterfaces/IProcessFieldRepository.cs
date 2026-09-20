// Interfaces/RepositoryInterfaces/IProcessFieldRepository.cs
using ProcessTracker.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProcessTracker.Interfaces.RepositoryInterfaces
{
    public interface IProcessFieldRepository : IGenericRepository<ProcessField>
    {
        Task<List<ProcessField>> GetFieldsByProcessDefinitionAsync(int processDefinitionId);
        Task<ProcessField?> GetFieldWithDefinitionAsync(int id);
        Task<bool> HasRecordsAssociatedAsync(int fieldId);
    }
}
