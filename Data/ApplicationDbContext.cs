// ApplicationDbContext.cs
using Microsoft.EntityFrameworkCore;
using ProcessTracker.Entities;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace ProcessTracker.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Application> Applications { get; set; }
        public DbSet<ProcessDefinition> ProcessDefinitions { get; set; }
        public DbSet<ProcessField> ProcessFields { get; set; }
        public DbSet<ProcessRecord> ProcessRecords { get; set; }
        public DbSet<ProcessRecordFieldValue> ProcessRecordFieldValues { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Application
            modelBuilder.Entity<Application>()
                .HasMany(a => a.ProcessRecords)
                .WithOne(pr => pr.Application)
                .HasForeignKey(pr => pr.ApplicationId)
                .OnDelete(DeleteBehavior.Cascade);

            // ProcessDefinition
            modelBuilder.Entity<ProcessDefinition>()
                .HasMany(pd => pd.Fields)
                .WithOne(pf => pf.ProcessDefinition)
                .HasForeignKey(pf => pf.ProcessDefinitionId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ProcessDefinition>()
                .HasMany(pd => pd.Records)
                .WithOne(pr => pr.ProcessDefinition)
                .HasForeignKey(pr => pr.ProcessDefinitionId)
                .OnDelete(DeleteBehavior.Cascade);

            // ProcessField
            modelBuilder.Entity<ProcessField>()
                .HasMany(pf => pf.FieldValues)
                .WithOne(pfv => pfv.ProcessField)
                .HasForeignKey(pfv => pfv.ProcessFieldId)
                .OnDelete(DeleteBehavior.Restrict);

            // ProcessRecord
            modelBuilder.Entity<ProcessRecord>()
                .HasMany(pr => pr.FieldValues)
                .WithOne(pfv => pfv.ProcessRecord)
                .HasForeignKey(pfv => pfv.ProcessRecordId)
                .OnDelete(DeleteBehavior.Cascade);

            // Seed data
            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            // Applications
            modelBuilder.Entity<Application>().HasData(
                new Application { Id = 1, Title = "Change Request", Description = "Process for managing change requests", CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
                new Application { Id = 2, Title = "Incident Management", Description = "Process for reporting and tracking incidents", CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
                new Application { Id = 3, Title = "Unit Testing", Description = "Process for unit testing documentation", CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow }
            );

            // ProcessDefinitions
            modelBuilder.Entity<ProcessDefinition>().HasData(
                new ProcessDefinition { Id = 1, Code = "CR", Name = "Change Request", Description = "CR Process", IsActive = true, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
                new ProcessDefinition { Id = 2, Code = "INCIDENT", Name = "Incident Management", Description = "Incident Process", IsActive = true, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
                new ProcessDefinition { Id = 3, Code = "UT", Name = "Unit Testing", Description = "Unit Testing Process", IsActive = true, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow }
            );

            // CR Process Fields
            modelBuilder.Entity<ProcessField>().HasData(
                new ProcessField { Id = 1, ProcessDefinitionId = 1, FieldName = "Title", Label = "Change Title", FieldType = FieldType.Text, IsRequired = true, SortOrder = 1, Placeholder = "Brief title", MinLength = 5, MaxLength = 255, IsActive = true, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
                new ProcessField { Id = 2, ProcessDefinitionId = 1, FieldName = "Description", Label = "Detailed Description", FieldType = FieldType.TextArea, IsRequired = true, SortOrder = 2, MinLength = 20, IsActive = true, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
                new ProcessField { Id = 3, ProcessDefinitionId = 1, FieldName = "Priority", Label = "Priority Level", FieldType = FieldType.Dropdown, IsRequired = true, SortOrder = 3, OptionsJson = "[{\"label\":\"Critical\",\"value\":\"CRITICAL\"},{\"label\":\"High\",\"value\":\"HIGH\"},{\"label\":\"Medium\",\"value\":\"MEDIUM\"},{\"label\":\"Low\",\"value\":\"LOW\"}]", IsActive = true, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
                new ProcessField { Id = 4, ProcessDefinitionId = 1, FieldName = "ChangeType", Label = "Type of Change", FieldType = FieldType.Dropdown, IsRequired = true, SortOrder = 4, OptionsJson = "[{\"label\":\"Emergency\",\"value\":\"EMERGENCY\"},{\"label\":\"Urgent\",\"value\":\"URGENT\"},{\"label\":\"Standard\",\"value\":\"STANDARD\"},{\"label\":\"Minor\",\"value\":\"MINOR\"}]", IsActive = true, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
                new ProcessField { Id = 5, ProcessDefinitionId = 1, FieldName = "ImpactScope", Label = "Impact Scope", FieldType = FieldType.TextArea, IsRequired = false, SortOrder = 5, IsActive = true, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
                new ProcessField { Id = 6, ProcessDefinitionId = 1, FieldName = "ImplementationDate", Label = "Implementation Date", FieldType = FieldType.Date, IsRequired = true, SortOrder = 6, IsActive = true, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
                new ProcessField { Id = 7, ProcessDefinitionId = 1, FieldName = "RollbackPlan", Label = "Rollback Plan", FieldType = FieldType.TextArea, IsRequired = false, SortOrder = 7, IsActive = true, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
                new ProcessField { Id = 8, ProcessDefinitionId = 1, FieldName = "CRNumber", Label = "CR Number", FieldType = FieldType.Text, IsRequired = true, SortOrder = 8, Placeholder = "e.g., CR-2024-001", IsActive = true, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow }
            );

            // INCIDENT Process Fields
            modelBuilder.Entity<ProcessField>().HasData(
                new ProcessField { Id = 9, ProcessDefinitionId = 2, FieldName = "IncidentId", Label = "Incident ID", FieldType = FieldType.Text, IsRequired = true, SortOrder = 1, Placeholder = "e.g., INC-2024-001", IsActive = true, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
                new ProcessField { Id = 10, ProcessDefinitionId = 2, FieldName = "Title", Label = "Incident Title", FieldType = FieldType.Text, IsRequired = true, SortOrder = 2, MinLength = 5, MaxLength = 255, IsActive = true, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
                new ProcessField { Id = 11, ProcessDefinitionId = 2, FieldName = "Description", Label = "Incident Description", FieldType = FieldType.TextArea, IsRequired = true, SortOrder = 3, IsActive = true, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
                new ProcessField { Id = 12, ProcessDefinitionId = 2, FieldName = "Severity", Label = "Severity Level", FieldType = FieldType.Dropdown, IsRequired = true, SortOrder = 4, OptionsJson = "[{\"label\":\"Blocker\",\"value\":\"BLOCKER\"},{\"label\":\"Critical\",\"value\":\"CRITICAL\"},{\"label\":\"Major\",\"value\":\"MAJOR\"},{\"label\":\"Minor\",\"value\":\"MINOR\"}]", IsActive = true, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
                new ProcessField { Id = 13, ProcessDefinitionId = 2, FieldName = "ReportedDate", Label = "Date Reported", FieldType = FieldType.DateTime, IsRequired = true, SortOrder = 5, IsActive = true, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
                new ProcessField { Id = 14, ProcessDefinitionId = 2, FieldName = "AffectedUsers", Label = "Number of Affected Users", FieldType = FieldType.Number, IsRequired = false, SortOrder = 6, Min = 0, Max = 10000, IsActive = true, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
                new ProcessField { Id = 15, ProcessDefinitionId = 2, FieldName = "ResolutionNotes", Label = "Resolution Notes", FieldType = FieldType.TextArea, IsRequired = false, SortOrder = 7, IsActive = true, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow }
            );

            // UT Process Fields
            modelBuilder.Entity<ProcessField>().HasData(
                new ProcessField { Id = 16, ProcessDefinitionId = 3, FieldName = "TestId", Label = "Test ID", FieldType = FieldType.Text, IsRequired = true, SortOrder = 1, Placeholder = "e.g., UT-2024-001", IsActive = true, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
                new ProcessField { Id = 17, ProcessDefinitionId = 3, FieldName = "ModuleUnderTest", Label = "Module Name", FieldType = FieldType.Text, IsRequired = true, SortOrder = 2, Placeholder = "e.g., AuthService", IsActive = true, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
                new ProcessField { Id = 18, ProcessDefinitionId = 3, FieldName = "TestCases", Label = "Number of Test Cases", FieldType = FieldType.Number, IsRequired = true, SortOrder = 3, Min = 0, IsActive = true, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
                new ProcessField { Id = 19, ProcessDefinitionId = 3, FieldName = "PassedCases", Label = "Passed Test Cases", FieldType = FieldType.Number, IsRequired = true, SortOrder = 4, Min = 0, IsActive = true, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
                new ProcessField { Id = 20, ProcessDefinitionId = 3, FieldName = "FailedCases", Label = "Failed Test Cases", FieldType = FieldType.Number, IsRequired = true, SortOrder = 5, Min = 0, IsActive = true, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
                new ProcessField { Id = 21, ProcessDefinitionId = 3, FieldName = "CodeCoverage", Label = "Code Coverage %", FieldType = FieldType.Number, IsRequired = true, SortOrder = 6, Min = 0, Max = 100, IsActive = true, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
                new ProcessField { Id = 22, ProcessDefinitionId = 3, FieldName = "TestStatus", Label = "Overall Status", FieldType = FieldType.Dropdown, IsRequired = true, SortOrder = 7, OptionsJson = "[{\"label\":\"Passed\",\"value\":\"PASSED\"},{\"label\":\"Failed\",\"value\":\"FAILED\"},{\"label\":\"In Progress\",\"value\":\"IN_PROGRESS\"},{\"label\":\"Not Started\",\"value\":\"NOT_STARTED\"}]", IsActive = true, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
                new ProcessField { Id = 23, ProcessDefinitionId = 3, FieldName = "Notes", Label = "Test Notes", FieldType = FieldType.TextArea, IsRequired = false, SortOrder = 8, IsActive = true, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow }
            );
        }
    }
}