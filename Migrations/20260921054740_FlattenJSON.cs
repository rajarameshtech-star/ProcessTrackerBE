using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProcessTracker.Migrations
{
    /// <inheritdoc />
    public partial class FlattenJSON : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProcessRecordFieldValues");

            migrationBuilder.AddColumn<string>(
                name: "FieldValuesJson",
                table: "ProcessRecords",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
                columns: new[] { "CreatedDate", "FieldValuesJson", "ModifiedDate", "SubmittedDate" },
                values: new object[] { new DateTime(2026, 9, 21, 5, 47, 39, 863, DateTimeKind.Utc).AddTicks(66), "{\"Title\":\"Upgrade HR Portal Database\",\"Description\":\"Database needs to be migrated to the latest version for better performance.\",\"Priority\":\"HIGH\",\"ChangeType\":\"STANDARD\",\"ImplementationDate\":\"2024-12-01\",\"CRNumber\":\"CR-2024-001\"}", new DateTime(2026, 9, 21, 5, 47, 39, 863, DateTimeKind.Utc).AddTicks(66), new DateTime(2026, 9, 21, 5, 47, 39, 863, DateTimeKind.Utc).AddTicks(67) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FieldValuesJson",
                table: "ProcessRecords");

            migrationBuilder.CreateTable(
                name: "ProcessRecordFieldValues",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProcessFieldId = table.Column<int>(type: "int", nullable: false),
                    ProcessRecordId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FieldValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
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

            migrationBuilder.InsertData(
                table: "ProcessRecordFieldValues",
                columns: new[] { "Id", "CreatedDate", "FieldValue", "ModifiedDate", "ProcessFieldId", "ProcessRecordId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2423), "Upgrade HR Portal Database", new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2424), 1, 1L },
                    { 2L, new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2425), "Database needs to be migrated to the latest version for better performance.", new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2426), 2, 1L },
                    { 3L, new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2427), "HIGH", new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2427), 3, 1L },
                    { 4L, new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2428), "STANDARD", new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2428), 4, 1L },
                    { 5L, new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2429), "2024-12-01", new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2430), 6, 1L },
                    { 6L, new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2431), "CR-2024-001", new DateTime(2026, 9, 20, 19, 37, 47, 843, DateTimeKind.Utc).AddTicks(2431), 8, 1L }
                });

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
    }
}
