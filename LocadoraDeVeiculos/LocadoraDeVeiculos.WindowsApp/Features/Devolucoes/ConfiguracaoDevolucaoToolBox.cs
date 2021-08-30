using LocadoraDeVeiculos.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.WindowsApp.Features.Devolucoes
{
    public class ConfiguracaoDevolucaoToolBox : IConfiguracaoToolBox
    {
        public string TipoCadastro { get { return "Devolução de Veículo"; } }

        public string ToolTipAdicionar { get { return "Registrar Devolução"; } }

        public string ToolTipEditar { get { return "Editar Devolução"; } }

        public string ToolTipExcluir { get { return "Excluir devolução"; } }
    }
}
