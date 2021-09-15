using LocadoraDeVeiculos.Controladores.VeiculoModule;

namespace LocadoraDeVeiculos.WindowsApp.Features.Dashboards
{
    public class OperacoesDashboard
    {
        private readonly VeiculoRepository controladorVeiculo = null;
        //private readonly ControladorLocacao controladorLocacao = null;
        //private readonly DashboardControl dashboardControl = null;

        public OperacoesDashboard(VeiculoRepository controladorVeiculo) //ControladorLocacao controladorLocacao)
        {
            //this.controladorLocacao = controladorLocacao;
            this.controladorVeiculo = controladorVeiculo;
            //dashboardControl = new DashboardControl();
        }
    }
}
