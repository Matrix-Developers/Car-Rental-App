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
        private readonly ControladorFuncionario controlador = null;
        private readonly TabelaFuncionarioControl tabelaFuncionarios = null;

        public OperacoesFuncionario(ControladorFuncionario ctrlFuncionario)
        {
            controlador = ctrlFuncionario;
            tabelaFuncionarios = new TabelaFuncionarioControl();
        }

        public void AgruparRegistros()
        {
            
        }

        public void EditarRegistro()
        {
            
        }

        public void ExcluirRegistro()
        {
            
        }

        public void FiltrarRegistros()
        {
            
        }

        public void InserirNovoRegistro()
        {
            FuncionarioForm tela = new FuncionarioForm();

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
