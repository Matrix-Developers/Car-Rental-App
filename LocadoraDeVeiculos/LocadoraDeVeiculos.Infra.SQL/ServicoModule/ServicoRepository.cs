using LocadoraDeVeiculos.Dominio.SevicosModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Infra.SQL.Shared;
using System;
using System.Collections.Generic;
using System.Data;

namespace LocadoraDeVeiculos.Controladores.ServicoModule
{
    public class ServicoRepository : RepositoryBase<Servico>, IRepository<Servico>
    {
        #region queries
        protected override string SqlInserirEntidade
        {
            get
            {
                return
                @"INSERT INTO TBSERVICO
                (
                    [NOME],
                    [EHTAXADODIARIO],
                    [VALOR]
                )
                VALUES
                (
                    @NOME,
                    @EHTAXADODIARIO,
                    @VALOR
                )";
            }
        }
        protected override string SqlEditarEntidade
        {
            get
            {
                return
                @"UPDATE 
                    [TBSERVICO]
                SET
                    [NOME] = @NOME,
                    [EHTAXADODIARIO] = @EHTAXADODIARIO,
                    [VALOR] = @VALOR
                WHERE
                    [ID] = @ID";

            }
        }
        protected override string SqlExcluirEntidade
        {
            get
            {
                return @"DELETE FROM [TBSERVICO] WHERE[ID] = @ID";
            }
        }
        protected override string SqlSelecionarEntidadePorId
        {
            get
            {
                return
                @"SELECT  
                    [ID],
                    [NOME],
                    [EHTAXADODIARIO],
                    [VALOR]
                FROM
                    TBSERVICO 
                WHERE 
                    [ID] = @ID";
            }
        }
        protected override string SqlSelecionarTodasEntidades
        {
            get
            {
                return
                @"SELECT 
                    [ID],
                    [NOME],
                    [EHTAXADODIARIO],
                    [VALOR]
                FROM 
                    TBSERVICO ORDER BY ID;";
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
                    [TBSERVICO]
                WHERE 
                    [ID] = @ID";
            }
        }
        #endregion

        protected override Dictionary<string, object> ObtemParametros(Servico entidade)
        {
            var parametros = new Dictionary<string, object>
            {
                { "ID", entidade.Id },
                { "NOME", entidade.Nome },
                { "EHTAXADODIARIO", entidade.EhTaxadoDiario },
                { "VALOR", entidade.Valor }
            };

            return parametros;
        }
        protected override Servico ConverterEmEntidade(IDataReader reader)
        {
            int id = Convert.ToInt32(reader["ID"]);
            string nome = Convert.ToString(reader["NOME"]);
            bool ehTaxadoDiario = Convert.ToBoolean(reader["EHTAXADODIARIO"]);
            double valor = Convert.ToDouble(reader["VALOR"]);

            Servico servico = new(id, nome, ehTaxadoDiario, valor);

            servico.Id = id;

            return servico;
        }
    }
}
