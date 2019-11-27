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
    public partial class frmBuscarSede : Form
    {
        private Service.sede sedeSeleccionada = new Service.sede();
        public frmBuscarSede(Boolean eliminar)
        {
            InitializeComponent();
            dgvSedes.AutoGenerateColumns = false;
            dgvSedes.DataSource = Program.dbController.listarSedes();
            Formateador f = new Formateador();
            f.iniFormFreddyBuscar(this, "Buscar Sede", "Nombre:", txtNombre, dgvSedes, btnBuscar, btnSeleccionar,btnEliminar, false, eliminar);
        }






        public sede SedeSeleccionada { get => sedeSeleccionada; set => sedeSeleccionada = value; }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            sedeSeleccionada = (Service.sede)dgvSedes.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void dgvSedes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Service.sede sedeFila = (Service.sede)dgvSedes.Rows[e.RowIndex].DataBoundItem;
            dgvSedes.Rows[e.RowIndex].Cells["Direccion"].Value = sedeFila.direccion;
            dgvSedes.Rows[e.RowIndex].Cells["Distrito"].Value = sedeFila.distrito;
            dgvSedes.Rows[e.RowIndex].Cells["Telefono"].Value = sedeFila.telefono;
        }

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			sedeSeleccionada = (Service.sede)dgvSedes.CurrentRow.DataBoundItem;
			Program.dbController.eliminarSede(sedeSeleccionada.idSede);
			frmMensaje mensaje = new frmMensaje("Se ha eliminado correctamente", "Mensaje Confirmacion", "Confirmar");
			this.Close();
		}
	}
    
}
