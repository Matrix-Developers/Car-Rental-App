using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Dominio.VeiculoModule;
using System.Collections.Generic;

namespace LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule
{
    public class GrupoDeVeiculo : EntidadeBase
    {
        private string nome;
        private double taxaPlanoDiario;
        private double taxaPorKmDiario;
        private double taxaPlanoControlado;
        private int limiteKmControlado;
        private double taxaKmExcedidoControlado;
        private double taxaPlanoLivre;

        public string Nome { get => nome; set => nome = value; }
        public double TaxaPlanoDiario { get => taxaPlanoDiario; set => taxaPlanoDiario = value; }
        public double TaxaPorKmDiario { get => taxaPorKmDiario; set => taxaPorKmDiario = value; }
        public double TaxaPlanoControlado { get => taxaPlanoControlado; set => taxaPlanoControlado = value; }
        public int LimiteKmControlado { get => limiteKmControlado; set => limiteKmControlado = value; }
        public double TaxaKmExcedidoControlado { get => taxaKmExcedidoControlado; set => taxaKmExcedidoControlado = value; }
        public double TaxaPlanoLivre { get => taxaPlanoLivre; set => taxaPlanoLivre = value; }
        public List<Veiculo> Veiculos { get; set; }

        public GrupoDeVeiculo(int id, string nome, double taxaPlanoDiario, double taxaPorKmDiario, double taxaPlanoControlado, int limiteKmControlado, double taxaKmExcedidoControlado, double taxaPlanoLivre)
        {
            this.id = id;
            this.nome = nome;
            this.taxaPlanoDiario = taxaPlanoDiario;
            this.taxaPorKmDiario = taxaPorKmDiario;
            this.taxaPlanoControlado = taxaPlanoControlado;
            this.limiteKmControlado = limiteKmControlado;
            this.taxaKmExcedidoControlado = taxaKmExcedidoControlado;
            this.taxaPlanoLivre = taxaPlanoLivre;
        }
        public GrupoDeVeiculo()
        {
        }

        public override string Validar()
        {
            string resultadoValidacao = "";

            if (this.nome.Length <= 0)
                resultadoValidacao = "The name field cannot be null.\n";

            if (this.taxaPlanoDiario <= 0f)
                resultadoValidacao += "The daily rate for the Daily Plan cannot be zero.\n";

            if (this.taxaPorKmDiario <= 0f)
                resultadoValidacao += "The rate per KM of the Daily Plan cannot be zero.\n";

            if (this.taxaPlanoControlado <= 0f)
                resultadoValidacao += "The daily rate of the Controlled Plan cannot be zero.\n";

            if (this.limiteKmControlado <= 0)
                resultadoValidacao += "The KM limit of the Controlled plan cannot be zero.\n";

            if (this.taxaKmExcedidoControlado <= 0f)
                resultadoValidacao += "The Controlled plan's Exceeded KM rate cannot be zero.\n";

            if (this.taxaPlanoLivre <= 0f)
                resultadoValidacao += "The daily fee for the Free Plan cannot be zero.\n";

            if (resultadoValidacao.Length == 0)
                resultadoValidacao = "VALID";

            return resultadoValidacao;
        }

        public override bool Equals(object obj)
        {
            return obj is GrupoDeVeiculo grupoDeVeiculo &&
                   id == grupoDeVeiculo.id &&
                   nome == grupoDeVeiculo.nome &&
                   taxaPlanoDiario == grupoDeVeiculo.taxaPlanoDiario &&
                   taxaPorKmDiario == grupoDeVeiculo.taxaPorKmDiario &&
                   taxaPlanoControlado == grupoDeVeiculo.taxaPlanoControlado &&
                   limiteKmControlado == grupoDeVeiculo.limiteKmControlado &&
                   taxaKmExcedidoControlado == grupoDeVeiculo.taxaKmExcedidoControlado &&
                   taxaPlanoLivre == grupoDeVeiculo.taxaPlanoLivre;
        }

        public override int GetHashCode()
        {
            int hashCode = -1513818721;
            hashCode = hashCode * -1521134295 + id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nome);
            hashCode = hashCode * -1521134295 + taxaPlanoDiario.GetHashCode();
            hashCode = hashCode * -1521134295 + taxaPorKmDiario.GetHashCode();
            hashCode = hashCode * -1521134295 + taxaPlanoControlado.GetHashCode();
            hashCode = hashCode * -1521134295 + limiteKmControlado.GetHashCode();
            hashCode = hashCode * -1521134295 + taxaKmExcedidoControlado.GetHashCode();
            hashCode = hashCode * -1521134295 + taxaPlanoLivre.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return $"{nome}";
        }
    }
}
