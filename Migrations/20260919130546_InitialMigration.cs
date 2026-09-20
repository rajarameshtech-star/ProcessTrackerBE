using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProcessTracker.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProcessDefinitions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcessDefinitions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProcessFields",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProcessDefinitionId = table.Column<int>(type: "int", nullable: false),
                    FieldName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Label = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FieldType = table.Column<int>(type: "int", nullable: false),
                    IsRequired = table.Column<bool>(type: "bit", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Placeholder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefaultValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OptionsJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MinLength = table.Column<int>(type: "int", nullable: true),
                    MaxLength = table.Column<int>(type: "int", nullable: true),
                    Min = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Max = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Pattern = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcessFields", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProcessFields_ProcessDefinitions_ProcessDefinitionId",
                        column: x => x.ProcessDefinitionId,
                        principalTable: "ProcessDefinitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProcessRecords",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<int>(type: "int", nullable: false),
                    ProcessDefinitionId = table.Column<int>(type: "int", nullable: false),
                    RecordStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecordNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SubmittedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcessRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProcessRecords_Applications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Applications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProcessRecords_ProcessDefinitions_ProcessDefinitionId",
                        column: x => x.ProcessDefinitionId,
                        principalTable: "ProcessDefinitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProcessRecordFieldValues",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProcessRecordId = table.Column<long>(type: "bigint", nullable: false),
                    ProcessFieldId = table.Column<int>(type: "int", nullable: false),
                    FieldValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcessRecordFieldValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProcessRecordFieldValues_ProcessFields_ProcessFieldId",
                        column: x => x.ProcessFieldId,
                        principalTable: "ProcessFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProcessRecordFieldValues_ProcessRecords_ProcessRecordId",
                        column: x => x.ProcessRecordId,
                        principalTable: "ProcessRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Applications",
                columns: new[] { "Id", "CreatedDate", "Description", "ModifiedDate", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(2958), "Process for managing change requests", new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(2961), "Change Request" },
                    { 2, new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(2963), "Process for reporting and tracking incidents", new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(2964), "Incident Management" },
                    { 3, new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(2965), "Process for unit testing documentation", new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(2966), "Unit Testing" }
                });

            migrationBuilder.InsertData(
                table: "ProcessDefinitions",
                columns: new[] { "Id", "Code", "CreatedDate", "Description", "IsActive", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "CR", new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3147), "CR Process", true, new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3148), "Change Request" },
                    { 2, "INCIDENT", new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3150), "Incident Process", true, new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3151), "Incident Management" },
                    { 3, "UT", new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3153), "Unit Testing Process", true, new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3153), "Unit Testing" }
                });

            migrationBuilder.InsertData(
                table: "ProcessFields",
                columns: new[] { "Id", "CreatedDate", "DefaultValue", "FieldName", "FieldType", "IsActive", "IsRequired", "Label", "Max", "MaxLength", "Min", "MinLength", "ModifiedDate", "OptionsJson", "Pattern", "Placeholder", "ProcessDefinitionId", "SortOrder" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3179), null, "Title", 0, true, true, "Change Title", null, 255, null, 5, new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3181), null, null, "Brief title", 1, 1 },
                    { 2, new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3185), null, "Description", 5, true, true, "Detailed Description", null, null, null, 20, new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3186), null, null, null, 1, 2 },
                    { 3, new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3188), null, "Priority", 4, true, true, "Priority Level", null, null, null, null, new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3189), "[{\"label\":\"Critical\",\"value\":\"CRITICAL\"},{\"label\":\"High\",\"value\":\"HIGH\"},{\"label\":\"Medium\",\"value\":\"MEDIUM\"},{\"label\":\"Low\",\"value\":\"LOW\"}]", null, null, 1, 3 },
                    { 4, new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3191), null, "ChangeType", 4, true, true, "Type of Change", null, null, null, null, new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3192), "[{\"label\":\"Emergency\",\"value\":\"EMERGENCY\"},{\"label\":\"Urgent\",\"value\":\"URGENT\"},{\"label\":\"Standard\",\"value\":\"STANDARD\"},{\"label\":\"Minor\",\"value\":\"MINOR\"}]", null, null, 1, 4 },
                    { 5, new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3194), null, "ImpactScope", 5, true, false, "Impact Scope", null, null, null, null, new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3194), null, null, null, 1, 5 },
                    { 6, new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3196), null, "ImplementationDate", 2, true, true, "Implementation Date", null, null, null, null, new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3197), null, null, null, 1, 6 },
                    { 7, new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3199), null, "RollbackPlan", 5, true, false, "Rollback Plan", null, null, null, null, new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3200), null, null, null, 1, 7 },
                    { 8, new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3202), null, "CRNumber", 0, true, true, "CR Number", null, null, null, null, new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3203), null, null, "e.g., CR-2024-001", 1, 8 },
                    { 9, new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3225), null, "IncidentId", 0, true, true, "Incident ID", null, null, null, null, new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3226), null, null, "e.g., INC-2024-001", 2, 1 },
                    { 10, new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3228), null, "Title", 0, true, true, "Incident Title", null, 255, null, 5, new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3229), null, null, null, 2, 2 },
                    { 11, new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3231), null, "Description", 5, true, true, "Incident Description", null, null, null, null, new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3231), null, null, null, 2, 3 },
                    { 12, new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3233), null, "Severity", 4, true, true, "Severity Level", null, null, null, null, new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3234), "[{\"label\":\"Blocker\",\"value\":\"BLOCKER\"},{\"label\":\"Critical\",\"value\":\"CRITICAL\"},{\"label\":\"Major\",\"value\":\"MAJOR\"},{\"label\":\"Minor\",\"value\":\"MINOR\"}]", null, null, 2, 4 },
                    { 13, new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3236), null, "ReportedDate", 3, true, true, "Date Reported", null, null, null, null, new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3237), null, null, null, 2, 5 },
                    { 14, new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3244), null, "AffectedUsers", 1, true, false, "Number of Affected Users", 10000m, null, 0m, null, new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3245), null, null, null, 2, 6 },
                    { 15, new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3247), null, "ResolutionNotes", 5, true, false, "Resolution Notes", null, null, null, null, new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3247), null, null, null, 2, 7 },
                    { 16, new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3319), null, "TestId", 0, true, true, "Test ID", null, null, null, null, new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3320), null, null, "e.g., UT-2024-001", 3, 1 },
                    { 17, new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3322), null, "ModuleUnderTest", 0, true, true, "Module Name", null, null, null, null, new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3323), null, null, "e.g., AuthService", 3, 2 },
                    { 18, new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3325), null, "TestCases", 1, true, true, "Number of Test Cases", null, null, 0m, null, new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3326), null, null, null, 3, 3 },
                    { 19, new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3328), null, "PassedCases", 1, true, true, "Passed Test Cases", null, null, 0m, null, new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3328), null, null, null, 3, 4 },
                    { 20, new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3331), null, "FailedCases", 1, true, true, "Failed Test Cases", null, null, 0m, null, new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3331), null, null, null, 3, 5 },
                    { 21, new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3334), null, "CodeCoverage", 1, true, true, "Code Coverage %", 100m, null, 0m, null, new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3334), null, null, null, 3, 6 },
                    { 22, new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3336), null, "TestStatus", 4, true, true, "Overall Status", null, null, null, null, new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3337), "[{\"label\":\"Passed\",\"value\":\"PASSED\"},{\"label\":\"Failed\",\"value\":\"FAILED\"},{\"label\":\"In Progress\",\"value\":\"IN_PROGRESS\"},{\"label\":\"Not Started\",\"value\":\"NOT_STARTED\"}]", null, null, 3, 7 },
                    { 23, new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3339), null, "Notes", 5, true, false, "Test Notes", null, null, null, null, new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3339), null, null, null, 3, 8 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProcessFields_ProcessDefinitionId",
                table: "ProcessFields",
                column: "ProcessDefinitionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProcessRecordFieldValues_ProcessFieldId",
                table: "ProcessRecordFieldValues",
                column: "ProcessFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_ProcessRecordFieldValues_ProcessRecordId",
                table: "ProcessRecordFieldValues",
                column: "ProcessRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_ProcessRecords_ApplicationId",
                table: "ProcessRecords",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_ProcessRecords_ProcessDefinitionId",
                table: "ProcessRecords",
                column: "ProcessDefinitionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProcessRecordFieldValues");

            migrationBuilder.DropTable(
                name: "ProcessFields");

            migrationBuilder.DropTable(
                name: "ProcessRecords");

            migrationBuilder.DropTable(
                name: "Applications");

            migrationBuilder.DropTable(
                name: "ProcessDefinitions");
        }
    }
}
