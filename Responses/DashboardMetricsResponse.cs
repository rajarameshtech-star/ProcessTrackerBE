// Responses/DashboardMetricsResponse.cs
namespace ProcessTracker.Responses
{
    public class DashboardMetricsResponse
    {
        public int TotalCompletedRecords { get; set; }
        public int TotalPendingRecords { get; set; }
        public int TotalRecords => TotalCompletedRecords + TotalPendingRecords;
        public decimal CompletionRate => TotalRecords == 0 ? 0 : Math.Round((decimal)TotalCompletedRecords / TotalRecords * 100, 2);

        public int ItemsPastDue { get; set; }
        public int ItemsDueToday { get; set; }
        public int ItemsDueThisWeek { get; set; }
        public int UnassignedItems { get; set; }

        public Dictionary<string, int> PriorityCounts { get; set; } = new();
        public List<ProcessMetricsResponse> ProcessMetrics { get; set; } = new();
    }

    public class ProcessMetricsResponse
    {
        public int ProcessDefinitionId { get; set; }
        public string ProcessName { get; set; } = string.Empty;
        public string ProcessCode { get; set; } = string.Empty;
        public int CompletedCount { get; set; }
        public int PendingCount { get; set; }
        public Dictionary<string, int> PriorityHeatmap { get; set; } = new();
    }
}
