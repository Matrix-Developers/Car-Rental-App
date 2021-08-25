using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Dominio.VeiculoModule;

namespace LocadoraDeVeiculos.Dominio.ImagemVeiculoModule
{
    public class ImagemVeiculo : EntidadeBase
    {
        public Veiculo veiculo { get; set; }
        public Bitmap imagem { get; set; }

        public ImagemVeiculo(int id, Veiculo veiculo, Bitmap imagem)
        {
            this.id = id;
            this.veiculo = veiculo;
            this.imagem = imagem;
        }


        public override int GetHashCode()
        {
            int hashCode = 1584103619;
            hashCode = hashCode * -1521134295 + id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Veiculo>.Default.GetHashCode(veiculo);
            hashCode = hashCode * -1521134295 + EqualityComparer<Bitmap>.Default.GetHashCode(imagem);
            return hashCode;
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }

        public override string Validar()
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object obj)
        {
            return obj is ImagemVeiculo imagemVeiculo &&
                   EqualityComparer<Veiculo>.Default.Equals(this.veiculo, imagemVeiculo.veiculo) &&
                   EqualityComparer<Bitmap>.Default.Equals(imagem, imagemVeiculo.imagem) &&
                   EqualityComparer<int>.Default.Equals(Id, imagemVeiculo.id);
        }
    }
}
