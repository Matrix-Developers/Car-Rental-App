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
            Log.Logger.Information("{DataEHora} / {Feature} / Camada: {Camada} / Usuário: {UsuarioLogado}", DateTime.Now, this.ToString(), "Apresentação", TelaPrincipalForm.FuncionarioLogado);

            if (id == 0)
            {
                MessageBox.Show("Selecione um registro para realizar a devolução!", "Registrar Devolução",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Locacao locacaoSelecionada = locacaoAppService.SelecionarEntidadePorId(id);

            TelaDevolucaoForm tela = new("Devolução de Veículo", servicoAppService, veiculoAppService);

            tela.Devolucao = locacaoSelecionada;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                locacaoAppService.EditarEntidade(tela.Devolucao.Id, tela.Devolucao);
                List<Locacao> funcionarios = locacaoAppService.SelecionarTodasEntidade();
                tabelaDevolucao.AtualizarRegistros(funcionarios);
                TelaPrincipalForm.Instancia.AtualizarRodape($"Devolução: [{tela.Devolucao.Id}] realizada com sucesso");
            }
        }

        public void EditarRegistro()
        {
            MessageBox.Show("Não é possivel editar uma devolução encerrada!! \nPara editar uma locação em aberta, vá ao menu Locação");
        }

        public void ExcluirRegistro()
        {
            Log.Logger.Information("{DataEHora} / {Feature} / Camada: {Camada} / Usuário: {UsuarioLogado}", DateTime.Now, this.ToString(), "Apresentação", TelaPrincipalForm.FuncionarioLogado);
            int id = tabelaDevolucao.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um registro de Devolução para poder excluir!", "Exclusão de Registro",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Locacao locacaoSelecionada = locacaoAppService.SelecionarEntidadePorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir todo o registro da locação e devolução: [{locacaoSelecionada.Id}] ?",
                "Exclusão de Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                locacaoAppService.ExcluirEntidade(id);

                List<Locacao> veiculos = locacaoAppService.SelecionarTodasEntidade();

                tabelaDevolucao.AtualizarRegistros(veiculos);

                TelaPrincipalForm.Instancia.AtualizarRodape($"Registro de: [{locacaoSelecionada.ClienteContratante}] removida com sucesso");
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
                            tipoLocacao = "pendente(s)";
                            break;
                        }

                    case FiltroDevolucaoEnum.DevolucoesFinalizadas:
                        {
                            List<Locacao> filtro = new();
                            foreach (Locacao devolucao in devolucoes)
                                if (!devolucao.EstaAberta)
                                    filtro.Add(devolucao);
                            devolucoes = filtro;
                            tipoLocacao = "concluída(s)";
                            break;
                        }

                    default:
                        break;
                }

                tabelaDevolucao.AtualizarRegistros(devolucoes);
                TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {devolucoes.Count} devolucao(s) {tipoLocacao}");
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
