using LocadoraDeVeiculos.Controladores.Shared;
using LocadoraDeVeiculos.Dominio.ClienteModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Infra.SQL.Shared;
using System;
using System.Collections.Generic;
using System.Data;

namespace LocadoraDeVeiculos.Controladores.ClientesModule
{
    public class ClienteRepository : RepositoryBase<Cliente>, IRepository<Cliente>
    {
        #region queries

        protected override string SqlInserirEntidade
        {
            get
            {
                return
                    @"INSERT INTO [TBCLIENTE]
					(
					    [NOME],
					    [REGISTROUNICO],
					    [ENDERECO],
					    [EMAIL],
					    [TELEFONE],
					    [EHPESSOAFISICA],
					    [CNH],
					    [VALIDADECNH]
					)
					VALUES
					(
					    @NOME,
					    @REGISTROUNICO,
					    @ENDERECO,
					    @EMAIL,
					    @TELEFONE,
					    @EHPESSOAFISICA,
					    @CNH,
					    @VALIDADECNH
					)";
            }
        }
        protected override string SqlEditarEntidade
        {
            get
            {
                return
                    @"UPDATE [TBCLIENTE] 
					SET
						[NOME] = @NOME,
						[REGISTROUNICO] = @REGISTROUNICO,
						[ENDERECO] = @ENDERECO,
						[TELEFONE] = @TELEFONE,
						[EMAIL] = @EMAIL,
						[EHPESSOAFISICA] = @EHPESSOAFISICA,
						[CNH] = @CNH,
						[VALIDADECNH] = @VALIDADECNH
					WHERE [ID] = @ID;";
            }
        }
        protected override string SqlExcluirEntidade
        {
            get
            {
                return
                    @"DELETE FROM [TBCLIENTE] WHERE [ID] = @ID";
            }
        }
        protected override string SqlSelecionarEntidadePorId
        {
            get
            {
                return
                    @"SELECT * FROM [TBCLIENTE] WHERE [ID] = @ID;";
            }
        }
        protected override string SqlSelecionarTodasEntidades
        {
            get
            {
                return
                    @" SELECT * FROM [TBCLIENTE]";
            }
        }
        protected override string SqlExisteEntidade
        {
            get
            {
                return
                    @"SELECT COUNT(*) FROM [TBCLIENTE] WHERE [ID] = @ID";
            }
        }
        #endregion

        public string InserirNovo(Cliente registro)
        {
            registro.Id = Db.Insert(SqlInserirEntidade, ObtemParametros(registro));
            return "VALIDO";
        }
        public string Editar(int id, Cliente registro)
        {
            registro.Id = id;
            Db.Update(SqlEditarEntidade, ObtemParametros(registro));
            return "VALIDO"; ;
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

        public Cliente SelecionarPorId(int id)
        {
            return Db.Get(SqlSelecionarEntidadePorId, ConverterEmEntidade, AdicionarParametro("ID", id));
        }
        public List<Cliente> SelecionarTodos()
        {
            return Db.GetAll(SqlSelecionarTodasEntidades, ConverterEmEntidade);
        }

        protected override Dictionary<string, object> ObtemParametros(Cliente entidade)
        {
            var parametros = new Dictionary<string, object>
            {
                { "ID", entidade.Id },
                { "NOME", entidade.Nome },
                { "REGISTROUNICO", entidade.RegistroUnico },
                { "ENDERECO", entidade.Endereco },
                { "TELEFONE", entidade.Telefone },
                { "EMAIL", entidade.Email },
                { "CNH", entidade.Cnh },
                { "VALIDADECNH", entidade.ValidadeCnh },
                { "EHPESSOAFISICA", entidade.EhPessoaFisica }
            };

            return parametros;
        }
        protected override Cliente ConverterEmEntidade(IDataReader reader)
        {
            DateTime? validadeCnh = null;
            int id = Convert.ToInt32(reader["ID"]);
            string nome = Convert.ToString((reader["NOME"]));
            string registroUnico = Convert.ToString((reader["REGISTROUNICO"]));
            string endereco = Convert.ToString(reader["ENDERECO"]);
            string telefone = Convert.ToString(reader["TELEFONE"]);
            string email = Convert.ToString(reader["EMAIL"]);
            string cnh = Convert.ToString(reader["CNH"]);
            if (reader["VALIDADECNH"] != DBNull.Value)
                validadeCnh = Convert.ToDateTime(reader["VALIDADECNH"]);
            bool ehPessoaFisica = Convert.ToBoolean(reader["EHPESSOAFISiCA"]);

            Cliente cliente = new(id, nome, registroUnico, endereco, telefone, email, cnh, validadeCnh, ehPessoaFisica)
            {
                Id = id
            };
            return cliente;
        }
    }
}
