﻿using System;
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
    public partial class frmBuscarColaborador : Form
    {
        private Service.colaborador colabSeleccionado = new Service.colaborador();

        public colaborador ColabSeleccionado { get => colabSeleccionado; set => colabSeleccionado = value; }

        public frmBuscarColaborador(Boolean eliminar)
        {
            InitializeComponent();
            dgvColaborador.AutoGenerateColumns = false;
            dgvColaborador.DataSource = Program.dbController.listarColaboradoresPorNombreDni("");

            Formateador f = new Formateador();
            f.iniFormFreddyBuscar(this, "Buscar Colaborador", "Nombre o DNI:", txtNombre, dgvColaborador, btnBuscar, btnSeleccionar,btnEliminar, false, eliminar);
        }

        private void dgvColaborador_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Service.colaborador colabFila = (Service.colaborador)dgvColaborador.Rows[e.RowIndex].DataBoundItem;
            dgvColaborador.Rows[e.RowIndex].Cells["Nombre"].Value = colabFila.nombre;
            dgvColaborador.Rows[e.RowIndex].Cells["DNI"].Value = colabFila.dni;
            dgvColaborador.Rows[e.RowIndex].Cells["Tipo"].Value = colabFila.tipo.nombre;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            ColabSeleccionado = (Service.colaborador)dgvColaborador.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			colabSeleccionado = (Service.colaborador)dgvColaborador.CurrentRow.DataBoundItem;
			frmMensaje mensaje = new frmMensaje("Seguro que desea eliminar el Colaborador: " + colabSeleccionado.nombre, "", "");
			if(mensaje.ShowDialog()== DialogResult.OK)
			{
				Program.dbController.eliminarColaborador(colabSeleccionado.idPersona);
				frmMensaje msj = new frmMensaje("Se ha eliminado correctamente", "Mensaje Confirmacion", "Confirmar");
				if (msj.ShowDialog() == DialogResult.OK) {
					this.Close();
				}
			}
			
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			dgvColaborador.DataSource = Program.dbController.listarColaboradoresPorNombreDni(txtNombre.Text);
		}

		private void txtNombre_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				btnBuscar_Click(sender, e);
		}
	}
}
