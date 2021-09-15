using LocadoraDeVeiculos.Dominio.ClienteModule;
using LocadoraDeVeiculos.Dominio.CupomModule;
using LocadoraDeVeiculos.Dominio.FuncionarioModule;
using LocadoraDeVeiculos.Dominio.SevicosModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Dominio.VeiculoModule;
using System;
using System.Collections.Generic;

namespace LocadoraDeVeiculos.Dominio.LocacaoModule
{
    public class Locacao : EntidadeBase
    {
        private Veiculo veiculo;
        private Funcionario funcionarioLocador;
        private Cliente clienteContratante;
        private Cliente clienteCondutor;
        private Cupom cupom;
        private DateTime dataDeSaida;
        private DateTime dataPrevistaDeChegada;
        private DateTime dataDeChegada;
        private string tipoDoPlano;         //PlanoDiario, KmControlado ou KmLivre
        private string tipoDeSeguro;    //SeguroCliente, SeguroTerceiro ou Nenhum
        private double precoLocacao;
        private double precoDevolucao;
        private bool estaAberta;
        private List<Servico> servicos;

        //Construtor para uso comum (PROBLEMAS NOS TESTES. EQUALS SAI DIFERENTE)
        public Locacao(int id, Veiculo veiculo, Funcionario funcionarioLocador, Cliente clienteContratante, Cliente clienteCondutor, Cupom cupom, DateTime dataDeSaida, DateTime dataPrevistaDeChegada, string tipoDoPlano, string tipoDeSeguro, List<Servico> servicos)
        {
            this.id = id;
            this.veiculo = veiculo;
            this.funcionarioLocador = funcionarioLocador;
            this.clienteContratante = clienteContratante;
            this.clienteCondutor = clienteCondutor;
            this.cupom = cupom;
            this.dataDeSaida = dataDeSaida;
            this.dataPrevistaDeChegada = dataPrevistaDeChegada;
            this.tipoDoPlano = tipoDoPlano;
            this.tipoDeSeguro = tipoDeSeguro;
            this.servicos = servicos;

            estaAberta = false;
            AbrirLocacao(dataDeSaida);
            dataDeChegada = DateTime.MaxValue;
            precoDevolucao = 0;
        }

        //Construtor SOMENTE para carregar do banco
        public Locacao(int id, Veiculo veiculo, Funcionario funcionarioLocador, Cliente clienteContratante, Cliente clienteCondutor, Cupom cupom, DateTime dataDeSaida, DateTime dataPrevistaDeChegada, DateTime dataDeChegada, string tipoDoPlano, string tipoDeSeguro, double precoLocacao, double precoDevolucao, bool estaAberta, List<Servico> servicos)
        {
            this.id = id;
            this.veiculo = veiculo;
            this.funcionarioLocador = funcionarioLocador;
            this.clienteContratante = clienteContratante;
            this.clienteCondutor = clienteCondutor;
            this.cupom = cupom;
            this.dataDeSaida = dataDeSaida;
            this.dataPrevistaDeChegada = dataPrevistaDeChegada;
            this.dataDeChegada = dataDeChegada;
            this.tipoDoPlano = tipoDoPlano;
            this.tipoDeSeguro = tipoDeSeguro;
            this.precoLocacao = precoLocacao;
            this.precoDevolucao = precoDevolucao;
            this.estaAberta = estaAberta;
            this.servicos = servicos;
        }

        public Veiculo Veiculo { get => veiculo; }
        public Funcionario FuncionarioLocador { get => funcionarioLocador; }
        public Cliente ClienteContratante { get => clienteContratante; }
        public Cliente ClienteCondutor { get => clienteCondutor; }
        public Cupom Cupom { get => cupom; }
        public DateTime DataDeSaida { get => dataDeSaida; }
        public DateTime DataPrevistaDeChegada { get => dataPrevistaDeChegada; }
        public DateTime DataDeChegada { get => dataDeChegada; }
        public string TipoDoPlano { get => tipoDoPlano; }
        public string TipoDeSeguro { get => tipoDeSeguro; }
        public double PrecoLocacao { get => precoLocacao; }
        public double PrecoDevolucao { get => precoDevolucao; }
        public bool EstaAberta { get => estaAberta; }
        public List<Servico> Servicos { get => servicos; set => servicos = value; }

