using System;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using System.Linq;

namespace Bendiciones
{
    public partial class FormLogin : Form
    {
		private string correo;
		private string pass;
        private Service.colaborador colaborador;
        public FormLogin()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("es-MX");
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

            Paleta paleta = new Paleta();
            picName.BackColor = paleta.Naranja;
            this.BackColor = paleta.NaranjaOscuro;
            btnIngresar.BackColor = paleta.Naranja;

            txtUser.Left = (txtUser.Parent.Width - txtUser.Width) / 2;
            txtPassword.Left = (txtPassword.Parent.Width - txtPassword.Width) / 2;
            btnIngresar.Left = (btnIngresar.Parent.Width - btnIngresar.Width) / 2;

            btnIngresar.ForeColor = paleta.Marron;
            lblUsuario.ForeColor = paleta.Marron;
            lblPassword.ForeColor = paleta.Marron;
            pnlLine1.BackColor = paleta.Marron;
            pnlLine2.BackColor = paleta.Marron;
			btnOlvide.Visible = false;

        }
        public int transformar(double minutos)
        {
            int segundos = (int)(60 - minutos);
            return segundos;
        }
        public Service.colaborador verificarCampos()
        {
            double minutos = 0;
            colaborador = Program.dbController.verificarUsuario(txtUser.Text);

            if (colaborador.idPersona == 0)
            {
                frmMensaje mensaje = new frmMensaje("Usuario o Contraseña inválido", "", "");
                return null;
            }

            if (colaborador.intentos == 3)
            {
                int  horaCur = DateTime.Now.Hour;
                int minCur = DateTime.Now.Minute;
                int segCur = DateTime.Now.Second;
                DateTime current = new DateTime(1970,1,1,horaCur,minCur,segCur);
                DateTime horaBloqueo = colaborador.horaBloqueo;
                minutos = (current.TimeOfDay - horaBloqueo.TimeOfDay).TotalMinutes;
                if (minutos < 1)
                {
                    frmMensaje mensaje = new frmMensaje("Excedio el numero de intentos, vuelva a intentar en " + transformar(minutos) + " segundos","","");
                    return null;
                }
                else {
                    colaborador.intentos = 0;
                    Program.dbController.actualizarColaborador(colaborador);
                }
            }
			
            if (txtPassword.Text.Equals(colaborador.password))
                return colaborador;
            else
            {
                if (colaborador.intentos < 3)
                {
                    colaborador.intentos += 1;
                    Program.dbController.actualizarColaborador(colaborador);
                    frmMensaje mensaje = new frmMensaje("Contraseña incorrecta \nIntentos restantes: " + (3 - colaborador.intentos), "", "");
					btnOlvide.Visible = true;
					correo = colaborador.email;
					pass = colaborador.password;
                    if (colaborador.intentos == 3)
                    {
                        int hora = DateTime.Now.Hour;
                        int minuto = DateTime.Now.Minute;
                        int seg = DateTime.Now.Second;
                        DateTime bloqueo = new DateTime(1970,1,1,hora,minuto,seg);
                        colaborador.horaBloqueoSpecified = true;
                        colaborador.horaBloqueo = bloqueo;
                        Program.dbController.actualizarColaborador(colaborador);
                    }
                }
            }
           
            return null;  
		}
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(txtUser.Text.Equals("") || txtPassword.Text.Equals(""))
            {
                frmMensaje mensaje = new frmMensaje("Ingresar usuario y/o contraseñña", "", "");
            }
            else
            {
                Service.colaborador colaborador = verificarCampos();
                if (colaborador != null)
                {
                    colaborador.intentos = 0;
                    Program.dbController.actualizarColaborador(colaborador);
                    if (colaborador.tipo.nombre.Equals("Administracion"))
                    {
                        frmPrincipal Principal = new frmPrincipal(txtUser.Text);
                        Principal.Show();
                        this.Hide();
                    }
                    else if(colaborador.tipo.nombre.Equals("Secretaria"))
                    {
                        frmPrincipalSec Principal = new frmPrincipalSec(txtUser.Text);
                        Principal.Show();
                        this.Hide();
                    }

                }
            }
            
        }

        public string randomPassword()
        {
            string password = "";
            //3 mayuscula, 3 minuscula, 3 numeros, 1 signo de puntuacion
            Random random = new Random();
            for (int i = 0; i < 3; i++)
            {
                int mayus = random.Next(65, 91);
                char car = (char)mayus;
                password += car;
            }
            for (int i = 0; i < 3; i++)
            {
                int min = random.Next(97, 123);
                char car = (char)min;
                password += car;
            }
            password += '.';
            for (int i = 0; i < 3; i++)
            {
                int num = random.Next(10);
                password += num;
            }

            string shuffle = new string(password.ToCharArray().OrderBy(s => (random.Next(2) % 2) == 0).ToArray());
            return shuffle;
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
		{
            if (e.KeyCode == Keys.Enter)
                btnIngresar_Click(sender, e);
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnIngresar_Click(sender, e);
        }

		private void btnOlvide_Click(object sender, EventArgs e)
		{
			Correo c = new Correo();
            colaborador.password = randomPassword();
            Program.dbController.actualizarColaborador(colaborador);
			c.RecuperarPassword(colaborador);
		}
	}
}