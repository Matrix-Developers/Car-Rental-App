using LocadoraDeVeiculos.Dominio.LocacaoModule;
using LocadoraDeVeiculos.Dominio.Shared;
using System.Collections.Generic;

namespace LocadoraDeVeiculos.Aplicacao.LocacaoModule
{
    public class LocacaoAppService
    {
        private readonly IRepository<Locacao> locacaoRepository;

        public LocacaoAppService(IRepository<Locacao> locacaoRepository)
        {
            this.locacaoRepository = locacaoRepository;
        }

        public string InserirNovaLocacao(Locacao locacao)
        {
            string resultadoValidacao = locacao.Validar();

            if (resultadoValidacao == "VALIDO")
                locacaoRepository.InserirNovo(locacao);

            return resultadoValidacao;
        }
        public string EditarLocacao(int id, Locacao locacao)
        {
            string resultadoValidacao = locacao.Validar();

            if (resultadoValidacao == "VALIDO")
                locacaoRepository.Editar(id, locacao);

            return resultadoValidacao;
        }
        public bool ExcluirLocacao(int id)
        {
            return locacaoRepository.Excluir(id);
        }
        public Locacao SelecionarLocacaoPorId(int id)
        {
            return locacaoRepository.SelecionarPorId(id);
        }
        public List<Locacao> SelecionarTodosLocacao()
        {
            return locacaoRepository.SelecionarTodos();
        }
        public bool ExisteLocacao(int id)
        {
            return locacaoRepository.Existe(id);
        }
    }
}
