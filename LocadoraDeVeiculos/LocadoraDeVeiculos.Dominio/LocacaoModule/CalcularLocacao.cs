using LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule;
using LocadoraDeVeiculos.Dominio.SevicosModule;
using System;
using System.Collections.Generic;

namespace LocadoraDeVeiculos.Dominio.Shared
{
    public static class CalcularLocacao
    {
        public const double VALOR_SEGURO_CLIENTE = 250.50f;
        public const double VALOR_SEGURO_TERCEIRO = 500.75f;
        public const double VALOR_GARANTIA = 1000f;

        public static double CalcularGarantia()
        {
            return VALOR_GARANTIA;
        }

        public static double CalcularSeguro(string tipoSeguro)
        {
            double valorFinal;
            if (tipoSeguro.Equals("SeguroCliente"))
                    valorFinal = VALOR_SEGURO_CLIENTE;
            else if(tipoSeguro.Equals("SeguroTerceiro"))
                valorFinal = VALOR_SEGURO_TERCEIRO;
            else
                valorFinal = 0;
            return valorFinal;
        }

        public static double CalcularPlano(string tipoPlano, GrupoDeVeiculo grupoDeVeiculos, double quilometragemRodada, DateTime dataInicial, DateTime dataFinal) 
        {
            double valorFinal = 0;
            switch (tipoPlano)
            {
                case "PlanoDiario":

                    break;
                case "KmControlado":

                    break;
                case "KmLivre":

                    break;
            }
            return valorFinal;
        }

        internal static double CalcularServicos(List<Servico> servicos, DateTime dataInicial, DateTime dataFinal)
        {
            double resultado = 0;
            foreach(Servico servico in servicos)
            {
                if (servico.EhTaxadoDiario)
                    resultado += servico.Valor * (dataFinal - dataInicial).TotalDays;
                else
                    resultado += servico.Valor;
            }
            return resultado;
        }
    }
}
