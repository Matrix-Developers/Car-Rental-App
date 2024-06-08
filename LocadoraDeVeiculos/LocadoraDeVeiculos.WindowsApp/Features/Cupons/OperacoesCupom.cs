using LocadoraDeVeiculos.Aplicacao.CupomModule;
using LocadoraDeVeiculos.Aplicacao.ParceiroModule;
using LocadoraDeVeiculos.Dominio.CupomModule;
using LocadoraDeVeiculos.Infra.Logs;
using LocadoraDeVeiculos.WindowsApp.Shared;
using Serilog;
using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

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
            Log.Logger.Information("{DataEHora} / {Feature} / Layer: {Layer} / Module: {Modulo} / User: {UsuarioLogado}", DateTime.Now, this.ToString(), "Apresentação", "Insert", TelaPrincipalForm.FuncionarioLogado);
            TelaCupomForm tela = new("Register Coupon", parceiroAppService);

            if (tela.ShowDialog() == DialogResult.OK)
            {
                bool resultado = appService.InserirEntidade(tela.Cupom);

                List<Cupom> cupons = appService.SelecionarTodasEntidade();

                tabela.AtualizarRegistros(cupons);
                if(resultado)
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Coupon: '{tela.Cupom.Nome}' added sucessfully");
                else
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Error inserting Coupon: '{tela.Cupom.Nome}', verify the log for more information");

            }
        }

        public void EditarRegistro()
        {
            Log.Logger.Information("{DataEHora} / {Feature} / Layer: {Layer} / Module: {Modulo} / User: {UsuarioLogado}", DateTime.Now, this.ToString(), "Apresentação", "Inserir", TelaPrincipalForm.FuncionarioLogado);
            TelaCupomForm tela = new("Edit Coupon", parceiroAppService);

            int id = tabela.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Select at least one Coupon to edit.", "Edit Coupon", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                      TelaPrincipalForm.Instancia.AtualizarRodape($"Coupon: '{cupomSelecionado.Nome}' edited sucessfully");
                else
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Error editing Coupon: '{cupomSelecionado.Nome}', verify the log for more information\"");

            }
        }

        public void ExcluirRegistro()
        {
            Log.Logger.Information("{DataEHora} / {Feature} / Layer: {Layer} / Module: {Modulo} / User: {UsuarioLogado}", DateTime.Now, this.ToString(), "Apresentação", "Inserir", TelaPrincipalForm.FuncionarioLogado);
            int id = tabela.ObtemIdSelecionado();
            if (id == 0)
            {
                MessageBox.Show("Select at least one Coupon to Delete.", "Delete Coupon", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Cupom parceiroSelecionado = appService.SelecionarEntidadePorId(id);

            if (MessageBox.Show($"Are you sure you want to delete the Coupon: '{parceiroSelecionado.Nome}' ?", "Delete Coupons", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                bool resultado = appService.ExcluirEntidade(id);
                List<Cupom> cupons = appService.SelecionarTodasEntidade();
                tabela.AtualizarRegistros(cupons);
                if(resultado)
                     TelaPrincipalForm.Instancia.AtualizarRodape($"Coupon: '{parceiroSelecionado.Nome}' deleted sucessfully.");
                else
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Error deleting Coupon: '{parceiroSelecionado.Nome}', verify the log for more information");


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
