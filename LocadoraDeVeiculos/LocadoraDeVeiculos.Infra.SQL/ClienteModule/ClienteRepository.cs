using LocadoraDeVeiculos.Controladores.Shared;
using LocadoraDeVeiculos.Dominio.ClienteModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Infra.SQL.Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

		public string Editar(int id, Cliente registro)
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
		public string InserirNovo(Cliente registro)
		{
			string resultadoValidacao = registro.Validar();

			if (resultadoValidacao == "VALIDO")
			{
				registro.Id = Db.Insert(SqlInserirEntidade, ObtemParametros(registro));
			}
			return resultadoValidacao;
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
			var parametros = new Dictionary<string, object>();

			parametros.Add("ID", entidade.Id);
			parametros.Add("NOME", entidade.Nome);
			parametros.Add("REGISTROUNICO", entidade.RegistroUnico);
			parametros.Add("ENDERECO", entidade.Endereco);
			parametros.Add("TELEFONE", entidade.Telefone);
			parametros.Add("EMAIL", entidade.Email);
			parametros.Add("CNH", entidade.Cnh);
			parametros.Add("VALIDADECNH", entidade.ValidadeCnh);
			parametros.Add("EHPESSOAFISICA", entidade.EhPessoaFisica);

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

			Cliente cliente = new Cliente(id, nome, registroUnico, endereco, telefone, email, cnh, validadeCnh, ehPessoaFisica);
			cliente.Id = id;
			return cliente;
		}
	}
}
