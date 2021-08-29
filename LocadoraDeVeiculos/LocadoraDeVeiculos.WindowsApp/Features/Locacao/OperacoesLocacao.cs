using LocadoraDeVeiculos.Controladores.LocacaoModule;
using LocadoraDeVeiculos.Controladores.ServicoLocacaoModule;
using LocadoraDeVeiculos.Dominio.LocacaoModule;
using LocadoraDeVeiculos.WindowsApp.Servicos;
using LocadoraDeVeiculos.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Features.Locacoes
{
    public class OperacoesLocacao : ICadastravel
    {
        private readonly ControladorLocacao controlador = null;
        private readonly TabelaLocacaoControl tabelaLocacao = null;
        public OperacoesLocacao(ControladorLocacao ctrlLocacao)
        {
            controlador = ctrlLocacao;
            tabelaLocacao = new TabelaLocacaoControl();
        }

        public void InserirNovoRegistro()
        {
            TelaLocacaoForm tela = new TelaLocacaoForm("Locação de Veiculos");

            ServicosForm telaServico = new ServicosForm();
            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.InserirNovo(tela.Locacao);

                if (telaServico.servicosSelecionados.Count > 0)
                    controlador.InserirRelacionamento(tela.Locacao, telaServico.servicosSelecionados);

                List<Locacao> veiculos = controlador.SelecionarTodos();

                tabelaLocacao.AtualizarRegistros(veiculos);

                TelaPrincipalForm.Instancia.AtualizarRodape($"Locação: [{tela.Locacao.Veiculo}] realizada com sucesso");
            }
        }

        public void EditarRegistro()
        {
            int id = tabelaLocacao.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione uma locação para poder editar!", "Edição de locação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Locacao locacaoSelecionada = controlador.SelecionarPorId(id);

            TelaLocacaoForm tela = new TelaLocacaoForm("Edição de Veiculos");

            tela.Locacao = locacaoSelecionada;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.Editar(id, tela.Locacao);

                List<Locacao> veiculos = controlador.SelecionarTodos();

                tabelaLocacao.AtualizarRegistros(veiculos);

                TelaPrincipalForm.Instancia.AtualizarRodape($"Locação de: [{tela.Locacao.ClienteContratante}] editado com sucesso");
            }
        }

        public void ExcluirRegistro()
        {
            int id = tabelaLocacao.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione uma locação para poder excluir!", "Exclusão de Locação",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Locacao locacaoSelecionada = controlador.SelecionarPorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir a locação: [{locacaoSelecionada.Id}] ?",
                "Exclusão de Locação", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                controlador.Excluir(id);

                List<Locacao> veiculos = controlador.SelecionarTodos();

                tabelaLocacao.AtualizarRegistros(veiculos);

                TelaPrincipalForm.Instancia.AtualizarRodape($"Locação de: [{locacaoSelecionada.ClienteContratante}] removida com sucesso");
            }
        }
        public void AgruparRegistros()
        {
            throw new NotImplementedException();
        }

        public void FiltrarRegistros()
        {
            throw new NotImplementedException();
        }
        public UserControl ObterTabela()
        {
            List<Locacao> locacoes = controlador.SelecionarTodos();
            tabelaLocacao.AtualizarRegistros(locacoes);

            return tabelaLocacao;
        }
    }
}
