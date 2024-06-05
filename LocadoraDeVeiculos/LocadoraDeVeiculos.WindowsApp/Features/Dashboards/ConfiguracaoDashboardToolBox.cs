using LocadoraDeVeiculos.WindowsApp.Shared;

namespace LocadoraDeVeiculos.WindowsApp.Features.Dashboards
{
    public class ConfiguracaoDashboardToolBox : IConfiguracaoToolBox
    {
        public string ToolTipAdicionar
        {
            get { return "Add"; }
        }
        public string TipoCadastro
        {
            get { return "DashBoard"; }
        }

        public string ToolTipEditar
        {
            get { return "Edit"; }
        }

        public string ToolTipExcluir
        {
            get { return "Delete"; }
        }
    }
}
