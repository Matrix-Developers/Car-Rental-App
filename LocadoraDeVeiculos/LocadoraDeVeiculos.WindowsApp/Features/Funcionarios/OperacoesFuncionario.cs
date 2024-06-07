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
            Log.Logger.Information("{DataEHora} / {Feature} / Layer: {Layer} / User: {UsuarioLogado}", DateTime.Now, this.ToString(), "Apresentação", TelaPrincipalForm.FuncionarioLogado);
            int id = tabelaFuncionarios.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Select at least one Employee to Edit.", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Funcionario funcionarioSelecionado = appService.SelecionarEntidadePorId(id);
            FuncionarioForm tela = new("Edit Employee");
            tela.Funcionario = funcionarioSelecionado;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                bool resultado = appService.EditarEntidade(id, tela.Funcionario);
                List<Funcionario> funcionarios = appService.SelecionarTodasEntidade();
                tabelaFuncionarios.AtualizarRegistros(funcionarios);
                if(resultado)
                      TelaPrincipalForm.Instancia.AtualizarRodape($"Employee: '{funcionarioSelecionado.Nome}' edited sucessfully.");
                else
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Unable to delete Employee: '{funcionarioSelecionado.Nome}', see the log for more information");

            }
        }

        public void ExcluirRegistro()
        {
            Log.Logger.Information("{DataEHora} / {Feature} / Layer: {Layer} / User: {UsuarioLogado}", DateTime.Now, this.ToString(), "Apresentação", TelaPrincipalForm.FuncionarioLogado);
            int id = tabelaFuncionarios.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Select at least one Employee to Delete.", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Funcionario funcionarioSelecionado = appService.SelecionarEntidadePorId(id);

            if (MessageBox.Show($"Are you sure you want to delete the employee: '{funcionarioSelecionado.Nome}' ?", "Delete Employee", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                bool resultado = appService.ExcluirEntidade(id);
                List<Funcionario> funcionarios = appService.SelecionarTodasEntidade();
                tabelaFuncionarios.AtualizarRegistros(funcionarios);
                if(resultado)
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Employee: '{funcionarioSelecionado.Nome}' deleted sucessfully.");
                else
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Unable to delete Employee: '{funcionarioSelecionado.Nome}', see the log for more information");

            }
        }

        public void FiltrarRegistros()
        {
            throw new NotImplementedException();
        }

        public void InserirNovoRegistro()
        {
            Log.Logger.Information("{DataEHora} / {Feature} / Layer: {Layer} / User: {UsuarioLogado}", DateTime.Now, this.ToString(), "Apresentação", TelaPrincipalForm.FuncionarioLogado);
            FuncionarioForm tela = new("Register Employee");

            if (tela.ShowDialog() == DialogResult.OK)
            {
                bool resultado = appService.InserirEntidade(tela.Funcionario);
                List<Funcionario> funcionarios = appService.SelecionarTodasEntidade();
                tabelaFuncionarios.AtualizarRegistros(funcionarios);
                if(resultado)                   
                     TelaPrincipalForm.Instancia.AtualizarRodape($"Employee: '{tela.Funcionario.Nome}' inserted sucessfully");
                else
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Unable to insert Employee: '{tela.Funcionario.Nome}', see the log for more information");
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
