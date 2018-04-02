using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BuscaIntimacao.Infra.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cartorio",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Codigo = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(type: "varchar(50)", nullable: true),
                    Telefone = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(type: "varchar(50)", nullable: true),
                    Cep = table.Column<string>(type: "varchar(10)", nullable: true),
                    Cidade = table.Column<string>(type: "varchar(50)", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    Endereco = table.Column<string>(type: "varchar(100)", nullable: true),
                    Numero = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cartorio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Devedor",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(type: "varchar(50)", nullable: true),
                    Numero = table.Column<string>(type: "varchar(50)", nullable: true),
                    Tipo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devedor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Intimacao",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Ativa = table.Column<bool>(type: "bit", nullable: false),
                    CartorioId = table.Column<Guid>(nullable: true),
                    Codigo = table.Column<string>(type: "Varchar(8)", nullable: true),
                    DevedorId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Intimacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Intimacao_Cartorio_CartorioId",
                        column: x => x.CartorioId,
                        principalTable: "Cartorio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Intimacao_Devedor_DevedorId",
                        column: x => x.DevedorId,
                        principalTable: "Devedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Intimacao_CartorioId",
                table: "Intimacao",
                column: "CartorioId");

            migrationBuilder.CreateIndex(
                name: "IX_Intimacao_DevedorId",
                table: "Intimacao",
                column: "DevedorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Intimacao");

            migrationBuilder.DropTable(
                name: "Cartorio");

            migrationBuilder.DropTable(
                name: "Devedor");
        }
    }
}
