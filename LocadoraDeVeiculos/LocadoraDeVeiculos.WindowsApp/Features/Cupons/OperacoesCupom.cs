using LocadoraDeVeiculos.Aplicacao.CupomModule;
using LocadoraDeVeiculos.Aplicacao.ParceiroModule;
using LocadoraDeVeiculos.Dominio.CupomModule;
using LocadoraDeVeiculos.Infra.Logs;
using LocadoraDeVeiculos.WindowsApp.Shared;
using Serilog;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Features.Cupons
{
    public class OperacoesCupom : ICadastravel
    {
        private readonly CupomAppService appService;
        private readonly ParceiroAppService parceiroAppService;
        private readonly TabelaCupomControl tabela;

        public OperacoesCupom(CupomAppService cupomAppService, ParceiroAppService parceiroAppService)
        {
            this.parceiroAppService = parceiroAppService;
            appService = cupomAppService;
            tabela = new TabelaCupomControl();
        }

        public void InserirNovoRegistro()
        {
            Log.Logger.Information("{DataEHora} / {Feature} / Camada: {Camada} / Módulo: {Modulo} / Usuário: {UsuarioLogado}", DateTime.Now, this.ToString(), "Apresentação", "Inserir", TelaPrincipalForm.FuncionarioLogado);
            TelaCupomForm tela = new("Cadastro de Cupom", parceiroAppService);

            if (tela.ShowDialog() == DialogResult.OK)
            {
                bool resultado = appService.InserirEntidade(tela.Cupom);

                List<Cupom> cupons = appService.SelecionarTodasEntidade();

                tabela.AtualizarRegistros(cupons);
                if(resultado)
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Cupom: [{tela.Cupom.Nome}] inserido com sucesso");
                else
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Não foi possível inserir o cupom: [{tela.Cupom.Nome}], consulte o log para mais informações");

            }
        }

        public void EditarRegistro()
        {
            Log.Logger.Information("{DataEHora} / {Feature} / Camada: {Camada} / Módulo: {Modulo} / Usuário: {UsuarioLogado}", DateTime.Now, this.ToString(), "Apresentação", "Inserir", TelaPrincipalForm.FuncionarioLogado);
            TelaCupomForm tela = new("Edição de Cupom", parceiroAppService);

            int id = tabela.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um Cupom para poder Editar!", "Edição de Cupons", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Cupom cupomSelecionado = appService.SelecionarEntidadePorId(id);

            tela.Cupom = cupomSelecionado;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                bool resultado = appService.EditarEntidade(id, tela.Cupom);
                List<Cupom> funcionarios = appService.SelecionarTodasEntidade();
                tabela.AtualizarRegistros(funcionarios);
                if(resultado)
                      TelaPrincipalForm.Instancia.AtualizarRodape($"Cupom: [{cupomSelecionado.Nome}] editado com sucesso");
                else
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Não foi possível editar o cupom: [{cupomSelecionado.Nome}], consulte o log para mais informações");

            }
        }

        public void ExcluirRegistro()
        {
            Log.Logger.Information("{DataEHora} / {Feature} / Camada: {Camada} / Módulo: {Modulo} / Usuário: {UsuarioLogado}", DateTime.Now, this.ToString(), "Apresentação", "Inserir", TelaPrincipalForm.FuncionarioLogado);

            int id = tabela.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um Cupom para excluir", "Exclusão de Cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Cupom parceiroSelecionado = appService.SelecionarEntidadePorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir o cupom: [{parceiroSelecionado.Nome}] ?", "Exclusão de Cupons", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                bool resultado = appService.ExcluirEntidade(id);
                List<Cupom> cupons = appService.SelecionarTodasEntidade();
                tabela.AtualizarRegistros(cupons);
                if(resultado)
                     TelaPrincipalForm.Instancia.AtualizarRodape($"Cupom: [{parceiroSelecionado.Nome}] removido com sucesso");
                else
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Não foi possível editar o cupom: [{parceiroSelecionado.Nome}], consulte o log para mais informações");


            }
        }

        public UserControl ObterTabela()
        {
            List<Cupom> cupons = appService.SelecionarTodasEntidade();
            tabela.AtualizarRegistros(cupons);
            return tabela;
        }

        public void FiltrarRegistros()
        {
            throw new NotImplementedException();
        }

        public void AgruparRegistros()
        {
            throw new NotImplementedException();
        }
    }
}
