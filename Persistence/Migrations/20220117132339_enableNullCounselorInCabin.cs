using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class enableNullCounselorInCabin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cabins_Counselors_CounselorId",
                table: "Cabins");

            migrationBuilder.AlterColumn<int>(
                name: "CounselorId",
                table: "Cabins",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Cabins_Counselors_CounselorId",
                table: "Cabins",
                column: "CounselorId",
                principalTable: "Counselors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cabins_Counselors_CounselorId",
                table: "Cabins");

            migrationBuilder.AlterColumn<int>(
                name: "CounselorId",
                table: "Cabins",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cabins_Counselors_CounselorId",
                table: "Cabins",
                column: "CounselorId",
                principalTable: "Counselors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
