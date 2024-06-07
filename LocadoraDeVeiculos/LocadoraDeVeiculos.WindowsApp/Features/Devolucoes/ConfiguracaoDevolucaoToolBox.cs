using LocadoraDeVeiculos.WindowsApp.Shared;

namespace LocadoraDeVeiculos.WindowsApp.Features.Devolucoes
{
    public class ConfiguracaoDevolucaoToolBox : IConfiguracaoToolBox
    {
        public string TipoCadastro { get { return "Vehicle Devolution"; } }

        public string ToolTipAdicionar { get { return "Register Devolution"; } }

        public string ToolTipEditar { get { return "Edit Devolution"; } }

        public string ToolTipExcluir { get { return "Delete Devolution"; } }
    }
}
