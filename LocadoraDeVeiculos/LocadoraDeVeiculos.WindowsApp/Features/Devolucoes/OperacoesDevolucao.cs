using LocadoraDeVeiculos.Aplicacao.LocacaoModule;
using LocadoraDeVeiculos.Aplicacao.ServicoModule;
using LocadoraDeVeiculos.Aplicacao.VeiculoModule;
using LocadoraDeVeiculos.Dominio.LocacaoModule;
using LocadoraDeVeiculos.Infra.Logs;
using LocadoraDeVeiculos.WindowsApp.Shared;
using Serilog;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Features.Devolucoes
{
    public class OperacoesDevolucao : ICadastravel
    {
        private readonly LocacaoAppService locacaoAppService;
        private readonly ServicoAppService servicoAppService;
        private readonly VeiculoAppService veiculoAppService;

        private readonly TabelaDevolucaoControl tabelaDevolucao = null;
        public OperacoesDevolucao(LocacaoAppService locacaoAppService, ServicoAppService servicoAppService, VeiculoAppService veiculoAppService)
        {
            this.locacaoAppService = locacaoAppService;
            this.servicoAppService = servicoAppService;
            this.veiculoAppService = veiculoAppService;
            tabelaDevolucao = new TabelaDevolucaoControl();
        }
        public void InserirNovoRegistro()
        {
            int id = tabelaDevolucao.ObtemIdSelecionado();
            Log.Logger.Information("{DataEHora} / {Feature} / Layer: {Layer} / User: {UsuarioLogado}", DateTime.Now, this.ToString(), "Apresentação", TelaPrincipalForm.FuncionarioLogado);

            if (id == 0)
            {
                MessageBox.Show("Select at least one Rental to register the Devolution.", "Register Devolution",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Locacao locacaoSelecionada = locacaoAppService.SelecionarEntidadePorId(id);

            TelaDevolucaoForm tela = new("Vehicle Devolution", servicoAppService, veiculoAppService);

            tela.Devolucao = locacaoSelecionada;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                locacaoAppService.EditarEntidade(tela.Devolucao.Id, tela.Devolucao);
                List<Locacao> funcionarios = locacaoAppService.SelecionarTodasEntidade();
                tabelaDevolucao.AtualizarRegistros(funcionarios);
                TelaPrincipalForm.Instancia.AtualizarRodape($"Devolution: '{tela.Devolucao.Id}' carried out successfully.");
            }
        }

        public void EditarRegistro()
        {
            MessageBox.Show("It is not possible to edit a closed Devolution. \nTo edit an open Rental, go to the Rental menu");
        }

        public void ExcluirRegistro()
        {
            Log.Logger.Information("{DataEHora} / {Feature} / Layer: {Layer} / User: {UsuarioLogado}", DateTime.Now, this.ToString(), "Apresentação", TelaPrincipalForm.FuncionarioLogado);
            int id = tabelaDevolucao.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Select at least one Devolution to be able to delete.", "Delete Devolution",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Locacao locacaoSelecionada = locacaoAppService.SelecionarEntidadePorId(id);

            if (MessageBox.Show($"Are you sure you want to delete the entire Rental and Devolution record of '{locacaoSelecionada.Id}' ?",
                "Exclusão de Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                locacaoAppService.ExcluirEntidade(id);

                List<Locacao> veiculos = locacaoAppService.SelecionarTodasEntidade();

                tabelaDevolucao.AtualizarRegistros(veiculos);

                TelaPrincipalForm.Instancia.AtualizarRodape($"Rental: '{locacaoSelecionada.ClienteContratante}' deleted sucessfully.");
            }
        }

        public void FiltrarRegistros()
        {
            FiltroDevolucaoForm telaFiltro = new();

            if (telaFiltro.ShowDialog() == DialogResult.OK)
            {
                List<Locacao> devolucoes = locacaoAppService.SelecionarTodasEntidade();
                string tipoLocacao = "";

                switch (telaFiltro.TipoFiltro)
                {
                    case FiltroDevolucaoEnum.TodasDevolucoes:
                        break;

                    case FiltroDevolucaoEnum.DevolucoesPendentes:
                        {
                            List<Locacao> filtro = new();
                            foreach (Locacao devolucao in devolucoes)
                                if (devolucao.EstaAberta)
                                    filtro.Add(devolucao);
                            devolucoes = filtro;
                            tipoLocacao = "pending";
                            break;
                        }

                    case FiltroDevolucaoEnum.DevolucoesFinalizadas:
                        {
                            List<Locacao> filtro = new();
                            foreach (Locacao devolucao in devolucoes)
                                if (!devolucao.EstaAberta)
                                    filtro.Add(devolucao);
                            devolucoes = filtro;
                            tipoLocacao = "concluded";
                            break;
                        }

                    default:
                        break;
                }

                tabelaDevolucao.AtualizarRegistros(devolucoes);
                TelaPrincipalForm.Instancia.AtualizarRodape($"Viewing {devolucoes.Count} {tipoLocacao} devolutions.");
            }
        }

        public void AgruparRegistros()
        {
            throw new NotImplementedException();
        }

        public UserControl ObterTabela()
        {
            List<Locacao> locacoes = locacaoAppService.SelecionarTodasEntidade();

            tabelaDevolucao.AtualizarRegistros(locacoes);

            return tabelaDevolucao;
        }
    }
}
