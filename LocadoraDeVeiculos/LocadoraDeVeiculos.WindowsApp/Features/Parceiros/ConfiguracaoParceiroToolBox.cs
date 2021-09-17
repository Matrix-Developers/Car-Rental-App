using LocadoraDeVeiculos.WindowsApp.Shared;

namespace LocadoraDeVeiculos.WindowsApp.Features.Parceiros
{
    public class ConfiguracaoParceiroToolBox : IConfiguracaoToolBox
    {
        public string ToolTipAdicionar
        {
            get { return "Cadastro de Parceiros"; }
        }

        public string TipoCadastro
        {
            get { return "Cadastro de um novo Parceiro"; }
        }

        public string ToolTipEditar
        {
            get { return "Editar um Parceiro existente"; }
        }

        public string ToolTipExcluir
        {
            get { return "Excluir um Parceiro existente"; }
        }
    }
}
