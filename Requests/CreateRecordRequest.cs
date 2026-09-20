// Requests/CreateRecordRequest.cs
namespace ProcessTracker.Requests
{
    public class CreateRecordRequest
    {
        public int ApplicationId { get; set; }
        public Dictionary<string, string> FieldValues { get; set; } = new();
    }
}