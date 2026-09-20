// Interfaces/ServiceInterfaces/IProcessDefinitionService.cs
using ProcessTracker.Requests;
using ProcessTracker.Responses;

namespace ProcessTracker.Interfaces.ServiceInterfaces
{
    public interface IProcessDefinitionService
    {
        Task<ProcessDefinitionResponse> CreateProcessDefinitionAsync(CreateProcessDefinitionRequest request);
        Task<ProcessDefinitionResponse> GetProcessDefinitionAsync(int processDefinitionId);
        Task<PaginatedResponse<ProcessDefinitionResponse>> GetAllProcessDefinitionsAsync(int pageNumber, int pageSize);
        Task<ProcessDefinitionResponse> UpdateProcessDefinitionAsync(int processDefinitionId, UpdateProcessDefinitionRequest request);
        Task DeleteProcessDefinitionAsync(int processDefinitionId);
        Task<ProcessDefinitionResponse> ToggleActiveStatusAsync(int processDefinitionId);
        // Interfaces/ServiceInterfaces/IProcessDefinitionService.cs - ADD THIS METHOD
        Task<PaginatedResponse<ProcessDefinitionResponse>> GetAllActiveProcessDefinitionsAsync(int pageNumber, int pageSize);
    }
}