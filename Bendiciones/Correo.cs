using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using System.ComponentModel;

namespace Bendiciones
{
    public class Correo
    {
        static string smtpAddress = "smtp.gmail.com";
        static int portNumber = 587;
        static bool enableSSL = true;
        static string emailFromAddress = "bendicionestest@gmail.com"; //Sender Email Address  
        static string password = "bendiciones1234."; //Sender Password  

        public void CorreoNuevoColaborador( Service.colaborador colaborador)
        {

			using (MailMessage mail = new MailMessage())
			{
				mail.From = new MailAddress(emailFromAddress);
				mail.To.Add(colaborador.email);
				mail.Subject = "Bienvenida/o a Escuela para embarazadas " + colaborador.nombre;
				mail.Body = "Usuario: " + colaborador.user + "<br>Contraseña: " + colaborador.password +
					"<br> Contraseña personal. Por favor, no comparta con nadie su contraseña" ; 
				mail.IsBodyHtml = true;
				using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
				{
					smtp.Credentials = new NetworkCredential(emailFromAddress, password);
					smtp.EnableSsl = enableSSL;
					smtp.Send(mail);
					frmMensaje mensaje = new frmMensaje("Se ha enviado el correo a " + colaborador.email, "", "");
				}
			}
               
            
        }
		
		public void CorreoNuevoServicio(Service.cliente cliente,BindingList<Service.matricula> matriculas)
		{

			using (MailMessage mail = new MailMessage())
			{
				mail.From = new MailAddress(emailFromAddress);
				mail.To.Add(cliente.email);
				mail.Subject = "Bienvenida/o a Escuela para embarazadas " + cliente.nombre;
				mail.Body = "La relacion de sus matricuals es\n\n";
				foreach(Service.matricula mat in matriculas)
				{
					mail.Body += mat.servicio.nombre +"\n";
				}
				mail.IsBodyHtml = true;
				using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
				{
					smtp.Credentials = new NetworkCredential(emailFromAddress, password);
					smtp.EnableSsl = enableSSL;
					smtp.Send(mail);
					frmMensaje mensaje = new frmMensaje("Se ha enviado Correo con los detalles a " + cliente.email, "", "");
				}
			}


		}

		public void RecuperarPassword(Service.colaborador colaborador)
		{
			using (MailMessage mail = new MailMessage())
			{
				mail.From = new MailAddress(emailFromAddress);
				mail.To.Add(colaborador.email);
				mail.Subject = "Recuperar Contraseña";
				mail.Body = "Estimado " + colaborador.nombre + ",<br><br> Nuestro sistema ha detectato que olvidaste tu contraseña por lo que se ha generado una nueva.+" +
                    "<br>Contraseña nueva: "+colaborador.password+ "<br> Contraseña personal. Por favor, no comparta con nadie su contraseña";
                mail.IsBodyHtml = true;
				using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
				{
					smtp.Credentials = new NetworkCredential(emailFromAddress, password);
					smtp.EnableSsl = enableSSL;
					smtp.Send(mail);
					frmMensaje mensaje = new frmMensaje("Se ha enviado un correo a " + colaborador.email, "", "Confirmar");
				}
			}
		}

        public void CambiarPass(Service.colaborador colaborador)
        {

            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(emailFromAddress);
                mail.To.Add(colaborador.email);
                mail.Subject = "Cambio de Contraseña de " + colaborador.nombre;
                mail.Body = "Usuario: " + colaborador.user + "<br>Contraseña: " + colaborador.password +
                    "<br> Contraseña personal. Por favor, no comparta con nadie su contraseña";
                mail.IsBodyHtml = true;
                using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                {
                    smtp.Credentials = new NetworkCredential(emailFromAddress, password);
                    smtp.EnableSsl = enableSSL;
                    smtp.Send(mail);
                    frmMensaje mensaje = new frmMensaje("Se ha enviado el correo a " + colaborador.email, "", "");
                }
            }


        }
    }
}

