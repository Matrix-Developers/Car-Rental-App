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
        const string comandoInserir = @"insert into TBFUNCIONARIO
										(
											[Nome],
											[RegistroUnico],
											[Endereco],
											[Telefone],
											[Email],
											[EhPessoaFisica],
											[MatriculaInterna],
											[UsuarioAcesso],
											[Cargo],
											[Salario],
                                            [dataAdmissao]
										)
										values
										(
											@Nome,
											@RegistroUnico,
											@Endereco,
											@Telefone,
											@Email,
											@EhPessoaFisica,
											@MatriculaInterna,
											@UsuarioAcesso,
											@Cargo,
											@Salario,
                                            @dataAdmissao
										);";
		const string comandoEditar = @"update TBFUNCIONARIO 
									    set
									    	[Nome] = @Nome,
									    	[RegistroUnico] = @RegistroUnico,
									    	[Endereco] = @Endereco,
									    	[Telefone] = @Telefone,
									    	[Email] = @Email,
									    	[EhPessoaFisica] = @EhPessoaFisica,
									    	[MatriculaInterna] = @MatriculaInterna,
									    	[UsuarioAcesso] = @UsuarioAcesso,
									    	[Cargo] = @Cargo,
									    	[Salario] = @Salario,
                                            [dataAdmissao] = @dataAdmissao
									    where [id] = @id;";
		const string comandoExcluir = @"delete from TBFUNCIONARIO where [id] = @id;";
		const string comandoSelecionarTodos = "select * from TBFUNCIONARIO;";
		const string comandoSelecionarPorId = "select * from TBFUNCIONARIO where [id] = @id;";
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
                Db.Delete(comandoExcluir, AdicionarParametro("Id", id));
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public override bool Existe(int id)
        {
            return Db.Exists(comandoSelecionarPorId, AdicionarParametro("Id", id));
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
            return Db.Get(comandoSelecionarPorId,ConverterEmFuncionario, AdicionarParametro("Id",id));
        }

        public override List<Funcionario> SelecionarTodos()
        {
            return Db.GetAll(comandoSelecionarTodos, ConverterEmFuncionario);
        }

        private Dictionary<string, object> ObtemParametrosFuncionario(Funcionario funcionario)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", funcionario.Id);
            parametros.Add("Nome", funcionario.Nome);
            parametros.Add("RegistroUnico", funcionario.RegistroUnico);
            parametros.Add("Endereco", funcionario.Endereco);
            parametros.Add("Telefone", funcionario.Telefone);
            parametros.Add("Email", funcionario.Email);
            parametros.Add("MatriculaInterna",funcionario.Matricula);
            parametros.Add("UsuarioAcesso",funcionario.UsuarioAcesso);
            parametros.Add("DataAdmissao",funcionario.DataAdmissao);
            parametros.Add("Cargo",funcionario.Cargo);
            parametros.Add("Salario",float.Parse(Convert.ToString(funcionario.Salario)));

            return parametros;
        }

        private Funcionario ConverterEmFuncionario(IDataReader reader)
        {
            int id = Convert.ToInt32(reader["Id"]);
            string nome = Convert.ToString(reader["Nome"]);
            string registroUnico = Convert.ToString(reader["RegistroUnico"]);
            string endereco = Convert.ToString(reader["Endereco"]);
            string telefone = Convert.ToString(reader["Telefone"]);
            string email = Convert.ToString(reader["Email"]);
            int matricula = Convert.ToInt32(reader["MatriculaInterna"]);
            string usuarioAcesso = Convert.ToString(reader["UsuarioAcesso"]);
            DateTime dataAdmissao = Convert.ToDateTime(reader["DataAdmissao"]);
            string cargo = Convert.ToString(reader["Cargo"]);
            double salario = Convert.ToDouble(Convert.ToString(reader["Salario"]));

            Funcionario funcionario = new Funcionario(id,nome, registroUnico, endereco, telefone, email,matricula, usuarioAcesso,dataAdmissao,cargo,salario);

            funcionario.Id = id;

            return funcionario;
        }
    }
}
