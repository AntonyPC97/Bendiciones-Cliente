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
    public partial class frmGestionarDescuento : Form
    {
        private Service.descuento descuento = new Service.descuento();
        Estado estadoObjDescuento;

        public frmGestionarDescuento()
        {
            InitializeComponent();
            Formateador f = new Formateador();
            f.iniFormFreddyGestionar(this, "Gestionar Descuento", pnlCtn,btnNuevo, btnBuscar, btnGuardar, btnModificar, btnCancelar, false);
			limpiarCompentes();
			estadoComponentes(Estado.Inicial);
        }

		public void limpiarCompentes()
		{
			txtDescripcion.Text = "";
			txtNombre.Text = "";
			txtPorcentaje.Text = "";
			cboTipo.SelectedIndex = -1;
		}
        public void estadoComponentes(Estado estado)
        {
			switch (estado)
			{
				case Estado.Inicial:
					txtPorcentaje.Enabled = false;
					txtDescripcion.Enabled = false;
					txtNombre.Enabled = false;
					cboTipo.Enabled = false;

					btnNuevo.Enabled = true;
					btnGuardar.Enabled = false;
					btnCancelar.Enabled = false;
					btnBuscar.Enabled = true;
					btnModificar.Enabled = false;
					break;
				case Estado.Nuevo:
					txtPorcentaje.Enabled = true;
					txtDescripcion.Enabled = true;
					txtNombre.Enabled = true;
					cboTipo.Enabled = true;

					btnNuevo.Enabled = false;
					btnGuardar.Enabled = true;
					btnCancelar.Enabled = true;
					btnBuscar.Enabled = false;
					btnModificar.Enabled = false;
					break;
				case Estado.Buscar:
					txtPorcentaje.Enabled = false;
					txtDescripcion.Enabled = false;
					txtNombre.Enabled = false;
					cboTipo.Enabled = false;

					btnNuevo.Enabled = false;
					btnModificar.Enabled = true;
					btnBuscar.Enabled = true;
					btnGuardar.Enabled = false;
					btnCancelar.Enabled = false;
					break;
				case Estado.Modificar:
					txtPorcentaje.Enabled = true;
					txtDescripcion.Enabled = true;
					txtNombre.Enabled = true;
					cboTipo.Enabled = true;

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
			float i;
			if (txtPorcentaje.Text.Equals("") || txtNombre.Text.Equals("") || txtDescripcion.Text.Equals("")) 
			{
				frmMensaje mensaje = new frmMensaje("Todos los campos son obligatorios", "Error de Campos","Confirmar");
				if(mensaje.ShowDialog() == DialogResult.OK) return false;
			}

			if (!float.TryParse(txtPorcentaje.Text,out i))
			{	
				frmMensaje mensaje = new frmMensaje("Ingrese un procentaje valido(Ej. 25, 30.5)", "Porcentaje Invalido", "");
				if(mensaje.ShowDialog() == DialogResult.OK) return false;
			}
			if (float.Parse(txtPorcentaje.Text) < 0 || float.Parse(txtPorcentaje.Text) > 100)
			{
				frmMensaje mensaje = new frmMensaje("El porcentaje debe estar entre 0 y 100", "Porcentaje Invalido", "");
				if(mensaje.ShowDialog() == DialogResult.OK) return false;
			}
			if (cboTipo.SelectedIndex == -1)
			{
				frmMensaje mensaje = new frmMensaje("Escoja un Tipo de Seguro", "Error de Tipo", "");
				if(mensaje.ShowDialog() == DialogResult.OK) return false;
			}
			return true;
		}
        private void btnGuardar_Click(object sender, EventArgs e)
        {
			if (verificarCampos())
			{
				descuento.porcentaje = float.Parse(txtPorcentaje.Text);
				descuento.descripcion = txtDescripcion.Text;
				descuento.nombre = txtNombre.Text;
				if (cboTipo.SelectedIndex == 0)
				{
					descuento.tipo = 'C';
				}
				else if (cboTipo.SelectedIndex == 1)
				{
					descuento.tipo = 'S';
				}
				else
				{
					frmMensaje mensaje = new frmMensaje("Selecciona tipo de descuento válido", "", ""); if (mensaje.ShowDialog() == DialogResult.OK) { }
                }

				if (estadoObjDescuento == Estado.Nuevo)
				{
					Program.dbController.insertarDescuento(descuento);
					frmMensaje mensaje = new frmMensaje("Descuento Registrado exitosamente.", "Mensaje Confirmacion", "Confirmar");   if(mensaje.ShowDialog() == DialogResult.OK){};
				}
				else if (estadoObjDescuento == Estado.Modificar)
				{
					Program.dbController.actualizarDescuento(descuento);
					frmMensaje mensaje = new frmMensaje("Se han actualizado los datos", "Mensaje Confirmacion", "Confirmar");   if(mensaje.ShowDialog() == DialogResult.OK){};
				}
				limpiarCompentes();
				estadoComponentes(Estado.Inicial);
			}
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarDescuento formDescuento = new frmBuscarDescuento(true);
            if (formDescuento.ShowDialog() == DialogResult.OK)
            {
                descuento = formDescuento.DescuentoSeleccionado;
                txtPorcentaje.Text = descuento.porcentaje.ToString();
                txtDescripcion.Text = descuento.descripcion;
                txtNombre.Text = descuento.nombre;
				if (descuento.tipo.Equals('C'))
					cboTipo.SelectedIndex = 0;
				else
					cboTipo.SelectedIndex = 1;
                estadoComponentes(Estado.Buscar);
            }
			else
			{
				limpiarCompentes();
				estadoComponentes(Estado.Inicial);
			}
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
			limpiarCompentes();
            estadoComponentes(Estado.Inicial);
        }
		private void btnNuevo_Click(object sender, EventArgs e)
		{
			estadoObjDescuento = Estado.Nuevo;
			estadoComponentes(Estado.Nuevo);
		}
		private void btnModificar_Click(object sender, EventArgs e)
		{
			estadoObjDescuento = Estado.Modificar;
			estadoComponentes(Estado.Modificar);

		}
    }
}
