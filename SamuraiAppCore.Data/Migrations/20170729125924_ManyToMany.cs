using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SamuraiAppCore.Data.Migrations
{
    public partial class ManyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Samurais_Buttles_ButtleId",
                table: "Samurais");

            migrationBuilder.DropIndex(
                name: "IX_Samurais_ButtleId",
                table: "Samurais");

            migrationBuilder.DropColumn(
                name: "ButtleId",
                table: "Samurais");

            migrationBuilder.CreateTable(
                name: "SamuraiButtles",
                columns: table => new
                {
                    ButtleId = table.Column<int>(nullable: false),
                    SamuraiId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SamuraiButtles", x => new { x.ButtleId, x.SamuraiId });
                    table.ForeignKey(
                        name: "FK_SamuraiButtles_Buttles_ButtleId",
                        column: x => x.ButtleId,
                        principalTable: "Buttles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SamuraiButtles_Samurais_SamuraiId",
                        column: x => x.SamuraiId,
                        principalTable: "Samurais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SamuraiButtles_SamuraiId",
                table: "SamuraiButtles",
                column: "SamuraiId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SamuraiButtles");

            migrationBuilder.AddColumn<int>(
                name: "ButtleId",
                table: "Samurais",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Samurais_ButtleId",
                table: "Samurais",
                column: "ButtleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Samurais_Buttles_ButtleId",
                table: "Samurais",
                column: "ButtleId",
                principalTable: "Buttles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
