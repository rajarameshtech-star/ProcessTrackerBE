// Services/ProcessDefinitionService.cs (UPDATED - REMOVE FIELD/RECORD COUNT LOGIC)
using ProcessTracker.Entities;
using ProcessTracker.Exceptions;
using ProcessTracker.Interfaces.RepositoryInterfaces;
using ProcessTracker.Interfaces.ServiceInterfaces;
using ProcessTracker.Requests;
using ProcessTracker.Responses;

namespace ProcessTracker.Services
{
    public class ProcessDefinitionService : IProcessDefinitionService
    {
        private readonly IProcessDefinitionRepository _processDefinitionRepository;

        public ProcessDefinitionService(IProcessDefinitionRepository processDefinitionRepository)
        {
            _processDefinitionRepository = processDefinitionRepository;
        }

        public async Task<ProcessDefinitionResponse> CreateProcessDefinitionAsync(CreateProcessDefinitionRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Code))
                throw new ValidationException(new Dictionary<string, string> { { "Code", "Code is required" } });

            if (string.IsNullOrWhiteSpace(request.Name))
                throw new ValidationException(new Dictionary<string, string> { { "Name", "Name is required" } });

            var existingCode = await _processDefinitionRepository.GetByCodeAsync(request.Code);
            if (existingCode != null)
                throw new ValidationException(new Dictionary<string, string> { { "Code", $"Process Definition with code '{request.Code}' already exists" } });

            var processDefinition = new ProcessDefinition
            {
                Code = request.Code,
                Name = request.Name,
                Description = request.Description,
                IsActive = true,
                CreatedDate = DateTime.UtcNow,
                ModifiedDate = DateTime.UtcNow
            };

            await _processDefinitionRepository.AddAsync(processDefinition);
            await _processDefinitionRepository.SaveChangesAsync();

            return MapToResponse(processDefinition);
        }

        public async Task<ProcessDefinitionResponse> GetProcessDefinitionAsync(int processDefinitionId)
        {
            var processDefinition = await _processDefinitionRepository.GetByIdAsync(processDefinitionId);
            if (processDefinition == null)
                throw new NotFoundException($"Process Definition with ID {processDefinitionId} not found");

            return MapToResponse(processDefinition);
        }

        public async Task<PaginatedResponse<ProcessDefinitionResponse>> GetAllProcessDefinitionsAsync(int pageNumber, int pageSize)
        {
            if (pageNumber < 1)
                throw new ValidationException(new Dictionary<string, string> { { "PageNumber", "PageNumber must be greater than 0" } });

            if (pageSize < 1 || pageSize > 100)
                throw new ValidationException(new Dictionary<string, string> { { "PageSize", "PageSize must be between 1 and 100" } });

            var processDefinitions = await _processDefinitionRepository.GetAllProcessDefinitionsAsync(pageNumber, pageSize);
            var totalCount = await _processDefinitionRepository.GetTotalProcessDefinitionsCountAsync();

            var responses = processDefinitions.Select(MapToResponse).ToList();

            int pageCount = (int)Math.Ceiling(totalCount / (double)pageSize);

            return new PaginatedResponse<ProcessDefinitionResponse>
            {
                PageNumber = pageNumber,
                PageSize = pageSize,
                TotalCount = totalCount,
                PageCount = pageCount,
                Records = responses
            };
        }

        public async Task<ProcessDefinitionResponse> UpdateProcessDefinitionAsync(int processDefinitionId, UpdateProcessDefinitionRequest request)
        {
            var processDefinition = await _processDefinitionRepository.GetByIdAsync(processDefinitionId);
            if (processDefinition == null)
                throw new NotFoundException($"Process Definition with ID {processDefinitionId} not found");

            if (string.IsNullOrWhiteSpace(request.Name))
                throw new ValidationException(new Dictionary<string, string> { { "Name", "Name is required" } });

            processDefinition.Name = request.Name;
            processDefinition.Description = request.Description;
            processDefinition.IsActive = request.IsActive;
            processDefinition.ModifiedDate = DateTime.UtcNow;

            _processDefinitionRepository.Update(processDefinition);
            await _processDefinitionRepository.SaveChangesAsync();

            return MapToResponse(processDefinition);
        }

        public async Task DeleteProcessDefinitionAsync(int processDefinitionId)
        {
            var processDefinition = await _processDefinitionRepository.GetByIdAsync(processDefinitionId);
            if (processDefinition == null)
                throw new NotFoundException($"Process Definition with ID {processDefinitionId} not found");

            var hasRecords = await _processDefinitionRepository.HasActiveRecordsAsync(processDefinitionId);
            if (hasRecords)
                throw new InvalidOperationException($"Cannot delete Process Definition. Active records exist. Please delete all records first.");

            _processDefinitionRepository.Delete(processDefinition);
            await _processDefinitionRepository.SaveChangesAsync();
        }

        public async Task<ProcessDefinitionResponse> ToggleActiveStatusAsync(int processDefinitionId)
        {
            var processDefinition = await _processDefinitionRepository.GetByIdAsync(processDefinitionId);
            if (processDefinition == null)
                throw new NotFoundException($"Process Definition with ID {processDefinitionId} not found");

            processDefinition.IsActive = !processDefinition.IsActive;
            processDefinition.ModifiedDate = DateTime.UtcNow;

            _processDefinitionRepository.Update(processDefinition);
            await _processDefinitionRepository.SaveChangesAsync();

            return MapToResponse(processDefinition);
        }

        private ProcessDefinitionResponse MapToResponse(ProcessDefinition processDefinition)
        {
            return new ProcessDefinitionResponse
            {
                Id = processDefinition.Id,
                Code = processDefinition.Code,
                Name = processDefinition.Name,
                Description = processDefinition.Description,
                IsActive = processDefinition.IsActive,
                CreatedDate = processDefinition.CreatedDate,
                ModifiedDate = processDefinition.ModifiedDate
            };
        }

        // Services/ProcessDefinitionService.cs - ADD THIS METHOD
        public async Task<PaginatedResponse<ProcessDefinitionResponse>> GetAllActiveProcessDefinitionsAsync(int pageNumber, int pageSize)
        {
            if (pageNumber < 1)
                throw new ValidationException(new Dictionary<string, string> { { "PageNumber", "PageNumber must be greater than 0" } });

            if (pageSize < 1 || pageSize > 100)
                throw new ValidationException(new Dictionary<string, string> { { "PageSize", "PageSize must be between 1 and 100" } });

            var processDefinitions = await _processDefinitionRepository.GetAllActiveProcessDefinitionsAsync(pageNumber, pageSize);
            var totalCount = await _processDefinitionRepository.GetTotalActiveProcessDefinitionsCountAsync();

            var responses = processDefinitions.Select(MapToResponse).ToList();

            int pageCount = (int)Math.Ceiling(totalCount / (double)pageSize);

            return new PaginatedResponse<ProcessDefinitionResponse>
            {
                PageNumber = pageNumber,
                PageSize = pageSize,
                TotalCount = totalCount,
                PageCount = pageCount,
                Records = responses
            };
        }
    }
}