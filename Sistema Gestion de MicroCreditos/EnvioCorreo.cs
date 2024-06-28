using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace Sistema_Gestion_de_MicroCreditos
{
    internal class EnvioCorreo
    {
        public string EnviarEmail(string to, string asunto, string body)
        {
            string mensaje = "ERROR. Verifique los datos ingresados.";
            string from = "ernestofh477@hotmail.com";
            string displayName = "Hola";
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(from, displayName);
                mail.To.Add(to);

                mail.Subject = asunto;
                mail.Body = body;
                mail.IsBodyHtml = true;


                SmtpClient client = new SmtpClient("smtp.office365.com", 587); //Aquí debes sustituir tu servidor SMTP y el puerto
                client.Credentials = new NetworkCredential(from, "supanigga103");
                client.EnableSsl = true;//En caso de que tu servidor de correo no utilice cifrado SSL,poner en false


                client.Send(mail);
                mensaje = "Se ha enviado el correo.";

            }
            catch (Exception ex)
            {
                mensaje = ex.Message + ". Por favor verifica tu conexión a internet y que tus datos sean correctos e intenta nuevamente.";
            }

            return mensaje;
        }
       
    }
}

