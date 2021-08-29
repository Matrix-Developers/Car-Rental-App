using LocadoraDeVeiculos.Controladores.Shared;
using LocadoraDeVeiculos.Dominio.RelacionamentoLocServModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Controladores.RelacionamentoLocServModule
{
    public class ControladorRelacionamentoLocServ : Controlador<RelacionamentoLocServ>
    {
        #region queries Relacionamento
        private const string sqlInserirRelacao =
                @"INSERT INTO[DBO].[TBSERVICO_LOCACAO]
                (
                    [ID_LOCACAO],
                    [ID_SEVICO]
                )
                VALUES
                (
                    @ID_LOCACAO,
                    @ID_SEVICO)
                );";

        private const string sqlEditarRelacao =
        @"UPDATE [DBO].[TBSERVICO_LOCACAO] 
                SET
                    [ID_LOCACAO] = @ID_LOCACAO,
                    [ID_SEVICO] = @ID_SEVICO
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
            foreach (var servico in servicosSelecionados)
                Db.Insert(sqlInserirRelacao, ObtemParametrosRelacao(locacao, servico));
        }

        public override RelacionamentoLocServ SelecionarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public override List<RelacionamentoLocServ> SelecionarTodos()
        {
            throw new NotImplementedException();
        }

        private Dictionary<string, object> ObtemParametrosRelacao(Locacao locacao, Servico servico)
        {
            var parametros = new Dictionary<string, object>();
            parametros.Add("ID", relacionamento.Id);
            parametros.Add("ID_LOCACAO", locacao.Id);
            parametros.Add("ID_SERVICO", servico.Id);

            return parametros;
        }
    }
}
