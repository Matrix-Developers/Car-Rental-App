using LocadoraDeVeiculos.Controladores.Shared;
using LocadoraDeVeiculos.Dominio.ClienteModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Controladores.ClientesModule
{
    public class ControladorCliente : Controlador<Cliente>
    {
        #region Queries
            private const string sqlInserirClientes =
            @"
               INSERT INTO [TBCLIENTE]
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

		private const string sqlEditarClientes =
		@"
				UPDATE [TBCLIENTE] 
				 SET
					[NOME] = @NOME,
					[REGISTROUNICO] = @REGISTROUNICO,
					[ENDERECO] = @ENDERECO,
					[TELEFONE] = @TELEFONE,
					[EMAIL] = @EMAIL,
					[EHPESSOAFISICA] = @EHPESSOAFISICA,
					[CNH] = @CNH,
					[VALIDADECNH] = @VALIDADECNH
				WHERE [ID] = @ID;
            )";

		private const string sqlExcluirClientes =
		@"
				DELETE FROM [TBCLIENTE] WHERE [ID] = @ID
			";

		private const string sqlSelecionarTodosClientes =
		@"
			SELECT * FROM [TBCLIENTE]
			";

		private const string sqlSelecionarClientesPorId =
		@"
			SELECT * FROM [TBCLIENTE] WHERE [ID] = @ID;
			";

			private const string sqlExisteCliente =
			@"SELECT 
                COUNT(*) 
            FROM 
                [TBCLIENTE]
            WHERE 
                [ID] = @ID";

		#endregion

		public override string Editar(int id, Cliente registro)
		{
			string resultadoValidacao = registro.Validar();

			if (resultadoValidacao == "VALIDO")
			{
				registro.Id = id;
				Db.Update(sqlEditarClientes, ObtemParametrosClientes(registro));
			}

			return resultadoValidacao;
		}

		public override bool Excluir(int id)
		{
			try
			{
				Db.Delete(sqlExcluirClientes, AdicionarParametro("ID", id));
			}
			catch (Exception)
			{
				return false;
			}

			return true;
		}

		public override bool Existe(int id)
		{
			return Db.Exists(sqlExisteCliente, AdicionarParametro("ID", id));
		}

		public override string InserirNovo(Cliente registro)
		{
			string resultadoValidacao = registro.Validar();

			if (resultadoValidacao == "VALIDO")
			{
				registro.Id = Db.Insert(sqlInserirClientes, ObtemParametrosClientes(registro));
			}
			return resultadoValidacao;
		}

       

        public override Cliente SelecionarPorId(int id)
		{
			return Db.Get(sqlSelecionarClientesPorId, ConverterEmClientes, AdicionarParametro("ID", id));
		}

		public override List<Cliente> SelecionarTodos()
		{
			return Db.GetAll(sqlSelecionarTodosClientes, ConverterEmClientes);
		}

        private Cliente ConverterEmClientes(IDataReader reader)
        {
			int id = Convert.ToInt32(reader["ID"]);
			string nome = Convert.ToString((reader["NOME"]));
			string registroUnico = Convert.ToString((reader["REGISTROUNICO"]));
			string endereco = Convert.ToString(reader["ENDERECO"]);
			string telefone = Convert.ToString(reader["TELEFONE"]);
			string email = Convert.ToString(reader["EMAIL"]);
			string cnh = Convert.ToString(reader["CNH"]);
			DateTime validadeCnh = Convert.ToDateTime(reader["VALIDADECNH"]);
			bool ehPessoaFisica = Convert.ToBoolean(reader["EHPESSOAFISiCA"]);

			Cliente cliente = new Cliente(id, nome, registroUnico, endereco, telefone, email, cnh, validadeCnh, ehPessoaFisica);
			cliente.Id = id;
			return cliente;
		}

        private Dictionary<string, object> ObtemParametrosClientes(Cliente cliente)
		{
			var parametros = new Dictionary<string, object>();

			parametros.Add("ID", cliente.Id);
			parametros.Add("NOME", cliente.Nome);
			parametros.Add("REGISTROUNICO", cliente.RegistroUnico);
			parametros.Add("ENDERECO", cliente.Endereco);
			parametros.Add("TELEFONE", cliente.Telefone);
			parametros.Add("EMAIL", cliente.Email);
			parametros.Add("CNH", cliente.Cnh);
			parametros.Add("VALIDADECNH", cliente.ValidadeCnh);
			parametros.Add("EHPESSOAFISICA", cliente.EhPessoaFisica);

			return parametros;
		}
	}
}
