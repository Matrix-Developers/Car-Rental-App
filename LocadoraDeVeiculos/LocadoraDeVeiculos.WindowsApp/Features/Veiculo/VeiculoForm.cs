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

namespace LocadoraDeVeiculos.WindowsApp.Veiculos
{
    public partial class VeiculoForm : Form
    {
        private Veiculo veiculo;
        public VeiculoForm()
        {
            InitializeComponent();
        }
        public Veiculo Veiculo
        {
            get { return veiculo; }

            set
            {
                veiculo = value;

                textId.Text = veiculo.Id.ToString();
                textModelo.Text = veiculo.modelo;
                cBoxGrupo.Text = veiculo.grupoVeiculos.Nome;
                textPlaca.Text = veiculo.placa;
                textChassi.Text = veiculo.chassi;
                textMarca.Text = veiculo.marca;
                textCor.Text = veiculo.marca;
                textCombustivel.Text = veiculo.tipoCombustivel;
                numUpDownCapTanque.Text = veiculo.capacidadeTanque.ToString();
                dateTPAno.Text = veiculo.ano.ToString();
                textKM.Text = veiculo.kilometragem.ToString();
                numUpDownQtdPortas.Text = veiculo.numeroPortas.ToString();
                cBoxPortaMalas.Text = veiculo.tamanhoPortaMala.ToString();
                if (veiculo.temArCondicionado)
                    checkLBoxOpcionais.SetItemChecked(0, true);
                if (veiculo.temDirecaoHidraulica)
                    checkLBoxOpcionais.SetItemChecked(1, true);
                if (veiculo.temFreiosAbs)
                    checkLBoxOpcionais.SetItemChecked(2, true);
            }
        }
    }
}
