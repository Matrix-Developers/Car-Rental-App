using LocadoraDeVeiculos.Controladores.Shared;
using LocadoraDeVeiculos.Dominio.LocacaoModule;
using LocadoraDeVeiculos.Dominio.RelacionamentoLocServModule;
using LocadoraDeVeiculos.Dominio.SevicosModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Controladores.RelacionamentoLocServModule
{
    public class ControladorRelacionamentoLocServ : Controlador<RelacionamentoLocServ>
    {
        private int id = 0;
        #region queries Relacionamento
        private const string sqlInserirRelacao =
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

        private const string sqlEditarRelacao =
        @"UPDATE [DBO].[TBSERVICO_LOCACAO] 
                SET
                    [ID_LOCACAO] = @ID_LOCACAO,
                    [ID_SERVICO] = @ID_SERVICO
                WHERE 
                    [ID] = @ID;";

        private const string sqlSelecionarTodasRelacoes =
            @"SELECT * FROM [DBO].[TBSERVICO_LOCACAO];";

        private const string sqlSelecionarRelacaoPorId =
            @"SELECT * FROM [DBO].[TBSERVICO_LOCACAO] WHERE [ID] = @ID;";

        private const string sqlDeletarRelacao =
            @"DELETE FROM [DBO].[TBSERVICO_LOCACAO] WHERE [ID] = @ID;";

        #endregion
        public override string Editar(int id, RelacionamentoLocServ registro)
        {
            throw new NotImplementedException();
        }

        public override bool Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public override bool Existe(int id)
        {
            throw new NotImplementedException();
        }

        public override string InserirNovo(RelacionamentoLocServ registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "VALIDO")
                foreach (Servico servico in registro.Servicos)
                {
                    id = servico.Id;
                    Db.Insert(sqlInserirRelacao, ObtemParametrosRelacao(registro));
                }

            return resultadoValidacao;
        }

        public override RelacionamentoLocServ SelecionarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public override List<RelacionamentoLocServ> SelecionarTodos()
        {
            throw new NotImplementedException();
        }

        private Dictionary<string, object> ObtemParametrosRelacao(RelacionamentoLocServ relacionamento)
        {
            var parametros = new Dictionary<string, object>();
            parametros.Add("ID", relacionamento.Id);
            parametros.Add("ID_LOCACAO", relacionamento.Locacao.Id);
            parametros.Add("ID_SERVICO", id);

            return parametros;
        }
    }
}
