using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gaming.DataAccess.Migrations
{
    public partial class initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    GamePrice = table.Column<double>(type: "float", nullable: false),
                    GameCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GamePlatform = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GameScore = table.Column<double>(type: "float", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Games_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CompanyName" },
                values: new object[,]
                {
                    { 1, "Rocksteady" },
                    { 2, "Ubisoft" },
                    { 3, "Frogwares" },
                    { 4, "EA Sports" },
                    { 5, "Rare Ltd" },
                    { 6, "Psyonix" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CompanyId", "CreatedTime", "GameCategory", "GameName", "GamePlatform", "GamePrice", "GameScore", "IsActive", "LastUpdatedTime" },
                values: new object[,]
                {
                    { 1, 2, null, "Suikastçı", "Assassin's Creed II", "PC", 45.0, 4.5, true, null },
                    { 2, 1, null, "Süper Kahraman", "Batman Arkham Knight", "PC", 50.0, 4.2000000000000002, true, null },
                    { 3, 3, null, "Dedektif", "Sherlock Holmes: Chapter One", "PC", 109.45, 4.7000000000000002, true, null },
                    { 4, 3, null, "Dedektif", "Sherlock Holmes: Crimes and Punishments", "PC", 39.149999999999999, 3.8999999999999999, true, null },
                    { 5, 4, null, "Futbol", "FIFA 2022", "Konsol", 800.0, 4.4000000000000004, true, null },
                    { 6, 5, null, "Macera", "Sea of Thieves", "PC", 61.0, 4.5999999999999996, true, null },
                    { 7, 6, null, "Spor", "Rocket League", "PC", 0.0, 4.7999999999999998, true, null },
                    { 8, 2, null, "Nişancı", "Far Cry 6", "PC", 134.15000000000001, 4.5, true, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Games_CompanyId",
                table: "Games",
                column: "CompanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
