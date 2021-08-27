using LocadoraDeVeiculos.Dominio.Shared;
using System.Collections.Generic;

namespace LocadoraDeVeiculos.Dominio.SevicosModule
{
    public class Servico : EntidadeBase
    {    
        public Servico(int id, string nome, bool EhTaxadoDiario, double valor)
        {
            this.id = id;
            this.Nome = nome;
            this.EhTaxadoDiario = EhTaxadoDiario;
            this.Valor = valor;
        }
        public string Nome { get; }
        public bool EhTaxadoDiario { get; }
        public double Valor { get; }

        public override string Validar()
        {
            string resultadoValidacao = "";
            if (this.Nome.Length == 0)
                resultadoValidacao = "O nome não pode ser nulo\n";
            if (this.Valor <= 0)
                resultadoValidacao += "O valor não pode ser nulo";
            if (resultadoValidacao.Length == 0)
                resultadoValidacao = "VALIDO";
            return resultadoValidacao;
        }

        public override bool Equals(object obj)
        {
            return obj is Servico servico &&
                   id == servico.id &&
                   Nome == servico.Nome &&
                   EhTaxadoDiario == servico.EhTaxadoDiario &&
                   Valor == servico.Valor;
        }

        public override int GetHashCode()
        {
            int hashCode = 1764119922;
            hashCode = hashCode * -1521134295 + id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nome);
            hashCode = hashCode * -1521134295 + EhTaxadoDiario.GetHashCode();
            hashCode = hashCode * -1521134295 + Valor.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return $"Servico = [{id}, {Nome}, {EhTaxadoDiario}, {Valor}]";
        }
    }
}
