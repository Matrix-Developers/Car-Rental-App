using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LocadoraDeVeiculos.WindowsApp.Features.Veiculos;
using LocadoraDeVeiculos.WindowsApp.Veiculos;

namespace LocadoraDeVeiculos.WindowsApp.Features.ImagemVeiculo
{
    public partial class ImagemVeiculoForm : Form
    {
        private const int voltar = -1;
        private const int avancar = 1;
        private int imagemAtual = 0;
        public List<Bitmap> imagens;
        private readonly VeiculoForm telaBase;
        public ImagemVeiculoForm(VeiculoForm telaBase)
        {
            imagens = imagens = new List<Bitmap>();
            InitializeComponent();
            this.telaBase = telaBase;
        }
        public ImagemVeiculoForm(VeiculoForm telaBase,List<Bitmap> imagens)
        {
            this.imagens = imagens;
            InitializeComponent();
            pctBoxImagem.Image = imagens[0];
            this.telaBase = telaBase;
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
            if (imagens.Count != 0)
                pctBoxImagem.Image = imagens[imagemAtual];
            else
                pctBoxImagem.Image = default;
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
                imagens.RemoveAt(imagemAtual);
                MudarImagemAtual(0);
            }
            else
            {
                pctBoxImagem.Image = default;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
                telaBase.AtualizarListaDeFotos(imagens);
            this.Close();
        }
    }
}
