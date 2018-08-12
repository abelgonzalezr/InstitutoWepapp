using Microsoft.EntityFrameworkCore.Migrations;

namespace InstitutoWebApp.Migrations
{
    public partial class IndexNonClusteredCedula : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdCedula",
                table: "Estudiantes",
                newName: "Cedula");

            migrationBuilder.CreateIndex(
                name: "IX_Estudiantes_Cedula",
                table: "Estudiantes",
                column: "Cedula");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Estudiantes_Cedula",
                table: "Estudiantes");

            migrationBuilder.RenameColumn(
                name: "Cedula",
                table: "Estudiantes",
                newName: "IdCedula");
        }
    }
}
