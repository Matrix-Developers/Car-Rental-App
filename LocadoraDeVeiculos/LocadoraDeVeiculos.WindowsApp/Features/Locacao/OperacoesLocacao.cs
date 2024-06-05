using LocadoraDeVeiculos.Aplicacao.ClienteModule;
using LocadoraDeVeiculos.Aplicacao.CupomModule;
using LocadoraDeVeiculos.Aplicacao.FuncionarioModule;
using LocadoraDeVeiculos.Aplicacao.LocacaoModule;
using LocadoraDeVeiculos.Aplicacao.ServicoModule;
using LocadoraDeVeiculos.Aplicacao.VeiculoModule;
using LocadoraDeVeiculos.Controladores.Shared;
using LocadoraDeVeiculos.Dominio.LocacaoModule;
using LocadoraDeVeiculos.Dominio.VeiculoModule;
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
            Log.Logger.Information("{DataEHora} / {Feature} / Layer: {Layer} / User: {UsuarioLogado}", DateTime.Now, this.ToString(), "Apresentação", TelaPrincipalForm.FuncionarioLogado);
            TelaLocacaoForm tela = new("Vehicle Rental", servicoAppService, funcionarioAppService, veiculoAppService, clienteAppService, cupomAppService);

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

                    TelaPrincipalForm.Instancia.AtualizarRodape($"Rental: '{tela.Locacao.Veiculo}' made successfully");
                }
                else
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Error trying to create Rental");

                List<Locacao> veiculos = locacaoAppService.SelecionarTodasEntidade();

                tabelaLocacao.AtualizarRegistros(veiculos);
              
            }
        }

        public void EditarRegistro()
        {
            Log.Logger.Information("{DataEHora} / {Feature} / Layer: {Layer} / User: {UsuarioLogado}", DateTime.Now, this.ToString(), "Apresentação", TelaPrincipalForm.FuncionarioLogado);
            int id = tabelaLocacao.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Select at least one rental to Edit", "Rental Edit", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Locacao locacaoSelecionada = locacaoAppService.SelecionarEntidadePorId(id);

            TelaLocacaoForm tela = new("Edit Rental", servicoAppService, funcionarioAppService, veiculoAppService, clienteAppService, cupomAppService);

            tela.Locacao = locacaoSelecionada;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                bool resultado = locacaoAppService.EditarEntidade(id, tela.Locacao);

                List<Locacao> veiculos = locacaoAppService.SelecionarTodasEntidade();

                tabelaLocacao.AtualizarRegistros(veiculos);

                if(resultado)
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Rental: '{tela.Locacao.ClienteContratante}' edited sucessfully");
                else
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Erro ao editar locação");
            }
        }

        public void ExcluirRegistro()
        {
            Log.Logger.Information("{DataEHora} / {Feature} / Layer: {Layer} / User: {UsuarioLogado}", DateTime.Now, this.ToString(), "Apresentação", TelaPrincipalForm.FuncionarioLogado);
            int id = tabelaLocacao.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Select at least one Rental to Delete.", "Delete Rental",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Locacao locacaoSelecionada = locacaoAppService.SelecionarEntidadePorId(id);

            if (MessageBox.Show($"Are you sure you want to Delete the Rental: '{locacaoSelecionada.Id}' ?",
                "Delete Rental", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bool resultado = locacaoAppService.ExcluirEntidade(id);

                List<Locacao> veiculos = locacaoAppService.SelecionarTodasEntidade();

                tabelaLocacao.AtualizarRegistros(veiculos);
                if(resultado)
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Rental of: '{locacaoSelecionada.ClienteContratante}' deleted sucessfully");
                else
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Error when deleting rental");
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
