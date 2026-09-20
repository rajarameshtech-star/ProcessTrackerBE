// Controllers/ProcessFieldsController.cs
using Microsoft.AspNetCore.Mvc;
using ProcessTracker.Interfaces.ServiceInterfaces;
using ProcessTracker.Requests;
using ProcessTracker.Responses;
using ProcessTracker.Exceptions;

namespace ProcessTracker.Controllers
{
    [ApiController]
    [Route("api/process-fields")]
    public class ProcessFieldsController : ControllerBase
    {
        private readonly IProcessFieldService _fieldService;

        public ProcessFieldsController(IProcessFieldService fieldService)
        {
            _fieldService = fieldService;
        }

        /// <summary>
        /// Create a new Process Field
        /// </summary>
        /// <param name="request">Process Field data</param>
        /// <returns>Created Process Field</returns>
        [HttpPost]
        [ProducesResponseType(typeof(ProcessFieldResponse), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(object), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ProcessFieldResponse>> CreateProcessField([FromBody] CreateProcessFieldRequest request)
        {
            try
            {
                var response = await _fieldService.CreateProcessFieldAsync(request);
                return CreatedAtAction(nameof(GetProcessField), new { id = response.Id }, response);
            }
            catch (ValidationException ex)
            {
                return BadRequest(new { status = 400, title = "Validation Failed", errors = ex.Errors });
            }
            catch (NotFoundException ex)
            {
                return NotFound(new { status = 404, message = ex.Message });
            }
        }

        /// <summary>
        /// Get a specific Process Field by its ID
        /// </summary>
        /// <param name="id">Process Field ID</param>
        /// <returns>Process Field details</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ProcessFieldResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(object), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ProcessFieldResponse>> GetProcessField([FromRoute] int id)
        {
            try
            {
                var response = await _fieldService.GetProcessFieldAsync(id);
                return Ok(response);
            }
            catch (NotFoundException ex)
            {
                return NotFound(new { status = 404, message = ex.Message });
            }
        }

        /// <summary>
        /// Get all fields for a specific Process Definition
        /// </summary>
        /// <param name="processDefinitionId">Process Definition ID</param>
        /// <returns>List of Process Fields</returns>
        [HttpGet("process/{processDefinitionId}")]
        [ProducesResponseType(typeof(List<ProcessFieldResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(object), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<List<ProcessFieldResponse>>> GetFieldsByProcessDefinition([FromRoute] int processDefinitionId)
        {
            try
            {
                var response = await _fieldService.GetFieldsByProcessDefinitionAsync(processDefinitionId);
                return Ok(response);
            }
            catch (NotFoundException ex)
            {
                return NotFound(new { status = 404, message = ex.Message });
            }
        }

        /// <summary>
        /// Update an existing Process Field
        /// </summary>
        /// <param name="id">Process Field ID</param>
        /// <param name="request">Update data</param>
        /// <returns>Updated Process Field</returns>
        [HttpPut("{id}")]
        [ProducesResponseType(typeof(ProcessFieldResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(object), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ProcessFieldResponse>> UpdateProcessField([FromRoute] int id, [FromBody] UpdateProcessFieldRequest request)
        {
            try
            {
                var response = await _fieldService.UpdateProcessFieldAsync(id, request);
                return Ok(response);
            }
            catch (ValidationException ex)
            {
                return BadRequest(new { status = 400, title = "Validation Failed", errors = ex.Errors });
            }
            catch (NotFoundException ex)
            {
                return NotFound(new { status = 404, message = ex.Message });
            }
        }

        /// <summary>
        /// Delete a Process Field
        /// </summary>
        /// <param name="id">Process Field ID</param>
        /// <returns>No Content</returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(object), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(object), StatusCodes.Status409Conflict)]
        public async Task<ActionResult> DeleteProcessField([FromRoute] int id)
        {
            try
            {
                await _fieldService.DeleteProcessFieldAsync(id);
                return NoContent();
            }
            catch (NotFoundException ex)
            {
                return NotFound(new { status = 404, message = ex.Message });
            }
            catch (InvalidOperationException ex)
            {
                return Conflict(new { status = 409, message = ex.Message });
            }
        }

        /// <summary>
        /// Toggle the active status of a Process Field
        /// </summary>
        /// <param name="id">Process Field ID</param>
        /// <returns>Updated Process Field</returns>
        [HttpPatch("{id}/toggle-status")]
        [ProducesResponseType(typeof(ProcessFieldResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(object), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ProcessFieldResponse>> ToggleActiveStatus([FromRoute] int id)
        {
            try
            {
                var response = await _fieldService.ToggleActiveStatusAsync(id);
                return Ok(response);
            }
            catch (NotFoundException ex)
            {
                return NotFound(new { status = 404, message = ex.Message });
            }
        }
    }
}
