using LocadoraDeVeiculos.Dominio.ParceiroModule;
using System;
using System.IO;
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
        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            int id = 0;
            string nome = txtNome.Text;
            if (txtId.Text.Length > 0)
                id = Convert.ToInt32(txtId.Text);

            parceiro = new Parceiro(id, nome);

            string resultadoValidacao = parceiro.Validar();

            if (resultadoValidacao != "VALID")
            {
                string primeiroErro = new StringReader(resultadoValidacao).ReadLine();

                TelaPrincipalForm.Instancia.AtualizarRodape(primeiroErro);

                DialogResult = DialogResult.None;
            }
        }
    }
}
