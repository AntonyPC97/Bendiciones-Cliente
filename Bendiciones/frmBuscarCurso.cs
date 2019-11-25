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
    public partial class frmBuscarCurso : Form
    {
        private Service.curso cursoSeleccionado = new Service.curso();
        public frmBuscarCurso()
        {
            InitializeComponent();
            Formateador f = new Formateador();
            f.iniFormFreddyBuscar(this, "Buscar Curso", "Nombre:", txtNombre, dgvCursos, btnBuscar, btnSeleccionar,btnEliminar, false);
            dgvCursos.AutoGenerateColumns = false;
            dgvCursos.DataSource = Program.dbController.listarCursosPorNombre("");
        }

        public curso CursoSeleccionado { get => cursoSeleccionado; set => cursoSeleccionado = value; }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvCursos.RowCount == 0)
            {
                MessageBox.Show("No hay curso para seleccionar", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cursoSeleccionado = (Service.curso)dgvCursos.CurrentRow.DataBoundItem;
                this.DialogResult = DialogResult.OK;
            }
            
        }

        private void dgvCursos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Service.curso data = dgvCursos.Rows[e.RowIndex].DataBoundItem as Service.curso;
            dgvCursos.Rows[e.RowIndex].Cells[0].Value = data.nombre;
            dgvCursos.Rows[e.RowIndex].Cells[1].Value = data.descripcion;
            dgvCursos.Rows[e.RowIndex].Cells[2].Value = data.numClases;
            dgvCursos.Rows[e.RowIndex].Cells[3].Value = data.precio;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvCursos.DataSource = Program.dbController.listarCursosPorNombre(txtNombre.Text);
        }

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			cursoSeleccionado = (Service.curso)dgvCursos.CurrentRow.DataBoundItem;
			Program.dbController.eliminarCurso(cursoSeleccionado.id_servicio);
			MessageBox.Show("Curso Eliminado exitosamente", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
			this.Close();
		}
	}
}
