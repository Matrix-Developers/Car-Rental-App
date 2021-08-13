using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LocadoraDeVeiculos.Controladores.ServicoModule;
using LocadoraDeVeiculos.WindowsApp.Clientes;
using LocadoraDeVeiculos.WindowsApp.ClientesModule;
using LocadoraDeVeiculos.WindowsApp.Features.Serviços;

namespace LocadoraDeVeiculos.WindowsApp
{
    public partial class TelaPrincipalForm : Form
    {
        public TelaPrincipalForm()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientesForm tarefas = new ClientesForm();
            tarefas.ShowDialog();
            this.Close();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripMenu.Enabled = true;
        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdicionarServico telAdicionarServico = new AdicionarServico(new ControladorServico());
            telAdicionarServico.ShowDialog();
        }
    }
}
