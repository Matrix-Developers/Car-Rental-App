using LocadoraDeVeiculos.Controladores.Shared;
using LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Dominio.VeiculoModule;
using LocadoraDeVeiculos.Infra.SQL.Shared;
using System;
using System.Collections.Generic;
using System.Data;

namespace LocadoraDeVeiculos.Controladores.VeiculoModule
{
    public class VeiculoRepository : RepositoryBase<Veiculo>, IRepository<Veiculo>
    {
        #region queries
        protected override string SqlInserirEntidade
        {
            get
            {
                return
                @"INSERT INTO TBVEICULO
                (
                    [MODELO],
                    [ID_GRUPOVEICULO],
                    [PLACA],
                    [CHASSI],      
                    [MARCA], 
                    [COR],
                    [TIPOCOMBUSTIVEL],
                    [CAPACIDADETANQUE],
                    [ANO],
                    [KILOMETRAGEM],
                    [NUMEROPORTAS],
                    [CAPACIDADEPESSOAS],
                    [TAMANHOPORTAMALA],
                    [TEMARCONDICIONADO],
                    [TEMDIRECAOHIDRAULICA],
                    [TEMFREIOSABS],
                    [ESTAALUGADO]
                )
                VALUES
                (
                    @MODELO,
                    @ID_GRUPOVEICULO,
                    @PLACA,
                    @CHASSI,      
                    @MARCA,
                    @COR,
                    @TIPOCOMBUSTIVEL,
                    @CAPACIDADETANQUE,
                    @ANO,
                    @KILOMETRAGEM,
                    @NUMEROPORTAS,
                    @CAPACIDADEPESSOAS,
                    @TAMANHOPORTAMALA,
                    @TEMARCONDICIONADO,
                    @TEMDIRECAOHIDRAULICA,
                    @TEMFREIOSABS,
                    @ESTAALUGADO
                )";
            }
        }
        protected override string SqlEditarEntidade
        {
            get
            {
                return
                @"UPDATE TBVEICULO SET
                    [MODELO] = @MODELO,
                    [ID_GRUPOVEICULO] = @ID_GRUPOVEICULO,
                    [PLACA] = @PLACA,
                    [CHASSI] = @CHASSI,
                    [MARCA] = @MARCA,
                    [COR] = @COR,
                    [TIPOCOMBUSTIVEL] = @TIPOCOMBUSTIVEL,
                    [CAPACIDADETANQUE] = @CAPACIDADETANQUE,
                    [ANO] = @ANO,
                    [KILOMETRAGEM] = @KILOMETRAGEM,
                    [NUMEROPORTAS] = @NUMEROPORTAS,
                    [CAPACIDADEPESSOAS] = @CAPACIDADEPESSOAS,
                    [TAMANHOPORTAMALA] = @TAMANHOPORTAMALA,
                    [TEMARCONDICIONADO] = @TEMARCONDICIONADO,
                    [TEMDIRECAOHIDRAULICA] = @TEMDIRECAOHIDRAULICA,
                    [TEMFREIOSABS] = @TEMFREIOSABS,
                    [ESTAALUGADO] = @ESTAALUGADO
                WHERE
                    [ID] = @ID";
            }
        }
        protected override string SqlExcluirEntidade
        {
            get
            {
                return
                @"DELETE FROM [TBVEICULO] WHERE [ID] = @ID";
            }
        }
        protected override string SqlSelecionarEntidadePorId
        {
            get
            {
                return
                @"SELECT  
                    CV.[ID],
                    CV.[MODELO],
                    CV.[ID_GRUPOVEICULO],
                    CV.[PLACA],
                    CV.[CHASSI],      
                    CV.[MARCA], 
                    CV.[COR],
                    CV.[TIPOCOMBUSTIVEL],
                    CV.[CAPACIDADETANQUE],
                    CV.[ANO],
                    CV.[KILOMETRAGEM],
                    CV.[NUMEROPORTAS],
                    CV.[CAPACIDADEPESSOAS],
                    CV.[TAMANHOPORTAMALA],
                    CV.[TEMARCONDICIONADO],
                    CV.[TEMDIRECAOHIDRAULICA],
                    CV.[TEMFREIOSABS],
                    CV.[ESTAALUGADO],
                    CG.[NOME],
	                CG.[TAXAPLANODIARIO],
	                CG.[TAXAPORKMDIARIO],
	                CG.[TAXAPLANOCONTROLADO],
	                CG.[LIMITEKMCONTROLADO],
	                CG.[TAXAKMEXCEDIDOCONTROLADO],
	                CG.[TAXAPLANOLIVRE]
                FROM 
                    [TBVEICULO] AS CV LEFT JOIN 
                    [TBGRUPOVEICULO] AS CG
                ON
                    CG.ID = CV.ID_GRUPOVEICULO
                WHERE 
                    CV.[ID] = @ID";
            }
        }
        protected override string SqlSelecionarTodasEntidades
        {
            get
            {
                return
                @"SELECT
                    CV.[ID],
                    CV.[MODELO],
                    CV.[ID_GRUPOVEICULO],
                    CV.[PLACA],
                    CV.[CHASSI],      
                    CV.[MARCA], 
                    CV.[COR],
                    CV.[TIPOCOMBUSTIVEL],
                    CV.[CAPACIDADETANQUE],
                    CV.[ANO],
                    CV.[KILOMETRAGEM],
                    CV.[NUMEROPORTAS],
                    CV.[CAPACIDADEPESSOAS],
                    CV.[TAMANHOPORTAMALA],
                    CV.[TEMARCONDICIONADO],
                    CV.[TEMDIRECAOHIDRAULICA],
                    CV.[TEMFREIOSABS],
                    CV.[ESTAALUGADO],
                    CG.[NOME],
	                CG.[TAXAPLANODIARIO],
	                CG.[TAXAPORKMDIARIO],
	                CG.[TAXAPLANOCONTROLADO],
	                CG.[LIMITEKMCONTROLADO],
	                CG.[TAXAKMEXCEDIDOCONTROLADO],
	                CG.[TAXAPLANOLIVRE]
                FROM 
                    [TBVEICULO] AS CV LEFT JOIN 
                    [TBGRUPOVEICULO] AS CG
                ON
                    CG.ID = CV.ID_GRUPOVEICULO";
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
                    [TBVEICULO]
                WHERE 
                    [ID] = @ID";
            }
        }

