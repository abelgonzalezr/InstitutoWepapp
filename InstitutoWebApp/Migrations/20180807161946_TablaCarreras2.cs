using Microsoft.EntityFrameworkCore.Migrations;

namespace InstitutoWebApp.Migrations
{
    public partial class TablaCarreras2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estudiantes_Carreras_CarrerasId",
                table: "Estudiantes");

            migrationBuilder.DropIndex(
                name: "IX_Estudiantes_CarrerasId",
                table: "Estudiantes");

            migrationBuilder.DropColumn(
                name: "CarrerasId",
                table: "Estudiantes");

            migrationBuilder.CreateIndex(
                name: "IX_Estudiantes_IdCarreras",
                table: "Estudiantes",
                column: "IdCarreras");

            migrationBuilder.AddForeignKey(
                name: "FK_Estudiantes_Carreras_IdCarreras",
                table: "Estudiantes",
                column: "IdCarreras",
                principalTable: "Carreras",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estudiantes_Carreras_IdCarreras",
                table: "Estudiantes");

            migrationBuilder.DropIndex(
                name: "IX_Estudiantes_IdCarreras",
                table: "Estudiantes");

            migrationBuilder.AddColumn<int>(
                name: "CarrerasId",
                table: "Estudiantes",
                nullable: true);

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
    }
}
