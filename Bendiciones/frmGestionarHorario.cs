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
    public partial class frmGestionarHorario : Form
    {
        private Service.horario horarioSeleccionado = new Service.horario();
        private Service.colaborador docente = new Service.colaborador();
        private Service.curso curs;

        public frmGestionarHorario(Service.curso cur)
        {
            Curs = cur;
            InitializeComponent();
            Formateador f = new Formateador();
            f.formGestionarHorario(this, "Gestionar Horario", pnlCtn, btnGuardar, btnModificar, btnCancelar);
            f.formatearBotonLila(btnEliminarDocente);
            cboSede.DataSource = Program.dbController.listarSedes();
            cboSede.DisplayMember = "direccion";
            dtpHoraIni.MinDate = DateTime.Parse("1/01/1970 9:00");
            dtpHoraIni.MaxDate = DateTime.Parse("1/01/1970 21:00");
            dtpHoraFin.MinDate = DateTime.Parse("1/01/1970 11:00");
            dtpHoraFin.MaxDate = DateTime.Parse("1/01/1970 23:00");

        }
        public frmGestionarHorario()
        {
            InitializeComponent();
            Formateador f = new Formateador();
            f.formGestionarHorario(this, "Gestionar Horario", pnlCtn, btnGuardar, btnModificar, btnCancelar);
            f.formatearBotonLila(btnEliminarDocente);
            cboSede.DataSource = Program.dbController.listarSedes();
            cboSede.DisplayMember = "direccion";
            dtpHoraIni.MinDate = DateTime.Parse("1/01/1970 9:00");
            dtpHoraIni.MaxDate = DateTime.Parse("1/01/1970 21:00");
            dtpHoraFin.MinDate = DateTime.Parse("1/01/1970 11:00");
            dtpHoraFin.MaxDate = DateTime.Parse("1/01/1970 23:00");

        }
        public bool verificarCampos()
        {
            if (txtNumClase.Text.ToString().Equals(""))
            {
                frmMensaje mensaje = new frmMensaje("Ingrese un número de clase o número de vacantes válido", "Error de Servicio", "");
                return false;
            }
            int nClases = Int32.Parse(txtNumClase.Text);
            if (Curs.numClases < nClases)
            {
                frmMensaje mensaje = new frmMensaje("El curso tiene como máximo: " + Curs.numClases + " clases", "Error de Servicio", "");
                return false;
            }
            if (dtpFechaMatricula.Value.Date < DateTime.Now.Date)
            {
                frmMensaje mensaje = new frmMensaje("El curso no puede crearse un fecha anterior al actual", "Error de Servicio", "");
                return false;
            }
            if(dtpHoraIni.Value> dtpHoraFin.Value)
            {
                frmMensaje mensaje = new frmMensaje("El horario tiene una hora de inicio mayor a la hora final", "Error de Servicio", "");
                return false;
            }

            int horaIni = dtpHoraIni.Value.Hour * 100 + dtpHoraIni.Value.Minute;
            int horaFin = dtpHoraFin.Value.Hour * 100 + dtpHoraFin.Value.Minute;
            if (horaFin - horaIni > 300| horaFin - horaIni < 130)
            {
                frmMensaje mensaje = new frmMensaje("El horario debe durar minimo 2hrs y maximo 3 hrs", "Error de Servicio", "");
                return false;
            }
            if (txtNumVac.Text.ToString().Equals(""))
            {
                frmMensaje mensaje = new frmMensaje("Ingrese un número de clase o número de vacantes válido", "Error de Servicio", "");
                return false;
            }
            if (Int32.Parse(txtNumVac.Text.ToString())>30)
            {
                frmMensaje mensaje = new frmMensaje("El horario debe terner máximo 30 vacantes", "Error de Servicio", "");
                return false;
            }
            return true;
        }
        public frmGestionarHorario(Service.horario h, Service.curso cur)
        {
            Curs = cur;
            InitializeComponent();
            Formateador f = new Formateador();
            f.formGestionarHorario(this, "Gestionar Horario", pnlCtn, btnGuardar, btnModificar, btnCancelar);
            f.formatearBotonLila(btnEliminarDocente);
            cboSede.DataSource = Program.dbController.listarSedes();
            cboSede.DisplayMember = "direccion";
            dtpHoraIni.MinDate = DateTime.Parse("1/01/1970 9:00");
            dtpHoraIni.MaxDate = DateTime.Parse("1/01/1970 21:00");
            dtpHoraFin.MinDate = DateTime.Parse("1/01/1970 11:00");
            dtpHoraFin.MaxDate = DateTime.Parse("1/01/1970 23:00");


            //llena los datos
            HorarioSeleccionado = h;
            cboSede.SelectedItem = h.sede;
            dtpFechaMatricula.Value = h.fecha;
            dtpHoraIni.Value = h.horaIni;
            dtpHoraFin.Value = h.horaFin;
            //cboHoraFin.SelectedItem = (String)h.horaIni.ToShortTimeString();
            //cboHoraIni.SelectedItem = (String)h.horaFin.ToShortTimeString();
            txtNumClase.Text = h.clase.ToString();
            txtNumVac.Text = h.numVacantes.ToString();

            //docente nulo
            if (h.colaborador.idPersona != 0)
            {
                txtDNIDocente.Text = h.colaborador.dni;
                txtNombreDocente.Text = h.colaborador.nombre;
            }
            estadoComponentes(Estado.Inicial);
        }
        public frmGestionarHorario(Service.horario h)
        {
            InitializeComponent();
            Formateador f = new Formateador();
            f.formGestionarHorario(this, "Gestionar Horario", pnlCtn, btnGuardar, btnModificar, btnCancelar);
            f.formatearBotonLila(btnEliminarDocente);
            cboSede.DataSource = Program.dbController.listarSedes();
            cboSede.DisplayMember = "direccion";
            dtpHoraIni.MinDate = DateTime.Parse("1/01/1970 9:00");
            dtpHoraIni.MaxDate = DateTime.Parse("1/01/1970 21:00");
            dtpHoraFin.MinDate = DateTime.Parse("1/01/1970 11:00");
            dtpHoraFin.MaxDate = DateTime.Parse("1/01/1970 23:00");


            //llena los datos
            cboSede.SelectedItem = h.sede;
            dtpFechaMatricula.Value = h.fecha;
            dtpHoraIni.Value = h.horaIni;
            dtpHoraFin.Value = h.horaFin;
            //cboHoraFin.SelectedItem = (String)h.horaIni.ToShortTimeString();
            //cboHoraIni.SelectedItem = (String)h.horaFin.ToShortTimeString();
            txtNumClase.Text = h.clase.ToString();
            txtNumVac.Text = h.numVacantes.ToString();

            //docente nulo
            if (h.colaborador.idPersona != 0)
            {
                txtDNIDocente.Text = h.colaborador.dni;
                txtNombreDocente.Text = h.colaborador.nombre;
            }
        }

        public horario HorarioSeleccionado { get => horarioSeleccionado; set => horarioSeleccionado = value; }
        public curso Curs { get => curs; set => curs = value; }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (verificarCampos())
            {
                //horarioSeleccionado = new Service.horario();

                horarioSeleccionado.fecha = dtpFechaMatricula.Value;
                horarioSeleccionado.fechaSpecified = true;
                horarioSeleccionado.horaIni = dtpHoraIni.Value;
                horarioSeleccionado.horaFinSpecified = true;
                horarioSeleccionado.horaIniSpecified = true;
                horarioSeleccionado.horaFin = dtpHoraFin.Value;
                horarioSeleccionado.clase = Int32.Parse(txtNumClase.Text);
                horarioSeleccionado.numVacantes = Int32.Parse(txtNumVac.Text);
                horarioSeleccionado.sede = (Service.sede)cboSede.SelectedItem;
                //si hay docente
                //Console.WriteLine(docente.idPersona);
                if (docente != null)
                {
                    horarioSeleccionado.colaborador = docente;
                }
                else
                {
                    horarioSeleccionado.colaborador = null;
                }
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnBuscarDocente_Click(object sender, EventArgs e)
        {
            frmBuscarDocente formBuscarDocente = new frmBuscarDocente();
            if (formBuscarDocente.ShowDialog() == DialogResult.OK)
            {
                docente = formBuscarDocente.DocenteSeleccionado;
                Console.WriteLine(docente.idPersona);
                txtDNIDocente.Text = docente.dni;
                txtNombreDocente.Text = docente.nombre;
            }
        }
        public void estadoComponentes(Estado estado)
        {
            switch (estado)
            {
                case Estado.Inicial:
                    cboSede.Enabled = false;
                    dtpFechaMatricula.Enabled = false;
                    dtpHoraFin.Enabled = false;
                    dtpHoraIni.Enabled = false;
                    txtNumVac.Enabled = false;
                    txtNumClase.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnEliminarDocente.Enabled = false;
                    btnBuscarDocente.Enabled = false;
                    break;
                case Estado.Modificar:
                    cboSede.Enabled = true;
                    dtpFechaMatricula.Enabled = true;
                    dtpHoraFin.Enabled = true;
                    dtpHoraIni.Enabled = true;
                    txtNumVac.Enabled = true;
                    txtNumClase.Enabled = true;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnEliminarDocente.Enabled = true;
                    btnBuscarDocente.Enabled = true;
                    break;
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            estadoComponentes(Estado.Modificar);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnEliminarDocente_Click(object sender, EventArgs e)
        {
            docente = null;
            txtDNIDocente.Text = "";
            txtNombreDocente.Text = "";
        }

        private void txtNumClase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNumVac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }
    }
}
