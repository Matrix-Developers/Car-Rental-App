using LocadoraDeVeiculos.WindowsApp.Shared;

namespace LocadoraDeVeiculos.WindowsApp.Features.Funcionarios
{
    public class ConfiguracaoFuncionarioToolBox : IConfiguracaoToolBox
    {
        public string TipoCadastro { get { return "Employee Register"; } }

        public string ToolTipAdicionar { get { return "Add Employee"; } }

        public string ToolTipEditar { get { return "Edit Employee"; } }

        public string ToolTipExcluir { get { return "Delete Employee"; } }
    }
}
