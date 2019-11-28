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
    public partial class frmGestionarCondicion : Form
    {
        Estado estadoObjCon;
        private Service.condicionMedica condicion = new Service.condicionMedica();
        public frmGestionarCondicion()
        {
            InitializeComponent();
            Formateador f = new Formateador();
            f.iniFormFreddyGestionar(this, "Condiciones Médicas", pnlCtn,btnNuevo,btnBuscar,btnGuardar, btnModificar, btnCancelar, false);
			limpiarComponentes();
			estadoComponentes(Estado.Inicial);
		}

		public void estadoComponentes(Estado estado)
		{
			switch (estado)
			{
				case Estado.Inicial:
					txtNombreCondicion.Enabled = false;
					txtDescripcion.Enabled = false;

					btnNuevo.Enabled = true;
					btnGuardar.Enabled = false;
					btnCancelar.Enabled = false;
					btnBuscar.Enabled = true;
					btnModificar.Enabled = false;
					break;
				case Estado.Nuevo:
					txtNombreCondicion.Enabled = true;
					txtDescripcion.Enabled = true;

					btnNuevo.Enabled = false;
					btnGuardar.Enabled = true;
					btnCancelar.Enabled = true;
					btnBuscar.Enabled = false;
					btnModificar.Enabled = false;
					break;

				case Estado.Buscar:
					txtNombreCondicion.Enabled = false;
					txtDescripcion.Enabled = false;

					btnNuevo.Enabled = false;
					btnGuardar.Enabled = false;
					btnCancelar.Enabled = true;
					btnBuscar.Enabled = true;
					btnModificar.Enabled = true;
					break;
				case Estado.Modificar:
					txtNombreCondicion.Enabled = true;
					txtDescripcion.Enabled = true;

					btnNuevo.Enabled = false;
					btnGuardar.Enabled = true;
					btnCancelar.Enabled = true;
					btnBuscar.Enabled = false;
					btnModificar.Enabled = false;
					break;
			}
		}
		
		public bool verificarCampos()
		{
			if(txtDescripcion.Text.Equals("") || txtNombreCondicion.Text.Equals(""))
			{
				frmMensaje mensaje = new frmMensaje("Complete los campos obligatorios", "Error de CAMPOS", "");
				if(mensaje.ShowDialog() == DialogResult.OK) return false;
			}
			return true;
		}
		public void limpiarComponentes()
		{
			txtDescripcion.Text = "";
			txtNombreCondicion.Text = "";
		}
		private void btnGuardar_Click(object sender, EventArgs e)
        {
			if (verificarCampos())
			{
				condicion.nombre = txtNombreCondicion.Text;
				condicion.descripcion = txtDescripcion.Text;

				if (estadoObjCon == Estado.Nuevo)
				{
					Program.dbController.insertarCondicionMedica(condicion);
					frmMensaje mensaje = new frmMensaje("Condicion Medica Registrada exitosamente", "Mensaje Confirmacion", "Confirmar");
				}
				else if (estadoObjCon == Estado.Modificar)
				{
					Program.dbController.actualizarCondicionMedica(condicion);
					frmMensaje mensaje = new frmMensaje("Se han actualizado los datos", "Mensaje Confirmacion", "Confirmar");
				}
				limpiarComponentes();
				estadoComponentes(Estado.Inicial);
			}
            
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarCondicion formCondicion = new frmBuscarCondicion(true);
            if(formCondicion.ShowDialog() == DialogResult.OK)
            {
                condicion = formCondicion.ConSeleccionada;
                txtNombreCondicion.Text = condicion.nombre;
                txtDescripcion.Text = condicion.descripcion;
				estadoComponentes(Estado.Buscar);
			}
			else
			{
				limpiarComponentes();
				estadoComponentes(Estado.Inicial);
			}
			
        }

		private void btnModificar_Click(object sender, EventArgs e)
		{
			estadoObjCon = Estado.Modificar;
			estadoComponentes(Estado.Modificar);
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			limpiarComponentes();
			estadoComponentes(Estado.Inicial);
			
		}

		private void btnNuevo_Click(object sender, EventArgs e)
		{
			estadoObjCon = Estado.Nuevo;
			estadoComponentes(Estado.Nuevo);
		}
	}
}
