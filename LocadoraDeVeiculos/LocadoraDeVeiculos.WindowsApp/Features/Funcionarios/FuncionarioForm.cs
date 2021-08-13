using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LocadoraDeVeiculos.Dominio.FuncionarioModule;

namespace LocadoraDeVeiculos.WindowsApp.Funcionarios
{
    public partial class FuncionarioForm : Form
    {
        private Funcionario funcionario;

        public FuncionarioForm()
        {
            InitializeComponent();          
        }

        public Funcionario Funcionario
        {
            get { return funcionario; }

            set
            {
                funcionario = value;

                textId.Text = funcionario.Id.ToString();
                textNome.Text = funcionario.Nome.ToString();
                mskTxtCpf.Text = funcionario.RegistroUnico.ToString();
                textEndereco.Text = funcionario.Endereco.ToString();
                mskTxtTelefone.Text = funcionario.Telefone.ToString();
                
            }
        }
    }
}
