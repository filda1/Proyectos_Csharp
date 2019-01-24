using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RequisicaoSServer.Models
{
   public class Email
    {
        public void email(string assunto, string descripcion , string titulo)
        {
            /////////////////////// RECEPTOR ////////////////////////////////////////
            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
            msg.To.Add("Filinto@amfurniture.pt");
            //msg.To.Add("CarlosVales@amfurniture.pt");
            //msg.To.Add("Luisaalves@amfurniture.pt");
            msg.Subject = assunto;
            msg.SubjectEncoding = System.Text.Encoding.UTF8;
            msg.Bcc.Add("Filinto@amfurniture.pt");

            msg.Body = descripcion;
            msg.BodyEncoding = System.Text.Encoding.UTF8;
            msg.IsBodyHtml = true;
            /////////////////////////////////////////////////////////////////////////////


            /////////////////////// EMISOR //////////////////////////////////////////////
            ///
            msg.From = new System.Net.Mail.MailAddress("filintomeireles@gmail.com");
            //msg.From = new System.Net.Mail.MailAddress("Filinto@amfurniture.pt");
            System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("filintomeireles@gmail.com", "universo");
            //client.Credentials = new System.Net.NetworkCredential("SoporteAM@outlook.pt", "Amfurniture");
            //client.Credentials = new System.Net.NetworkCredential("Filinto@amfurniture.pt", "");

            //////////////////////////////////////////////////////////////////////////////

            client.Port = 587;  // gmail y hotmail

            client.EnableSsl = true;

            client.Host = "smtp.gmail.com";
            //client.Host = "smtp-mail.outlook.com";
            //client.Host = "smtp.live.com";

            try
            {
                client.Send(msg);
                //fala.Falar("Ok Enviado com exito!!");
                MessageBox.Show("Ok Enviado com exito!!");
            }
            catch (Exception)
            {
                //fala.Falar("Error");
                MessageBox.Show("Error");
            }
        }
    }
}
