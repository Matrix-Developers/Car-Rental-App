using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Features.ImagemVeiculo
{
    public partial class ImagemVeiculoForm : Form
    {
        private const int voltar = -1;
        private const int avancar = 1;
        private int imagemAtual = 0;
        public List<Bitmap> imagens;
        public ImagemVeiculoForm()
        {
            imagens = imagens = new List<Bitmap>();
            InitializeComponent();
        }
        public ImagemVeiculoForm(List<Bitmap> imagens)
        {
            this.imagens = imagens;
            InitializeComponent();
            pctBoxImagem.Image = imagens[0];
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            if (openFileDialog.ShowDialog()  == DialogResult.OK)
                {
                imagens.Add((Bitmap)Image.FromFile(openFileDialog.FileName));
                if (imagens.Count == 1)
                    AtualizarImagem();
                else
                {
                    MudarImagemAtual((imagens.Count() - 1));
                }
            }
        }

        private void MudarImagemAtual(int indice)
        {
            if (imagemAtual == 0 && indice == voltar) //<=======================|ir    para    a   ultima
                imagemAtual = imagens.Count() - 1;
            else if (imagemAtual + 1 == imagens.Count() && indice == avancar) //|ir    para   a  primeira
                imagemAtual = 0;
            else if (indice != 1 && indice != -1) //<===========================| vai  para  o   index  0
                imagemAtual = indice;
            else //<============================================================| só move no meio da list
                imagemAtual = imagemAtual + indice;

            AtualizarImagem();
        }

        private void AtualizarImagem()
        {
            pctBoxImagem.Image = imagens[imagemAtual];
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (imagens.Count() != 0)
                MudarImagemAtual(voltar);
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            if (imagens.Count() != 0)
                MudarImagemAtual(avancar);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (imagens.Count() != 0)
            {
                imagens.RemoveAt(imagemAtual - 1);
                MudarImagemAtual(0);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
