using LocadoraDeVeiculos.WindowsApp.Shared;

namespace LocadoraDeVeiculos.WindowsApp.Features.Clientes
{
    public class ConfiguracaoClienteToolBox : IConfiguracaoToolBox
    {


        public string TipoCadastro
        {
            get { return "Register Client"; }
        }

        public string ToolTipAdicionar
        {
            get { return "Add a new Client"; }
        }

        public string ToolTipEditar
        {
            get { return "Edit an existing Client"; }
        }

        public string ToolTipExcluir
        {
            get { return "Delete an existign Client"; }
        }


    }
}
