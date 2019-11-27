using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bendiciones
{
    public partial class frmGestionarColaboradores : Form
    {
        private Service.colaborador colaborador = new Service.colaborador();
        private int estadoPassword = 0;
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
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        public bool verificarCampos()
		{
            int i;
			if (txtNombre.Text.Equals("") || txtDNI.Text.Equals("") || txtCorreo.Text.Equals("") ||
				txtTelefono.Text.Equals("") || txtPassword.Text.Equals("") ||
				(rbFemenino.Checked==false && rbMasculino.Checked == false) || 
				cboTipo.SelectedIndex ==-1 || txtProfesion.Text.Equals(""))
            {
				frmMensaje mensaje = new frmMensaje("Todos los campos son obligatorios.","","");
				return false;
			}
            if (!Program.dbController.verificarDNI(txtDNI.Text))
            {
                frmMensaje mensaje = new frmMensaje("El Dni ya existe en la base de datos", "Error de DNI", "");
                return false;
            }

            if (!IsValidEmail(txtCorreo.Text))
            {
                frmMensaje mensaje = new frmMensaje("Ingrese un correo electronico valido", "", "");
                return false;
            }
            if (!int.TryParse(txtDNI.Text,out i) || !int.TryParse(txtTelefono.Text, out i) || !int.TryParse(txtNumColeg.Text, out i)) 
            {
                frmMensaje mensaje = new frmMensaje("Dni, Telefono y Numero de Colegiatura deben ser numericos", "", "");
                return false;
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
                colaborador.password = txtPassword.Text;
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
                    Program.dbController.insertarColaborador(colaborador);
					frmMensaje mensaje = new frmMensaje("Colaborador registrado correctamente.", "Mensaje Confirmacion", "Confirmar");
                    correo.CorreoNuevoColaborador(colaborador);
                }
                else if (estadoObjColab == Estado.Modificar)
                {
                    Program.dbController.actualizarColaborador(colaborador);
                    frmMensaje mensaje = new frmMensaje("Se han actualizado los datos.", "Mensaje Confirmacion", "Confirmar");
                    correo.CorreoNuevoColaborador(colaborador);
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

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (estadoPassword == 0)
            {
                estadoPassword = 1;
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                estadoPassword = 0;
                txtPassword.PasswordChar = '*';
            }

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
    }
}
