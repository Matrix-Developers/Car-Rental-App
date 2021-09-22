using LocadoraDeVeiculos.Aplicacao.ServicoModule;
using LocadoraDeVeiculos.Controladores.ServicoModule;
using LocadoraDeVeiculos.Dominio.SevicosModule;
using LocadoraDeVeiculos.WindowsApp.Features.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Servicos
{
    public partial class TelaSelecionarServicoForm : Form
    {
        private readonly ServicoAppService appService;

        public List<Servico> servicosSelecionados;
        public string seguro = "Nenhum";
        
        public TelaSelecionarServicoForm(ServicoAppService servicoAppService)
        {
            appService = servicoAppService;
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
            foreach (Servico servico in appService.SelecionarTodasEntidade())
                cLBoxServicos.Items.Add(servico);
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            seguro = cBoxSeguro.SelectedItem.ToString().Replace(" ", "");
            foreach (Servico servico in cLBoxServicos.CheckedItems)
                servicosSelecionados.Add(servico);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            TelaServicoForm telaServicoForm = new("Cadastro de Serviços");
            if (telaServicoForm.ShowDialog() == DialogResult.OK)
            {
                appService.InserirEntidade(telaServicoForm.Servico);
                AtualizarListCheckBox();
            }
        }
    }
}
