using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProcessTracker.Migrations
{
    /// <inheritdoc />
    public partial class AddFieldValuesIndexes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ProcessRecordFieldValues_ProcessFieldId",
                table: "ProcessRecordFieldValues");

            migrationBuilder.DropIndex(
                name: "IX_ProcessRecordFieldValues_ProcessRecordId",
                table: "ProcessRecordFieldValues");

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2137), new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2138) });

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2140), new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2141) });

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2142), new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2142) });

            migrationBuilder.UpdateData(
                table: "ProcessDefinitions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2222), new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2223) });

            migrationBuilder.UpdateData(
                table: "ProcessDefinitions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2225), new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2225) });

            migrationBuilder.UpdateData(
                table: "ProcessDefinitions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2227), new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2227) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2248), new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2248) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2251), new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2252) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2254), new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2254) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2256), new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2257) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2258), new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2259) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2261), new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2262) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2263), new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2264) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2265), new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2266) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2283), new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2284) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2286), new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2286) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2288), new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2288) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2290), new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2290) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2292), new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2292) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2298), new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2298) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2300), new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2300) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2316), new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2317) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2318), new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2319) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2321), new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2321) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2323), new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2323) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2325), new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2325) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2328), new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2328) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2330), new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2330) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2332), new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2332) });

            migrationBuilder.UpdateData(
                table: "ProcessRecordFieldValues",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2423), new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2424) });

            migrationBuilder.UpdateData(
                table: "ProcessRecordFieldValues",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2425), new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2426) });

            migrationBuilder.UpdateData(
                table: "ProcessRecordFieldValues",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2427), new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2427) });

            migrationBuilder.UpdateData(
                table: "ProcessRecordFieldValues",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2428), new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2428) });

            migrationBuilder.UpdateData(
                table: "ProcessRecordFieldValues",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2429), new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2430) });

            migrationBuilder.UpdateData(
                table: "ProcessRecordFieldValues",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2431), new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2431) });

            migrationBuilder.UpdateData(
                table: "ProcessRecords",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "SubmittedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2405), new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2405), new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2406) });

            migrationBuilder.CreateIndex(
                name: "IX_ProcessRecordFieldValues_ProcessFieldId_Include_FieldValue",
                table: "ProcessRecordFieldValues",
                column: "ProcessFieldId")
                .Annotation("SqlServer:Include", new[] { "FieldValue" });

            migrationBuilder.CreateIndex(
                name: "IX_ProcessRecordFieldValues_Record_Field",
                table: "ProcessRecordFieldValues",
                columns: new[] { "ProcessRecordId", "ProcessFieldId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ProcessRecordFieldValues_ProcessFieldId_Include_FieldValue",
                table: "ProcessRecordFieldValues");

            migrationBuilder.DropIndex(
                name: "IX_ProcessRecordFieldValues_Record_Field",
                table: "ProcessRecordFieldValues");

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

            migrationBuilder.UpdateData(
                table: "ProcessRecordFieldValues",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2169), new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2169) });

            migrationBuilder.UpdateData(
                table: "ProcessRecordFieldValues",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2171), new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2171) });

            migrationBuilder.UpdateData(
                table: "ProcessRecordFieldValues",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2172), new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2173) });

            migrationBuilder.UpdateData(
                table: "ProcessRecordFieldValues",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2174), new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2174) });

            migrationBuilder.UpdateData(
                table: "ProcessRecordFieldValues",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2175), new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2175) });

            migrationBuilder.UpdateData(
                table: "ProcessRecordFieldValues",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2177), new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2177) });

            migrationBuilder.UpdateData(
                table: "ProcessRecords",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "SubmittedDate" },
                values: new object[] { new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2152), new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2152), new DateTime(2026, 9, 20, 16, 1, 50, 204, DateTimeKind.Utc).AddTicks(2153) });

            migrationBuilder.CreateIndex(
                name: "IX_ProcessRecordFieldValues_ProcessFieldId",
                table: "ProcessRecordFieldValues",
                column: "ProcessFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_ProcessRecordFieldValues_ProcessRecordId",
                table: "ProcessRecordFieldValues",
                column: "ProcessRecordId");
        }
    }
}
