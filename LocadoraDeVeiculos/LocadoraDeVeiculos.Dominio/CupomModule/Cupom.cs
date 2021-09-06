using LocadoraDeVeiculos.Dominio.ParceiroModule;
using LocadoraDeVeiculos.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Dominio.CupomModule
{
    public class Cupom : EntidadeBase
    {
        public string Nome { get; }
        public string Codigo { get; }
        public double Valor { get; }
        public double ValorMinimo { get; }
        public bool EhDescontoFixo { get; }
        public DateTime Validade { get; }
        public Parceiro Parceiro { get; }

        public Cupom(int id, string nome, string codigo, double valor, double valorMinimo, bool ehDescontoFixo, DateTime validade, Parceiro parceiro)
        {
            Id = id;
            Nome = nome;
            Codigo = codigo;
            Valor = valor;
            ValorMinimo = valorMinimo;
            EhDescontoFixo = ehDescontoFixo;
            Validade = validade;
            Parceiro = parceiro;
        }
        public override string Validar()
        {
            string resultadoValicadacao = "";

            if (Nome.Length == 0)
                resultadoValicadacao += "O campo nome é obrigatório\n";
            if (Codigo.Length == 0)
                resultadoValicadacao += "O campo código é obrigatório\n";
            if (Valor <= 0)
                resultadoValicadacao += "O valor não pode ser negativo ou 0(zero)\n";
            if(!EhDescontoFixo && Valor > 100)
                resultadoValicadacao += "A porcentagem de desconto não pode ser maior que 100%\n";
            if (Parceiro == null)
                resultadoValicadacao += "É obrigatório possuir um parceiro vinculado\n";
            if (resultadoValicadacao == "")
                resultadoValicadacao = "VALIDO";
            return resultadoValicadacao;
        }
        public override string ToString()
        {
            return $"[{id}, {Nome}, {Codigo}, {EhDescontoFixo}, {Valor}]";
        }

        public override bool Equals(object obj)
        {
            return obj is Cupom cupom &&
                   Id == cupom.Id &&
                   Nome == cupom.Nome &&
                   Codigo == cupom.Codigo &&
                   Valor == cupom.Valor &&
                   ValorMinimo == cupom.ValorMinimo &&
                   EhDescontoFixo == cupom.EhDescontoFixo &&
                   Validade == cupom.Validade &&
                   EqualityComparer<Parceiro>.Default.Equals(Parceiro, cupom.Parceiro);
        }

        public override int GetHashCode()
        {
            int hashCode = -1097376669;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nome);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Codigo);
            hashCode = hashCode * -1521134295 + Valor.GetHashCode();
            hashCode = hashCode * -1521134295 + ValorMinimo.GetHashCode();
            hashCode = hashCode * -1521134295 + EhDescontoFixo.GetHashCode();
            hashCode = hashCode * -1521134295 + Validade.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Parceiro>.Default.GetHashCode(Parceiro);
            return hashCode;
        }
    }
}
