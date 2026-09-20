// Requests/CreateProcessDefinitionRequest.cs
namespace ProcessTracker.Requests
{
    public class CreateProcessDefinitionRequest
    {
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
    }
}