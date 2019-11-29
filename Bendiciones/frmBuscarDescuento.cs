using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bendiciones.Service;

namespace Bendiciones
{
    public partial class frmBuscarDescuento : Form
    {
        private Service.descuento descuentoSeleccionado = new Service.descuento();

		public descuento DescuentoSeleccionado { get => descuentoSeleccionado; set => descuentoSeleccionado = value; }

		public frmBuscarDescuento(Boolean eliminar)
        {
            InitializeComponent();
            dgvDescuentos.AutoGenerateColumns = false;
            dgvDescuentos.DataSource = Program.dbController.listarDescuentos();
            Formateador f = new Formateador();
            f.iniFormFreddyBuscar(this, "Buscar Descuento", "Nombre:", txtNombre, dgvDescuentos, btnBuscar, btnSeleccionar,btnEliminar, false, eliminar);
        }

        

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            descuentoSeleccionado= (Service.descuento)dgvDescuentos.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void dgvSedes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Service.descuento descuentoFila = (Service.descuento)dgvDescuentos.Rows[e.RowIndex].DataBoundItem;
            dgvDescuentos.Rows[e.RowIndex].Cells["Porcentaje"].Value = descuentoFila.porcentaje;
            dgvDescuentos.Rows[e.RowIndex].Cells["Descripcion"].Value = descuentoFila.descripcion;
            dgvDescuentos.Rows[e.RowIndex].Cells["Nombre"].Value = descuentoFila.nombre;
            dgvDescuentos.Rows[e.RowIndex].Cells["Tipo"].Value = (char)descuentoFila.tipo;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
			
        }

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			descuentoSeleccionado = (Service.descuento)dgvDescuentos.CurrentRow.DataBoundItem;
			Program.dbController.eliminarDescuento(descuentoSeleccionado.idDescuento);
			frmMensaje mensaje = new frmMensaje("Se ha eliminado correctamente","Mensaje Confirmacion","Confirmar");   if(mensaje.ShowDialog() == DialogResult.OK){};
			this.Close();
		}
	}
}
