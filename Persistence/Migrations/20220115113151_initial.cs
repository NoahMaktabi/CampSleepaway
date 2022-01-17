using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Counselors", x => x.Id);
                });

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
                    table.ForeignKey(
                        name: "FK_Cabins_Counselors_CounselorId",
                        column: x => x.CounselorId,
                        principalTable: "Counselors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateTable(
                name: "CamperRegistries",
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
                    table.PrimaryKey("PK_CamperRegistries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CamperRegistries_Cabins_CabinId",
                        column: x => x.CabinId,
                        principalTable: "Cabins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CamperRegistries_Campers_CamperId",
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

            migrationBuilder.InsertData(
                table: "Counselors",
                columns: new[] { "Id", "Address", "DateOfBirth", "Email", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Storgatan10", new DateTime(1992, 1, 15, 12, 31, 51, 247, DateTimeKind.Local).AddTicks(6723), "counc1@th.com", "Anders Counselsson", "0700545641" },
                    { 2, "Göteborgsvägen 2", new DateTime(1999, 1, 15, 12, 31, 51, 249, DateTimeKind.Local).AddTicks(7526), "counc2@th.com", "Erik Test", "0700274641" },
                    { 3, "Torggatan1", new DateTime(1996, 1, 15, 12, 31, 51, 249, DateTimeKind.Local).AddTicks(7555), "counc3@th.com", "Johan Svart", "0703545641" },
                    { 4, "Lillegatan4", new DateTime(1993, 1, 15, 12, 31, 51, 249, DateTimeKind.Local).AddTicks(7560), "counc4@th.com", "Jimmie Svensson", "0787445641" },
                    { 5, "Kunggatan3", new DateTime(1997, 1, 15, 12, 31, 51, 249, DateTimeKind.Local).AddTicks(7563), "counc5@th.com", "Maja Andersson", "0700543421" }
                });

            migrationBuilder.InsertData(
                table: "Cabins",
                columns: new[] { "Id", "CounselorId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "First" },
                    { 2, 2, "Second" },
                    { 3, 3, "Third" },
                    { 4, 4, "Fourth" },
                    { 5, 5, "Fifth" }
                });

            migrationBuilder.InsertData(
                table: "Campers",
                columns: new[] { "Id", "CabinId", "DateOfBirth", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2012, 1, 15, 12, 31, 51, 250, DateTimeKind.Local).AddTicks(6243), "Niklas", "0711254895" },
                    { 17, 5, new DateTime(2011, 1, 15, 12, 31, 51, 250, DateTimeKind.Local).AddTicks(6554), "Rachel", "0711254895" },
                    { 16, 4, new DateTime(2012, 1, 15, 12, 31, 51, 250, DateTimeKind.Local).AddTicks(6551), "Ross", "0711254895" },
                    { 15, 4, new DateTime(2011, 1, 15, 12, 31, 51, 250, DateTimeKind.Local).AddTicks(6547), "Howard", "0711254895" },
                    { 14, 4, new DateTime(2010, 1, 15, 12, 31, 51, 250, DateTimeKind.Local).AddTicks(6544), "Leo", "0711254895" },
                    { 13, 4,  new DateTime(2011, 1, 15, 12, 31, 51, 250, DateTimeKind.Local).AddTicks(6541), "Per", "0711254895" },
                    { 12, 3,  new DateTime(2009, 1, 15, 12, 31, 51, 250, DateTimeKind.Local).AddTicks(6538), "Silvio", "0711254895" },
                    { 11, 3, new DateTime(2010, 1, 15, 12, 31, 51, 250, DateTimeKind.Local).AddTicks(6535), "John", "0711254895" },
                    { 18, 5, new DateTime(2013, 1, 15, 12, 31, 51, 250, DateTimeKind.Local).AddTicks(6558), "Jakob", "0711254895" },
                    { 9, 3, new DateTime(2011, 1, 15, 12, 31, 51, 250, DateTimeKind.Local).AddTicks(6528), "Paul", "0711254895" },
                    { 10, 3, new DateTime(2011, 1, 15, 12, 31, 51, 250, DateTimeKind.Local).AddTicks(6532), "Mikael", "0711254895" },
                    { 8, 2, new DateTime(2012, 1, 15, 12, 31, 51, 250, DateTimeKind.Local).AddTicks(6525), "Frida", "0711254895" },
                    { 7, 2, new DateTime(2013, 1, 15, 12, 31, 51, 250, DateTimeKind.Local).AddTicks(6522), "Erik", "0711254895" },
                    { 6, 2, new DateTime(2014, 1, 15, 12, 31, 51, 250, DateTimeKind.Local).AddTicks(6519), "Ahmed", "0711254895" },
                    { 5, 2, new DateTime(2013, 1, 15, 12, 31, 51, 250, DateTimeKind.Local).AddTicks(6514), "Anders", "0711254895" },
                    { 4, 1, new DateTime(2012, 1, 15, 12, 31, 51, 250, DateTimeKind.Local).AddTicks(6510), "Paula", "0711254895" },
                    { 3, 1, new DateTime(2010, 1, 15, 12, 31, 51, 250, DateTimeKind.Local).AddTicks(6507), "Lina", "0711254895" },
                    { 2, 1, new DateTime(2011, 1, 15, 12, 31, 51, 250, DateTimeKind.Local).AddTicks(6498), "Maja", "0711254895" }
                });

            migrationBuilder.InsertData(
                table: "CounselorRegistries",
                columns: new[] { "Id", "AssignmentEnd", "AssignmentStart", "CabinId", "CounselorId", "Notes" },
                values: new object[,]
                {
                    { 3, new DateTime(2022, 4, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(8782), new DateTime(2022, 1, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(8780), 3, 3, null },
                    { 1, new DateTime(2022, 4, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(8454), new DateTime(2022, 1, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(8226), 1, 1, null },
                    { 4, new DateTime(2022, 4, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(8787), new DateTime(2022, 1, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(8785), 4, 4, null },
                    { 2, new DateTime(2022, 4, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(8776), new DateTime(2022, 1, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(8770), 2, 2, null },
                    { 5, new DateTime(2022, 4, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(8791), new DateTime(2022, 1, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(8790), 5, 5, null }
                });

            migrationBuilder.InsertData(
                table: "CamperRegistries",
                columns: new[] { "Id", "CabinId", "CamperId", "CheckIn", "CheckOut", "Notes" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2022, 1, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(3732), new DateTime(2022, 4, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(3965), null },
                    { 11, 3, 11, new DateTime(2022, 1, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4294), new DateTime(2022, 4, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4297), null },
                    { 10, 3, 10, new DateTime(2022, 1, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4288), new DateTime(2022, 4, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4291), null },
                    { 18, 5, 18, new DateTime(2022, 1, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4334), new DateTime(2022, 4, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4335), null },
                    { 9, 3, 9, new DateTime(2022, 1, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4280), new DateTime(2022, 4, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4283), null },
                    { 14, 4, 14, new DateTime(2022, 1, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4312), new DateTime(2022, 4, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4315), null },
                    { 8, 2, 8, new DateTime(2022, 1, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4273), new DateTime(2022, 4, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4277), null },
                    { 7, 2, 7, new DateTime(2022, 1, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4267), new DateTime(2022, 4, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4270), null },
                    { 13, 4, 13, new DateTime(2022, 1, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4307), new DateTime(2022, 4, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4309), null },
                    { 6, 2, 6, new DateTime(2022, 1, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4260), new DateTime(2022, 4, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4263), null },
                    { 15, 4, 15, new DateTime(2022, 1, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4320), new DateTime(2022, 4, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4321), null },
                    { 5, 2, 5, new DateTime(2022, 1, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4251), new DateTime(2022, 4, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4253), null },
                    { 16, 4, 16, new DateTime(2022, 1, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4324), new DateTime(2022, 4, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4326), null },
                    { 4, 1, 4, new DateTime(2022, 1, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4243), new DateTime(2022, 4, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4246), null },
                    { 3, 1, 3, new DateTime(2022, 1, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4235), new DateTime(2022, 4, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4238), null },
                    { 17, 5, 17, new DateTime(2022, 1, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4328), new DateTime(2022, 4, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4330), null },
                    { 2, 1, 2, new DateTime(2022, 1, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4223), new DateTime(2022, 4, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4230), null },
                    { 12, 3, 12, new DateTime(2022, 1, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4300), new DateTime(2022, 4, 15, 12, 31, 51, 251, DateTimeKind.Local).AddTicks(4303), null }
                });

            migrationBuilder.InsertData(
                table: "NextOfKins",
                columns: new[] { "Id", "Address", "CamperId", "Email", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 14, "Gata48", 14, "parent14@test.com", "Fredrick", "071254864" },
                    { 16, "Gata69", 16, "parent16@test.com", "Polo", "071254864" },
                    { 13, "Gata25", 13, "parent13@test.com", "Stefan", "071254864" },
                    { 17, "Gata74", 17, "parent17@test.com", "Cameron", "071254864" },
                    { 15, "Gata66", 15, "parent15@test.com", "Marco", "071254864" },
                    { 9, "Gata42", 9, "parent9@test.com", "Chandler", "071254864" },
                    { 11, "Gata61", 11, "parent11@test.com", "Joey", "071254864" },
                    { 10, "Gata64", 10, "parent10@test.com", "Gunther", "071254864" },
                    { 8, "Gata54", 8, "parent8@test.com", "Ross", "071254864" },
                    { 7, "Gata45", 7, "parent7@test.com", "Leonard", "071254864" },
                    { 6, "Gata1", 6, "parent6@test.com", "Johnny", "071254864" },
                    { 5, "Gata5", 5, "parent5@test.com", "Mikael", "071254864" },
                    { 4, "Gata4", 4, "parent4@test.com", "Per", "071254864" },
                    { 3, "Gata8", 3, "parent3@test.com", "Lina", "071254864" },
                    { 2, "Gata7", 2, "parent2@test.com", "Anders", "071254864" },
                    { 1, "Gata6", 1, "parent1@test.com", "Ken", "071254864" },
                    { 12, "Gata45", 12, "parent12@test.com", "Josef", "071254864" },
                    { 18, "Gata87", 18, "parent18@test.com", "Mitchel", "071254864" }
                });

            migrationBuilder.InsertData(
                table: "Visits",
                columns: new[] { "Id", "CamperId", "EndTime", "StartTime", "VisitorId" },
                values: new object[] { 1, 1, new DateTime(2022, 1, 15, 14, 31, 51, 252, DateTimeKind.Local).AddTicks(1665), new DateTime(2022, 1, 15, 12, 31, 51, 252, DateTimeKind.Local).AddTicks(1472), 1 });

            migrationBuilder.InsertData(
                table: "Visits",
                columns: new[] { "Id", "CamperId", "EndTime", "StartTime", "VisitorId" },
                values: new object[] { 2, 2, new DateTime(2022, 1, 15, 13, 31, 51, 252, DateTimeKind.Local).AddTicks(2007), new DateTime(2022, 1, 15, 12, 31, 51, 252, DateTimeKind.Local).AddTicks(2001), 2 });

            migrationBuilder.InsertData(
                table: "Visits",
                columns: new[] { "Id", "CamperId", "EndTime", "StartTime", "VisitorId" },
                values: new object[] { 3, 3, new DateTime(2022, 1, 15, 15, 31, 51, 252, DateTimeKind.Local).AddTicks(2012), new DateTime(2022, 1, 15, 12, 31, 51, 252, DateTimeKind.Local).AddTicks(2010), 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Cabins_CounselorId",
                table: "Cabins",
                column: "CounselorId");

            migrationBuilder.CreateIndex(
                name: "IX_CamperRegistries_CabinId",
                table: "CamperRegistries",
                column: "CabinId");

            migrationBuilder.CreateIndex(
                name: "IX_CamperRegistries_CamperId",
                table: "CamperRegistries",
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
                column: "CounselorId");

            migrationBuilder.CreateIndex(
                name: "IX_NextOfKins_CamperId",
                table: "NextOfKins",
                column: "CamperId");

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
                name: "CamperRegistries");

            migrationBuilder.DropTable(
                name: "CounselorRegistries");

            migrationBuilder.DropTable(
                name: "Visits");

            migrationBuilder.DropTable(
                name: "NextOfKins");

            migrationBuilder.DropTable(
                name: "Campers");

            migrationBuilder.DropTable(
                name: "Cabins");

            migrationBuilder.DropTable(
                name: "Counselors");
        }
    }
}
