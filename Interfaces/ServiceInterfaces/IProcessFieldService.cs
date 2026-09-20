// Interfaces/ServiceInterfaces/IProcessFieldService.cs
using ProcessTracker.Requests;
using ProcessTracker.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProcessTracker.Interfaces.ServiceInterfaces
{
    public interface IProcessFieldService
    {
        Task<ProcessFieldResponse> CreateProcessFieldAsync(CreateProcessFieldRequest request);
        Task<ProcessFieldResponse> GetProcessFieldAsync(int id);
        Task<List<ProcessFieldResponse>> GetFieldsByProcessDefinitionAsync(int processDefinitionId);
        Task<ProcessFieldResponse> UpdateProcessFieldAsync(int id, UpdateProcessFieldRequest request);
        Task DeleteProcessFieldAsync(int id);
        Task<ProcessFieldResponse> ToggleActiveStatusAsync(int id);
    }
}
