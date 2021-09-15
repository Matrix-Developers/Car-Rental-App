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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Controladores.RelacionamentoLocServModule
{
    public class RelacionamentoLocServRepository : RepositoryBase<RelacionamentoLocServ>, IRepository<RelacionamentoLocServ>       //essa classe está parcialmente obsoleta
    {
        private int id = 0;
        ServicoRepository controladorServico = new ServicoRepository();
        LocacaoRepository controladorLocacao = new LocacaoRepository(new VeiculoRepository(), new FuncionarioRepository(), new ClienteRepository(), new ServicoRepository(), new CupomRepository());

        #region queries
        private const string sqlInserirEntidade =
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

        private const string sqlEditarEntidade =
        @"UPDATE [DBO].[TBSERVICO_LOCACAO] 
                SET
                    [ID_LOCACAO] = @ID_LOCACAO,
                    [ID_SERVICO] = @ID_SERVICO
                WHERE 
                    [ID] = @ID;";

        private const string sqlSelecionarTodasEntidades =
            @"SELECT * FROM [DBO].[TBSERVICO_LOCACAO];";

        private const string sqlSelecionarEntidadesPorId =
            @"SELECT * FROM [DBO].[TBSERVICO_LOCACAO] WHERE [ID] = @ID;";

        private const string sqlDeletarEntidade =
            @"DELETE FROM [DBO].[TBSERVICO_LOCACAO] WHERE [ID] = @ID;";

        private const string sqlSelecionarRelacaoPorLocacao =
            @"SELECT * FROM [DBO].[TBSERVICO_LOCACAO] WHERE [ID_LOCACAO] = @ID_LOCACAO;";

        #endregion

        public string Editar(int id, RelacionamentoLocServ registro)
        {
            throw new NotImplementedException();
        }
        public bool Excluir(int id)
        {
            try
            {
                Db.Delete(sqlDeletarEntidade, AdicionarParametro("ID", id));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
        public bool Existe(int id)
        {
            return Db.Exists(sqlSelecionarEntidadesPorId, AdicionarParametro("ID", id));
        }
        public string InserirNovo(RelacionamentoLocServ registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "VALIDO")
                foreach (Servico servico in registro.Servicos)
                {
                    id = servico.Id;
                    registro.Id = Db.Insert(sqlInserirEntidade, ObtemParametros(registro));
                }

            return resultadoValidacao;
        }
        public RelacionamentoLocServ SelecionarPorId(int id)
        {
            return Db.Get(sqlSelecionarEntidadesPorId, ConverterEmEntidade, AdicionarParametro("ID", id));
        }

        public object SelecionarPorLocacao(int id)
        {
            return Db.GetAll(sqlSelecionarRelacaoPorLocacao, ConverterEmEntidade, AdicionarParametro("ID_LOCACAO", id));
        }
        public List<RelacionamentoLocServ> SelecionarTodos()
        {
            return Db.GetAll(sqlSelecionarTodasEntidades, ConverterEmEntidade);
        }

        protected override Dictionary<string, object> ObtemParametros(RelacionamentoLocServ entidade)
        {
            var parametros = new Dictionary<string, object>();
            parametros.Add("ID", entidade.Id);
            parametros.Add("ID_LOCACAO", entidade.Locacao.Id);
            parametros.Add("ID_SERVICO", id);

            return parametros;
        }
        protected override RelacionamentoLocServ ConverterEmEntidade(IDataReader reader)
        {
            var id = Convert.ToInt32(reader["ID"]);
            var id_locacao = Convert.ToInt32(reader["ID_LOCACAO"]);
            var id_servico = Convert.ToInt32(reader["ID_SERVICO"]);

            List<Servico> filtrado = new List<Servico>();
            foreach (Servico item in controladorServico.SelecionarTodos())
                if (item.Id == id_servico)
                    filtrado.Add(item);
            Locacao locacao = controladorLocacao.SelecionarPorId(id_locacao);

            return new RelacionamentoLocServ(id, locacao, filtrado);
        }
    }
}
