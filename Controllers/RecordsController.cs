// Controllers/RecordsController.cs
using Microsoft.AspNetCore.Mvc;
using ProcessTracker.Interfaces.ServiceInterfaces;
using ProcessTracker.Requests;
using ProcessTracker.Responses;
using ProcessTracker.Exceptions;

namespace ProcessTracker.Controllers
{
    [ApiController]
    [Route("api/processes/{processDefinitionId}/records")]
    public class RecordsController : ControllerBase
    {
        private readonly IRecordService _recordService;

        public RecordsController(IRecordService recordService)
        {
            _recordService = recordService;
        }

        /// <summary>
        /// Create a new Record for a specific Process Definition
        /// </summary>
        /// <param name="processDefinitionId">Process Definition ID</param>
        /// <param name="request">Record data</param>
        /// <returns>Created Record</returns>
        [HttpPost]
        [ProducesResponseType(typeof(RecordResponse), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<RecordResponse>> CreateRecord([FromRoute] int processDefinitionId, [FromBody] CreateRecordRequest request)
        {
            try
            {
                var applicationId = request.ApplicationId;
                var response = await _recordService.CreateRecordAsync(processDefinitionId, applicationId, request);
                return CreatedAtAction(nameof(GetRecord), new { processDefinitionId, recordId = response.Id }, response);
            }
            catch (ValidationException ex)
            {
                return BadRequest(new { status = 400, title = "Validation Failed", errors = ex.Errors });
            }
        }

        /// <summary>
        /// Get a specific Record by its ID
        /// </summary>
        /// <param name="processDefinitionId">Process Definition ID</param>
        /// <param name="recordId">Record ID</param>
        /// <returns>Record data</returns>
        [HttpGet("{recordId}")]
        [ProducesResponseType(typeof(RecordResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(object), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<RecordResponse>> GetRecord([FromRoute] int processDefinitionId, [FromRoute] long recordId)
        {
            try
            {
                var response = await _recordService.GetRecordAsync(recordId);
                return Ok(response);
            }
            catch (NotFoundException ex)
            {
                return NotFound(new { status = 404, message = ex.Message });
            }
        }

        /// <summary>
        /// Get all records for a process, paginated
        /// </summary>
        /// <param name="processDefinitionId">Process Definition ID</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="status">Optional status filter</param>
        /// <returns>Paginated records</returns>
        [HttpGet]
        [ProducesResponseType(typeof(PaginatedResponse<RecordResponse>), StatusCodes.Status200OK)]
        public async Task<ActionResult<PaginatedResponse<RecordResponse>>> GetRecords([FromRoute] int processDefinitionId, [FromQuery] int pageNumber = 0, [FromQuery] int pageSize = 20, [FromQuery] string? status = null)
        {
            var response = await _recordService.GetRecordsByProcessAsync(processDefinitionId, pageNumber, pageSize, status);
            return Ok(response);
        }

        /// <summary>
        /// Update an existing record
        /// </summary>
        /// <param name="processDefinitionId">Process Definition ID</param>
        /// <param name="recordId">Record ID</param>
        /// <param name="request">Update data</param>
        /// <returns>Updated record</returns>
        [HttpPut("{recordId}")]
        [ProducesResponseType(typeof(RecordResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(object), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(object), StatusCodes.Status409Conflict)]
        public async Task<ActionResult<RecordResponse>> UpdateRecord([FromRoute] int processDefinitionId, [FromRoute] long recordId, [FromBody] UpdateRecordRequest request)
        {
            try
            {
                var response = await _recordService.UpdateRecordAsync(recordId, request);
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
            catch (InvalidOperationException ex)
            {
                return Conflict(new { status = 409, message = ex.Message });
            }
        }

        /// <summary>
        /// Delete a specific record
        /// </summary>
        /// <param name="processDefinitionId">Process Definition ID</param>
        /// <param name="recordId">Record ID</param>
        [HttpDelete("{recordId}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(object), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(object), StatusCodes.Status409Conflict)]
        public async Task<ActionResult> DeleteRecord([FromRoute] int processDefinitionId, [FromRoute] long recordId)
        {
            try
            {
                await _recordService.DeleteRecordAsync(recordId);
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
        /// Change record status to Submitted
        /// </summary>
        /// <param name="processDefinitionId">Process Definition ID</param>
        /// <param name="recordId">Record ID</param>
        /// <param name="request">Submission payload</param>
        /// <returns>Submitted Record</returns>
        [HttpPost("{recordId}/submit")]
        [ProducesResponseType(typeof(RecordResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(object), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(object), StatusCodes.Status409Conflict)]
        public async Task<ActionResult<RecordResponse>> SubmitRecord([FromRoute] int processDefinitionId, [FromRoute] long recordId, [FromBody] SubmitRecordRequest request)
        {
            try
            {
                var response = await _recordService.SubmitRecordAsync(recordId, request);
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
            catch (InvalidOperationException ex)
            {
                return Conflict(new { status = 409, message = ex.Message });
            }
        }

        // Controllers/RecordsController.cs - ADD THIS METHOD
        /// <summary>
        /// Search records with complex filters
        /// </summary>
        /// <param name="processDefinitionId">Process Definition ID</param>
        /// <param name="applicationId">Optional Application ID filter</param>
        /// <param name="request">Filter criteria</param>
        /// <returns>Filtered records</returns>
        [HttpPost("search")]
        [ProducesResponseType(typeof(PaginatedResponse<RecordResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<PaginatedResponse<RecordResponse>>> SearchRecords(
            [FromRoute] int processDefinitionId,
            [FromQuery] int? applicationId,
            [FromBody] FilterRecordsRequest request)
        {
            if (request.PageNumber < 1)
                return BadRequest(new { message = "PageNumber must be greater than 0" });

            if (request.PageSize < 1 || request.PageSize > 100)
                return BadRequest(new { message = "PageSize must be between 1 and 100" });

            if (!string.IsNullOrEmpty(request.Priority))
                request.Filters["Priority"] = request.Priority;

            if (!string.IsNullOrEmpty(request.RecordStatus))
                request.Filters["RecordStatus"] = request.RecordStatus;

            if (!string.IsNullOrEmpty(request.AssignedTo))
                request.Filters["AssignedTo"] = request.AssignedTo;

            if (request.ExpectedDueDateStart.HasValue || request.ExpectedDueDateEnd.HasValue)
            {
                var dates = new Dictionary<string, string>();
                if (request.ExpectedDueDateStart.HasValue) dates["startDate"] = request.ExpectedDueDateStart.Value.ToString("o");
                if (request.ExpectedDueDateEnd.HasValue) dates["endDate"] = request.ExpectedDueDateEnd.Value.ToString("o");
                request.Filters["ExpectedDueDate"] = dates;
            }

            var response = await _recordService.GetRecordsByProcessWithFiltersAsync(
                processDefinitionId,
                applicationId,
                request.Filters,
                request.PageNumber,
                request.PageSize);

            return Ok(response);
        }

        /// <summary>
        /// Get available priority options
        /// </summary>
        /// <returns>List of Priority strings</returns>
        [HttpGet("priorities")]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status200OK)]
        public ActionResult<List<string>> GetPriorities()
        {
            var priorities = Enum.GetNames(typeof(ProcessTracker.Entities.PriorityLevel)).ToList();
            return Ok(priorities);
        }
    }
}