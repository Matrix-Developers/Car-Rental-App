using LocadoraDeVeiculos.Dominio.Shared;
using System.Collections.Generic;

namespace LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule
{
    public class GrupoDeVeiculos : EntidadeBase
    {
        private string nome;
        private float taxaPlanoDiario;
        private float taxaKmControlado;
        private int quantidadeQuilometrosKmControlado;
        private float taxaKmLivre;

        public string Nome { get => nome; set => nome = value; }
        public float TaxaPlanoDiario { get => taxaPlanoDiario; set => taxaPlanoDiario = value; }
        public float TaxaKmControlado { get => taxaKmControlado; set => taxaKmControlado = value; }
        public int QuantidadeQuilometrosKmControlado { get => quantidadeQuilometrosKmControlado; set => quantidadeQuilometrosKmControlado = value; }
        public float TaxaKmLivre { get => taxaKmLivre; set => taxaKmLivre = value; }

        public GrupoDeVeiculos(int id,string nome, float taxaPlanoDiario, float taxaKmControlado, int quantidadeQuilometrosKmControlado, float taxaKmLivre)
        {
            this.id = id;
            this.nome = nome;
            this.taxaPlanoDiario = taxaPlanoDiario;
            this.taxaKmControlado = taxaKmControlado;
            this.quantidadeQuilometrosKmControlado = quantidadeQuilometrosKmControlado;
            this.taxaKmLivre = taxaKmLivre;
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
            return obj is GrupoDeVeiculos veiculos &&
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
            return $"GrupoDeVaiculos = [{id}, {nome}, {taxaPlanoDiario}, {taxaKmControlado}, {quantidadeQuilometrosKmControlado}, {taxaKmLivre}]";
        }
    }
}
