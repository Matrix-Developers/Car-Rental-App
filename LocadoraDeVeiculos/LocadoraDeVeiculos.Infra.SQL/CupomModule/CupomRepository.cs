﻿using LocadoraDeVeiculos.Controladores.Shared;
using LocadoraDeVeiculos.Dominio.CupomModule;
using LocadoraDeVeiculos.Dominio.ParceiroModule;
using LocadoraDeVeiculos.Infra.SQL.Shared;
using Serilog;
using System;
using System.Collections.Generic;
using System.Data;

namespace LocadoraDeVeiculos.Controladores.CupomModule
{
    public class CupomRepository : RepositoryBase<Cupom>, ICupomRepository
    {
        #region queries
        protected override string SqlInserirEntidade
        {
            get
            {
                return
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
            }
        }
        protected override string SqlEditarEntidade
        {
            get
            {
                return
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
            }
        }
        protected override string SqlExcluirEntidade
        {
            get
            {
                return
                    @"DELETE FROM [TBCUPOM_DESCONTO] WHERE [ID] = @ID";
            }
        }
        protected override string SqlSelecionarEntidadePorId
        {
            get
            {
                return
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
                        D.[ID] = @ID ";
            }
        }
        protected override string SqlSelecionarTodasEntidades
        {
            get
            {
                return
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
                        [TBCUPOM_DESCONTO]
                    WHERE 
                        [ID] = @ID";
            }
        }

        //chamadas unicas do cupom
        private const string sqlExisteCodigo =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBCUPOM_DESCONTO]
            WHERE 
                [CODIGO] = @CODIGO";
        private const string sqlEditarQtdUtilizadaCupom =
            @" UPDATE [TBCUPOM_DESCONTO]
                SET 
                    [QTDUTILIZADA] = @QTDUTILIZADA
                WHERE [ID] = @ID";
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
        //
        #endregion

        public bool ExisteCodigo(string codigo)
        {
            
            try
            {
                return Db.Exists(sqlExisteCodigo, AdicionarParametro("CODIGO", codigo));
            }
            catch (Exception ex)
            {

                Log.Error("{DataEHora} / Ocorreu um erro ao tentar Verificar se Existe o Código o(a) {Feature} / Camada: Repository / Usuário: IdUsuario Tempo: ?? / Sql: {query} / {StackTrace}", DateTime.Now, this.ToString(), SqlExcluirEntidade, ex);
                return false;
            }
        }
        public Cupom SelecionarPorCodigo(string codigo)
        {
            try
            {
            return Db.Get(sqlSelecionarCupomPorCodigo, ConverterEmEntidade, AdicionarParametro("CODIGO", codigo));

            }
            catch (Exception ex )
            {
                Log.Error("{DataEHora} / Ocorreu um erro ao tentar Selecionar Por Código um(a) {Feature} / Camada: Repository / Id Processo: {IdProcesso} / Usuário: IdUsuario Tempo: ?? / Sql: {query} / {StackTrace}", DateTime.Now, this.ToString(), codigo, sqlSelecionarCupomPorCodigo, ex);
                return null;
            }
        }
        public void AtualizarQtdUtilizada(Cupom cupom)
        {
            try
            {
                cupom.QtdUtilizada++;
                Db.Update(sqlEditarQtdUtilizadaCupom, ObtemParametrosQtdUtilizada(cupom.Id, cupom.QtdUtilizada));

            }
            catch (Exception ex)
            {
                Log.Error("{DataEHora} / Ocorreu um erro ao tentar Selecionar Por Código um(a) {Feature} / Camada: Repository / Id Processo: {IdProcesso} / Usuário: IdUsuario Tempo: ?? / Sql: {query} / {StackTrace}", DateTime.Now, this.ToString(), cupom.Id, cupom.QtdUtilizada, sqlEditarQtdUtilizadaCupom, ex);
            }
        }
        private static Dictionary<string, object> ObtemParametrosQtdUtilizada(int id, int qtdUtilizada)
        {
            var parametros = new Dictionary<string, object>
            {
                { "ID", id },
                { "QTDUTILIZADA", qtdUtilizada }
            };

            return parametros;
        }

        protected override Dictionary<string, object> ObtemParametros(Cupom entidade)
        {
            var parametros = new Dictionary<string, object>
            {
                { "ID", entidade.Id },
                { "NOMECUPOM", entidade.Nome },
                { "CODIGO", entidade.Codigo },
                { "VALORMINIMO", entidade.ValorMinimo },
                { "VALOR", entidade.Valor },
                { "EHDESCONTOFIXO", entidade.EhDescontoFixo },
                { "VALIDADE", entidade.Validade },
                { "ID_PARCEIRO", entidade.Parceiro.Id },
                { "QTDUTILIZADA", entidade.QtdUtilizada }
            };

            return parametros;
        }
        protected override Cupom ConverterEmEntidade(IDataReader reader)
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
            Parceiro parceiro = new(idParceiro, nomeParceiro);


            Cupom cupom = new(id, nome, codigo, valor, valorMinimo, ehDescontoFixo, validade, parceiro, qtdUtilizada);

            cupom.Id = id;

            return cupom;
        }
    }
}
