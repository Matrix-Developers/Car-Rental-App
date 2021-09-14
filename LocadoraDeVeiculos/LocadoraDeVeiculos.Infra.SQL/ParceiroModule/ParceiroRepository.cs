using LocadoraDeVeiculos.Controladores.Shared;
using LocadoraDeVeiculos.Dominio.ParceiroModule;
using LocadoraDeVeiculos.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Controladores.ParceiroModule
{
    public class ParceiroRepository : IRepository<Parceiro>
    {
        #region queries
        private const string sqlInserirParceiro =
            @"INSERT INTO TBPARCEIRO
	                (
		                [NOMEPARCEIRO]
	                ) 
	                VALUES
	                (
                        @NOMEPARCEIRO
	                )";

        private const string sqlEditarParceiro =
            @"UPDATE TBPARCEIRO
                    SET
                        [NOMEPARCEIRO] = @NOMEPARCEIRO
                    WHERE 
                        ID = @ID";

        private const string sqlDeletarParceiro =
            @"DELETE 
	                FROM
                        TBPARCEIRO
                    WHERE 
                        ID = @ID";

        private const string sqlSelecionarParceiroPorId =
            @"SELECT
                        [ID],
		                [NOMEPARCEIRO]
	                FROM
                        TBPARCEIRO
                    WHERE 
                        ID = @ID";

        private const string sqlSelecionarTodosParceiros =
            @"SELECT
                        [ID],
		                [NOMEPARCEIRO]
	                FROM
                        TBPARCEIRO";

        private const string sqlExisteParceiro =
            @"SELECT 
                    COUNT(*) 
                FROM 
                    [TBPARCEIRO]
                WHERE 
                    [ID] = @ID";
        #endregion

        public string InserirNovo(Parceiro registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "VALIDO")
                registro.Id = Db.Insert(sqlInserirParceiro, ObtemParametrosParceiro(registro));

            return resultadoValidacao;
        }
        public List<Parceiro> SelecionarTodos()
        {
            return Db.GetAll(sqlSelecionarTodosParceiros, ConverterEmParceiro);
        }       
        public Parceiro SelecionarPorId(int id)
        {
            return Db.Get(sqlSelecionarParceiroPorId, ConverterEmParceiro, AdicionarParametro("ID", id));
        }        
        public string Editar(int id, Parceiro registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "VALIDO")
            {
                registro.Id = id;
                Db.Update(sqlEditarParceiro, ObtemParametrosParceiro(registro));
            }

            return resultadoValidacao;
        }

        public bool Excluir(int id)
        {
            try
            {
                Db.Delete(sqlDeletarParceiro, AdicionarParametro("ID", id));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public bool Existe(int id)
        {
            return Db.Exists(sqlExisteParceiro, AdicionarParametro("ID", id));
        }

        private Dictionary<string, object> ObtemParametrosParceiro(Parceiro registro)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", registro.Id);
            parametros.Add("NOMEPARCEIRO", registro.Nome);

            return parametros;
        }
        private Parceiro ConverterEmParceiro(IDataReader reader)
        {
            int id = Convert.ToInt32(reader["ID"]);
            string nome = Convert.ToString(reader["NOMEPARCEIRO"]);

            Parceiro parceiro = new Parceiro(id, nome);

            parceiro.Id = id;

            return parceiro;
        }
        protected Dictionary<string, object> AdicionarParametro(string campo, object valor)
        {
            return new Dictionary<string, object>() { { campo, valor } };
        }
    }
}
