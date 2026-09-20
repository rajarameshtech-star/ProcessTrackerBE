// Interfaces/ServiceInterfaces/IRecordService.cs
using ProcessTracker.Requests;
using ProcessTracker.Responses;

namespace ProcessTracker.Interfaces.ServiceInterfaces
{
    public interface IRecordService
    {
        Task<RecordResponse> CreateRecordAsync(int processDefinitionId, int applicationId, CreateRecordRequest request);
        Task<RecordResponse> GetRecordAsync(long recordId);
        Task<RecordResponse> UpdateRecordAsync(long recordId, UpdateRecordRequest request);
        Task DeleteRecordAsync(long recordId);
        Task<RecordResponse> SubmitRecordAsync(long recordId, SubmitRecordRequest request);
        Task<PaginatedResponse<RecordResponse>> GetRecordsByProcessAsync(int processDefinitionId, int skip, int take, string? status = null);

        // Interfaces/ServiceInterfaces/IRecordService.cs - ADD THIS METHOD
        Task<PaginatedResponse<RecordResponse>> GetRecordsByProcessWithFiltersAsync(int processDefinitionId, Dictionary<string, object> filters, int pageNumber, int pageSize);
    }
}