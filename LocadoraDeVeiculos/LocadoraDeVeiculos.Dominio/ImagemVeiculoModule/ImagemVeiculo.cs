using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Dominio.VeiculoModule;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace LocadoraDeVeiculos.Dominio.ImagemVeiculoModule
{
    public class ImagemVeiculo : EntidadeBase
    {
        public Veiculo veiculo {get; set;}
        public Bitmap Imagem { get; set; }

        public ImagemVeiculo() { }
        public ImagemVeiculo(int id, int idVeiculo, Bitmap imagem)
        {
            this.id = id;
            this.Imagem = imagem;
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
                   EqualityComparer<Bitmap>.Default.Equals(Imagem, imagemVeiculo.Imagem) &&
                   EqualityComparer<int>.Default.Equals(Id, imagemVeiculo.id);
        }

        public override int GetHashCode()
        {
            int hashCode = 155997214;
            hashCode = hashCode * -1521134295 + id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Bitmap>.Default.GetHashCode(Imagem);
            return hashCode;
        }
    }
}
