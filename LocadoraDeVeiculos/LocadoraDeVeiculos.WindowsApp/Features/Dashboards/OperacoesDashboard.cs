using LocadoraDeVeiculos.Controladores.VeiculoModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.WindowsApp.Features.Dashboards
{
    public class OperacoesDashboard
    {
        private readonly ControladorVeiculo controladorVeiculo = null;
        //private readonly ControladorLocacao controladorLocacao = null;
        //private readonly DashboardControl dashboardControl = null;

        public OperacoesDashboard(ControladorVeiculo controladorVeiculo) //ControladorLocacao controladorLocacao)
        {
            //this.controladorLocacao = controladorLocacao;
            this.controladorVeiculo = controladorVeiculo;
            //dashboardControl = new DashboardControl();
        }
    }
}
