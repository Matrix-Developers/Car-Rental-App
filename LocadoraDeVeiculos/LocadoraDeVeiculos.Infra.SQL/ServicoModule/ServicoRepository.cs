using LocadoraDeVeiculos.Controladores.Shared;
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

        public string InserirNovo(Servico registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "VALIDO")
                registro.Id = Db.Insert(SqlInserirEntidade, ObtemParametros(registro));

            return resultadoValidacao;
        }
        public List<Servico> SelecionarTodos()
        {
            return Db.GetAll(SqlSelecionarTodasEntidades, ConverterEmEntidade);
        }
        public Servico SelecionarPorId(int id)
        {
            return Db.Get(SqlSelecionarEntidadePorId, ConverterEmEntidade, AdicionarParametro("ID", id));
        }
        public string Editar(int id, Servico registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "VALIDO")
            {
                registro.Id = id;
                Db.Update(SqlEditarEntidade, ObtemParametros(registro));
            }

            return resultadoValidacao;
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

        protected override Dictionary<string, object> ObtemParametros(Servico entidade)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", entidade.Id);
            parametros.Add("NOME", entidade.Nome);
            parametros.Add("EHTAXADODIARIO", entidade.EhTaxadoDiario);
            parametros.Add("VALOR", entidade.Valor);

            return parametros;
        }
        protected override Servico ConverterEmEntidade(IDataReader reader)
        {
            int id = Convert.ToInt32(reader["ID"]);
            string nome = Convert.ToString(reader["NOME"]);
            bool ehTaxadoDiario = Convert.ToBoolean(reader["EHTAXADODIARIO"]);
            double valor = Convert.ToDouble(reader["VALOR"]);

            Servico servico = new Servico(id, nome, ehTaxadoDiario, valor);

            servico.Id = id;

            return servico;
        }
    }
}
