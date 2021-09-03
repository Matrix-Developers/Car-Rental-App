using LocadoraDeVeiculos.Dominio.LocacaoModule;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Controladores.Shared
{
    public static class ConversorParaPdf
    {
        const string fontFamily = "Verdana";
        const double textFontSize = 10;
        const double titleFontSize = 18;
        
        public static void ConverterLocacaoEmPdf(Locacao locacao)
        {
            string arquivo = $"recibo{locacao.Id}.pdf";
            string titulo = $"Recibo Locadora de Veículos - Locação {locacao.Id}";

            List<string> linhas = new List<string>
            {
                $"Cliente contratante: {locacao.ClienteContratante.Nome}, {locacao.ClienteContratante.RegistroUnico}",
                $"Veículo locado: {locacao.Veiculo.modelo},  {locacao.Veiculo.placa}",
                $"Seguro selecionado: {locacao.TipoDeSeguro}",
                $"Plano selecionado: {locacao.TipoDoPlano}",
                $"Data de locação: {locacao.DataDeSaida.Date}",
                $"Data prevista de devolução: {locacao.DataPrevistaDeChegada.Date}",
                $"Preco inicial da locação: R${locacao.PrecoLocacao}"
            };

            GerarPdf(arquivo, titulo, linhas);
        }

        private static void GerarPdf(string nomeArquivo, string textoTitulo, List<string> textoLinhas) 
        {
            double lineXPosition = 50;
            double lineYPosition = 30;
            XFont titleFont = new XFont(fontFamily, titleFontSize, XFontStyle.Bold);
            XFont textFont = new XFont(fontFamily, textFontSize, XFontStyle.Regular);

            PdfDocument pdf = new PdfDocument();
            pdf.Info.Title = textoTitulo;
            PdfPage pdfPage = pdf.AddPage();
            XGraphics graph = XGraphics.FromPdfPage(pdfPage);

            //titulo
            graph.DrawString(textoTitulo, titleFont, XBrushes.Black, new XRect(lineXPosition, lineYPosition, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            lineYPosition += titleFontSize + textFontSize;

            //linhas
            foreach(string linha in textoLinhas)
            {
                graph.DrawString(linha, textFont, XBrushes.Black, new XRect(lineXPosition, lineYPosition, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                lineYPosition += textFontSize;
            }

            pdf.Save(nomeArquivo);
            Process.Start(nomeArquivo);
        }
    }
}
