using LocadoraDeVeiculos.WindowsApp.Shared;

namespace LocadoraDeVeiculos.WindowsApp.Features.Clientes
{
    public class ConfiguracaoClienteToolBox : IConfiguracaoToolBox
    {


        public string TipoCadastro
        {
            get { return "Cadastro de Clientes"; }
        }

        public string ToolTipAdicionar
        {
            get { return "Adicionar um novo Cliente"; }
        }

        public string ToolTipEditar
        {
            get { return "Editar um Cliente existente"; }
        }

        public string ToolTipExcluir
        {
            get { return "Excluir um Cliente existente"; }
        }


    }
}
