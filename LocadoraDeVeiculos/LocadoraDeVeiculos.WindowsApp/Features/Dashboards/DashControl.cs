using LocadoraDeVeiculos.Controladores.VeiculoModule;
using LocadoraDeVeiculos.Dominio.VeiculoModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Features.Dashboards
{
    public partial class DashControl : UserControl
    {
        ControladorVeiculo controladorVeiculo;
        public DashControl()
        {
            InitializeComponent();
            controladorVeiculo = new ControladorVeiculo();
            MudaLabels();
        }

        private void MudaLabels()
        {
            CarregaDashBoardVeiculo();
        }

        private void CarregaDashBoardVeiculo()
        {
            List<Veiculo> TodosVeiculos = controladorVeiculo.SelecionarTodos();
            int carrosNoTotal = TodosVeiculos.Count;
            int carrosAlugados = 0;
            int carrosDisponiveis = 0;


            foreach (Veiculo veiculo in TodosVeiculos)
            {
                if (veiculo.estaAlugado)
                {
                    carrosAlugados++;
                }
                else
                {
                    carrosDisponiveis++;
                }
            }
            lbCarDisp.Text = carrosDisponiveis.ToString();
            lbCarInd.Text = carrosAlugados.ToString();
            lbCarTotal.Text = carrosNoTotal.ToString();
        }

    }
}
