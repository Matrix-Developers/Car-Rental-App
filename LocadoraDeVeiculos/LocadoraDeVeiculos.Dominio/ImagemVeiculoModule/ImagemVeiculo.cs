using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Dominio.VeiculoModule;
using System.IO;
using System.Drawing;

namespace LocadoraDeVeiculos.Dominio.ImagemVeiculoModule
{
    public class ImagemVeiculo : EntidadeBase
    {
        public int idVeiculo { get; set; }
        public Bitmap imagem { get; set; }

        public ImagemVeiculo() { }
        public ImagemVeiculo(int id, int idVeiculo, Bitmap imagem)
        {
            this.id = id;
            this.idVeiculo = idVeiculo;
            this.imagem = imagem;
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }

        public override string Validar()
        {
            string resultadoValidacao = "VALIDO";
            return resultadoValidacao;
        }

        public override bool Equals(object obj)
        {
            return obj is ImagemVeiculo imagemVeiculo &&
                   EqualityComparer<int>.Default.Equals(this.idVeiculo, imagemVeiculo.idVeiculo) &&
                   EqualityComparer<Bitmap>.Default.Equals(imagem, imagemVeiculo.imagem) &&
                   EqualityComparer<int>.Default.Equals(Id, imagemVeiculo.id);
        }

        public override int GetHashCode()
        {
            int hashCode = 155997214;
            hashCode = hashCode * -1521134295 + id.GetHashCode();
            hashCode = hashCode * -1521134295 + idVeiculo.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Bitmap>.Default.GetHashCode(imagem);
            return hashCode;
        }
    }
}
