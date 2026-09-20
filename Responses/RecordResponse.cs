// Responses/RecordResponse.cs
namespace ProcessTracker.Responses
{
    public class RecordResponse
    {
        public long Id { get; set; }
        public int ApplicationId { get; set; }
        public int ProcessDefinitionId { get; set; }
        public string RecordStatus { get; set; }
        public string? RecordNumber { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime? SubmittedDate { get; set; }
        public string? Notes { get; set; }
        public Dictionary<string, string?> FieldValues { get; set; } = new();
    }
}