using System;
using System.Net;
using System.Net.Mail;

namespace Biblioteca.Auxiliares
{
    public static class Email
    {
        public static bool Enviar(string assunto,  string conteudo)
        {
            try
            {                
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                message.From = new MailAddress("sistema@davidoliveira.dev", "Contato Site");
                message.To.Add(new MailAddress("contato@davidoliveira.dev"));
                message.Subject = assunto;
                message.IsBodyHtml = false;
                message.Body = conteudo;

                smtp.Port = 587;
                smtp.Host = "mail.davidoliveira.dev";
                smtp.EnableSsl = false;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("sistema@davidoliveira.dev", "riseofdestiny564");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
