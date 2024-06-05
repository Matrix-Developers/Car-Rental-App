using LocadoraDeVeiculos.Aplicacao.GrupoDeVeiculosModule;
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
        private readonly GrupoDeVeiculosAppService grupoDeVeiculosAppService;
        public OperacoesVeiculo(VeiculoAppService VeiculoAppService, GrupoDeVeiculosAppService grupoDeVeiculosAppService)
        {
            veiculoAppService = VeiculoAppService;
            tabelaVeiculo = new TabelaVeiculoControl();
            this.grupoDeVeiculosAppService = grupoDeVeiculosAppService;
        }
        public void InserirNovoRegistro()
        {
            Log.Logger.Information("{DataEHora} / {Feature} / Layer: {Layer} / Module: {Modulo} / User: {UsuarioLogado}", DateTime.Now, this.ToString(), "Apresentação", "Inserir", TelaPrincipalForm.FuncionarioLogado);
            VeiculoForm tela = new("Register Vehicle", grupoDeVeiculosAppService);

            if (tela.ShowDialog() == DialogResult.OK)
            {
                bool resultado = veiculoAppService.InserirEntidade(tela.Veiculo);

                List<Veiculo> veiculos = veiculoAppService.SelecionarTodasEntidade();

                tabelaVeiculo.AtualizarRegistros(veiculos);
                if (resultado)
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Vehicle: '{tela.Veiculo.modelo}' inserted saucessfully");
                else
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Unable to insert Vehicle: '{tela.Veiculo.modelo}', see the log for more information.");
            }
        }
        public void EditarRegistro()
        {
            Log.Logger.Information("{DataEHora} / {Feature} / Layer: {Layer} / Module: {Modulo} / User: {UsuarioLogado}", DateTime.Now, this.ToString(), "Apresentação", "Editar", TelaPrincipalForm.FuncionarioLogado);
            int id = tabelaVeiculo.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Select at least one vehicle to Edit", "Edit Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Veiculo tarefaSelecionada = veiculoAppService.SelecionarEntidadePorId(id);

            VeiculoForm tela = new("Edit Vehicle", grupoDeVeiculosAppService);

            tela.Veiculo = tarefaSelecionada;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                bool resultado = veiculoAppService.EditarEntidade(id, tela.Veiculo);

                List<Veiculo> veiculos = veiculoAppService.SelecionarTodasEntidade();

                tabelaVeiculo.AtualizarRegistros(veiculos);

                if (resultado)
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Vehicle: '{tela.Veiculo.modelo}' edited sucessfully");
                else
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Unable to Edit Vehicle: '{tela.Veiculo.modelo}', see the log for more information.");
            }
        }
        public void ExcluirRegistro()
        {
            Log.Logger.Information("{DataEHora} / {Feature} / Layer: {Layer} / Module: {Modulo} / User: {UsuarioLogado}", DateTime.Now, this.ToString(), "Apresentação", "Excluir", TelaPrincipalForm.FuncionarioLogado);
            int id = tabelaVeiculo.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Select at least one Vehicle to Delete.", "Delete Vehicle",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Veiculo tarefaSelecionada = veiculoAppService.SelecionarEntidadePorId(id);

            if (MessageBox.Show($"Are you sure you want to Delete the Vehicle: '{tarefaSelecionada.modelo}' ?",
                "Delete Vehicle", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bool resultado = veiculoAppService.ExcluirEntidade(id);

                List<Veiculo> veiculos = veiculoAppService.SelecionarTodasEntidade();

                tabelaVeiculo.AtualizarRegistros(veiculos);

                if (resultado)
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Vehicle: '{tarefaSelecionada.modelo}' deleted sucessfully");
                else
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Unable to delete Vehicle: '{tarefaSelecionada.modelo}'. Vehicle is already rented or unexpected problem occurred, see the log for more information.");
            }
        }
        public void FiltrarRegistros()
        {
            throw new System.NotImplementedException();
        }
        public UserControl ObterTabela()
        {
            Log.Logger.Information("{DataEHora} / {Feature} / Layer: {Layer} / Module: {Modulo} / User: {UsuarioLogado}", DateTime.Now, this.ToString(), "Apresentação", TelaPrincipalForm.FuncionarioLogado);
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
