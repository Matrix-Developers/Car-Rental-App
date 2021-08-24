using LocadoraDeVeiculos.WindowsApp.Shared;

namespace LocadoraDeVeiculos.WindowsApp.Features.Locacoes
{
    public class ConfiguracaoLocacaoToolBox : IConfiguracaoToolBox
    {
        public string TipoCadastro
        {
            get { return "Registro Locação de Veiculo"; }
        }

        public string ToolTipAdicionar
        {
            get { return "Realizar Locação de Veiculo"; }
        }

        public string ToolTipEditar
        {
            get { return "Editar Locação de Veiculo"; }
        }

        public string ToolTipExcluir
        {
            get { return "Excluir uma Locação de Veiculo"; }
        }
    }
}