// Responses/ApplicationResponse.cs
namespace ProcessTracker.Responses
{
    public class ApplicationResponse
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ProcessCount { get; set; }
    }
}