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

    public partial class frmAgregarCursoMatricula : Form
    {
        private Service.matricula mat;
        private Service.cuota c = null;
        private Service.curso cur = null;

        public matricula Mat { get => mat; set => mat = value; }




        public curso Cur { get => cur; set => cur = value; }

        public frmAgregarCursoMatricula()
        {
            InitializeComponent();
			Formateador f = new Formateador();
			Paleta p = new Paleta();
			this.BackColor = p.Blanco;
			f.formatearBotonListar(btnListarServicios);
			gbServicio.BackColor = p.Blanco;
			gbCliente.BackColor = p.Blanco;
			gbRestricciones.BackColor = p.Blanco;
			f.formatearBotonNaranja(btnCancelar);
			f.formatearBotonNaranja(btnGuardar);
			btnGuardar.Top = gbCliente.Top;
			btnCancelar.Top = btnGuardar.Top + btnGuardar.Height + 10;
            cboFormaPago.SelectedIndex = 0;
			btnGuardar.Left = gbCliente.Left + gbCliente.Width + 10;
			btnCancelar.Left = btnGuardar.Left;
            dgvCondicionesMedicas.AutoGenerateColumns = false;
            txtAbonar.Text = "0";
            txtSaldo.Text = "0";
        }

        public bool verificarCampos()
        {
            float i;
            if (cur == null)
            {
                frmMensaje mensaje = new frmMensaje("No se ha seleccionado un servicio","Error de Servicio","");
                return false;
            }
            if (cboFormaPago.SelectedIndex == -1)
            {
                frmMensaje mensaje = new frmMensaje("No se ha seleccionado una forma de pago", "Error de Forma de Pago", "");
                return false;
            }
            if(!float.TryParse(txtAbonar.Text,out i))
            {
                frmMensaje mensaje = new frmMensaje("Ingrese una cantidad valida", "Error al Abonar", "");
                txtAbonar.Text = "";
                return false;
            }
            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //validacíon
            if (verificarCampos())
            {
                //actualizar saldo
                mat = new Service.matricula();
                mat.monto = float.Parse(txtTotal.Text);
                mat.saldo = float.Parse(txtSaldo.Text);
                mat.servicio = cur;
                if (cboDescuentos.DataSource != null)
                {
                    mat.descuento = (Service.descuento)cboDescuentos.SelectedItem;
                }
                mat.fecha = DateTime.Today;
                mat.fechaSpecified = true;

                if (float.Parse(txtAbonar.Text) != 0)
                {
                    c = new Service.cuota();
                    c.fecha = DateTime.Today;
                    c.fechaSpecified = true;
                    c.monto = float.Parse(txtAbonar.Text);
                    c.formaPago = (String)cboFormaPago.SelectedItem;
                    BindingList<Service.cuota> cuotas = new BindingList<cuota>();
                    cuotas.Add(c);
                    mat.cuotas = cuotas.ToArray<Service.cuota>();
                }
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnListarServicios_Click(object sender, EventArgs e)
        {
            frmBuscarCurso formBuscarCurso = new frmBuscarCurso(false);
            if(formBuscarCurso.ShowDialog() == DialogResult.OK)
            {
                txtAbonar.Text = "0";
                cur = formBuscarCurso.CursoSeleccionado;
                txtNombreServicio.Text = cur.nombre;
                txtDescripcion.Text = cur.descripcion;
                txtPrecio.Text = cur.precio.ToString();
                dgvCondicionesMedicas.DataSource = cur.condMedicas;
               
                if (cur.desAplicables != null)
                {
                    cboDescuentos.DataSource = cur.desAplicables;
                    cboDescuentos.DisplayMember = "Nombre";
                    cboDescuentos.ValueMember = "idDescuento";
                    cboDescuentos.SelectedIndex = -1;
                }
                else
                {
                    cboDescuentos.DataSource = null;
                    cboDescuentos.Items.Clear();

                }
                txtTotal.Text= cur.precio.ToString();
                txtSaldo.Text = cur.precio.ToString();
            }
        }

        private void dgvCondicionesMedicas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Service.condicionMedica data = dgvCondicionesMedicas.Rows[e.RowIndex].DataBoundItem as Service.condicionMedica;
            if(data != null)
            {
                dgvCondicionesMedicas.Rows[e.RowIndex].Cells[0].Value = data.nombre;
                dgvCondicionesMedicas.Rows[e.RowIndex].Cells[1].Value = data.descripcion;
            }
        }

        private void cboDescuentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDescuentos.SelectedIndex != -1) { 
                Service.descuento desc = (Service.descuento)cboDescuentos.SelectedItem;
                txtTotal.Text = (cur.precio * (1 - desc.porcentaje / 100)).ToString("0.0");
                int longitud = txtTotal.Text.Length;
                txtAbonar.MaxLength = longitud;
                if (txtAbonar.Text == "")
                {
                    txtSaldo.Text = (float.Parse(txtTotal.Text) - 0).ToString("0.0");
                }
                else
                {
                    txtSaldo.Text = (float.Parse(txtTotal.Text) - float.Parse(txtAbonar.Text)).ToString("0.0");
                }
                
            }
            else
            {
                txtTotal.Text = cur.precio.ToString();
                int longitud = txtTotal.Text.Length;
                txtAbonar.MaxLength = longitud;
            }
        }

        private void txtAbonar_TextChanged(object sender, EventArgs e)
        {
            float i;
            if (txtAbonar.Text == "")
            {

            }
            
            else if (float.TryParse(txtAbonar.Text,out i))
            {
                if ((txtAbonar.Text != "") & (txtTotal.Text != ""))
                {
                    float total = float.Parse(txtTotal.Text);
                    float abono = float.Parse(txtAbonar.Text);
                    if (total < abono)
                    {
                        frmMensaje mensaje = new frmMensaje("Monto máximo a abonar: " + total.ToString("0.0"), "Mensaje de advertencia", "");
                        txtAbonar.Text = txtTotal.Text;
                    }
                    else
                    {
                        txtSaldo.Text = (total - abono).ToString("0.0");
                    }
                }
            }
            else
            {
                frmMensaje mensaje = new frmMensaje("Ingrese una cantidad valida", "Error al Abonar", "");
                txtAbonar.Text = "";
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cur = null;
            txtNombreServicio.Text = "";
            txtPrecio.Text = "";
            txtDescripcion.Text = "";
            txtSaldo.Text = "";
            txtTotal.Text = "";
            txtAbonar.Text = "";
            cboDescuentos.SelectedIndex = -1;
            cboFormaPago.SelectedIndex = -1;
            dgvCondicionesMedicas.DataSource = null;
        }

 
    }
}
