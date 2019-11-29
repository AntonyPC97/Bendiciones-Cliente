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
    public partial class frmMatricula : Form
    {
        private Service.cliente cliente;
        private Service.matricula matricula;
        private BindingList<Service.matricula> matriculas = new BindingList<Service.matricula>();
        private Service.apoderado ap;

        public cliente Cliente { get => cliente; set => cliente = value; }
        public matricula Matricula { get => matricula; set => matricula = value; }

        public frmMatricula()
        {
            InitializeComponent();
			Formateador f = new Formateador();
			Paleta p = new Paleta();
			f.formatearBotonListar(btnBuscarCliente);
			btnAgregarCurso.BackColor = p.Naranja;
			btnAgregarCurso.ForeColor = p.Blanco;
            btnEliminarCurso.BackColor = p.Naranja;
            btnEliminarCurso.ForeColor = p.Blanco;
            lblBebe.Visible = false;
            cboBebes.Visible = false;
			f.formMatricula(this,"Matricula",pnlCtn,btnGuardar,btnCancelar);
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            lblBebe.Visible = false;
            cboBebes.Visible = false;

            frmBuscarCliente formBuscarCliente = new frmBuscarCliente(false);
            if(formBuscarCliente.ShowDialog() == DialogResult.OK)
            {
                cliente = formBuscarCliente.ClienteSeleccionado;
                txtDNI.Text = cliente.dni;
                txtNombreCliente.Text = cliente.nombre;

                //si es apoderado, muestra bebés
                if (cliente is Service.apoderado)
                {
                    lblBebe.Visible = true;
                    cboBebes.Visible = true;
                    ap = (Service.apoderado)cliente;
                    if(ap.bebes != null)
                    {
                        BindingList<Service.bebe> bebes = new BindingList<bebe>(ap.bebes);
                        cboBebes.DisplayMember = "Nombre";
                        cboBebes.DataSource = bebes;
                    }
                    
                }
                
            }

        }

        private void btnAgregarCurso_Click(object sender, EventArgs e)
        {
            if(cliente != null)
            {
                frmAgregarCursoMatricula formAgregarCursoMatricula = new frmAgregarCursoMatricula();
                if (formAgregarCursoMatricula.ShowDialog() == DialogResult.OK)
                {
                    matricula = new Service.matricula();
                    matricula = formAgregarCursoMatricula.Mat;

                    matriculas.Add(matricula);
                    Object[] fila = new Object[6];
                    fila[0] = matricula.servicio.nombre;
                    fila[1] = matricula.fecha.ToShortDateString();
                    fila[3] = matricula.monto.ToString();
                    fila[2] = matricula.servicio.precio.ToString();
                    fila[4] = matricula.saldo.ToString();
                    if (matricula.descuento != null)
                    {
                        fila[5] = matricula.descuento.nombre;
                    }
                    else
                    {
                        fila[5] = "Sin descuento";
                    }


                    dgvMatriculas.Rows.Add(fila);

                }
            }
            else
            {
                frmMensaje mensaje = new frmMensaje("Seleecione un Cliente","Error de Cliente","Confirmar");   if(mensaje.ShowDialog() == DialogResult.OK){};
                return;
            }
        }

        public bool verificarCampos()
        {
            if(cliente == null)
            {
                frmMensaje mensaje = new frmMensaje("Seleecione un Cliente", "Error de Cliente", "");
                if(mensaje.ShowDialog() == DialogResult.OK) return false;
            }
            if (dgvMatriculas.RowCount == 0)
            {
                frmMensaje mensaje = new frmMensaje("Agregue un curso", "Error de Matricula", "");
                if(mensaje.ShowDialog() == DialogResult.OK) return false;
            }
            return true;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (verificarCampos())
            {
                Service.matricula m = new Service.matricula();
                for (int fila = 0; fila < dgvMatriculas.Rows.Count; fila++)
                {
                    m = matriculas[fila];
                    //(Service.matricula)dgvMatriculas.Rows[fila].DataBoundItem;
                    m.cliente = cliente;
                    if (cliente is Service.apoderado)
                    {
                        m.bebe = (Service.bebe)cboBebes.SelectedItem;
                    }

                    Program.dbController.insertarMatricula(m);
                }
				frmMensaje mensaje = new frmMensaje("Matrícula Registrada exitosamente", "Mensaje Confirmación", "Confirmar");   if(mensaje.ShowDialog() == DialogResult.OK){};
                
				Correo c = new Correo();
				c.CorreoNuevoServicio(cliente,matriculas);
				txtDNI.Text = "";
                txtNombreCliente.Text = "";
                cboBebes.DataSource = null;
                cboBebes.SelectedIndex = -1;
                dgvMatriculas.RowCount = 0;
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cliente = null;
            txtDNI.Text = "";
            txtNombreCliente.Text = "";
            lblBebe.Visible = false;
            cboBebes.Visible = false;
            dgvMatriculas.RowCount = 0;
        }

        private void btnEliminarCurso_Click(object sender, EventArgs e)
        {
            if(cliente == null)
            {
                frmMensaje mensaje = new frmMensaje("Seleccione un Cliente", "Error de Cliente", ""); if (mensaje.ShowDialog() == DialogResult.OK) { }
                return;
            }
            foreach(DataGridViewRow row in dgvMatriculas.SelectedRows)
            {
                matriculas.RemoveAt(row.Index);
                dgvMatriculas.Rows.RemoveAt(row.Index);
            }
        }
    }
}
