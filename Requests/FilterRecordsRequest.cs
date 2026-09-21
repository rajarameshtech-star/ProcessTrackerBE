// Requests/FilterRecordsRequest.cs
namespace ProcessTracker.Requests
{
    public class FilterRecordsRequest
    {
        public string? Priority { get; set; }
        public string? RecordStatus { get; set; }
        public DateTime? ExpectedDueDateStart { get; set; }
        public DateTime? ExpectedDueDateEnd { get; set; }
        public string? AssignedTo { get; set; }
        public Dictionary<string, object> Filters { get; set; } = new();
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 20;
    }
}