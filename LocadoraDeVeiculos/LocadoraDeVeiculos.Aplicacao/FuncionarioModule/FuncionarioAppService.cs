using LocadoraDeVeiculos.Aplicacao.Shared;
using LocadoraDeVeiculos.Dominio.FuncionarioModule;
using LocadoraDeVeiculos.Dominio.Shared;
using System.Collections.Generic;

namespace LocadoraDeVeiculos.Aplicacao.FuncionarioModule
{
    public class FuncionarioAppService : AppServiceBase<Funcionario>
    {
        private readonly IRepository<Funcionario> funcionarioRepository;

        public FuncionarioAppService(IRepository<Funcionario> funcionarioRepository)
        {
            this.funcionarioRepository = funcionarioRepository;
        }

        public override string InserirEntidade(Funcionario funcionario)
        {
            string resultadoValidacao = funcionario.Validar();
            if (resultadoValidacao == "VALIDO")
                funcionarioRepository.InserirNovo(funcionario);
            return resultadoValidacao;
        }
        public override string EditarEntidade(int id, Funcionario funcionario)
        {
            string resultadoValidacao = funcionario.Validar();
            if (resultadoValidacao == "VALIDO")
                funcionarioRepository.Editar(id, funcionario);
            return resultadoValidacao;
        }
        public override bool ExcluirEntidade(int id)
        {
            return funcionarioRepository.Excluir(id);
        }
        public override bool ExisteEntidade(int id)
        {
            return funcionarioRepository.Existe(id);
        }
        public override Funcionario SelecionarEntidadePorId(int id)
        {
            return funcionarioRepository.SelecionarPorId(id);
        }
        public override List<Funcionario> SelecionarTodasEntidade()
        {
            return funcionarioRepository.SelecionarTodos();
        }
    }
}
