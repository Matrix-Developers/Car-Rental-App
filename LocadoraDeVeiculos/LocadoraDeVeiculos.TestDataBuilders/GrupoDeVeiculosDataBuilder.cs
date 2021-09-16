using LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule;

namespace LocadoraDeVeiculos.TestDataBuilders
{
    public class GrupoDeVeiculosDataBuilder
    {
        private GrupoDeVeiculo grupoDeVeiculo;

        public GrupoDeVeiculosDataBuilder()
        {
            grupoDeVeiculo = new GrupoDeVeiculo();
        }

        public GrupoDeVeiculosDataBuilder ComNome(string nome)
        {
            grupoDeVeiculo.Nome = nome;
            return this;
        }
        public GrupoDeVeiculosDataBuilder ComTaxaPlanoDiario(double taxaPlanoDiario)
        {
            grupoDeVeiculo.TaxaPlanoDiario = taxaPlanoDiario;
            return this;
        }
        public GrupoDeVeiculosDataBuilder ComTaxaPorKmDiario(double taxaPorKmDiario)
        {
            grupoDeVeiculo.TaxaPorKmDiario = taxaPorKmDiario;
            return this;
        }
        public GrupoDeVeiculosDataBuilder ComTaxaPlanoControlado(double taxaPlanoConrolado)
        {
            grupoDeVeiculo.TaxaPlanoControlado = taxaPlanoConrolado;
            return this;
        }
        public GrupoDeVeiculosDataBuilder ComLimiteKmControlado(int limiteKmControlado)
        {
            grupoDeVeiculo.LimiteKmControlado = limiteKmControlado;
            return this;
        }
        public GrupoDeVeiculosDataBuilder ComTaxaKmExcedidoControlado(double taxaKmExcedidoControlado)
        {
            grupoDeVeiculo.TaxaKmExcedidoControlado = taxaKmExcedidoControlado;
            return this;
        }
        public GrupoDeVeiculosDataBuilder ComTaxaPlanoLivre(double taxaPlanoLivre)
        {
            grupoDeVeiculo.TaxaPlanoLivre = taxaPlanoLivre;
            return this;
        }
    }
}