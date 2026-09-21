using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProcessTracker.Migrations
{
    /// <inheritdoc />
    public partial class ExhaustiveSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProcessRecords",
                keyColumn: "Id",
                keyValue: 101L);

            migrationBuilder.DeleteData(
                table: "ProcessRecords",
                keyColumn: "Id",
                keyValue: 102L);

            migrationBuilder.DeleteData(
                table: "ProcessRecords",
                keyColumn: "Id",
                keyValue: 103L);

            migrationBuilder.DeleteData(
                table: "ProcessRecords",
                keyColumn: "Id",
                keyValue: 104L);

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3129), new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3130) });

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3132), new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3132) });

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3134), new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3134) });

            migrationBuilder.UpdateData(
                table: "ProcessDefinitions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3234), new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3234) });

            migrationBuilder.UpdateData(
                table: "ProcessDefinitions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3237), new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3237) });

            migrationBuilder.UpdateData(
                table: "ProcessDefinitions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3239), new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3239) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3260), new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3261) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3263), new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3264) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3266), new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3266) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3268), new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3268) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3270), new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3270) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3272), new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3272) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3274), new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3274) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3276), new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3276) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3317), new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3318) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3320), new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3320) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3322), new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3322) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3324), new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3324) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3326), new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3326) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3333), new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3334) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3335), new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3336) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3352), new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3352) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3354), new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3354) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3356), new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3357) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3358), new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3359) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3361), new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3361) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3363), new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3364) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3365), new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3366) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3367), new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3368) });

            migrationBuilder.UpdateData(
                table: "ProcessRecords",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AssignedTo", "CreatedDate", "ExpectedDueDate", "FieldValuesJson", "ModifiedDate", "Priority", "SubmittedDate" },
                values: new object[] { "john.doe@company.com", new DateTime(2026, 9, 6, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3374), new DateTime(2026, 9, 16, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3374), "{\"Title\":\"Upgrade HR Portal Database\",\"Description\":\"Database needs to be migrated to the latest version for better performance.\",\"ChangeType\":\"STANDARD\",\"CRNumber\":\"CR-2024-001\"}", new DateTime(2026, 9, 11, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3374), "HIGH", new DateTime(2026, 9, 11, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3374) });

            migrationBuilder.InsertData(
                table: "ProcessRecords",
                columns: new[] { "Id", "ApplicationId", "AssignedTo", "CreatedDate", "ExpectedDueDate", "FieldValuesJson", "ModifiedDate", "Notes", "Priority", "ProcessDefinitionId", "RecordNumber", "RecordStatus", "SubmittedDate" },
                values: new object[,]
                {
                    { 501L, 2, "jenna.devops@company.com", new DateTime(2026, 9, 19, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3374), new DateTime(2026, 9, 20, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3374), "{\"Title\":\"CRM Login Gateway Down\",\"Description\":\"Customer logins are timing out on the central gateway.\",\"IncidentId\":\"INC-2024-001\",\"Severity\":\"CRITICAL\",\"AffectedUsers\":\"1500\",\"ResolutionNotes\":\"Rebooted instances\"}", new DateTime(2026, 9, 20, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3374), null, "CRITICAL", 2, "INC-2024-001", "Submitted", new DateTime(2026, 9, 20, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3374) },
                    { 502L, 2, null, new DateTime(2026, 9, 21, 10, 28, 13, 444, DateTimeKind.Utc).AddTicks(3374), new DateTime(2026, 9, 21, 22, 28, 13, 444, DateTimeKind.Utc).AddTicks(3374), "{\"Title\":\"Payment Gateway Latency\",\"Description\":\"Payments are processing but taking up to 30 seconds.\",\"IncidentId\":\"INC-2024-002\",\"Severity\":\"MAJOR\",\"AffectedUsers\":\"250\"}", new DateTime(2026, 9, 21, 18, 28, 13, 444, DateTimeKind.Utc).AddTicks(3374), null, "BLOCKER", 2, "INC-2024-002", "Draft", null },
                    { 503L, 3, "mark.qa@company.com", new DateTime(2026, 9, 20, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3374), new DateTime(2026, 9, 25, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3374), "{\"TestId\":\"UT-2024-001\",\"ModuleUnderTest\":\"BillingCalculator\",\"TestCases\":\"45\",\"PassedCases\":\"44\",\"FailedCases\":\"1\",\"CodeCoverage\":\"85\",\"TestStatus\":\"FAILED\"}", new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3374), null, "LOW", 3, "UT-2024-001", "Submitted", new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3374) },
                    { 504L, 3, "jenna.devops@company.com", new DateTime(2026, 9, 18, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3374), new DateTime(2026, 9, 22, 1, 28, 13, 444, DateTimeKind.Utc).AddTicks(3374), "{\"TestId\":\"UT-2024-002\",\"ModuleUnderTest\":\"AuthTokenService\",\"TestCases\":\"12\",\"PassedCases\":\"12\",\"FailedCases\":\"0\",\"CodeCoverage\":\"100\",\"TestStatus\":\"PASSED\"}", new DateTime(2026, 9, 20, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3374), null, "MEDIUM", 3, "UT-2024-002", "Submitted", new DateTime(2026, 9, 20, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3374) },
                    { 505L, 1, null, new DateTime(2026, 9, 20, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3374), new DateTime(2026, 9, 20, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3374), "{\"Title\":\"Fix CSS Dropdown Glitch\",\"Description\":\"The dropdowns are hanging off the screen.\",\"ChangeType\":\"MINOR\",\"CRNumber\":\"CR-2024-002\"}", new DateTime(2026, 9, 21, 15, 28, 13, 444, DateTimeKind.Utc).AddTicks(3374), null, "MEDIUM", 1, "CR-2024-002", "Draft", null },
                    { 506L, 2, "alex@ops.com", new DateTime(2026, 9, 21, 19, 28, 13, 444, DateTimeKind.Utc).AddTicks(3374), new DateTime(2026, 9, 22, 8, 28, 13, 444, DateTimeKind.Utc).AddTicks(3374), "{\"Title\":\"High CPU on Redis API\",\"Description\":\"Nodes are spinning at 99% usage.\",\"IncidentId\":\"INC-2024-003\",\"Severity\":\"MAJOR\",\"AffectedUsers\":\"40\"}", new DateTime(2026, 9, 21, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3374), null, "HIGH", 2, "INC-2024-003", "Draft", null },
                    { 507L, 1, "alex@ops.com", new DateTime(2026, 9, 16, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3374), new DateTime(2026, 9, 23, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3374), "{\"Title\":\"Migrate Payment Gateway\",\"Description\":\"Shift entirely away from legacy API endpoints.\",\"ChangeType\":\"EMERGENCY\",\"CRNumber\":\"CR-2024-003\"}", new DateTime(2026, 9, 17, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3374), null, "CRITICAL", 1, "CR-2024-003", "Submitted", new DateTime(2026, 9, 17, 20, 28, 13, 444, DateTimeKind.Utc).AddTicks(3374) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProcessRecords",
                keyColumn: "Id",
                keyValue: 501L);

            migrationBuilder.DeleteData(
                table: "ProcessRecords",
                keyColumn: "Id",
                keyValue: 502L);

            migrationBuilder.DeleteData(
                table: "ProcessRecords",
                keyColumn: "Id",
                keyValue: 503L);

            migrationBuilder.DeleteData(
                table: "ProcessRecords",
                keyColumn: "Id",
                keyValue: 504L);

            migrationBuilder.DeleteData(
                table: "ProcessRecords",
                keyColumn: "Id",
                keyValue: 505L);

            migrationBuilder.DeleteData(
                table: "ProcessRecords",
                keyColumn: "Id",
                keyValue: 506L);

            migrationBuilder.DeleteData(
                table: "ProcessRecords",
                keyColumn: "Id",
                keyValue: 507L);

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1183), new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1184) });

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1186), new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1186) });

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1188), new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1188) });

            migrationBuilder.UpdateData(
                table: "ProcessDefinitions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1297), new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1298) });

            migrationBuilder.UpdateData(
                table: "ProcessDefinitions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1300), new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1301) });

            migrationBuilder.UpdateData(
                table: "ProcessDefinitions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1302), new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1303) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1329), new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1329) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1332), new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1332) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1334), new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1335) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1336), new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1337) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1338), new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1339) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1378), new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1378) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1380), new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1380) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1382), new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1383) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1400), new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1400) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1402), new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1403) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1404), new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1405) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1406), new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1407) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1408), new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1409) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1417), new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1418) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1419), new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1420) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1435), new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1435) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1437), new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1437) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1439), new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1439) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1441), new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1442) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1444), new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1444) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1446), new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1447) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1448), new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1449) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1450), new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1450) });

            migrationBuilder.UpdateData(
                table: "ProcessRecords",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AssignedTo", "CreatedDate", "ExpectedDueDate", "FieldValuesJson", "ModifiedDate", "Priority", "SubmittedDate" },
                values: new object[] { null, new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1469), null, "{\"Title\":\"Upgrade HR Portal Database\",\"Description\":\"Database needs to be migrated to the latest version for better performance.\",\"Priority\":\"HIGH\",\"ChangeType\":\"STANDARD\",\"ImplementationDate\":\"2024-12-01\",\"CRNumber\":\"CR-2024-001\"}", new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1470), null, new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1470) });

            migrationBuilder.InsertData(
                table: "ProcessRecords",
                columns: new[] { "Id", "ApplicationId", "AssignedTo", "CreatedDate", "ExpectedDueDate", "FieldValuesJson", "ModifiedDate", "Notes", "Priority", "ProcessDefinitionId", "RecordNumber", "RecordStatus", "SubmittedDate" },
                values: new object[,]
                {
                    { 101L, 2, null, new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1475), null, "{\"Title\":\"CRM Login Gateway Down\",\"Description\":\"Customer logins are timing out on the central gateway.\",\"IncidentId\":\"INC-2024-001\",\"Severity\":\"CRITICAL\",\"ReportedDate\":\"2024-09-20T10:00:00Z\",\"AffectedUsers\":\"1500\",\"ResolutionNotes\":\"Rebooted instances\"}", new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1475), null, null, 2, "INC-2024-001", "Submitted", new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1476) },
                    { 102L, 2, null, new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1478), null, "{\"Title\":\"Payment Gateway Latency\",\"Description\":\"Payments are processing but taking up to 30 seconds.\",\"IncidentId\":\"INC-2024-002\",\"Severity\":\"MAJOR\",\"ReportedDate\":\"2024-09-21T08:30:00Z\",\"AffectedUsers\":\"250\"}", new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1478), null, null, 2, "INC-2024-002", "Draft", null },
                    { 103L, 3, null, new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1480), null, "{\"TestId\":\"UT-2024-001\",\"ModuleUnderTest\":\"BillingCalculator\",\"TestCases\":\"45\",\"PassedCases\":\"44\",\"FailedCases\":\"1\",\"CodeCoverage\":\"85\",\"TestStatus\":\"FAILED\",\"Notes\":\"Failing isolated edge case on leap year billing calculation.\"}", new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1480), null, null, 3, "UT-2024-001", "Submitted", new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1480) },
                    { 104L, 3, null, new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1482), null, "{\"TestId\":\"UT-2024-002\",\"ModuleUnderTest\":\"AuthTokenService\",\"TestCases\":\"12\",\"PassedCases\":\"12\",\"FailedCases\":\"0\",\"CodeCoverage\":\"100\",\"TestStatus\":\"PASSED\",\"Notes\":\"Fully verified standard configurations.\"}", new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1482), null, null, 3, "UT-2024-002", "Submitted", new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1483) }
                });
        }
    }
}
