// Services/ValidationService.cs
using System.Text.RegularExpressions;
using ProcessTracker.Data;
using ProcessTracker.Entities;
using ProcessTracker.Interfaces.ServiceInterfaces;
using Microsoft.EntityFrameworkCore;

namespace ProcessTracker.Services
{
    public class ValidationService : IValidationService
    {
        private readonly ApplicationDbContext _context;

        public ValidationService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Dictionary<string, string>> ValidateRecordAsync(int processDefinitionId, Dictionary<string, string> fieldValues, bool isSubmit = false)
        {
            var errors = new Dictionary<string, string>();

            var processFields = await _context.ProcessFields
                .Where(pf => pf.ProcessDefinitionId == processDefinitionId && pf.IsActive)
                .ToListAsync();

            foreach (var field in processFields)
            {
                if (!fieldValues.ContainsKey(field.FieldName))
                {
                    if ((isSubmit || fieldValues.Count > 0) && field.IsRequired)
                    {
                        errors[field.FieldName] = $"{field.Label} is required";
                    }
                    continue;
                }

                var fieldValue = fieldValues[field.FieldName];

                // Required validation
                if (field.IsRequired && string.IsNullOrWhiteSpace(fieldValue))
                {
                    errors[field.FieldName] = $"{field.Label} is required";
                    continue;
                }

                // Skip other validations if field is empty and not required
                if (string.IsNullOrWhiteSpace(fieldValue))
                    continue;

                // Type validation
                if (!ValidateFieldType(field, fieldValue))
                {
                    errors[field.FieldName] = $"{field.Label} must be a valid {field.FieldType}";
                    continue;
                }

                // MinLength validation
                if (field.MinLength.HasValue && fieldValue.Length < field.MinLength)
                {
                    errors[field.FieldName] = $"{field.Label} must be at least {field.MinLength} characters";
                }

                // MaxLength validation
                if (field.MaxLength.HasValue && fieldValue.Length > field.MaxLength)
                {
                    errors[field.FieldName] = $"{field.Label} cannot exceed {field.MaxLength} characters";
                }

                // Pattern validation (Regex)
                if (!string.IsNullOrEmpty(field.Pattern))
                {
                    try
                    {
                        if (!Regex.IsMatch(fieldValue, field.Pattern))
                        {
                            errors[field.FieldName] = $"{field.Label} format is invalid";
                        }
                    }
                    catch { }
                }

                // Number validation (Min/Max)
                if (field.FieldType == FieldType.Number)
                {
                    if (decimal.TryParse(fieldValue, out var numValue))
                    {
                        if (field.Min.HasValue && numValue < field.Min)
                        {
                            errors[field.FieldName] = $"{field.Label} must be at least {field.Min}";
                        }
                        if (field.Max.HasValue && numValue > field.Max)
                        {
                            errors[field.FieldName] = $"{field.Label} cannot exceed {field.Max}";
                        }
                    }
                }

                // Dropdown validation
                if (field.FieldType == FieldType.Dropdown && !string.IsNullOrEmpty(field.OptionsJson))
                {
                    if (!IsValidDropdownOption(field.OptionsJson, fieldValue))
                    {
                        errors[field.FieldName] = $"{field.Label} contains an invalid option";
                    }
                }
            }

            return errors;
        }

        private bool ValidateFieldType(ProcessField field, string value)
        {
            return field.FieldType switch
            {
                FieldType.Number => decimal.TryParse(value, out _),
                FieldType.Date => DateTime.TryParse(value, out _),
                FieldType.DateTime => DateTime.TryParse(value, out _),
                FieldType.Checkbox => bool.TryParse(value, out _),
                FieldType.Email => IsValidEmail(value),
                FieldType.Url => IsValidUrl(value),
                FieldType.Phone => IsValidPhone(value),
                _ => true
            };
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidUrl(string url)
        {
            return Uri.TryCreate(url, UriKind.Absolute, out var uriResult) &&
                   (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
        }

        private bool IsValidPhone(string phone)
        {
            return Regex.IsMatch(phone, @"^\+?[1-9]\d{1,14}$");
        }

        private bool IsValidDropdownOption(string optionsJson, string selectedValue)
        {
            try
            {
                var options = System.Text.Json.JsonSerializer.Deserialize<List<Dictionary<string, string>>>(optionsJson);
                return options?.Any(o => o["value"] == selectedValue) ?? false;
            }
            catch
            {
                return false;
            }
        }
    }
}