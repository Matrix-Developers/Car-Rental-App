using Microsoft.VisualStudio.TestTools.UnitTesting;
using LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule;
using FluentAssertions;
using System;

namespace LocadoraDeVeiculos.Tests.GrupoDeVeiculosModule
{
    [TestClass]
    public class GrupoDeVeiculosTest
    {
        [TestMethod]
        public void DeveCriarDominioCorreto()
        {
            GrupoDeVeiculos grupoDeVeiculos = new GrupoDeVeiculos();
            string nome = "nome";
            float taxaPlanoDiario = 12.50f;
            float taxaKmControlado = 25.73f;
            int quantidadeQuilometrosKmControlado = 200;
            float taxaKmLivre = 13.99f;

            grupoDeVeiculos.nome = nome;
            grupoDeVeiculos.taxaPlanoDiario = taxaPlanoDiario;
            grupoDeVeiculos.taxaKmControlado = taxaKmControlado;
            grupoDeVeiculos.quantidadeQuilometrosKmControlado = quantidadeQuilometrosKmControlado;
            grupoDeVeiculos.taxaKmLivre = taxaKmLivre;

            Assert.AreEqual("VALIDO", grupoDeVeiculos.Validar());
        }

        [TestMethod]
        public void DeveCriarDominioIncorreto()
        {
            GrupoDeVeiculos grupoDeVeiculos = new GrupoDeVeiculos();
            string nome = "";
            float taxaPlanoDiario = 0f;
            float taxaKmControlado = 0f;
            int quantidadeQuilometrosKmControlado = 0;
            float taxaKmLivre = 0f;

            grupoDeVeiculos.nome = nome;
            grupoDeVeiculos.taxaPlanoDiario = taxaPlanoDiario;
            grupoDeVeiculos.taxaKmControlado = taxaKmControlado;
            grupoDeVeiculos.quantidadeQuilometrosKmControlado = quantidadeQuilometrosKmControlado;
            grupoDeVeiculos.taxaKmLivre = taxaKmLivre;

            Assert.AreEqual("O nome não pode ser nulo\nA taxa do Quilometro Controlado não pode ser nula nem negativa\nA taxa do Plano Diário não pode ser nula nem negativa\nA taxa do Quilometro Livre não pode ser nula nem negativa\nA quantidade de quilômetros não pode ser nulo nem negativo", 
                            grupoDeVeiculos.Validar());
        }
    }
}
