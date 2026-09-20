// Responses/PaginatedResponse.cs
namespace ProcessTracker.Responses
{
    public class PaginatedResponse<T>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public int PageCount { get; set; }
        public List<T> Records { get; set; } = new();
    }
}