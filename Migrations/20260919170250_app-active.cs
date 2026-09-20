using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProcessTracker.Migrations
{
    /// <inheritdoc />
    public partial class appactive : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Applications",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "IsActive", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9159), true, new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9160) });

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "IsActive", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9162), true, new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9163) });

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "IsActive", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9164), true, new DateTime(2026, 9, 19, 17, 2, 50, 43, DateTimeKind.Utc).AddTicks(9165) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Applications");

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(2958), new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(2961) });

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(2963), new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(2964) });

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(2965), new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(2966) });

            migrationBuilder.UpdateData(
                table: "ProcessDefinitions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3147), new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3148) });

            migrationBuilder.UpdateData(
                table: "ProcessDefinitions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3150), new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3151) });

            migrationBuilder.UpdateData(
                table: "ProcessDefinitions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3153), new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3153) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3179), new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3181) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3185), new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3186) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3188), new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3191), new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3192) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3194), new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3194) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3196), new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3197) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3199), new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3200) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3202), new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3203) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3225), new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3226) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3228), new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3229) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3231), new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3231) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3233), new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3234) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3236), new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3237) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3244), new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3245) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3247), new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3247) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3319), new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3320) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3322), new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3323) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3325), new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3326) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3328), new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3328) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3331), new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3331) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3334), new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3334) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3336), new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3337) });

            migrationBuilder.UpdateData(
                table: "ProcessFields",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3339), new DateTime(2026, 9, 19, 13, 5, 46, 239, DateTimeKind.Utc).AddTicks(3339) });
        }
    }
}
