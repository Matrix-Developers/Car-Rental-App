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

        public static double CalcularPlano(string tipoPlano, GrupoDeVeiculo grupoDeVeiculos, double kilometragemRodada, DateTime dataInicial, DateTime dataFinal) 
        {
            double intervaloDeDias = (dataFinal - dataInicial).TotalDays;
            double precoPorDia = 0;
            double precoPorKm = 0;
            switch (tipoPlano)
            {
                case "PlanoDiario":     //calculado por dia e por km rodado.
                    precoPorDia = grupoDeVeiculos.TaxaPlanoDiario * intervaloDeDias;
                    precoPorKm = kilometragemRodada * grupoDeVeiculos.TaxaPorKmDiario;
                    break;

                case "KmControlado":    // pago por dia e com uma quantidade que pode rodar por dia. Caso extrapole paga a mais por km.
                    precoPorDia = grupoDeVeiculos.TaxaPlanoControlado * intervaloDeDias;
                    if (intervaloDeDias > grupoDeVeiculos.LimiteKmControlado)
                        precoPorKm = (kilometragemRodada - grupoDeVeiculos.LimiteKmControlado) * grupoDeVeiculos.TaxaKmExcedidoControlado;
                    break;

                case "KmLivre":         //paga apenas a diária e sem controle de km.
                    precoPorDia = grupoDeVeiculos.TaxaPlanoLivre * intervaloDeDias;
                    break;
            }
            return precoPorDia + precoPorKm;
        }

        public static double CalcularServicos(List<Servico> servicos, DateTime dataInicial, DateTime dataFinal)
        {
            double resultado = 0;
            double intervaloDeDias = (dataFinal - dataInicial).TotalDays;
            foreach (Servico servico in servicos)
            {
                if (servico.EhTaxadoDiario)
                    resultado += servico.Valor * intervaloDeDias;
                else
                    resultado += servico.Valor;
            }
            return resultado;
        }
    }
}
