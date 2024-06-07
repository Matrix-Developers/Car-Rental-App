using LocadoraDeVeiculos.WindowsApp.Shared;

namespace LocadoraDeVeiculos.WindowsApp.Features.Cupons
{
    public class ConfiguracaoCupomToolBox : IConfiguracaoToolBox
    {
        public string ToolTipAdicionar
        {
            get { return "Register Discount Coupon"; }
        }

        public string TipoCadastro
        {
            get { return "Add Discount Coupon"; }
        }

        public string ToolTipEditar
        {
            get { return "Edit Discount Coupon"; }
        }

        public string ToolTipExcluir
        {
            get { return "Delete Discount Coupon"; }
        }
    }
}
