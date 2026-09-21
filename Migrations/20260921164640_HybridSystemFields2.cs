using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProcessTracker.Migrations
{
    /// <inheritdoc />
    public partial class HybridSystemFields2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AssignedTo",
                table: "ProcessRecords",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpectedDueDate",
                table: "ProcessRecords",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Priority",
                table: "ProcessRecords",
                type: "nvarchar(max)",
                nullable: true);

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
                columns: new[] { "AssignedTo", "CreatedDate", "ExpectedDueDate", "ModifiedDate", "Priority", "SubmittedDate" },
                values: new object[] { null, new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1469), null, new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1470), null, new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1470) });

            migrationBuilder.UpdateData(
                table: "ProcessRecords",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "AssignedTo", "CreatedDate", "ExpectedDueDate", "ModifiedDate", "Priority", "SubmittedDate" },
                values: new object[] { null, new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1475), null, new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1475), null, new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1476) });

            migrationBuilder.UpdateData(
                table: "ProcessRecords",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "AssignedTo", "CreatedDate", "ExpectedDueDate", "ModifiedDate", "Priority" },
                values: new object[] { null, new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1478), null, new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1478), null });

            migrationBuilder.UpdateData(
                table: "ProcessRecords",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "AssignedTo", "CreatedDate", "ExpectedDueDate", "ModifiedDate", "Priority", "SubmittedDate" },
                values: new object[] { null, new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1480), null, new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1480), null, new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1480) });

            migrationBuilder.UpdateData(
                table: "ProcessRecords",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "AssignedTo", "CreatedDate", "ExpectedDueDate", "ModifiedDate", "Priority", "SubmittedDate" },
                values: new object[] { null, new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1482), null, new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1482), null, new DateTime(2026, 9, 21, 16, 46, 39, 904, DateTimeKind.Utc).AddTicks(1483) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AssignedTo",
                table: "ProcessRecords");

            migrationBuilder.DropColumn(
                name: "ExpectedDueDate",
                table: "ProcessRecords");

            migrationBuilder.DropColumn(
                name: "Priority",
                table: "ProcessRecords");

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

            migrationBuilder.UpdateData(
                table: "ProcessRecords",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedDate", "ModifiedDate", "SubmittedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(6045), new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(6046), new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(6047) });

            migrationBuilder.UpdateData(
                table: "ProcessRecords",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(6048), new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(6049) });

            migrationBuilder.UpdateData(
                table: "ProcessRecords",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedDate", "ModifiedDate", "SubmittedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(6050), new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(6051), new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(6051) });

            migrationBuilder.UpdateData(
                table: "ProcessRecords",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedDate", "ModifiedDate", "SubmittedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(6052), new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(6053), new DateTime(2026, 9, 21, 6, 1, 15, 844, DateTimeKind.Utc).AddTicks(6053) });
        }
    }
}
