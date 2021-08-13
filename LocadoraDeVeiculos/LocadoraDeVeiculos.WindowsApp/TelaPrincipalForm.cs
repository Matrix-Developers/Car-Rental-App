using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LocadoraDeVeiculos.WindowsApp.Clientes;
using LocadoraDeVeiculos.WindowsApp.ClientesModule;
using LocadoraDeVeiculos.Dominio.FuncionarioModule;

namespace LocadoraDeVeiculos.WindowsApp
{
    public partial class TelaPrincipalForm : Form
    {
        public static TelaPrincipalForm Instancia;
        public TelaPrincipalForm()
        {
            InitializeComponent();

            Instancia = this;
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

        private void ConfigurarPainelRegistros()
        {
            
        }
    }
}
