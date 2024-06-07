using LocadoraDeVeiculos.Dominio.CupomModule;
using LocadoraDeVeiculos.Dominio.Shared;
using System.Collections.Generic;

namespace LocadoraDeVeiculos.Dominio.ParceiroModule
{
    public class Parceiro : EntidadeBase
    {
        public string Nome { get; set; }
        public List<Cupom> Cupons { get; set; }

        public Parceiro(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
        public Parceiro()
        {
        }

        public override string Validar()
        {
            string resultadoValidacao = "";

            if (string.IsNullOrEmpty(Nome))
                resultadoValidacao += "The name field cannot be null.";
            if (resultadoValidacao == "")
                resultadoValidacao = "VALID";

            return resultadoValidacao;
        }

        public override bool Equals(object obj)
        {
            return obj is Parceiro parceiro &&
                   Id == parceiro.Id &&
                   Nome == parceiro.Nome;
        }

        public override int GetHashCode()
        {
            int hashCode = -1643562096;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nome);
            return hashCode;
        }

        public override string ToString()
        {
            return $"{Nome}";
        }
    }
}
