using LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Infra.SQL.Shared;
using System;
using System.Collections.Generic;
using System.Data;

namespace LocadoraDeVeiculos.Controladores.GrupoDeVeiculosModule
{
    public class GrupoDeVeiculosRepository : RepositoryBase<GrupoDeVeiculo>, IRepository<GrupoDeVeiculo>
    {
        #region queries
        protected override string SqlInserirEntidade
        {
            get
            {
                return
                    @"INSERT INTO [TBGRUPOVEICULO]
                    (
	                    [NOME],
	                    [TAXAPLANODIARIO],
	                    [TAXAPORKMDIARIO],
	                    [TAXAPLANOCONTROLADO],
	                    [LIMITEKMCONTROLADO],
	                    [TAXAKMEXCEDIDOCONTROLADO],
	                    [TAXAPLANOLIVRE]
                    )
                    VALUES
                    (
	                    @NOME,
	                    @TAXAPLANODIARIO,
	                    @TAXAPORKMDIARIO,
	                    @TAXAPLANOCONTROLADO,
	                    @LIMITEKMCONTROLADO,
	                    @TAXAKMEXCEDIDOCONTROLADO,
	                    @TAXAPLANOLIVRE
                    );";
            }
        }
        protected override string SqlEditarEntidade
        {
            get
            {
                return
                    @"UPDATE [TBGRUPOVEICULO] 
                    SET
	                    [NOME] = @NOME,
	                    [TAXAPLANODIARIO] = @TAXAPLANODIARIO,
	                    [TAXAPORKMDIARIO] = @TAXAPORKMDIARIO,
	                    [TAXAPLANOCONTROLADO] = @TAXAPLANOCONTROLADO,
	                    [LIMITEKMCONTROLADO] = @LIMITEKMCONTROLADO,
	                    [TAXAKMEXCEDIDOCONTROLADO] = @TAXAKMEXCEDIDOCONTROLADO,
	                    [TAXAPLANOLIVRE] = @TAXAPLANOLIVRE
                    WHERE [ID] = @ID;";
            }
        }
        protected override string SqlExcluirEntidade
        {
            get
            {
                return
                    @"DELETE FROM [TBGRUPOVEICULO]  WHERE [ID] = @ID;";
            }
        }
        protected override string SqlSelecionarEntidadePorId
        {
            get
            {
                return
                    @"SELECT * FROM [TBGRUPOVEICULO] WHERE [ID] = @ID;";
            }
        }
        protected override string SqlSelecionarTodasEntidades
        {
            get
            {
                return
                    @"SELECT * FROM [TBGRUPOVEICULO];";
            }
        }
        protected override string SqlExisteEntidade
        {
            get
            {
                return
                    @"SELECT 
                        COUNT(*) 
                    FROM 
                        [TBGRUPOVEICULO]
                    WHERE 
                        [ID] = @ID";
            }
        }
        #endregion

        protected override Dictionary<string, object> ObtemParametros(GrupoDeVeiculo entidade)
        {
            var parametros = new Dictionary<string, object>
            {
                { "ID", entidade.Id },
                { "NOME", entidade.Nome },
                { "TAXAPLANODIARIO", entidade.TaxaPlanoDiario },
                { "TAXAPORKMDIARIO", entidade.TaxaPorKmDiario },
                { "TAXAPLANOCONTROLADO", entidade.TaxaPlanoControlado },
                { "LIMITEKMCONTROLADO", entidade.LimiteKmControlado },
                { "TAXAKMEXCEDIDOCONTROLADO", entidade.TaxaKmExcedidoControlado },
                { "TAXAPLANOLIVRE", entidade.TaxaPlanoLivre }
            };

            return parametros;
        }
        protected override GrupoDeVeiculo ConverterEmEntidade(IDataReader reader)
        {
            int id = Convert.ToInt32(reader["ID"]); ;
            string nome = Convert.ToString(reader["NOME"]); ;
            double taxaPlanoDiario = Convert.ToDouble(reader["TAXAPLANODIARIO"]);
            double taxaPorKmDiario = Convert.ToDouble(reader["TAXAPORKMDIARIO"]);
            double taxaPlanoControlado = Convert.ToDouble(reader["TAXAPLANOCONTROLADO"]);
            int limiteKmControlado = Convert.ToInt32(reader["LIMITEKMCONTROLADO"]);
            double taxaKmExcedidoControlado = Convert.ToDouble(reader["TAXAKMEXCEDIDOCONTROLADO"]);
            double taxaPlanoLivre = Convert.ToDouble(reader["TAXAPLANOLIVRE"]);

            GrupoDeVeiculo grupoDeVeiculos = new(id, nome, taxaPlanoDiario, taxaPorKmDiario, taxaPlanoControlado,
                limiteKmControlado, taxaKmExcedidoControlado, taxaPlanoLivre);

            return grupoDeVeiculos;
        }
    }
}
