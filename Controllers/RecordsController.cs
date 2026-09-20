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

        [HttpPost]
        public async Task<ActionResult<RecordResponse>> CreateRecord(int processDefinitionId, [FromBody] CreateRecordRequest request)
        {
            try
            {
                var applicationId = 1; // TODO: Get from context/user
                var response = await _recordService.CreateRecordAsync(processDefinitionId, applicationId, request);
                return CreatedAtAction(nameof(GetRecord), new { processDefinitionId, recordId = response.Id }, response);
            }
            catch (ValidationException ex)
            {
                return BadRequest(new { status = 400, title = "Validation Failed", errors = ex.Errors });
            }
        }

        [HttpGet("{recordId}")]
        public async Task<ActionResult<RecordResponse>> GetRecord(int processDefinitionId, long recordId)
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

        [HttpGet]
        public async Task<ActionResult<PaginatedResponse<RecordResponse>>> GetRecords(int processDefinitionId, [FromQuery] int pageNumber = 0, [FromQuery] int pageSize = 20, [FromQuery] string? status = null)
        {
            var response = await _recordService.GetRecordsByProcessAsync(processDefinitionId, pageNumber, pageSize, status);
            return Ok(response);
        }

        [HttpPut("{recordId}")]
        public async Task<ActionResult<RecordResponse>> UpdateRecord(int processDefinitionId, long recordId, [FromBody] UpdateRecordRequest request)
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

        [HttpDelete("{recordId}")]
        public async Task<ActionResult> DeleteRecord(int processDefinitionId, long recordId)
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

        [HttpPost("{recordId}/submit")]
        public async Task<ActionResult<RecordResponse>> SubmitRecord(int processDefinitionId, long recordId, [FromBody] SubmitRecordRequest request)
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
        [HttpPost("search")]
        public async Task<ActionResult<PaginatedResponse<RecordResponse>>> SearchRecords(
            int processDefinitionId,
            [FromBody] FilterRecordsRequest request)
        {
            if (request.PageNumber < 1)
                return BadRequest(new { message = "PageNumber must be greater than 0" });

            if (request.PageSize < 1 || request.PageSize > 100)
                return BadRequest(new { message = "PageSize must be between 1 and 100" });

            var response = await _recordService.GetRecordsByProcessWithFiltersAsync(
                processDefinitionId,
                request.Filters,
                request.PageNumber,
                request.PageSize);

            return Ok(response);
        }
    }
}