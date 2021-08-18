using LocadoraDeVeiculos.WindowsApp.Shared;

namespace LocadoraDeVeiculos.WindowsApp.Features.Veiculos
{
    public class ConfiguracaoVeiculoToolBox : IConfiguracaoToolBox
    {
        public string ToolTipAdicionar
        {
            get { return "Cadastro de Veiculos"; }
        }

        public string TipoCadastro
        {
            get { return "Cadastro de um novo Veiculo"; }
        }

        public string ToolTipEditar
        {
            get { return "Editar um Veiculo existente"; }
        }

        public string ToolTipExcluir
        {
            get { return "Excluir um Veiculo existente"; }
        }
    }
}
