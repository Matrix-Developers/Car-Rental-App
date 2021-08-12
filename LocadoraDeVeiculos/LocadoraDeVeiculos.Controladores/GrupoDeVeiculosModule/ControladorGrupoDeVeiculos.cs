using LocadoraDeVeiculos.Controladores.Shared;
using LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule;
using System;
using System.Collections.Generic;
using System.Data;

namespace LocadoraDeVeiculos.Controladores.GrupoDeVeiculosModule
{
    public class ControladorGrupoDeVeiculos : Controlador<GrupoDeVeiculos>
    {
        private const string sqlInserirGrupoDeVeiculos =
            @"";

        private const string sqlEditarGrupoDeVeiculos =
            @" ";

        private const string sqlExcluirGrupoDeVeiculos =
            @" ";

        private const string sqlSelecionarGrupoDeVeiculosPorId =
            @" ";

        private const string sqlSelecionarTodosGrupoDeVeiculoss =
            @" ";

        private const string sqlExisteGrupoDeVeiculos =
            @" ";

        public override string InserirNovo(GrupoDeVeiculos registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = Db.Insert(sqlInserirGrupoDeVeiculos, ObtemParametrosGrupoDeVeiculos(registro));
            }

            return resultadoValidacao;
        }

        public override string Editar(int id, GrupoDeVeiculos registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
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

        public override GrupoDeVeiculos SelecionarPorId(int id)
        {
            return Db.Get(sqlSelecionarGrupoDeVeiculosPorId, ConverterEmGrupoDeVeiculos, AdicionarParametro("ID", id));
        }

        public override List<GrupoDeVeiculos> SelecionarTodos()
        {
            return Db.GetAll(sqlSelecionarTodosGrupoDeVeiculoss, ConverterEmGrupoDeVeiculos);
        }

        private Dictionary<string, object> ObtemParametrosGrupoDeVeiculos(GrupoDeVeiculos grupoDeVeiculos)
        {
            throw new NotImplementedException();
        }

        private GrupoDeVeiculos ConverterEmGrupoDeVeiculos(IDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
