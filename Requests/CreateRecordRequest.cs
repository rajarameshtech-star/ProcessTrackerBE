// Requests/CreateRecordRequest.cs
namespace ProcessTracker.Requests
{
    public class CreateRecordRequest
    {
        public Dictionary<string, string> FieldValues { get; set; } = new();
    }
}