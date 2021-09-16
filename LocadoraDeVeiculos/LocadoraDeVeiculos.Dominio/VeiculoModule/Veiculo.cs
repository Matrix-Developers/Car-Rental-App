using LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule;
using LocadoraDeVeiculos.Dominio.ImagemVeiculoModule;
using LocadoraDeVeiculos.Dominio.Shared;
using System;
using System.Collections.Generic;

namespace LocadoraDeVeiculos.Dominio.VeiculoModule
{
    public class Veiculo : EntidadeBase
    {
        public string modelo;
        public GrupoDeVeiculo grupoVeiculos;
        public string placa;
        public string chassi;
        public string marca;
        public string cor;
        public string tipoCombustivel;
        public double capacidadeTanque;
        public int ano;
        public double kilometragem;
        public int numeroPortas;
        public int capacidadePessoas;
        public char tamanhoPortaMala;
        public bool temArCondicionado;
        public bool temDirecaoHidraulica;
        public bool temFreiosAbs;
        public bool estaAlugado;
        public List<ImagemVeiculo> imagens;

        public Veiculo(int id, string modelo, GrupoDeVeiculo grupoVeiculos, string placa, string chassi, string marca, string cor, string tipoCombustivel, double capacidadeTanque, int ano, double kilometragem, int numeroPortas, int capacidadePessoas, char tamanhoPortaMala, bool temArCondicionado, bool temDirecaoHidraulica, bool temFreiosAbs, bool status, List<ImagemVeiculo> imagens)
        {
            this.id = id;
            this.modelo = modelo;
            this.grupoVeiculos = grupoVeiculos;
            this.placa = placa;
            this.chassi = chassi;
            this.marca = marca;
            this.cor = cor;
            this.tipoCombustivel = tipoCombustivel;
            this.capacidadeTanque = capacidadeTanque;
            this.ano = ano;
            this.kilometragem = kilometragem;
            this.numeroPortas = numeroPortas;
            this.capacidadePessoas = capacidadePessoas;
            this.tamanhoPortaMala = tamanhoPortaMala;
            this.temArCondicionado = temArCondicionado;
            this.temDirecaoHidraulica = temDirecaoHidraulica;
            this.temFreiosAbs = temFreiosAbs;
            this.estaAlugado = status;
            this.imagens = imagens;
        }

        public override string Validar()
        {
            string resultadoValidacao = "";

            if (this.modelo.Length == 0)
                resultadoValidacao = "O campo modelo não pode ser vazio!\n";
            if (this.placa.Length == 0)
                resultadoValidacao += "O campo placa não pode ser vazio!\n";
            if (this.chassi.Length == 0)
                resultadoValidacao += "O campo chassi não pode ser vazio!\n";
            if (this.marca.Length == 0)
                resultadoValidacao += "O campo marca não pode ser vazio!\n";
            if (this.cor.Length == 0)
                resultadoValidacao += "O campo cor não pode ser vazio!\n";
            if (this.tipoCombustivel.Length == 0)
                resultadoValidacao += "O campo tipo de combústivel não pode ser vazio!\n";
            if (this.capacidadeTanque == 0)
                resultadoValidacao += "O campo capacidade de tanque não pode ser vazio!\n";
            if (this.ano <= 0)
                resultadoValidacao += "O campo ano não pode ser vazio!\n";
            if (this.kilometragem <= 0)
                resultadoValidacao += "O campo kilometragem não pode ser vazio!\n";
            if (this.numeroPortas <= 0)
                resultadoValidacao += "O campo numero de portas não pode ser vazio!\n";
            if (this.capacidadePessoas <= 0)
                resultadoValidacao += "O campo capacidades de pessoas não pode ser vazio!\n";
            if (this.tamanhoPortaMala != 'P' && this.tamanhoPortaMala != 'M' && this.tamanhoPortaMala != 'G')
                resultadoValidacao += "O campo tamanho do porta mala não pode ser vazio!\n";
            if (resultadoValidacao == "")
                resultadoValidacao = "VALIDO";
            return resultadoValidacao;
        }

        public override string ToString()
        {
            return $"[{id}, {modelo}, {grupoVeiculos}, {placa}]";
        }

        public override bool Equals(object obj)
        {
            return obj is Veiculo veiculo &&
                   id == veiculo.id &&
                   modelo == veiculo.modelo &&
                   EqualityComparer<GrupoDeVeiculo>.Default.Equals(grupoVeiculos, veiculo.grupoVeiculos) &&
                   placa == veiculo.placa &&
                   chassi == veiculo.chassi &&
                   marca == veiculo.marca &&
                   cor == veiculo.cor &&
                   tipoCombustivel == veiculo.tipoCombustivel &&
                   capacidadeTanque == veiculo.capacidadeTanque &&
                   ano == veiculo.ano &&
                   kilometragem == veiculo.kilometragem &&
                   numeroPortas == veiculo.numeroPortas &&
                   capacidadePessoas == veiculo.capacidadePessoas &&
                   tamanhoPortaMala == veiculo.tamanhoPortaMala &&
                   temArCondicionado == veiculo.temArCondicionado &&
                   temDirecaoHidraulica == veiculo.temDirecaoHidraulica &&
                   temFreiosAbs == veiculo.temFreiosAbs &&
                   estaAlugado == veiculo.estaAlugado;
        }

        public override int GetHashCode()
        {
            HashCode hash = new();
            hash.Add(id);
            hash.Add(modelo);
            hash.Add(grupoVeiculos);
            hash.Add(placa);
            hash.Add(chassi);
            hash.Add(marca);
            hash.Add(cor);
            hash.Add(tipoCombustivel);
            hash.Add(capacidadeTanque);
            hash.Add(ano);
            hash.Add(kilometragem);
            hash.Add(numeroPortas);
            hash.Add(capacidadePessoas);
            hash.Add(tamanhoPortaMala);
            hash.Add(temArCondicionado);
            hash.Add(temDirecaoHidraulica);
            hash.Add(temFreiosAbs);
            hash.Add(estaAlugado);
            return hash.ToHashCode();
        }
    }
}
