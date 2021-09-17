
using LocadoraDeVeiculos.Controladores.LocacaoModule;
using LocadoraDeVeiculos.Controladores.RelacionamentoLocServModule;
using LocadoraDeVeiculos.Controladores.Shared;
using LocadoraDeVeiculos.Dominio.LocacaoModule;
using LocadoraDeVeiculos.Dominio.RelacionamentoLocServModule;
using LocadoraDeVeiculos.Infra.InternetServices;
using LocadoraDeVeiculos.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Features.Locacoes
{
    public class OperacoesLocacao : ICadastravel
    {
        private readonly LocacaoRepository controlador = null;
        private readonly RelacionamentoLocServRepository controladorRelacionamento = null;
        private RelacionamentoLocServ relacionamento;
        private readonly TabelaLocacaoControl tabelaLocacao = null;
        ConversorParaPdf conversorPdf;
        public OperacoesLocacao(LocacaoRepository ctrlLocacao)
        {
            conversorPdf = new ConversorParaPdf(10, 18);
            controlador = ctrlLocacao;
            controladorRelacionamento = new RelacionamentoLocServRepository();
            tabelaLocacao = new TabelaLocacaoControl();
        }

        public void InserirNovoRegistro()
        {
            TelaLocacaoForm tela = new("Locação de Veiculos");

            if (tela.ShowDialog() == DialogResult.OK)
            {
                string resultadoLocacao = controlador.InserirNovo(tela.Locacao);

                if (resultadoLocacao == "VALIDO")
                {
                    relacionamento = new RelacionamentoLocServ(0, tela.Locacao, tela.Servicos);
                    controladorRelacionamento.InserirNovo(relacionamento);
                    conversorPdf.ConverterLocacaoEmPdf(tela.Locacao);

                    try
                    {
                        GerenciadorDeEmail.EnviarEmail("matriquisdevelopers@gmail.com", "matrixadm",tela.Locacao);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao tentar enviar os dados de locação por e-mail.\nO recibo está salvo na pasta Recibos e deverá ser enviado manualmente assim que possível!!\n" + ex.Message, "Erro ao enviar e-mail");
                    }
                }

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

            TelaLocacaoForm tela = new("Edição de Locação");

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
