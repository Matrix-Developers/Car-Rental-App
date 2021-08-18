using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocadoraDeVeiculos.Controladores.Shared;
using LocadoraDeVeiculos.Dominio.FuncionarioModule;
using LocadoraDeVeiculos.Dominio;

namespace LocadoraDeVeiculos.Controladores.FuncionarioModule
{
    public class ControladorFuncionario : Controlador<Funcionario>
    {

        #region Queries
        private const string comandoInserir = @"INSERT INTO TBFUNCIONARIO
										(
											[NOME],
											[REGISTROUNICO],
											[ENDERECO],
											[TELEFONE],
											[EMAIL],
											[EHPESSOAFISICA],
											[MATRICULAINTERNA],
											[USUARIOACESSO],
											[CARGO],
											[SALARIO],
                                            [DATAADMISSAO]
										)
										VALUES
										(
											@NOME,
											@REGISTROUNICO,
											@ENDERECO,
											@TELEFONE,
											@EMAIL,
											@EHPESSOAFISICA,
											@MATRICULAINTERNA,
											@USUARIOACESSO,
											@CARGO,
											@SALARIO,
                                            @DATAADMISSAO
										);";
        private const string comandoEditar = @"UPDATE TBFUNCIONARIO 
									    SET
									    	[NOME] = @NOME,
									    	[REGISTROUNICO] = @REGISTROUNICO,
									    	[ENDERECO] = @ENDERECO,
									    	[TELEFONE] = @TELEFONE,
									    	[EMAIL] = @EMAIL,
									    	[EHPESSOAFISICA] = @EHPESSOAFISICA,
									    	[MATRICULAINTERNA] = @MATRICULAINTERNA,
									    	[USUARIOACESSO] = @USUARIOACESSO,
									    	[CARGO] = @CARGO,
									    	[SALARIO] = @SALARIO,
                                            [DATAADMISSAO] = @DATAADMISSAO
									    WHERE [ID] = @ID;";
        private const string comandoExcluir = @"DELETE FROM TBFUNCIONARIO WHERE [ID] = @ID;";
        private const string comandoSelecionarTodos = "SELECT * FROM TBFUNCIONARIO;";
        private const string comandoSelecionarPorId = "SELECT * FROM TBFUNCIONARIO WHERE [ID] = @ID;";
        #endregion

        public override string Editar(int id, Funcionario registro)
        {
            string resultadoValidacao = registro.Validar();
            if (resultadoValidacao == "VALIDO")
            {
                registro.Id = id;
                Db.Update(comandoEditar, ObtemParametrosFuncionario(registro));
            }
            return resultadoValidacao;
        }

        public override bool Excluir(int id)
        {
            try
            {
                Db.Delete(comandoExcluir, AdicionarParametro("ID", id));
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public override bool Existe(int id)
        {
            return Db.Exists(comandoSelecionarPorId, AdicionarParametro("ID", id));
        }

        public override string InserirNovo(Funcionario registro)
        {
            string resultadoValidacao = registro.Validar();
            if (resultadoValidacao == "VALIDO")
                registro.Id = Db.Insert(comandoInserir, ObtemParametrosFuncionario(registro));

            return resultadoValidacao;
        }

        public override Funcionario SelecionarPorId(int id)
        {
            return Db.Get(comandoSelecionarPorId, ConverterEmFuncionario, AdicionarParametro("ID", id));
        }

        public override List<Funcionario> SelecionarTodos()
        {
            return Db.GetAll(comandoSelecionarTodos, ConverterEmFuncionario);
        }

        private Dictionary<string, object> ObtemParametrosFuncionario(Funcionario funcionario)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", funcionario.Id);
            parametros.Add("NOME", funcionario.Nome);
            parametros.Add("REGISTROUNICO", funcionario.RegistroUnico);
            parametros.Add("ENDERECO", funcionario.Endereco);
            parametros.Add("TELEFONE", funcionario.Telefone);
            parametros.Add("EMAIL", funcionario.Email);
            parametros.Add("MATRICULAINTERNA", funcionario.MatriculaInterna);
            parametros.Add("USUARIOACESSO", funcionario.UsuarioAcesso);
            parametros.Add("DATAADMISSAO", funcionario.DataAdmissao);
            parametros.Add("CARGO", funcionario.Cargo);
            parametros.Add("SALARIO", float.Parse(Convert.ToString(funcionario.Salario)));
            parametros.Add("EHPESSOAFISICA", Convert.ToBoolean(funcionario.EhPessoaFisica));

            return parametros;
        }

        private Funcionario ConverterEmFuncionario(IDataReader reader)
        {
            int id = Convert.ToInt32(reader["ID"]);
            string nome = Convert.ToString(reader["NOME"]);
            string registroUnico = Convert.ToString(reader["REGISTROUNICO"]);
            string endereco = Convert.ToString(reader["ENDERECO"]);
            string telefone = Convert.ToString(reader["TELEFONE"]);
            string email = Convert.ToString(reader["EMAIL"]);
            int matriculaInterna = Convert.ToInt32(reader["MATRICULAINTERNA"]);
            string usuarioAcesso = Convert.ToString(reader["USUARIOACESSO"]);
            DateTime dataAdmissao = Convert.ToDateTime(reader["DATAADMISSAO"]);
            string cargo = Convert.ToString(reader["CARGO"]);
            double salario = Convert.ToDouble(Convert.ToString(reader["SALARIO"]));
            bool ehPessoaFisica = Convert.ToBoolean(reader["EHPESSOAFISICA"]);

            Funcionario funcionario = new Funcionario(id, nome, registroUnico, endereco, telefone, email, matriculaInterna, usuarioAcesso, dataAdmissao, cargo, salario, ehPessoaFisica);

            funcionario.Id = id;

            return funcionario;
        }
    }
}
