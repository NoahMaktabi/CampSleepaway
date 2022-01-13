using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cabins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CounselorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cabins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Campers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CabinId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Campers_Cabins_CabinId",
                        column: x => x.CabinId,
                        principalTable: "Cabins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Counselors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CabinId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Counselors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Counselors_Cabins_CabinId",
                        column: x => x.CabinId,
                        principalTable: "Cabins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CamperRegistry",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CamperId = table.Column<int>(type: "int", nullable: false),
                    CabinId = table.Column<int>(type: "int", nullable: false),
                    CheckIn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckOut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CamperRegistry", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CamperRegistry_Cabins_CabinId",
                        column: x => x.CabinId,
                        principalTable: "Cabins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CamperRegistry_Campers_CamperId",
                        column: x => x.CamperId,
                        principalTable: "Campers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "NextOfKins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CamperId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NextOfKins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NextOfKins_Campers_CamperId",
                        column: x => x.CamperId,
                        principalTable: "Campers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CounselorRegistries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CounselorId = table.Column<int>(type: "int", nullable: false),
                    CabinId = table.Column<int>(type: "int", nullable: false),
                    AssignmentStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AssignmentEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CounselorRegistries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CounselorRegistries_Cabins_CabinId",
                        column: x => x.CabinId,
                        principalTable: "Cabins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CounselorRegistries_Counselors_CounselorId",
                        column: x => x.CounselorId,
                        principalTable: "Counselors",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Cabins",
                columns: new[] { "Id", "Name", "CounselorId" },
                values: new object[,]
                {
                    { 1, "First", 1 },
                    { 2, "Second", 2 },
                    { 3, "Third", 3 },
                    { 4, "Fourth", 4 },
                    { 5, "Fifth", 5 }
                });

            migrationBuilder.InsertData(
                table: "Campers",
                columns: new[] { "Id", "CabinId", "DateOfBirth", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2012, 1, 12, 13, 57, 55, 500, DateTimeKind.Local).AddTicks(3124), "Niklas", "0711254895" },
                    { 17, 5, new DateTime(2011, 1, 12, 13, 57, 55, 500, DateTimeKind.Local).AddTicks(4210), "Rachel", "0711254895" },
                    { 16, 4, new DateTime(2012, 1, 12, 13, 57, 55, 500, DateTimeKind.Local).AddTicks(4204), "Ross", "0711254895" },
                    { 15, 4, new DateTime(2011, 1, 12, 13, 57, 55, 500, DateTimeKind.Local).AddTicks(4197), "Howard", "0711254895" },
                    { 14, 4, new DateTime(2010, 1, 12, 13, 57, 55, 500, DateTimeKind.Local).AddTicks(4191), "Leo", "0711254895" },
                    { 13, 4, new DateTime(2011, 1, 12, 13, 57, 55, 500, DateTimeKind.Local).AddTicks(4184), "Per", "0711254895" },
                    { 12, 3, new DateTime(2009, 1, 12, 13, 57, 55, 500, DateTimeKind.Local).AddTicks(4178), "Silvio", "0711254895" },
                    { 11, 3, new DateTime(2010, 1, 12, 13, 57, 55, 500, DateTimeKind.Local).AddTicks(4171), "John", "0711254895" },
                    { 18, 5, new DateTime(2013, 1, 12, 13, 57, 55, 500, DateTimeKind.Local).AddTicks(4219), "Jakob", "0711254895" },
                    { 9, 3, new DateTime(2011, 1, 12, 13, 57, 55, 500, DateTimeKind.Local).AddTicks(4155), "Paul", "0711254895" },
                    { 10, 3, new DateTime(2011, 1, 12, 13, 57, 55, 500, DateTimeKind.Local).AddTicks(4165), "Mikael", "0711254895" },
                    { 8, 2, new DateTime(2012, 1, 12, 13, 57, 55, 500, DateTimeKind.Local).AddTicks(4076), "Frida", "0711254895" },
                    { 7, 2, new DateTime(2013, 1, 12, 13, 57, 55, 500, DateTimeKind.Local).AddTicks(4069), "Erik", "0711254895" },
                    { 6, 2, new DateTime(2014, 1, 12, 13, 57, 55, 500, DateTimeKind.Local).AddTicks(4063), "Ahmed", "0711254895" },
                    { 5, 2, new DateTime(2013, 1, 12, 13, 57, 55, 500, DateTimeKind.Local).AddTicks(4043), "Anders", "0711254895" },
                    { 4, 1, new DateTime(2012, 1, 12, 13, 57, 55, 500, DateTimeKind.Local).AddTicks(4034), "Paula", "0711254895" },
                    { 3, 1, new DateTime(2010, 1, 12, 13, 57, 55, 500, DateTimeKind.Local).AddTicks(4027), "Lina", "0711254895" },
                    { 2, 1, new DateTime(2011, 1, 12, 13, 57, 55, 500, DateTimeKind.Local).AddTicks(4006), "Maja", "0711254895" }
                });

            migrationBuilder.InsertData(
                table: "Counselors",
                columns: new[] { "Id", "Address", "CabinId", "DateOfBirth", "Email", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 3, "Torggatan1", 3, new DateTime(1996, 1, 12, 13, 57, 55, 498, DateTimeKind.Local).AddTicks(626), "counc3@th.com", "Johan Svart", "0703545641" },
                    { 1, "Storgatan10", 1, new DateTime(1992, 1, 12, 13, 57, 55, 492, DateTimeKind.Local).AddTicks(9541), "counc1@th.com", "Anders Counselsson", "0700545641" },
                    { 4, "Lillegatan4", 4, new DateTime(1993, 1, 12, 13, 57, 55, 498, DateTimeKind.Local).AddTicks(643), "counc4@th.com", "Jimmie Svensson", "0787445641" },
                    { 2, "Göteborgsvägen 2", 2, new DateTime(1999, 1, 12, 13, 57, 55, 498, DateTimeKind.Local).AddTicks(547), "counc2@th.com", "Erik Test", "0700274641" },
                    { 5, "Kunggatan3", 5, new DateTime(1997, 1, 12, 13, 57, 55, 498, DateTimeKind.Local).AddTicks(654), "counc5@th.com", "Maja Andersson", "0700543421" }
                });

            migrationBuilder.InsertData(
                table: "CamperRegistry",
                columns: new[] { "Id", "CabinId", "CamperId", "CheckIn", "CheckOut", "Notes" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2022, 1, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(1446), new DateTime(2022, 4, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(3301), null },
                    { 18, 5, 18, new DateTime(2022, 1, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5703), new DateTime(2022, 4, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5710), null },
                    { 17, 5, 17, new DateTime(2022, 1, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5682), new DateTime(2022, 4, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5689), null },
                    { 16, 4, 16, new DateTime(2022, 1, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5666), new DateTime(2022, 4, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5673), null },
                    { 15, 4, 15, new DateTime(2022, 1, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5652), new DateTime(2022, 4, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5658), null },
                    { 14, 4, 14, new DateTime(2022, 1, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5638), new DateTime(2022, 4, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5644), null },
                    { 13, 4, 13, new DateTime(2022, 1, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5624), new DateTime(2022, 4, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5630), null },
                    { 12, 3, 12, new DateTime(2022, 1, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5611), new DateTime(2022, 4, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5617), null },
                    { 11, 3, 11, new DateTime(2022, 1, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5596), new DateTime(2022, 4, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5602), null },
                    { 9, 3, 9, new DateTime(2022, 1, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5563), new DateTime(2022, 4, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5568), null },
                    { 8, 2, 8, new DateTime(2022, 1, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5547), new DateTime(2022, 4, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5554), null },
                    { 7, 2, 7, new DateTime(2022, 1, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5532), new DateTime(2022, 4, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5539), null },
                    { 10, 3, 10, new DateTime(2022, 1, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5581), new DateTime(2022, 4, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5587), null },
                    { 6, 2, 6, new DateTime(2022, 1, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5516), new DateTime(2022, 4, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5523), null },
                    { 2, 1, 2, new DateTime(2022, 1, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5388), new DateTime(2022, 4, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5445), null },
                    { 3, 1, 3, new DateTime(2022, 1, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5457), new DateTime(2022, 4, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5469), null },
                    { 4, 1, 4, new DateTime(2022, 1, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5477), new DateTime(2022, 4, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5481), null },
                    { 5, 2, 5, new DateTime(2022, 1, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5488), new DateTime(2022, 4, 12, 13, 57, 55, 502, DateTimeKind.Local).AddTicks(5492), null }
                });

            migrationBuilder.InsertData(
                table: "CounselorRegistries",
                columns: new[] { "Id", "AssignmentEnd", "AssignmentStart", "CabinId", "CounselorId", "Notes" },
                values: new object[,]
                {
                    { 4, new DateTime(2022, 4, 12, 13, 57, 55, 504, DateTimeKind.Local).AddTicks(1444), new DateTime(2022, 1, 12, 13, 57, 55, 504, DateTimeKind.Local).AddTicks(1437), 4, 4, null },
                    { 1, new DateTime(2022, 4, 12, 13, 57, 55, 504, DateTimeKind.Local).AddTicks(843), new DateTime(2022, 1, 12, 13, 57, 55, 504, DateTimeKind.Local).AddTicks(196), 1, 1, null },
                    { 3, new DateTime(2022, 4, 12, 13, 57, 55, 504, DateTimeKind.Local).AddTicks(1428), new DateTime(2022, 1, 12, 13, 57, 55, 504, DateTimeKind.Local).AddTicks(1420), 3, 3, null },
                    { 5, new DateTime(2022, 4, 12, 13, 57, 55, 504, DateTimeKind.Local).AddTicks(1461), new DateTime(2022, 1, 12, 13, 57, 55, 504, DateTimeKind.Local).AddTicks(1454), 5, 5, null },
                    { 2, new DateTime(2022, 4, 12, 13, 57, 55, 504, DateTimeKind.Local).AddTicks(1408), new DateTime(2022, 1, 12, 13, 57, 55, 504, DateTimeKind.Local).AddTicks(1392), 2, 2, null }
                });

            migrationBuilder.InsertData(
                table: "NextOfKins",
                columns: new[] { "Id", "Address", "CamperId", "Email", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Gata6", 1, "parent1@test.com", "Ken", "071254864" },
                    { 17, "Gata74", 17, "parent17@test.com", "Cameron", "071254864" },
                    { 7, "Gata45", 7, "parent7@test.com", "Leonard", "071254864" },
                    { 5, "Gata5", 5, "parent5@test.com", "Mikael", "071254864" },
                    { 16, "Gata69", 16, "parent16@test.com", "Polo", "071254864" },
                    { 2, "Gata7", 2, "parent2@test.com", "Anders", "071254864" },
                    { 15, "Gata66", 15, "parent15@test.com", "Marco", "071254864" },
                    { 8, "Gata54", 8, "parent8@test.com", "Ross", "071254864" },
                    { 14, "Gata48", 14, "parent14@test.com", "Fredrick", "071254864" },
                    { 3, "Gata8", 3, "parent3@test.com", "Lina", "071254864" },
                    { 13, "Gata25", 13, "parent13@test.com", "Stefan", "071254864" },
                    { 6, "Gata1", 6, "parent6@test.com", "Johnny", "071254864" },
                    { 12, "Gata45", 12, "parent12@test.com", "Josef", "071254864" },
                    { 4, "Gata4", 4, "parent4@test.com", "Per", "071254864" },
                    { 11, "Gata61", 11, "parent11@test.com", "Joey", "071254864" },
                    { 9, "Gata42", 9, "parent9@test.com", "Chandler", "071254864" },
                    { 18, "Gata87", 18, "parent18@test.com", "Mitchel", "071254864" },
                    { 10, "Gata64", 10, "parent10@test.com", "Gunther", "071254864" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CamperRegistry_CabinId",
                table: "CamperRegistry",
                column: "CabinId");

            migrationBuilder.CreateIndex(
                name: "IX_CamperRegistry_CamperId",
                table: "CamperRegistry",
                column: "CamperId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Campers_CabinId",
                table: "Campers",
                column: "CabinId");

            migrationBuilder.CreateIndex(
                name: "IX_CounselorRegistries_CabinId",
                table: "CounselorRegistries",
                column: "CabinId");

            migrationBuilder.CreateIndex(
                name: "IX_CounselorRegistries_CounselorId",
                table: "CounselorRegistries",
                column: "CounselorId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Counselors_CabinId",
                table: "Counselors",
                column: "CabinId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_NextOfKins_CamperId",
                table: "NextOfKins",
                column: "CamperId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CamperRegistry");

            migrationBuilder.DropTable(
                name: "CounselorRegistries");

            migrationBuilder.DropTable(
                name: "NextOfKins");

            migrationBuilder.DropTable(
                name: "Counselors");

            migrationBuilder.DropTable(
                name: "Campers");

            migrationBuilder.DropTable(
                name: "Cabins");
        }
    }
}
