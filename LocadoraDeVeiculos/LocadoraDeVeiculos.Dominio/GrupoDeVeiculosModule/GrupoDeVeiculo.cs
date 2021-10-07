using LocadoraDeVeiculos.Dominio.Shared;
using System.Collections.Generic;

namespace LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule
{
    public class GrupoDeVeiculo : EntidadeBase<int>
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
                resultadoValidacao = "O nome não pode ser nulo\n";

            if (this.taxaPlanoDiario <= 0f)
                resultadoValidacao += "A taxa diaria do Plano Diário não pode ser nula\n";

            if (this.taxaPorKmDiario <= 0f)
                resultadoValidacao += "A taxa por KM do Plano Diário não pode ser nula\n";

            if (this.taxaPlanoControlado <= 0f)
                resultadoValidacao += "A taxa diária do Plano Controlado não pode ser nula\n";

            if (this.limiteKmControlado <= 0)
                resultadoValidacao += "O limite de KM do plano Controlado não pode ser nulo\n";

            if (this.taxaKmExcedidoControlado <= 0f)
                resultadoValidacao += "A taxa de KM Excedido do plano Controlado não pode ser nulo\n";

            if (this.taxaPlanoLivre <= 0f)
                resultadoValidacao += "A taxa diária do do Plano Livre não pode ser nula\n";

            if (resultadoValidacao.Length == 0)
                resultadoValidacao = "VALIDO";

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
            return $"{id} {nome}";
        }
    }
}
