using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class visitAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Visits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitorId = table.Column<int>(type: "int", nullable: false),
                    CamperId = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Visits_Campers_CamperId",
                        column: x => x.CamperId,
                        principalTable: "Campers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Visits_NextOfKins_VisitorId",
                        column: x => x.VisitorId,
                        principalTable: "NextOfKins",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 13, 9, 26, 33, 369, DateTimeKind.Local).AddTicks(3021), new DateTime(2022, 4, 13, 9, 26, 33, 369, DateTimeKind.Local).AddTicks(3284) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 13, 9, 26, 33, 369, DateTimeKind.Local).AddTicks(3525), new DateTime(2022, 4, 13, 9, 26, 33, 369, DateTimeKind.Local).AddTicks(3532) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 13, 9, 26, 33, 369, DateTimeKind.Local).AddTicks(3537), new DateTime(2022, 4, 13, 9, 26, 33, 369, DateTimeKind.Local).AddTicks(3540) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 13, 9, 26, 33, 369, DateTimeKind.Local).AddTicks(3543), new DateTime(2022, 4, 13, 9, 26, 33, 369, DateTimeKind.Local).AddTicks(3546) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 13, 9, 26, 33, 369, DateTimeKind.Local).AddTicks(3550), new DateTime(2022, 4, 13, 9, 26, 33, 369, DateTimeKind.Local).AddTicks(3553) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 13, 9, 26, 33, 369, DateTimeKind.Local).AddTicks(3559), new DateTime(2022, 4, 13, 9, 26, 33, 369, DateTimeKind.Local).AddTicks(3562) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 13, 9, 26, 33, 369, DateTimeKind.Local).AddTicks(3565), new DateTime(2022, 4, 13, 9, 26, 33, 369, DateTimeKind.Local).AddTicks(3568) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 13, 9, 26, 33, 369, DateTimeKind.Local).AddTicks(3572), new DateTime(2022, 4, 13, 9, 26, 33, 369, DateTimeKind.Local).AddTicks(3574) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 13, 9, 26, 33, 369, DateTimeKind.Local).AddTicks(3578), new DateTime(2022, 4, 13, 9, 26, 33, 369, DateTimeKind.Local).AddTicks(3580) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 13, 9, 26, 33, 369, DateTimeKind.Local).AddTicks(3585), new DateTime(2022, 4, 13, 9, 26, 33, 369, DateTimeKind.Local).AddTicks(3588) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 13, 9, 26, 33, 369, DateTimeKind.Local).AddTicks(3591), new DateTime(2022, 4, 13, 9, 26, 33, 369, DateTimeKind.Local).AddTicks(3594) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 13, 9, 26, 33, 369, DateTimeKind.Local).AddTicks(3597), new DateTime(2022, 4, 13, 9, 26, 33, 369, DateTimeKind.Local).AddTicks(3600) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 13, 9, 26, 33, 369, DateTimeKind.Local).AddTicks(3603), new DateTime(2022, 4, 13, 9, 26, 33, 369, DateTimeKind.Local).AddTicks(3606) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 13, 9, 26, 33, 369, DateTimeKind.Local).AddTicks(3610), new DateTime(2022, 4, 13, 9, 26, 33, 369, DateTimeKind.Local).AddTicks(3613) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 13, 9, 26, 33, 369, DateTimeKind.Local).AddTicks(3617), new DateTime(2022, 4, 13, 9, 26, 33, 369, DateTimeKind.Local).AddTicks(3619) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 13, 9, 26, 33, 369, DateTimeKind.Local).AddTicks(3623), new DateTime(2022, 4, 13, 9, 26, 33, 369, DateTimeKind.Local).AddTicks(3625) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 13, 9, 26, 33, 369, DateTimeKind.Local).AddTicks(3629), new DateTime(2022, 4, 13, 9, 26, 33, 369, DateTimeKind.Local).AddTicks(3632) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 13, 9, 26, 33, 369, DateTimeKind.Local).AddTicks(3637), new DateTime(2022, 4, 13, 9, 26, 33, 369, DateTimeKind.Local).AddTicks(3639) });

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2012, 1, 13, 9, 26, 33, 368, DateTimeKind.Local).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2011, 1, 13, 9, 26, 33, 368, DateTimeKind.Local).AddTicks(4096));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2010, 1, 13, 9, 26, 33, 368, DateTimeKind.Local).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(2012, 1, 13, 9, 26, 33, 368, DateTimeKind.Local).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(2013, 1, 13, 9, 26, 33, 368, DateTimeKind.Local).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfBirth",
                value: new DateTime(2014, 1, 13, 9, 26, 33, 368, DateTimeKind.Local).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfBirth",
                value: new DateTime(2013, 1, 13, 9, 26, 33, 368, DateTimeKind.Local).AddTicks(4127));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateOfBirth",
                value: new DateTime(2012, 1, 13, 9, 26, 33, 368, DateTimeKind.Local).AddTicks(4131));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateOfBirth",
                value: new DateTime(2011, 1, 13, 9, 26, 33, 368, DateTimeKind.Local).AddTicks(4135));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateOfBirth",
                value: new DateTime(2011, 1, 13, 9, 26, 33, 368, DateTimeKind.Local).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateOfBirth",
                value: new DateTime(2010, 1, 13, 9, 26, 33, 368, DateTimeKind.Local).AddTicks(4144));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateOfBirth",
                value: new DateTime(2009, 1, 13, 9, 26, 33, 368, DateTimeKind.Local).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateOfBirth",
                value: new DateTime(2011, 1, 13, 9, 26, 33, 368, DateTimeKind.Local).AddTicks(4152));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateOfBirth",
                value: new DateTime(2010, 1, 13, 9, 26, 33, 368, DateTimeKind.Local).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateOfBirth",
                value: new DateTime(2011, 1, 13, 9, 26, 33, 368, DateTimeKind.Local).AddTicks(4159));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateOfBirth",
                value: new DateTime(2012, 1, 13, 9, 26, 33, 368, DateTimeKind.Local).AddTicks(4163));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateOfBirth",
                value: new DateTime(2011, 1, 13, 9, 26, 33, 368, DateTimeKind.Local).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateOfBirth",
                value: new DateTime(2013, 1, 13, 9, 26, 33, 368, DateTimeKind.Local).AddTicks(4172));

            migrationBuilder.UpdateData(
                table: "CounselorRegistries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssignmentEnd", "AssignmentStart" },
                values: new object[] { new DateTime(2022, 4, 13, 9, 26, 33, 369, DateTimeKind.Local).AddTicks(7685), new DateTime(2022, 1, 13, 9, 26, 33, 369, DateTimeKind.Local).AddTicks(7431) });

            migrationBuilder.UpdateData(
                table: "CounselorRegistries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AssignmentEnd", "AssignmentStart" },
                values: new object[] { new DateTime(2022, 4, 13, 9, 26, 33, 369, DateTimeKind.Local).AddTicks(7929), new DateTime(2022, 1, 13, 9, 26, 33, 369, DateTimeKind.Local).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "CounselorRegistries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AssignmentEnd", "AssignmentStart" },
                values: new object[] { new DateTime(2022, 4, 13, 9, 26, 33, 369, DateTimeKind.Local).AddTicks(7937), new DateTime(2022, 1, 13, 9, 26, 33, 369, DateTimeKind.Local).AddTicks(7934) });

            migrationBuilder.UpdateData(
                table: "CounselorRegistries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AssignmentEnd", "AssignmentStart" },
                values: new object[] { new DateTime(2022, 4, 13, 9, 26, 33, 369, DateTimeKind.Local).AddTicks(7943), new DateTime(2022, 1, 13, 9, 26, 33, 369, DateTimeKind.Local).AddTicks(7940) });

            migrationBuilder.UpdateData(
                table: "CounselorRegistries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AssignmentEnd", "AssignmentStart" },
                values: new object[] { new DateTime(2022, 4, 13, 9, 26, 33, 369, DateTimeKind.Local).AddTicks(7950), new DateTime(2022, 1, 13, 9, 26, 33, 369, DateTimeKind.Local).AddTicks(7947) });

            migrationBuilder.UpdateData(
                table: "Counselors",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(1992, 1, 13, 9, 26, 33, 365, DateTimeKind.Local).AddTicks(398));

            migrationBuilder.UpdateData(
                table: "Counselors",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(1999, 1, 13, 9, 26, 33, 367, DateTimeKind.Local).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "Counselors",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(1996, 1, 13, 9, 26, 33, 367, DateTimeKind.Local).AddTicks(4017));

            migrationBuilder.UpdateData(
                table: "Counselors",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(1993, 1, 13, 9, 26, 33, 367, DateTimeKind.Local).AddTicks(4025));

            migrationBuilder.UpdateData(
                table: "Counselors",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(1997, 1, 13, 9, 26, 33, 367, DateTimeKind.Local).AddTicks(4029));

            migrationBuilder.InsertData(
                table: "Visits",
                columns: new[] { "Id", "CamperId", "EndTime", "StartTime", "VisitorId" },
                values: new object[,]
                {
                    { 3, 3, new DateTime(2022, 1, 13, 12, 26, 33, 370, DateTimeKind.Local).AddTicks(1792), new DateTime(2022, 1, 13, 9, 26, 33, 370, DateTimeKind.Local).AddTicks(1789), 3 },
                    { 2, 2, new DateTime(2022, 1, 13, 10, 26, 33, 370, DateTimeKind.Local).AddTicks(1785), new DateTime(2022, 1, 13, 9, 26, 33, 370, DateTimeKind.Local).AddTicks(1777), 2 },
                    { 1, 1, new DateTime(2022, 1, 13, 11, 26, 33, 370, DateTimeKind.Local).AddTicks(1343), new DateTime(2022, 1, 13, 9, 26, 33, 370, DateTimeKind.Local).AddTicks(1092), 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Visits_CamperId",
                table: "Visits",
                column: "CamperId");

            migrationBuilder.CreateIndex(
                name: "IX_Visits_VisitorId",
                table: "Visits",
                column: "VisitorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Visits");

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
        }
    }
}
