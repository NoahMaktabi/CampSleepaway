using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class enableNullInCounselorRegistry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_CounselorRegistries_CounselorId",
                table: "CounselorRegistries");

            migrationBuilder.AlterColumn<int>(
                name: "CounselorId",
                table: "CounselorRegistries",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

           
            migrationBuilder.CreateIndex(
                name: "IX_CounselorRegistries_CounselorId",
                table: "CounselorRegistries",
                column: "CounselorId",
                filter: "[CounselorId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_CounselorRegistries_CounselorId",
                table: "CounselorRegistries");

            migrationBuilder.AlterColumn<int>(
                name: "CounselorId",
                table: "CounselorRegistries",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

           
            migrationBuilder.CreateIndex(
                name: "IX_CounselorRegistries_CounselorId",
                table: "CounselorRegistries",
                column: "CounselorId",
                unique: false);
        }
    }
}
