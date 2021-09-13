using LocadoraDeVeiculos.Controladores.Shared;
using LocadoraDeVeiculos.Dominio.CupomModule;
using LocadoraDeVeiculos.Dominio.ParceiroModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Controladores.CupomModule
{
    public class ControladorCupom : Controlador<Cupom>
    {
        #region queries
        private const string sqlInserirCupom =
           @"INSERT INTO [TBCUPOM_DESCONTO]
                (
                    [NOMECUPOM],
                    [CODIGO],      
                    [VALORMINIMO],
                    [VALOR], 
                    [EHDESCONTOFIXO],
                    [VALIDADE],                    
                    [ID_PARCEIRO],
                    [QTDUTILIZADA]
                )
            VALUES
                (
                    @NOMECUPOM,
                    @CODIGO,
                    @VALORMINIMO,
                    @VALOR,
                    @EHDESCONTOFIXO,
                    @VALIDADE,
                    @ID_PARCEIRO,
                    @QTDUTILIZADA
                )";

        private const string sqlEditarCupom =
            @" UPDATE [TBCUPOM_DESCONTO]
                SET 
                    [NOMECUPOM] = @NOMECUPOM, 
                    [CODIGO] = @CODIGO, 
                    [VALORMINIMO] = @VALORMINIMO,
                    [VALOR] = @VALOR, 
                    [EHDESCONTOFIXO] = @EHDESCONTOFIXO,
                    [VALIDADE] = @VALIDADE,
                    [ID_PARCEIRO] = @ID_PARCEIRO,
                    [QTDUTILIZADA] = @QTDUTILIZADA
                WHERE [ID] = @ID";

        private const string sqlDeletarCupom =
            @"DELETE FROM [TBCUPOM_DESCONTO] 
                WHERE [ID] = @ID";

        private const string sqlSelecionarTodosCupons =
            @"SELECT 
                    D.[ID],       
                    D.[NOMECUPOM],       
                    D.[CODIGO], 
                    D.[VALORMINIMO],
                    D.[VALOR],                    
                    D.[EHDESCONTOFIXO],                                                           
                    D.[VALIDADE],
                    D.[ID_PARCEIRO],
                    D.[QTDUTILIZADA],
                    P.[ID],
                    P.[NOMEPARCEIRO]
            FROM
                [TBCUPOM_DESCONTO] AS D INNER JOIN
                [TBPARCEIRO] AS P
            ON
                D.ID_PARCEIRO = P.ID";
        private const string sqlSelecionarCupomPorId =
            @"SELECT 
                    D.[ID],       
                    D.[NOMECUPOM],       
                    D.[CODIGO], 
                    D.[VALORMINIMO],
                    D.[VALOR],                    
                    D.[EHDESCONTOFIXO],                                                           
                    D.[VALIDADE],
                    D.[ID_PARCEIRO],
                    D.[QTDUTILIZADA],
                    P.[ID],
                    P.[NOMEPARCEIRO]
            FROM
                [TBCUPOM_DESCONTO] AS D INNER JOIN
                [TBPARCEIRO] AS P
            ON
                D.ID_PARCEIRO = P.ID
            WHERE 
                D.[ID] = @ID";

        private const string sqlSelecionarCupomPorCodigo =
            @"SELECT 
                    D.[ID],       
                    D.[NOMECUPOM],       
                    D.[CODIGO], 
                    D.[VALORMINIMO],
                    D.[VALOR],                    
                    D.[EHDESCONTOFIXO],                                                           
                    D.[VALIDADE],
                    D.[ID_PARCEIRO],
                    D.[QTDUTILIZADA],
                    P.[ID],
                    P.[NOMEPARCEIRO]
            FROM
                [TBCUPOM_DESCONTO] AS D INNER JOIN
                [TBPARCEIRO] AS P
            ON
                D.ID_PARCEIRO = P.ID
            WHERE 
                D.[CODIGO] = @CODIGO";

        private const string sqlExisteCupom =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBCUPOM_DESCONTO]
            WHERE 
                [ID] = @ID";

        private const string sqlExisteCodigo =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBCUPOM_DESCONTO]
            WHERE 
                [CODIGO] = @CODIGO";
        #endregion
        public override string InserirNovo(Cupom registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "VALIDO")
                registro.Id = Db.Insert(sqlInserirCupom, ObtemParametrosCupom(registro));

            return resultadoValidacao;
        }

        public override List<Cupom> SelecionarTodos()
        {
            return Db.GetAll(sqlSelecionarTodosCupons, ConverterEmCupom);
        }

        public override Cupom SelecionarPorId(int id)
        {
            return Db.Get(sqlSelecionarCupomPorId, ConverterEmCupom, AdicionarParametro("ID", id));
        }

        public Cupom SelecionarPorCodigo(string codigo)
        {
            return Db.Get(sqlSelecionarCupomPorCodigo, ConverterEmCupom, AdicionarParametro("CODIGO", codigo));
        }

        public override string Editar(int id, Cupom registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "VALIDO")
            {
                registro.Id = id;
                Db.Update(sqlEditarCupom, ObtemParametrosCupom(registro));
            }

            return resultadoValidacao;
        }

        public void AtualizarQtdUtilizada(int id, int qtdUtilizada)
        {
            Db.Update(sqlEditarCupom, ObtemParametrosQtdUtilizada(id, qtdUtilizada));
        }        

        public override bool Excluir(int id)
        {
            try
            {
                Db.Delete(sqlDeletarCupom, AdicionarParametro("ID", id));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public override bool Existe(int id)
        {
            return Db.Exists(sqlExisteCupom, AdicionarParametro("ID", id));
        }

        public bool ExisteCodigo(string codigo)
        {
            return Db.Exists(sqlExisteCodigo, AdicionarParametro("CODIGO", codigo));
        }
        private Dictionary<string, object> ObtemParametrosQtdUtilizada(int id, int qtdUtilizada)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", id);
            parametros.Add("QTDUTILIZADA", qtdUtilizada);

            return parametros;
        }
        private Dictionary<string, object> ObtemParametrosCupom(Cupom registro)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", registro.Id);
            parametros.Add("NOMECUPOM", registro.Nome);
            parametros.Add("CODIGO", registro.Codigo);
            parametros.Add("VALORMINIMO", registro.ValorMinimo);
            parametros.Add("VALOR", registro.Valor);
            parametros.Add("EHDESCONTOFIXO", registro.EhDescontoFixo);
            parametros.Add("VALIDADE", registro.Validade);
            parametros.Add("ID_PARCEIRO", registro.Parceiro.Id);
            parametros.Add("QTDUTILIZADA", registro.QtdUtilizada);

            return parametros;
        }

        private Cupom ConverterEmCupom(IDataReader reader)
        {
            int id = Convert.ToInt32(reader["ID"]);
            string nome = Convert.ToString(reader["NOMECUPOM"]);
            string codigo = Convert.ToString(reader["CODIGO"]);
            double valorMinimo = Convert.ToDouble(reader["VALORMINIMO"]);
            double valor = Convert.ToDouble(reader["VALOR"]);
            bool ehDescontoFixo = Convert.ToBoolean(reader["EHDESCONTOFIXO"]);
            DateTime validade = Convert.ToDateTime(reader["VALIDADE"]);
            int qtdUtilizada = Convert.ToInt32(reader["QTDUTILIZADA"]);

            int idParceiro = Convert.ToInt32(reader["ID_PARCEIRO"]);
            string nomeParceiro = Convert.ToString(reader["NOMEPARCEIRO"]);
            Parceiro parceiro = new Parceiro(idParceiro, nomeParceiro);


            Cupom cupom = new Cupom(id, nome, codigo, valor, valorMinimo, ehDescontoFixo, validade, parceiro, qtdUtilizada);

            cupom.Id = id;

            return cupom;
        }
    }
}
