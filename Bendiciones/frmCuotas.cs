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
    public partial class frmCuotas : Form
    {
        private Service.cliente cliente;
        private Service.matricula servMat;
        public frmCuotas()
        {
            InitializeComponent();
            Formateador f = new Formateador();
			f.formatearBotonListar(btnBuscarCliente);
			f.formatearBotonListar(btnListarServicios);
			f.formatearBotonNaranja(btnAbonar);
			f.formatearBotonNaranja(btnCancelar);
			btnCancelar.Top = gbPago.Top + gbPago.Height + 10;
			btnCancelar.Left = gbPago.Left + gbPago.Width - btnCancelar.Width;
			btnAbonar.Top = btnCancelar.Top;
			btnAbonar.Left = btnCancelar.Left - btnCancelar.Width - 10;
			f.formRegistrarCuota(this, "Cuotas", pnlCtn, false);
        }

		public bool verificarCampos()
		{
			float i;

			if (cliente == null || servMat == null ||txtAbonar.Text.Equals("") || cboFormaPago.SelectedIndex == -1)
			{
				MessageBox.Show("Todos los campos son oligatorios", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			if (!float.TryParse(txtAbonar.Text, out i))
			{
				MessageBox.Show("Ingrese una cantidad numerica valida", "Error de Abonar", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			if (float.Parse(txtAbonar.Text) < 0)
			{
				MessageBox.Show("Ingrese una cantidad numerica positiva", "Error de Abonar", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			if (float.Parse(txtAbonar.Text)==0)
			{
				MessageBox.Show("No es posible abonar 0 soles", "Error de Abonar", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			
			return true;
		}
        private void limpiarComponentes()
        {
            txtNombreServicio.Text = "";
            txtPendiente.Text = "";
            dtpFechaMatricula.Value = DateTime.Now;
            cboFormaPago.SelectedIndex = -1;
            txtAbonar.Text = "0";
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmBuscarCliente formBuscarCliente = new frmBuscarCliente();
            if (formBuscarCliente.ShowDialog() == DialogResult.OK)
            {
                limpiarComponentes();
                cliente = formBuscarCliente.ClienteSeleccionado;
                txtDNI.Text = cliente.dni;
                txtNombreCliente.Text = cliente.nombre;
            }
        }

        private void btnListarServicios_Click(object sender, EventArgs e)
        {
			if(cliente != null)
            {
                frmBuscarServicioDeudaPorCliente formBuscarServicioPorCliente = new frmBuscarServicioDeudaPorCliente(cliente);
                if (formBuscarServicioPorCliente.Matriculas != null)                {
                    
                    if (formBuscarServicioPorCliente.ShowDialog() == DialogResult.OK)
                    {
                        servMat = formBuscarServicioPorCliente.ServMat;
                        txtNombreServicio.Text = servMat.servicio.nombre;
                        dtpFechaMatricula.Value = servMat.fecha;
                        txtPendiente.Text = servMat.saldo.ToString("0.0");
                    }
                }
				
			}
			else
				MessageBox.Show("Seleccione un Cliente","",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            
        }

        private void btnAbonar_Click(object sender, EventArgs e)
        {
            if((verificarCampos()))
            {
                float monto = float.Parse(txtAbonar.Text);
                float pendiente = float.Parse(txtPendiente.Text);
                if (pendiente < monto)
                {
                    MessageBox.Show("Monto máximo a abonar: " + pendiente.ToString("0.0"), "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAbonar.Text = "0";
                }
                else
                {
                    Service.cuota c = new Service.cuota();
                    c.fecha = DateTime.Today;
                    c.fechaSpecified = true;
                    c.monto = float.Parse(txtAbonar.Text);
                    c.formaPago = (String)cboFormaPago.SelectedItem;

                    servMat.saldo = servMat.saldo - c.monto;
                    Program.dbController.actualizarMatricula(servMat);
                    Program.dbController.insertarCuota(c, servMat.idMatricula);
                    MessageBox.Show("Cuota Registrada exitosamente", "Mensaje Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtPendiente.Text = (float.Parse(txtPendiente.Text) - float.Parse(txtAbonar.Text)).ToString("0.0");
                    txtAbonar.Text = "0";
                }
                
			}
			
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			cliente = null;
			servMat = null;
			txtDNI.Text = "";
			txtNombreCliente.Text = "";
			txtNombreServicio.Text = "";
			txtAbonar.Text = "0";
			txtPendiente.Text = "";
			cboFormaPago.SelectedIndex = -1;
		}

     
    }
}
