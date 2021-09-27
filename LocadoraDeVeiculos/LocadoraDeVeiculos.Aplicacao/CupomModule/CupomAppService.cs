using LocadoraDeVeiculos.Aplicacao.Shared;
using LocadoraDeVeiculos.Dominio.CupomModule;
using System.Collections.Generic;

namespace LocadoraDeVeiculos.Aplicacao.CupomModule
{
    public class CupomAppService : AppServiceBase<Cupom>
    {
        private readonly ICupomRepository cupomRepository;

        public CupomAppService(ICupomRepository cupomRepository)
        {
            this.cupomRepository = cupomRepository;
        }

        public override bool InserirEntidade(Cupom cupom)
        {
            bool resultado= cupomRepository.InserirNovo(cupom);

            return resultado;
        }
        public override bool EditarEntidade(int id, Cupom cupom)
        {
            bool resultado = cupomRepository.Editar(id, cupom);

            return resultado;
        }
        public override bool ExcluirEntidade(int id)
        {
            return cupomRepository.Excluir(id);
        }
        public override bool ExisteEntidade(int id)
        {
            return cupomRepository.Existe(id);
        }
        public override Cupom SelecionarEntidadePorId(int id)
        {
            return cupomRepository.SelecionarPorId(id);
        }
        public override List<Cupom> SelecionarTodasEntidade()
        {
            return cupomRepository.SelecionarTodos();
        }


        public bool ExisteCodigo(string codigo)
        {
            return cupomRepository.ExisteCodigo(codigo);
        }

        public Cupom SelecionarPorCodigo(string codigo)
        {
            return cupomRepository.SelecionarPorCodigo(codigo);
        }

        public void AtualizarQuantidadeUtilizada(int id, int quantidade)
        {
            cupomRepository.AtualizarQtdUtilizada(id, quantidade);
        }
    }
}
