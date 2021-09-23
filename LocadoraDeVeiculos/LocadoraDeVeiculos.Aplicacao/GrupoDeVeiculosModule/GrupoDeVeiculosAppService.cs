using LocadoraDeVeiculos.Aplicacao.Shared;
using LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule;
using LocadoraDeVeiculos.Dominio.Shared;
using System.Collections.Generic;

namespace LocadoraDeVeiculos.Aplicacao.GrupoDeVeiculosModule
{
    public class GrupoDeVeiculosAppService : AppServiceBase<GrupoDeVeiculo>
    {
        private readonly IRepository<GrupoDeVeiculo> grupoDeVeiculoRepository;

        public GrupoDeVeiculosAppService(IRepository<GrupoDeVeiculo> grupoDeVeiculoRepository)
        {
            this.grupoDeVeiculoRepository = grupoDeVeiculoRepository;
        }

        public override string InserirEntidade(GrupoDeVeiculo grupoDeVeiculos)
        {
            string resultadoValidacao = Vaidacoes(grupoDeVeiculos);

            if (resultadoValidacao == "VALIDO")
            {
                grupoDeVeiculoRepository.InserirNovo(grupoDeVeiculos);

            }

            return resultadoValidacao;
        }
        public override string EditarEntidade(int id, GrupoDeVeiculo grupoDeVeiculos)
        {
            string resultadoValidacao = Vaidacoes(grupoDeVeiculos);


            if (resultadoValidacao == "VALIDO")
                grupoDeVeiculoRepository.Editar(id, grupoDeVeiculos);

            return resultadoValidacao;
        }
        public override bool ExcluirEntidade(int id)
        {
            return grupoDeVeiculoRepository.Excluir(id);
        }
        public override bool ExisteEntidade(int id)
        {
            return grupoDeVeiculoRepository.Existe(id);
        }
        public override GrupoDeVeiculo SelecionarEntidadePorId(int id)
        {
            return grupoDeVeiculoRepository.SelecionarPorId(id);
        }
        public override List<GrupoDeVeiculo> SelecionarTodasEntidade()
        {
            return grupoDeVeiculoRepository.SelecionarTodos();
        }

        #region Métodos privados
        private string VerificarSeNaoPossuiRepetidos(GrupoDeVeiculo grupoVeiculo)
        {

            List<GrupoDeVeiculo> grupoDeVeiculosRegistrados = SelecionarTodasEntidade();
            foreach (GrupoDeVeiculo grupo in grupoDeVeiculosRegistrados)
            {
                if (grupoVeiculo.Nome == grupo.Nome)
                    return "O nome do grupo de veículos deve ser único\n";
            }

            return "VALIDO";
        }

        private string Vaidacoes(GrupoDeVeiculo grupo)
        {
            string resultadoValidacao = grupo.Validar();
            if (resultadoValidacao == "VALIDO")
                resultadoValidacao = VerificarSeNaoPossuiRepetidos(grupo);

            return resultadoValidacao;
        }
        #endregion
    }
}
