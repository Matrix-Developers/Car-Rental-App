using LocadoraDeVeiculos.Controladores.Shared;
using LocadoraDeVeiculos.Dominio.LocacaoModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Controladores.LocacaoModule
{
    class ControladorLocacao : Controlador<Locacao>
    {
        #region queries
        private const string sqlInserirLocacao =
            @"";

        private const string sqlSelecionarTodosLocacaos =
            @"";

        private const string sqlSelecionarLocacaoPorId =
            @"";

        private const string sqlEditarLocacao =
            @"";
        private const string sqlDeletarLocacao =
            @"";

        private const string sqlExisteLocacao =
            @"";

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
            return Db.GetAll(sqlSelecionarTodosLocacaos, ConverterEmVeiculo);
        }
        public override Locacao SelecionarPorId(int id)
        {
            return Db.Get(sqlSelecionarLocacaoPorId, ConverterEmVeiculo, AdicionarParametro("ID", id));
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
            return Db.Exists(sqlExisteLocacao, AdicionarParametro("ID", id));
        }

        private Dictionary<string, object> ObtemParametrosLocacao(Locacao locacao)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", locacao.Id);
            parametros.Add("ID_VEICULO",locacao.Veiculo.Id);
            parametros.Add("ID_FUNCIONARIO", locacao.FuncionarioLocador.Id);
            parametros.Add("ID_CLIENTECONTRATANTE", locacao.ClienteContratante.Id);
            parametros.Add("ID_CLIENTECONDUTOR", locacao.ClienteCondutor);
            parametros.Add("DATADESAIDA", locacao.DataDeSaida.ToString());
            parametros.Add("DATAPREVISTADECHEGADA", locacao.DataPrevistaDeChegada.ToString());
            parametros.Add("TIPODOPLANO", locacao.TipoDoPlano);
            parametros.Add("TIPODOSEGURO", locacao.TipoDeSeguro);
            parametros.Add("PRECOLOCACAO", locacao.PrecoLocacao);

            return parametros;
        }

        private Locacao ConverterEmVeiculo(IDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
