using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LocadoraDeVeiculos.Infra.EntityFramework.Migrations
{
    public partial class TabelaFuncionario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBFUNCIONARIO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MatriculaInterna = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    UsuarioAcesso = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    DataAdmissao = table.Column<DateTime>(type: "DATE", nullable: false),
                    Cargo = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Salario = table.Column<double>(type: "FLOAT", nullable: false),
                    Senha = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Nome = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    RegistroUnico = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Endereco = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Telefone = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Email = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    EhPessoaFisica = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBFUNCIONARIO", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBFUNCIONARIO");
        }
    }
}
