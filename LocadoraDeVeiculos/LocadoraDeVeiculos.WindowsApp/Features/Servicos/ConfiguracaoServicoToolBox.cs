using LocadoraDeVeiculos.WindowsApp.Shared;

namespace LocadoraDeVeiculos.WindowsApp.Features.Servicos
{
    class ConfiguracaoServicoToolBox : IConfiguracaoToolBox
    {
        public string ToolTipAdicionar
        {
            get { return "Cadastro de Serviços"; }
        }

        public string TipoCadastro
        {
            get { return "Adicionar um novo Serviço"; }
        }

        public string ToolTipEditar
        {
            get { return "Editar um Serviço existente"; }
        }

        public string ToolTipExcluir
        {
            get { return "Excluir um Serviço existente"; }
        }
    }
}
