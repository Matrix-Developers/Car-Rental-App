using LocadoraDeVeiculos.WindowsApp.Shared;

namespace LocadoraDeVeiculos.WindowsApp.Features.GrupoDeVeiculos
{
    public class ConfiguracaoGrupoDeVeiculosToolBox : IConfiguracaoToolBox
    {
        public string TipoCadastro
        {
            get { return "Cadastro de Grupo de Veiculos"; }
        }

        public string ToolTipAdicionar
        {
            get { return "Adicionar uma novo Grupo de Veiculos"; }
        }

        public string ToolTipEditar
        {
            get { return "Editar um Grupo de Veiculos existente"; }
        }

        public string ToolTipExcluir
        {
            get { return "Excluir um Grupo de Veiculos existente"; }
        }
    }
}