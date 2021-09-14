using LocadoraDeVeiculos.Controladores.Shared;
using LocadoraDeVeiculos.Dominio.SevicosModule;
using LocadoraDeVeiculos.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Data;

namespace LocadoraDeVeiculos.Controladores.ServicoModule
{
    public class ServicoRepository : IRepository<Servico>
    {
        #region queries
        private const string sqlInserirServico =
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
        private const string sqlSelecionarTodosServicos =
            @"SELECT 
                [ID],
                [NOME],
                [EHTAXADODIARIO],
                [VALOR]
            FROM 
                TBSERVICO ORDER BY ID;";

        private const string sqlSelecionarServicoPorId =
            @"SELECT  
                [ID],
                [NOME],
                [EHTAXADODIARIO],
                [VALOR]
            FROM
                TBSERVICO 
            WHERE 
                [ID] = @ID";

        private const string sqlEditarServico =
            @"UPDATE TBSERVICO SET
                [NOME] = @NOME,
                [EHTAXADODIARIO] = @EHTAXADODIARIO,
                [VALOR] = @VALOR
            WHERE
                [ID] = @ID
            ";
        private const string sqlDeletarServico =
            @"DELETE 
                FROM 
                TBSERVICO 
            WHERE 
                [ID] = @ID";

        private const string sqlExisteServico =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBSERVICO]
            WHERE 
                [ID] = @ID";
        #endregion

        public string InserirNovo(Servico registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "VALIDO")
                registro.Id = Db.Insert(sqlInserirServico, ObtemParametrosServico(registro));

            return resultadoValidacao;
        }
        public List<Servico> SelecionarTodos()
        {
            return Db.GetAll(sqlSelecionarTodosServicos, ConverterEmServico);
        }
        public Servico SelecionarPorId(int id)
        {
            return Db.Get(sqlSelecionarServicoPorId, ConverterEmServico, AdicionarParametro("ID", id));
        }
        public string Editar(int id, Servico registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "VALIDO")
            {
                registro.Id = id;
                Db.Update(sqlEditarServico, ObtemParametrosServico(registro));
            }

            return resultadoValidacao;
        }
        public bool Excluir(int id)
        {
            try
            {
                Db.Delete(sqlDeletarServico, AdicionarParametro("ID", id));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
        public bool Existe(int id)
        {
            return Db.Exists(sqlExisteServico, AdicionarParametro("ID", id));
        }

        private Dictionary<string, object> ObtemParametrosServico(Servico servico)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", servico.Id);
            parametros.Add("NOME", servico.Nome);
            parametros.Add("EHTAXADODIARIO", servico.EhTaxadoDiario);
            parametros.Add("VALOR", servico.Valor);

            return parametros;
        }
        private Servico ConverterEmServico(IDataReader reader)
        {
            int id = Convert.ToInt32(reader["ID"]);
            string nome = Convert.ToString(reader["NOME"]);
            bool ehTaxadoDiario = Convert.ToBoolean(reader["EHTAXADODIARIO"]);
            double valor = Convert.ToDouble(reader["VALOR"]);

            Servico servico = new Servico(id, nome, ehTaxadoDiario, valor);

            servico.Id = id;

            return servico;
        }
        protected Dictionary<string, object> AdicionarParametro(string campo, object valor)
        {
            return new Dictionary<string, object>() { { campo, valor } };
        }
    }
}
