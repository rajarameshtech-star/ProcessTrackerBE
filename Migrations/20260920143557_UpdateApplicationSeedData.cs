using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProcessTracker.Migrations
{
    /// <inheritdoc />
    public partial class UpdateApplicationSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "ModifiedDate", "Title" },
                values: new object[] { new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(1785), "Human Resources portal and management", new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(1786), "HR Management System" });

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "ModifiedDate", "Title" },
                values: new object[] { new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(1787), "CRM application for sales and tracking", new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(1788), "Customer Relationship Management" });

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "ModifiedDate", "Title" },
                values: new object[] { new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(1789), "Internal accounting and billing portal", new DateTime(2026, 9, 20, 14, 35, 56, 793, DateTimeKind.Utc).AddTicks(1789), "Financial Accounting Portal" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "ModifiedDate", "Title" },
                values: new object[] { new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9159), "Process for managing change requests", new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9160), "Change Request" });

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "ModifiedDate", "Title" },
                values: new object[] { new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9162), "Process for reporting and tracking incidents", new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9163), "Incident Management" });

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "ModifiedDate", "Title" },
                values: new object[] { new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9164), "Process for unit testing documentation", new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9165), "Unit Testing" });

            migrationBuilder.UpdateData(
                table: "ProcessDefinitions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9312), new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9313) });

            migrationBuilder.UpdateData(
                table: "ProcessDefinitions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9315), new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9316) });

            migrationBuilder.UpdateData(
                table: "ProcessDefinitions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9317), new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9318) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9336), new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9336) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9339), new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9340) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9342), new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9342) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9344), new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9344) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9346), new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9346) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9348), new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9348) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9350), new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9350) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9352), new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9352) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9371), new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9372) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9374), new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9374) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9376), new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9377) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9378), new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9379) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9380), new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9381) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9386), new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9387) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9388), new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9388) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9405), new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9405) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9407), new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9407) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9409), new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9410) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9412), new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9412) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9414), new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9414) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9443), new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9443) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9445), new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9446) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9447), new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9448) });
        }
    }
}
