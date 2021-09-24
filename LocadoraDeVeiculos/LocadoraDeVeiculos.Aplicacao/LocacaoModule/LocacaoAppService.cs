using LocadoraDeVeiculos.Aplicacao.Shared;
using LocadoraDeVeiculos.Dominio.LocacaoModule;
using LocadoraDeVeiculos.Dominio.Shared;
using System.Collections.Generic;

namespace LocadoraDeVeiculos.Aplicacao.LocacaoModule
{
    public class LocacaoAppService : AppServiceBase<Locacao>
    {
        private readonly IRepository<Locacao> locacaoRepository;

        public LocacaoAppService(IRepository<Locacao> locacaoRepository)
        {
            this.locacaoRepository = locacaoRepository;
        }

        public override bool InserirEntidade(Locacao locacao)
        {
            bool resultadoValidacao = locacaoRepository.InserirNovo(locacao);

            return resultadoValidacao;
        }
        public override bool EditarEntidade(int id, Locacao locacao)
        {
            bool resultadoValidacao = locacaoRepository.Editar(id, locacao);

            return resultadoValidacao;
        }
        public override bool ExcluirEntidade(int id)
        {
            return locacaoRepository.Excluir(id);
        }
        public override Locacao SelecionarEntidadePorId(int id)
        {
            return locacaoRepository.SelecionarPorId(id);
        }
        public override List<Locacao> SelecionarTodasEntidade()
        {
            return locacaoRepository.SelecionarTodos();
        }
        public override bool ExisteEntidade(int id)
        {
            return locacaoRepository.Existe(id);
        }
    }
}
