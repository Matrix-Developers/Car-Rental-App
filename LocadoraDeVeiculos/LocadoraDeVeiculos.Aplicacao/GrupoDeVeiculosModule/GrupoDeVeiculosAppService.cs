using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Aplicacao.GrupoDeVeiculosModule
{
    public class GrupoDeVeiculosAppService
    {
        private readonly IRepository<GrupoDeVeiculo> grupoDeVeiculoRepository;

        public GrupoDeVeiculosAppService(IRepository<GrupoDeVeiculo> grupoDeVeiculoRepository)
        {
            this.grupoDeVeiculoRepository = grupoDeVeiculoRepository;
        }

        public string InserirNovoGrupoDeVeiculo(GrupoDeVeiculo grupoDeVeiculos){
            string resultadoValidacao = grupoDeVeiculos.Validar();

            if (resultadoValidacao == "VALIDO")
                grupoDeVeiculoRepository.InserirNovo(grupoDeVeiculos);

            return resultadoValidacao;
        }
        public string EditarGrupoDeVeiculo(int id,GrupoDeVeiculo grupoDeVeiculos)
        {
            string resultadoValidacao = grupoDeVeiculos.Validar();

            if (resultadoValidacao == "VALIDO")
                grupoDeVeiculoRepository.Editar(id,grupoDeVeiculos);

            return resultadoValidacao;
        }
        public void ExcluirGrupoDeVeiculo(int id) { grupoDeVeiculoRepository.Excluir(id);}
        public bool ExisteGrupoDeVeiculo(int id) { return grupoDeVeiculoRepository.Existe(id);}
        public GrupoDeVeiculo SelecionarGrupoDeVeiculoPorId(int id) { return grupoDeVeiculoRepository.SelecionarPorId(id);}
        public List<GrupoDeVeiculo> SelecionarTodosGrupoDeVeiculo() { return grupoDeVeiculoRepository.SelecionarTodos();}
        
    }
}
