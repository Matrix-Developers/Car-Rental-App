using LocadoraDeVeiculos.Dominio.LocacaoModule;
using Serilog;
using System;
using System.Net.Mail;

namespace LocadoraDeVeiculos.Infra.InternetServices
{
    public class GerenciadorDeEmail
    {
        public static void EnviarEmail(string emailRemetente, string passwordRemetente, Locacao locacaoEnviada)
        {
            using SmtpClient smtp = new();
            using MailMessage email = new();

            smtp.Host = "smtp.gmail.com";
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential(emailRemetente, passwordRemetente);
            smtp.Port = 587;
            smtp.EnableSsl = true;

            email.From = new MailAddress(emailRemetente);
            email.To.Add(locacaoEnviada.ClienteContratante.Email);

            email.Subject = "Matrix";
            email.IsBodyHtml = false;
            email.Body = "Obrigado por utilizar nossos serviços, volte sempre!";

            email.Attachments.Add(new Attachment($@"..\..\..\..\Recibos\recibo{locacaoEnviada.Id}.pdf"));

            try
            {
            smtp.Send(email);

            }
            catch (Exception ex)
            {
                Log.Error("{DataEHora} / Ocorreu um erro ao tentar enviar e-mail o(a) {Feature} / Layer: Repository / Usuário: IdUsuario Tempo: ?? /  {StackTrace}", DateTime.Now, "Gerenciador de E-Mail", ex);


            }
        }
    }
}
