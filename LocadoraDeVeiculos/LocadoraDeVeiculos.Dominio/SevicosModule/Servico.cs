using LocadoraDeVeiculos.Dominio.Shared;
using System.Collections.Generic;

namespace LocadoraDeVeiculos.Dominio.SevicosModule
{
    public class Servico : EntidadeBase
    {
        private string nome;
        private string tipo;
        private float valor;

        public Servico(int id, string nome, string tipo, float valor)
        {
            this.id = id;
            this.nome = nome;
            this.tipo = tipo;
            this.valor = valor;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public float Valor { get => valor; set => valor = value; }

        public override string Validar() 
        {
            string resultadoValidacao = "VALIDO";
            if (this.nome.Length <= 0)
                resultadoValidacao = "O nome não pode ser nulo\n";
            if (this.valor <= 0)
                resultadoValidacao += "O valor não pode ser nulo ou negativo";
            return resultadoValidacao;
        }

        public override bool Equals(object obj)
        {
            return obj is Servico servico &&
                   id == servico.id &&
                   Id == servico.Id &&
                   nome == servico.nome &&
                   tipo == servico.tipo &&
                   valor == servico.valor;
        }

        public override int GetHashCode()
        {
            int hashCode = -851700056;
            hashCode = hashCode * -1521134295 + id.GetHashCode();
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nome);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(tipo);
            hashCode = hashCode * -1521134295 + valor.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return $"Sevico = [{id}, {nome}, {tipo}, {valor}]";
        }
    }
}
