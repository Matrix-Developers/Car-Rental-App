using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LocadoraDeVeiculos.Infra.EntityFramework.Migrations
{
    public partial class CriacaoTabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBGRUPOVEICULO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    TaxaPlanoDiario = table.Column<double>(type: "FLOAT", nullable: false),
                    TaxaPorKmDiario = table.Column<double>(type: "FLOAT", nullable: false),
                    TaxaPlanoControlado = table.Column<double>(type: "FLOAT", nullable: false),
                    LimiteKmControlado = table.Column<int>(type: "INT", nullable: false),
                    TaxaKmExcedidoControlado = table.Column<double>(type: "FLOAT", nullable: false),
                    TaxaPlanoLivre = table.Column<double>(type: "FLOAT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBGRUPOVEICULO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBPARCEIRO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "VARCHAR(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBPARCEIRO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBVEICULO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ano = table.Column<int>(type: "INT", nullable: false),
                    capacidadePessoas = table.Column<int>(type: "INT", nullable: false),
                    capacidadeTanque = table.Column<double>(type: "FLOAT", nullable: false),
                    chassi = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    cor = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    estaAlugado = table.Column<bool>(type: "BIT", nullable: false),
                    id_GrupoVeiculo = table.Column<int>(type: "INT", nullable: false),
                    kilometragem = table.Column<double>(type: "FLOAT", nullable: false),
                    marca = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    modelo = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    numeroPortas = table.Column<int>(type: "INT", nullable: false),
                    placa = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    tamanhoPortaMala = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    temArCondicionado = table.Column<bool>(type: "BIT", nullable: false),
                    temDirecaoHidraulica = table.Column<bool>(type: "BIT", nullable: false),
                    temFreiosAbs = table.Column<bool>(type: "BIT", nullable: false),
                    tipoCombustivel = table.Column<string>(type: "VARCHAR(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBVEICULO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBCUPOM_DESCONTO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Codigo = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Valor = table.Column<double>(type: "FLOAT", nullable: false),
                    ValorMinimo = table.Column<double>(type: "FLOAT", nullable: false),
                    EhDescontoFixo = table.Column<bool>(type: "BIT", nullable: false),
                    Validade = table.Column<DateTime>(type: "DATE", nullable: false),
                    ParceiroId = table.Column<int>(type: "INT", nullable: false),
                    QtdUtilizada = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBCUPOM_DESCONTO", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TBCUPOM_DESCONTO_TBPARCEIRO_ParceiroId",
                        column: x => x.ParceiroId,
                        principalTable: "TBPARCEIRO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TBCUPOM_DESCONTO_ParceiroId",
                table: "TBCUPOM_DESCONTO",
                column: "ParceiroId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBCUPOM_DESCONTO");

            migrationBuilder.DropTable(
                name: "TBGRUPOVEICULO");

            migrationBuilder.DropTable(
                name: "TBVEICULO");

            migrationBuilder.DropTable(
                name: "TBPARCEIRO");
        }
    }
}
