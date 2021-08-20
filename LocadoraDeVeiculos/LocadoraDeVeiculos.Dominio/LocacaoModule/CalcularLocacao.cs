using LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Dominio.Shared
{
    public static class CalcularLocacao
    {
        public static double CalcularGarantia()
        {
            return 1000;
        }

        public static double CalcularSeguro(string tipoSeguro)
        {
            double valorFinal = 0;
            switch (tipoSeguro)
            {
                case "SeguroCliente":

                    break;
                case "SeguroTerceiro":

                    break;
                case "Nenhum":

                    break;
            }
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
    }
}
