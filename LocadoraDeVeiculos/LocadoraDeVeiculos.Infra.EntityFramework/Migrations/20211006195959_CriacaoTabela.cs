using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LocadoraDeVeiculos.Infra.EntityFramework.Migrations
{
    public partial class CriacaoTabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBParceiro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "VARCHAR(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBParceiro", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBCupom",
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
                    ParceiroId = table.Column<int>(type: "int", nullable: false),
                    QtdUtilizada = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBCupom", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TBCupom_TBParceiro_ParceiroId",
                        column: x => x.ParceiroId,
                        principalTable: "TBParceiro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TBCupom_ParceiroId",
                table: "TBCupom",
                column: "ParceiroId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBCupom");

            migrationBuilder.DropTable(
                name: "TBParceiro");
        }
    }
}
