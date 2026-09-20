// Controllers/ApplicationsController.cs
using Microsoft.AspNetCore.Mvc;
using ProcessTracker.Interfaces.ServiceInterfaces;
using ProcessTracker.Requests;
using ProcessTracker.Responses;
using ProcessTracker.Exceptions;

namespace ProcessTracker.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApplicationsController : ControllerBase
    {
        private readonly IApplicationService _applicationService;

        public ApplicationsController(IApplicationService applicationService)
        {
            _applicationService = applicationService;
        }

        /// <summary>
        /// Create a new Application
        /// </summary>
        /// <param name="request">Application details</param>
        /// <returns>Created application</returns>
        [HttpPost]
        [ProducesResponseType(typeof(ApplicationResponse), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ApplicationResponse>> CreateApplication([FromBody] CreateApplicationRequest request)
        {
            try
            {
                var response = await _applicationService.CreateApplicationAsync(request);
                return CreatedAtAction(nameof(GetApplication), new { id = response.Id }, response);
            }
            catch (ValidationException ex)
            {
                return BadRequest(new { status = 400, title = "Validation Failed", errors = ex.Errors });
            }
        }

        /// <summary>
        /// Get all Applications with pagination
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Paginated response of applications</returns>
        [HttpGet]
        [ProducesResponseType(typeof(PaginatedResponse<ApplicationResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<PaginatedResponse<ApplicationResponse>>> GetAllApplications([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 20)
        {
            try
            {
                var response = await _applicationService.GetAllApplicationsAsync(pageNumber, pageSize);
                return Ok(response);
            }
            catch (ValidationException ex)
            {
                return BadRequest(new { status = 400, errors = ex.Errors });
            }
        }

        /// <summary>
        /// Get a specific Application by ID
        /// </summary>
        /// <param name="id">Application ID</param>
        /// <returns>Application details</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ApplicationResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(object), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ApplicationResponse>> GetApplication([FromRoute] int id)
        {
            try
            {
                var response = await _applicationService.GetApplicationAsync(id);
                return Ok(response);
            }
            catch (NotFoundException ex)
            {
                return NotFound(new { status = 404, message = ex.Message });
            }
        }

        /// <summary>
        /// Update an Application
        /// </summary>
        /// <param name="id">Application ID</param>
        /// <param name="request">Update request details</param>
        /// <returns>Updated Application</returns>
        [HttpPut("{id}")]
        [ProducesResponseType(typeof(ApplicationResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(object), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ApplicationResponse>> UpdateApplication([FromRoute] int id, [FromBody] UpdateApplicationRequest request)
        {
            try
            {
                var response = await _applicationService.UpdateApplicationAsync(id, request);
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
        /// Delete an Application
        /// </summary>
        /// <param name="id">Application ID</param>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(object), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(object), StatusCodes.Status409Conflict)]
        public async Task<ActionResult> DeleteApplication([FromRoute] int id)
        {
            try
            {
                await _applicationService.DeleteApplicationAsync(id);
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
        /// Toggle the active status of an Application
        /// </summary>
        /// <param name="id">Application ID</param>
        /// <returns>Updated application status</returns>
        [HttpPatch("{id}/toggle-status")]
        [ProducesResponseType(typeof(ApplicationResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(object), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ApplicationResponse>> ToggleActiveStatus([FromRoute] int id)
        {
            try
            {
                var response = await _applicationService.ToggleActiveStatusAsync(id);
                return Ok(response);
            }
            catch (NotFoundException ex)
            {
                return NotFound(new { status = 404, message = ex.Message });
            }
        }

        // Controllers/ApplicationsController.cs - ADD THIS METHOD
        /// <summary>
        /// Get all active Applications with pagination
        /// </summary>
        /// <param name="pageNumber">Page number (default: 1)</param>
        /// <param name="pageSize">Number of records per page (default: 20, max: 100)</param>
        /// <returns>Paginated list of active Applications with 200 status</returns>
        /// <response code="200">Active Applications retrieved successfully</response>
        /// <response code="400">Invalid pagination parameters</response>
        [HttpGet("active")]
        [ProducesResponseType(typeof(PaginatedResponse<ApplicationResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<PaginatedResponse<ApplicationResponse>>> GetAllActiveApplications([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 20)
        {
            try
            {
                var response = await _applicationService.GetAllActiveApplicationsAsync(pageNumber, pageSize);
                return Ok(response);
            }
            catch (ValidationException ex)
            {
                return BadRequest(new { status = 400, errors = ex.Errors });
            }
        }
    }
}