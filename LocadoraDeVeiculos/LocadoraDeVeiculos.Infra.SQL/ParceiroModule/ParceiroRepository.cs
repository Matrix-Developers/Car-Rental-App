using LocadoraDeVeiculos.Controladores.Shared;
using LocadoraDeVeiculos.Dominio.ParceiroModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Infra.SQL.Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Controladores.ParceiroModule
{
    public class ParceiroRepository : RepositoryBase<Parceiro>, IRepository<Parceiro>
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
                registro.Id = Db.Insert(sqlInserirParceiro, ObtemParametros(registro));

            return resultadoValidacao;
        }
        public List<Parceiro> SelecionarTodos()
        {
            return Db.GetAll(sqlSelecionarTodosParceiros, ConverterEmEntidade);
        }       
        public Parceiro SelecionarPorId(int id)
        {
            return Db.Get(sqlSelecionarParceiroPorId, ConverterEmEntidade, AdicionarParametro("ID", id));
        }        
        public string Editar(int id, Parceiro registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "VALIDO")
            {
                registro.Id = id;
                Db.Update(sqlEditarParceiro, ObtemParametros(registro));
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

        protected override Dictionary<string, object> ObtemParametros(Parceiro entidade)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", entidade.Id);
            parametros.Add("NOMEPARCEIRO", entidade.Nome);

            return parametros;
        }
        protected override Parceiro ConverterEmEntidade(IDataReader reader)
        {
            int id = Convert.ToInt32(reader["ID"]);
            string nome = Convert.ToString(reader["NOMEPARCEIRO"]);

            Parceiro parceiro = new Parceiro(id, nome);

            parceiro.Id = id;

            return parceiro;
        }
    }
}
