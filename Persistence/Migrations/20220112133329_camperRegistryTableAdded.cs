using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class camperRegistryTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CamperRegistry_Cabins_CabinId",
                table: "CamperRegistry");

            migrationBuilder.DropForeignKey(
                name: "FK_CamperRegistry_Campers_CamperId",
                table: "CamperRegistry");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CamperRegistry",
                table: "CamperRegistry");

            migrationBuilder.RenameTable(
                name: "CamperRegistry",
                newName: "CamperRegistries");

            migrationBuilder.RenameIndex(
                name: "IX_CamperRegistry_CamperId",
                table: "CamperRegistries",
                newName: "IX_CamperRegistries_CamperId");

            migrationBuilder.RenameIndex(
                name: "IX_CamperRegistry_CabinId",
                table: "CamperRegistries",
                newName: "IX_CamperRegistries_CabinId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CamperRegistries",
                table: "CamperRegistries",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Cabins",
                keyColumn: "Id",
                keyValue: 1,
                column: "CounselorId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Cabins",
                keyColumn: "Id",
                keyValue: 2,
                column: "CounselorId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Cabins",
                keyColumn: "Id",
                keyValue: 3,
                column: "CounselorId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Cabins",
                keyColumn: "Id",
                keyValue: 4,
                column: "CounselorId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Cabins",
                keyColumn: "Id",
                keyValue: 5,
                column: "CounselorId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 12, 14, 33, 29, 156, DateTimeKind.Local).AddTicks(7381), new DateTime(2022, 4, 12, 14, 33, 29, 156, DateTimeKind.Local).AddTicks(7574) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 12, 14, 33, 29, 156, DateTimeKind.Local).AddTicks(7749), new DateTime(2022, 4, 12, 14, 33, 29, 156, DateTimeKind.Local).AddTicks(7754) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 12, 14, 33, 29, 156, DateTimeKind.Local).AddTicks(7758), new DateTime(2022, 4, 12, 14, 33, 29, 156, DateTimeKind.Local).AddTicks(7760) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 12, 14, 33, 29, 156, DateTimeKind.Local).AddTicks(7762), new DateTime(2022, 4, 12, 14, 33, 29, 156, DateTimeKind.Local).AddTicks(7764) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 12, 14, 33, 29, 156, DateTimeKind.Local).AddTicks(7767), new DateTime(2022, 4, 12, 14, 33, 29, 156, DateTimeKind.Local).AddTicks(7769) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 12, 14, 33, 29, 156, DateTimeKind.Local).AddTicks(7773), new DateTime(2022, 4, 12, 14, 33, 29, 156, DateTimeKind.Local).AddTicks(7775) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 12, 14, 33, 29, 156, DateTimeKind.Local).AddTicks(7777), new DateTime(2022, 4, 12, 14, 33, 29, 156, DateTimeKind.Local).AddTicks(7779) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 12, 14, 33, 29, 156, DateTimeKind.Local).AddTicks(7782), new DateTime(2022, 4, 12, 14, 33, 29, 156, DateTimeKind.Local).AddTicks(7783) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 12, 14, 33, 29, 156, DateTimeKind.Local).AddTicks(7786), new DateTime(2022, 4, 12, 14, 33, 29, 156, DateTimeKind.Local).AddTicks(7788) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 12, 14, 33, 29, 156, DateTimeKind.Local).AddTicks(7791), new DateTime(2022, 4, 12, 14, 33, 29, 156, DateTimeKind.Local).AddTicks(7793) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 12, 14, 33, 29, 156, DateTimeKind.Local).AddTicks(7795), new DateTime(2022, 4, 12, 14, 33, 29, 156, DateTimeKind.Local).AddTicks(7797) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 12, 14, 33, 29, 156, DateTimeKind.Local).AddTicks(7799), new DateTime(2022, 4, 12, 14, 33, 29, 156, DateTimeKind.Local).AddTicks(7801) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 12, 14, 33, 29, 156, DateTimeKind.Local).AddTicks(7804), new DateTime(2022, 4, 12, 14, 33, 29, 156, DateTimeKind.Local).AddTicks(7805) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 12, 14, 33, 29, 156, DateTimeKind.Local).AddTicks(7808), new DateTime(2022, 4, 12, 14, 33, 29, 156, DateTimeKind.Local).AddTicks(7810) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 12, 14, 33, 29, 156, DateTimeKind.Local).AddTicks(7812), new DateTime(2022, 4, 12, 14, 33, 29, 156, DateTimeKind.Local).AddTicks(7814) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 12, 14, 33, 29, 156, DateTimeKind.Local).AddTicks(7817), new DateTime(2022, 4, 12, 14, 33, 29, 156, DateTimeKind.Local).AddTicks(7818) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 12, 14, 33, 29, 156, DateTimeKind.Local).AddTicks(7821), new DateTime(2022, 4, 12, 14, 33, 29, 156, DateTimeKind.Local).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 12, 14, 33, 29, 156, DateTimeKind.Local).AddTicks(7863), new DateTime(2022, 4, 12, 14, 33, 29, 156, DateTimeKind.Local).AddTicks(7865) });

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2012, 1, 12, 14, 33, 29, 156, DateTimeKind.Local).AddTicks(103));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2011, 1, 12, 14, 33, 29, 156, DateTimeKind.Local).AddTicks(335));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2010, 1, 12, 14, 33, 29, 156, DateTimeKind.Local).AddTicks(343));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(2012, 1, 12, 14, 33, 29, 156, DateTimeKind.Local).AddTicks(346));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(2013, 1, 12, 14, 33, 29, 156, DateTimeKind.Local).AddTicks(349));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfBirth",
                value: new DateTime(2014, 1, 12, 14, 33, 29, 156, DateTimeKind.Local).AddTicks(354));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfBirth",
                value: new DateTime(2013, 1, 12, 14, 33, 29, 156, DateTimeKind.Local).AddTicks(357));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateOfBirth",
                value: new DateTime(2012, 1, 12, 14, 33, 29, 156, DateTimeKind.Local).AddTicks(359));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateOfBirth",
                value: new DateTime(2011, 1, 12, 14, 33, 29, 156, DateTimeKind.Local).AddTicks(362));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateOfBirth",
                value: new DateTime(2011, 1, 12, 14, 33, 29, 156, DateTimeKind.Local).AddTicks(366));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateOfBirth",
                value: new DateTime(2010, 1, 12, 14, 33, 29, 156, DateTimeKind.Local).AddTicks(369));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateOfBirth",
                value: new DateTime(2009, 1, 12, 14, 33, 29, 156, DateTimeKind.Local).AddTicks(372));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateOfBirth",
                value: new DateTime(2011, 1, 12, 14, 33, 29, 156, DateTimeKind.Local).AddTicks(374));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateOfBirth",
                value: new DateTime(2010, 1, 12, 14, 33, 29, 156, DateTimeKind.Local).AddTicks(378));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateOfBirth",
                value: new DateTime(2011, 1, 12, 14, 33, 29, 156, DateTimeKind.Local).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateOfBirth",
                value: new DateTime(2012, 1, 12, 14, 33, 29, 156, DateTimeKind.Local).AddTicks(383));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateOfBirth",
                value: new DateTime(2011, 1, 12, 14, 33, 29, 156, DateTimeKind.Local).AddTicks(386));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateOfBirth",
                value: new DateTime(2013, 1, 12, 14, 33, 29, 156, DateTimeKind.Local).AddTicks(389));

            migrationBuilder.UpdateData(
                table: "CounselorRegistries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssignmentEnd", "AssignmentStart" },
                values: new object[] { new DateTime(2022, 4, 12, 14, 33, 29, 157, DateTimeKind.Local).AddTicks(1128), new DateTime(2022, 1, 12, 14, 33, 29, 157, DateTimeKind.Local).AddTicks(947) });

            migrationBuilder.UpdateData(
                table: "CounselorRegistries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AssignmentEnd", "AssignmentStart" },
                values: new object[] { new DateTime(2022, 4, 12, 14, 33, 29, 157, DateTimeKind.Local).AddTicks(1307), new DateTime(2022, 1, 12, 14, 33, 29, 157, DateTimeKind.Local).AddTicks(1302) });

            migrationBuilder.UpdateData(
                table: "CounselorRegistries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AssignmentEnd", "AssignmentStart" },
                values: new object[] { new DateTime(2022, 4, 12, 14, 33, 29, 157, DateTimeKind.Local).AddTicks(1312), new DateTime(2022, 1, 12, 14, 33, 29, 157, DateTimeKind.Local).AddTicks(1310) });

            migrationBuilder.UpdateData(
                table: "CounselorRegistries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AssignmentEnd", "AssignmentStart" },
                values: new object[] { new DateTime(2022, 4, 12, 14, 33, 29, 157, DateTimeKind.Local).AddTicks(1317), new DateTime(2022, 1, 12, 14, 33, 29, 157, DateTimeKind.Local).AddTicks(1315) });

            migrationBuilder.UpdateData(
                table: "CounselorRegistries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AssignmentEnd", "AssignmentStart" },
                values: new object[] { new DateTime(2022, 4, 12, 14, 33, 29, 157, DateTimeKind.Local).AddTicks(1321), new DateTime(2022, 1, 12, 14, 33, 29, 157, DateTimeKind.Local).AddTicks(1319) });

            migrationBuilder.UpdateData(
                table: "Counselors",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(1992, 1, 12, 14, 33, 29, 152, DateTimeKind.Local).AddTicks(5332));

            migrationBuilder.UpdateData(
                table: "Counselors",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(1999, 1, 12, 14, 33, 29, 155, DateTimeKind.Local).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "Counselors",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(1996, 1, 12, 14, 33, 29, 155, DateTimeKind.Local).AddTicks(795));

            migrationBuilder.UpdateData(
                table: "Counselors",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(1993, 1, 12, 14, 33, 29, 155, DateTimeKind.Local).AddTicks(801));

            migrationBuilder.UpdateData(
                table: "Counselors",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(1997, 1, 12, 14, 33, 29, 155, DateTimeKind.Local).AddTicks(804));

            migrationBuilder.AddForeignKey(
                name: "FK_CamperRegistries_Cabins_CabinId",
                table: "CamperRegistries",
                column: "CabinId",
                principalTable: "Cabins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CamperRegistries_Campers_CamperId",
                table: "CamperRegistries",
                column: "CamperId",
                principalTable: "Campers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CamperRegistries_Cabins_CabinId",
                table: "CamperRegistries");

            migrationBuilder.DropForeignKey(
                name: "FK_CamperRegistries_Campers_CamperId",
                table: "CamperRegistries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CamperRegistries",
                table: "CamperRegistries");

            migrationBuilder.RenameTable(
                name: "CamperRegistries",
                newName: "CamperRegistry");

            migrationBuilder.RenameIndex(
                name: "IX_CamperRegistries_CamperId",
                table: "CamperRegistry",
                newName: "IX_CamperRegistry_CamperId");

            migrationBuilder.RenameIndex(
                name: "IX_CamperRegistries_CabinId",
                table: "CamperRegistry",
                newName: "IX_CamperRegistry_CabinId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CamperRegistry",
                table: "CamperRegistry",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Cabins",
                keyColumn: "Id",
                keyValue: 1,
                column: "CounselorId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Cabins",
                keyColumn: "Id",
                keyValue: 2,
                column: "CounselorId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Cabins",
                keyColumn: "Id",
                keyValue: 3,
                column: "CounselorId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Cabins",
                keyColumn: "Id",
                keyValue: 4,
                column: "CounselorId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Cabins",
                keyColumn: "Id",
                keyValue: 5,
                column: "CounselorId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "CamperRegistry",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(1446), new DateTime(2022, 4, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(3301) });

            migrationBuilder.UpdateData(
                table: "CamperRegistry",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5388), new DateTime(2022, 4, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5445) });

            migrationBuilder.UpdateData(
                table: "CamperRegistry",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5457), new DateTime(2022, 4, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5469) });

            migrationBuilder.UpdateData(
                table: "CamperRegistry",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5477), new DateTime(2022, 4, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5481) });

            migrationBuilder.UpdateData(
                table: "CamperRegistry",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5488), new DateTime(2022, 4, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5492) });

            migrationBuilder.UpdateData(
                table: "CamperRegistry",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5516), new DateTime(2022, 4, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5523) });

            migrationBuilder.UpdateData(
                table: "CamperRegistry",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5532), new DateTime(2022, 4, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5539) });

            migrationBuilder.UpdateData(
                table: "CamperRegistry",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5547), new DateTime(2022, 4, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5554) });

            migrationBuilder.UpdateData(
                table: "CamperRegistry",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5563), new DateTime(2022, 4, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5568) });

            migrationBuilder.UpdateData(
                table: "CamperRegistry",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5581), new DateTime(2022, 4, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5587) });

            migrationBuilder.UpdateData(
                table: "CamperRegistry",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5596), new DateTime(2022, 4, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5602) });

            migrationBuilder.UpdateData(
                table: "CamperRegistry",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5611), new DateTime(2022, 4, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5617) });

            migrationBuilder.UpdateData(
                table: "CamperRegistry",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5624), new DateTime(2022, 4, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "CamperRegistry",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5638), new DateTime(2022, 4, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5644) });

            migrationBuilder.UpdateData(
                table: "CamperRegistry",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5652), new DateTime(2022, 4, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5658) });

            migrationBuilder.UpdateData(
                table: "CamperRegistry",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5666), new DateTime(2022, 4, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5673) });

            migrationBuilder.UpdateData(
                table: "CamperRegistry",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5682), new DateTime(2022, 4, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5689) });

            migrationBuilder.UpdateData(
                table: "CamperRegistry",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5703), new DateTime(2022, 4, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5710) });

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2012, 1, 12, 13, 57, 55, 500, DateTimeKind.Local).AddTicks(3124));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2011, 1, 12, 13, 57, 55, 500, DateTimeKind.Local).AddTicks(4006));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2010, 1, 12, 13, 57, 55, 500, DateTimeKind.Local).AddTicks(4027));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(2012, 1, 12, 13, 57, 55, 500, DateTimeKind.Local).AddTicks(4034));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(2013, 1, 12, 13, 57, 55, 500, DateTimeKind.Local).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfBirth",
                value: new DateTime(2014, 1, 12, 13, 57, 55, 500, DateTimeKind.Local).AddTicks(4063));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfBirth",
                value: new DateTime(2013, 1, 12, 13, 57, 55, 500, DateTimeKind.Local).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateOfBirth",
                value: new DateTime(2012, 1, 12, 13, 57, 55, 500, DateTimeKind.Local).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateOfBirth",
                value: new DateTime(2011, 1, 12, 13, 57, 55, 500, DateTimeKind.Local).AddTicks(4155));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateOfBirth",
                value: new DateTime(2011, 1, 12, 13, 57, 55, 500, DateTimeKind.Local).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateOfBirth",
                value: new DateTime(2010, 1, 12, 13, 57, 55, 500, DateTimeKind.Local).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateOfBirth",
                value: new DateTime(2009, 1, 12, 13, 57, 55, 500, DateTimeKind.Local).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateOfBirth",
                value: new DateTime(2011, 1, 12, 13, 57, 55, 500, DateTimeKind.Local).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateOfBirth",
                value: new DateTime(2010, 1, 12, 13, 57, 55, 500, DateTimeKind.Local).AddTicks(4191));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateOfBirth",
                value: new DateTime(2011, 1, 12, 13, 57, 55, 500, DateTimeKind.Local).AddTicks(4197));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateOfBirth",
                value: new DateTime(2012, 1, 12, 13, 57, 55, 500, DateTimeKind.Local).AddTicks(4204));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateOfBirth",
                value: new DateTime(2011, 1, 12, 13, 57, 55, 500, DateTimeKind.Local).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateOfBirth",
                value: new DateTime(2013, 1, 12, 13, 57, 55, 500, DateTimeKind.Local).AddTicks(4219));

            migrationBuilder.UpdateData(
                table: "CounselorRegistries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssignmentEnd", "AssignmentStart" },
                values: new object[] { new DateTime(2022, 4, 12, 13, 57, 55, 504, DateTimeKind.Local).AddTicks(843), new DateTime(2022, 1, 12, 13, 57, 55, 504, DateTimeKind.Local).AddTicks(196) });

            migrationBuilder.UpdateData(
                table: "CounselorRegistries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AssignmentEnd", "AssignmentStart" },
                values: new object[] { new DateTime(2022, 4, 12, 13, 57, 55, 504, DateTimeKind.Local).AddTicks(1408), new DateTime(2022, 1, 12, 13, 57, 55, 504, DateTimeKind.Local).AddTicks(1392) });

            migrationBuilder.UpdateData(
                table: "CounselorRegistries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AssignmentEnd", "AssignmentStart" },
                values: new object[] { new DateTime(2022, 4, 12, 13, 57, 55, 504, DateTimeKind.Local).AddTicks(1428), new DateTime(2022, 1, 12, 13, 57, 55, 504, DateTimeKind.Local).AddTicks(1420) });

            migrationBuilder.UpdateData(
                table: "CounselorRegistries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AssignmentEnd", "AssignmentStart" },
                values: new object[] { new DateTime(2022, 4, 12, 13, 57, 55, 504, DateTimeKind.Local).AddTicks(1444), new DateTime(2022, 1, 12, 13, 57, 55, 504, DateTimeKind.Local).AddTicks(1437) });

            migrationBuilder.UpdateData(
                table: "CounselorRegistries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AssignmentEnd", "AssignmentStart" },
                values: new object[] { new DateTime(2022, 4, 12, 13, 57, 55, 504, DateTimeKind.Local).AddTicks(1461), new DateTime(2022, 1, 12, 13, 57, 55, 504, DateTimeKind.Local).AddTicks(1454) });

            migrationBuilder.UpdateData(
                table: "Counselors",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(1992, 1, 12, 13, 57, 55, 492, DateTimeKind.Local).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "Counselors",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(1999, 1, 12, 13, 57, 55, 498, DateTimeKind.Local).AddTicks(547));

            migrationBuilder.UpdateData(
                table: "Counselors",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(1996, 1, 12, 13, 57, 55, 498, DateTimeKind.Local).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "Counselors",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(1993, 1, 12, 13, 57, 55, 498, DateTimeKind.Local).AddTicks(643));

            migrationBuilder.UpdateData(
                table: "Counselors",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(1997, 1, 12, 13, 57, 55, 498, DateTimeKind.Local).AddTicks(654));

            migrationBuilder.AddForeignKey(
                name: "FK_CamperRegistry_Cabins_CabinId",
                table: "CamperRegistry",
                column: "CabinId",
                principalTable: "Cabins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CamperRegistry_Campers_CamperId",
                table: "CamperRegistry",
                column: "CamperId",
                principalTable: "Campers",
                principalColumn: "Id");
        }
    }
}
