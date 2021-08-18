using LocadoraDeVeiculos.Dominio.Shared;
using System.Collections.Generic;

namespace LocadoraDeVeiculos.Dominio.SevicosModule
{
    public class Servico : EntidadeBase
    {    
        public Servico(int id, string nome, string tipo, double valor)
        {
            this.id = id;
            this.Nome = nome;
            this.Tipo = tipo;
            this.Valor = valor;
        }
        public string Nome { get; }
        public string Tipo { get; }
        public double Valor { get; }

        public override string Validar()
        {
            string resultadoValidacao = "";
            if (this.Nome.Length == 0)
                resultadoValidacao = "O nome não pode ser nulo\n";
            if (this.Valor <= 0)
                resultadoValidacao += "O valor não pode ser nulo ou negativo";
            if (resultadoValidacao.Length == 0)
                resultadoValidacao = "VALIDO";
            return resultadoValidacao;
        }

        public override bool Equals(object obj)
        {
            return obj is Servico servico &&
                   id == servico.id &&
                   Id == servico.Id &&
                   Nome == servico.Nome &&
                   Tipo == servico.Tipo &&
                   Valor == servico.Valor;
        }

        public override int GetHashCode()
        {
            int hashCode = 1587577256;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nome);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Tipo);
            hashCode = hashCode * -1521134295 + Valor.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return $"Serviço = [{id}, {Nome}, {Tipo}, {Valor}]";
        }
    }
}
