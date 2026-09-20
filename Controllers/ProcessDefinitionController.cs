// Controllers/ProcessDefinitionsController.cs
using Microsoft.AspNetCore.Mvc;
using ProcessTracker.Interfaces.ServiceInterfaces;
using ProcessTracker.Requests;
using ProcessTracker.Responses;
using ProcessTracker.Exceptions;

namespace ProcessTracker.Controllers
{
    /// <summary>
    /// API endpoints for managing Process Definitions (templates)
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ProcessDefinitionsController : ControllerBase
    {
        private readonly IProcessDefinitionService _processDefinitionService;

        public ProcessDefinitionsController(IProcessDefinitionService processDefinitionService)
        {
            _processDefinitionService = processDefinitionService;
        }

        /// <summary>
        /// Create a new Process Definition
        /// </summary>
        /// <param name="request">Process Definition creation details (Code, Name, Description)</param>
        /// <returns>Created Process Definition with 201 status</returns>
        /// <response code="201">Process Definition created successfully</response>
        /// <response code="400">Validation failed - Code or Name is missing, or Code already exists</response>
        [HttpPost]
        [ProducesResponseType(typeof(ProcessDefinitionResponse), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ProcessDefinitionResponse>> CreateProcessDefinition([FromBody] CreateProcessDefinitionRequest request)
        {
            try
            {
                var response = await _processDefinitionService.CreateProcessDefinitionAsync(request);
                return CreatedAtAction(nameof(GetProcessDefinition), new { id = response.Id }, response);
            }
            catch (ValidationException ex)
            {
                return BadRequest(new { status = 400, title = "Validation Failed", errors = ex.Errors });
            }
        }

        /// <summary>
        /// Get all Process Definitions with pagination
        /// </summary>
        /// <param name="pageNumber">Page number (default: 1)</param>
        /// <param name="pageSize">Number of records per page (default: 20, max: 100)</param>
        /// <returns>Paginated list of Process Definitions with 200 status</returns>
        /// <response code="200">Process Definitions retrieved successfully</response>
        /// <response code="400">Invalid pagination parameters</response>
        [HttpGet]
        [ProducesResponseType(typeof(PaginatedResponse<ProcessDefinitionResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<PaginatedResponse<ProcessDefinitionResponse>>> GetAllProcessDefinitions([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 20)
        {
            try
            {
                var response = await _processDefinitionService.GetAllProcessDefinitionsAsync(pageNumber, pageSize);
                return Ok(response);
            }
            catch (ValidationException ex)
            {
                return BadRequest(new { status = 400, errors = ex.Errors });
            }
        }

        /// <summary>
        /// Get a specific Process Definition by ID
        /// </summary>
        /// <param name="id">Process Definition ID</param>
        /// <returns>Process Definition details with 200 status</returns>
        /// <response code="200">Process Definition found and returned</response>
        /// <response code="404">Process Definition not found</response>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ProcessDefinitionResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(object), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ProcessDefinitionResponse>> GetProcessDefinition(int id)
        {
            try
            {
                var response = await _processDefinitionService.GetProcessDefinitionAsync(id);
                return Ok(response);
            }
            catch (NotFoundException ex)
            {
                return NotFound(new { status = 404, message = ex.Message });
            }
        }

        /// <summary>
        /// Update a Process Definition
        /// </summary>
        /// <param name="id">Process Definition ID</param>
        /// <param name="request">Updated Process Definition details (Name, Description, IsActive)</param>
        /// <returns>Updated Process Definition with 200 status</returns>
        /// <response code="200">Process Definition updated successfully</response>
        /// <response code="400">Validation failed - Name is missing</response>
        /// <response code="404">Process Definition not found</response>
        [HttpPut("{id}")]
        [ProducesResponseType(typeof(ProcessDefinitionResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(object), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ProcessDefinitionResponse>> UpdateProcessDefinition(int id, [FromBody] UpdateProcessDefinitionRequest request)
        {
            try
            {
                var response = await _processDefinitionService.UpdateProcessDefinitionAsync(id, request);
                return Ok(response);
            }
            catch (NotFoundException ex)
            {
                return NotFound(new { status = 404, message = ex.Message });
            }
            catch (ValidationException ex)
            {
                return BadRequest(new { status = 400, errors = ex.Errors });
            }
        }

        /// <summary>
        /// Delete a Process Definition (only if no records exist)
        /// </summary>
        /// <param name="id">Process Definition ID</param>
        /// <returns>204 No Content on success</returns>
        /// <response code="204">Process Definition deleted successfully</response>
        /// <response code="404">Process Definition not found</response>
        /// <response code="409">Cannot delete - Process Definition has active records</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(object), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(object), StatusCodes.Status409Conflict)]
        public async Task<ActionResult> DeleteProcessDefinition(int id)
        {
            try
            {
                await _processDefinitionService.DeleteProcessDefinitionAsync(id);
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
        /// Toggle the active status of a Process Definition
        /// (Works regardless of whether records exist under it)
        /// </summary>
        /// <param name="id">Process Definition ID</param>
        /// <returns>Updated Process Definition with toggled IsActive status and 200 status</returns>
        /// <response code="200">Process Definition status toggled successfully</response>
        /// <response code="404">Process Definition not found</response>
        [HttpPatch("{id}/toggle-status")]
        [ProducesResponseType(typeof(ProcessDefinitionResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(object), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ProcessDefinitionResponse>> ToggleActiveStatus(int id)
        {
            try
            {
                var response = await _processDefinitionService.ToggleActiveStatusAsync(id);
                return Ok(response);
            }
            catch (NotFoundException ex)
            {
                return NotFound(new { status = 404, message = ex.Message });
            }
        }

        // Controllers/ProcessDefinitionsController.cs - ADD THIS METHOD
        /// <summary>
        /// Get all active Process Definitions with pagination
        /// </summary>
        /// <param name="pageNumber">Page number (default: 1)</param>
        /// <param name="pageSize">Number of records per page (default: 20, max: 100)</param>
        /// <returns>Paginated list of active Process Definitions with 200 status</returns>
        /// <response code="200">Active Process Definitions retrieved successfully</response>
        /// <response code="400">Invalid pagination parameters</response>
        [HttpGet("active")]
        [ProducesResponseType(typeof(PaginatedResponse<ProcessDefinitionResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<PaginatedResponse<ProcessDefinitionResponse>>> GetAllActiveProcessDefinitions([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 20)
        {
            try
            {
                var response = await _processDefinitionService.GetAllActiveProcessDefinitionsAsync(pageNumber, pageSize);
                return Ok(response);
            }
            catch (ValidationException ex)
            {
                return BadRequest(new { status = 400, errors = ex.Errors });
            }
        }
    }
}