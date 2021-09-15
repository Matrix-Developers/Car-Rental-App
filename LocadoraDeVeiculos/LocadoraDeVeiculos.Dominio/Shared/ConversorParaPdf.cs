using LocadoraDeVeiculos.Dominio.LocacaoModule;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
//using PdfSharp.Drawing;
//using PdfSharp.Pdf;
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
            string arquivo = $@"..\..\..\..\Recibos\recibo{locacao.Id}.pdf";
            string titulo = $"Recibo Locadora de Veículos - Locação {locacao.Id}";

            List<string> linhas = new()
            {
                $"• Detalhes da Locação:",
                $"      - Seguro selecionado: {locacao.TipoDeSeguro}",
                $"      - Plano selecionado: {locacao.TipoDoPlano}",
                $"      - Data de locação: {locacao.DataDeSaida.Date:dd/MM/yyyy}",
                $"      - Data prevista de devolução: {locacao.DataPrevistaDeChegada.Date:dd/MM/yyyy}",
                $"      - Preco inicial da locação: R${locacao.PrecoLocacao}",
                $"• Cliente contratante:",
                $"      - Nome: {locacao.ClienteContratante.Nome}",
                $"      - Registro Único: {locacao.ClienteContratante.RegistroUnico}",
                $"      - Email: {locacao.ClienteContratante.Email}",
                $"• Cliente condutor:",
                $"      - Nome: {locacao.ClienteCondutor.Nome}",
                $"      - Registro Único: {locacao.ClienteCondutor.RegistroUnico}",
                $"      - Email: {locacao.ClienteCondutor.Email}",
                $"      - CNH: {locacao.ClienteCondutor.Cnh}",
                $"• Veículo locado:",
                $"      - Modelo: {locacao.Veiculo.modelo}",
                $"      - Marca: {locacao.Veiculo.marca}",
                $"      - Placa: {locacao.Veiculo.placa}",
                $"      - Ano: {locacao.Veiculo.ano}",
                $"      - Cor: {locacao.Veiculo.cor}",
                $"      - Número de portas: {locacao.Veiculo.numeroPortas}",
                $"      - Kilometragem atual: {locacao.Veiculo.kilometragem} km"
            };

            GerarPdf(arquivo, titulo, linhas);
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
