using LocadoraDeVeiculos.Controladores.ClientesModule;
using LocadoraDeVeiculos.Controladores.CupomModule;
using LocadoraDeVeiculos.Controladores.FuncionarioModule;
using LocadoraDeVeiculos.Controladores.ServicoModule;
using LocadoraDeVeiculos.Controladores.Shared;
using LocadoraDeVeiculos.Controladores.VeiculoModule;
using LocadoraDeVeiculos.Dominio.ClienteModule;
using LocadoraDeVeiculos.Dominio.CupomModule;
using LocadoraDeVeiculos.Dominio.FuncionarioModule;
using LocadoraDeVeiculos.Dominio.LocacaoModule;
using LocadoraDeVeiculos.Dominio.SevicosModule;
using LocadoraDeVeiculos.Dominio.VeiculoModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Controladores.LocacaoModule
{
    public class ControladorLocacao : Controlador<Locacao>
    {
        private ControladorVeiculo controladorVeiculo = null;
        private ControladorFuncionario controladorFuncionario = null;
        private ControladorCliente controladorCliente = null;
        private ControladorServico controladorServico = null;
        private ControladorCupom controladorCupom = new ControladorCupom();

        public ControladorLocacao(ControladorVeiculo controladorVeiculo, ControladorFuncionario controladorFuncionario, ControladorCliente controladorCliente, ControladorServico controladorServico, ControladorCupom controladorCupom)
        {
            this.controladorVeiculo = controladorVeiculo;
            this.controladorFuncionario = controladorFuncionario;
            this.controladorCliente = controladorCliente;
            this.controladorServico = controladorServico;
            //this.controladorCupom = controladorCupom;
        }

        #region queries
        private const string sqlInserirLocacao =
                @"INSERT INTO[DBO].[TBLOCACAO]
                (
                    [ID_VEICULO],
                    [ID_FUNCIONARIO],
                    [ID_CLIENTECONTRATANTE],
                    [ID_CLIENTECONDUTOR],
                    [ID_CUPOM],
                    [DATADESAIDA],
                    [DATAPREVISTADECHEGADA],
                    [DATADECHEGADA],
                    [TIPODOPLANO],
                    [TIPODESEGURO],
                    [PRECOLOCACAO],
                    [PRECODEVOLUCAO],
                    [ESTAABERTA]
                )
                VALUES
                (
                    @ID_VEICULO,
                    @ID_FUNCIONARIO,
                    @ID_CLIENTECONTRATANTE,
                    @ID_CLIENTECONDUTOR,
                    @ID_CUPOM,
                    @DATADESAIDA,
                    @DATAPREVISTADECHEGADA,
                    @DATADECHEGADA,
                    @TIPODOPLANO,
                    @TIPODESEGURO,
                    @PRECOLOCACAO,
                    @PRECODEVOLUCAO,
                    @ESTAABERTA
                );";

        private const string sqlEditarLocacao =
        @"UPDATE [DBO].[TBLOCACAO] 
                SET
                    [ID_VEICULO] = @ID_VEICULO,
                    [ID_FUNCIONARIO] = @ID_FUNCIONARIO,
                    [ID_CLIENTECONTRATANTE] = @ID_CLIENTECONTRATANTE,
                    [ID_CLIENTECONDUTOR] = @ID_CLIENTECONDUTOR,
                    [ID_CUPOM] = @ID_CUPOM,
                    [DATADESAIDA] = @DATADESAIDA,
                    [DATAPREVISTADECHEGADA] = @DATAPREVISTADECHEGADA,
                    [DATADECHEGADA] = @DATADECHEGADA,
                    [TIPODOPLANO] = @TIPODOPLANO,
                    [TIPODESEGURO] = @TIPODESEGURO,
                    [PRECOLOCACAO] = @PRECOLOCACAO,
                    [PRECODEVOLUCAO] = @PRECODEVOLUCAO,
                    [ESTAABERTA] = @ESTAABERTA
                WHERE 
                    [ID] = @ID;";

        private const string sqlSelecionarTodosLocacaos =
            @"SELECT * FROM [DBO].[TBLOCACAO];";

        private const string sqlSelecionarLocacaoPorId =
            @"SELECT * FROM [DBO].[TBLOCACAO] WHERE [ID] = @ID;";


        private const string sqlDeletarLocacao =
                @"DELETE FROM [DBO].[TBLOCACAO] WHERE [ID] = @ID;";

        string sqlSelecionarIdServicoPorIdLocacao =
            @"SELECT [ID_SERVICO] FROM [TBSERVICO_LOCACAO]
               WHERE [ID_LOCACAO] = @ID_LOCACAO";


        #endregion
        public override string InserirNovo(Locacao registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "VALIDO")
                registro.Id = Db.Insert(sqlInserirLocacao, ObtemParametrosLocacao(registro));

            return resultadoValidacao;
        }
        public override List<Locacao> SelecionarTodos()
        {
            return Db.GetAll(sqlSelecionarTodosLocacaos, ConverterEmLocacao);
        }
        public override Locacao SelecionarPorId(int id)
        {
            return Db.Get(sqlSelecionarLocacaoPorId, ConverterEmLocacao, AdicionarParametro("ID", id));
        }

        private List<Servico> SelecionarServicosComIdLocacao(int idLocacao)
        {
            List<Servico> servicosDaLocacao = new List<Servico>();
            List<int> idsDeServicos = Db.GetAll(sqlSelecionarIdServicoPorIdLocacao, ConverterEmInteiro, AdicionarParametro("ID_LOCACAO", idLocacao));
            foreach (int idServico in idsDeServicos)
            {
                servicosDaLocacao.Add(controladorServico.SelecionarPorId(idServico));
            }
            return servicosDaLocacao;
        }

        public override string Editar(int id, Locacao registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "VALIDO")
            {
                registro.Id = id;
                Db.Update(sqlEditarLocacao, ObtemParametrosLocacao(registro));
            }

            return resultadoValidacao;
        }
        public override bool Excluir(int id)
        {
            try
            {
                Db.Delete(sqlDeletarLocacao, AdicionarParametro("ID", id));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public override bool Existe(int id)
        {
            return Db.Exists(sqlSelecionarLocacaoPorId, AdicionarParametro("ID", id));
        }

        private Dictionary<string, object> ObtemParametrosLocacao(Locacao locacao)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", locacao.Id);
            parametros.Add("ID_VEICULO",locacao.Veiculo.Id);
            parametros.Add("ID_FUNCIONARIO", locacao.FuncionarioLocador.Id);
            parametros.Add("ID_CLIENTECONTRATANTE", locacao.ClienteContratante.Id);
            parametros.Add("ID_CLIENTECONDUTOR", locacao.ClienteCondutor.Id);
            if(locacao.Cupom != null)
                parametros.Add("ID_CUPOM", locacao.Cupom.Id);
            else
                parametros.Add("ID_CUPOM", null);
            parametros.Add("DATADESAIDA", locacao.DataDeSaida);
            parametros.Add("DATAPREVISTADECHEGADA", locacao.DataPrevistaDeChegada);
            parametros.Add("DATADECHEGADA", locacao.DataDeChegada);
            parametros.Add("TIPODOPLANO", locacao.TipoDoPlano);
            parametros.Add("TIPODESEGURO", locacao.TipoDeSeguro);
            parametros.Add("PRECOLOCACAO", locacao.PrecoLocacao);
            parametros.Add("PRECODEVOLUCAO", locacao.PrecoDevolucao);
            parametros.Add("ESTAABERTA", locacao.EstaAberta);
            return parametros;
        }

        private int ConverterEmInteiro(IDataReader reader)
        {
            return Convert.ToInt32(reader["ID_SERVICO"]);
        }

        private Locacao ConverterEmLocacao(IDataReader reader)
        {
            var id = Convert.ToInt32(reader["ID"]);
            var id_veiculo = Convert.ToInt32(reader["ID_VEICULO"]);
            var id_funcionario = Convert.ToInt32(reader["ID_FUNCIONARIO"]);
            var id_clienteContratante = Convert.ToInt32(reader["ID_CLIENTECONTRATANTE"]);
            var id_clienteCondutor = Convert.ToInt32(reader["ID_CLIENTECONDUTOR"]);
            var id_cupom = 0;
            if (reader["ID_CUPOM"] != DBNull.Value)
                id_cupom = Convert.ToInt32(reader["ID_CUPOM"]);
            //pode haver problemas com retorno null. caso ocorrer, fazer algo como:
            //if (!int.TryParse(reader["ID_CLIENTECONDUTOR"].ToString(), out int id_clienteCondutor))
            //    id_clienteCondutor = -1;
            var dataDeSaida = Convert.ToDateTime(reader["DATADESAIDA"]);
            var dataPrevistaDeChegada = Convert.ToDateTime(reader["DATAPREVISTADECHEGADA"]);
            var dataDeChegada = Convert.ToDateTime(reader["DATADECHEGADA"]);
            var tipoDoPlano = Convert.ToString(reader["TIPODOPLANO"]);
            var tipoDeSeguro = Convert.ToString(reader["TIPODESEGURO"]);
            var precoLocacao = Convert.ToDouble(reader["PRECOLOCACAO"]);
            var precoDevolucao = Convert.ToDouble(reader["PRECODEVOLUCAO"]);
            var estaAberta = Convert.ToBoolean(reader["ESTAABERTA"]);

            List <Servico>  servicosDaLocacao = SelecionarServicosComIdLocacao(id);
            //foreach (Servico servico in controladorServico.SelecionarTodos())
            //{
            //    List<int> idsDeServicos = SelecionarServicosComIdLocacao(id);
            //    if (idsDeServicos.Contains(servico.Id))
            //        servicosDaLocacao.Add(servico);
            //}

            Veiculo veiculo = controladorVeiculo.SelecionarPorId(id_veiculo);
            Funcionario funcionarioLocador = controladorFuncionario.SelecionarPorId(id_funcionario);
            Cliente clienteContratante = controladorCliente.SelecionarPorId(id_clienteContratante);
            Cliente clienteCondutor = controladorCliente.SelecionarPorId(id_clienteCondutor);
            Cupom cupom;
            if (id_cupom != 0)
                cupom = controladorCupom.SelecionarPorId(id_cupom);
            else
                cupom = null;

            return new Locacao(id, veiculo, funcionarioLocador, clienteContratante, clienteCondutor, cupom, dataDeSaida, dataPrevistaDeChegada, dataDeChegada, tipoDoPlano, tipoDeSeguro, precoLocacao, precoDevolucao, estaAberta, servicosDaLocacao);
        }
    }
}
