

using LocadoraDeVeiculos.Dominio.CupomModule;
using LocadoraDeVeiculos.Dominio.ParceiroModule;
using System;

namespace LocadoraDeVeiculos.TestDataBuilders
{
    public class CupomDataBuilder
    {
        private Cupom cupom;

        public CupomDataBuilder()
        {
            cupom = new Cupom();
        }

        public CupomDataBuilder ComNome(string nome)
        {
            cupom.Nome = nome;
            return this;
        }
        public CupomDataBuilder ComCodigo(string codigo)
        {
            cupom.Codigo = codigo;
            return this;
        }
        public CupomDataBuilder ComValor(double valor)
        {
            cupom.Valor = valor;
            return this;
        }
        public CupomDataBuilder ComValorMinimo(double valorMinimo)
        {
            cupom.ValorMinimo = valorMinimo;
            return this;
        }
        public CupomDataBuilder EhDescontoFixo(bool descontoFixo)
        {
            cupom.EhDescontoFixo = descontoFixo;
            return this;
        }
        public CupomDataBuilder ComValidade(DateTime validade)
        {
            cupom.Validade = validade;
            return this;
        }
        public CupomDataBuilder ComParceiro(Parceiro parceiro)
        {
            cupom.Parceiro = parceiro;
            return this;
        }
        public CupomDataBuilder ComQtdUtilizada(int qtdUtilizada)
        {
            cupom.QtdUtilizada = qtdUtilizada;
            return this;
        }

        public Cupom Build()
        {
            return cupom;
        }
    }
}