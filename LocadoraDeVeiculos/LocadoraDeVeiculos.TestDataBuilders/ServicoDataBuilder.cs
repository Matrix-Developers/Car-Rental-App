using LocadoraDeVeiculos.Dominio.SevicosModule;
using System;

namespace LocadoraDeVeiculos.TestDataBuilders
{
    public class ServicoDataBuilder
    {
        private Servico servico;

        public ServicoDataBuilder()
        {
            servico = new Servico();
        }

        public ServicoDataBuilder ComNome(string nome)
        {
            servico.Nome = nome;
            return this;
        }
        public ServicoDataBuilder ComTaxaDiaria(bool EhTaxadoDiario)
        {
            servico.EhTaxadoDiario = EhTaxadoDiario;
            return this;
        }
        public ServicoDataBuilder ComValor(double valor)
        {
            servico.Valor = valor;
            return this;
        }

        public Servico Build()
        {
            return servico;
        }
    }
}