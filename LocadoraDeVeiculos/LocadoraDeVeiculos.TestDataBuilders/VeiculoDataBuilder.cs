using LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule;
using LocadoraDeVeiculos.Dominio.ImagemVeiculoModule;
using LocadoraDeVeiculos.Dominio.VeiculoModule;
using System.Collections.Generic;

namespace LocadoraDeVeiculos.TestDataBuilders
{
    public class VeiculoDataBuilder
    {
        private readonly Veiculo veiculo;
        public VeiculoDataBuilder()
        {
            veiculo = new Veiculo();
        }
        public VeiculoDataBuilder ComModelo(string modelo)
        {
            veiculo.modelo = modelo;
            return this;
        }
        public VeiculoDataBuilder ComGrupoDeVeiculo(GrupoDeVeiculo grupoDeVeiculo)
        {
            veiculo.grupoVeiculos = grupoDeVeiculo;
            return this;
        }

        public VeiculoDataBuilder ComPlaca(string placa)
        {
            veiculo.placa = placa;
            return this;
        }
        public VeiculoDataBuilder ComChassi(string chassi)
        {
            veiculo.chassi = chassi;
            return this;
        }
        public VeiculoDataBuilder ComMarca(string marca)
        {
            veiculo.marca = marca;
            return this;
        }
        public VeiculoDataBuilder ComCor(string cor)
        {
            veiculo.cor = cor;
            return this;
        }
        public VeiculoDataBuilder ComTipoCombustivel(string tipoCombustivel)
        {
            veiculo.tipoCombustivel = tipoCombustivel;
            return this;
        }
        public VeiculoDataBuilder ComCapacidadeTanque(double capacidadeTanque)
        {
            veiculo.capacidadeTanque = capacidadeTanque;
            return this;
        }
        public VeiculoDataBuilder ComAno(int ano)
        {
            veiculo.ano = ano;
            return this;
        }
        public VeiculoDataBuilder ComQuilometragem(double quilometragem)
        {
            veiculo.kilometragem = quilometragem;
            return this;
        }
        public VeiculoDataBuilder ComNumPortas(int numPortas)
        {
            veiculo.numeroPortas = numPortas;
            return this;
        }
        public VeiculoDataBuilder ComCapacidadePessoas(int capacidadePessoas)
        {
            veiculo.capacidadePessoas = capacidadePessoas;
            return this;
        }
        public VeiculoDataBuilder ComTamanhoPortaMala(char tamanhoPortaMala)
        {
            veiculo.tamanhoPortaMala = tamanhoPortaMala;
            return this;
        }
        public VeiculoDataBuilder ComArCondicionado(bool temArCondicionado)
        {
            veiculo.temArCondicionado = temArCondicionado;
            return this;
        }
        public VeiculoDataBuilder ComDirecaoHidraulica(bool temDirecaoHidraulica)
        {
            veiculo.temDirecaoHidraulica = temDirecaoHidraulica;
            return this;
        }
        public VeiculoDataBuilder ComFreiosAbs(bool temFreiosAbs)
        {
            veiculo.temFreiosAbs = temFreiosAbs;
            return this;
        }
        public VeiculoDataBuilder ComAlocaoAtiva(bool estaAlugado)
        {
            veiculo.estaAlugado = estaAlugado;
            return this;
        }
        public VeiculoDataBuilder ComImagem(List<ImagemVeiculo> imagemVeiculos)
        {
            veiculo.imagens = imagemVeiculos;
            return this;
        }
        public Veiculo Build()
        {
            return veiculo;
        }
    }
}
