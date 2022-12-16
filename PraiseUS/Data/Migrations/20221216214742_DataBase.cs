using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PraiseUS.Data.Migrations
{
    public partial class DataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Locataire",
                columns: table => new
                {
                    locataireId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nationalite = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateDeNaissance = table.Column<DateTime>(type: "datetime2", nullable: false),
                    inscriptionDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locataire", x => x.locataireId);
                });

            migrationBuilder.CreateTable(
                name: "Avis",
                columns: table => new
                {
                    avisId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    note = table.Column<int>(type: "int", nullable: false),
                    commentaire = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    avisDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    locataireId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avis", x => x.avisId);
                    table.ForeignKey(
                        name: "FK_Avis_Locataire_locataireId",
                        column: x => x.locataireId,
                        principalTable: "Locataire",
                        principalColumn: "locataireId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Avis_locataireId",
                table: "Avis",
                column: "locataireId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Avis");

            migrationBuilder.DropTable(
                name: "Locataire");
        }
    }
}
