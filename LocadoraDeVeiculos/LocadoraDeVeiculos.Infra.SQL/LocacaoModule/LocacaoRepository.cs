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
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Dominio.VeiculoModule;
using LocadoraDeVeiculos.Infra.SQL.Shared;
using System;
using System.Collections.Generic;
using System.Data;

namespace LocadoraDeVeiculos.Controladores.LocacaoModule
{
    public class LocacaoRepository : RepositoryBase<Locacao>, IRepository<Locacao>
    {
        private readonly VeiculoRepository controladorVeiculo = null;
        private readonly FuncionarioRepository controladorFuncionario = null;
        private readonly ClienteRepository controladorCliente = null;
        private readonly ServicoRepository controladorServico = null;
        private readonly CupomRepository controladorCupom = null;

        public LocacaoRepository(VeiculoRepository controladorVeiculo, FuncionarioRepository controladorFuncionario, ClienteRepository controladorCliente, ServicoRepository controladorServico, CupomRepository controladorCupom)
        {
            this.controladorVeiculo = controladorVeiculo;
            this.controladorFuncionario = controladorFuncionario;
            this.controladorCliente = controladorCliente;
            this.controladorServico = controladorServico;
            this.controladorCupom = controladorCupom;
        }

        #region queries
        protected override string SqlInserirEntidade
        {
            get
            {
                return
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
            }
        }
        protected override string SqlEditarEntidade
        {
            get
            {
                return
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
            }
        }
        protected override string SqlExcluirEntidade
        {
            get
            {
                return @"DELETE FROM [DBO].[TBLOCACAO] WHERE [ID] = @ID;";
            }
        }
        protected override string SqlSelecionarEntidadePorId
        {
            get
            {
                return @"SELECT * FROM [DBO].[TBLOCACAO] WHERE [ID] = @ID;";
            }
        }
        protected override string SqlSelecionarTodasEntidades
        {
            get
            {
                return @"SELECT * FROM [DBO].[TBLOCACAO];";
            }
        }
        protected override string SqlExisteEntidade
        {
            get
            {
                return
                    @"SELECT 
                        COUNT(*) 
                    FROM 
                        [TBLOCACAO]
                    WHERE 
                        [ID] = @ID";
            }
        }

        //chamada unica do Locacao
        readonly string sqlSelecionarIdServicoPorIdLocacao =
            @"SELECT [ID_SERVICO] FROM [TBSERVICO_LOCACAO]
               WHERE [ID_LOCACAO] = @ID_LOCACAO";
        //
        #endregion

        public string InserirNovo(Locacao registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "VALIDO")
                registro.Id = Db.Insert(SqlInserirEntidade, ObtemParametros(registro));

            return resultadoValidacao;
        }
        public List<Locacao> SelecionarTodos()
        {
            return Db.GetAll(SqlSelecionarTodasEntidades, ConverterEmEntidade);
        }
        public Locacao SelecionarPorId(int id)
        {
            return Db.Get(SqlSelecionarEntidadePorId, ConverterEmEntidade, AdicionarParametro("ID", id));
        }
        public string Editar(int id, Locacao registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "VALIDO")
            {
                registro.Id = id;
                Db.Update(SqlEditarEntidade, ObtemParametros(registro));
            }

            return resultadoValidacao;
        }
        public bool Excluir(int id)
        {
            try
            {
                Db.Delete(SqlExcluirEntidade, AdicionarParametro("ID", id));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
        public bool Existe(int id)
        {
            return Db.Exists(SqlSelecionarEntidadePorId, AdicionarParametro("ID", id));
        }

        //metodos unicos do Locacao
        private List<Servico> SelecionarServicosComIdLocacao(int idLocacao)
        {
            List<Servico> servicosDaLocacao = new();
            List<int> idsDeServicos = Db.GetAll(sqlSelecionarIdServicoPorIdLocacao, ConverterEmInteiro, AdicionarParametro("ID_LOCACAO", idLocacao));
            foreach (int idServico in idsDeServicos)
            {
                servicosDaLocacao.Add(controladorServico.SelecionarPorId(idServico));
            }
            return servicosDaLocacao;
        }
        private int ConverterEmInteiro(IDataReader reader)
        {
            return Convert.ToInt32(reader["ID_SERVICO"]);
        }
        //

        protected override Dictionary<string, object> ObtemParametros(Locacao entidade)
        {
            var parametros = new Dictionary<string, object>
            {
                { "ID", entidade.Id },
                { "ID_VEICULO", entidade.Veiculo.Id },
                { "ID_FUNCIONARIO", entidade.FuncionarioLocador.Id },
                { "ID_CLIENTECONTRATANTE", entidade.ClienteContratante.Id },
                { "ID_CLIENTECONDUTOR", entidade.ClienteCondutor.Id }
            };
            if (entidade.Cupom != null)
                parametros.Add("ID_CUPOM", entidade.Cupom.Id);
            else
                parametros.Add("ID_CUPOM", null);
            parametros.Add("DATADESAIDA", entidade.DataDeSaida);
            parametros.Add("DATAPREVISTADECHEGADA", entidade.DataPrevistaDeChegada);
            parametros.Add("DATADECHEGADA", entidade.DataDeChegada);
            parametros.Add("TIPODOPLANO", entidade.TipoDoPlano);
            parametros.Add("TIPODESEGURO", entidade.TipoDeSeguro);
            parametros.Add("PRECOLOCACAO", entidade.PrecoLocacao);
            parametros.Add("PRECODEVOLUCAO", entidade.PrecoDevolucao);
            parametros.Add("ESTAABERTA", entidade.EstaAberta);
            return parametros;
        }
        protected override Locacao ConverterEmEntidade(IDataReader reader)
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

            List<Servico> servicosDaLocacao = SelecionarServicosComIdLocacao(id);
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
