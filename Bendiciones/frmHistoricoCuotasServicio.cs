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
    public partial class frmHistoricoCuotasServicio : Form
    {
        private Service.matricula mat;
        private Service.cliente cliente;
        public frmHistoricoCuotasServicio()
        {
            InitializeComponent();
			this.CenterToScreen();
			Paleta p = new Paleta();
			Formateador f = new Formateador();
			this.BackColor = p.GrisClaro;
			f.formatearBotonListar(btnBuscarCliente);
			f.formatearBotonListar(btnListarServicios);
			gbCliente.BackColor = p.Blanco;
			gbServicio.BackColor = p.Blanco;
			gbHistorico.BackColor = p.Blanco;
			dgvHistorico.AutoGenerateColumns = false;

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmBuscarCliente formBuscarCliente = new frmBuscarCliente();
            if(formBuscarCliente.ShowDialog() == DialogResult.OK)
            {
                limpiarComponentes();
				cliente = formBuscarCliente.ClienteSeleccionado;
                txtDNI.Text = cliente.dni;
                txtNombreCliente.Text = cliente.nombre;
            }
        }

        private void limpiarComponentes()
        {
            txtNombreServicio.Text = "";
            txtDescripcion.Text = "";
            txtSaldo.Text = "";
            txtPrecio.Text = "";
            txtDescuento.Text = "";
            dtpFechaMatricula.Value = DateTime.Now;
            dgvHistorico.RowCount = 0;
        }

        private void btnListarServicios_Click(object sender, EventArgs e)
        {

			if(cliente != null)			{
                
                frmBuscarServicioPorCliente formBuscarServicioPorCliente = new frmBuscarServicioPorCliente(cliente);
                if(formBuscarServicioPorCliente.Matriculas!= null)
                {
                    if (formBuscarServicioPorCliente.ShowDialog() == DialogResult.OK)
                    {
                        limpiarComponentes();
                        mat = formBuscarServicioPorCliente.ServMat;
                        txtNombreServicio.Text = mat.servicio.nombre;
                        txtDescripcion.Text = mat.servicio.descripcion;
                        txtSaldo.Text = mat.saldo.ToString();
                        txtPrecio.Text = (mat.servicio.precio * (1 - (mat.descuento.porcentaje / 100))).ToString("0.0");
                        if (mat.descuento.porcentaje != 0)
                            txtDescuento.Text = mat.descuento.nombre + " - " + mat.descuento.porcentaje.ToString() + "%";
                        dtpFechaMatricula.Value = mat.fecha;
                        //datagridview
                        //List<Service.cuota> cuotas = Program.dbController.listarCuotasPorMatricula(mat.idMatricula).ToList<Service.cuota>();
                        IEnumerable<Service.cuota> cuotas = Program.dbController.listarCuotasPorMatricula(mat.idMatricula);
                        if (cuotas != null)
                        {
                            dgvHistorico.RowCount = 0;
                            foreach (Service.cuota c in cuotas)
                            {
                                Object[] fila = new Object[3];
                                fila[0] = c.fecha.ToShortDateString();
                                fila[1] = c.monto.ToString("0.0");
                                fila[2] = c.formaPago;
                                dgvHistorico.Rows.Add(fila);
                            }
                        }

                    }
                }
					
			}
			else
				MessageBox.Show("Seleccione un Cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

		}
    }
}
