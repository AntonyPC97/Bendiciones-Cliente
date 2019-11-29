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
    public partial class frmGestionarSede : Form
    {
        private Service.sede sede = new Service.sede();
        Estado estadoObjSede;
        public frmGestionarSede()
        {
            InitializeComponent();
            Formateador f = new Formateador();
            f.iniFormFreddyGestionar(this, "Gestionar Sede", pnlCtn,btnNuevo,btnBuscar, btnGuardar, btnModificar, btnCancelar, false);
			limpiarComponentes();
			estadoComponentes(Estado.Inicial);
        }

		public void limpiarComponentes()
		{
			txtDireccion.Text = "";
			txtDistrito.Text = "";
			txtTelefono.Text = "";
		}
		public bool verificarCampos() 
		{
			int i;
			if(txtTelefono.Text.Equals("") || txtDireccion.Text.Equals("") || txtDistrito.Text.Equals(""))
			{
				frmMensaje mensaje = new frmMensaje("Todos los campos son obligatorios", "", "");
				if(mensaje.ShowDialog() == DialogResult.OK) return false;
			}
			if (!int.TryParse(txtTelefono.Text, out i))
			{
				frmMensaje mensaje = new frmMensaje("Telefono debe ser numerico", "", "");
				if(mensaje.ShowDialog() == DialogResult.OK) return false;
			}
			if (txtTelefono.Text.Length < 7)
			{
				frmMensaje mensaje = new frmMensaje("Tamaño minimo de 7 numeros en el campo Telefono", "", "");
				if(mensaje.ShowDialog() == DialogResult.OK) return false;
			}
			return true;
		}
        public void estadoComponentes(Estado estado)
        {
            switch (estado)
            {
				case Estado.Inicial:
					txtDireccion.Enabled = false;
					txtDistrito.Enabled = false;
					txtTelefono.Enabled = false;

					btnNuevo.Enabled = true;
					btnGuardar.Enabled = false;
					btnCancelar.Enabled = false;
					btnBuscar.Enabled = true;
					btnModificar.Enabled = false;
					break;
                case Estado.Nuevo:
                    txtDireccion.Enabled = true;
                    txtDistrito.Enabled = true;
                    txtTelefono.Enabled = true;

					btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnModificar.Enabled = false;
                    break;
                case Estado.Buscar:
                    txtDireccion.Enabled = false;
                    txtDistrito.Enabled = false;
                    txtTelefono.Enabled = false;

					btnNuevo.Enabled = false;
                    btnModificar.Enabled = true;
                    btnBuscar.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = true;
                    break;
                case Estado.Modificar:
                    txtDireccion.Enabled = true;
                    txtDistrito.Enabled = true;
                    txtTelefono.Enabled = true;

					btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnModificar.Enabled = false;
                    break;
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            estadoObjSede = Estado.Modificar;
            estadoComponentes(Estado.Modificar);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
			if (verificarCampos())
			{
				sede.distrito = txtDistrito.Text;
				sede.direccion = txtDireccion.Text;
				sede.telefono = txtTelefono.Text;

				if (estadoObjSede == Estado.Nuevo)
				{
					Program.dbController.insertarSede(sede);
					frmMensaje mensaje = new frmMensaje("Sede Registrada exitosamente", "Mensaje Confirmacion", "Confirmar");   if(mensaje.ShowDialog() == DialogResult.OK){};
					txtDistrito.Text = "";
					txtDireccion.Text = "";
					txtTelefono.Text = "";
				}
				else if (estadoObjSede == Estado.Modificar)
				{
					Program.dbController.actualizarSede(sede);
					frmMensaje mensaje = new frmMensaje("Se han actualizado los datos", "Mensaje Confirmacion", "Confirmar");   if(mensaje.ShowDialog() == DialogResult.OK){};
				}
				limpiarComponentes();
				estadoComponentes(Estado.Inicial);
			}
        }

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			frmBuscarSede formSede = new frmBuscarSede(true);
			if (formSede.ShowDialog() == DialogResult.OK)
			{
				sede = formSede.SedeSeleccionada;
				txtDireccion.Text = sede.direccion;
				txtDistrito.Text = sede.distrito;
				txtTelefono.Text = sede.telefono;
				estadoComponentes(Estado.Buscar);
			}
			else
			{
				limpiarComponentes();
				estadoComponentes(Estado.Inicial);
			}
			
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			limpiarComponentes();
			estadoComponentes(Estado.Inicial);
		}

		private void btnNuevo_Click(object sender, EventArgs e)
		{
			estadoObjSede = Estado.Nuevo;
			estadoComponentes(Estado.Nuevo);
		}
	}
}