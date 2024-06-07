using LocadoraDeVeiculos.WindowsApp.Shared;

namespace LocadoraDeVeiculos.WindowsApp.Features.Veiculos
{
    public class ConfiguracaoVeiculoToolBox : IConfiguracaoToolBox
    {
        public string ToolTipAdicionar
        {
            get { return "Register Vehicles"; }
        }

        public string TipoCadastro
        {
            get { return "Add new Vehicle"; }
        }

        public string ToolTipEditar
        {
            get { return "Edit existing Vehicle"; }
        }

        public string ToolTipExcluir
        {
            get { return "Delete Existing Vehicle"; }
        }
    }
}
