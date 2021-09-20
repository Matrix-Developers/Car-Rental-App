using LocadoraDeVeiculos.Aplicacao.ServicoModule;
using LocadoraDeVeiculos.Controladores.LocacaoModule;
using LocadoraDeVeiculos.Controladores.ServicoModule;
using LocadoraDeVeiculos.Dominio.LocacaoModule;
using LocadoraDeVeiculos.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Features.Devolucoes
{
    public class OperacoesDevolucao : ICadastravel
    {
        private readonly LocacaoRepository controlador = null;
        private readonly TabelaDevolucaoControl tabelaDevolucao = null;
        public OperacoesDevolucao(LocacaoRepository ctrlDevolucao)
        {
            controlador = ctrlDevolucao;
            tabelaDevolucao = new TabelaDevolucaoControl();
        }
        public void InserirNovoRegistro()
        {
            int id = tabelaDevolucao.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um registro para realizar a devolução!", "Registrar Devolução",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Locacao locacaoSelecionada = controlador.SelecionarPorId(id);

            ServicoAppService servicoAppService = new(new ServicoRepository());     //talvez pode mudar o lugar onde é instanciado. construtor?
            TelaDevolucaoForm tela = new("Devolução de Veículo",servicoAppService);

            tela.Devolucao = locacaoSelecionada;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.Editar(tela.Devolucao.Id, tela.Devolucao);
                List<Locacao> funcionarios = controlador.SelecionarTodos();
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
            int id = tabelaDevolucao.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um registro de Devolução para poder excluir!", "Exclusão de Registro",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Locacao locacaoSelecionada = controlador.SelecionarPorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir todo o registro da locação e devolução: [{locacaoSelecionada.Id}] ?",
                "Exclusão de Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                controlador.Excluir(id);

                List<Locacao> veiculos = controlador.SelecionarTodos();

                tabelaDevolucao.AtualizarRegistros(veiculos);

                TelaPrincipalForm.Instancia.AtualizarRodape($"Registro de: [{locacaoSelecionada.ClienteContratante}] removida com sucesso");
            }
        }

        public void FiltrarRegistros()
        {
            FiltroDevolucaoForm telaFiltro = new();

            if (telaFiltro.ShowDialog() == DialogResult.OK)
            {
                List<Locacao> devolucoes = controlador.SelecionarTodos();
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
            List<Locacao> locacoes = controlador.SelecionarTodos();

            tabelaDevolucao.AtualizarRegistros(locacoes);

            return tabelaDevolucao;
        }
    }
}
