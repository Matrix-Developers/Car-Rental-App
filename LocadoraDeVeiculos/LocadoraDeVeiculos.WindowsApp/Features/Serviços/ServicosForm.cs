using LocadoraDeVeiculos.Controladores.ServicoModule;
using LocadoraDeVeiculos.Dominio.SevicosModule;
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
        public List<Servico> servicosSelecionados = new List<Servico>();
        ControladorServico controladorServico = new ControladorServico();
        double valorTotal = 00.00;
        public ServicosForm()
        {
            InitializeComponent();
            AtualizarListCheckBox();
        }

        private void AtualizarListCheckBox()
        {
            cLBoxServicos.Items.Clear();
            foreach (Servico servico in controladorServico.SelecionarTodos())
                cLBoxServicos.Items.Add(servico);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            foreach (Servico servico in cLBoxServicos.CheckedItems)
                servicosSelecionados.Add(servico);
        }

        private void cLBoxServicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < cLBoxServicos.Items.Count; i++)
                if (cLBoxServicos.GetItemChecked(i))
                    valorTotal += (cLBoxServicos.Items[i] as Servico).Valor;
            textBox1.Text = Convert.ToString(valorTotal);
            valorTotal = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaServicoForm telaServicoForm = new TelaServicoForm("Cadastro de Serviços");
            if (telaServicoForm.ShowDialog() == DialogResult.OK)
                AtualizarListCheckBox();
        }
    }
}
