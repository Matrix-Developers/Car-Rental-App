using LocadoraDeVeiculos.Controladores.ServicoModule;
using LocadoraDeVeiculos.Dominio.SevicosModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.WindowsApp.Features.Servicos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Servicos
{
    public partial class ServicosForm : Form
    {
        public double valorFinal = 0;
        public List<Servico> servicosSelecionados = new List<Servico>();
        public string seguro = "";
        ControladorServico controladorServico = new ControladorServico();
        double valorTotal = 00.00;
        public ServicosForm()
        {
            InitializeComponent();
            AtualizarListCheckBox();
            cBoxSeguro.SelectedIndex = 0;
        }

        private void AtualizarListCheckBox()
        {
            cLBoxServicos.Items.Clear();
            foreach (Servico servico in controladorServico.SelecionarTodos())
                cLBoxServicos.Items.Add(servico);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            valorFinal = Convert.ToDouble(textBox1.Text);
            seguro = cBoxSeguro.SelectedItem.ToString().Replace(" ", "");
            foreach (Servico servico in cLBoxServicos.CheckedItems)
                servicosSelecionados.Add(servico);
        }

        private void cLBoxServicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularValorServicos();
            textBox1.Text = Convert.ToString(valorTotal);
            valorTotal = 0;
        }

        private void CalcularValorServicos()
        {
            valorTotal = CalcularLocacao.CalcularSeguro(cBoxSeguro.SelectedItem.ToString().Replace(" ", ""));
            for (int i = 0; i < cLBoxServicos.Items.Count; i++)
                if (cLBoxServicos.GetItemChecked(i))
                    valorTotal += (cLBoxServicos.Items[i] as Servico).Valor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaServicoForm telaServicoForm = new TelaServicoForm("Cadastro de Serviços");
            if (telaServicoForm.ShowDialog() == DialogResult.OK)
            {
                controladorServico.InserirNovo(telaServicoForm.Servico);
                AtualizarListCheckBox();                
            }
        }

        private void cBoxSeguro_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularValorServicos();

            textBox1.Text = Convert.ToString(valorTotal);
        }
    }
}
