// Interfaces/ServiceInterfaces/IValidationService.cs
using ProcessTracker.Entities;

namespace ProcessTracker.Interfaces.ServiceInterfaces
{
    public interface IValidationService
    {
        Task<Dictionary<string, string>> ValidateRecordAsync(int processDefinitionId, Dictionary<string, string> fieldValues, bool isSubmit = false);
    }
}