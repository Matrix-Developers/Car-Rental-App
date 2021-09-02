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

        public static void GerarPdf(Locacao locacao) 
        {
            double lineXPosition = 50;
            double lineYPosition = 30;
           
            PdfDocument pdf = new PdfDocument();
            pdf.Info.Title = "My First PDF";
            PdfPage pdfPage = pdf.AddPage();
            XGraphics graph = XGraphics.FromPdfPage(pdfPage);
            XFont titleFont = new XFont(fontFamily, titleFontSize, XFontStyle.Bold);
            XFont textFont = new XFont(fontFamily, textFontSize, XFontStyle.Regular);

            graph.DrawString($"Recibo Locadora de Veículos - Locação {locacao.Id}", titleFont, XBrushes.Black, new XRect(lineXPosition, lineYPosition, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            lineYPosition += titleFontSize + textFontSize;
            graph.DrawString($"Cliente contratante: {locacao.ClienteContratante.Nome}, {locacao.ClienteContratante.RegistroUnico}", textFont, XBrushes.Black, new XRect(lineXPosition, lineYPosition, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            lineYPosition += textFontSize;
            graph.DrawString($"Veículo locado: {locacao.Veiculo.modelo},  {locacao.Veiculo.placa}", textFont, XBrushes.Black, new XRect(lineXPosition, lineYPosition, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            lineYPosition += textFontSize;
            graph.DrawString($"Seguro selecionado: {locacao.TipoDeSeguro}", textFont, XBrushes.Black, new XRect(lineXPosition, lineYPosition, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            lineYPosition += textFontSize;
            graph.DrawString($"Plano selecionado: {locacao.TipoDoPlano}", textFont, XBrushes.Black, new XRect(lineXPosition, lineYPosition, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            lineYPosition += textFontSize;
            graph.DrawString($"Data de locação: {locacao.DataDeSaida.Date}", textFont, XBrushes.Black, new XRect(lineXPosition, lineYPosition, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            lineYPosition += textFontSize;
            graph.DrawString($"Data prevista de devolução: {locacao.DataPrevistaDeChegada.Date}", textFont, XBrushes.Black, new XRect(lineXPosition, lineYPosition, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            lineYPosition += textFontSize;
            graph.DrawString($"Preco inicial da locação: R${locacao.PrecoLocacao}", textFont, XBrushes.Black, new XRect(lineXPosition, lineYPosition, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

            string pdfFilename = $"recibo{locacao.Id}.pdf";
            pdf.Save(pdfFilename);
            Process.Start(pdfFilename);
        }
    }
}
