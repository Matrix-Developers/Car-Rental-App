using LocadoraDeVeiculos.Aplicacao.VeiculoModule;
using LocadoraDeVeiculos.Dominio.VeiculoModule;
using LocadoraDeVeiculos.Infra.Logs;
using LocadoraDeVeiculos.WindowsApp.Shared;
using LocadoraDeVeiculos.WindowsApp.Veiculos;
using Serilog;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Features.Veiculos
{
    public class OperacoesVeiculo : ICadastravel
    {
        private readonly VeiculoAppService veiculoAppService;
        private readonly TabelaVeiculoControl tabelaVeiculo;
        public OperacoesVeiculo(VeiculoAppService VeiculoAppService)
        {
            veiculoAppService = VeiculoAppService;
            tabelaVeiculo = new TabelaVeiculoControl();
        }
        public void InserirNovoRegistro()
        {
            GeradorLog.ConfigurarLog();
            Log.Logger.Information("{DataEHora} / {Feature} / Camada: {Camada} / Módulo: {Modulo} / Usuário: {UsuarioLogado}", DateTime.Now, this.ToString(), "Apresentação", "Inserir", TelaPrincipalForm.FuncionarioLogado);
            VeiculoForm tela = new("Cadastro de Veiculos");

            if (tela.ShowDialog() == DialogResult.OK)
            {
                if (tela.Veiculo.imagens.Count != 0)
                    foreach (Dominio.ImagemVeiculoModule.ImagemVeiculo imagem in tela.Veiculo.imagens)
                        imagem.idVeiculo = tela.Veiculo.id;

                bool resultado = veiculoAppService.InserirEntidade(tela.Veiculo);

                List<Veiculo> veiculos = veiculoAppService.SelecionarTodasEntidade();

                tabelaVeiculo.AtualizarRegistros(veiculos);
                if (resultado)
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Veiculo: [{tela.Veiculo.modelo}] inserido com sucesso");
                else
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Não foi possível inserir o Veiculo: [{tela.Veiculo.modelo}], consulte o log para mais informações");
            }
        }
        public void EditarRegistro()
        {
            GeradorLog.ConfigurarLog();
            Log.Logger.Information("{DataEHora} / {Feature} / Camada: {Camada} / Módulo: {Modulo} / Usuário: {UsuarioLogado}", DateTime.Now, this.ToString(), "Apresentação", "Editar", TelaPrincipalForm.FuncionarioLogado);
            int id = tabelaVeiculo.ObtemidSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um veiculo para poder editar!", "Edição de Veiculos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Veiculo tarefaSelecionada = veiculoAppService.SelecionarEntidadePorId(id);

            VeiculoForm tela = new("Edição de Veiculos");

            tela.Veiculo = tarefaSelecionada;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                bool resultado = veiculoAppService.EditarEntidade(id, tela.Veiculo);

                List<Veiculo> veiculos = veiculoAppService.SelecionarTodasEntidade();

                tabelaVeiculo.AtualizarRegistros(veiculos);

                if (resultado)
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Veiculo: [{tela.Veiculo.modelo}] editado com sucesso");
                else
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Não foi possível editar o Veiculo: [{tela.Veiculo.modelo}], consulte o log para mais informações");
            }
        }
        public void ExcluirRegistro()
        {
            GeradorLog.ConfigurarLog();
            Log.Logger.Information("{DataEHora} / {Feature} / Camada: {Camada} / Módulo: {Modulo} / Usuário: {UsuarioLogado}", DateTime.Now, this.ToString(), "Apresentação", "Excluir", TelaPrincipalForm.FuncionarioLogado);
            int id = tabelaVeiculo.ObtemidSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um veiculo para poder excluir!", "Exclusão de Veiculos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Veiculo tarefaSelecionada = veiculoAppService.SelecionarEntidadePorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir o veículo: [{tarefaSelecionada.modelo}] ?",
                "Exclusão de Veiculos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bool resultado = veiculoAppService.ExcluirEntidade(id);

                List<Veiculo> veiculos = veiculoAppService.SelecionarTodasEntidade();

                tabelaVeiculo.AtualizarRegistros(veiculos);

                if (resultado)
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Veiculo: [{tarefaSelecionada.modelo}] removido com sucesso");
                else
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Não foi possível remover o Veiculo: [{tarefaSelecionada.modelo}], consulte o log para mais informações");
            }
        }
        public void FiltrarRegistros()
        {
            throw new System.NotImplementedException();
        }
        public UserControl ObterTabela()
        {
            GeradorLog.ConfigurarLog();
            Log.Logger.Information("{DataEHora} / {Feature} / Camada: {Camada} / Módulo: {Modulo} / Usuário: {UsuarioLogado}", DateTime.Now, this.ToString(), "Apresentação", TelaPrincipalForm.FuncionarioLogado);
            List<Veiculo> veiculos = veiculoAppService.SelecionarTodasEntidade();

            tabelaVeiculo.AtualizarRegistros(veiculos);

            return tabelaVeiculo;
        }
        public void AgruparRegistros()
        {
            throw new System.NotImplementedException();
        }
    }
}
