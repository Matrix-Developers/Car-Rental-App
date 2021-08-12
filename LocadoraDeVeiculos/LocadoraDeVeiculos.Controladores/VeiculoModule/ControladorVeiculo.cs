using LocadoraDeVeiculos.Controladores.Shared;
using LocadoraDeVeiculos.Dominio.VeiculoModule;
using System;
using System.Collections.Generic;
using System.Data;

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
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
                registro.Id = Db.Insert(sqlInserirVeiculo, ObtemParametrosVeiculo(registro));

            return resultadoValidacao;
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

        private Dictionary<string, object> ObtemParametrosVeiculo(Veiculo veiculo)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", veiculo.Id);
            parametros.Add("MODELO", veiculo.modelo);
            parametros.Add("ID_GRUPOVEICULO", veiculo.grupoVeiculos);
            parametros.Add("PLACA", veiculo.placa);
            parametros.Add("CHASSI", veiculo.chassi);
            parametros.Add("COR", veiculo.cor);
            parametros.Add("TIPOCOMBUSTIVEL", veiculo.tipoCombustivel);
            parametros.Add("ANO", veiculo.ano);
            parametros.Add("KILOMETRAGEM", veiculo.kilometragem);
            parametros.Add("NUMEROPORTAS", veiculo.numeroPortas);
            parametros.Add("CAPACIDADEPESSOAS", veiculo.capacidadePessoas);
            parametros.Add("TAMANHOPORTAMALA", veiculo.tamanhoPortaMala);
            parametros.Add("TEMARCONDICIONADO", veiculo.temArCondicionado);
            parametros.Add("TEMDIRECAOHIDRAULICA", veiculo.temDirecaoHidraulica);
            parametros.Add("TEMFREIOABS", veiculo.temFreiosAbs);

            return parametros;
        }

        private Veiculo ConverterEmVeiculo(IDataReader reader)
        {
            int id = Convert.ToInt32(reader["ID"]);
            string modelo = Convert.ToString(reader["MODELO"]);
            string grupoVeiculos = Convert.ToString(reader["ID_GRUPOVEICULO"]);
            string placa = Convert.ToString(reader["PLACA"]);
            string chassi = Convert.ToString(reader["CHASSI"]);
            string marca = Convert.ToString(reader["MARCA"]);
            //string imagem = Convert.(reader["IMAGEM"]);
            string cor = Convert.ToString(reader["COR"]);
            string tipoCombustivel = Convert.ToString(reader["TIPOCOMBUSTIVEL"]);
            double capacidadeTanque = Convert.ToDouble(reader["capacidadeTanque"]);
            int ano = Convert.ToInt32(reader["ANO"]);
            double kilometragem = Convert.ToDouble(reader["KILOMETRAGEM"]);
            int numeroPortas = Convert.ToInt32(reader["NUMEROPORTAS"]);
            int capacidadePessoas = Convert.ToInt32(reader["CAPACIDADEPESSOAS"]);
            char tamanhoPortaMala = Convert.ToChar(reader["TAMANHOPORTAMALA"]);
            string temArCondicionado = Convert.ToString(reader["TEMARCONDICIONADO"]);
            string temDirecaoHidraulica = Convert.ToString(reader["TEMDIRECAOHIDRAULICA"]);
            string temFreioAbs = Convert.ToString(reader["TEMFREIOABS"]);


            Veiculo veiculo = new Veiculo(id, modelo, grupoVeiculos, placa, chassi, marca, cor, tipoCombustivel, capacidadeTanque, ano, kilometragem, numeroPortas, capacidadePessoas, tamanhoPortaMala);

            veiculo.Id = id;

            return veiculo;
        }
    }
}
