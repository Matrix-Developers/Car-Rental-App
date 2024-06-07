using LocadoraDeVeiculos.Dominio.FuncionarioModule;
using LocadoraDeVeiculos.WindowsApp.Shared;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Features.Funcionarios
{
    public partial class TabelaFuncionarioControl : UserControl
    {
        public TabelaFuncionarioControl()
        {
            InitializeComponent();
            gridFuncionarios.ConfigurarGridZebrado();
            gridFuncionarios.ConfigurarGridSomenteLeitura();
            gridFuncionarios.Columns.AddRange(ObterColunas());
        }
        public DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
           {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Name"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Cpf", HeaderText = "CPF"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Endereco", HeaderText = "Address"},

                new DataGridViewTextBoxColumn {DataPropertyName = "Telefone", HeaderText = "Phone"},

                new DataGridViewTextBoxColumn {DataPropertyName = "Email", HeaderText = "Email"},

                new DataGridViewTextBoxColumn {DataPropertyName = "MatriculaInterna", HeaderText = "Code"},

                new DataGridViewTextBoxColumn {DataPropertyName = "UsuarioAcesso", HeaderText = "User"},

                new DataGridViewTextBoxColumn {DataPropertyName = "Cargo", HeaderText = "Role"},

                new DataGridViewTextBoxColumn {DataPropertyName = "Salario", HeaderText = "Salary"},

                new DataGridViewTextBoxColumn {DataPropertyName = "DataAdmissao", HeaderText = "Admission Date"}
           };

            return colunas;
        }

        public int ObtemIdSelecionado()
        {
            return gridFuncionarios.SelecionarId<int>();
        }

        public void AtualizarRegistros(List<Funcionario> funcionarios)
        {
            gridFuncionarios.Rows.Clear();

            foreach (Funcionario funcionario in funcionarios)
            {
                gridFuncionarios.Rows.Add(funcionario.Id, funcionario.Nome, funcionario.RegistroUnico,
                    funcionario.Endereco, funcionario.Telefone, funcionario.Email, funcionario.MatriculaInterna,
                    funcionario.UsuarioAcesso, funcionario.Cargo, funcionario.Salario, funcionario.DataAdmissao);
            }
        }
    }
}
