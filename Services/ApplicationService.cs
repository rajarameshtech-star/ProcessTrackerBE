// Services/ApplicationService.cs
using ProcessTracker.Entities;
using ProcessTracker.Exceptions;
using ProcessTracker.Interfaces.RepositoryInterfaces;
using ProcessTracker.Interfaces.ServiceInterfaces;
using ProcessTracker.Requests;
using ProcessTracker.Responses;

namespace ProcessTracker.Services
{
    public class ApplicationService : IApplicationService
    {
        private readonly IApplicationRepository _applicationRepository;

        public ApplicationService(IApplicationRepository applicationRepository)
        {
            _applicationRepository = applicationRepository;
        }

        public async Task<ApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Title))
                throw new ValidationException(new Dictionary<string, string> { { "Title", "Title is required" } });

            var application = new Application
            {
                Title = request.Title,
                Description = request.Description,
                IsActive = true,
                CreatedDate = DateTime.UtcNow,
                ModifiedDate = DateTime.UtcNow
            };

            await _applicationRepository.AddAsync(application);
            await _applicationRepository.SaveChangesAsync();

            return MapToResponse(application, 0);
        }

        public async Task<ApplicationResponse> GetApplicationAsync(int applicationId)
        {
            var application = await _applicationRepository.GetByIdAsync(applicationId);
            if (application == null)
                throw new NotFoundException($"Application with ID {applicationId} not found");

            var recordCount = await _applicationRepository.GetRecordsCountAsync(applicationId);
            return MapToResponse(application, recordCount);
        }

        public async Task<PaginatedResponse<ApplicationResponse>> GetAllApplicationsAsync(int pageNumber, int pageSize)
        {
            if (pageNumber < 1)
                throw new ValidationException(new Dictionary<string, string> { { "PageNumber", "PageNumber must be greater than 0" } });

            if (pageSize < 1 || pageSize > 100)
                throw new ValidationException(new Dictionary<string, string> { { "PageSize", "PageSize must be between 1 and 100" } });

            var applications = await _applicationRepository.GetAllApplicationsAsync(pageNumber, pageSize);
            var totalCount = await _applicationRepository.GetTotalApplicationsCountAsync();

            var responses = new List<ApplicationResponse>();
            foreach (var app in applications)
            {
                var recordCount = await _applicationRepository.GetRecordsCountAsync(app.Id);
                responses.Add(MapToResponse(app, recordCount));
            }

            int pageCount = (int)Math.Ceiling(totalCount / (double)pageSize);

            return new PaginatedResponse<ApplicationResponse>
            {
                PageNumber = pageNumber,
                PageSize = pageSize,
                TotalCount = totalCount,
                PageCount = pageCount,
                Records = responses
            };
        }

        public async Task<ApplicationResponse> UpdateApplicationAsync(int applicationId, UpdateApplicationRequest request)
        {
            var application = await _applicationRepository.GetByIdAsync(applicationId);
            if (application == null)
                throw new NotFoundException($"Application with ID {applicationId} not found");

            if (string.IsNullOrWhiteSpace(request.Title))
                throw new ValidationException(new Dictionary<string, string> { { "Title", "Title is required" } });

            application.Title = request.Title;
            application.Description = request.Description;
            application.IsActive = request.IsActive;
            application.ModifiedDate = DateTime.UtcNow;

            _applicationRepository.Update(application);
            await _applicationRepository.SaveChangesAsync();

            var recordCount = await _applicationRepository.GetRecordsCountAsync(applicationId);
            return MapToResponse(application, recordCount);
        }

        public async Task DeleteApplicationAsync(int applicationId)
        {
            var application = await _applicationRepository.GetByIdAsync(applicationId);
            if (application == null)
                throw new NotFoundException($"Application with ID {applicationId} not found");

            var recordCount = await _applicationRepository.GetRecordsCountAsync(applicationId);
            if (recordCount > 0)
                throw new InvalidOperationException($"Cannot delete application with {recordCount} active processes. Please delete all processes first.");

            _applicationRepository.Delete(application);
            await _applicationRepository.SaveChangesAsync();
        }

        public async Task<ApplicationResponse> ToggleActiveStatusAsync(int applicationId)
        {
            var application = await _applicationRepository.GetByIdAsync(applicationId);
            if (application == null)
                throw new NotFoundException($"Application with ID {applicationId} not found");

            application.IsActive = !application.IsActive;
            application.ModifiedDate = DateTime.UtcNow;

            _applicationRepository.Update(application);
            await _applicationRepository.SaveChangesAsync();

            var recordCount = await _applicationRepository.GetRecordsCountAsync(applicationId);
            return MapToResponse(application, recordCount);
        }

        private ApplicationResponse MapToResponse(Application application, int processCount)
        {
            return new ApplicationResponse
            {
                Id = application.Id,
                Title = application.Title,
                Description = application.Description,
                IsActive = application.IsActive,
                CreatedDate = application.CreatedDate,
                ModifiedDate = application.ModifiedDate,
                ProcessCount = processCount
            };
        }

        // Services/ApplicationService.cs - ADD THIS METHOD
        public async Task<PaginatedResponse<ApplicationResponse>> GetAllActiveApplicationsAsync(int pageNumber, int pageSize)
        {
            if (pageNumber < 1)
                throw new ValidationException(new Dictionary<string, string> { { "PageNumber", "PageNumber must be greater than 0" } });

            if (pageSize < 1 || pageSize > 100)
                throw new ValidationException(new Dictionary<string, string> { { "PageSize", "PageSize must be between 1 and 100" } });

            var applications = await _applicationRepository.GetAllActiveApplicationsAsync(pageNumber, pageSize);
            var totalCount = await _applicationRepository.GetTotalActiveApplicationsCountAsync();

            var responses = new List<ApplicationResponse>();
            foreach (var app in applications)
            {
                var recordCount = await _applicationRepository.GetRecordsCountAsync(app.Id);
                responses.Add(MapToResponse(app, recordCount));
            }

            int pageCount = (int)Math.Ceiling(totalCount / (double)pageSize);

            return new PaginatedResponse<ApplicationResponse>
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