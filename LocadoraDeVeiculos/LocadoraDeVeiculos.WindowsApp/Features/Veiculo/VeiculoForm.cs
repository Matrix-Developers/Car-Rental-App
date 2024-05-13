using LocadoraDeVeiculos.Aplicacao.GrupoDeVeiculosModule;
using LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule;
using LocadoraDeVeiculos.Dominio.VeiculoModule;
using System;
using System.IO;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Veiculos
{
    public partial class VeiculoForm : Form
    {
        private Veiculo veiculo;
        private readonly GrupoDeVeiculosAppService controladorGrupoVeiculos;
        public VeiculoForm(string titulo, GrupoDeVeiculosAppService controladorGrupoVeiculos)
        {
            this.controladorGrupoVeiculos = controladorGrupoVeiculos;
            InitializeComponent();
            CarregarGruposDeVeiculos();
            labelTitulo.Text = titulo;
            cBoxPortaMalas.SelectedIndex = 0;
            cBoxCombustivel.SelectedIndex = 0;
        }

        private void CarregarGruposDeVeiculos()
        {
            cBoxGrupo.DataSource = controladorGrupoVeiculos.SelecionarTodasEntidade();
        }

        public Veiculo Veiculo
        {
            get { return veiculo; }

            set
            {
                veiculo = value;

                textId.Text = veiculo.Id.ToString();
                textModelo.Text = veiculo.modelo;
                cBoxGrupo.Text = veiculo.grupoVeiculos.Nome;
                textPlaca.Text = veiculo.placa;
                textChassi.Text = veiculo.chassi;
                textMarca.Text = veiculo.marca;
                textCor.Text = veiculo.cor;
                cBoxCombustivel.Text = veiculo.tipoCombustivel;
                numUpDownCapTanque.Text = veiculo.capacidadeTanque.ToString();
                textAno.Text = veiculo.ano.ToString();
                textKM.Text = veiculo.kilometragem.ToString();
                numUpDownQtdPortas.Text = veiculo.numeroPortas.ToString();
                numUpDownQtdPessoas.Text = veiculo.capacidadePessoas.ToString();
                cBoxPortaMalas.Text = veiculo.tamanhoPortaMala.ToString();
                if (veiculo.temArCondicionado)
                    checkLBoxOpcionais.SetItemChecked(0, true);
                if (veiculo.temDirecaoHidraulica)
                    checkLBoxOpcionais.SetItemChecked(1, true);
                if (veiculo.temFreiosAbs)
                    checkLBoxOpcionais.SetItemChecked(2, true);
            }
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            int id = 0;
            int ano = 0;
            if (textId.Text.Length > 0)
                id = Convert.ToInt32(textId.Text);
            string placa = textPlaca.Text;
            string chassi = textChassi.Text;
            string marca = textMarca.Text;
            string modelo = textModelo.Text;
            if (textAno.Text.Length > 0)
                ano = Convert.ToInt32(textAno.Text);
            string cor = textCor.Text;
            GrupoDeVeiculo grupoDeVeiculos = cBoxGrupo.SelectedItem as GrupoDeVeiculo;
            int capTanque = Convert.ToInt32(numUpDownCapTanque.Value);
            string combustivel = cBoxCombustivel.Text;
            int numPortas = Convert.ToInt32(numUpDownQtdPortas.Value);
            int numPessoas = Convert.ToInt32(numUpDownQtdPessoas.Value);
            double kilometragem = Convert.ToDouble(textKM.Text);
            char tamPortaMalas = Convert.ToChar(cBoxPortaMalas.Text);
            bool possuiArCondicionado = false;
            bool possuiDirecaoHidraulica = false;
            bool possuiFreioAbs = false;
            if (checkLBoxOpcionais.CheckedIndices.Contains(0))
                possuiArCondicionado = true;
            if (checkLBoxOpcionais.CheckedIndices.Contains(1))
                possuiDirecaoHidraulica = true;
            if (checkLBoxOpcionais.CheckedIndices.Contains(2))
                possuiFreioAbs = true;

            veiculo = new Veiculo(id, modelo, grupoDeVeiculos, placa, chassi, marca, cor, combustivel, capTanque, ano, kilometragem, numPortas, numPessoas, tamPortaMalas, possuiArCondicionado, possuiDirecaoHidraulica, possuiFreioAbs, false);

            string resultadoValidacao = veiculo.Validar();

            if (resultadoValidacao != "VALIDO")
            {
                string primeiroErro = new StringReader(resultadoValidacao).ReadLine();

                TelaPrincipalForm.Instancia.AtualizarRodape(primeiroErro);

                DialogResult = DialogResult.None;
            }
        }

        private void TextAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                if (textAno.Text.Contains(".", StringComparison.CurrentCulture) || textAno.Text.Length == 0)
                {
                    e.Handled = true;
                }
            }
            else if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TextKM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                if (textKM.Text.Contains(".", StringComparison.CurrentCulture) || textKM.Text.Length == 0)
                {
                    e.Handled = true;
                }
            }
            else if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
