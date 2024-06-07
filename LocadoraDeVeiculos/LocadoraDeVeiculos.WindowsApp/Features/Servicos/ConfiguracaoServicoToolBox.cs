using LocadoraDeVeiculos.WindowsApp.Shared;

namespace LocadoraDeVeiculos.WindowsApp.Features.Servicos
{
    class ConfiguracaoServicoToolBox : IConfiguracaoToolBox
    {
        public string ToolTipAdicionar
        {
            get { return "Register Serivce"; }
        }

        public string TipoCadastro
        {
            get { return "Add new Service"; }
        }

        public string ToolTipEditar
        {
            get { return "Edit Existing Service"; }
        }

        public string ToolTipExcluir
        {
            get { return "Delete Existing Service"; }
        }
    }
}
