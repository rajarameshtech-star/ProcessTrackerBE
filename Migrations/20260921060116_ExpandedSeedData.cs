using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProcessTracker.Migrations
{
    /// <inheritdoc />
    public partial class ExpandedSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(5760), new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(5763) });

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(5764), new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(5765) });

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(5766), new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(5767) });

            migrationBuilder.UpdateData(
                table: "ProcessDefinitions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(5887), new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(5888) });

            migrationBuilder.UpdateData(
                table: "ProcessDefinitions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(5890), new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "ProcessDefinitions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(5892), new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(5892) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(5911), new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(5912) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(5915), new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(5915) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(5917), new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(5918) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(5920), new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(5920) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(5922), new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(5922) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(5924), new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(5924) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(5926), new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(5926) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(5928), new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(5929) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(5971), new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(5971) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(5975), new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(5975) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(5977), new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(5977) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(5979), new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(5979) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(5981), new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(5981) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(5987), new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(5988) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(5989), new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(5989) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(6004), new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(6005) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(6006), new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(6007) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(6009), new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(6009) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(6011), new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(6011) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(6013), new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(6014) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(6016), new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(6016) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(6018), new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(6018) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(6020), new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(6020) });

            migrationBuilder.UpdateData(
                table: "ProcessRecords",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "SubmittedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(6040), new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(6041), new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(6041) });

            migrationBuilder.InsertData(
                table: "ProcessRecords",
                columns: new[] { "Id", "ApplicationId", "CreatedDate", "FieldValuesJson", "ModifiedDate", "Notes", "ProcessDefinitionId", "RecordNumber", "RecordStatus", "SubmittedDate" },
                values: new object[,]
                {
                    { 101L, 2, new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(6045), "{\"Title\":\"CRM Login Gateway Down\",\"Description\":\"Customer logins are timing out on the central gateway.\",\"IncidentId\":\"INC-2024-001\",\"Severity\":\"CRITICAL\",\"ReportedDate\":\"2024-09-20T10:00:00Z\",\"AffectedUsers\":\"1500\",\"ResolutionNotes\":\"Rebooted instances\"}", new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(6046), null, 2, "INC-2024-001", "Submitted", new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(6047) },
                    { 102L, 2, new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(6048), "{\"Title\":\"Payment Gateway Latency\",\"Description\":\"Payments are processing but taking up to 30 seconds.\",\"IncidentId\":\"INC-2024-002\",\"Severity\":\"MAJOR\",\"ReportedDate\":\"2024-09-21T08:30:00Z\",\"AffectedUsers\":\"250\"}", new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(6049), null, 2, "INC-2024-002", "Draft", null },
                    { 103L, 3, new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(6050), "{\"TestId\":\"UT-2024-001\",\"ModuleUnderTest\":\"BillingCalculator\",\"TestCases\":\"45\",\"PassedCases\":\"44\",\"FailedCases\":\"1\",\"CodeCoverage\":\"85\",\"TestStatus\":\"FAILED\",\"Notes\":\"Failing isolated edge case on leap year billing calculation.\"}", new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(6051), null, 3, "UT-2024-001", "Submitted", new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(6051) },
                    { 104L, 3, new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(6052), "{\"TestId\":\"UT-2024-002\",\"ModuleUnderTest\":\"AuthTokenService\",\"TestCases\":\"12\",\"PassedCases\":\"12\",\"FailedCases\":\"0\",\"CodeCoverage\":\"100\",\"TestStatus\":\"PASSED\",\"Notes\":\"Fully verified standard configurations.\"}", new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(6053), null, 3, "UT-2024-002", "Submitted", new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(6053) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new DateTime(2026, 9, 21, 5, 47, 39, 862, DateTimeKind.Utc).AddTicks(9779), new DateTime(2026, 9, 21, 5, 47, 39, 862, DateTimeKind.Utc).AddTicks(9781) });

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 5, 47, 39, 862, DateTimeKind.Utc).AddTicks(9783), new DateTime(2026, 9, 21, 5, 47, 39, 862, DateTimeKind.Utc).AddTicks(9784) });

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 5, 47, 39, 862, DateTimeKind.Utc).AddTicks(9785), new DateTime(2026, 9, 21, 5, 47, 39, 862, DateTimeKind.Utc).AddTicks(9786) });

            migrationBuilder.UpdateData(
                table: "ProcessDefinitions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 5, 47, 39, 862, DateTimeKind.Utc).AddTicks(9920), new DateTime(2026, 9, 21, 5, 47, 39, 862, DateTimeKind.Utc).AddTicks(9920) });

            migrationBuilder.UpdateData(
                table: "ProcessDefinitions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 5, 47, 39, 862, DateTimeKind.Utc).AddTicks(9922), new DateTime(2026, 9, 21, 5, 47, 39, 862, DateTimeKind.Utc).AddTicks(9923) });

            migrationBuilder.UpdateData(
                table: "ProcessDefinitions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 5, 47, 39, 862, DateTimeKind.Utc).AddTicks(9925), new DateTime(2026, 9, 21, 5, 47, 39, 862, DateTimeKind.Utc).AddTicks(9925) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 5, 47, 39, 862, DateTimeKind.Utc).AddTicks(9945), new DateTime(2026, 9, 21, 5, 47, 39, 862, DateTimeKind.Utc).AddTicks(9946) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 5, 47, 39, 862, DateTimeKind.Utc).AddTicks(9948), new DateTime(2026, 9, 21, 5, 47, 39, 862, DateTimeKind.Utc).AddTicks(9949) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 5, 47, 39, 862, DateTimeKind.Utc).AddTicks(9951), new DateTime(2026, 9, 21, 5, 47, 39, 862, DateTimeKind.Utc).AddTicks(9951) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 5, 47, 39, 862, DateTimeKind.Utc).AddTicks(9953), new DateTime(2026, 9, 21, 5, 47, 39, 862, DateTimeKind.Utc).AddTicks(9953) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 5, 47, 39, 862, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 9, 21, 5, 47, 39, 862, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 5, 47, 39, 862, DateTimeKind.Utc).AddTicks(9957), new DateTime(2026, 9, 21, 5, 47, 39, 862, DateTimeKind.Utc).AddTicks(9957) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 5, 47, 39, 862, DateTimeKind.Utc).AddTicks(9959), new DateTime(2026, 9, 21, 5, 47, 39, 862, DateTimeKind.Utc).AddTicks(9959) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 5, 47, 39, 862, DateTimeKind.Utc).AddTicks(9961), new DateTime(2026, 9, 21, 5, 47, 39, 862, DateTimeKind.Utc).AddTicks(9961) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 5, 47, 39, 862, DateTimeKind.Utc).AddTicks(9978), new DateTime(2026, 9, 21, 5, 47, 39, 862, DateTimeKind.Utc).AddTicks(9978) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 5, 47, 39, 862, DateTimeKind.Utc).AddTicks(9980), new DateTime(2026, 9, 21, 5, 47, 39, 862, DateTimeKind.Utc).AddTicks(9981) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 5, 47, 39, 862, DateTimeKind.Utc).AddTicks(9983), new DateTime(2026, 9, 21, 5, 47, 39, 862, DateTimeKind.Utc).AddTicks(9983) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 5, 47, 39, 862, DateTimeKind.Utc).AddTicks(9985), new DateTime(2026, 9, 21, 5, 47, 39, 862, DateTimeKind.Utc).AddTicks(9985) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 5, 47, 39, 862, DateTimeKind.Utc).AddTicks(9987), new DateTime(2026, 9, 21, 5, 47, 39, 862, DateTimeKind.Utc).AddTicks(9987) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 5, 47, 39, 862, DateTimeKind.Utc).AddTicks(9994), new DateTime(2026, 9, 21, 5, 47, 39, 862, DateTimeKind.Utc).AddTicks(9994) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 5, 47, 39, 862, DateTimeKind.Utc).AddTicks(9996), new DateTime(2026, 9, 21, 5, 47, 39, 862, DateTimeKind.Utc).AddTicks(9996) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 5, 47, 39, 863, DateTimeKind.Utc).AddTicks(12), new DateTime(2026, 9, 21, 5, 47, 39, 863, DateTimeKind.Utc).AddTicks(13) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 5, 47, 39, 863, DateTimeKind.Utc).AddTicks(14), new DateTime(2026, 9, 21, 5, 47, 39, 863, DateTimeKind.Utc).AddTicks(15) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 5, 47, 39, 863, DateTimeKind.Utc).AddTicks(17), new DateTime(2026, 9, 21, 5, 47, 39, 863, DateTimeKind.Utc).AddTicks(17) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 5, 47, 39, 863, DateTimeKind.Utc).AddTicks(19), new DateTime(2026, 9, 21, 5, 47, 39, 863, DateTimeKind.Utc).AddTicks(20) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 5, 47, 39, 863, DateTimeKind.Utc).AddTicks(21), new DateTime(2026, 9, 21, 5, 47, 39, 863, DateTimeKind.Utc).AddTicks(22) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 5, 47, 39, 863, DateTimeKind.Utc).AddTicks(24), new DateTime(2026, 9, 21, 5, 47, 39, 863, DateTimeKind.Utc).AddTicks(25) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 5, 47, 39, 863, DateTimeKind.Utc).AddTicks(26), new DateTime(2026, 9, 21, 5, 47, 39, 863, DateTimeKind.Utc).AddTicks(27) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 5, 47, 39, 863, DateTimeKind.Utc).AddTicks(28), new DateTime(2026, 9, 21, 5, 47, 39, 863, DateTimeKind.Utc).AddTicks(29) });

            migrationBuilder.UpdateData(
                table: "ProcessRecords",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "SubmittedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 5, 47, 39, 863, DateTimeKind.Utc).AddTicks(66), new DateTime(2026, 9, 21, 5, 47, 39, 863, DateTimeKind.Utc).AddTicks(66), new DateTime(2026, 9, 21, 5, 47, 39, 863, DateTimeKind.Utc).AddTicks(67) });
        }
    }
}
