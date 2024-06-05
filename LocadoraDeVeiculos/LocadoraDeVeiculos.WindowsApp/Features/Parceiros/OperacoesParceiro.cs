using LocadoraDeVeiculos.Aplicacao.ParceiroModule;
using LocadoraDeVeiculos.Dominio.ParceiroModule;
using LocadoraDeVeiculos.Infra.Logs;
using LocadoraDeVeiculos.WindowsApp.Shared;
using Serilog;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Features.Parceiros
{
    public class OperacoesParceiro : ICadastravel
    {
        private readonly ParceiroAppService appService;
        private readonly TabelaParceiroControl tabela;

        public OperacoesParceiro(ParceiroAppService parceiroAppService)
        {
            appService = parceiroAppService;
            tabela = new TabelaParceiroControl();
        }

        public void InserirNovoRegistro()
        {
            Log.Logger.Information("{DataEHora} / {Feature} / Layer: {Layer} / Module: {Modulo} / User: {UsuarioLogado}", DateTime.Now, this.ToString(), "Apresentação", "Inserir", TelaPrincipalForm.FuncionarioLogado);
            TelaParceiroForm tela = new("Register Partner");

            if (tela.ShowDialog() == DialogResult.OK)
            {
                bool resultado = appService.InserirEntidade(tela.Parceiro);
                List<Parceiro> parceiros = appService.SelecionarTodasEntidade();
                tabela.AtualizarRegistros(parceiros);
                if(resultado)
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Partner: '{tela.Parceiro.Nome}' inserted sucessfully");
                else
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Unable to insert Partner: '{tela.Parceiro.Nome}', see the log for more information");
            }
        }

        public void EditarRegistro()
        {
            Log.Logger.Information("{DataEHora} / {Feature} / Layer: {Layer} / Module: {Modulo} / User: {UsuarioLogado}", DateTime.Now, this.ToString(), "Apresentação", "Editar", TelaPrincipalForm.FuncionarioLogado);
            int id = tabela.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Select at least one partner to Edit.", "Edit Partner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Parceiro parceiroSelecionado = appService.SelecionarEntidadePorId(id);
            TelaParceiroForm tela = new("Edit Partner");
            tela.Parceiro = parceiroSelecionado;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                bool resultado = appService.EditarEntidade(id, tela.Parceiro);
                List<Parceiro> parceiros = appService.SelecionarTodasEntidade();
                tabela.AtualizarRegistros(parceiros);
                if (resultado)
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Partner: '{parceiroSelecionado.Nome}' edited sucessfully.");
                else
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Unable to Edit Partner: '{parceiroSelecionado.Nome}', see the log for more information.");
            }
        }

        public void ExcluirRegistro()
        {
            Log.Logger.Information("{DataEHora} / {Feature} / Layer: {Layer} / Module: {Modulo} / User: {UsuarioLogado}", DateTime.Now, this.ToString(), "Apresentação", "Excluir", TelaPrincipalForm.FuncionarioLogado);
            int id = tabela.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Select at least one Partner to Delete.", "Delete Partner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Parceiro parceiroSelecionado = appService.SelecionarEntidadePorId(id);

            if (MessageBox.Show($"Are you sure you want to Delete Partner: '{parceiroSelecionado.Nome}' ?","Delete Partner", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                bool resultado = appService.ExcluirEntidade(id);
                List<Parceiro> parceiros = appService.SelecionarTodasEntidade();
                tabela.AtualizarRegistros(parceiros);
                if (resultado)
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Partner: '{parceiroSelecionado.Nome}' deleted sucessfully");
                else
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Unable to Delete Partner: '{parceiroSelecionado.Nome}', see the log for more information");
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
            Log.Logger.Information("{DataEHora} / {Feature} / Layer: {Layer} / User: {UsuarioLogado}", DateTime.Now, this.ToString(), "Apresentação", TelaPrincipalForm.FuncionarioLogado);

            List<Parceiro> cupons = appService.SelecionarTodasEntidade();
            tabela.AtualizarRegistros(cupons);
            return tabela;
        }
    }
}
