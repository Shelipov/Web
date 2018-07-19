using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit;

namespace Web.Services
{
    // This class is used by the application to send email for account confirmation and password reset.
    // For more details see https://go.microsoft.com/fwlink/?LinkID=532713
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
            return Task.CompletedTask;
        }
        //public async Task SendEmailAsync(string email, string subject, string message)
        //{
        //    var emailMessage = new MimeMessage();  //Serge Shelipov
        //                                           // testdevelopmentemail911@gmail.com

        //    emailMessage.From.Add(new MailboxAddress("Администрация сайта", "testdevelopmentemail911@gmail.com"));
        //    emailMessage.To.Add(new MailboxAddress("", email));
        //    emailMessage.Subject = subject;
        //    emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
        //    {
        //        Text = message
        //    };

        //    using (var client = new SmtpClient())
        //    {

        //        //client.SslProtocols = System.Security.Authentication.SslProtocols.Tls11;
        //        client.ServerCertificateValidationCallback = (s, c, h, e) => true;
        //        await client.ConnectAsync("smtp.gmail.com", 465, false);  //на этом этапе может вылететь
        //        //ошибка снртификата google это особенность их сервера 
        //        //если вылетела надо вручную в бд подтвердить регистрацию и попробовать другой email сервис
        //        await client.AuthenticateAsync("testdevelopmentemail911@gmail.com", "test911test");
        //        await client.SendAsync(emailMessage);

        //        await client.DisconnectAsync(true);
        //    }
    //}
    }
}
