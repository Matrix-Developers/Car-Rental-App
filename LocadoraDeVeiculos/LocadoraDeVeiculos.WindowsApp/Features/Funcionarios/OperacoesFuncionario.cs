using LocadoraDeVeiculos.Aplicacao.FuncionarioModule;
using LocadoraDeVeiculos.Dominio.FuncionarioModule;
using LocadoraDeVeiculos.WindowsApp.Funcionarios;
using LocadoraDeVeiculos.WindowsApp.Shared;
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
            int id = tabelaFuncionarios.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um Funcionário para poder Editar!", "Edição de Funcionários", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Funcionario funcionarioSelecionado = appService.SelecionarFuncionarioPorId(id);
            FuncionarioForm tela = new("Edição de Funcionário");
            tela.Funcionario = funcionarioSelecionado;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                appService.EditarFuncionario(id, tela.Funcionario);
                List<Funcionario> funcionarios = appService.SelecionarTodos();
                tabelaFuncionarios.AtualizarRegistros(funcionarios);
                TelaPrincipalForm.Instancia.AtualizarRodape($"Funcionário: [{funcionarioSelecionado.Nome}] editado com sucesso");
            }
        }

        public void ExcluirRegistro()
        {
            int id = tabelaFuncionarios.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um Funcionário para excluir", "Exclusão de Funcionários", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Funcionario funcionarioSelecionado = appService.SelecionarFuncionarioPorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir o funcionário: [{funcionarioSelecionado.Nome}] ?", "Exclusão de Funcionários", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                appService.ExcluirFuncionario(id);
                List<Funcionario> funcionarios = appService.SelecionarTodos();
                tabelaFuncionarios.AtualizarRegistros(funcionarios);
                TelaPrincipalForm.Instancia.AtualizarRodape($"Funcionário: [{funcionarioSelecionado.Nome}] removido com sucesso");
            }
        }

        public void FiltrarRegistros()
        {
            throw new NotImplementedException();
        }

        public void InserirNovoRegistro()
        {
            FuncionarioForm tela = new("Cadastro de Funcionário");

            if (tela.ShowDialog() == DialogResult.OK)
            {
                appService.InserirNovoFuncionario(tela.Funcionario);
                List<Funcionario> funcionarios = appService.SelecionarTodos();
                tabelaFuncionarios.AtualizarRegistros(funcionarios);
                TelaPrincipalForm.Instancia.AtualizarRodape($"Funcionário: [{tela.Funcionario.Nome}] inserido com sucesso");
            }
        }

        public UserControl ObterTabela()
        {
            List<Funcionario> funcionarios = appService.SelecionarTodos();
            tabelaFuncionarios.AtualizarRegistros(funcionarios);
            return tabelaFuncionarios;
        }
    }
}
