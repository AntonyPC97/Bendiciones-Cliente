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
    public partial class frmBuscarDocente : Form
    {
        Service.colaborador docenteSeleccionado;

        public colaborador DocenteSeleccionado { get => docenteSeleccionado; set => docenteSeleccionado = value; }

        public frmBuscarDocente()
        {
            InitializeComponent();
            Formateador f = new Formateador();
            f.iniFormFreddyBuscar(this, "Buscar Docente", "Nombre o DNI:", txtNombre, dgvProfesores, btnBuscar, btnSeleccionar, btnEliminar, false);
            dgvProfesores.AutoGenerateColumns = false;
            dgvProfesores.DataSource = Program.dbController.listarDocentesPorNombreDni("");
            btnEliminar.Visible = false;
            //solo porque no debería mostrarse el botón eliminar
            btnSeleccionar.Left = dgvProfesores.Left + dgvProfesores.Width - btnEliminar.Width;
            btnBuscar.Left = btnSeleccionar.Left - btnSeleccionar.Width - 10;
           
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNombre.Text)) {
                //frmMensaje msg = new frmMensaje();
                //msg.ventanaMensaje("Ingresar nombre de profesor");
            } else
            {
                dgvProfesores.DataSource = Program.dbController.listarDocentesPorNombreDni(txtNombre.Text);
            }

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvProfesores.RowCount == 0)
            {
                frmMensaje mensaje = new frmMensaje("No hay docente para seleccionar", "Mensaje de advertencia", "");
            }
            else
            {
                docenteSeleccionado = (Service.colaborador)dgvProfesores.CurrentRow.DataBoundItem;
                this.DialogResult = DialogResult.OK;
            }
            
        }

        private void dgvProfesores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvProfesores.RowCount != 0)
            {
                Service.colaborador data = dgvProfesores.Rows[e.RowIndex].DataBoundItem as Service.colaborador;
                dgvProfesores.Rows[e.RowIndex].Cells[0].Value = data.dni;
                dgvProfesores.Rows[e.RowIndex].Cells[1].Value = data.nombre;
                dgvProfesores.Rows[e.RowIndex].Cells[2].Value = data.profesion;
                dgvProfesores.Rows[e.RowIndex].Cells[3].Value = (char)data.sexo;

            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            docenteSeleccionado = (Service.colaborador)dgvProfesores.CurrentRow.DataBoundItem;
            Program.dbController.eliminarColaborador(docenteSeleccionado.idPersona);
        }
    }
}
