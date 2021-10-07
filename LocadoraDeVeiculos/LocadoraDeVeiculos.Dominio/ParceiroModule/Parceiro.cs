using LocadoraDeVeiculos.Dominio.Shared;
using System.Collections.Generic;

namespace LocadoraDeVeiculos.Dominio.ParceiroModule
{
    public class Parceiro : EntidadeBase<int>
    {
        public string Nome { get; set; }

        public Parceiro(int id, string nome)
        {
            this.id = id;
            Nome = nome;
        }
        public Parceiro()
        {
        }

        public override string Validar()
        {
            string resultadoValidacao = "";

            if (string.IsNullOrEmpty(Nome))
                resultadoValidacao += "O campo nome é obrigatório";
            if (resultadoValidacao == "")
                resultadoValidacao = "VALIDO";

            return resultadoValidacao;
        }

        public override bool Equals(object obj)
        {
            return obj is Parceiro parceiro &&
                   id == parceiro.id &&
                   Nome == parceiro.Nome;
        }

        public override int GetHashCode()
        {
            int hashCode = -1643562096;
            hashCode = hashCode * -1521134295 + id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nome);
            return hashCode;
        }

        public override string ToString()
        {
            return $" {id}, {Nome}";
        }
    }
}
