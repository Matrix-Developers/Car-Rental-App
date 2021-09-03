using LocadoraDeVeiculos.Controladores.LocacaoModule;
using LocadoraDeVeiculos.Controladores.RelacionamentoLocServModule;
using LocadoraDeVeiculos.Dominio.LocacaoModule;
using LocadoraDeVeiculos.Dominio.RelacionamentoLocServModule;
using LocadoraDeVeiculos.WindowsApp.Servicos;
using LocadoraDeVeiculos.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Features.Locacoes
{
    public class OperacoesLocacao : ICadastravel
    {
        private readonly ControladorLocacao controlador = null;
        private readonly ControladorRelacionamentoLocServ controladorRelacionamento = null;
        private RelacionamentoLocServ relacionamento;
        private readonly TabelaLocacaoControl tabelaLocacao = null;
        public OperacoesLocacao(ControladorLocacao ctrlLocacao)
        {
            controlador = ctrlLocacao;
            controladorRelacionamento = new ControladorRelacionamentoLocServ();
            tabelaLocacao = new TabelaLocacaoControl();
        }

        public void InserirNovoRegistro()
        {
            TelaLocacaoForm tela = new TelaLocacaoForm("Locação de Veiculos");

            if (tela.ShowDialog() == DialogResult.OK)
            {
                string resultadoLocacao = controlador.InserirNovo(tela.Locacao);

                relacionamento = new RelacionamentoLocServ(0, tela.Locacao, tela.Servicos);
                controladorRelacionamento.InserirNovo(relacionamento);
                if (resultadoLocacao == "VALIDO")
                {
                    try
                    {
                        EnviarEmail(tela);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao tentar enviar os dados de locação por e-mail.\nO recibo está salvo na pasta Recibos e deverá ser enviado manualmente assim que possível!!\n" + ex.Message, "Erro ao enviar e-mail");
                    }
                }

                List<Locacao> veiculos = controlador.SelecionarTodos();

                tabelaLocacao.AtualizarRegistros(veiculos);

                TelaPrincipalForm.Instancia.AtualizarRodape($"Locação: [{tela.Locacao.Veiculo}] realizada com sucesso");
            }
        }

        public void EditarRegistro()
        {
            int id = tabelaLocacao.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione uma locação para poder editar!", "Edição de locação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Locacao locacaoSelecionada = controlador.SelecionarPorId(id);

            TelaLocacaoForm tela = new TelaLocacaoForm("Edição de Locação");

            tela.Locacao = locacaoSelecionada;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.Editar(id, tela.Locacao);

                List<Locacao> veiculos = controlador.SelecionarTodos();

                tabelaLocacao.AtualizarRegistros(veiculos);

                TelaPrincipalForm.Instancia.AtualizarRodape($"Locação de: [{tela.Locacao.ClienteContratante}] editado com sucesso");
            }
        }

        public void ExcluirRegistro()
        {
            int id = tabelaLocacao.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione uma locação para poder excluir!", "Exclusão de Locação",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Locacao locacaoSelecionada = controlador.SelecionarPorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir a locação: [{locacaoSelecionada.Id}] ?",
                "Exclusão de Locação", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                controlador.Excluir(id);

                List<Locacao> veiculos = controlador.SelecionarTodos();

                tabelaLocacao.AtualizarRegistros(veiculos);

                TelaPrincipalForm.Instancia.AtualizarRodape($"Locação de: [{locacaoSelecionada.ClienteContratante}] removida com sucesso");
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
            List<Locacao> locacoes = controlador.SelecionarTodos();
            tabelaLocacao.AtualizarRegistros(locacoes);

            return tabelaLocacao;
        }

        private void EnviarEmail(TelaLocacaoForm tela)
        {
            using (SmtpClient smtp = new SmtpClient())
            {
                using (MailMessage email = new MailMessage())
                {
                    smtp.Host = "smtp.gmail.com";
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new System.Net.NetworkCredential("matriquisdevelopers@gmail.com", "matrixadm");
                    smtp.Port = 587;
                    smtp.EnableSsl = true;

                    email.From = new MailAddress("matriquisdevelopers@gmail.com");
                    email.To.Add(tela.Locacao.ClienteContratante.Email);

                    email.Subject = "Matrix";
                    email.IsBodyHtml = false;
                    email.Body = "Obrigado por utilizar nossos serviços, volte sempre!";


                    email.Attachments.Add(new Attachment($@"..\..\..\Recibos\recibo{tela.Locacao.Id}.pdf"));

                    smtp.Send(email);
                }
            }
        }
    }
}
