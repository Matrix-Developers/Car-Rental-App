using LocadoraDeVeiculos.Dominio.ClienteModule;
using LocadoraDeVeiculos.Dominio.FuncionarioModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Dominio.VeiculoModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Dominio.LocacaoModule
{
    public class Locacao : EntidadeBase
    {
        private Veiculo veiculo;
        private Funcionario funcionarioLocador;
        private Cliente clienteContratante;
        private Cliente clienteCondutor;
        private DateTime dataDeSaida;
        private DateTime dataPrevistaDeChegada;
        private string tipoDoPlano;         //PlanoDiario, KmControlado ou KmLivre
        private string tipoDeSeguro;    //SeguroCliente, SeguroTerceiro ou Nenhum
        private double precoLocacao;

        public Veiculo Veiculo { get => veiculo; }
        public Funcionario FuncionarioLocador { get => funcionarioLocador; }
        public Cliente ClienteContratante { get => clienteContratante; }
        public Cliente ClienteCondutor { get => clienteCondutor; }
        public DateTime DataDeSaida { get => dataDeSaida; }
        public DateTime DataPrevistaDeChegada { get => dataPrevistaDeChegada; }
        public string TipoDoPlano { get => tipoDoPlano; }
        public string TipoDeSeguro { get => tipoDeSeguro; }
        public double PrecoLocacao { get => precoLocacao; }

        public Locacao(Veiculo veiculo, Funcionario funcionarioLocador, Cliente clienteContratante, Cliente clienteCondutor, DateTime dataDeSaida, DateTime dataPrevistaDeChegada, string tipoDoPlano, string tipoDeSeguro)
        {
            this.veiculo = veiculo;
            this.funcionarioLocador = funcionarioLocador;
            this.clienteContratante = clienteContratante;
            this.clienteCondutor = clienteCondutor;
            this.dataDeSaida = dataDeSaida;
            this.dataPrevistaDeChegada = dataPrevistaDeChegada;
            this.tipoDoPlano = tipoDoPlano;
            this.tipoDeSeguro = tipoDeSeguro;
            precoLocacao = CalcularLocacao.CalcularSeguro(tipoDeSeguro);
            precoLocacao += CalcularLocacao.CalcularGarantia();
        }

        public override string Validar()
        {
            string resultadoValidacao = "";
            if (this.veiculo == null)
                resultadoValidacao = "O veiculo não pode ser nulo\n";

            if (this.funcionarioLocador == null)
                resultadoValidacao += "O funcionário locador não pode ser nulo\n";

            if (this.clienteContratante == null)
                resultadoValidacao += "O cliente contratante não pode ser nulo\n";

            else if (!this.clienteContratante.EhPessoaFisica && this.clienteCondutor == null)
                resultadoValidacao += "O condutor não pode ser nulo quando o cliente contratante é pessoa juridica\n";

            if (this.clienteCondutor != null)
            {
                if (!this.clienteCondutor.EhPessoaFisica)
                    resultadoValidacao += "O condutor não pode ser pessoa jurídica.\n";
            }

            if (!this.tipoDoPlano.Equals("PlanoDiario") && !this.tipoDoPlano.Equals("KmControlado") && !this.tipoDoPlano.Equals("KmLivre"))
                resultadoValidacao += "O tipo do plano é inválido.\n";

            if (!this.tipoDeSeguro.Equals("SeguroCliente") && !this.tipoDeSeguro.Equals("SeguroTerceiro") && !this.tipoDeSeguro.Equals("Nenhum"))
                resultadoValidacao += "O tipo do seguro é inválido.\n";

            if (resultadoValidacao == "")
                resultadoValidacao = "VALIDO";

            return resultadoValidacao;
        }

        public override bool Equals(object obj)
        {
            return obj is Locacao locacao &&
                   id == locacao.id &&
                   EqualityComparer<Veiculo>.Default.Equals(veiculo, locacao.veiculo) &&
                   EqualityComparer<Funcionario>.Default.Equals(funcionarioLocador, locacao.funcionarioLocador) &&
                   EqualityComparer<Cliente>.Default.Equals(clienteContratante, locacao.clienteContratante) &&
                   EqualityComparer<Cliente>.Default.Equals(clienteCondutor, locacao.clienteCondutor) &&
                   dataDeSaida == locacao.dataDeSaida &&
                   dataPrevistaDeChegada == locacao.dataPrevistaDeChegada &&
                   tipoDoPlano == locacao.tipoDoPlano &&
                   tipoDeSeguro == locacao.tipoDeSeguro &&
                   precoLocacao == locacao.precoLocacao;
        }

        public override int GetHashCode()
        {
            int hashCode = -562312921;
            hashCode = hashCode * -1521134295 + id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Veiculo>.Default.GetHashCode(veiculo);
            hashCode = hashCode * -1521134295 + EqualityComparer<Funcionario>.Default.GetHashCode(funcionarioLocador);
            hashCode = hashCode * -1521134295 + EqualityComparer<Cliente>.Default.GetHashCode(clienteContratante);
            hashCode = hashCode * -1521134295 + EqualityComparer<Cliente>.Default.GetHashCode(clienteCondutor);
            hashCode = hashCode * -1521134295 + dataDeSaida.GetHashCode();
            hashCode = hashCode * -1521134295 + dataPrevistaDeChegada.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(tipoDoPlano);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(tipoDeSeguro);
            hashCode = hashCode * -1521134295 + precoLocacao.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
