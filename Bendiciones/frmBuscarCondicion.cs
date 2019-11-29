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
    public partial class frmBuscarCondicion : Form
    {
		private Service.condicionMedica conSeleccionada = new Service.condicionMedica();
        public frmBuscarCondicion(Boolean eliminar)
        {
            InitializeComponent();
            dgvCondiciones.AutoGenerateColumns = false;
            dgvCondiciones.DataSource = Program.dbController.listarCondMedicasPorNombre("");
            Formateador f = new Formateador();
            f.iniFormFreddyBuscar(this, "Buscar Condicion", "Nombre:", txtNombre, dgvCondiciones, 
									btnBuscar, btnSeleccionar,btnEliminar, false, eliminar);
        }

        public condicionMedica ConSeleccionada { get => conSeleccionada; set => conSeleccionada = value; }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            ConSeleccionada = (Service.condicionMedica)dgvCondiciones.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }
        private void dgvCondiciones_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Service.condicionMedica conFila = (Service.condicionMedica)dgvCondiciones.Rows[e.RowIndex].DataBoundItem;
            dgvCondiciones.Rows[e.RowIndex].Cells["ID"].Value = conFila.id_cond;
            dgvCondiciones.Rows[e.RowIndex].Cells["Nombre"].Value = conFila.nombre;
        }

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			Service.condicionMedica conSeleccionada = (Service.condicionMedica)dgvCondiciones.CurrentRow.DataBoundItem;
			Program.dbController.eliminarCondicionMedica(conSeleccionada.id_cond);
			frmMensaje mensaje = new frmMensaje("Eliminado correctamente.", "Mensaje Confirmacion","Confirmar");   if(mensaje.ShowDialog() == DialogResult.OK){};
			this.Close();
		}
	}
}
