using LocadoraDeVeiculos.Aplicacao.Shared;
using LocadoraDeVeiculos.Dominio.SevicosModule;
using LocadoraDeVeiculos.Dominio.Shared;
using System.Collections.Generic;

namespace LocadoraDeVeiculos.Aplicacao.ServicoModule
{
    public class ServicoAppService : AppServiceBase<Servico>
    {
        private readonly IRepository<Servico> servicoRepository;

        public ServicoAppService(IRepository<Servico> servicoRepository)
        {
            this.servicoRepository = servicoRepository;
        }

        public override bool InserirEntidade(Servico servico)
        {
            bool resultadoValidacao = servicoRepository.InserirNovo(servico);

            return resultadoValidacao;
        }
        public override bool EditarEntidade(int id, Servico servico)
        {
            bool resultadoValidacao = servicoRepository.Editar(id, servico);

            return resultadoValidacao;
        }
        public override bool ExcluirEntidade(int id)
        {
            return servicoRepository.Excluir(id);
        }
        public override bool ExisteEntidade(int id)
        {
            return servicoRepository.Existe(id);
        }
        public override Servico SelecionarEntidadePorId(int id)
        {
            return servicoRepository.SelecionarPorId(id);
        }
        public override List<Servico> SelecionarTodasEntidade()
        {
            return servicoRepository.SelecionarTodos();
        }
    }
}
