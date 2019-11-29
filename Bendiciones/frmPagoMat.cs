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
    public partial class frmPagoMat : Form
    {
        private Service.cuota cuota = null;

        public frmPagoMat(Service.matricula c)
        {
            InitializeComponent();
            Formateador f = new Formateador();
            Paleta p = new Paleta();
            this.BackColor = p.Blanco;
            f.formatearBotonNaranja(btnGuardar);


            txtTotalAPagar.Text = c.monto.ToString();
            txtAbonar.Text = "0";
            txtPendiente.Text = c.monto.ToString();
            cboFormaPago.SelectedIndex = 0;
        }


       
        public cuota Cuota { get => cuota; set => cuota = value; }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (verificarCampos())
            {
                cuota = new Service.cuota();
                cuota.fecha = DateTime.Today;
                cuota.fechaSpecified = true;
                cuota.formaPago = cboFormaPago.SelectedItem.ToString();
                
                cuota.monto = float.Parse(txtAbonar.Text);


                this.DialogResult = DialogResult.OK;
            }
            //this.DialogResult = DialogResult.OK;
        }

        private void txtAbonar_TextChanged(object sender, EventArgs e)
        {
            float i;
            if (float.TryParse(txtAbonar.Text, out i))
            {
                if ((txtAbonar.Text != "") & (txtTotalAPagar.Text != ""))
                {
                    float total = float.Parse(txtTotalAPagar.Text);
                    float abono = float.Parse(txtAbonar.Text);
                    if (total < abono)
                    {
                        frmMensaje mensaje = new frmMensaje("Monto máximo a abonar: " + total.ToString("0.0"), "Mensaje de advertencia", ""); if (mensaje.ShowDialog() == DialogResult.OK) { }
                        txtAbonar.Text = txtTotalAPagar.Text;
                    }
                    else
                    {
                        txtPendiente.Text = (total - abono).ToString("0.0");
                    }
                }
            }
            else
            {
                frmMensaje mensaje = new frmMensaje("Ingrese una cantidad valida", "Error al Abonar", ""); if (mensaje.ShowDialog() == DialogResult.OK) { }
                txtAbonar.Text = "0";
            }
        }


        public bool verificarCampos()
        {
            float i;
            
            if (cboFormaPago.SelectedIndex == -1)
            {
                frmMensaje mensaje = new frmMensaje("No se ha seleciconado una forma de pago", "Error de Forma de Pago", "");
                if(mensaje.ShowDialog() == DialogResult.OK) return false;
            }
            if (!float.TryParse(txtAbonar.Text, out i))
            {
                frmMensaje mensaje = new frmMensaje("Ingrese una cantidad valida", "Error al Abonar", "");
                if(mensaje.ShowDialog() == DialogResult.OK) return false;
            }else if(i == 0)
            {
                frmMensaje mensaje = new frmMensaje("Ingrese un monto a abonar mayor que cero", "Error al Abonar", "");
                if(mensaje.ShowDialog() == DialogResult.OK) return false;
            }
            return true;
        }

    }
}




