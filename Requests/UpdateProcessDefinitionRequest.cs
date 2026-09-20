// Requests/UpdateProcessDefinitionRequest.cs
namespace ProcessTracker.Requests
{
    public class UpdateProcessDefinitionRequest
    {
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public bool IsActive { get; set; }
    }
}