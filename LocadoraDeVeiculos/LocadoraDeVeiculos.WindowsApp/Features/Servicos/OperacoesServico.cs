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
            GeradorLog.ConfigurarLog();
            Log.Logger.Information("{DataEHora} / {Feature} / Camada: {Camada} / Módulo: {Modulo} / Usuário: {UsuarioLogado}", DateTime.Now, this.ToString(), "Apresentação", "Inserir",TelaPrincipalForm.FuncionarioLogado);
            TelaServicoForm tela = new("Cadastro de Serviços");

            if (tela.ShowDialog() == DialogResult.OK)
            {
                bool resultado = appService.InserirEntidade(tela.Servico);
                List<Servico> servicos = appService.SelecionarTodasEntidade();
                tabelaServicos.AtualizarRegistros(servicos);
                if(resultado)
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Servico: [{tela.Servico.Nome}] inserido com sucesso");
                else
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Não foi possível inserir o Servico: [{tela.Servico.Nome}], consulte o log para mais informações");
            }
        }

        public void EditarRegistro()
        {
            GeradorLog.ConfigurarLog();
            Log.Logger.Information("{DataEHora} / {Feature} / Camada: {Camada} / Módulo: {Modulo} / Usuário: {UsuarioLogado}", DateTime.Now, this.ToString(), "Apresentação", "Editar", TelaPrincipalForm.FuncionarioLogado);
            int id = tabelaServicos.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um servico para poder editar!", "Edição de Servicos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Servico servicoSelecionada = appService.SelecionarEntidadePorId(id);
            TelaServicoForm tela = new("Edição de Serviços");
            tela.Servico = servicoSelecionada;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                bool resultado = appService.EditarEntidade(id, tela.Servico);
                List<Servico> servicos = appService.SelecionarTodasEntidade();
                tabelaServicos.AtualizarRegistros(servicos);                
                if (resultado)
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Servico: [{tela.Servico.Nome}] editado com sucesso");
                else
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Não foi possível editar o Servico: [{tela.Servico.Nome}], consulte o log para mais informações");
            }
        }

        public void ExcluirRegistro()
        {
            GeradorLog.ConfigurarLog();
            Log.Logger.Information("{DataEHora} / {Feature} / Camada: {Camada} / Módulo: {Modulo} / Usuário: {UsuarioLogado}", DateTime.Now, this.ToString(), "Apresentação", "Excluir", TelaPrincipalForm.FuncionarioLogado);
            int id = tabelaServicos.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione uma servico para poder excluir!", "Exclusão de Servicos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Servico servicoSelecionada = appService.SelecionarEntidadePorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir o servico: [{servicoSelecionada.Nome}] ?",
                "Exclusão de Servicos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bool resultado = appService.ExcluirEntidade(id);
                List<Servico> servicos = appService.SelecionarTodasEntidade();
                tabelaServicos.AtualizarRegistros(servicos);
                if (resultado)
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Servico: [{servicoSelecionada.Nome}] removido com sucesso");
                else
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Não foi possível remover o Serviço: [{servicoSelecionada.Nome}], consulte o log para mais informações");
            }
        }

        public UserControl ObterTabela()
        {
            GeradorLog.ConfigurarLog();
            Log.Logger.Information("{DataEHora} / {Feature} / Camada: {Camada} / IdUUsuário: {UsuarioLogado}", DateTime.Now, this.ToString(), "Apresentação", TelaPrincipalForm.FuncionarioLogado);
            
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
