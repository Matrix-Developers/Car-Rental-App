using LocadoraDeVeiculos.Aplicacao.ServicoModule;
using LocadoraDeVeiculos.Dominio.SevicosModule;
using LocadoraDeVeiculos.Infra.Logs;
using LocadoraDeVeiculos.WindowsApp.Shared;
using Serilog;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Features.Servicos
{
    class OperacoesServico : ICadastravel
    {
        private readonly ServicoAppService appService;
        private readonly TabelaServicoControl tabelaServicos = null;

        public OperacoesServico(ServicoAppService servicoAppService)
        {
            appService = servicoAppService;
            tabelaServicos = new TabelaServicoControl();
        }

        public void InserirNovoRegistro()
        {
            Log.Logger.Information("{DataEHora} / {Feature} / Layer: {Layer} / Module: {Modulo} / User: {UsuarioLogado}", DateTime.Now, this.ToString(), "Apresentação", "Inserir",TelaPrincipalForm.FuncionarioLogado);
            TelaServicoForm tela = new("Register Service");

            if (tela.ShowDialog() == DialogResult.OK)
            {
                bool resultado = appService.InserirEntidade(tela.Servico);
                List<Servico> servicos = appService.SelecionarTodasEntidade();
                tabelaServicos.AtualizarRegistros(servicos);
                if(resultado)
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Service: '{tela.Servico.Nome}' inserted sucessfully");
                else
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Unable to Insert Service: '{tela.Servico.Nome}', see the log for more information");
            }
        }

        public void EditarRegistro()
        {
            Log.Logger.Information("{DataEHora} / {Feature} / Layer: {Layer} / Module: {Modulo} / User: {UsuarioLogado}", DateTime.Now, this.ToString(), "Apresentação", "Editar", TelaPrincipalForm.FuncionarioLogado);
            int id = tabelaServicos.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Select at least one Service to Edit.", "Edit Service",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Servico servicoSelecionada = appService.SelecionarEntidadePorId(id);
            TelaServicoForm tela = new("Edit Service");
            tela.Servico = servicoSelecionada;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                bool resultado = appService.EditarEntidade(id, tela.Servico);
                List<Servico> servicos = appService.SelecionarTodasEntidade();
                tabelaServicos.AtualizarRegistros(servicos);                
                if (resultado)
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Service: '{tela.Servico.Nome}' edited sucessfully");
                else
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Unable to Edit Service: [{tela.Servico.Nome}], see the log for more information");
            }
        }

        public void ExcluirRegistro()
        {
            Log.Logger.Information("{DataEHora} / {Feature} / Layer: {Layer} / Module: {Modulo} / User: {UsuarioLogado}", DateTime.Now, this.ToString(), "Apresentação", "Excluir", TelaPrincipalForm.FuncionarioLogado);
            int id = tabelaServicos.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Select at least one service to delete.", "Delete Service",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Servico servicoSelecionada = appService.SelecionarEntidadePorId(id);

            if (MessageBox.Show($"Are you sure you want to Delete Service: '{servicoSelecionada.Nome}' ?",
                "Delete Service", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bool resultado = appService.ExcluirEntidade(id);
                List<Servico> servicos = appService.SelecionarTodasEntidade();
                tabelaServicos.AtualizarRegistros(servicos);
                if (resultado)
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Service: '{servicoSelecionada.Nome}' deleted sucessfully");
                else
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Unable to Delete Service: '{servicoSelecionada.Nome}', verify the log for more information");
            }
        }

        public UserControl ObterTabela()
        {
            Log.Logger.Information("{DataEHora} / {Feature} / Layer: {Layer} / IdUUser: {UsuarioLogado}", DateTime.Now, this.ToString(), "Apresentação", TelaPrincipalForm.FuncionarioLogado);
            
            List<Servico> servicos = appService.SelecionarTodasEntidade();
            tabelaServicos.AtualizarRegistros(servicos);
            return tabelaServicos;
        }

        public void AgruparRegistros()
        {
            throw new NotImplementedException();
        }

        public void FiltrarRegistros()
        {
            throw new NotImplementedException();
        }
    }
}
