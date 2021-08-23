using LocadoraDeVeiculos.Controladores.Shared;
using LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule;
using System;
using System.Collections.Generic;
using System.Data;

namespace LocadoraDeVeiculos.Controladores.GrupoDeVeiculosModule
{
    public class ControladorGrupoDeVeiculos : Controlador<GrupoDeVeiculo>
    {
        private const string sqlInserirGrupoDeVeiculos =
                @"INSERT INTO TBGRUPOVEICULO
                (
	                [NOME],
	                [TAXAPLANODIARIO],
	                [TAXAPORKMDIARIO],
	                [TAXAPLANOCONTROLADO],
	                [LIMITEKMCONTROLADO],
	                [TAXAKMEXCEDIDOCONTROLADO]
	                [TAXAPLANOLIVRE]
                )
                VALUES
                (
	                @NOME,
	                @TAXAPLANODIARIO,
	                @TAXAPORKMDIARIO,
	                @TAXAPLANOCONTROLADO,
	                @LIMITEKMCONTROLADO,
	                @TAXAKMEXCEDIDOCONTROLADO,
	                @TAXAPLANOLIVRE
                );";

        private const string sqlEditarGrupoDeVeiculos =
                @"UPDATE TBGRUPOVEICULO 
                SET
	                [NOME] = @NOME,
	                [TAXAPLANODIARIO] = @TAXAPLANODIARIO,
	                [TAXAPORKMDIARIO] = @TAXAPORKMDIARIO,
	                [TAXAPLANOCONTROLADO] = @TAXAPLANOCONTROLADO,
	                [LIMITEKMCONTROLADO] = @LIMITEKMCONTROLADO,
	                [TAXAKMEXCEDIDOCONTROLADO] = @TAXAKMEXCEDIDOCONTROLADO,
	                [TAXAPLANOLIVRE] = @TAXAPLANOLIVRE
                WHERE [ID] = @ID;";

        private const string sqlExcluirGrupoDeVeiculos =
                @"DELETE FROM TBGRUPOVEICULO  WHERE [ID] = @ID;";

        private const string sqlSelecionarGrupoDeVeiculosPorId =
                @"SELECT * FROM TBGRUPOVEICULO WHERE [ID] = @ID;";

        private const string sqlSelecionarTodosGrupoDeVeiculoss =
                @"SELECT * FROM TBGRUPOVEICULO;";

        private const string sqlExisteGrupoDeVeiculos =
                @"SELECT 
                    COUNT(*) 
                FROM 
                    [TBGRUPOVEICULO]
                WHERE 
                    [ID] = @ID";

        public override string InserirNovo(GrupoDeVeiculo registro)
        {
            string resultadoValidacao = registro.Validar();

            List<GrupoDeVeiculo> grupoDeVeiculosRegistrados = SelecionarTodos();
            foreach (GrupoDeVeiculo grupo in grupoDeVeiculosRegistrados)
            {
                if (registro.Nome == grupo.Nome)
                    resultadoValidacao = "O nome do grupo de veículos deve ser único\n";
            }

            if (resultadoValidacao == "VALIDO")
            {
                registro.Id = Db.Insert(sqlInserirGrupoDeVeiculos, ObtemParametrosGrupoDeVeiculos(registro));
            }

            return resultadoValidacao;
        }

        public override string Editar(int id, GrupoDeVeiculo registro)
        {
            string resultadoValidacao = registro.Validar();

            List<GrupoDeVeiculo> grupoDeVeiculosRegistrados = SelecionarTodos();
            foreach (GrupoDeVeiculo grupo in grupoDeVeiculosRegistrados)
            {
                if (id != grupo.Id && registro.Nome == grupo.Nome)
                    resultadoValidacao = "O nome do grupo de veículos deve ser único\n";
            }

            if (resultadoValidacao == "VALIDO")
            {
                registro.Id = id;
                Db.Update(sqlEditarGrupoDeVeiculos, ObtemParametrosGrupoDeVeiculos(registro));
            }

            return resultadoValidacao;
        }

        public override bool Excluir(int id)
        {
            try
            {
                Db.Delete(sqlExcluirGrupoDeVeiculos, AdicionarParametro("ID", id));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public override bool Existe(int id)
        {
            return Db.Exists(sqlExisteGrupoDeVeiculos, AdicionarParametro("ID", id));
        }

        public override GrupoDeVeiculo SelecionarPorId(int id)
        {
            return Db.Get(sqlSelecionarGrupoDeVeiculosPorId, ConverterEmGrupoDeVeiculos, AdicionarParametro("ID", id));
        }

        public override List<GrupoDeVeiculo> SelecionarTodos()
        {
            return Db.GetAll(sqlSelecionarTodosGrupoDeVeiculoss, ConverterEmGrupoDeVeiculos);
        }

        private Dictionary<string, object> ObtemParametrosGrupoDeVeiculos(GrupoDeVeiculo grupoDeVeiculos)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", grupoDeVeiculos.Id);
            parametros.Add("NOME", grupoDeVeiculos.Nome);
            parametros.Add("TAXAPLANODIARIO", grupoDeVeiculos.TaxaPlanoDiario);
            parametros.Add("TAXAPORKMDIARIO", grupoDeVeiculos.TaxaPorKmDiario);
            parametros.Add("TAXAPLANOCONTROLADO", grupoDeVeiculos.TaxaPlanoControlado);
            parametros.Add("LIMITEKMCONTROLADO", grupoDeVeiculos.LimiteKmControlado);
            parametros.Add("TAXAKMEXCEDIDOCONTROLADO", grupoDeVeiculos.TaxaKmExcedidoControlado);
            parametros.Add("TAXAPLANOLIVRE", grupoDeVeiculos.TaxaPlanoLivre);

            return parametros;
        }

        private GrupoDeVeiculo ConverterEmGrupoDeVeiculos(IDataReader reader)
        {
            int id = Convert.ToInt32(reader["ID"]); ;
            string nome = Convert.ToString(reader["NOME"]); ;
            double taxaPlanoDiario = Convert.ToDouble(reader["TAXAPLANODIARIO"]);
            double taxaPorKmDiario = Convert.ToDouble(reader["TAXAPORKMDIARIO"]);
            double taxaPlanoControlado = Convert.ToDouble(reader["TAXAPLANOCONTROLADO"]);
            int limiteKmControlado = Convert.ToInt32(reader["LIMITEKMCONTROLADO"]);
            double taxaKmExcedidoControlado = Convert.ToDouble(reader["TAXAKMEXCEDIDOCONTROLADO"]);
            double taxaPlanoLivre = Convert.ToDouble(reader["TAXAPLANOLIVRE"]);

            GrupoDeVeiculo grupoDeVeiculos = new GrupoDeVeiculo(id, nome, taxaPlanoDiario, taxaPorKmDiario, taxaPlanoControlado,
                limiteKmControlado, taxaKmExcedidoControlado,taxaPlanoLivre);

            return grupoDeVeiculos;
        }
    }
}