        public void AbrirLocacao(DateTime dataAbertura)
        {
            estaAberta = true;
            dataDeSaida = dataAbertura;
            veiculo.estaAlugado = true;
            precoLocacao = CalcularLocacao.CalcularSeguro(tipoDeSeguro);
            precoLocacao += CalcularLocacao.CalcularGarantia();
            precoLocacao = Math.Round(precoLocacao, 2);
        }

        public void FecharLocacao(DateTime dataFechamento, double adicionalDoCombustivel, double kilometragemRodada)
        {
            estaAberta = false;
            dataDeChegada = dataFechamento;
            veiculo.kilometragem += kilometragemRodada;
            veiculo.estaAlugado = false;
            precoDevolucao = precoLocacao;
            precoDevolucao += adicionalDoCombustivel;
            precoDevolucao += CalcularLocacao.CalcularPlano(tipoDoPlano, veiculo.grupoVeiculos, kilometragemRodada, dataDeSaida, dataDeChegada);
            precoDevolucao += CalcularLocacao.CalcularServicos(servicos, dataDeSaida, dataDeChegada);
            precoDevolucao += CalcularLocacao.CalcularMultaDevolucaoAtrasada(precoDevolucao, dataPrevistaDeChegada, dataDeChegada);
            precoDevolucao -= CalcularLocacao.CalcularCupomDesconto(precoDevolucao, cupom);
            precoDevolucao = Math.Round(precoDevolucao, 2);
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
                if (!this.clienteCondutor.EhPessoaFisica)
                    resultadoValidacao += "O condutor não pode ser pessoa jurídica.\n";

            if (!this.tipoDoPlano.Equals("PlanoDiario") && !this.tipoDoPlano.Equals("KmControlado") && !this.tipoDoPlano.Equals("KmLivre"))
                resultadoValidacao += "O tipo do plano é inválido.\n";

            if (!this.tipoDeSeguro.Equals("SeguroCliente") && !this.tipoDeSeguro.Equals("SeguroTerceiro") && !this.tipoDeSeguro.Equals("Nenhum"))
                resultadoValidacao += "O tipo do seguro é inválido.\n";

            if (this.DataDeSaida >= this.DataPrevistaDeChegada)
                resultadoValidacao += "A data de entrega não pode ser anterior à data de locação.\n";

            if (resultadoValidacao == "")
                resultadoValidacao = "VALIDO";

            return resultadoValidacao;
        }



        public override string ToString()
        {
            return $"Locacao = {id}, {veiculo}, {funcionarioLocador}, {clienteContratante}, {clienteCondutor}, {dataDeSaida}, {dataPrevistaDeChegada}, {dataDeChegada}, {tipoDoPlano}, {tipoDeSeguro}, {precoLocacao}, {precoDevolucao}, {estaAberta}";
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
                   dataDeChegada == locacao.dataDeChegada &&
                   tipoDoPlano == locacao.tipoDoPlano &&
                   tipoDeSeguro == locacao.tipoDeSeguro &&
                   precoLocacao == locacao.precoLocacao &&
                   precoDevolucao == locacao.precoDevolucao &&
                   estaAberta == locacao.estaAberta;
        }

        public override int GetHashCode()
        {
            int hashCode = 1457090499;
            hashCode = hashCode * -1521134295 + id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Veiculo>.Default.GetHashCode(veiculo);
            hashCode = hashCode * -1521134295 + EqualityComparer<Funcionario>.Default.GetHashCode(funcionarioLocador);
            hashCode = hashCode * -1521134295 + EqualityComparer<Cliente>.Default.GetHashCode(clienteContratante);
            hashCode = hashCode * -1521134295 + EqualityComparer<Cliente>.Default.GetHashCode(clienteCondutor);
            hashCode = hashCode * -1521134295 + dataDeSaida.GetHashCode();
            hashCode = hashCode * -1521134295 + dataPrevistaDeChegada.GetHashCode();
            hashCode = hashCode * -1521134295 + dataDeChegada.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(tipoDoPlano);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(tipoDeSeguro);
            hashCode = hashCode * -1521134295 + precoLocacao.GetHashCode();
            hashCode = hashCode * -1521134295 + precoDevolucao.GetHashCode();
            hashCode = hashCode * -1521134295 + estaAberta.GetHashCode();
            return hashCode;
        }
    }
}
