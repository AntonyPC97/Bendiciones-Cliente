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
            
            txtTotalAPagar.Text = c.monto.ToString();
            txtAbonar.Text = "0";
            txtPendiente.Text = c.monto.ToString();
        }


       
        public cuota Cuota { get => cuota; set => cuota = value; }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtAbonar.Text != "0")
            {
                cuota = new Service.cuota();
                cuota.fecha = DateTime.Today;
                cuota.fechaSpecified = true;
                cuota.formaPago = cboFormaPago.SelectedItem.ToString();
                
                cuota.monto = float.Parse(txtAbonar.Text);
                //insertar cuota
                //mat.saldo = mat.saldo - cuota.monto;

                Console.WriteLine(cuota.formaPago);
                Console.WriteLine("item to string: ", cboFormaPago.SelectedItem.ToString());
                Console.WriteLine("text: ", cboFormaPago.SelectedText);

                this.DialogResult = DialogResult.OK;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void txtAbonar_TextChanged(object sender, EventArgs e)
        {
            txtPendiente.Text = (float.Parse(txtTotalAPagar.Text) - float.Parse(txtAbonar.Text)).ToString();
        }
    }
}
