using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Features.Devolucoes
{
    public partial class FiltroDevolucaoForm : Form
    {
        public FiltroDevolucaoForm()
        {
            InitializeComponent();
        }
        public FiltroDevolucaoEnum TipoFiltro
        {
            get
            {
                if (rdbDevolucoesConcluidas.Checked)
                    return FiltroDevolucaoEnum.DevolucoesFinalizadas;

                else if (rdbDevolucoesPendentes.Checked)
                    return FiltroDevolucaoEnum.DevolucoesPendentes;

                else
                    return FiltroDevolucaoEnum.TodasDevolucoes;
            }
        }
    }
}
