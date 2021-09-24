using LocadoraDeVeiculos.Aplicacao.ParceiroModule;
using LocadoraDeVeiculos.Dominio.ParceiroModule;
using LocadoraDeVeiculos.Infra.Logs;
using LocadoraDeVeiculos.WindowsApp.Shared;
using Serilog;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Features.Parceiros
{
    public class OperacoesParceiro : ICadastravel
    {
        private readonly ParceiroAppService appService;
        private readonly TabelaParceiroControl tabela;

        public OperacoesParceiro(ParceiroAppService parceiroAppService)
        {            
            appService = parceiroAppService;
            tabela = new TabelaParceiroControl();
        }

        public void InserirNovoRegistro()
        {
            GeradorLog.ConfigurarLog();
            Log.Logger.Information("{DataEHora} / {Feature} / Camada: {Camada} / IdUsuario? / Tempo?", DateTime.Now, this.ToString(), "Apresentação");
            TelaParceiroForm tela = new("Cadastro de Parceiro");

            if (tela.ShowDialog() == DialogResult.OK)
            {
                appService.InserirEntidade(tela.Parceiro);

                List<Parceiro> parceiros = appService.SelecionarTodasEntidade();

                tabela.AtualizarRegistros(parceiros);

                TelaPrincipalForm.Instancia.AtualizarRodape($"Parceiro: [{tela.Parceiro.Nome}] inserido com sucesso");
            }
        }

        public void EditarRegistro()
        {
            int id = tabela.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um Parceiro para poder Editar!", "Edição de Parceiros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Parceiro parceiroSelecionado = appService.SelecionarEntidadePorId(id);
            TelaParceiroForm tela = new("Edição de Parceiro");
            tela.Parceiro = parceiroSelecionado;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                appService.EditarEntidade(id, tela.Parceiro);
                List<Parceiro> parceiros = appService.SelecionarTodasEntidade();
                tabela.AtualizarRegistros(parceiros);
                TelaPrincipalForm.Instancia.AtualizarRodape($"Parceiro: [{parceiroSelecionado.Nome}] editado com sucesso");
            }
        }

        public void ExcluirRegistro()
        {
            int id = tabela.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um Parceiro para excluir", "Exclusão de Parceiro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Parceiro parceiroSelecionado = appService.SelecionarEntidadePorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir o Parceiro: [{parceiroSelecionado.Nome}] ?", "Exclusão de Parceiros", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                appService.ExcluirEntidade(id);
                List<Parceiro> parceiros = appService.SelecionarTodasEntidade();
                tabela.AtualizarRegistros(parceiros);
                TelaPrincipalForm.Instancia.AtualizarRodape($"Parceiro: [{parceiroSelecionado.Nome}] removido com sucesso");
            }
        }
        public void AgruparRegistros()
        {
            throw new NotImplementedException();
        }

        public void FiltrarRegistros()
        {
            throw new NotImplementedException();
        }
        public UserControl ObterTabela()
        {
            List<Parceiro> cupons = appService.SelecionarTodasEntidade();
            tabela.AtualizarRegistros(cupons);
            return tabela;
        }
    }
}
