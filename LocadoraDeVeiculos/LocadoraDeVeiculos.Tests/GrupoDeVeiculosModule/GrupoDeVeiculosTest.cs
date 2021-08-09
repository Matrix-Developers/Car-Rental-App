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
            GrupoDeVeiculos grupoDeVeiculos = new GrupoDeVeiculos("nome", 12.50f, 25.73f, 200, 13.99f);

            Assert.AreEqual("VALIDO", grupoDeVeiculos.Validar());
        }

        [TestMethod]
        public void DeveCriarDominioIncorreto()
        {
            GrupoDeVeiculos grupoDeVeiculos = new GrupoDeVeiculos("",0f,0f,0,0f);

            Assert.AreEqual("O nome não pode ser nulo\nA taxa do Quilometro Controlado não pode ser nula nem negativa\nA taxa do Plano Diário não pode ser nula nem negativa\nA taxa do Quilometro Livre não pode ser nula nem negativa\nA quantidade de quilômetros não pode ser nulo nem negativo", 
                            grupoDeVeiculos.Validar());
        }
    }
}
