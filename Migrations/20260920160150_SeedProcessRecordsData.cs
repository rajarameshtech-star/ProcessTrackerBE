using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProcessTracker.Migrations
{
    /// <inheritdoc />
    public partial class SeedProcessRecordsData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(1817), new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(1820) });

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(1822), new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(1822) });

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(1824), new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(1824) });

            migrationBuilder.UpdateData(
                table: "ProcessDefinitions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(1982), new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(1983) });

            migrationBuilder.UpdateData(
                table: "ProcessDefinitions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(1985), new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(1985) });

            migrationBuilder.UpdateData(
                table: "ProcessDefinitions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(1987), new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(1987) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2009), new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2010) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2013), new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2013) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2015), new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2015) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2017), new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2018) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2019), new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2020) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2021), new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2022) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2023), new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2024) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2025), new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2026) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2080), new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2080) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2082), new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2083) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2084), new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2085) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2087), new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2087) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2089), new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2089) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2098), new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2098) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2100), new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2100) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2117), new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2118) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2120), new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2120) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2122), new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2122) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2124), new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2124) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2126), new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2127) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2129), new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2130) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2131), new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2132) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2133), new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2134) });

            migrationBuilder.InsertData(
                table: "ProcessRecords",
                columns: new[] { "Id", "ApplicationId", "CreatedDate", "ModifiedDate", "Notes", "ProcessDefinitionId", "RecordNumber", "RecordStatus", "SubmittedDate" },
                values: new object[] { 1L, 1, new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2152), new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2152), null, 1, "CR-2024-001", "Submitted", new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2153) });

            migrationBuilder.InsertData(
                table: "ProcessRecordFieldValues",
                columns: new[] { "Id", "CreatedDate", "FieldValue", "ModifiedDate", "ProcessFieldId", "ProcessRecordId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2169), "Upgrade HR Portal Database", new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2169), 1, 1L },
                    { 2L, new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2171), "Database needs to be migrated to the latest version for better performance.", new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2171), 2, 1L },
                    { 3L, new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2172), "HIGH", new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2173), 3, 1L },
                    { 4L, new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2174), "STANDARD", new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2174), 4, 1L },
                    { 5L, new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2175), "2024-12-01", new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2175), 6, 1L },
                    { 6L, new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2177), "CR-2024-001", new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2177), 8, 1L }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProcessRecordFieldValues",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "ProcessRecordFieldValues",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "ProcessRecordFieldValues",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "ProcessRecordFieldValues",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "ProcessRecordFieldValues",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "ProcessRecordFieldValues",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "ProcessRecords",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(1785), new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(1786) });

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(1787), new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(1788) });

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(1789), new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(1789) });

            migrationBuilder.UpdateData(
                table: "ProcessDefinitions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(1898), new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(1899) });

            migrationBuilder.UpdateData(
                table: "ProcessDefinitions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(1901), new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(1901) });

            migrationBuilder.UpdateData(
                table: "ProcessDefinitions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(1903), new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(1903) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(2054), new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(2054) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(2057), new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(2058) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(2060), new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(2060) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(2062), new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(2062) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(2064), new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(2064) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(2066), new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(2068), new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(2069) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(2070), new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(2071) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(2088), new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(2089) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(2091), new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(2091) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(2093), new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(2093) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(2095), new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(2095) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(2097), new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(2097) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(2103), new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(2103) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(2105), new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(2105) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(2138), new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(2138) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(2140), new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(2141) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(2143), new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(2143) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(2145), new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(2146) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(2148), new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(2148) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(2151), new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(2151) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(2153), new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(2153) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(2155), new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(2156) });
        }
    }
}
