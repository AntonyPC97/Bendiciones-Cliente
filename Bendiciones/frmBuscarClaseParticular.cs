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
    
    public partial class frmBuscarClaseParticular : Form
    {
        private Service.claseParticular claseSeleccionada;
        private Service.cliente cliente;
        private BindingList<Service.claseParticular> clases = new BindingList<claseParticular>();
        public frmBuscarClaseParticular()
        {
            InitializeComponent();
            dgvClasesParticulares.AutoGenerateColumns = false;
            Formateador f = new Formateador();
            Paleta p = new Paleta();

            this.BackColor = p.Blanco;
            f.formatearBotonListar(btnBuscarCliente);
            f.formatearBotonNaranja(btnSeleccionar);
            f.formatearBotonNaranja(btnEliminar);

        }

        public claseParticular ClaseSeleccionada { get => claseSeleccionada; set => claseSeleccionada = value; }
        public cliente Cliente { get => cliente; set => cliente = value; }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if(cliente == null)
            {
                frmMensaje mensaje = new frmMensaje("Debe seleccionar primero a un cliente", "Mensaje de advertencia", ""); if (mensaje.ShowDialog() == DialogResult.OK) { }
                //MessageBox.Show("Debe seleccionar primero a un cliente", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (dgvClasesParticulares.RowCount == 0)
            {
                frmMensaje mensaje = new frmMensaje("El cliente no tiene clases particulares", "Mensaje de advertencia", ""); if (mensaje.ShowDialog() == DialogResult.OK) { }
                //MessageBox.Show("El cliente no tiene clases particulares", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                claseSeleccionada = clases[dgvClasesParticulares.CurrentRow.Index];
                this.DialogResult = DialogResult.OK;
            }
            
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cliente == null || dgvClasesParticulares.RowCount == 0)
            {
                frmMensaje mensaje = new frmMensaje("No hay clase particular seleccionada", "Mensaje de advertencia", ""); if (mensaje.ShowDialog() == DialogResult.OK) { }
                //MessageBox.Show("No hay clase particular seleccionada", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                claseSeleccionada = clases[dgvClasesParticulares.CurrentRow.Index];
                Program.dbController.eliminarClaseParticular(claseSeleccionada.id_servicio);
                frmMensaje mensaje = new frmMensaje("Se ha eliminado correctamente", "Mensaje de Confirmacion", ""); if (mensaje.ShowDialog() == DialogResult.OK) { }
                //MessageBox.Show("Se ha eliminado correctamente", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clases.Remove(ClaseSeleccionada);
                dgvClasesParticulares.Rows.Remove(dgvClasesParticulares.CurrentRow);
                this.Close();
            }
            
        }


        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmBuscarCliente formBuscarCliente = new frmBuscarCliente(false);
            if (formBuscarCliente.ShowDialog() == DialogResult.OK)
            {
                Cliente = formBuscarCliente.ClienteSeleccionado;
                txtDNI.Text = Cliente.dni;
                txtNombreCliente.Text = Cliente.nombre;
                dgvClasesParticulares.RowCount = 0;
                //lista las sus clases particulares
                IEnumerable<Service.claseParticular> cp = Program.dbController.listarClasesParticularesPorCliente(Cliente.idPersona);
                if(cp != null)
                {
                    foreach (Service.claseParticular c in Program.dbController.listarClasesParticularesPorCliente(Cliente.idPersona))
                    {
                        clases.Add(c);
                        Object[] filaClase = new Object[3];
                        filaClase[0] = c.nombre;
                        filaClase[1] = c.precio;
                        filaClase[2] = c.fecha.ToShortDateString();
                        dgvClasesParticulares.Rows.Add(filaClase);
                    }
                }
                
            }
        }

    }
}
