using LocadoraDeVeiculos.WindowsApp.Shared;

namespace LocadoraDeVeiculos.WindowsApp.Features.Locacoes
{
    public class ConfiguracaoLocacaoToolBox : IConfiguracaoToolBox
    {
        public string TipoCadastro
        {
            get { return "Register Car Rental"; }
        }

        public string ToolTipAdicionar
        {
            get { return "Make Car Rental"; }
        }

        public string ToolTipEditar
        {
            get { return "Edit Car Rental"; }
        }

        public string ToolTipExcluir
        {
            get { return "Delete Car Rental"; }
        }
    }
}