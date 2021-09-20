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

                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Cpf", HeaderText = "CPF"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Endereco", HeaderText = "Endereço"},

                new DataGridViewTextBoxColumn {DataPropertyName = "Telefone", HeaderText = "Telefone"},

                new DataGridViewTextBoxColumn {DataPropertyName = "Email", HeaderText = "E-mail"},

                new DataGridViewTextBoxColumn {DataPropertyName = "MatriculaInterna", HeaderText = "Matricula"},

                new DataGridViewTextBoxColumn {DataPropertyName = "UsuarioAcesso", HeaderText = "Usuário"},

                new DataGridViewTextBoxColumn {DataPropertyName = "Cargo", HeaderText = "Cargo"},

                new DataGridViewTextBoxColumn {DataPropertyName = "Salario", HeaderText = "Salário"},

                new DataGridViewTextBoxColumn {DataPropertyName = "DataAdmissao", HeaderText = "Data de admissão"}
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
