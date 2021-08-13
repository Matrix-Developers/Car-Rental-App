using LocadoraDeVeiculos.Controladores.Shared;
using LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule;
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
                [COR],
                [TIPOCOMBUSTIVEL],
                [ANO],
                [KILOMETRAGEM],
                [NUMEROPORTAS],
                [CAPACIDADEPESSOAS],
                [TAMANHOPORTAMALA],
                [TEMARCONDICIONADO],
                [TEMDIRECAOHIDRAULICA],
                [TEMFREIOSABS]
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
                @ANO,
                @KILOMETRAGEM,
                @NUMEROPORTAS,
                @CAPACIDADEPESSOAS,
                @TAMANHOPORTAMALA,
                @TEMARCONDICIONADO,
                @TEMDIRECAOHIDRAULICA,
                @TEMFREIOSABS
            )";
        private const string sqlSelecionarTodosVeiculos =
            @"SELECT
                [ID],
                [MODELO],
                [ID_GRUPOVEICULO],
                [PLACA],
                [CHASSI],      
                [MARCA], 
                [COR],
                [TIPOCOMBUSTIVEL],
                [ANO],
                [KILOMETRAGEM],
                [NUMEROPORTAS],
                [CAPACIDADEPESSOAS],
                [TAMANHOPORTAMALA],
                [TEMARCONDICIONADO],
                [TEMDIRECAOHIDRAULICA],
                [TEMFREIOSABS] 
            FROM 
                TBVEICULO ORDER BY ID;";

        private const string sqlSelecionarVeiculoPorId =
            @"SELECT  
                [ID],
                [MODELO],
                [ID_GRUPOVEICULO],
                [PLACA],
                [CHASSI],      
                [MARCA], 
                [COR],
                [TIPOCOMBUSTIVEL],
                [ANO],
                [KILOMETRAGEM],
                [NUMEROPORTAS],
                [CAPACIDADEPESSOAS],
                [TAMANHOPORTAMALA],
                [TEMARCONDICIONADO],
                [TEMDIRECAOHIDRAULICA],
                [TEMFREIOSABS] 
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
                [COR] = @COR,
                [TIPOCOMBUSTIVEL] = @TIPOCOMBUSTIVEL,
                [ANO] = @ANO,
                [KILOMETRAGEM] = @KILOMETRAGEM,
                [NUMEROPORTAS] = @NUMEROPORTAS,
                [CAPACIDADEPESSOAS] = @CAPACIDADEPESSOAS,
                [TAMANHOPORTAMALA] = @TAMANHOPORTAMALA,
                [TEMARCONDICIONADO] = @TEMARCONDICIONADO,
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

            if (resultadoValidacao == "VALIDO")
                registro.Id = Db.Insert(sqlInserirVeiculo, ObtemParametrosVeiculo(registro));

            return resultadoValidacao;
        }
        public override List<Veiculo> SelecionarTodos()
        {
            return Db.GetAll(sqlSelecionarTodosVeiculos, ConverterEmVeiculo);
        }
        public override Veiculo SelecionarPorId(int id)
        {
            return Db.Get(sqlSelecionarVeiculoPorId, ConverterEmVeiculo, AdicionarParametro("ID", id));
        }
        public override string Editar(int id, Veiculo registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "VALIDO")
            {
                registro.Id = id;
                Db.Update(sqlEditarVeiculo, ObtemParametrosVeiculo(registro));
            }

            return resultadoValidacao;
        }
        public override bool Excluir(int id)
        {
            try
            {
                Db.Delete(sqlDeletarVeiculo, AdicionarParametro("ID", id));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public override bool Existe(int id)
        {
            return Db.Exists(sqlExisteVeiculo, AdicionarParametro("ID", id));
        }

        private Dictionary<string, object> ObtemParametrosVeiculo(Veiculo veiculo)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", veiculo.Id);
            parametros.Add("MODELO", veiculo.modelo);
            parametros.Add("ID_GRUPOVEICULO", veiculo.grupoVeiculos);
            parametros.Add("PLACA", veiculo.placa);
            parametros.Add("CHASSI", veiculo.chassi);
            parametros.Add("MARCA", veiculo.marca);
            //parametros.Add("IMAGEM", veiculo.imagem);
            parametros.Add("COR", veiculo.cor);
            parametros.Add("TIPOCOMBUSTIVEL", veiculo.tipoCombustivel);
            parametros.Add("ANO", veiculo.ano);
            parametros.Add("KILOMETRAGEM", veiculo.kilometragem);
            parametros.Add("NUMEROPORTAS", veiculo.numeroPortas);
            parametros.Add("CAPACIDADEPESSOAS", veiculo.capacidadePessoas);
            parametros.Add("TAMANHOPORTAMALA", veiculo.tamanhoPortaMala);
            parametros.Add("TEMARCONDICIONADO", veiculo.temArCondicionado);
            parametros.Add("TEMDIRECAOHIDRAULICA", veiculo.temDirecaoHidraulica);
            parametros.Add("TEMFREIOSABS", veiculo.temFreiosAbs);

            return parametros;
        }

        private Veiculo ConverterEmVeiculo(IDataReader reader)
        {
            int id = Convert.ToInt32(reader["ID"]);
            string modelo = Convert.ToString(reader["MODELO"]);
            GrupoDeVeiculos grupoVeiculos = (reader["ID_GRUPOVEICULO"]) as GrupoDeVeiculos;
            string placa = Convert.ToString(reader["PLACA"]);
            string chassi = Convert.ToString(reader["CHASSI"]);
            string marca = Convert.ToString(reader["MARCA"]);
            //string imagem = Convert.(reader["IMAGEM"]);
            string cor = Convert.ToString(reader["COR"]);
            string tipoCombustivel = Convert.ToString(reader["TIPOCOMBUSTIVEL"]);
            //double capacidadeTanque = Convert.ToDouble(reader["capacidadeTanque"]);
            int ano = Convert.ToInt32(reader["ANO"]);
            double kilometragem = Convert.ToDouble(reader["KILOMETRAGEM"]);
            int numeroPortas = Convert.ToInt32(reader["NUMEROPORTAS"]);
            int capacidadePessoas = Convert.ToInt32(reader["CAPACIDADEPESSOAS"]);
            char tamanhoPortaMala = Convert.ToChar(reader["TAMANHOPORTAMALA"]);
            bool temArCondicionado = Convert.ToBoolean(reader["TEMARCONDICIONADO"]);
            bool temDirecaoHidraulica = Convert.ToBoolean(reader["TEMDIRECAOHIDRAULICA"]);
            bool temFreioAbs = Convert.ToBoolean(reader["TEMFREIOSABS"]);


            Veiculo veiculo = new Veiculo(id, modelo, grupoVeiculos, placa, chassi, marca, cor, tipoCombustivel, 60.5, ano, kilometragem, numeroPortas, capacidadePessoas, tamanhoPortaMala, temArCondicionado, temDirecaoHidraulica, temFreioAbs);

            veiculo.Id = id;

            return veiculo;
        }
    }
}
