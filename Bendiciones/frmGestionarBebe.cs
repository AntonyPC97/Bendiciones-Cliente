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
    public partial class frmGestionarBebe : Form
    {
        private Service.bebe bebeSeleccionado;
        private Service.bebe bebe;
        Estado estObjBebe;
        public frmGestionarBebe()
        {
            InitializeComponent();
            Formateador f = new Formateador();
            f.iniFormFreddyGestionar(this, "Gestionar Bebe", pnlCtn,btnNuevo,btnBuscar, btnGuardar, btnModificar, btnCancelar,true);
            btnBuscar.Visible = false;
            btnNuevo.Visible = false;
            dgvCondiciones.AutoGenerateColumns = false;
            dgvCondiciones.DataSource = Program.dbController.listarCondMedicasPorNombre("");
            estObjBebe = Estado.Nuevo;
            estadoComponentes(Estado.Nuevo);
        }

        public frmGestionarBebe(Service.bebe bebe)
        {
            InitializeComponent();
            Formateador f = new Formateador();
            f.iniFormFreddyGestionar(this, "Gestionar Bebe", pnlCtn, btnNuevo, btnBuscar, btnGuardar, btnModificar, btnCancelar, true);
            btnBuscar.Visible = false;
            btnNuevo.Visible = false;
            dgvCondiciones.AutoGenerateColumns = false;
            txtDNIBebe.Text = bebe.dni;
            txtNombre.Text = bebe.nombre;
            dtpFechaNac.Value = bebe.fechaNaci;
            cboRelacion.Text = bebe.relacion;
            udNumHermanos.Value = bebe.numHerman;
            if (bebe.sexo == 'F')
                rbFemenino.Checked = true;
            else
                rbMasculino.Checked = true;
            txtObservaciones.Text = bebe.observMedicas;
            dgvCondiciones.DataSource = bebe.condMedicas;
            for (int i = 0; i < dgvCondiciones.RowCount; i++)
                dgvCondiciones.Rows[i].Cells[1].Value = true;
            estadoComponentes(Estado.Buscar);
            bebeSeleccionado = bebe;
        }

        public bool verificarCampos()
        {
            if (txtDNIBebe.Text.Equals("") || txtNombre.Text.Equals("") || cboRelacion.SelectedIndex==-1 || (rbMasculino.Checked==false && rbFemenino.Checked==false))
            {
                frmMensaje mensaje = new frmMensaje("Complete los campos obligatorios", "Error de CAMPOS", "");
                return false;
            }
            return true;
        }
        public void estadoComponentes(Estado estado)
        {
            switch (estado)
            {
                case Estado.Nuevo:
                    dtpFechaNac.Enabled = true;
                    txtDNIBebe.Enabled = true;
                    txtNombre.Enabled = true;
                    cboRelacion.Enabled = true;
                    udNumHermanos.Enabled = true;
                    rbFemenino.Enabled = true;
                    rbMasculino.Enabled = true;
                    dgvCondiciones.Enabled = true;
                    txtObservaciones.Enabled = true;

                    btnGuardar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnCancelar.Enabled = false;
                    break;
                case Estado.Buscar:
                    dtpFechaNac.Enabled = false;
                    txtDNIBebe.Enabled = false;
                    txtNombre.Enabled = false;
                    cboRelacion.Enabled = false;
                    udNumHermanos.Enabled = false;
                    rbFemenino.Enabled = false;
                    rbMasculino.Enabled = false;
                    dgvCondiciones.Enabled = false;
                    txtObservaciones.Enabled = false;

                    btnGuardar.Enabled = false;
                    btnModificar.Enabled = true;
                    btnCancelar.Enabled = false;
                    break;
                case Estado.Modificar:
                    dtpFechaNac.Enabled = true;
                    txtDNIBebe.Enabled = true;
                    txtNombre.Enabled = true;
                    cboRelacion.Enabled = true;
                    udNumHermanos.Enabled = true;
                    rbFemenino.Enabled = true;
                    rbMasculino.Enabled = true;
                    dgvCondiciones.Enabled = true;
                    txtObservaciones.Enabled = true;

                    btnGuardar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnCancelar.Enabled = true;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            dtpFechaNac.Value = DateTime.Now;
            txtDNIBebe.Text = "";
            txtNombre.Text = "";
            cboRelacion.SelectedIndex = -1;
            udNumHermanos.Value = 0; 
            rbFemenino.Checked = false;
            rbMasculino.Checked = false;
            txtObservaciones.Text = "";
            dgvCondiciones.AutoGenerateColumns = false;
            dgvCondiciones.DataSource = Program.dbController.listarCondMedicasPorNombre("");
        }
        public bebe Bebe { get => bebe; set => bebe = value; }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (verificarCampos())
            {
                bebe = new bebe();
                if (estObjBebe == Estado.Modificar)
                    bebe.idPersona = bebeSeleccionado.idPersona;
                bebe.dni = txtDNIBebe.Text;
                bebe.fechaNaci = dtpFechaNac.Value;
                bebe.fechaNaciSpecified = true;
                bebe.nombre = txtNombre.Text;
                if (rbFemenino.Checked == true)
                    bebe.sexo = 'F';
                else
                    bebe.sexo = 'M';
                bebe.numHerman = (int)udNumHermanos.Value;
                bebe.observMedicas = txtObservaciones.Text;
                bebe.relacion = (String)cboRelacion.SelectedItem;

                //condiciones medicas

                List<Service.condicionMedica> condicionMedicas = new List<Service.condicionMedica>();
                for (int i = 0; i < dgvCondiciones.Rows.Count; i++)
                {
                    if (dgvCondiciones.Rows[i].Cells[1].Value == null)
                    { }
                    else if ((bool)dgvCondiciones.Rows[i].Cells[1].Value == true)
                    {
                        Service.condicionMedica cond = new Service.condicionMedica();
                        cond = (Service.condicionMedica)dgvCondiciones.Rows[i].DataBoundItem;
                        condicionMedicas.Add(cond);
                    }
                }

                bebe.condMedicas = condicionMedicas.ToArray();
                this.DialogResult = DialogResult.OK;
            }
            
        }

        private void dgvCondiciones_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Service.condicionMedica conFila = (Service.condicionMedica)dgvCondiciones.Rows[e.RowIndex].DataBoundItem;
            if (conFila != null)
                dgvCondiciones.Rows[e.RowIndex].Cells["Nombre"].Value = conFila.nombre;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            dgvCondiciones.DataSource = Program.dbController.listarCondMedicasPorNombre("");
            foreach (Service.condicionMedica con in bebeSeleccionado.condMedicas)
            {
                for (int i = 0; i < dgvCondiciones.RowCount; i++)
                {
                    if (con.nombre.Equals(((Service.condicionMedica)dgvCondiciones.Rows[i].DataBoundItem).nombre))
                    {
                        dgvCondiciones.Rows[i].Cells[1].Value = true;
                        i = dgvCondiciones.RowCount;
                    }
                }
            }
            estadoComponentes(Estado.Modificar);
            estObjBebe = Estado.Modificar;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (estObjBebe == Estado.Nuevo)
            {
                limpiarComponentes();
            }
            else
            {
                this.Close();
            }
        }
    }
}
