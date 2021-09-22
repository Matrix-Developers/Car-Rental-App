using LocadoraDeVeiculos.Controladores.Shared;
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

        public string InserirNovo(Parceiro registro)
        {
            registro.Id = Db.Insert(SqlInserirEntidade, ObtemParametros(registro));
            return "VALIDO";
        }
        public List<Parceiro> SelecionarTodos()
        {
            return Db.GetAll(SqlSelecionarTodasEntidades, ConverterEmEntidade);
        }
        public Parceiro SelecionarPorId(int id)
        {
            return Db.Get(SqlSelecionarEntidadePorId, ConverterEmEntidade, AdicionarParametro("ID", id));
        }
        public string Editar(int id, Parceiro registro)
        {

            registro.Id = id;
            Db.Update(SqlEditarEntidade, ObtemParametros(registro));

            return "VALIDO";
        }
        public bool Excluir(int id)
        {
            try
            {
                Db.Delete(SqlExcluirEntidade, AdicionarParametro("ID", id));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
        public bool Existe(int id)
        {
            return Db.Exists(SqlExisteEntidade, AdicionarParametro("ID", id));
        }

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
