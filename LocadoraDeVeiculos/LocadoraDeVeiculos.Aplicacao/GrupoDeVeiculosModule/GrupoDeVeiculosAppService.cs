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
            string resultadoValidacao = Vaidacoes(grupoDeVeiculos);

            if (resultadoValidacao == "VALIDO")
                grupoDeVeiculoRepository.InserirNovo(grupoDeVeiculos);

            return resultadoValidacao;
        }
        public string EditarGrupoDeVeiculo(int id,GrupoDeVeiculo grupoDeVeiculos)
        {
            string resultadoValidacao = Vaidacoes(grupoDeVeiculos);


            if (resultadoValidacao == "VALIDO")
                grupoDeVeiculoRepository.Editar(id,grupoDeVeiculos);

            return resultadoValidacao;
        }
        public void ExcluirGrupoDeVeiculo(int id) { grupoDeVeiculoRepository.Excluir(id);}
        public bool ExisteGrupoDeVeiculo(int id) { return grupoDeVeiculoRepository.Existe(id);}
        public GrupoDeVeiculo SelecionarGrupoDeVeiculoPorId(int id) { return grupoDeVeiculoRepository.SelecionarPorId(id);}
        public List<GrupoDeVeiculo> SelecionarTodosGrupoDeVeiculo() { return grupoDeVeiculoRepository.SelecionarTodos();}

        #region Métodos privados
        private string VerificarSeNaoPossuiRepetidos(GrupoDeVeiculo grupoVeiculo)
        {

            List<GrupoDeVeiculo> grupoDeVeiculosRegistrados = SelecionarTodosGrupoDeVeiculo();
            foreach (GrupoDeVeiculo grupo in grupoDeVeiculosRegistrados)
            {
                if (grupoVeiculo.Nome == grupo.Nome)
                    return "O nome do grupo de veículos deve ser único\n";
            }

            return null;
        }

        private string Vaidacoes(GrupoDeVeiculo grupo)
        {
            string resultadoValidacao = grupo.Validar();
            resultadoValidacao += VerificarSeNaoPossuiRepetidos(grupo);

            return resultadoValidacao;
        }
        #endregion
    }
}
