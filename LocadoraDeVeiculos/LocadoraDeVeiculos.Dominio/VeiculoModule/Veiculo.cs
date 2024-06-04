using LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule;
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

        public Veiculo(int id, string modelo, GrupoDeVeiculo grupoVeiculos, string placa, string chassi, string marca, string cor, string tipoCombustivel, double capacidadeTanque, int ano, double kilometragem, int numeroPortas, int capacidadePessoas, char tamanhoPortaMala, bool temArCondicionado, bool temDirecaoHidraulica, bool temFreiosAbs, bool status)
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

        }

        public Veiculo()
        {
        }

        public override string Validar()
        {
            string resultadoValidacao = "";

            if (this.modelo.Length == 0)
                resultadoValidacao = "The model field cannot be empty.\n";
            if (this.placa.Length == 0)
                resultadoValidacao += "The sign field cannot be empty.\n";
            if (this.chassi.Length == 0)
                resultadoValidacao += "The chassis field cannot be empty.\n";
            if (this.marca.Length == 0)
                resultadoValidacao += "The brand field cannot be empty.\n";
            if (this.cor.Length == 0)
                resultadoValidacao += "The color field cannot be empty.\n";
            if (this.tipoCombustivel.Length == 0)
                resultadoValidacao += "The fuel type field cannot be empty.\n";
            if (this.capacidadeTanque == 0)
                resultadoValidacao += "The tank capacity field cannot be empty.\n";
            if (this.ano <= 0)
                resultadoValidacao += "The year field cannot be empty.\n";
            if (this.kilometragem <= 0)
                resultadoValidacao += "The mileage field cannot be empty.\n";
            if (this.numeroPortas <= 0)
                resultadoValidacao += "The number of doors field cannot be empty.\n";
            if (this.capacidadePessoas <= 0)
                resultadoValidacao += "The number of seats field cannot be empty.\n";
            if (this.tamanhoPortaMala != 'P' && this.tamanhoPortaMala != 'M' && this.tamanhoPortaMala != 'G')
                resultadoValidacao += "The trunk size field cannot be empty.\n";
            if (resultadoValidacao == "")
                resultadoValidacao = "VALID";
            return resultadoValidacao;
        }

        public override string ToString()
        {
            return $"{modelo}, {grupoVeiculos.Nome}, {placa}";
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