        //chamadas unicas do Veiculo não utilizadas. Obsoleto?
        //private const string sqlVeiculoTotal = @"SELECT COUNT(*) AS QTD FROM[TBVEICULO]";
        //
        #endregion

        //Metodo sem referencias ou usos. Esta obsoleto?
        //private int ConverterDados(IDataReader reader)
        //{
        //    return Convert.ToInt32(reader["qtd"]);
        //}

        protected override Dictionary<string, object> ObtemParametros(Veiculo entidade)
        {
            var parametros = new Dictionary<string, object>
            {
                { "ID", entidade.Id },
                { "MODELO", entidade.modelo },
                { "ID_GRUPOVEICULO", entidade.grupoVeiculos.Id },
                { "PLACA", entidade.placa },
                { "CHASSI", entidade.chassi },
                { "MARCA", entidade.marca },
                { "COR", entidade.cor },
                { "TIPOCOMBUSTIVEL", entidade.tipoCombustivel },
                { "CAPACIDADETANQUE", entidade.capacidadeTanque },
                { "ANO", entidade.ano },
                { "KILOMETRAGEM", entidade.kilometragem },
                { "NUMEROPORTAS", entidade.numeroPortas },
                { "CAPACIDADEPESSOAS", entidade.capacidadePessoas },
                { "TAMANHOPORTAMALA", entidade.tamanhoPortaMala },
                { "TEMARCONDICIONADO", entidade.temArCondicionado },
                { "TEMDIRECAOHIDRAULICA", entidade.temDirecaoHidraulica },
                { "TEMFREIOSABS", entidade.temFreiosAbs },
                { "ESTAALUGADO", entidade.estaAlugado }
            };

            return parametros;
        }
        protected override Veiculo ConverterEmEntidade(IDataReader reader)
        {
            var id = Convert.ToInt32(reader["ID"]);
            var modelo = Convert.ToString(reader["MODELO"]);
            var id_grupoveiculo = Convert.ToInt32(reader["ID_GRUPOVEICULO"]);
            var placa = Convert.ToString(reader["PLACA"]);
            var chassi = Convert.ToString(reader["CHASSI"]);
            var marca = Convert.ToString(reader["MARCA"]);
            var cor = Convert.ToString(reader["COR"]);
            var tipoCombustivel = Convert.ToString(reader["TIPOCOMBUSTIVEL"]);
            var capacidadeTanque = Convert.ToDouble(reader["capacidadeTanque"]);
            var ano = Convert.ToInt32(reader["ANO"]);
            var quilometragem = Convert.ToDouble(reader["KILOMETRAGEM"]);
            var numeroPortas = Convert.ToInt32(reader["NUMEROPORTAS"]);
            var capacidadePessoas = Convert.ToInt32(reader["CAPACIDADEPESSOAS"]);
            var tamanhoPortaMala = Convert.ToChar(reader["TAMANHOPORTAMALA"]);
            var temArCondicionado = Convert.ToBoolean(reader["TEMARCONDICIONADO"]);
            var temDirecaoHidraulica = Convert.ToBoolean(reader["TEMDIRECAOHIDRAULICA"]);
            var temFreioAbs = Convert.ToBoolean(reader["TEMFREIOSABS"]);
            var estaAlugado = Convert.ToBoolean(reader["ESTAALUGADO"]);

            string nome = Convert.ToString(reader["NOME"]); ;
            double taxaPlanoDiario = Convert.ToDouble(reader["TAXAPLANODIARIO"]);
            double taxaPorKmDiario = Convert.ToDouble(reader["TAXAPORKMDIARIO"]);
            double taxaPlanoControlado = Convert.ToDouble(reader["TAXAPLANOCONTROLADO"]);
            int limiteKmControlado = Convert.ToInt32(reader["LIMITEKMCONTROLADO"]);
            double taxaKmExcedidoControlado = Convert.ToDouble(reader["TAXAKMEXCEDIDOCONTROLADO"]);
            double taxaPlanoLivre = Convert.ToDouble(reader["TAXAPLANOLIVRE"]);

            GrupoDeVeiculo grupo = new(id_grupoveiculo, nome, taxaPlanoDiario, taxaPorKmDiario, taxaPlanoControlado, limiteKmControlado, taxaKmExcedidoControlado, taxaPlanoLivre);

            Veiculo veiculo = new(id, modelo, grupo, placa, chassi, marca, cor, tipoCombustivel, capacidadeTanque, ano, quilometragem, numeroPortas, capacidadePessoas, tamanhoPortaMala, temArCondicionado, temDirecaoHidraulica, temFreioAbs, estaAlugado, null)
            {
                Id = id
            };

            return veiculo;
        }
    }
}
