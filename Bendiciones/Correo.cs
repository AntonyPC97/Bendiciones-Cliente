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
					frmMensaje mensaje = new frmMensaje("Se ha enviado el correo a " + colaborador.email, "", ""); if (mensaje.ShowDialog() == DialogResult.OK) { }
                }
			}
               
            
        }
		
		public void CorreoNuevoServicio(Service.cliente cliente,BindingList<Service.matricula> matriculas)
		{
            double monto =0;
			using (MailMessage mail = new MailMessage())
			{
				mail.From = new MailAddress(emailFromAddress);
				mail.To.Add(cliente.email);
				mail.Subject = "Bienvenida/o a Escuela para embarazadas " + cliente.nombre;
				mail.Body = "La relacion de sus matricuals es<br><br>";
				foreach(Service.matricula mat in matriculas)
				{
                    if (mat.cuotas!=null) monto = mat.cuotas[0].monto;

					mail.Body += "Curso: "+mat.servicio.nombre +"<br>Monto inicial Abonado: "+monto + "<br>Saldo: "+mat.saldo+"<br><br>";
				}
				mail.IsBodyHtml = true;
				using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
				{
					smtp.Credentials = new NetworkCredential(emailFromAddress, password);
					smtp.EnableSsl = enableSSL;
					smtp.Send(mail);
					frmMensaje mensaje = new frmMensaje("Se ha enviado correo con los detalles a " + cliente.email, "", ""); if (mensaje.ShowDialog() == DialogResult.OK) { }
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
					frmMensaje mensaje = new frmMensaje("Se ha enviado un correo a " + colaborador.email, "", "Confirmar");   if(mensaje.ShowDialog() == DialogResult.OK){};
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
                    frmMensaje mensaje = new frmMensaje("Se ha enviado el correo a " + colaborador.email, "", ""); if (mensaje.ShowDialog() == DialogResult.OK) { }
                }
            }
        }

        public void RegistroCuota(Service.matricula matricula,string abonar)
        {

            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(emailFromAddress);
                mail.To.Add(matricula.cliente.email);
                mail.Subject = "Se ha registrado un nuevo pago" ;
                mail.Body = "Estimada/o cliente, <br><br>Se ha registrado un nuevo pago en su curso "+ matricula.servicio.nombre;
                mail.Body += "<br>Monto Registrado: "+abonar + "<br>Nuevo Saldo Adeudado: "+matricula.saldo;
                mail.IsBodyHtml = true;
                using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                {
                    smtp.Credentials = new NetworkCredential(emailFromAddress, password);
                    smtp.EnableSsl = enableSSL;
                    smtp.Send(mail);
                }
            }
        }
    }
}

