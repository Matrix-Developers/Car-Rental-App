using LocadoraDeVeiculos.Aplicacao.FuncionarioModule;
using LocadoraDeVeiculos.Dominio.FuncionarioModule;
using LocadoraDeVeiculos.Infra.Logs;
using LocadoraDeVeiculos.WindowsApp.Funcionarios;
using LocadoraDeVeiculos.WindowsApp.Shared;
using Serilog;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Features.Funcionarios
{
    public class OperacoesFuncionario : ICadastravel
    {
        private readonly FuncionarioAppService appService;
        private readonly TabelaFuncionarioControl tabelaFuncionarios;

        public OperacoesFuncionario(FuncionarioAppService funcionarioAppService)
        {
            appService = funcionarioAppService;
            tabelaFuncionarios = new TabelaFuncionarioControl();
        }

        public void AgruparRegistros()
        {
            throw new NotImplementedException();
        }

        public void EditarRegistro()
        {
            GeradorLog.ConfigurarLog();
            Log.Logger.Information("{DataEHora} / {Feature} / Camada: {Camada} / Usuário: {UsuarioLogado}", DateTime.Now, this.ToString(), "Apresentação", TelaPrincipalForm.FuncionarioLogado);
            int id = tabelaFuncionarios.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um Funcionário para poder Editar!", "Edição de Funcionários", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Funcionario funcionarioSelecionado = appService.SelecionarEntidadePorId(id);
            FuncionarioForm tela = new("Edição de Funcionário");
            tela.Funcionario = funcionarioSelecionado;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                bool resultado = appService.EditarEntidade(id, tela.Funcionario);
                List<Funcionario> funcionarios = appService.SelecionarTodasEntidade();
                tabelaFuncionarios.AtualizarRegistros(funcionarios);
                if(resultado)
                      TelaPrincipalForm.Instancia.AtualizarRodape($"Funcionário: [{funcionarioSelecionado.Nome}] editado com sucesso");
                else
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Não foi possível excluir o Funcionário: [{funcionarioSelecionado.Nome}], consulte o log para mais informações");

            }
        }

        public void ExcluirRegistro()
        {
            GeradorLog.ConfigurarLog();
            Log.Logger.Information("{DataEHora} / {Feature} / Camada: {Camada} / Usuário: {UsuarioLogado}", DateTime.Now, this.ToString(), "Apresentação", TelaPrincipalForm.FuncionarioLogado);
            int id = tabelaFuncionarios.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um Funcionário para excluir", "Exclusão de Funcionários", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Funcionario funcionarioSelecionado = appService.SelecionarEntidadePorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir o funcionário: [{funcionarioSelecionado.Nome}] ?", "Exclusão de Funcionários", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                bool resultado = appService.ExcluirEntidade(id);
                List<Funcionario> funcionarios = appService.SelecionarTodasEntidade();
                tabelaFuncionarios.AtualizarRegistros(funcionarios);
                if(resultado)
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Funcionário: [{funcionarioSelecionado.Nome}] removido com sucesso");
                else
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Não foi possível excluir o Funcionário: [{funcionarioSelecionado.Nome}], consulte o log para mais informações");

            }
        }

        public void FiltrarRegistros()
        {
            throw new NotImplementedException();
        }

        public void InserirNovoRegistro()
        {
            GeradorLog.ConfigurarLog();
            Log.Logger.Information("{DataEHora} / {Feature} / Camada: {Camada} / Usuário: {UsuarioLogado}", DateTime.Now, this.ToString(), "Apresentação", TelaPrincipalForm.FuncionarioLogado);
            FuncionarioForm tela = new("Cadastro de Funcionário");

            if (tela.ShowDialog() == DialogResult.OK)
            {
                bool resultado = appService.InserirEntidade(tela.Funcionario);
                List<Funcionario> funcionarios = appService.SelecionarTodasEntidade();
                tabelaFuncionarios.AtualizarRegistros(funcionarios);
                if(resultado)                   
                     TelaPrincipalForm.Instancia.AtualizarRodape($"Funcionário: [{tela.Funcionario.Nome}] inserido com sucesso");
                else
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Não foi possível inserir o Funcionário: [{tela.Funcionario.Nome}], consulte o log para mais informações");
            }
        }

        public UserControl ObterTabela()
        {
            List<Funcionario> funcionarios = appService.SelecionarTodasEntidade();
            tabelaFuncionarios.AtualizarRegistros(funcionarios);
            return tabelaFuncionarios;
        }
    }
}
