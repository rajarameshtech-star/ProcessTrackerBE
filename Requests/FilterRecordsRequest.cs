// Requests/FilterRecordsRequest.cs
namespace ProcessTracker.Requests
{
    public class FilterRecordsRequest
    {
        public Dictionary<string, object> Filters { get; set; } = new();
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 20;
    }
}