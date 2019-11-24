﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;

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

		public void CorreoNuevoServicio(Service.colaborador cliente,Service.curso curso)
		{

			using (MailMessage mail = new MailMessage())
			{
				mail.From = new MailAddress(emailFromAddress);
				mail.To.Add(cliente.email);
				mail.Subject = "Bienvenida/o a Escuela para embarazadas " + cliente.nombre;
				mail.Body = "El dia de hoy se matriculo en el curso "+curso.nombre;
				mail.IsBodyHtml = true;
				using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
				{
					smtp.Credentials = new NetworkCredential(emailFromAddress, password);
					smtp.EnableSsl = enableSSL;
					smtp.Send(mail);
					frmMensaje mensaje = new frmMensaje("Se ha enviado el correo a " + cliente.email, "", "");
				}
			}


		}
	}
}

