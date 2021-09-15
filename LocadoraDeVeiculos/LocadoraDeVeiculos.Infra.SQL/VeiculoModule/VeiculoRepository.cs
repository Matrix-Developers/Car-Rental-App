using LocadoraDeVeiculos.Controladores.Shared;
using LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule;
using LocadoraDeVeiculos.Dominio.ImagemVeiculoModule;
using LocadoraDeVeiculos.Controladores.ImagemVeiculoModule;
using LocadoraDeVeiculos.Dominio.VeiculoModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Infra.SQL.Shared;

namespace LocadoraDeVeiculos.Controladores.VeiculoModule
{
    public class VeiculoRepository : RepositoryBase<Veiculo>, IRepository<Veiculo>
    {
        private ImagemVeiculoRepository controladorImagem = new ImagemVeiculoRepository();

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
                [TEMFREIOSABS] = @TEMFREIOSABS,
                [ESTAALUGADO] = @ESTAALUGADO
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

        private const string sqlVeiculoTotal =
            @"SELECT COUNT(*) AS QTD FROM[TBVEICULO]";
        #endregion

        public string InserirNovo(Veiculo registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "VALIDO")
            {
                registro.Id = Db.Insert(sqlInserirVeiculo, ObtemParametros(registro));
                if (registro.imagens != null)
                {
                    foreach (ImagemVeiculo imagemVeiculo in registro.imagens)
                    {
                        imagemVeiculo.idVeiculo = registro.Id;
                        controladorImagem.InserirNovo(imagemVeiculo);
                    }
                }
            }
            return resultadoValidacao;
        }
        public List<Veiculo> SelecionarTodos()
        {
            List<Veiculo>veiculos = Db.GetAll(sqlSelecionarTodosVeiculos, ConverterEmEntidade);

            foreach (Veiculo veiculo in veiculos)
            {
                veiculo.imagens = controladorImagem.SelecioanrTodasImagensDeUmVeiculo(veiculo.Id);
            }

            return veiculos;
        }
        public Veiculo SelecionarPorId(int id)
        {
            Veiculo veiculo = Db.Get(sqlSelecionarVeiculoPorId, ConverterEmEntidade, AdicionarParametro("ID", id));
            veiculo.imagens = controladorImagem.SelecioanrTodasImagensDeUmVeiculo(id);
            return veiculo;
        }
        public string Editar(int id, Veiculo registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "VALIDO")
            {
                registro.Id = id;
                Db.Update(sqlEditarVeiculo, ObtemParametros(registro));
                foreach (ImagemVeiculo imagem in registro.imagens)
                    imagem.idVeiculo = registro.Id;
                controladorImagem.EditarLista(registro.imagens);
            }

            return resultadoValidacao;
        }
        public bool Excluir(int id)
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
        public bool Existe(int id)
        {
            return Db.Exists(sqlExisteVeiculo, AdicionarParametro("ID", id));
        }

        //private int ConverterDados(IDataReader reader)
        //{
        //    return Convert.ToInt32(reader["qtd"]);
        //}

        protected override Dictionary<string, object> ObtemParametros(Veiculo entidade)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", entidade.Id);
            parametros.Add("MODELO", entidade.modelo);
            parametros.Add("ID_GRUPOVEICULO", entidade.grupoVeiculos.Id);
            parametros.Add("PLACA", entidade.placa);
            parametros.Add("CHASSI", entidade.chassi);
            parametros.Add("MARCA", entidade.marca);
            parametros.Add("COR", entidade.cor);
            parametros.Add("TIPOCOMBUSTIVEL", entidade.tipoCombustivel);
            parametros.Add("CAPACIDADETANQUE", entidade.capacidadeTanque);
            parametros.Add("ANO", entidade.ano);
            parametros.Add("KILOMETRAGEM", entidade.kilometragem);
            parametros.Add("NUMEROPORTAS", entidade.numeroPortas);
            parametros.Add("CAPACIDADEPESSOAS", entidade.capacidadePessoas);
            parametros.Add("TAMANHOPORTAMALA", entidade.tamanhoPortaMala);
            parametros.Add("TEMARCONDICIONADO", entidade.temArCondicionado);
            parametros.Add("TEMDIRECAOHIDRAULICA", entidade.temDirecaoHidraulica);
            parametros.Add("TEMFREIOSABS", entidade.temFreiosAbs);
            parametros.Add("ESTAALUGADO", entidade.estaAlugado);

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

            GrupoDeVeiculo grupo = new GrupoDeVeiculo(id_grupoveiculo, nome, taxaPlanoDiario, taxaPorKmDiario, taxaPlanoControlado, limiteKmControlado, taxaKmExcedidoControlado, taxaPlanoLivre);

            Veiculo veiculo = new Veiculo(id, modelo, grupo, placa, chassi, marca, cor, tipoCombustivel, capacidadeTanque, ano, quilometragem, numeroPortas, capacidadePessoas, tamanhoPortaMala, temArCondicionado, temDirecaoHidraulica, temFreioAbs, estaAlugado,null);

            veiculo.Id = id;

            return veiculo;
        }
    }
}
