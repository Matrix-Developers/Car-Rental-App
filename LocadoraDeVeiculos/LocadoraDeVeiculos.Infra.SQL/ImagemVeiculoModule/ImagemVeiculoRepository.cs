using LocadoraDeVeiculos.Controladores.Shared;
using LocadoraDeVeiculos.Dominio.ImagemVeiculoModule;
using LocadoraDeVeiculos.Infra.SQL.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace LocadoraDeVeiculos.Controladores.ImagemVeiculoModule
{
    public class ImagemVeiculoRepository : RepositoryBase<ImagemVeiculo>, IImagemVeiculoRepository
    {
        private Bitmap bmp;

        #region queries
        protected override string SqlInserirEntidade
        {
            get
            {
                return
                    @"INSERT INTO [DBO].[TBIMAGEMVEICULO] 
                    (
                        [ID_VEICULO],
                        [IMAGEM]
                    )
                    VALUES
                    (
                        @ID_VEICULO,
                        @IMAGEM
                    );";
            }
        }
        protected override string SqlEditarEntidade
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        protected override string SqlExcluirEntidade
        {
            get
            {
                return "DELETE FROM [DBO].[TBIMAGEMVEICULO] WHERE [ID] = @ID";
            }
        }
        protected override string SqlSelecionarEntidadePorId
        {
            get
            {
                return "SELECT * FROM [DBO].[TBIMAGEMVEICULO] WHERE [ID] = @ID";
            }
        }

        protected override string SqlSelecionarTodasEntidades
        {
            get
            {
                return "SELECT* FROM DBO].[TBIMAGEMVEICULO]";
            }
        }

        protected override string SqlExisteEntidade
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        //chamadas unicas do ImagemVeiculo
        private const string comandoSelecionarPorIdDoVeiculo = "SELECT * FROM [DBO].[TBIMAGEMVEICULO] WHERE [ID_VEICULO] = @ID_VEICULO";
        private const string comandoExcluirTodosPorIdDoVeiculo = "DELETE FROM [DBO].[TBIMAGEMVEICULO] WHERE [ID_VEICULO] = @ID_VEICULO";
        private const string comandoSelecionarTodosDoVeiculo = "SELECT * FROM [DBO].[TBIMAGEMVEICULO] WHERE [ID_VEICULO] = @ID_VEICULO;";
        //
        #endregion

        public string Editar(int id, ImagemVeiculo registro)
        {
            registro.Id = Db.Insert(SqlInserirEntidade, ObtemParametros(registro));
            return "VALIDO";
        }
        public bool Excluir(int id)
        {
            try
            {
                Db.Delete(SqlExcluirEntidade, AdicionarParametro("ID", id));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
        public bool Existe(int id)
        {
            throw new NotImplementedException();
        }
        public string InserirNovo(ImagemVeiculo registro)
        {
            registro.Id = Db.Insert(SqlInserirEntidade, ObtemParametros(registro));
            return "VALIDO";
        }
        public ImagemVeiculo SelecionarPorId(int id)
        {
            return Db.Get(SqlSelecionarEntidadePorId, ConverterEmEntidade, AdicionarParametro("ID", id));
        }
        public List<ImagemVeiculo> SelecionarTodos()
        {
            return Db.GetAll(SqlSelecionarTodasEntidades, ConverterEmEntidade);
        }

        //metodos unicos do ImagemVeiculo
        public void EditarLista(List<ImagemVeiculo> registros)
        {
            if (registros != null)
            {
                if (registros.Count != 0)
                    ExcluirPorIdDoVeiculo(registros[0].IdVeiculo);
                foreach (ImagemVeiculo imagem in registros)
                {
                    InserirNovo(imagem);
                }
            }
        }
        public bool ExcluirPorIdDoVeiculo(int idVeiculo)
        {
            try
            {
                Db.Delete(comandoExcluirTodosPorIdDoVeiculo, AdicionarParametro("ID_Veiculo", idVeiculo));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
        public List<ImagemVeiculo> SelecionarPorIdDoVeiculo(int id)
        {
            return Db.GetAll(comandoSelecionarPorIdDoVeiculo, ConverterEmEntidade, AdicionarParametro("ID_VEICULO", id));
        }
        public List<ImagemVeiculo> SelecioanrTodasImagensDeUmVeiculo(int id)
        {
            return Db.GetAll(comandoSelecionarTodosDoVeiculo, ConverterEmEntidade, AdicionarParametro("ID_VEICULO", id));
        }
        //

        //Metodo sem referencia ou uso. está obsoleto?
        //R: caso precise trocar o formato da imagem já está meio pronto :)
        //private Bitmap ConverteEmImagem(IDataReader reader)
        //{

        //    byte[] a = (byte[])(reader["IMAGEM"]);

        //    TypeConverter tc = TypeDescriptor.GetConverter(typeof(Bitmap));
        //    bmp = (Bitmap)tc.ConvertFrom(a);

        //    return bmp;
        //}

        protected override Dictionary<string, object> ObtemParametros(ImagemVeiculo entidade)
        {
            bmp = entidade.Imagem;
            MemoryStream memoria = new();
            bmp.Save(memoria, ImageFormat.Bmp);
            byte[] imagemByte = memoria.ToArray();

            var parametros = new Dictionary<string, object>
            {
                { "ID", entidade.Id },
                { "ID_VEICULO", entidade.IdVeiculo },
                { "IMAGEM", imagemByte }
            };

            return parametros;
        }
        protected override ImagemVeiculo ConverterEmEntidade(IDataReader reader)
        {
            byte[] byteArray = (byte[])(reader["IMAGEM"]);
            var id = Convert.ToInt32(reader["ID"]);
            var idVeiculo = Convert.ToInt32(reader["ID_VEICULO"]);

            TypeConverter tc = TypeDescriptor.GetConverter(typeof(Bitmap));
            bmp = (Bitmap)tc.ConvertFrom(byteArray);
            Bitmap imagem = new(bmp);

            return new ImagemVeiculo(id, idVeiculo, imagem);

        }
    }
}
