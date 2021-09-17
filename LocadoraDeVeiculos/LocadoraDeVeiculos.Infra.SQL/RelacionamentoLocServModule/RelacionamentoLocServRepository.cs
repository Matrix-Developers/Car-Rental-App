using LocadoraDeVeiculos.Controladores.ClientesModule;
using LocadoraDeVeiculos.Controladores.CupomModule;
using LocadoraDeVeiculos.Controladores.FuncionarioModule;
using LocadoraDeVeiculos.Controladores.LocacaoModule;
using LocadoraDeVeiculos.Controladores.ServicoModule;
using LocadoraDeVeiculos.Controladores.Shared;
using LocadoraDeVeiculos.Controladores.VeiculoModule;
using LocadoraDeVeiculos.Dominio.LocacaoModule;
using LocadoraDeVeiculos.Dominio.RelacionamentoLocServModule;
using LocadoraDeVeiculos.Dominio.SevicosModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Infra.SQL.Shared;
using System;
using System.Collections.Generic;
using System.Data;

namespace LocadoraDeVeiculos.Controladores.RelacionamentoLocServModule
{
    public class RelacionamentoLocServRepository : RepositoryBase<RelacionamentoLocServ>, IRepository<RelacionamentoLocServ>       //essa classe está parcialmente obsoleta
    {
        private int id = 0;
        readonly ServicoRepository controladorServico = new();
        readonly LocacaoRepository controladorLocacao = new(new VeiculoRepository(), new FuncionarioRepository(), new ClienteRepository(), new ServicoRepository(), new CupomRepository());

        #region queries
        protected override string SqlInserirEntidade
        {
            get
            {
                return
                @"INSERT INTO[DBO].[TBSERVICO_LOCACAO]
                (
                    [ID_LOCACAO],
                    [ID_SERVICO]
                )
                VALUES
                (
                    @ID_LOCACAO,
                    @ID_SERVICO
                );";
            }
        }
        protected override string SqlEditarEntidade
        {
            get
            {
                return
                @"UPDATE [DBO].[TBSERVICO_LOCACAO] 
                SET
                    [ID_LOCACAO] = @ID_LOCACAO,
                    [ID_SERVICO] = @ID_SERVICO
                WHERE 
                    [ID] = @ID;";
            }
        }
        protected override string SqlExcluirEntidade
        {
            get
            {
                return @"DELETE FROM [DBO].[TBSERVICO_LOCACAO] WHERE [ID] = @ID;";
            }
        }
        protected override string SqlSelecionarEntidadePorId
        {
            get
            {
                return @"SELECT * FROM [DBO].[TBSERVICO_LOCACAO] WHERE [ID] = @ID;";
            }
        }
        protected override string SqlSelecionarTodasEntidades
        {
            get
            {
                return @"SELECT * FROM [DBO].[TBSERVICO_LOCACAO];";
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
                        [TBSERVICO_LOCACAO]
                    WHERE 
                        [ID] = @ID";
            }
        }
        //chamada unica do RelacionamentoLocServ
        private const string sqlSelecionarRelacaoPorLocacao =
            @"SELECT * FROM [DBO].[TBSERVICO_LOCACAO] WHERE [ID_LOCACAO] = @ID_LOCACAO;";
        //
        #endregion

        public string Editar(int id, RelacionamentoLocServ registro)
        {
            throw new NotImplementedException();
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
        public string InserirNovo(RelacionamentoLocServ registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "VALIDO")
                foreach (Servico servico in registro.Servicos)
                {
                    id = servico.Id;
                    registro.Id = Db.Insert(SqlInserirEntidade, ObtemParametros(registro));
                }

            return resultadoValidacao;
        }
        public RelacionamentoLocServ SelecionarPorId(int id)
        {
            return Db.Get(SqlSelecionarEntidadePorId, ConverterEmEntidade, AdicionarParametro("ID", id));
        }

        //metodos unicos do RelacionamentoLocServ
        public object SelecionarPorLocacao(int id)
        {
            return Db.GetAll(sqlSelecionarRelacaoPorLocacao, ConverterEmEntidade, AdicionarParametro("ID_LOCACAO", id));
        }
        public List<RelacionamentoLocServ> SelecionarTodos()
        {
            return Db.GetAll(SqlSelecionarTodasEntidades, ConverterEmEntidade);
        }
        //

        protected override Dictionary<string, object> ObtemParametros(RelacionamentoLocServ entidade)
        {
            var parametros = new Dictionary<string, object>
            {
                { "ID", entidade.Id },
                { "ID_LOCACAO", entidade.Locacao.Id },
                { "ID_SERVICO", id }
            };

            return parametros;
        }
        protected override RelacionamentoLocServ ConverterEmEntidade(IDataReader reader)
        {
            var id = Convert.ToInt32(reader["ID"]);
            var id_locacao = Convert.ToInt32(reader["ID_LOCACAO"]);
            var id_servico = Convert.ToInt32(reader["ID_SERVICO"]);

            List<Servico> filtrado = new();
            foreach (Servico item in controladorServico.SelecionarTodos())
                if (item.Id == id_servico)
                    filtrado.Add(item);
            Locacao locacao = controladorLocacao.SelecionarPorId(id_locacao);

            return new RelacionamentoLocServ(id, locacao, filtrado);
        }
    }
}
