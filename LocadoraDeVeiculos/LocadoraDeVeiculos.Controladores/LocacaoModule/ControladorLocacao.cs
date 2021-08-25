using LocadoraDeVeiculos.Controladores.ClientesModule;
using LocadoraDeVeiculos.Controladores.FuncionarioModule;
using LocadoraDeVeiculos.Controladores.Shared;
using LocadoraDeVeiculos.Controladores.VeiculoModule;
using LocadoraDeVeiculos.Dominio.ClienteModule;
using LocadoraDeVeiculos.Dominio.FuncionarioModule;
using LocadoraDeVeiculos.Dominio.LocacaoModule;
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

        public ControladorLocacao(ControladorVeiculo controladorVeiculo, ControladorFuncionario controladorFuncionario, ControladorCliente controladorCliente)
        {
            this.controladorVeiculo = controladorVeiculo;
            this.controladorFuncionario = controladorFuncionario;
            this.controladorCliente = controladorCliente;
        }

        #region queries
        private const string sqlInserirLocacao =
                @"INSERT INTO[DBO].[TBLOCACAO]
                (
                    [ID_VEICULO],
                    [ID_FUNCIONARIO],
                    [ID_CLIENTECONTRATANTE],
                    [ID_CLIENTECONDUTOR],
                    [DATADESAIDA],
                    [DATAPREVISTADECHEGADA],
                    [TIPODOPLANO],
                    [TIPODESEGURO],
                    [PRECOLOCACAO]
                )
                VALUES
                (
                    @ID_VEICULO,
                    @ID_FUNCIONARIO,
                    @ID_CLIENTECONTRATANTE,
                    @ID_CLIENTECONDUTOR,
                    @DATADESAIDA,
                    @DATAPREVISTADECHEGADA,
                    @TIPODOPLANO,
                    @TIPODESEGURO,
                    @PRECOLOCACAO
                );";

        private const string sqlEditarLocacao =
        @"UPDATE [DBO].[TBLOCACAO] 
                SET
                    [ID_VEICULO] = @ID_VEICULO,
                    [ID_FUNCIONARIO] = @ID_FUNCIONARIO,
                    [ID_CLIENTECONTRATANTE] = @ID_CLIENTECONTRATANTE,
                    [ID_CLIENTECONDUTOR] = @ID_CLIENTECONDUTOR,
                    [DATADESAIDA] = @DATADESAIDA,
                    [DATAPREVISTADECHEGADA] = @DATAPREVISTADECHEGADA,
                    [TIPODOPLANO] = @TIPODOPLANO,
                    [TIPODESEGURO] = @TIPODESEGURO,
                    [PRECOLOCACAO] = @PRECOLOCACAO
                WHERE 
                    [ID] = @ID;";

        private const string sqlSelecionarTodosLocacaos =
            @"SELECT * FROM [DBO].[TBLOCACAO];";

        private const string sqlSelecionarLocacaoPorId =
            @"SELECT * FROM [DBO].[TBLOCACAO] WHERE [ID] = @ID;";


        private const string sqlDeletarLocacao =
                @"DELETE FROM [DBO].[TBLOCACAO] WHERE [ID] = @ID;";

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
            parametros.Add("DATADESAIDA", locacao.DataDeSaida);
            parametros.Add("DATAPREVISTADECHEGADA", locacao.DataPrevistaDeChegada);
            parametros.Add("TIPODOPLANO", locacao.TipoDoPlano);
            parametros.Add("TIPODESEGURO", locacao.TipoDeSeguro);
            parametros.Add("PRECOLOCACAO", locacao.PrecoLocacao);

            return parametros;
        }

        private Locacao ConverterEmLocacao(IDataReader reader)
        {
            var id = Convert.ToInt32(reader["ID"]);
            var id_veiculo = Convert.ToInt32(reader["ID_VEICULO"]);
            var id_funcionario = Convert.ToInt32(reader["ID_FUNCIONARIO"]);
            var id_clienteContratante = Convert.ToInt32(reader["ID_CLIENTECONTRATANTE"]);
            var id_clienteCondutor = Convert.ToInt32(reader["ID_CLIENTECONDUTOR"]);
            //pode haver problemas com retorno null. caso ocorrer, fazer algo como:
            //if (!int.TryParse(reader["ID_CLIENTECONDUTOR"].ToString(), out int id_clienteCondutor))
            //    id_clienteCondutor = -1;
            var dataDeSaida = Convert.ToDateTime(reader["DATADESAIDA"]);
            var dataPrevistaDeChegada = Convert.ToDateTime(reader["DATAPREVISTADECHEGADA"]);
            var tipoDePlano = Convert.ToString(reader["TIPODOPLANO"]);
            var tipoDeSeguro = Convert.ToString(reader["TIPODESEGURO"]);
            var precoLocacao = Convert.ToDouble(reader["PRECOLOCACAO"]);

            Veiculo veiculo = controladorVeiculo.SelecionarPorId(id_veiculo);
            Funcionario funcionario = controladorFuncionario.SelecionarPorId(id_funcionario);
            Cliente clienteContratante = controladorCliente.SelecionarPorId(id_clienteContratante);
            Cliente clienteCondutor = controladorCliente.SelecionarPorId(id_clienteCondutor);

            return new Locacao(id,veiculo,funcionario,clienteContratante,clienteCondutor,dataDeSaida,dataPrevistaDeChegada, tipoDePlano,tipoDeSeguro);
        }
    }
}
