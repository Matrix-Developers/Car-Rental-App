using LocadoraDeVeiculos.Dominio.ParceiroModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Features.Parceiros
{
    public partial class TabelaParceiroControl : UserControl
    {
        public TabelaParceiroControl()
        {
            InitializeComponent();
        }

        internal void AtualizarRegistros(List<Parceiro> parceiros)
        {
            throw new NotImplementedException();
        }

        internal int ObtemIdSelecionado()
        {
            throw new NotImplementedException();
        }
    }
}
