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
    public partial class frmBuscarCliente : Form
    {
        private Service.cliente clienteSeleccionado;
        private List<Service.cliente> clientes;
        
        public cliente ClienteSeleccionado { get => clienteSeleccionado; set => clienteSeleccionado = value; }

        public frmBuscarCliente(Boolean eliminar)
        {
            InitializeComponent();
            dgvClientes.AutoGenerateColumns = false;
            Formateador f = new Formateador();
            f.iniFormFreddyBuscar(this, "Buscar Cliente", "Nombre o DNI:", txtNombre, dgvClientes, btnBuscar, btnSeleccionar, btnEliminar, false, eliminar);

            //agregar gestantes y apoderados a la lista de clientes
            clientes = Program.dbController.listarApoderadosPorNombreDNI("").ToList<Service.cliente>();
            foreach (Service.gestante g in Program.dbController.listarGestantePorNombreDNI(""))
                clientes.Add((Service.cliente)g);

            //llenar data grid view
            foreach (Service.apoderado apoderado in Program.dbController.listarApoderadosPorNombreDNI(""))
            {
                Object[] fila = new Object[3];
                fila[0] = apoderado.dni;
                fila[1] = apoderado.nombre;
                fila[2] = "Apoderado";
                dgvClientes.Rows.Add(fila);
            }
            foreach (Service.gestante gestante in Program.dbController.listarGestantePorNombreDNI(""))
            {
                Object[] fila = new Object[3];
                fila[0] = gestante.dni;
                fila[1] = gestante.nombre;
                fila[2] = "Gestante";
                dgvClientes.Rows.Add(fila);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvClientes.RowCount = 0;
            clientes = new List<cliente>();
            IEnumerable < Service.cliente > apoderados = Program.dbController.listarApoderadosPorNombreDNI(txtNombre.Text);
            if (apoderados != null)
            {
                List<cliente> apo = apoderados.ToList();
                clientes.AddRange(apo);
            }

            IEnumerable<Service.cliente> gestantes = Program.dbController.listarGestantePorNombreDNI(txtNombre.Text);
            if (gestantes != null)
            {
                List<cliente> gest = gestantes.ToList();
                clientes.AddRange(gest);
            }
            foreach (Service.cliente cli in clientes)
            {
                Object[] fila = new Object[3];
                fila[0] = cli.dni;
                fila[1] = cli.nombre;
                if( cli is Service.gestante)
                {
                    fila[2] = "Gestante";
                }
                else
                {
                    fila[2] = "Apoderado";
                }
                dgvClientes.Rows.Add(fila);
            }
        }



        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.RowCount == 0)
            {
                frmMensaje mensaje = new frmMensaje("No hay clientes para seleccionar", "Mensaje de advertencia", ""); if (mensaje.ShowDialog() == DialogResult.OK) { }
            }
            else
            {
                clienteSeleccionado = clientes[dgvClientes.CurrentCell.RowIndex];
                this.DialogResult = DialogResult.OK;
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

		private void txtNombre_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				btnBuscar_Click(sender,e);
		}
	}
}
