// Services/ProcessFieldService.cs
using ProcessTracker.Entities;
using ProcessTracker.Exceptions;
using ProcessTracker.Interfaces.RepositoryInterfaces;
using ProcessTracker.Interfaces.ServiceInterfaces;
using ProcessTracker.Requests;
using ProcessTracker.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessTracker.Services
{
    public class ProcessFieldService : IProcessFieldService
    {
        private readonly IProcessFieldRepository _fieldRepository;
        private readonly IProcessDefinitionRepository _definitionRepository;

        public ProcessFieldService(IProcessFieldRepository fieldRepository, IProcessDefinitionRepository definitionRepository)
        {
            _fieldRepository = fieldRepository;
            _definitionRepository = definitionRepository;
        }

        public async Task<ProcessFieldResponse> CreateProcessFieldAsync(CreateProcessFieldRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.FieldName))
                throw new ValidationException(new Dictionary<string, string> { { "FieldName", "Field Name is required" } });

            if (string.IsNullOrWhiteSpace(request.Label))
                throw new ValidationException(new Dictionary<string, string> { { "Label", "Label is required" } });

            var definition = await _definitionRepository.GetByIdAsync(request.ProcessDefinitionId);
            if (definition == null)
                throw new NotFoundException($"Process Definition with ID {request.ProcessDefinitionId} not found");

            var existingFields = await _fieldRepository.GetFieldsByProcessDefinitionAsync(request.ProcessDefinitionId);
            if (existingFields.Any(f => f.FieldName.Equals(request.FieldName, StringComparison.OrdinalIgnoreCase)))
                throw new ValidationException(new Dictionary<string, string> { { "FieldName", $"Field with name '{request.FieldName}' already exists in this process definition" } });

            var field = new ProcessField
            {
                ProcessDefinitionId = request.ProcessDefinitionId,
                FieldName = request.FieldName,
                Label = request.Label,
                FieldType = request.FieldType,
                IsRequired = request.IsRequired,
                SortOrder = request.SortOrder,
                Placeholder = request.Placeholder,
                DefaultValue = request.DefaultValue,
                OptionsJson = request.OptionsJson,
                MinLength = request.MinLength,
                MaxLength = request.MaxLength,
                Min = request.Min,
                Max = request.Max,
                Pattern = request.Pattern,
                IsActive = request.IsActive,
                CreatedDate = DateTime.UtcNow,
                ModifiedDate = DateTime.UtcNow
            };

            await _fieldRepository.AddAsync(field);
            await _fieldRepository.SaveChangesAsync();

            return MapToResponse(field);
        }

        public async Task<ProcessFieldResponse> GetProcessFieldAsync(int id)
        {
            var field = await _fieldRepository.GetByIdAsync(id);
            if (field == null)
                throw new NotFoundException($"Field with ID {id} not found");

            return MapToResponse(field);
        }

        public async Task<List<ProcessFieldResponse>> GetFieldsByProcessDefinitionAsync(int processDefinitionId)
        {
            var definition = await _definitionRepository.GetByIdAsync(processDefinitionId);
            if (definition == null)
                throw new NotFoundException($"Process Definition with ID {processDefinitionId} not found");

            var fields = await _fieldRepository.GetFieldsByProcessDefinitionAsync(processDefinitionId);
            return fields.Select(MapToResponse).ToList();
        }

        public async Task<ProcessFieldResponse> UpdateProcessFieldAsync(int id, UpdateProcessFieldRequest request)
        {
            var field = await _fieldRepository.GetByIdAsync(id);
            if (field == null)
                throw new NotFoundException($"Field with ID {id} not found");

            if (string.IsNullOrWhiteSpace(request.Label))
                throw new ValidationException(new Dictionary<string, string> { { "Label", "Label is required" } });

            field.Label = request.Label;
            field.IsRequired = request.IsRequired;
            field.SortOrder = request.SortOrder;
            field.Placeholder = request.Placeholder;
            field.DefaultValue = request.DefaultValue;
            field.OptionsJson = request.OptionsJson;
            field.MinLength = request.MinLength;
            field.MaxLength = request.MaxLength;
            field.Min = request.Min;
            field.Max = request.Max;
            field.Pattern = request.Pattern;
            field.IsActive = request.IsActive;
            field.ModifiedDate = DateTime.UtcNow;

            _fieldRepository.Update(field);
            await _fieldRepository.SaveChangesAsync();

            return MapToResponse(field);
        }

        public async Task DeleteProcessFieldAsync(int id)
        {
            var field = await _fieldRepository.GetByIdAsync(id);
            if (field == null)
                throw new NotFoundException($"Field with ID {id} not found");

            if (await _fieldRepository.HasRecordsAssociatedAsync(id))
                throw new InvalidOperationException("Cannot delete field because there are records associated with it");

            _fieldRepository.Delete(field);
            await _fieldRepository.SaveChangesAsync();
        }

        public async Task<ProcessFieldResponse> ToggleActiveStatusAsync(int id)
        {
            var field = await _fieldRepository.GetByIdAsync(id);
            if (field == null)
                throw new NotFoundException($"Field with ID {id} not found");

            field.IsActive = !field.IsActive;
            field.ModifiedDate = DateTime.UtcNow;

            _fieldRepository.Update(field);
            await _fieldRepository.SaveChangesAsync();

            return MapToResponse(field);
        }

        private ProcessFieldResponse MapToResponse(ProcessField field)
        {
            return new ProcessFieldResponse
            {
                Id = field.Id,
                FieldName = field.FieldName,
                Label = field.Label,
                FieldType = field.FieldType,
                IsRequired = field.IsRequired,
                SortOrder = field.SortOrder,
                Placeholder = field.Placeholder,
                DefaultValue = field.DefaultValue,
                OptionsJson = field.OptionsJson,
                MinLength = field.MinLength,
                MaxLength = field.MaxLength,
                Min = field.Min,
                Max = field.Max,
                Pattern = field.Pattern
            };
        }
    }
}
