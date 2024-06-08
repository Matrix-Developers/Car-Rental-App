using LocadoraDeVeiculos.Dominio.LocacaoModule;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using Serilog;
using System;
using System.Collections.Generic;

namespace LocadoraDeVeiculos.Controladores.Shared
{
    public class ConversorParaPdf
    {
        private string fontFamily;
        private double tamanhoFonteTexto;
        private double tamanhoFonteTitulo;

        public ConversorParaPdf(double tamanhoFonteTexto, double tamanhoFonteTitulo)
        {
            fontFamily = "Verdana";
            this.tamanhoFonteTexto = tamanhoFonteTexto;   //default: 10
            this.tamanhoFonteTitulo = tamanhoFonteTitulo;     //default: 18
        }

        public double TamanhoFonteTexto { get => tamanhoFonteTexto; set => tamanhoFonteTexto = value; }
        public string FontFamily { get => fontFamily; set => fontFamily = value; }
        public double TamanhoFonteTitulo { get => tamanhoFonteTitulo; set => tamanhoFonteTitulo = value; }

        public void ConverterLocacaoEmPdf(Locacao locacao)
        {
            string subpath = @"c:\Car Rental App\Recibos\";
            System.IO.Directory.CreateDirectory(subpath);

            string arquivo = $@"{subpath}Receipt{locacao.Id}.pdf";
            string titulo = $"Receipt Car Rental App - Rental ID: {locacao.Id}";

            List<string> linhas = new()
            {
                $"• Rental Details:",
                $"      - Insurance selected: {locacao.TipoDeSeguro}",
                $"      - Plan selected: {locacao.TipoDoPlano}",
                $"      - Rental date: {locacao.DataDeSaida.Date:dd/MM/yyyy}",
                $"      - Expected return date: {locacao.DataPrevistaDeChegada.Date:dd/MM/yyyy}",
                $"      - Initial rental price: ${locacao.PrecoLocacao}",
                $"• Contracting Client:",
                $"      - Name: {locacao.ClienteContratante.Nome}",
                $"      - Unique registry: {locacao.ClienteContratante.RegistroUnico}",
                $"      - Email: {locacao.ClienteContratante.Email}",
                $"• Conducting Client:",
                $"      - Name: {locacao.ClienteCondutor.Nome}",
                $"      - Unique registry {locacao.ClienteCondutor.RegistroUnico}",
                $"      - Email: {locacao.ClienteCondutor.Email}",
                $"      - CNH: {locacao.ClienteCondutor.Cnh}",
                $"• Rented Vehicle:",
                $"      - Model: {locacao.Veiculo.modelo}",
                $"      - Brand: {locacao.Veiculo.marca}",
                $"      - Sign: {locacao.Veiculo.placa}",
                $"      - Year: {locacao.Veiculo.ano}",
                $"      - Collour: {locacao.Veiculo.cor}",
                $"      - Number of doors: {locacao.Veiculo.numeroPortas}",
                $"      - Current Mileage: {locacao.Veiculo.kilometragem} km"
            };
            try
            {
            GerarPdf(arquivo, titulo, linhas);

            }
            catch (Exception ex)
            {
                Log.Error("{DataEHora} / An error occurred when trying to generate the PDF {Feature} / Layer: Shared / {StackTrace}", DateTime.Now, this.ToString(), ex);
            }
        }

        private void GerarPdf(string nomeArquivo, string textoTitulo, List<string> textoLinhas)
        {
            double lineXPosition = 70;
            double lineYPosition = 15;
            XFont titleFont = new(fontFamily, tamanhoFonteTitulo, XFontStyle.Bold);
            XFont textFont = new(fontFamily, tamanhoFonteTexto, XFontStyle.Regular);

            PdfDocument pdf = new();
            pdf.Info.Title = textoTitulo;
            PdfPage pdfPage = pdf.AddPage();
            XGraphics graph = XGraphics.FromPdfPage(pdfPage);

            //titulo e cabeçalho
            graph.DrawString(textoTitulo, titleFont, XBrushes.Black, new XRect(lineXPosition * 0.60, lineYPosition, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            lineYPosition += tamanhoFonteTitulo * 0.5;
            graph.DrawString("___________________________________________________________", titleFont, XBrushes.Black, new XRect(0, lineYPosition, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            lineYPosition += tamanhoFonteTitulo * 2;

            //linhas
            foreach (string linha in textoLinhas)
            {
                graph.DrawString(linha, textFont, XBrushes.Black, new XRect(lineXPosition, lineYPosition, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                lineYPosition += tamanhoFonteTexto * 2;
            }

            pdf.Save(nomeArquivo);
            //Process.Start(nomeArquivo);
        }
    }
}
