using LocadoraDeVeiculos.Dominio.ClienteModule;
using LocadoraDeVeiculos.Dominio.CupomModule;
using LocadoraDeVeiculos.Dominio.FuncionarioModule;
using LocadoraDeVeiculos.Dominio.SevicosModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Dominio.VeiculoModule;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace LocadoraDeVeiculos.Dominio.LocacaoModule
{
    public class Locacao : EntidadeBase
    {
        private Veiculo veiculo;
        private Funcionario funcionarioLocador;
        private Cliente clienteContratante;
        private Cliente clienteCondutor;
        private Cupom cupom;
        private int? veiculoId;
        private int? funcionarioLocadorId;
        private int? cupomId;
        private int? clienteContratanteId;
        private int? clienteCondutorId;
        private DateTime dataDeSaida;
        private DateTime dataPrevistaDeChegada;
        private DateTime dataDeChegada;
        private string tipoDoPlano;
        private string tipoDeSeguro;
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
            clienteContratanteId = clienteContratante != null ? clienteContratante.Id : null;
            clienteCondutorId = clienteCondutor != null ? clienteCondutor.Id : null;
            veiculoId = veiculo.Id;
            funcionarioLocadorId = funcionarioLocador != null ? funcionarioLocador.Id : null;
            if (cupom != null)
                cupomId = cupom.Id;
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
            clienteContratanteId = clienteContratante != null ? clienteContratante.Id : null;
            clienteCondutorId = clienteCondutor.Id;
            veiculoId = veiculo.Id;
            funcionarioLocadorId = funcionarioLocador.Id;
            if (cupom != null)
                cupomId = cupom.Id;
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

        public Locacao Clone()
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(ms, this);

            ms.Position = 0;
            object obj = bf.Deserialize(ms);
            ms.Close();

            return obj as Locacao;
        }

        public Locacao()
        {
        }

        public Veiculo Veiculo { get => veiculo; set => veiculo = value; }
        public Funcionario FuncionarioLocador { get => funcionarioLocador; set => funcionarioLocador = value; }
        public Cliente ClienteContratante { get => clienteContratante; set => clienteContratante = value; }
        public Cliente ClienteCondutor { get => clienteCondutor; set =>clienteCondutor = value; }
        public Cupom Cupom { get => cupom; set => cupom = value; }
        public DateTime DataDeSaida { get => dataDeSaida; set => dataDeSaida = value; }
        public DateTime DataPrevistaDeChegada { get => dataPrevistaDeChegada; set => dataPrevistaDeChegada = value; }
        public DateTime DataDeChegada { get => dataDeChegada; set => dataDeChegada = value; }
        public string TipoDoPlano { get => tipoDoPlano; set => tipoDoPlano = value; }
        public string TipoDeSeguro { get => tipoDeSeguro; set => tipoDeSeguro = value; }
        public double PrecoLocacao { get => precoLocacao; set => precoLocacao = value; }
        public double PrecoDevolucao { get => precoDevolucao; set => precoDevolucao = value; }
        public bool EstaAberta { get => estaAberta; set => estaAberta = value; }
        public List<Servico> Servicos { get => servicos; set => servicos = value; }
        public int? ClienteCondutorId { get => clienteCondutorId; set => clienteCondutorId = value; }
        public int? ClienteContratanteId { get => clienteContratanteId; set => clienteContratanteId = value; }
        public int? VeiculoId { get => veiculoId; set => veiculoId = value; }
        public int? FuncionarioLocadorId { get => funcionarioLocadorId; set => funcionarioLocadorId = value; }
        public int? CupomId { get => cupomId; set => cupomId = value; }

        public void AbrirLocacao(DateTime dataAbertura)
        {
            estaAberta = true;
            dataDeSaida = dataAbertura;
            if(veiculo != null)
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
                resultadoValidacao = "The Vehicle cannot be null\n";

            if (this.funcionarioLocador == null)
                resultadoValidacao += "The Employee cannot be null\n";

            if (this.clienteContratante == null)
                resultadoValidacao += "The renting client cannot be null\n";

            else if (!this.clienteContratante.EhPessoaFisica && this.clienteCondutor == null)
                resultadoValidacao += "The conductor cannot be null when the renting client is legal entity\n";

            if (this.clienteCondutor != null)
                if (!this.clienteCondutor.EhPessoaFisica)
                    resultadoValidacao += "The conductor cannot be legal entity.\n";

            if (!this.tipoDoPlano.Equals("PlanoDiario") && !this.tipoDoPlano.Equals("KmControlado") && !this.tipoDoPlano.Equals("KmLivre"))
                resultadoValidacao += "The plan type is invalid.\n";

            if (!this.tipoDeSeguro.Equals("ClientInsurance") && !this.tipoDeSeguro.Equals("ThirdPartyInsurance") && !this.tipoDeSeguro.Equals("None"))
                resultadoValidacao += "The insurance type is invalid.\n";

            if (this.DataDeSaida >= this.DataPrevistaDeChegada)
                resultadoValidacao += "The lease date cannot be before the return date.\n";

            if (resultadoValidacao == "")
                resultadoValidacao = "VALID";

            return resultadoValidacao;
        }



        public override string ToString()
        {
            return $"{veiculo.modelo}, {clienteContratante.Nome}, {dataDeSaida}, {dataPrevistaDeChegada}, {tipoDoPlano}, {tipoDeSeguro}";
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
