using LocadoraDeVeiculos.Controladores.ServicoModule;
using LocadoraDeVeiculos.Dominio.SevicosModule;
using LocadoraDeVeiculos.WindowsApp.Servicos;
using LocadoraDeVeiculos.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Features.Servicos
{
    class OperacoesServico : ICadastravel
    {
        private readonly ControladorServico controlador = null;
        private readonly TabelaServicoControl tabelaServicos = null;

        public OperacoesServico(ControladorServico ctrlServico)
        {
            controlador = ctrlServico;
            tabelaServicos = new TabelaServicoControl();
        }

        public void InserirNovoRegistro()
        {
            TelaServicoForm tela = new TelaServicoForm("Cadastro de Serviços");

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.InserirNovo(tela.Servico);

                List<Servico> servicos = controlador.SelecionarTodos();

                tabelaServicos.AtualizarRegistros(servicos);

                TelaPrincipalForm.Instancia.AtualizarRodape($"Servico: [{tela.Servico.Nome}] inserido com sucesso");
            }
        }

        public void EditarRegistro()
        {
            int id = tabelaServicos.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um servico para poder editar!", "Edição de Servicos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Servico servicoSelecionada = controlador.SelecionarPorId(id);

            TelaServicoForm tela = new TelaServicoForm("Edição de Serviços");

            tela.Servico = servicoSelecionada;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.Editar(id, tela.Servico);

                List<Servico> servicos = controlador.SelecionarTodos();

                tabelaServicos.AtualizarRegistros(servicos);

                TelaPrincipalForm.Instancia.AtualizarRodape($"Servico: [{tela.Servico.Nome}] editado com sucesso");
            }
        }

        public void ExcluirRegistro()
        {
            int id = tabelaServicos.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione uma servico para poder excluir!", "Exclusão de Servicos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Servico servicoSelecionada = controlador.SelecionarPorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir o servico: [{servicoSelecionada.Nome}] ?",
                "Exclusão de Servicos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                controlador.Excluir(id);

                List<Servico> servicos = controlador.SelecionarTodos();

                tabelaServicos.AtualizarRegistros(servicos);

                TelaPrincipalForm.Instancia.AtualizarRodape($"Servico: [{servicoSelecionada.Nome}] removido com sucesso");
            }
        }

        public UserControl ObterTabela()
        {
            List<Servico> servicos = controlador.SelecionarTodos();

            tabelaServicos.AtualizarRegistros(servicos);

            return tabelaServicos;
        }

        public void AgruparRegistros()
        {
            throw new NotImplementedException();
        }

        public void FiltrarRegistros()
        {
            throw new NotImplementedException();
        }
    }
}
