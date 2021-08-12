using LocadoraDeVeiculos.Controladores.Shared;
using LocadoraDeVeiculos.Dominio.VeiculoModule;
using System.Collections.Generic;

namespace LocadoraDeVeiculos.Controladores.VeiculoModule
{
    public class ControladorVeiculo : Controlador<Veiculo>
    {
        #region queries
        private const string sqlInserirVeiculo =
            @"INSERT INTO TBVEICULO
            (
                [MODELO],
                [ID_GRUPOVEICULO],
                [PLACA],
                [CHASSI],      
                [MARCA], 
                [IMAGEM],
                [COR],
                [TIPOCOMBUSTIVEL],
                [ANO],
                [KILOMETRAGEM],
                [NUMEROPORTAS],
                [CAPACIDADEPESSOAS],
                [TAMANHOPORTAMALAS],
                [TEMARCONDICIONADO],
                [TEMDIRECAOHIDRAULICA],
                [TEMFREIOABS]
            )
            VALUES
            (
                @MODELO,
                @ID_GRUPOVEICULO,
                @PLACA,
                @CHASSI,      
                @MARCA,
                @IMAGEM,
                @COR,
                @TIPOCOMBUSTIVEL,
                @ANO,
                @KILOMETRAGEM,
                @NUMEROPORTAS,
                @CAPACIDADEPESSOAS,
                @TAMANHOPORTAMALAS,
                @TEMARCONDICIONADO,
                @TEMDIRECAOHIDRAULICA,
                @TEMFREIOABS
            )";
        private const string sqlSelecionarTodosVeiculos =
            @"SELECT 
                [MODELO],
                [ID_GRUPOVEICULO],
                [PLACA],
                [CHASSI],      
                [MARCA], 
                [IMAGEM],
                [COR],
                [TIPOCOMBUSTIVEL],
                [ANO],
                [KILOMETRAGEM],
                [NUMEROPORTAS],
                [CAPACIDADEPESSOAS],
                [TAMANHOPORTAMALAS],
                [TEMARCONDICIONADO],
                [TEMDIRECAOHIDRAULICA],
                [TEMFREIOABS] 
            FROM 
                TBVEICULO ORDER BY ID;";

        private const string sqlSelecionarVeiculoPorId =
            @"SELECT  
                [MODELO],
                [ID_GRUPOVEICULO],
                [PLACA],
                [CHASSI],      
                [MARCA], 
                [IMAGEM],
                [COR],
                [TIPOCOMBUSTIVEL],
                [ANO],
                [KILOMETRAGEM],
                [NUMEROPORTAS],
                [CAPACIDADEPESSOAS],
                [TAMANHOPORTAMALAS],
                [TEMARCONDICIONADO],
                [TEMDIRECAOHIDRAULICA],
                [TEMFREIOABS] 
            FROM
                TBVEICULO 
            WHERE 
                [ID] = @ID";

        private const string sqlEditarVeiculo =
            @"UPDATE TBVEICULO SET
                [MODELO] = @MODELO,
                [ID_GRUPOVEICULO] = @ID_GRUPOVEICULO,
                [PLACA] = @PLACA,
                [CHASSI] = @CHASSI,
                [MARCA] = @MARCA,
                [IMAGEM] = @IMAGEM,
                [COR] = @COR,
                [TIPOCOMBUSTIVEL] = @TIPOCOMBUSTIVEL,
                [ANO] = @ANO,
                [KILOMETRAGEM] = @KILOMETRAGEM,
                [NUMEROPORTAS] = @NUMEROPORTAS,
                [CAPACIDADEPESSOAS] = @CAPACIDADEPESSOAS,
                [TAMANHOPORTAMALA] = @TAMANHOPORTAMALA,
                [TEMARCONDICIONADO] = @TEMARCONDICIONADO
                [TEMDIRECAOHIDRAULICA] = @TEMDIRECAOHIDRAULICA,
                [TEMFREIOSABS] = @TEMFREIOSABS
            WHERE
                [ID] = @ID
            ";
        private const string sqlDeletarVeiculo =
            @"DELETE 
                FROM 
                TBVEICULO 
            WHERE 
                [ID] = @ID";

        private const string sqlExisteVeiculo =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBVEICULO]
            WHERE 
                [ID] = @ID";
        #endregion
        public override string InserirNovo(Veiculo registro)
        {
            throw new System.NotImplementedException();
        }
        public override List<Veiculo> SelecionarTodos()
        {
            throw new System.NotImplementedException();
        }
        public override Veiculo SelecionarPorId(int id)
        {
            throw new System.NotImplementedException();
        }
        public override string Editar(int id, Veiculo registro)
        {
            throw new System.NotImplementedException();
        }

        public override bool Excluir(int id)
        {
            throw new System.NotImplementedException();
        }

        public override bool Existe(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
