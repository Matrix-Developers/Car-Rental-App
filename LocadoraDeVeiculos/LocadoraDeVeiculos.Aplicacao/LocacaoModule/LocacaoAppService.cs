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

        public override string InserirEntidade(Locacao locacao)
        {
            string resultadoValidacao = locacao.Validar();

            if (resultadoValidacao == "VALIDO")
                locacaoRepository.InserirNovo(locacao);

            return resultadoValidacao;
        }
        public override string EditarEntidade(int id, Locacao locacao)
        {
            string resultadoValidacao = locacao.Validar();

            if (resultadoValidacao == "VALIDO")
                locacaoRepository.Editar(id, locacao);

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
