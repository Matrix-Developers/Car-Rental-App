using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocadoraDeVeiculos.Controladores.Shared;
using LocadoraDeVeiculos.Dominio.FuncionarioModule;
using LocadoraDeVeiculos.Dominio.PessoaModule;

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
											[Salario]
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
											@Salario
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
									    	[Salario] = @Salario	
									    where [id] = @id;";
		const string comandoExcluir = @"delete from TBFUNCIONARIO where [id] = @id;";
		const string comandoSelecionarTodos = "select * from TBFUNCIONARIO;";
		const string comandoSelecionarPorId = "select * from TBFUNCIONARIO where [id] = @id;";
        #endregion

        public override string Editar(int id, Funcionario registro)
        {
            throw new NotImplementedException();
        }

        public override bool Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public override bool Existe(int id)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public override List<Funcionario> SelecionarTodos()
        {
            throw new NotImplementedException();
        }


        private Dictionary<string, object> ObtemParametrosFuncionario(Funcionario funcionario)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", funcionario.Id);
            parametros.Add("NOME", funcionario.Nome);
            parametros.Add("EMAIL", funcionario.Email);
            parametros.Add("TELEFONE", funcionario.Telefone);
            parametros.Add("CARGO", funcionario.Cargo);
            parametros.Add("EMPRESA", funcionario.Empresa);

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

            Funcionario funcionario = new Funcionario(id,nome, registroUnico, endereco, telefone, email,matricula, usuarioAcesso,dataAdmissao,cargo,salario);

            funcionario.Id = id;

            return funcionario;
        }
    }
}
