using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InstitutoWebApp.Migrations
{
    public partial class TablaCarreras : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarrerasId",
                table: "Estudiantes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdCarreras",
                table: "Estudiantes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Carreras",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NombreCarrera = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carreras", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Estudiantes_CarrerasId",
                table: "Estudiantes",
                column: "CarrerasId");

            migrationBuilder.AddForeignKey(
                name: "FK_Estudiantes_Carreras_CarrerasId",
                table: "Estudiantes",
                column: "CarrerasId",
                principalTable: "Carreras",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estudiantes_Carreras_CarrerasId",
                table: "Estudiantes");

            migrationBuilder.DropTable(
                name: "Carreras");

            migrationBuilder.DropIndex(
                name: "IX_Estudiantes_CarrerasId",
                table: "Estudiantes");

            migrationBuilder.DropColumn(
                name: "CarrerasId",
                table: "Estudiantes");

            migrationBuilder.DropColumn(
                name: "IdCarreras",
                table: "Estudiantes");
        }
    }
}
