using LocadoraDeVeiculos.Dominio.CupomModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Aplicacao.CupomModule
{
    public class CupomAppService
    {
        private readonly ICupomRepository cupomRepository;

        public CupomAppService(ICupomRepository cupomRepository)
        {
            this.cupomRepository = cupomRepository;
        }

        public string InserirNovoCupom(Cupom cupom){
            string resultadoValidacao = cupom.Validar();

            if (resultadoValidacao == "VALIDO")
                cupomRepository.InserirNovo(cupom);

            return resultadoValidacao;
        }
        public string EditarCupom(int id, Cupom cupom){
            string resultadoValidacao = cupom.Validar();

            if (resultadoValidacao == "VALIDO")
                cupomRepository.Editar(id,cupom);

            return resultadoValidacao;
        }
        public void ExcluirCupom(int id) { cupomRepository.Excluir(id);}
        public bool ExisteCupom(int id) { return cupomRepository.Existe(id);}
        public bool ExisteCodigo(string codigo) { return cupomRepository.ExisteCodigo(codigo);}
        public Cupom SelecionarCupomPorId(int id) { return cupomRepository.SelecionarPorId(id);}
        public Cupom SelecionarPorCodigo(string codigo) { return cupomRepository.SelecionarPorCodigo(codigo);}
        public List<Cupom> SelecionarTodosCupom() { return cupomRepository.SelecionarTodos();}
        public void AtualizarQuantidadeUtilizada(int id,int quantidade) { cupomRepository.AtualizarQtdUtilizada(id, quantidade);}
    }
}
