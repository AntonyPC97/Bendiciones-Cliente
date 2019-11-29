using System;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Bendiciones
{
    public partial class frmGestionarColaboradores : Form
    {
        private Service.colaborador colaborador = new Service.colaborador();
        private string cont;
        Estado estadoObjColab;
        public frmGestionarColaboradores()
        {
            InitializeComponent();
            BindingList<Service.tipoColaborador> tipos = new BindingList<Service.tipoColaborador>(Program.dbController.listarTipoColaborador());
            cboTipo.DataSource = tipos;
            cboTipo.DisplayMember = "Nombre";
			cboTipo.ValueMember = "idTipoColab";
            Formateador f = new Formateador();
            f.iniFormFreddyGestionar(this, "Gestionar Colaborador", pnlCtn,btnNuevo,btnBuscar, btnGuardar, btnModificar, btnCancelar, false);
			limpiarComponentes();
			estadoComponentes(Estado.Inicial);
		}

		public void estadoComponentes(Estado estado)
		{
			switch (estado)
			{
				case Estado.Inicial:
					txtNombre.Enabled=false;
					txtDNI.Enabled = false;
					txtTelefono.Enabled = false;
					txtCorreo.Enabled = false;
					txtNumColeg.Enabled = false;
					txtUsuario.Enabled = false;
					txtPassword.Enabled = false;
					rbFemenino.Enabled = false;
					rbMasculino.Enabled = false;
					cboTipo.Enabled = false;
					cboTipo.SelectedIndex = -1;
					txtReferencia.Enabled = false;
                    txtProfesion.Enabled = false;
                    dtpFechaNac.Enabled = false;
                    txtDireccion.Enabled = false;

                    btnNuevo.Enabled = true;
					btnGuardar.Enabled = false;
					btnCancelar.Enabled = false;
					btnBuscar.Enabled = true;
					btnModificar.Enabled = false;
					break;
				case Estado.Nuevo:
                    txtNombre.Focus();
					txtNombre.Enabled = true;
					txtDNI.Enabled = true;
					txtTelefono.Enabled = true;
					txtCorreo.Enabled = true;
					txtNumColeg.Enabled = true;
					txtUsuario.Enabled = true;
                    txtPassword.Enabled = false;
					rbFemenino.Enabled = true;
					rbMasculino.Enabled = true;
					cboTipo.Enabled = true;
                    txtReferencia.Enabled = true;
                    txtProfesion.Enabled = true;
                    dtpFechaNac.Enabled = true;
                    txtDireccion.Enabled = true;

                    btnNuevo.Enabled = false;
					btnGuardar.Enabled = true;
					btnCancelar.Enabled = true;
					btnBuscar.Enabled = false;
					btnModificar.Enabled = false;
					break;
				case Estado.Buscar:
					txtNombre.Enabled = false;
					txtDNI.Enabled = false;
					txtTelefono.Enabled = false;
					txtCorreo.Enabled = false;
					txtNumColeg.Enabled = false;
					txtUsuario.Enabled = false;
					txtPassword.Enabled = false;
					rbFemenino.Enabled = false;
					rbMasculino.Enabled = false;
					cboTipo.Enabled = false;
                    txtReferencia.Enabled = false;
                    txtProfesion.Enabled = false;
                    dtpFechaNac.Enabled = false;
                    txtDireccion.Enabled = false;

					btnNuevo.Enabled = false;
					btnModificar.Enabled = true;
					btnBuscar.Enabled = true;
					btnGuardar.Enabled = false;
					btnCancelar.Enabled = true;
					break;
				case Estado.Modificar:
					txtNombre.Enabled = true;
					txtDNI.Enabled = true;
					txtTelefono.Enabled = true;
					txtCorreo.Enabled = true;
					txtNumColeg.Enabled = true;
					txtUsuario.Enabled = true;
					txtPassword.Enabled = false;
					rbFemenino.Enabled = true;
					rbMasculino.Enabled = true;
					cboTipo.Enabled = true;
                    txtReferencia.Enabled = true;
                    txtProfesion.Enabled = true;
                    dtpFechaNac.Enabled = true;
                    txtDireccion.Enabled = true;

					btnNuevo.Enabled = false;
					btnGuardar.Enabled = true;
					btnCancelar.Enabled = true;
					btnBuscar.Enabled = false;
					btnModificar.Enabled = false;
					break;
			}
		}

        public string randomPassword()
        {
            string password = "";
            //3 mayuscula, 3 minuscula, 3 numeros, 1 signo de puntuacion
            Random random = new Random();
            for(int i = 0; i < 3; i++)
            {
                int mayus = random.Next(65,91);
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

		public void limpiarComponentes() {
			txtNombre.Text = "";
			txtDNI.Text = "";
			txtTelefono.Text = "";
			txtCorreo.Text = "";
			txtNumColeg.Text = "";
			txtUsuario.Text = "";
			txtPassword.Text = "";
            txtDireccion.Text = "";
            txtReferencia.Text = "";
            txtProfesion.Text = "";
			rbFemenino.Checked = false;
			rbMasculino.Checked = false;
			cboTipo.SelectedIndex = -1;
		}

        public bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    var domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        public bool verificarCampos()
		{
            int i;
			if (txtNombre.Text.Equals("") || txtDNI.Text.Equals("") || txtCorreo.Text.Equals("") ||
				txtTelefono.Text.Equals("") || (rbFemenino.Checked==false && rbMasculino.Checked == false) || 
				cboTipo.SelectedIndex ==-1 || txtDireccion.Text.Equals(""))
            {
				frmMensaje mensaje = new frmMensaje("Complete los campos obligatorios","Error de CAMPOS","");
				if(mensaje.ShowDialog() == DialogResult.OK) return false;
			}
            
			if(txtTelefono.Text.Length < 7 || txtTelefono.Text.Length == 8)
			{
				frmMensaje mensaje = new frmMensaje("Telefono de longitud incorrecta", "Error de TELEFONO", "");
				if(mensaje.ShowDialog() == DialogResult.OK) return false;
			}
			if (!Program.dbController.validarUsuarioUnico(txtUsuario.Text))
			{
				frmMensaje mensaje = new frmMensaje("El nombre de USUARIO no esta disponible.", "Error de USUARIO", "");
				if(mensaje.ShowDialog() == DialogResult.OK) return false;
			}
            if (!IsValidEmail(txtCorreo.Text))
            {
                frmMensaje mensaje = new frmMensaje("Ingrese un correo electronico valido", "", "");
                if(mensaje.ShowDialog() == DialogResult.OK) return false;
            }
            if (!int.TryParse(txtDNI.Text,out i) || !int.TryParse(txtTelefono.Text, out i)) 
            {
                frmMensaje mensaje = new frmMensaje("Dni y Telefono deben ser numericos", "", "");
                if(mensaje.ShowDialog() == DialogResult.OK) return false;
            }
            
            return true;
		}
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarColaborador formColaborador = new frmBuscarColaborador(true);
            if (formColaborador.ShowDialog() == DialogResult.OK)
            {
                colaborador = formColaborador.ColabSeleccionado;
                txtNombre.Text = colaborador.nombre;
                txtDNI.Text = colaborador.dni;
                txtCorreo.Text = colaborador.email;
                txtTelefono.Text = colaborador.telefono;
                txtUsuario.Text = colaborador.user;
                txtPassword.Text = colaborador.password;
                txtNumColeg.Text = colaborador.numColegiatura;
				txtProfesion.Text = colaborador.profesion;
                txtReferencia.Text = colaborador.referencia;
                txtDireccion.Text = colaborador.direccion;
                dtpFechaNac.Value = colaborador.fechaNaci;
                

                if (colaborador.sexo == 'M')
                    rbMasculino.Checked = true;
                else
                    rbFemenino.Checked = true;
				
				cboTipo.SelectedValue = colaborador.tipo.idTipoColab;
				estadoComponentes(Estado.Buscar);
			}
			else
			{
				limpiarComponentes();
				estadoComponentes(Estado.Inicial);
			}
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           Correo correo = new Correo();
			if (verificarCampos())
			{
                Service.tipoColaborador tipo = new Service.tipoColaborador();
                colaborador.nombre = txtNombre.Text;
                colaborador.dni = txtDNI.Text;
                colaborador.email = txtCorreo.Text;
                colaborador.telefono = txtTelefono.Text;
                colaborador.user = txtUsuario.Text;
				cont = txtPassword.Text;
                colaborador.password = Encriptar.HashTable(cont);
                colaborador.numColegiatura = txtNumColeg.Text;
                colaborador.profesion = txtProfesion.Text;
                colaborador.referencia = txtReferencia.Text;
                colaborador.fechaNaci = dtpFechaNac.Value;
                colaborador.fechaNaciSpecified = true;
                colaborador.direccion = txtDireccion.Text;


                if (rbFemenino.Checked == true)
                    colaborador.sexo = 'F';
                else
                    colaborador.sexo = 'M';

                tipo = (Service.tipoColaborador)cboTipo.SelectedItem;
                colaborador.tipo = tipo;

                if (estadoObjColab == Estado.Nuevo)
                {
					if (!Program.dbController.verificarDNI(txtDNI.Text))
					{
                        frmMensaje msj = new frmMensaje("El Dni ya existe en la base de datos", "Error de DNI", ""); if (msj.ShowDialog() == DialogResult.OK) { };
						return;
					}
					Program.dbController.insertarColaborador(colaborador);
					frmMensaje mensaje = new frmMensaje("Colaborador registrado correctamente.", "Mensaje Confirmacion", "Confirmar");   if(mensaje.ShowDialog() == DialogResult.OK){};
                    correo.CorreoNuevoColaborador(colaborador,cont);
                }
                else if (estadoObjColab == Estado.Modificar)
                {
                    Program.dbController.actualizarColaborador(colaborador);
                    frmMensaje mensaje = new frmMensaje("Se han actualizado los datos.", "Mensaje Confirmacion", "Confirmar");   if(mensaje.ShowDialog() == DialogResult.OK){};
                }

                limpiarComponentes();
				estadoComponentes(Estado.Inicial);
			}	
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            estadoObjColab = Estado.Modificar;
			estadoComponentes(Estado.Modificar);
        }

		private void btnNuevo_Click(object sender, EventArgs e)
		{
			estadoObjColab = Estado.Nuevo;
			estadoComponentes(Estado.Nuevo);
            txtPassword.Text = randomPassword();
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			limpiarComponentes();
			estadoComponentes(Estado.Inicial);
		}


        private void rbMasculino_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                rbMasculino.Checked = true;
        }

        private void rbFemenino_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                rbFemenino.Checked = true;
        }

		private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsDigit(e.KeyChar))
			{
				e.Handled = false;
			}
			else if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
			{
				e.Handled = false;
			}
			else
			{
				//el resto de teclas pulsadas se desactivan
				e.Handled = true;
			}
		}

		private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
		{
			txtDNI_KeyPress(sender,e);
		}

		private void txtNumColeg_KeyPress(object sender, KeyPressEventArgs e)
		{
			txtDNI_KeyPress(sender, e);
		}

		private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(cboTipo.SelectedIndex==2)
			{
				txtUsuario.Text = "";
				txtUsuario.Enabled = false;
			}
			else
			{
				txtUsuario.Enabled = true;
			}
		}
	}
}
