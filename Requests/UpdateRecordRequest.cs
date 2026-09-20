// Requests/UpdateRecordRequest.cs
namespace ProcessTracker.Requests
{
    public class UpdateRecordRequest
    {
        public Dictionary<string, string> FieldValues { get; set; } = new();
        public string? Notes { get; set; }
    }
}