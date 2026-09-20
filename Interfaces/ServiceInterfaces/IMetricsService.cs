// Interfaces/ServiceInterfaces/IMetricsService.cs
using ProcessTracker.Responses;
using System.Threading.Tasks;

namespace ProcessTracker.Interfaces.ServiceInterfaces
{
    public interface IMetricsService
    {
        Task<DashboardMetricsResponse> GetDashboardMetricsAsync(int? applicationId = null);
    }
}
