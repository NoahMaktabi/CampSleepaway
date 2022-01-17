using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class enableNullCamperInNextOfKin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NextOfKins_Campers_CamperId",
                table: "NextOfKins");

            migrationBuilder.AlterColumn<int>(
                name: "CamperId",
                table: "NextOfKins",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_NextOfKins_Campers_CamperId",
                table: "NextOfKins",
                column: "CamperId",
                principalTable: "Campers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NextOfKins_Campers_CamperId",
                table: "NextOfKins");

            migrationBuilder.AlterColumn<int>(
                name: "CamperId",
                table: "NextOfKins",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_NextOfKins_Campers_CamperId",
                table: "NextOfKins",
                column: "CamperId",
                principalTable: "Campers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
