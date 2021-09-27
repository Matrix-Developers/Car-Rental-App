using LocadoraDeVeiculos.Dominio.ParceiroModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Infra.SQL.Shared;
using System;
using System.Collections.Generic;
using System.Data;

namespace LocadoraDeVeiculos.Controladores.ParceiroModule
{
    public class ParceiroRepository : RepositoryBase<Parceiro>, IRepository<Parceiro>
    {
        #region queries
        protected override string SqlInserirEntidade
        {
            get
            {
                return
                @"INSERT INTO [TBPARCEIRO]
	            (
		            [NOMEPARCEIRO]
	            ) 
	            VALUES
	            (
                    @NOMEPARCEIRO
	            );";
            }
        }
        protected override string SqlEditarEntidade
        {
            get
            {
                return
                @"UPDATE [TBPARCEIRO]
                SET
                    [NOMEPARCEIRO] = @NOMEPARCEIRO
                WHERE 
                    ID = @ID";
            }
        }
        protected override string SqlExcluirEntidade
        {
            get
            {
                return
                @"DELETE FROM [TBPARCEIRO] WHERE [ID] = @ID";
            }
        }
        protected override string SqlSelecionarEntidadePorId
        {
            get
            {
                return
                @"SELECT * FROM [TBPARCEIRO] WHERE ID = @ID";
            }
        }
        protected override string SqlSelecionarTodasEntidades
        {
            get
            {
                return
                @"SELECT * FROM [TBPARCEIRO]";
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
                    [TBPARCEIRO]
                WHERE 
                    [ID] = @ID";
            }
        }
        #endregion

        protected override Dictionary<string, object> ObtemParametros(Parceiro entidade)
        {
            var parametros = new Dictionary<string, object>
            {
                { "ID", entidade.Id },
                { "NOMEPARCEIRO", entidade.Nome }
            };

            return parametros;
        }
        protected override Parceiro ConverterEmEntidade(IDataReader reader)
        {
            int id = Convert.ToInt32(reader["ID"]);
            string nome = Convert.ToString(reader["NOMEPARCEIRO"]);

            Parceiro parceiro = new(id, nome)
            {
                Id = id
            };

            return parceiro;
        }
    }
}
