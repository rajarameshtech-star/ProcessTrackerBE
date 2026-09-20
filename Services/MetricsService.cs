// Services/MetricsService.cs
using Microsoft.EntityFrameworkCore;
using ProcessTracker.Data;
using ProcessTracker.Interfaces.ServiceInterfaces;
using ProcessTracker.Responses;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ProcessTracker.Services
{
    public class MetricsService : IMetricsService
    {
        private readonly ApplicationDbContext _context;

        public MetricsService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<DashboardMetricsResponse> GetDashboardMetricsAsync(int? applicationId = null)
        {
            var recordsQuery = _context.ProcessRecords.AsQueryable();

            if (applicationId.HasValue)
            {
                recordsQuery = recordsQuery.Where(r => r.ApplicationId == applicationId.Value);
            }

            var totalCompleted = await recordsQuery.CountAsync(r => r.RecordStatus == "Submitted");
            var totalPending = await recordsQuery.CountAsync(r => r.RecordStatus == "Draft");

            // Fetch grouped metrics by process definition
            var processStats = await recordsQuery
                .GroupBy(r => new { r.ProcessDefinitionId, r.RecordStatus })
                .Select(g => new 
                {
                    ProcessDefinitionId = g.Key.ProcessDefinitionId,
                    Status = g.Key.RecordStatus,
                    Count = g.Count()
                })
                .ToListAsync();

            var processDefinitions = await _context.ProcessDefinitions
                .Select(p => new { p.Id, p.Name, p.Code })
                .ToListAsync();

            var processMetrics = new List<ProcessMetricsResponse>();

            foreach (var pd in processDefinitions)
            {
                var metric = new ProcessMetricsResponse
                {
                    ProcessDefinitionId = pd.Id,
                    ProcessName = pd.Name,
                    ProcessCode = pd.Code,
                    CompletedCount = processStats.Where(ps => ps.ProcessDefinitionId == pd.Id && ps.Status == "Submitted").Sum(ps => ps.Count),
                    PendingCount = processStats.Where(ps => ps.ProcessDefinitionId == pd.Id && ps.Status == "Draft").Sum(ps => ps.Count)
                };

                processMetrics.Add(metric);
            }

            return new DashboardMetricsResponse
            {
                TotalCompletedRecords = totalCompleted,
                TotalPendingRecords = totalPending,
                ProcessMetrics = processMetrics
            };
        }
    }
}
