using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocadoraDeVeiculos.Controladores.Shared;
using LocadoraDeVeiculos.Controladores.VeiculoModule;
using LocadoraDeVeiculos.Dominio.ImagemVeiculoModule;
using LocadoraDeVeiculos.Dominio.VeiculoModule;

namespace LocadoraDeVeiculos.Controladores.ImagemVeiculoModule
{
    public class ControladorImagemVeiculo : Controlador<ImagemVeiculo>
    {

        private Bitmap bmp;
        #region Queries
        private const string comandoInserir = @"insert into [dbo].[TBIMAGEMVEICULO] 
                                                (
                                                 [id_veiculo],
                                                 [imagem]
                                                )values
                                                (
                                                @id_veiculo,
                                                @imagem
                                                );";
        private const string comandoEditar = @"UPDATE [DBO].[TBIMAGEMVEICULO] SET [IMAGEM] = @IMAGEM WHERE [ID] = @ID";
        private const string comandoExcluir = "DELETE FROM [DBO].[TBIMAGEMVEICULO] WHERE [ID] = @ID";
        private const string comandoSelecionarTodosDoVeiculo = "SELECT * FROM [DBO].[TBIMAGEMVEICULO] WHERE [ID_VEICULO] = @ID_VEICULO;";
        private const string comandoSelecionarPorId = "SELECT * FROM [DBO].[TBIMAGEMVEICULO] WHERE [ID] = @ID";
        private const string comandoSelecioarTodos = "SELECT * FROM DBO].[TBIMAGEMVEICULO]";
        #endregion
        public override string Editar(int id, ImagemVeiculo registro)
        {
            registro.Id = Db.Insert(comandoInserir,ObtemParametrosImagem(registro));
            return "a";
        }

        public override bool Excluir(int id)
        {
            try
            {
                Db.Delete(comandoExcluir, AdicionarParametro("ID", id));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public override bool Existe(int id)
        {
            throw new NotImplementedException();
        }

        public override string InserirNovo(ImagemVeiculo registro)
        {
            string resultadoValidacao = "VALIDO";

            registro.Id = Db.Insert(comandoInserir, ObtemParametrosImagem(registro));

            return resultadoValidacao;
        }

        public override ImagemVeiculo SelecionarPorId(int id)
        {
            return Db.Get(comandoSelecionarPorId,ConverteEmImagemVeiculo,AdicionarParametro("ID",id));
        }

        public override List<ImagemVeiculo> SelecionarTodos()
        {
            return Db.GetAll(comandoSelecioarTodos,ConverteEmImagemVeiculo);
        }

        public List<ImagemVeiculo> SelecioanrTodasImagensDeUmVeiculo(int id)
        {
            return Db.GetAll(comandoSelecionarTodosDoVeiculo, ConverteEmImagemVeiculo,AdicionarParametro("ID_VEICULO",id));
        }

        private Dictionary<string, object> ObtemParametrosImagem(ImagemVeiculo imagemVeiculo)
        {
            bmp = imagemVeiculo.imagem;
            MemoryStream memoria = new MemoryStream();
            bmp.Save(memoria,ImageFormat.Bmp);
            byte[] imagemByte = memoria.ToArray();

            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", imagemVeiculo.Id);
            parametros.Add("ID_VEICULO", imagemVeiculo.idVeiculo);
            parametros.Add("IMAGEM", imagemByte);

            return parametros;
        }

        private Bitmap ConverteEmImagem(IDataReader reader)
        {

            byte[] a = (byte[])(reader["IMAGEM"]);

            TypeConverter tc = TypeDescriptor.GetConverter(typeof(Bitmap));
            bmp = (Bitmap)tc.ConvertFrom(a);

            return bmp;
        }

        private ImagemVeiculo ConverteEmImagemVeiculo(IDataReader reader)
        {
            byte[] byteArray= (byte[])(reader["IMAGEM"]);
            var id = Convert.ToInt32(reader["ID"]);
            var idVeiculo = Convert.ToInt32(reader["ID_VEICULO"]);

            TypeConverter tc = TypeDescriptor.GetConverter(typeof(Bitmap));
            bmp = (Bitmap)tc.ConvertFrom(byteArray);
            Bitmap imagem = new Bitmap(bmp);

            return new ImagemVeiculo(id,idVeiculo, imagem);

        }
    }
}
