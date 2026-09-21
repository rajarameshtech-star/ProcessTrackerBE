// Requests/CreateRecordRequest.cs
namespace ProcessTracker.Requests
{
    public class CreateRecordRequest
    {
        public int ApplicationId { get; set; }
        public string? Priority { get; set; }
        public DateTime? ExpectedDueDate { get; set; }
        public string? AssignedTo { get; set; }
        public Dictionary<string, string> FieldValues { get; set; } = new();
    }
}