using LocadoraDeVeiculos.Aplicacao.CupomModule;
using LocadoraDeVeiculos.Aplicacao.ParceiroModule;
using LocadoraDeVeiculos.Controladores.CupomModule;
using LocadoraDeVeiculos.Dominio.CupomModule;
using LocadoraDeVeiculos.WindowsApp.Shared;
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
            TelaCupomForm tela = new("Cadastro de Cupom", parceiroAppService);

            if (tela.ShowDialog() == DialogResult.OK)
            {
                appService.InserirNovoCupom(tela.Cupom);

                List<Cupom> cupons = appService.SelecionarTodosCupom();

                tabela.AtualizarRegistros(cupons);

                TelaPrincipalForm.Instancia.AtualizarRodape($"Cupom: [{tela.Cupom.Nome}] inserido com sucesso");
            }
        }

        public void EditarRegistro()
        {
            TelaCupomForm tela = new("Edição de Cupom", parceiroAppService);

            int id = tabela.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um Cupom para poder Editar!", "Edição de Cupons", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Cupom cupomSelecionado = appService.SelecionarCupomPorId(id);
            
            tela.Cupom = cupomSelecionado;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                appService.EditarCupom(id, tela.Cupom);
                List<Cupom> funcionarios = appService.SelecionarTodosCupom();
                tabela.AtualizarRegistros(funcionarios);
                TelaPrincipalForm.Instancia.AtualizarRodape($"Cupom: [{cupomSelecionado.Nome}] editado com sucesso");
            }
        }

        public void ExcluirRegistro()
        {
            int id = tabela.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um Cupom para excluir", "Exclusão de Cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Cupom parceiroSelecionado = appService.SelecionarCupomPorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir o cupom: [{parceiroSelecionado.Nome}] ?", "Exclusão de Cupons", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                appService.ExcluirCupom(id);
                List<Cupom> cupons = appService.SelecionarTodosCupom();
                tabela.AtualizarRegistros(cupons);
                TelaPrincipalForm.Instancia.AtualizarRodape($"Cupom: [{parceiroSelecionado.Nome}] removido com sucesso");
            }
        }

        public UserControl ObterTabela()
        {
            List<Cupom> cupons = appService.SelecionarTodosCupom();
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
