﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Controle.Cursos.Migrations
{
    public partial class UserdBModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
              name: "UsuarioModel",
              columns: table => new
              {
                  Id = table.Column<int>(type: "int", nullable: false)
                      .Annotation("SqlServer:Identity", "1, 1"),
                  Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                  Senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                  Perfil = table.Column<int>(type: "int", nullable: false),
              },
              constraints: table =>
              {
                  table.PrimaryKey("PK_UsuarioModel", x => x.Id);
              });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsuarioModel");
        }
    }
}
