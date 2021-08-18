using LocadoraDeVeiculos.Dominio.Shared;
using System.Collections.Generic;

namespace LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule
{
    public class GrupoDeVeiculo : EntidadeBase
    {
        private string nome;
        private double taxaPlanoDiario;
        private double taxaKmControlado;
        private int quantidadeQuilometrosKmControlado;
        private double taxaKmLivre;

        public string Nome { get => nome; set => nome = value; }
        public double TaxaPlanoDiario { get => taxaPlanoDiario; set => taxaPlanoDiario = value; }
        public double TaxaKmControlado { get => taxaKmControlado; set => taxaKmControlado = value; }
        public int QuantidadeQuilometrosKmControlado { get => quantidadeQuilometrosKmControlado; set => quantidadeQuilometrosKmControlado = value; }
        public double TaxaKmLivre { get => taxaKmLivre; set => taxaKmLivre = value; }

        public GrupoDeVeiculo(int id,string nome, double taxaPlanoDiario, double taxaKmControlado, double taxaKmLivre, int quantidadeQuilometrosKmControlado)
        {
            this.id = id;
            this.nome = nome;
            this.taxaPlanoDiario = taxaPlanoDiario;
            this.taxaKmControlado = taxaKmControlado;
            this.taxaKmLivre = taxaKmLivre;
            this.quantidadeQuilometrosKmControlado = quantidadeQuilometrosKmControlado;
        }

        public override string Validar()
        {
            string resultadoValidacao = "";

            if (this.nome.Length <= 0)
                resultadoValidacao  = "O nome não pode ser nulo\n";

            if (this.taxaKmControlado <= 0f)
                resultadoValidacao += "A taxa do Quilometro Controlado não pode ser nula nem negativa\n";

            if (this.taxaPlanoDiario <=0f)
                resultadoValidacao += "A taxa do Plano Diário não pode ser nula nem negativa\n";

            if (this.taxaKmLivre <= 0f)
                resultadoValidacao += "A taxa do Quilometro Livre não pode ser nula nem negativa\n";

            if (this.quantidadeQuilometrosKmControlado <= 0)
                resultadoValidacao += "A quantidade de quilômetros não pode ser nulo nem negativo";

            if (resultadoValidacao.Length == 0)
                resultadoValidacao = "VALIDO";

            return resultadoValidacao;
        }

        public override bool Equals(object obj)
        {
            return obj is GrupoDeVeiculo veiculos &&
                   id == veiculos.id &&
                   nome == veiculos.nome &&
                   taxaPlanoDiario == veiculos.taxaPlanoDiario &&
                   taxaKmControlado == veiculos.taxaKmControlado &&
                   quantidadeQuilometrosKmControlado == veiculos.quantidadeQuilometrosKmControlado &&
                   taxaKmLivre == veiculos.taxaKmLivre;
        }

        public override int GetHashCode()
        {
            int hashCode = 1038375158;
            hashCode = hashCode * -1521134295 + id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nome);
            hashCode = hashCode * -1521134295 + taxaPlanoDiario.GetHashCode();
            hashCode = hashCode * -1521134295 + taxaKmControlado.GetHashCode();
            hashCode = hashCode * -1521134295 + quantidadeQuilometrosKmControlado.GetHashCode();
            hashCode = hashCode * -1521134295 + taxaKmLivre.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return nome;
        }
    }
}
