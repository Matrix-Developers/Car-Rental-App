using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Features.Parceiros
{
    public partial class TelaParceiroForm : Form
    {
        public TelaParceiroForm(string titulo)
        {
            InitializeComponent();
            labelTitulo.Text = titulo;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

        }
    }
}
