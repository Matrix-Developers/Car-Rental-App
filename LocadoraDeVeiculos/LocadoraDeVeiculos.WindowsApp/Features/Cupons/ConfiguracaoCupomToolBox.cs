using LocadoraDeVeiculos.WindowsApp.Shared;

namespace LocadoraDeVeiculos.WindowsApp.Features.Cupons
{
    public class ConfiguracaoCupomToolBox : IConfiguracaoToolBox
    {
        public string ToolTipAdicionar
        {
            get { return "Cadastro de Cupom de Desconto"; }
        }

        public string TipoCadastro
        {
            get { return "Cadastro de um novo Cupom"; }
        }

        public string ToolTipEditar
        {
            get { return "Editar um Cupom existente"; }
        }

        public string ToolTipExcluir
        {
            get { return "Excluir um Cupom existente"; }
        }
    }
}
