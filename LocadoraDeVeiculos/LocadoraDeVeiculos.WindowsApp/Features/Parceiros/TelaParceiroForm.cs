using LocadoraDeVeiculos.Dominio.ParceiroModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Features.Parceiros
{
    public partial class TelaParceiroForm : Form
    {
        Parceiro parceiro;
        public TelaParceiroForm(string titulo)
        {
            InitializeComponent();
            labelTitulo.Text = titulo;
        }
        public Parceiro Parceiro
        {
            get { return parceiro; }

            set
            {
                parceiro = value;

                txtId.Text = parceiro.Id.ToString();
                txtNome.Text = parceiro.Nome;
            }
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int id = 0;
            string nome = txtNome.Text;
            if (txtId.Text.Length > 0)
                id = Convert.ToInt32(txtId.Text);

            parceiro = new Parceiro(id, nome);

            string resultadoValidacao = parceiro.Validar();

            if (resultadoValidacao != "VALIDO")
            {
                string primeiroErro = new StringReader(resultadoValidacao).ReadLine();

                TelaPrincipalForm.Instancia.AtualizarRodape(primeiroErro);

                DialogResult = DialogResult.None;
            }
        }
    }
}
