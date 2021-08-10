using System;


namespace LocadoraDeVeiculos.Dominio.VeiculoModule
{
    public class Veiculo
    {
        public string modelo;
        public string grupoVeiculos;
        public string placa;
        public string chassi;
        public string marca;
        public string cor;
        public string tipoCombustivel;
        public string capacidadeTanque;
        public int ano;
        public double kilometragem;
        public int numeroPortas;
        public int capacidadePessoas;
        public string tamanhoPortaMala;
        public bool temArCondicionado;
        public bool temDirecaoHidraulica;
        public bool temFreiosAbs;

        public Veiculo(string modelo, string grupoVeiculos, string placa, string chassi, string marca, string cor, string tipoCombustivel, string capacidadeTanque, int ano, double kilometragem, int numeroPortas, int capacidadePessoas, string tamanhoPortaMala)
        {
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
        }
        public string Validar()
        {
            int seZeroehValido = 0;
            string resultadoValidacao = "";

            if (this.modelo.Length <= 0)
            {
                resultadoValidacao = "O campo modelo não pode ser vazio!\n";
                seZeroehValido++;
            }
            if (this.grupoVeiculos.Length <= 0)
            {
                resultadoValidacao += "O campo grupo de veículos não pode ser vazio!\n";
                seZeroehValido++;
            }
            if (this.placa.Length <= 0)
            {
                resultadoValidacao += "O campo placa não pode ser vazio!\n";
                seZeroehValido++;
            }

            if (this.chassi.Length <= 0)
            {
                resultadoValidacao += "O campo chassi não pode ser vazio!\n";
                seZeroehValido++;
            }

            if (this.marca.Length <= 0)
            {
                resultadoValidacao += "O campo marca não pode ser vazio!\n";
                seZeroehValido++;
            }

            if (this.cor.Length <= 0)
            {
                resultadoValidacao += "O campo cor não pode ser vazio!\n";
                seZeroehValido++;
            }

            if (this.tipoCombustivel.Length <= 0)
            {
                resultadoValidacao += "O campo tipo de combústivel não pode ser vazio!\n";
                seZeroehValido++;
            }

            if (this.capacidadeTanque.Length <= 0)
            {
                resultadoValidacao += "O campo capacidade de tanque não pode ser vazio!\n";
                seZeroehValido++;
            }

            if (this.ano <= 0)
            {
                resultadoValidacao += "O campo ano não pode ser vazio!\n";
                seZeroehValido++;
            }

            if (this.kilometragem <= 0)
            {
                resultadoValidacao += "O campo kilometragem não pode ser vazio!\n";
                seZeroehValido++;
            }

            if (this.numeroPortas <= 0)
            {
                resultadoValidacao += "O campo numero de portas não pode ser vazio!\n";
                seZeroehValido++;
            }

            if (this.capacidadePessoas <= 0)
            {
                resultadoValidacao += "O campo capacidades de pessoas não pode ser vazio!\n";
                seZeroehValido++;
            }

            if (this.tamanhoPortaMala.Length <= 0)
            {
                resultadoValidacao += "O campo tamanho do porta mala não pode ser vazio!\n";
                seZeroehValido++;
            }
            if (seZeroehValido == 0)
            {
                resultadoValidacao = "VALIDO";
            }
                return resultadoValidacao;
        }
    }
 
}
