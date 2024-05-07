using LocadoraDeVeiculos.Dominio.ClienteModule;
using LocadoraDeVeiculos.Dominio.CupomModule;
using LocadoraDeVeiculos.Dominio.FuncionarioModule;
using LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule;
using LocadoraDeVeiculos.Dominio.LocacaoModule;
using LocadoraDeVeiculos.Dominio.ParceiroModule;
using LocadoraDeVeiculos.Dominio.SevicosModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Dominio.VeiculoModule;
using LocadoraDeVeiculos.Infra.EntityFramework;
using LocadoraDeVeiculos.Infra.EntityFramework.Features;
using LocadoraDeVeiculos.TestDataBuilders;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.ORMTests.Shared
{
    [TestClass]
    public class PopularBancoORMTest
    {
        bool deveLimparBanco = false;
        #region atributos privados
        private IRepository<Locacao> controlador;
        private IRepository<GrupoDeVeiculo> controladorGrupoDeVeiculos;
        private IRepository<Veiculo> controladorVeiculo;
        private IRepository<Funcionario> controladorFuncionario;
        private IRepository<Cliente> controladorCliente;
        private IRepository<Parceiro> controladorParceiro;
        private IRepository<Cupom> controladorCupom;
        private IRepository<Servico> controladorServico;
        private LocadoraDeVeiculosDBContext dbContext = new();

        private Locacao locacao1, locacao2, locacao3;
        private GrupoDeVeiculo suv, sedan, utilitarios;

        private Veiculo kicks, fusca, clio;

        private Funcionario beto, joao, mario;

        private Cliente condutorBruno, condutorPedro, condutorMaria;

        private Servico caderinhaBebe, lavacaoCarro, trocaOleo;

        private Cupom descontaoDoDeko, nddtech, cupombrabo;
        private Parceiro gabriel, jose, maria;

        List<Servico> servicos = new();

     
        #endregion

        [SetUp]
        public void Setup()
        {
            LocadoraDeVeiculosDBContext dbContext = new();
            controlador = new LocacaoORM(dbContext);
            controladorGrupoDeVeiculos = new GrupoDeVeiculosORM(dbContext);
            controladorVeiculo = new VeiculoORM(dbContext);
            controladorFuncionario = new FuncionarioORM(dbContext);
            controladorCliente = new ClienteORM(dbContext);
            controladorParceiro = new ParceiroORM(dbContext);
            controladorCupom = new CupomORM(dbContext);
            controladorServico = new ServicoORM(dbContext);
        }
        [TearDown]
        public void TearDown()
        {
            if (deveLimparBanco)
            {
                var listaLocacaoes = dbContext.Locacoes.ToList().Select(x => x as Locacao);
                foreach (var item in listaLocacaoes)
                    dbContext.Locacoes.Remove(item);

                var listaClientes = dbContext.Clientes.ToList().Select(x => x as Cliente);
                foreach (var item in listaClientes)
                    dbContext.Clientes.Remove(item);

                var listaCupons = dbContext.Cupons.ToList().Select(x => x as Cupom);
                foreach (var cupom in listaCupons)
                    dbContext.Cupons.Remove(cupom);
                dbContext.SaveChanges();

                var listaParceiros = dbContext.Parceiros.ToList().Select(x => x as Parceiro);
                foreach (var item in listaParceiros)
                    dbContext.Parceiros.Remove(item);

                var listaFuncionario = dbContext.Funcionarios.ToList().Select(x => x as Funcionario);
                foreach (var item in listaFuncionario)
                    dbContext.Funcionarios.Remove(item);

                var listaGrupo = dbContext.GrupoDeVeiculos.ToList().Select(x => x as GrupoDeVeiculo);
                foreach (var item in listaGrupo)
                    dbContext.GrupoDeVeiculos.Remove(item);

                var listaServicos = dbContext.Servicos.ToList().Select(x => x as Servico);
                foreach (var item in listaServicos)
                    dbContext.Servicos.Remove(item);

                var listaVeiculos = dbContext.Veiculos.ToList().Select(x => x as Veiculo);
                foreach (var item in listaVeiculos)
                    dbContext.Veiculos.Remove(item);

                dbContext.SaveChanges();
            }
        }

        [Test]
        public void PopularBanco()
        {
            if (!deveLimparBanco)
            {
                InserirParceiros();
                InserirCupons();
                InserirClientes();
                InserirFuncionarios();
                InserirGrupoDeVeiculos();
                InserirServicos();
                InserirVeiculos();
                InserirLocacoes();
            }
        }

        private void InserirLocacoes()
        {
            //bug ClienteId e Lista de Servico 
            locacao1 = new Locacao(0, clio, beto, condutorPedro, condutorPedro, descontaoDoDeko, DateTime.Today, DateTime.Today.AddDays(5f), "KmLivre", "Nenhum", servicos);
            locacao2 = new Locacao(0, fusca, joao, condutorBruno, condutorBruno, cupombrabo, DateTime.Today, DateTime.Today.AddDays(5f), "KmLivre", "Nenhum", null);
            locacao3 = new Locacao(0, kicks, mario, condutorMaria, condutorMaria, nddtech, DateTime.Today, DateTime.Today.AddDays(5f), "KmLivre", "Nenhum", null);

            controlador.InserirNovo(locacao1);
            controlador.InserirNovo(locacao2);
            controlador.InserirNovo(locacao3);
        }

        private void InserirVeiculos()
        {
            //Bug Grupo de Veiculos
            kicks = new(0, "kicks", suv, "FWE-4652", "4DF56F78E8WE9WED", "Nissan", "Prata", "Gasolina Comum", 60.5, 2018, 30000, 4, 5, 'G', true, true, true, true);
            fusca = new(0, "fusca", sedan, "FWW-4652", "4DF56F78E8WE9WED", "Ford", "Prata", "Gasolina Comum", 60.5, 2018, 30000, 4, 5, 'G', true, true, true, true);    
            clio= new(0, "clio", utilitarios, "DAS-4652", "4DF56F78E8WE9WED", "Renault", "Prata", "Gasolina Comum", 60.5, 2018, 30000, 4, 5, 'G', true, true, true, true);

            controladorVeiculo.InserirNovo(kicks);
            controladorVeiculo.InserirNovo(fusca);
            controladorVeiculo.InserirNovo(clio);
        }

        private void InserirServicos()
        {
            caderinhaBebe = new(0, "cadeirinha", true, 100f);
            lavacaoCarro = new(0, "Lavacao", true, 100f);
            trocaOleo = new(0, "troca de oleo", true, 100f);

            controladorServico.InserirNovo(caderinhaBebe);
            controladorServico.InserirNovo(lavacaoCarro);
            controladorServico.InserirNovo(trocaOleo);
        }

        private void InserirGrupoDeVeiculos()
        {
            suv = new(0, "suv", 15.3f, 16.5f, 20.5f, 30, 16.3f, 45.2f);
            sedan = new(0, "sedan", 12.3f, 16.5f, 20.5f, 30, 16.3f, 45.2f);
            utilitarios = new(0, "utilitarios", 17.3f, 15.5f, 20.5f, 30, 16.3f, 45.2f);

            controladorGrupoDeVeiculos.InserirNovo(suv);
            controladorGrupoDeVeiculos.InserirNovo(sedan);
            controladorGrupoDeVeiculos.InserirNovo(utilitarios);
        }

        private void InserirFuncionarios()
        {
            beto = new Funcionario(0, "Nome", "954.746.736-04", "Endereco Lages", "4932518000", "teste@email.com", 001, "beto01", "12345644", new DateTime(2021, 01, 01), "Maluco", 1000f, true);
            joao = new Funcionario(0, "Beto", "954.746.736-04", "Rua KKKKK", "4932518000", "teste@hotmail.com", 001, "jao", "12345565", new DateTime(2021, 01, 01), "Dev", 1000f, true);
            mario = new Funcionario(0, "mario", "954.746.736-04", "Rua nao sei", "4932518000", "teste@outlook.com", 001, "mario777", "1234565", new DateTime(2021, 01, 01), "Vendedor", 1000f, true);

            controladorFuncionario.InserirNovo(beto);
            controladorFuncionario.InserirNovo(joao);
            controladorFuncionario.InserirNovo(mario);
        }

        private void InserirClientes()
        {
            condutorPedro = new Cliente(0, "Nome Teste", "954.746.736-04", "Endereco ", "4932518000", "teste@email.com", "978545956-90", new DateTime(2030, 05, 02), true);
            condutorBruno = new Cliente(0, "Nome", "954.746.736-04", "Endereco Cliente", "4932545700", "teste@hotmail.com", "978545956-90", new DateTime(2030, 03, 04), true);
            condutorMaria = new Cliente(0, "Maria", "954.746.736-04", "Endereco Lages", "4932514511", "teste@outlook.com", "978545956-90", new DateTime(2030, 06, 07), true);

            controladorCliente.InserirNovo(condutorMaria);
            controladorCliente.InserirNovo(condutorBruno);
            controladorCliente.InserirNovo(condutorPedro);
        }

        private void InserirCupons()
        {
            descontaoDoDeko = new(0,"deko","descontaododeko",10,5,true, DateTime.Today.AddDays(30),jose,5);
            nddtech = new(0,"NDD", "NDDTech", 20,10,true, DateTime.Today.AddDays(30),maria,5);
            cupombrabo = new(0,"lojinha","cupombrabo",30,15,true, DateTime.Today.AddDays(30),gabriel,5);

            controladorCupom.InserirNovo(descontaoDoDeko);
            controladorCupom.InserirNovo(nddtech);
            controladorCupom.InserirNovo(cupombrabo);
        }

        private void InserirParceiros()
        {
            jose = new(0,"Jose");
            maria = new(0,"Maria");
            gabriel = new(0,"Gabriel");
             
            controladorParceiro.InserirNovo(jose);
            controladorParceiro.InserirNovo(maria);
            controladorParceiro.InserirNovo(gabriel);
        }

    }
}
