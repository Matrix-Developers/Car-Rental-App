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
        public List<Servico> servicosSelecionados;
        public string seguro = "Nenhum";
        ServicoRepository controladorServico;
        public ServicosForm()
        {
            controladorServico = new ServicoRepository();
            servicosSelecionados = new List<Servico>();
            InitializeComponent();
            AtualizarListCheckBox();
            cBoxSeguro.SelectedIndex = 0; 
        }

        public void InicializarCampos(List<Servico> servicosIniciais, string seguroInicial, bool campoSeguroEhEditavel)
        {
            if (seguroInicial.Contains("Terceiro"))
                cBoxSeguro.SelectedIndex = 2;
            else if (seguroInicial.Contains("Cliente"))
                cBoxSeguro.SelectedIndex = 1;

            if (servicosIniciais != null)
            {
                for (int index = 0; index < cLBoxServicos.Items.Count; index++)
                {
                    cLBoxServicos.SetItemChecked(index, servicosIniciais.Contains(cLBoxServicos.Items[index]));
                }
            }

            cBoxSeguro.Enabled = campoSeguroEhEditavel;
        }

        private void AtualizarListCheckBox()
        {
            cLBoxServicos.Items.Clear();
            foreach (Servico servico in controladorServico.SelecionarTodos())
                cLBoxServicos.Items.Add(servico);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            seguro = cBoxSeguro.SelectedItem.ToString().Replace(" ", "");
            foreach (Servico servico in cLBoxServicos.CheckedItems)
                servicosSelecionados.Add(servico);
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
    }
}
