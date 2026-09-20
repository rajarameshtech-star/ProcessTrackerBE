// Requests/UpdateApplicationRequest.cs
namespace ProcessTracker.Requests
{
    public class UpdateApplicationRequest
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsActive { get; set; }
    }
}