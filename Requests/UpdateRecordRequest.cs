// Requests/UpdateRecordRequest.cs
namespace ProcessTracker.Requests
{
    public class UpdateRecordRequest
    {
        public string? Priority { get; set; }
        public DateTime? ExpectedDueDate { get; set; }
        public string? AssignedTo { get; set; }
        public Dictionary<string, string> FieldValues { get; set; } = new();
        public string? Notes { get; set; }
    }
}