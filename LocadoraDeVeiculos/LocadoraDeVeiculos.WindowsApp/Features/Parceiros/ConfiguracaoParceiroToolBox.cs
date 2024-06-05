using LocadoraDeVeiculos.WindowsApp.Shared;

namespace LocadoraDeVeiculos.WindowsApp.Features.Parceiros
{
    public class ConfiguracaoParceiroToolBox : IConfiguracaoToolBox
    {
        public string ToolTipAdicionar
        {
            get { return "Register Partner"; }
        }

        public string TipoCadastro
        {
            get { return "Add new Partner"; }
        }

        public string ToolTipEditar
        {
            get { return "Edit existing Partner"; }
        }

        public string ToolTipExcluir
        {
            get { return "Delete Existing Partner"; }
        }
    }
}
