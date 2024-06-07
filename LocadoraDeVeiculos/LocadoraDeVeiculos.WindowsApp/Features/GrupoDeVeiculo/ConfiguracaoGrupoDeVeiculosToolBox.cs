using LocadoraDeVeiculos.WindowsApp.Shared;

namespace LocadoraDeVeiculos.WindowsApp.Features.GrupoDeVeiculos
{
    public class ConfiguracaoGrupoDeVeiculosToolBox : IConfiguracaoToolBox
    {
        public string TipoCadastro
        {
            get { return "Register Vehicle Group"; }
        }

        public string ToolTipAdicionar
        {
            get { return "Add new Vehicle Group"; }
        }

        public string ToolTipEditar
        {
            get { return "Edit existing Vehicle Group"; }
        }

        public string ToolTipExcluir
        {
            get { return "Delete existing Vehicle Group"; }
        }
    }
}