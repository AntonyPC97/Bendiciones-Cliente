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
    public partial class frmGestionarGestacion : Form

    {
        private Service.gestacion gestacion;
        Estado estadoObjGestacion;
        public frmGestionarGestacion(int maxEmb)
        {
            InitializeComponent();
            Formateador f = new Formateador();
            f.iniFormFreddyGestionar(this, "Gestionar Gestacion", pnlCtn, btnNuevo, btnBuscar, btnGuardar, btnModificar, btnCancelar, true);
            btnBuscar.Visible = false;
            btnNuevo.Visible = false;
            udNumeroEmb.Maximum = maxEmb;
            estadoObjGestacion = Estado.Nuevo;
        }
        public frmGestionarGestacion(Service.gestacion gestacion, int maxEmb)
        {
            InitializeComponent();
            Formateador f = new Formateador();
            f.iniFormFreddyGestionar(this, "Gestionar Gestacion", pnlCtn, btnNuevo, btnBuscar, btnGuardar, btnModificar, btnCancelar, true);
            btnBuscar.Visible = false;
            btnNuevo.Visible = false;
            dtpFPP.Value = gestacion.fecha_probable_parto;
            txtClinica.Text = gestacion.clinica;
            txtMedico.Text = gestacion.medico;
            udNumeroEmb.Maximum = maxEmb;
            udNumeroEmb.Value = gestacion.numEmbar;
            estadoComponentes(Estado.Buscar);
        }

        public void estadoComponentes(Estado estado)
        {
            switch (estado)
            {
                case Estado.Nuevo:
                    dtpFPP.Enabled = true;
                    txtClinica.Enabled = true;
                    txtMedico.Enabled = true;
                    udNumeroEmb.Enabled = true;

                    btnGuardar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnCancelar.Enabled = false;
                    break;
                case Estado.Buscar:
                    dtpFPP.Enabled = false;
                    txtClinica.Enabled = false;
                    txtMedico.Enabled = false;
                    udNumeroEmb.Enabled = false;

                    btnGuardar.Enabled = false;
                    btnModificar.Enabled = true;
                    btnCancelar.Enabled = false;
                    break;
                case Estado.Modificar:
                    dtpFPP.Enabled = true;
                    txtClinica.Enabled = true;
                    txtMedico.Enabled = true;
                    udNumeroEmb.Enabled = true;

                    btnGuardar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnCancelar.Enabled = true;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            txtClinica.Text = "";
            txtMedico.Text = "";
            udNumeroEmb.Value = 0;
            dtpFPP.Value = DateTime.Now;
        }

        public gestacion Gestacion { get => gestacion; set => gestacion = value; }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            gestacion = new gestacion();
            gestacion.clinica = txtClinica.Text;
            gestacion.fecha_probable_parto = dtpFPP.Value;
            gestacion.fecha_probable_partoSpecified = true;
            gestacion.medico = txtMedico.Text;
            gestacion.numEmbar = (int)udNumeroEmb.Value;
            this.DialogResult = DialogResult.OK;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            estadoComponentes(Estado.Modificar);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (estadoObjGestacion == Estado.Nuevo)
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
