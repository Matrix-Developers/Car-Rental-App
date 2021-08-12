using Microsoft.VisualStudio.TestTools.UnitTesting;
using LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule;
using FluentAssertions;
using System;

namespace LocadoraDeVeiculos.Tests.GrupoDeVeiculosModule
{
    [TestClass]
    public class GrupoDeVeiculosDominioTest
    {
        [TestMethod]
        public void DeveCriarGrupoDeVeiculo_Correto()
        {
            GrupoDeVeiculos grupoDeVeiculos = new GrupoDeVeiculos(0,"nome", 12.50f, 25.73f, 13.99f, 200);

            string resultado = grupoDeVeiculos.Validar();

            Assert.AreEqual("VALIDO", resultado);
        }

        [TestMethod]
        public void DeveApresentarErro_GrupoTotalmenteIncorreto()
        {
            GrupoDeVeiculos grupoDeVeiculos = new GrupoDeVeiculos(0,"",0f,0f,0f,0);

            string resultado = grupoDeVeiculos.Validar();

            Assert.AreEqual("O nome não pode ser nulo\nA taxa do Quilometro Controlado não pode ser nula nem negativa\nA taxa do Plano Diário não pode ser nula nem negativa\nA taxa do Quilometro Livre não pode ser nula nem negativa\nA quantidade de quilômetros não pode ser nulo nem negativo", 
                            resultado);
        }

        [TestMethod]
        public void DeveApresentarErro_SomenteNomeCorreto()
        {
            GrupoDeVeiculos grupoDeVeiculos = new GrupoDeVeiculos(0,"nome", 0f, 0f, 0f, 0);

            string resultado = grupoDeVeiculos.Validar();

            Assert.AreEqual("A taxa do Quilometro Controlado não pode ser nula nem negativa\nA taxa do Plano Diário não pode ser nula nem negativa\nA taxa do Quilometro Livre não pode ser nula nem negativa\nA quantidade de quilômetros não pode ser nulo nem negativo",
                            resultado);
        }

        [TestMethod]
        public void DeveApresentarErro_SomenteNomeIncorreto()
        {
            GrupoDeVeiculos grupoDeVeiculos = new GrupoDeVeiculos(0,"", 10f, 10f, 10f, 10);

            string resultado = grupoDeVeiculos.Validar();

            Assert.AreEqual("O nome não pode ser nulo\n",
                            resultado);
        }
    }
}
