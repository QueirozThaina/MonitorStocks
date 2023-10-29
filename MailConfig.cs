using System;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Config
{
    public class MailConfig
    {
        public void DisparaMail(string Destino, string Body, string Subject)
        {


            //Objeto MailMessage
            MailMessage mail = new MailMessage();

            mail.From = new MailAddress("thaii.queiroz95@gmail.com");
            mail.To.Add(Destino); // para
            mail.Subject = Subject; // assunto
            mail.Body = Body; // mensagem


            SmtpClient cliente = new SmtpClient();
            cliente.Credentials = new System.Net.NetworkCredential("thaii.queiroz95@gmail.com", "ygek enbf orjf ccpg");

            cliente.Port = 587;
            cliente.Host = "smtp.gmail.com";
            cliente.EnableSsl = true;

            cliente.Send(mail);
        }

    }


}

