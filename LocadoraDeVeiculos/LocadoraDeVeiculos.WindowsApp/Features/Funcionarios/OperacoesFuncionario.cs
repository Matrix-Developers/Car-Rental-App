using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocadoraDeVeiculos.Controladores.FuncionarioModule;
using LocadoraDeVeiculos.Dominio.FuncionarioModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Dominio.PessoaModule;
using LocadoraDeVeiculos.Controladores.Shared;
using LocadoraDeVeiculos.WindowsApp.Shared;
using LocadoraDeVeiculos.WindowsApp.Funcionarios;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Features.Funcionarios
{
    public class OperacoesFuncionario : ICadastravel
    {
        private readonly FuncionarioRepository controlador = null;
        private readonly TabelaFuncionarioControl tabelaFuncionarios = null;

        public OperacoesFuncionario(FuncionarioRepository ctrlFuncionario)
        {
            controlador = ctrlFuncionario;
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
                MessageBox.Show("Selecione um Funcionário para poder Editar!","Edição de Funcionários",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }

            Funcionario funcionarioSelecionado = controlador.SelecionarPorId(id);
            FuncionarioForm tela = new FuncionarioForm("Edição de Funcionário");
            tela.Funcionario = funcionarioSelecionado;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.Editar(id, tela.Funcionario);
                List<Funcionario> funcionarios = controlador.SelecionarTodos();
                tabelaFuncionarios.AtualizarRegistros(funcionarios);
                TelaPrincipalForm.Instancia.AtualizarRodape($"Funcionário: [{funcionarioSelecionado.Nome}] editado com sucesso");
            }

        }

        public void ExcluirRegistro()
        {
            int id = tabelaFuncionarios.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um Funcionário para excluir","Exclusão de Funcionários",MessageBoxButtons.OK , MessageBoxIcon.Exclamation);
                return;
            }

            Funcionario funcionarioSelecionado = controlador.SelecionarPorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir o funcionário: [{funcionarioSelecionado.Nome}] ?", "Exclusão de Funcionários", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                controlador.Excluir(id);
                List<Funcionario> funcionarios = controlador.SelecionarTodos();
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
            FuncionarioForm tela = new FuncionarioForm("Cadastro de Funcionário");           

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.InserirNovo(tela.Funcionario);
                List<Funcionario> funcionarios = controlador.SelecionarTodos();
                tabelaFuncionarios.AtualizarRegistros(funcionarios);
                TelaPrincipalForm.Instancia.AtualizarRodape($"Funcionário: [{tela.Funcionario.Nome}] inserido com sucesso");
            }
        }

        public UserControl ObterTabela()
        {
            List<Funcionario> funcionarios = controlador.SelecionarTodos();
            tabelaFuncionarios.AtualizarRegistros(funcionarios);
            return tabelaFuncionarios;
        }
    }
}
