using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LocadoraDeVeiculos.Infra.EntityFramework.Migrations
{
    public partial class Base : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "TBPARCEIRO");
        }
    }
}
