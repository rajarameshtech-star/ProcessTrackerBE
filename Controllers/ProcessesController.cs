// Controllers/ProcessesController.cs
using Microsoft.AspNetCore.Mvc;
using ProcessTracker.Data;
using ProcessTracker.Responses;
using Microsoft.EntityFrameworkCore;

namespace ProcessTracker.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProcessesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProcessesController(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Get a Process by Process Definition ID, including fields
        /// </summary>
        /// <param name="processDefinitionId">The process definition ID</param>
        /// <returns>Process Definition and its fields</returns>
        [HttpGet("{processDefinitionId}")]
        [ProducesResponseType(typeof(ProcessDefinitionWithFieldsResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(object), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ProcessDefinitionWithFieldsResponse>> GetProcessDefinition([FromRoute] int processDefinitionId)
        {
            var process = await _context.ProcessDefinitions
                .Include(pd => pd.Fields)
                .FirstOrDefaultAsync(pd => pd.Id == processDefinitionId && pd.IsActive);

            if (process == null)
                return NotFound(new { message = "Process not found" });

            var response = new ProcessDefinitionWithFieldsResponse
            {
                Id = process.Id,
                Code = process.Code,
                Name = process.Name,
                Description = process.Description,
                IsActive = process.IsActive,
                CreatedDate = process.CreatedDate,
                ModifiedDate = process.ModifiedDate,
                Fields = process.Fields
                    .OrderBy(f => f.SortOrder)
                    .Select(f => new ProcessFieldResponse
                    {
                        Id = f.Id,
                        FieldName = f.FieldName,
                        Label = f.Label,
                        FieldType = f.FieldType,
                        IsRequired = f.IsRequired,
                        SortOrder = f.SortOrder,
                        Placeholder = f.Placeholder,
                        DefaultValue = f.DefaultValue,
                        OptionsJson = f.OptionsJson,
                        MinLength = f.MinLength,
                        MaxLength = f.MaxLength,
                        Min = f.Min,
                        Max = f.Max,
                        Pattern = f.Pattern
                    })
                    .ToList()
            };

            return Ok(response);
        }
    }
}