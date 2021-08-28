using LocadoraDeVeiculos.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.WindowsApp.Features.Dashboards
{
    public class ConfiguracaoDashboardToolBox : IConfiguracaoToolBox
    {
        public string ToolTipAdicionar
        {
            get { return "Adicionar"; }
        }
        public string TipoCadastro
        {
            get { return "DashBoard"; }
        }

        public string ToolTipEditar
        {
            get { return "Editar"; }
        }

        public string ToolTipExcluir
        {
            get { return "Excluir"; }
        }
    }
}
