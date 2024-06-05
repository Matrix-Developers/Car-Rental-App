using LocadoraDeVeiculos.Aplicacao.GrupoDeVeiculosModule;
using LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule;
using LocadoraDeVeiculos.Infra.Logs;
using LocadoraDeVeiculos.WindowsApp.GrupoDeVeiculos;
using LocadoraDeVeiculos.WindowsApp.Shared;
using Serilog;
using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Features.GrupoDeVeiculos
{
    public class OperacoesGrupoDeVeiculos : ICadastravel
    {
        private readonly GrupoDeVeiculosAppService grupoDeVeiculosAppService;
        private readonly TabelaGrupoDeVeiculosControl tabelaGrupoDeVeiculos;

        public OperacoesGrupoDeVeiculos(GrupoDeVeiculosAppService GrupoDeVeiculosAppService)
        {
            grupoDeVeiculosAppService = GrupoDeVeiculosAppService;
            tabelaGrupoDeVeiculos = new TabelaGrupoDeVeiculosControl();
        }

        public void InserirNovoRegistro()
        {
            TarefaGrupoDeVeiculosForm tela = new("Registre Vehicle Group");
            Log.Logger.Information("{DataEHora} / {Feature} / Layer: {Layer} / User: {UsuarioLogado}", DateTime.Now, this.ToString(), "Apresentação", TelaPrincipalForm.FuncionarioLogado);
            if (tela.ShowDialog() == DialogResult.OK)
            {
                bool resultado = grupoDeVeiculosAppService.InserirEntidade(tela.GrupoDeVeiculos);

                List<GrupoDeVeiculo> grupoDeVeiculos = grupoDeVeiculosAppService.SelecionarTodasEntidade();

                tabelaGrupoDeVeiculos.AtualizarRegistros(grupoDeVeiculos);

                if (resultado)
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Vehicle Group: '{tela.GrupoDeVeiculos.Nome}' inserted sucessfully");
                else
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Unable to insert Vehicle Group: '{tela.GrupoDeVeiculos.Nome}', see the log for more information");
            }
        }

        public void EditarRegistro()
        {
            int id = tabelaGrupoDeVeiculos.ObtemIdSelecionado();
            Log.Logger.Information("{DataEHora} / {Feature} / Layer: {Layer} / User: {UsuarioLogado}", DateTime.Now, this.ToString(), "Apresentação", TelaPrincipalForm.FuncionarioLogado);
            if (id == 0)
            {
                MessageBox.Show("Select at least one Vehicle Group to Edit", "Edit Vehicle Group",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            GrupoDeVeiculo grupoSelecionado = grupoDeVeiculosAppService.SelecionarEntidadePorId(id);

            TarefaGrupoDeVeiculosForm tela = new("Edit Vehicle Group");

            tela.GrupoDeVeiculos = grupoSelecionado;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                bool resultado = grupoDeVeiculosAppService.EditarEntidade(id, tela.GrupoDeVeiculos);

                List<GrupoDeVeiculo> grupoDeVeiculos = grupoDeVeiculosAppService.SelecionarTodasEntidade();

                tabelaGrupoDeVeiculos.AtualizarRegistros(grupoDeVeiculos);

                if (resultado)
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Vehicle Groupd: '{tela.GrupoDeVeiculos.Nome}' edited sucessfully");
                else
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Unable to delete Vehicle Group: '{tela.GrupoDeVeiculos.Nome}', see the log for more information");
            }
        }

        public void ExcluirRegistro()
        {
            Log.Logger.Information("{DataEHora} / {Feature} / Layer: {Layer} / User: {UsuarioLogado}", DateTime.Now, this.ToString(), "Apresentação", TelaPrincipalForm.FuncionarioLogado);
            int id = tabelaGrupoDeVeiculos.ObtemIdSelecionado();
            if (id == 0)
            {
                MessageBox.Show("Select at least one Vehicle Group to Delete", "Delete Vehicle Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            GrupoDeVeiculo grupoSelecionado = grupoDeVeiculosAppService.SelecionarEntidadePorId(id);

            if (MessageBox.Show($"Are you sure you want to the Delete the Vehicle Group: '{grupoSelecionado.Nome}' ?",
                "Delete Vehicle Group", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bool resultado = grupoDeVeiculosAppService.ExcluirEntidade(id);

                List<GrupoDeVeiculo> grupos = grupoDeVeiculosAppService.SelecionarTodasEntidade();

                tabelaGrupoDeVeiculos.AtualizarRegistros(grupos);
                if (resultado)
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Vehicle Group: '{grupoSelecionado.Nome}' deleted sucessfully");
                else
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Unable to delete Vehicle Group: '{grupoSelecionado.Nome}', see the log for more information");
            }
        }

        public void FiltrarRegistros()
        {
            throw new NotImplementedException();
        }

        public void AgruparRegistros()
        {
            throw new NotImplementedException();
        }


        public UserControl ObterTabela()
        {
            List<GrupoDeVeiculo> grupoDeVeiculos = grupoDeVeiculosAppService.SelecionarTodasEntidade();
            tabelaGrupoDeVeiculos.AtualizarRegistros(grupoDeVeiculos);

            return tabelaGrupoDeVeiculos;
        }
    }
}
