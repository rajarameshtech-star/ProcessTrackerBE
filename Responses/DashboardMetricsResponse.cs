// Responses/DashboardMetricsResponse.cs
namespace ProcessTracker.Responses
{
    public class DashboardMetricsResponse
    {
        public int TotalCompletedRecords { get; set; }
        public int TotalPendingRecords { get; set; }
        public List<ProcessMetricsResponse> ProcessMetrics { get; set; } = new();
    }

    public class ProcessMetricsResponse
    {
        public int ProcessDefinitionId { get; set; }
        public string ProcessName { get; set; } = string.Empty;
        public string ProcessCode { get; set; } = string.Empty;
        public int CompletedCount { get; set; }
        public int PendingCount { get; set; }
    }
}
