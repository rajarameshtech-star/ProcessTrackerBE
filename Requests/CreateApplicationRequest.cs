// Requests/CreateApplicationRequest.cs
namespace ProcessTracker.Requests
{
    public class CreateApplicationRequest
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}