// Interfaces/ServiceInterfaces/IApplicationService.cs
using ProcessTracker.Requests;
using ProcessTracker.Responses;

namespace ProcessTracker.Interfaces.ServiceInterfaces
{
    public interface IApplicationService
    {
        Task<ApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request);
        Task<ApplicationResponse> GetApplicationAsync(int applicationId);
        Task<PaginatedResponse<ApplicationResponse>> GetAllApplicationsAsync(int pageNumber, int pageSize);
        Task<ApplicationResponse> UpdateApplicationAsync(int applicationId, UpdateApplicationRequest request);
        Task DeleteApplicationAsync(int applicationId);
        Task<ApplicationResponse> ToggleActiveStatusAsync(int applicationId);
        // Interfaces/ServiceInterfaces/IApplicationService.cs - ADD THIS METHOD
        Task<PaginatedResponse<ApplicationResponse>> GetAllActiveApplicationsAsync(int pageNumber, int pageSize);
    }
}