
using LocadoraDeVeiculos.Aplicacao.ClienteModule;
using LocadoraDeVeiculos.Aplicacao.CupomModule;
using LocadoraDeVeiculos.Aplicacao.FuncionarioModule;
using LocadoraDeVeiculos.Aplicacao.LocacaoModule;
using LocadoraDeVeiculos.Aplicacao.ServicoModule;
using LocadoraDeVeiculos.Aplicacao.VeiculoModule;
using LocadoraDeVeiculos.Controladores.RelacionamentoLocServModule;
using LocadoraDeVeiculos.Controladores.Shared;
using LocadoraDeVeiculos.Dominio.LocacaoModule;
using LocadoraDeVeiculos.Dominio.RelacionamentoLocServModule;
using LocadoraDeVeiculos.Dominio.VeiculoModule;
using LocadoraDeVeiculos.Infra.InternetServices;
using LocadoraDeVeiculos.Infra.Logs;
using LocadoraDeVeiculos.WindowsApp.Shared;
using Serilog;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Features.Locacoes
{
    public class OperacoesLocacao : ICadastravel
    {
        private readonly ConversorParaPdf conversorPdf;

        private readonly LocacaoAppService locacaoAppService;
        private readonly ServicoAppService servicoAppService;
        private readonly FuncionarioAppService funcionarioAppService;
        private readonly VeiculoAppService veiculoAppService;
        private readonly ClienteAppService clienteAppService;
        private readonly CupomAppService cupomAppService;

        //private readonly RelacionamentoLocServRepository controladorRelacionamento;
        //private RelacionamentoLocServ relacionamento;
        private readonly TabelaLocacaoControl tabelaLocacao; 

        public OperacoesLocacao(LocacaoAppService locacaoAppService, ServicoAppService servicoAppService, FuncionarioAppService funcionarioAppService, VeiculoAppService veiculoAppService, ClienteAppService clienteAppService, CupomAppService cupomAppService)
        {
            this.locacaoAppService = locacaoAppService;
            this.servicoAppService = servicoAppService;
            this.funcionarioAppService = funcionarioAppService;
            this.veiculoAppService = veiculoAppService;
            this.clienteAppService = clienteAppService;
            this.cupomAppService = cupomAppService;
            //controladorRelacionamento = new RelacionamentoLocServRepository();
            conversorPdf = new ConversorParaPdf(10, 18);
            tabelaLocacao = new TabelaLocacaoControl();
        }

        public void InserirNovoRegistro()
        {
            GeradorLog.ConfigurarLog();
            Log.Logger.Information("{DataEHora} / {Feature} / Camada: {Camada} / Usuário: {UsuarioLogado}", DateTime.Now, this.ToString(), "Apresentação", TelaPrincipalForm.FuncionarioLogado);
            TelaLocacaoForm tela = new("Locação de Veiculos", servicoAppService, funcionarioAppService, veiculoAppService, clienteAppService, cupomAppService);

            if (tela.ShowDialog() == DialogResult.OK)
            {
                bool resultadoLocacao = locacaoAppService.InserirEntidade(tela.Locacao);

                if (resultadoLocacao)
                {
                    Veiculo veiculoAtualizado = tela.Locacao.Veiculo;
                    veiculoAppService.EditarEntidade(tela.Locacao.Veiculo.Id, veiculoAtualizado);
                    //relacionamento = new RelacionamentoLocServ(0, tela.Locacao, tela.Servicos);
                    //foreach (var item in relacionamento.Servicos)
                    //{
                    //    RelacionamentoLocServ relacionamentoSelecionado = new(0, relacionamento.Locacao, item.Id);
                    //    controladorRelacionamento.InserirNovo(relacionamentoSelecionado);
                    //}
                    conversorPdf.ConverterLocacaoEmPdf(tela.Locacao);

                    try
                    {
                        GerenciadorDeEmail.EnviarEmail("matriquisdevelopers@gmail.com", "matrixadm", tela.Locacao);     //deve ser feita variaveis para tornar email e senha mais acessiveis
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao tentar enviar os dados de locação por e-mail.\nO recibo está salvo na pasta Recibos e deverá ser enviado manualmente assim que possível!!\n" + ex.Message, "Erro ao enviar e-mail");
                    }

                    TelaPrincipalForm.Instancia.AtualizarRodape($"Locação: [{tela.Locacao.Veiculo}] realizada com sucesso");
                }
                else
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Erro ao inserir locação");

                List<Locacao> veiculos = locacaoAppService.SelecionarTodasEntidade();

                tabelaLocacao.AtualizarRegistros(veiculos);
              
            }
        }

        public void EditarRegistro()
        {
            GeradorLog.ConfigurarLog();
            Log.Logger.Information("{DataEHora} / {Feature} / Camada: {Camada} / Usuário: {UsuarioLogado}", DateTime.Now, this.ToString(), "Apresentação", TelaPrincipalForm.FuncionarioLogado);
            int id = tabelaLocacao.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione uma locação para poder editar!", "Edição de locação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Locacao locacaoSelecionada = locacaoAppService.SelecionarEntidadePorId(id);

            TelaLocacaoForm tela = new("Edição de Locação", servicoAppService, funcionarioAppService, veiculoAppService, clienteAppService, cupomAppService);

            tela.Locacao = locacaoSelecionada;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                bool resultado = locacaoAppService.EditarEntidade(id, tela.Locacao);

                List<Locacao> veiculos = locacaoAppService.SelecionarTodasEntidade();

                tabelaLocacao.AtualizarRegistros(veiculos);

                if(resultado)
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Locação de: [{tela.Locacao.ClienteContratante}] editado com sucesso");
                else
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Erro ao editar locação");
            }
        }

        public void ExcluirRegistro()
        {
            GeradorLog.ConfigurarLog();
            Log.Logger.Information("{DataEHora} / {Feature} / Camada: {Camada} / Usuário: {UsuarioLogado}", DateTime.Now, this.ToString(), "Apresentação", TelaPrincipalForm.FuncionarioLogado);
            int id = tabelaLocacao.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione uma locação para poder excluir!", "Exclusão de Locação",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Locacao locacaoSelecionada = locacaoAppService.SelecionarEntidadePorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir a locação: [{locacaoSelecionada.Id}] ?",
                "Exclusão de Locação", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bool resultado = locacaoAppService.ExcluirEntidade(id);

                List<Locacao> veiculos = locacaoAppService.SelecionarTodasEntidade();

                tabelaLocacao.AtualizarRegistros(veiculos);
                if(resultado)
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Locação de: [{locacaoSelecionada.ClienteContratante}] removida com sucesso");
                else
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Erro ao remover locação");
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
            List<Locacao> locacoes = locacaoAppService.SelecionarTodasEntidade();
            tabelaLocacao.AtualizarRegistros(locacoes);

            return tabelaLocacao;
        }
    }
}
