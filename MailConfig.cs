using Newtonsoft.Json;
using System;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Config
{
    public class setupSMTP
    {
        public string To { get; set; }
        public string From { get; set; }
        public string PassWord { get; set; }
        public int Porta { get; set; }
        public string Host { get; set; }
    }

    public class MailConfig
    {
        public void DisparaMail(string Body, string Subject)
        {

            var Setup = File.ReadAllText("SetupSMTP.txt");
            setupSMTP resposta = JsonConvert.DeserializeObject<setupSMTP>(Setup);

            //Objeto MailMessage
            MailMessage mail = new MailMessage();

            mail.From = new MailAddress(resposta.From);
            mail.To.Add(resposta.To); // para
            mail.Subject = Subject; // assunto
            mail.Body = Body; // mensagem


            SmtpClient cliente = new SmtpClient();
            cliente.Credentials = new System.Net.NetworkCredential(resposta.From, resposta.PassWord);

            cliente.Port = resposta.Porta;
            cliente.Host = resposta.Host;
            cliente.EnableSsl = true;

            cliente.Send(mail);
        }

    }


}

