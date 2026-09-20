// Controllers/MetricsController.cs
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProcessTracker.Interfaces.ServiceInterfaces;
using ProcessTracker.Responses;
using System.Threading.Tasks;

namespace ProcessTracker.Controllers
{
    [ApiController]
    [Route("api/metrics")]
    public class MetricsController : ControllerBase
    {
        private readonly IMetricsService _metricsService;

        public MetricsController(IMetricsService metricsService)
        {
            _metricsService = metricsService;
        }

        /// <summary>
        /// Retrieves aggregated metrics for the dashboard home page.
        /// </summary>
        /// <param name="applicationId">Optional filter for a specific Application ID.</param>
        /// <returns>Dashboard metrics covering Pending and Completed tasks globally and by process type.</returns>
        [HttpGet("dashboard")]
        [ProducesResponseType(typeof(DashboardMetricsResponse), StatusCodes.Status200OK)]
        public async Task<ActionResult<DashboardMetricsResponse>> GetDashboardMetrics([FromQuery] int? applicationId)
        {
            var response = await _metricsService.GetDashboardMetricsAsync(applicationId);
            return Ok(response);
        }
    }
}
