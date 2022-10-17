using Microsoft.EntityFrameworkCore.Migrations;

namespace Controle.Cursos.Migrations
{
    public partial class m014 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Curso_Alunos_AlunoId",
                table: "Curso");

            migrationBuilder.DropIndex(
                name: "IX_Curso_AlunoId",
                table: "Curso");

            migrationBuilder.DropColumn(
                name: "AlunoId",
                table: "Curso");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AlunoId",
                table: "Curso",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Curso_AlunoId",
                table: "Curso",
                column: "AlunoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Curso_Alunos_AlunoId",
                table: "Curso",
                column: "AlunoId",
                principalTable: "Alunos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
