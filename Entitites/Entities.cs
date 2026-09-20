using System;
using System.Collections.Generic;

namespace ProcessTracker.Entities
{
    // Enum for field types
    public enum FieldType
    {
        Text = 0,
        Number = 1,
        Date = 2,
        DateTime = 3,
        Dropdown = 4,
        TextArea = 5,
        Checkbox = 6,
        Email = 7,
        Url = 8,
        Phone = 9
    }

    // Application entity - represents a process application (CR, Incident, UT)
    public class Application
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        // Navigation
        public ICollection<ProcessRecord> ProcessRecords { get; set; } = new List<ProcessRecord>();
    }


    // ProcessDefinition entity - defines the structure of a process (fields, validations)
    public class ProcessDefinition
    {
        public int Id { get; set; }
        public string Code { get; set; } = string.Empty;  // CR, INCIDENT, UT
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        // Navigation
        public ICollection<ProcessField> Fields { get; set; } = new List<ProcessField>();
        public ICollection<ProcessRecord> Records { get; set; } = new List<ProcessRecord>();
    }

    // ProcessField entity - represents a field in a process
    public class ProcessField
    {
        public int Id { get; set; }
        public int ProcessDefinitionId { get; set; }
        public string FieldName { get; set; } = string.Empty;
        public string Label { get; set; } = string.Empty;
        public FieldType FieldType { get; set; }
        public bool IsRequired { get; set; }
        public int SortOrder { get; set; }
        public string? Placeholder { get; set; }
        public string? DefaultValue { get; set; }
        public string? OptionsJson { get; set; }  // JSON array for dropdown options
        public int? MinLength { get; set; }
        public int? MaxLength { get; set; }
        public decimal? Min { get; set; }
        public decimal? Max { get; set; }
        public string? Pattern { get; set; }  // Regex pattern
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        // Navigation
        public ProcessDefinition? ProcessDefinition { get; set; }
        public ICollection<ProcessRecordFieldValue> FieldValues { get; set; } = new List<ProcessRecordFieldValue>();
    }

    // ProcessRecord entity - represents a submitted form instance
    public class ProcessRecord
    {
        public long Id { get; set; }
        public int ApplicationId { get; set; }
        public int ProcessDefinitionId { get; set; }
        public string RecordStatus { get; set; } = "Draft";  // Draft, Submitted, InProgress, Completed, Rejected
        public string? RecordNumber { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime? SubmittedDate { get; set; }
        public string? Notes { get; set; }

        // Navigation
        public Application? Application { get; set; }
        public ProcessDefinition? ProcessDefinition { get; set; }
        public ICollection<ProcessRecordFieldValue> FieldValues { get; set; } = new List<ProcessRecordFieldValue>();
    }

    // ProcessRecordFieldValue entity - stores actual field values submitted by users
    public class ProcessRecordFieldValue
    {
        public long Id { get; set; }
        public long ProcessRecordId { get; set; }
        public int ProcessFieldId { get; set; }
        public string? FieldValue { get; set; }  // Stored as string
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        // Navigation
        public ProcessRecord? ProcessRecord { get; set; }
        public ProcessField? ProcessField { get; set; }

        // Helper method to convert string value to typed value
        public object? GetTypedValue()
        {
            if (string.IsNullOrEmpty(FieldValue) || ProcessField == null)
                return null;

            return ProcessField.FieldType switch
            {
                FieldType.Number => decimal.TryParse(FieldValue, out var num) ? num : null,
                FieldType.Date => DateTime.TryParse(FieldValue, out var date) ? date : null,
                FieldType.DateTime => DateTime.TryParse(FieldValue, out var dt) ? dt : null,
                FieldType.Checkbox => bool.TryParse(FieldValue, out var b) ? b : null,
                _ => FieldValue
            };
        }
    }
}