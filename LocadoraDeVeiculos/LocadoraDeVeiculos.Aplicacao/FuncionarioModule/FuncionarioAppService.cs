using LocadoraDeVeiculos.Dominio.FuncionarioModule;
using LocadoraDeVeiculos.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Aplicacao.FuncionarioModule
{
    public class FuncionarioAppService
    {
        private readonly IRepository<Funcionario> funcionarioRepository;
    public FuncionarioAppService(IRepository<Funcionario> funcionarioRepository)
        {
            this.funcionarioRepository = funcionarioRepository;
        }

        public string InserirNovoFuncionario(Funcionario funcionario){
            string resultadoValidacao = funcionario.Validar();
            if (resultadoValidacao == "VALIDO")
                funcionarioRepository.InserirNovo(funcionario);
            return resultadoValidacao;
        }
        public string EditarFuncionario(int id, Funcionario funcionario){
            string resultadoValidacao = funcionario.Validar();
            if (resultadoValidacao == "VALIDO")
                funcionarioRepository.Editar(id,funcionario);
            return resultadoValidacao;
        }
        public void ExcluirFuncionario(int id) { funcionarioRepository.Excluir(id);}
        public void ExisteFuncionario(int id) { funcionarioRepository.Existe(id);}
        public Funcionario SelecionarFuncionarioPorId(int id) { return funcionarioRepository.SelecionarPorId(id);}
        public List<Funcionario> SelecionarTodos() { return funcionarioRepository.SelecionarTodos();}
    }
}
