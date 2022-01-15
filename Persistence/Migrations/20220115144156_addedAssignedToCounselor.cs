using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class addedAssignedToCounselor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "AssignedToCabin",
                table: "Counselors",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 15, 15, 41, 56, 508, DateTimeKind.Local).AddTicks(9411), new DateTime(2022, 4, 15, 15, 41, 56, 508, DateTimeKind.Local).AddTicks(9676) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 15, 15, 41, 56, 508, DateTimeKind.Local).AddTicks(9916), new DateTime(2022, 4, 15, 15, 41, 56, 508, DateTimeKind.Local).AddTicks(9921) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 15, 15, 41, 56, 508, DateTimeKind.Local).AddTicks(9923), new DateTime(2022, 4, 15, 15, 41, 56, 508, DateTimeKind.Local).AddTicks(9925) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 15, 15, 41, 56, 508, DateTimeKind.Local).AddTicks(9927), new DateTime(2022, 4, 15, 15, 41, 56, 508, DateTimeKind.Local).AddTicks(9929) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 15, 15, 41, 56, 508, DateTimeKind.Local).AddTicks(9931), new DateTime(2022, 4, 15, 15, 41, 56, 508, DateTimeKind.Local).AddTicks(9933) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 15, 15, 41, 56, 508, DateTimeKind.Local).AddTicks(9937), new DateTime(2022, 4, 15, 15, 41, 56, 508, DateTimeKind.Local).AddTicks(9939) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 15, 15, 41, 56, 508, DateTimeKind.Local).AddTicks(9941), new DateTime(2022, 4, 15, 15, 41, 56, 508, DateTimeKind.Local).AddTicks(9943) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 15, 15, 41, 56, 508, DateTimeKind.Local).AddTicks(9945), new DateTime(2022, 4, 15, 15, 41, 56, 508, DateTimeKind.Local).AddTicks(9946) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 15, 15, 41, 56, 508, DateTimeKind.Local).AddTicks(9949), new DateTime(2022, 4, 15, 15, 41, 56, 508, DateTimeKind.Local).AddTicks(9950) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 15, 15, 41, 56, 508, DateTimeKind.Local).AddTicks(9953), new DateTime(2022, 4, 15, 15, 41, 56, 508, DateTimeKind.Local).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 15, 15, 41, 56, 508, DateTimeKind.Local).AddTicks(9957), new DateTime(2022, 4, 15, 15, 41, 56, 508, DateTimeKind.Local).AddTicks(9959) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 15, 15, 41, 56, 508, DateTimeKind.Local).AddTicks(9961), new DateTime(2022, 4, 15, 15, 41, 56, 508, DateTimeKind.Local).AddTicks(9962) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 15, 15, 41, 56, 508, DateTimeKind.Local).AddTicks(9965), new DateTime(2022, 4, 15, 15, 41, 56, 508, DateTimeKind.Local).AddTicks(9966) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 15, 15, 41, 56, 508, DateTimeKind.Local).AddTicks(9968), new DateTime(2022, 4, 15, 15, 41, 56, 508, DateTimeKind.Local).AddTicks(9970) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 15, 15, 41, 56, 508, DateTimeKind.Local).AddTicks(9972), new DateTime(2022, 4, 15, 15, 41, 56, 508, DateTimeKind.Local).AddTicks(9974) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 15, 15, 41, 56, 508, DateTimeKind.Local).AddTicks(9976), new DateTime(2022, 4, 15, 15, 41, 56, 508, DateTimeKind.Local).AddTicks(9978) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 15, 15, 41, 56, 508, DateTimeKind.Local).AddTicks(9980), new DateTime(2022, 4, 15, 15, 41, 56, 508, DateTimeKind.Local).AddTicks(9981) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 15, 15, 41, 56, 508, DateTimeKind.Local).AddTicks(9984), new DateTime(2022, 4, 15, 15, 41, 56, 508, DateTimeKind.Local).AddTicks(9986) });

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2012, 1, 15, 15, 41, 56, 508, DateTimeKind.Local).AddTicks(2881));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2011, 1, 15, 15, 41, 56, 508, DateTimeKind.Local).AddTicks(3112));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2010, 1, 15, 15, 41, 56, 508, DateTimeKind.Local).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(2012, 1, 15, 15, 41, 56, 508, DateTimeKind.Local).AddTicks(3123));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(2013, 1, 15, 15, 41, 56, 508, DateTimeKind.Local).AddTicks(3127));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfBirth",
                value: new DateTime(2014, 1, 15, 15, 41, 56, 508, DateTimeKind.Local).AddTicks(3133));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfBirth",
                value: new DateTime(2013, 1, 15, 15, 41, 56, 508, DateTimeKind.Local).AddTicks(3135));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateOfBirth",
                value: new DateTime(2012, 1, 15, 15, 41, 56, 508, DateTimeKind.Local).AddTicks(3138));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateOfBirth",
                value: new DateTime(2011, 1, 15, 15, 41, 56, 508, DateTimeKind.Local).AddTicks(3141));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateOfBirth",
                value: new DateTime(2011, 1, 15, 15, 41, 56, 508, DateTimeKind.Local).AddTicks(3145));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateOfBirth",
                value: new DateTime(2010, 1, 15, 15, 41, 56, 508, DateTimeKind.Local).AddTicks(3148));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateOfBirth",
                value: new DateTime(2009, 1, 15, 15, 41, 56, 508, DateTimeKind.Local).AddTicks(3150));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateOfBirth",
                value: new DateTime(2011, 1, 15, 15, 41, 56, 508, DateTimeKind.Local).AddTicks(3153));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateOfBirth",
                value: new DateTime(2010, 1, 15, 15, 41, 56, 508, DateTimeKind.Local).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateOfBirth",
                value: new DateTime(2011, 1, 15, 15, 41, 56, 508, DateTimeKind.Local).AddTicks(3159));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateOfBirth",
                value: new DateTime(2012, 1, 15, 15, 41, 56, 508, DateTimeKind.Local).AddTicks(3163));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateOfBirth",
                value: new DateTime(2011, 1, 15, 15, 41, 56, 508, DateTimeKind.Local).AddTicks(3166));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateOfBirth",
                value: new DateTime(2013, 1, 15, 15, 41, 56, 508, DateTimeKind.Local).AddTicks(3169));

            migrationBuilder.UpdateData(
                table: "CounselorRegistries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssignmentEnd", "AssignmentStart" },
                values: new object[] { new DateTime(2022, 4, 15, 15, 41, 56, 509, DateTimeKind.Local).AddTicks(2650), new DateTime(2022, 1, 15, 15, 41, 56, 509, DateTimeKind.Local).AddTicks(2480) });

            migrationBuilder.UpdateData(
                table: "CounselorRegistries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AssignmentEnd", "AssignmentStart" },
                values: new object[] { new DateTime(2022, 4, 15, 15, 41, 56, 509, DateTimeKind.Local).AddTicks(2812), new DateTime(2022, 1, 15, 15, 41, 56, 509, DateTimeKind.Local).AddTicks(2807) });

            migrationBuilder.UpdateData(
                table: "CounselorRegistries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AssignmentEnd", "AssignmentStart" },
                values: new object[] { new DateTime(2022, 4, 15, 15, 41, 56, 509, DateTimeKind.Local).AddTicks(2817), new DateTime(2022, 1, 15, 15, 41, 56, 509, DateTimeKind.Local).AddTicks(2815) });

            migrationBuilder.UpdateData(
                table: "CounselorRegistries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AssignmentEnd", "AssignmentStart" },
                values: new object[] { new DateTime(2022, 4, 15, 15, 41, 56, 509, DateTimeKind.Local).AddTicks(2821), new DateTime(2022, 1, 15, 15, 41, 56, 509, DateTimeKind.Local).AddTicks(2819) });

            migrationBuilder.UpdateData(
                table: "CounselorRegistries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AssignmentEnd", "AssignmentStart" },
                values: new object[] { new DateTime(2022, 4, 15, 15, 41, 56, 509, DateTimeKind.Local).AddTicks(2824), new DateTime(2022, 1, 15, 15, 41, 56, 509, DateTimeKind.Local).AddTicks(2823) });

            migrationBuilder.UpdateData(
                table: "Counselors",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(1992, 1, 15, 15, 41, 56, 505, DateTimeKind.Local).AddTicks(3557));

            migrationBuilder.UpdateData(
                table: "Counselors",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(1999, 1, 15, 15, 41, 56, 507, DateTimeKind.Local).AddTicks(4947));

            migrationBuilder.UpdateData(
                table: "Counselors",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(1996, 1, 15, 15, 41, 56, 507, DateTimeKind.Local).AddTicks(4979));

            migrationBuilder.UpdateData(
                table: "Counselors",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(1993, 1, 15, 15, 41, 56, 507, DateTimeKind.Local).AddTicks(4984));

            migrationBuilder.UpdateData(
                table: "Counselors",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(1997, 1, 15, 15, 41, 56, 507, DateTimeKind.Local).AddTicks(4987));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 1, 15, 17, 41, 56, 509, DateTimeKind.Local).AddTicks(4972), new DateTime(2022, 1, 15, 15, 41, 56, 509, DateTimeKind.Local).AddTicks(4816) });

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 1, 15, 16, 41, 56, 509, DateTimeKind.Local).AddTicks(5244), new DateTime(2022, 1, 15, 15, 41, 56, 509, DateTimeKind.Local).AddTicks(5239) });

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 1, 15, 18, 41, 56, 509, DateTimeKind.Local).AddTicks(5249), new DateTime(2022, 1, 15, 15, 41, 56, 509, DateTimeKind.Local).AddTicks(5247) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AssignedToCabin",
                table: "Counselors");

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(3732), new DateTime(2022, 4, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(3965) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4223), new DateTime(2022, 4, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4230) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4235), new DateTime(2022, 4, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4238) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4243), new DateTime(2022, 4, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4246) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4251), new DateTime(2022, 4, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4253) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4260), new DateTime(2022, 4, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4263) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4267), new DateTime(2022, 4, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4270) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4273), new DateTime(2022, 4, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4277) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4280), new DateTime(2022, 4, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4283) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4288), new DateTime(2022, 4, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4291) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4294), new DateTime(2022, 4, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4297) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4300), new DateTime(2022, 4, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4303) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4307), new DateTime(2022, 4, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4309) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4312), new DateTime(2022, 4, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4315) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4320), new DateTime(2022, 4, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4321) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4324), new DateTime(2022, 4, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4326) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4328), new DateTime(2022, 4, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4330) });

            migrationBuilder.UpdateData(
                table: "CamperRegistries",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new DateTime(2022, 1, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4334), new DateTime(2022, 4, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4335) });

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2012, 1, 15, 12, 31, 51, 250, DateTimeKind.Local).AddTicks(6243));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2011, 1, 15, 12, 31, 51, 250, DateTimeKind.Local).AddTicks(6498));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2010, 1, 15, 12, 31, 51, 250, DateTimeKind.Local).AddTicks(6507));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(2012, 1, 15, 12, 31, 51, 250, DateTimeKind.Local).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(2013, 1, 15, 12, 31, 51, 250, DateTimeKind.Local).AddTicks(6514));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfBirth",
                value: new DateTime(2014, 1, 15, 12, 31, 51, 250, DateTimeKind.Local).AddTicks(6519));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfBirth",
                value: new DateTime(2013, 1, 15, 12, 31, 51, 250, DateTimeKind.Local).AddTicks(6522));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateOfBirth",
                value: new DateTime(2012, 1, 15, 12, 31, 51, 250, DateTimeKind.Local).AddTicks(6525));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateOfBirth",
                value: new DateTime(2011, 1, 15, 12, 31, 51, 250, DateTimeKind.Local).AddTicks(6528));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateOfBirth",
                value: new DateTime(2011, 1, 15, 12, 31, 51, 250, DateTimeKind.Local).AddTicks(6532));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateOfBirth",
                value: new DateTime(2010, 1, 15, 12, 31, 51, 250, DateTimeKind.Local).AddTicks(6535));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateOfBirth",
                value: new DateTime(2009, 1, 15, 12, 31, 51, 250, DateTimeKind.Local).AddTicks(6538));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateOfBirth",
                value: new DateTime(2011, 1, 15, 12, 31, 51, 250, DateTimeKind.Local).AddTicks(6541));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateOfBirth",
                value: new DateTime(2010, 1, 15, 12, 31, 51, 250, DateTimeKind.Local).AddTicks(6544));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateOfBirth",
                value: new DateTime(2011, 1, 15, 12, 31, 51, 250, DateTimeKind.Local).AddTicks(6547));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateOfBirth",
                value: new DateTime(2012, 1, 15, 12, 31, 51, 250, DateTimeKind.Local).AddTicks(6551));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateOfBirth",
                value: new DateTime(2011, 1, 15, 12, 31, 51, 250, DateTimeKind.Local).AddTicks(6554));

            migrationBuilder.UpdateData(
                table: "Campers",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateOfBirth",
                value: new DateTime(2013, 1, 15, 12, 31, 51, 250, DateTimeKind.Local).AddTicks(6558));

            migrationBuilder.UpdateData(
                table: "CounselorRegistries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssignmentEnd", "AssignmentStart" },
                values: new object[] { new DateTime(2022, 4, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(8454), new DateTime(2022, 1, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(8226) });

            migrationBuilder.UpdateData(
                table: "CounselorRegistries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AssignmentEnd", "AssignmentStart" },
                values: new object[] { new DateTime(2022, 4, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(8776), new DateTime(2022, 1, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "CounselorRegistries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AssignmentEnd", "AssignmentStart" },
                values: new object[] { new DateTime(2022, 4, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(8782), new DateTime(2022, 1, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(8780) });

            migrationBuilder.UpdateData(
                table: "CounselorRegistries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AssignmentEnd", "AssignmentStart" },
                values: new object[] { new DateTime(2022, 4, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(8787), new DateTime(2022, 1, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(8785) });

            migrationBuilder.UpdateData(
                table: "CounselorRegistries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AssignmentEnd", "AssignmentStart" },
                values: new object[] { new DateTime(2022, 4, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(8791), new DateTime(2022, 1, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "Counselors",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(1992, 1, 15, 12, 31, 51, 247, DateTimeKind.Local).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "Counselors",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(1999, 1, 15, 12, 31, 51, 249, DateTimeKind.Local).AddTicks(7526));

            migrationBuilder.UpdateData(
                table: "Counselors",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(1996, 1, 15, 12, 31, 51, 249, DateTimeKind.Local).AddTicks(7555));

            migrationBuilder.UpdateData(
                table: "Counselors",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(1993, 1, 15, 12, 31, 51, 249, DateTimeKind.Local).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "Counselors",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(1997, 1, 15, 12, 31, 51, 249, DateTimeKind.Local).AddTicks(7563));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 1, 15, 14, 31, 51, 252, DateTimeKind.Local).AddTicks(1665), new DateTime(2022, 1, 15, 12, 31, 51, 252, DateTimeKind.Local).AddTicks(1472) });

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 1, 15, 13, 31, 51, 252, DateTimeKind.Local).AddTicks(2007), new DateTime(2022, 1, 15, 12, 31, 51, 252, DateTimeKind.Local).AddTicks(2001) });

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 1, 15, 15, 31, 51, 252, DateTimeKind.Local).AddTicks(2012), new DateTime(2022, 1, 15, 12, 31, 51, 252, DateTimeKind.Local).AddTicks(2010) });
        }
    }
}
