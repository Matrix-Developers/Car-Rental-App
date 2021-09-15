using LocadoraDeVeiculos.Dominio.ParceiroModule;
using LocadoraDeVeiculos.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Aplicacao.ParceiroModule
{
    public class ParceiroAppService
    {
        private readonly IRepository<Parceiro> parceiroRepository;

        public string InserirNovoParceiro(Parceiro parceiro){
            string ResultadoValidacao = parceiro.Validar();

            if (ResultadoValidacao == "VALIDO")
                parceiroRepository.InserirNovo(parceiro);

            return ResultadoValidacao;
        }
        public string EditarParceiro(int id, Parceiro parceiro)
        {
            string ResultadoValidacao = parceiro.Validar();

            if (ResultadoValidacao == "VALIDO")
                parceiroRepository.Editar(id,parceiro);

            return ResultadoValidacao;
        }
        public void ExcluirParceiro(int id) { parceiroRepository.Excluir(id); }
        public bool ExisteParceiro(int id) { return parceiroRepository.Existe(id);}
        public Parceiro SelecionarParceiroPorId(int id) { return parceiroRepository.SelecionarPorId(id);}
        public List<Parceiro> SelecionarTodosParceiro() { return parceiroRepository.SelecionarTodos();}
    }
}
