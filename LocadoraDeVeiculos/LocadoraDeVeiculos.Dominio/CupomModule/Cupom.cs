using LocadoraDeVeiculos.Dominio.LocacaoModule;
using LocadoraDeVeiculos.Dominio.ParceiroModule;
using LocadoraDeVeiculos.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocadoraDeVeiculos.Dominio.CupomModule
{
    public class Cupom : EntidadeBase
    {
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public double Valor { get; set; }
        public double ValorMinimo { get; set; }
        public bool EhDescontoFixo { get; set; }
        public DateTime Validade { get; set; }
        public Parceiro Parceiro { get; set; }
        public int? ParceiroId { get; set; }
        public int QtdUtilizada { get; set; }
        public List<Locacao> Locacoes { get; set; }

        public Cupom(int id, string nome, string codigo, double valor, double valorMinimo, bool ehDescontoFixo, DateTime validade, Parceiro parceiro, int qtdUtilizada)
        {
            Id = id;
            Nome = nome;
            Codigo = codigo;
            Valor = valor;
            ValorMinimo = valorMinimo;
            EhDescontoFixo = ehDescontoFixo;
            Validade = validade;
            Parceiro = parceiro;
            ParceiroId = parceiro != null ? parceiro.Id : null;
            QtdUtilizada = qtdUtilizada;
        }

        public Cupom()
        {
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
            if (!EhDescontoFixo && Valor > 100)
                resultadoValicadacao += "A porcentagem de desconto não pode ser maior que 100%\n";
            if (Parceiro == null)
                resultadoValicadacao += "É obrigatório possuir um parceiro vinculado\n";
            if (resultadoValicadacao == "")
                resultadoValicadacao = "VALIDO";
            return resultadoValicadacao;
        }
        public override string ToString()
        {
            return $"{Nome}, {Codigo}, R${Valor}";
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
                   EqualityComparer<Parceiro>.Default.Equals(Parceiro, cupom.Parceiro) &&
                   QtdUtilizada == cupom.QtdUtilizada;
        }

        public override int GetHashCode()
        {
            HashCode hash = new();
            hash.Add(Id);
            hash.Add(Nome);
            hash.Add(Codigo);
            hash.Add(Valor);
            hash.Add(ValorMinimo);
            hash.Add(EhDescontoFixo);
            hash.Add(Validade);
            hash.Add(Parceiro);
            hash.Add(QtdUtilizada);
            return hash.ToHashCode();
        }
    }
}
