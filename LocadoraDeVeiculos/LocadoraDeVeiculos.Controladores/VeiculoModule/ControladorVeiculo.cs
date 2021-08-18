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
                [CAPACIDADETANQUE],
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
                @CAPACIDADETANQUE,
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
                CG.[NOME],
                CG.[TAXAPLANODIARIO],
                CG.[TAXAKMCONTROLADO],
                CG.[TAXAKMLIVRE],
                CG.[QUANTIDADEQUILOMETROSKMCONTROLADO]
            FROM 
                [TBVEICULO] AS CV LEFT JOIN 
                [TBGRUPOVEICULO] AS CG
            ON
                CG.ID = CV.ID_GRUPOVEICULO";

        private const string sqlSelecionarVeiculoPorId =
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
                CG.[NOME],
                CG.[TAXAPLANODIARIO],
                CG.[TAXAKMCONTROLADO],
                CG.[TAXAKMLIVRE],
                CG.[QUANTIDADEQUILOMETROSKMCONTROLADO]
            FROM 
                [TBVEICULO] AS CV LEFT JOIN 
                [TBGRUPOVEICULO] AS CG
            ON
                CG.ID = CV.ID_GRUPOVEICULO
            WHERE 
                CV.[ID] = @ID";

        private const string sqlEditarVeiculo =
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
            parametros.Add("ID_GRUPOVEICULO", veiculo.grupoVeiculos.Id);
            parametros.Add("PLACA", veiculo.placa);
            parametros.Add("CHASSI", veiculo.chassi);
            parametros.Add("MARCA", veiculo.marca);
            //parametros.Add("IMAGEM", veiculo.imagem);
            parametros.Add("COR", veiculo.cor);
            parametros.Add("TIPOCOMBUSTIVEL", veiculo.tipoCombustivel);
            parametros.Add("CAPACIDADETANQUE", veiculo.capacidadeTanque);
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
            var id = Convert.ToInt32(reader["ID"]);
            var modelo = Convert.ToString(reader["MODELO"]);
            var grupoVeiculos = Convert.ToInt32(reader["ID_GRUPOVEICULO"]);
            var placa = Convert.ToString(reader["PLACA"]);
            var chassi = Convert.ToString(reader["CHASSI"]);
            var marca = Convert.ToString(reader["MARCA"]);
            //string imagem = Convert.(reader["IMAGEM"]);
            var cor = Convert.ToString(reader["COR"]);
            var tipoCombustivel = Convert.ToString(reader["TIPOCOMBUSTIVEL"]);
            var capacidadeTanque = Convert.ToDouble(reader["capacidadeTanque"]);
            var ano = Convert.ToInt32(reader["ANO"]);
            var kilometragem = Convert.ToDouble(reader["KILOMETRAGEM"]);
            var numeroPortas = Convert.ToInt32(reader["NUMEROPORTAS"]);
            var capacidadePessoas = Convert.ToInt32(reader["CAPACIDADEPESSOAS"]);
            var tamanhoPortaMala = Convert.ToChar(reader["TAMANHOPORTAMALA"]);
            var temArCondicionado = Convert.ToBoolean(reader["TEMARCONDICIONADO"]);
            var temDirecaoHidraulica = Convert.ToBoolean(reader["TEMDIRECAOHIDRAULICA"]);
            var temFreioAbs = Convert.ToBoolean(reader["TEMFREIOSABS"]);

            var nome = Convert.ToString(reader["NOME"]);
            var taxaPlanoDiario = Convert.ToDouble(reader["TAXAPLANODIARIO"]);
            var taxaKmControlado = Convert.ToDouble(reader["TAXAKMCONTROLADO"]);
            var taxaKmLivre = Convert.ToDouble(reader["TAXAKMLIVRE"]);
            var quantidadeQuilometrosKmControlado = Convert.ToInt32(reader["QUANTIDADEQUILOMETROSKMCONTROLADO"]);

            GrupoDeVeiculos grupo = new GrupoDeVeiculos(grupoVeiculos, nome, taxaPlanoDiario, taxaKmControlado, taxaKmLivre, quantidadeQuilometrosKmControlado);

            Veiculo veiculo = new Veiculo(id, modelo, grupo, placa, chassi, marca, cor, tipoCombustivel, capacidadeTanque, ano, kilometragem, numeroPortas, capacidadePessoas, tamanhoPortaMala, temArCondicionado, temDirecaoHidraulica, temFreioAbs);

            veiculo.Id = id;

            return veiculo;
        }
    }
}
