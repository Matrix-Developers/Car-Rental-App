using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LocadoraDeVeiculos.Infra.EntityFramework.Migrations
{
    public partial class t : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBCLIENTE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cnh = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    ValidadeCnh = table.Column<DateTime>(type: "DATETIME", nullable: true),
                    Nome = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    RegistroUnico = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Endereco = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Telefone = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Email = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    EhPessoaFisica = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBCLIENTE", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "TBLOCACAO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VeiculoId = table.Column<int>(type: "int", nullable: true),
                    FuncionarioLocadorId = table.Column<int>(type: "int", nullable: true),
                    ClienteContratanteId = table.Column<int>(type: "int", nullable: true),
                    ClienteCondutorId = table.Column<int>(type: "int", nullable: true),
                    CupomId = table.Column<int>(type: "int", nullable: true),
                    DataDeSaida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataPrevistaDeChegada = table.Column<DateTime>(type: "DATE", nullable: false),
                    DataDeChegada = table.Column<DateTime>(type: "DATE", nullable: false),
                    TipoDoPlano = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    TipoDeSeguro = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    PrecoLocacao = table.Column<double>(type: "FLOAT", nullable: false),
                    PrecoDevolucao = table.Column<double>(type: "FLOAT", nullable: false),
                    EstaAberta = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBLOCACAO", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TBLOCACAO_TBCLIENTE_ClienteCondutorId",
                        column: x => x.ClienteCondutorId,
                        principalTable: "TBCLIENTE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TBLOCACAO_TBCLIENTE_ClienteContratanteId",
                        column: x => x.ClienteContratanteId,
                        principalTable: "TBCLIENTE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TBLOCACAO_TBCUPOM_DESCONTO_CupomId",
                        column: x => x.CupomId,
                        principalTable: "TBCUPOM_DESCONTO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TBLOCACAO_TBFUNCIONARIO_FuncionarioLocadorId",
                        column: x => x.FuncionarioLocadorId,
                        principalTable: "TBFUNCIONARIO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TBLOCACAO_TBVEICULO_VeiculoId",
                        column: x => x.VeiculoId,
                        principalTable: "TBVEICULO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TBSERVICO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    EhTaxadoDiario = table.Column<bool>(type: "BIT", nullable: false),
                    Valor = table.Column<double>(type: "FLOAT", nullable: false),
                    LocacaoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBSERVICO", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TBSERVICO_TBLOCACAO_LocacaoId",
                        column: x => x.LocacaoId,
                        principalTable: "TBLOCACAO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TBCUPOM_DESCONTO_ParceiroId",
                table: "TBCUPOM_DESCONTO",
                column: "ParceiroId");

            migrationBuilder.CreateIndex(
                name: "IX_TBLOCACAO_ClienteCondutorId",
                table: "TBLOCACAO",
                column: "ClienteCondutorId");

            migrationBuilder.CreateIndex(
                name: "IX_TBLOCACAO_ClienteContratanteId",
                table: "TBLOCACAO",
                column: "ClienteContratanteId");

            migrationBuilder.CreateIndex(
                name: "IX_TBLOCACAO_CupomId",
                table: "TBLOCACAO",
                column: "CupomId");

            migrationBuilder.CreateIndex(
                name: "IX_TBLOCACAO_FuncionarioLocadorId",
                table: "TBLOCACAO",
                column: "FuncionarioLocadorId");

            migrationBuilder.CreateIndex(
                name: "IX_TBLOCACAO_VeiculoId",
                table: "TBLOCACAO",
                column: "VeiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_TBSERVICO_LocacaoId",
                table: "TBSERVICO",
                column: "LocacaoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBGRUPOVEICULO");

            migrationBuilder.DropTable(
                name: "TBSERVICO");

            migrationBuilder.DropTable(
                name: "TBLOCACAO");

            migrationBuilder.DropTable(
                name: "TBCLIENTE");

            migrationBuilder.DropTable(
                name: "TBCUPOM_DESCONTO");

            migrationBuilder.DropTable(
                name: "TBFUNCIONARIO");

            migrationBuilder.DropTable(
                name: "TBVEICULO");

            migrationBuilder.DropTable(
                name: "TBPARCEIRO");
        }
    }
}
