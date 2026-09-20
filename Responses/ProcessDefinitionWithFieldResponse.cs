// Responses/ProcessDefinitionWithFieldsResponse.cs
namespace ProcessTracker.Responses
{
    public class ProcessDefinitionWithFieldsResponse
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public List<ProcessFieldResponse> Fields { get; set; } = new();
    }
}