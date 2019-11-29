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
    public partial class frmGestionarClaseParticular : Form
    {
        private Service.cliente cliente;
        private Service.colaborador docente;
        private Service.claseParticular cp = new Service.claseParticular();
        private Service.matricula mat = new Service.matricula();
        private BindingList<Service.cuota> cuotas = null;
        private IEnumerable<Service.descuento> descuentos;
        Estado estadoObjColab;


        public void limpiarComponentes()
        {
            txtDNICliente.Text = "";
            txtNombreCliente.Text = "";
            txtNombreServicio.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "0";
            txtObservaciones.Text = "";
            txtDireccion.Text = "";
            //cboDistrito.SelectedText = "";
            cboDistrito.SelectedIndex = 0;
            dtpFechaMatricula.Value = DateTime.Today;

            dtpHoraIni.MinDate = DateTime.Parse("1/01/1970 9:00");
            dtpHoraIni.MaxDate = DateTime.Parse("1/01/1970 21:00");
            dtpHoraFin.MinDate = DateTime.Parse("1/01/1970 11:00");
            dtpHoraFin.MaxDate = DateTime.Parse("1/01/1970 23:00");

            txtDNIDocente.Text = ""; ;
            txtNombreDocente.Text = "";
            txtSaldo.Text = "0";
            txtTotal.Text = "0";

            cboDescuentos.SelectedIndex = -1;
        }
        public void estadoComponentes(Estado estado)
        {
            switch (estado)
            {
                case Estado.Inicial:

                    btnBuscarCliente.Enabled = false;
                    txtNombreServicio.Enabled = false;
                    txtDescripcion.Enabled = false;
                    txtPrecio.Enabled = false;
                    txtObservaciones.Enabled = false;
                    txtDireccion.Enabled = false;
                    cboDistrito.Enabled = false;
                    dtpFechaMatricula.Enabled = false;

                    dtpHoraIni.Enabled = false;
                    dtpHoraFin.Enabled = false;

                    btnBuscarDocente.Enabled = false;

                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnModificar.Enabled = false;

                    cboDescuentos.Enabled = false;

                    gbPago.Visible = true;

                    btnPagarAhora.Enabled = false;
                    btnPagarAhora.Visible = false;
                    break;
                case Estado.Nuevo:
                    
                    btnBuscarCliente.Enabled = true;
                    txtNombreServicio.Enabled = true;
                    txtDescripcion.Enabled = true;
                    txtPrecio.Enabled = true;
                    txtObservaciones.Enabled = true;
                    txtDireccion.Enabled = true;
                    cboDistrito.Enabled = true;
                    dtpFechaMatricula.Enabled = true;

                    dtpHoraIni.Enabled = true;
                    dtpHoraFin.Enabled = true;

                    btnBuscarDocente.Enabled = true;
                   

                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnModificar.Enabled = false;
                    cboDescuentos.Enabled = true;

                    gbPago.Visible = true;

                    btnPagarAhora.Enabled = true;
                    btnPagarAhora.Visible = true;
                    break;
                case Estado.Buscar:
                  
                    btnBuscarCliente.Enabled = false;
                    txtNombreServicio.Enabled = false;
                    txtDescripcion.Enabled = false;
                    txtPrecio.Enabled = false;
                    txtObservaciones.Enabled = false;
                    txtDireccion.Enabled = false;
                    cboDistrito.Enabled = false;
                    dtpFechaMatricula.Enabled = false;
                    dtpHoraIni.Enabled = false;
                    dtpHoraFin.Enabled = false;

                    btnBuscarDocente.Enabled = false;

                    btnNuevo.Enabled = false;
                    btnModificar.Enabled = true;
                    btnBuscar.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = true;
                    cboDescuentos.Enabled = false;

                    gbPago.Visible = false;

                    btnPagarAhora.Enabled = false;
                    btnPagarAhora.Visible = false;
                    break;
                case Estado.Modificar:
                   
                    btnBuscarCliente.Enabled = true;
                    txtNombreServicio.Enabled = true;
                    txtDescripcion.Enabled = true;
                    txtPrecio.Enabled = true;
                    txtObservaciones.Enabled = true;
                    txtDireccion.Enabled = true;
                    cboDistrito.Enabled = true;
                    dtpFechaMatricula.Enabled = true;
                    dtpHoraIni.Enabled = true;
                    dtpHoraFin.Enabled = true;

                    btnBuscarDocente.Enabled = true;
                    

                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnModificar.Enabled = false;
                    cboDescuentos.Enabled = false;

                    gbPago.Visible = false;

                    btnPagarAhora.Enabled = false;
                    btnPagarAhora.Visible = false;
                    break;
            }
        }


        public bool verificarCampos()
        {
            float i;
            if (txtNombreServicio.Text.Equals("") || txtDescripcion.Text.Equals("") || txtPrecio.Text.Equals("") ||
               txtDireccion.Text.Equals("") || cboDistrito.SelectedIndex == -1)
            {
                frmMensaje mensaje = new frmMensaje("Todos los campos son obligatorios", "", "");
               if(mensaje.ShowDialog() == DialogResult.OK) return false;
            }
            if(float.TryParse(txtPrecio.Text, out i))
            {
                if(i <= 0)
                {
                    frmMensaje mensaje = new frmMensaje("El precio debe ser mayor a cero", "", "");
                    if(mensaje.ShowDialog() == DialogResult.OK) return false;
                }
            }
            else
            {
                frmMensaje mensaje = new frmMensaje("TDebe ingresar un precio válido", "", "");
                if(mensaje.ShowDialog() == DialogResult.OK) return false;
            }
            if (dtpHoraIni.Value > dtpHoraFin.Value)
            {
                frmMensaje mensaje = new frmMensaje("El horario tiene una hora de inicio mayor a la hora final", "Error de Servicio", "");
                if(mensaje.ShowDialog() == DialogResult.OK) return false;
            }
            int horaIni = dtpHoraIni.Value.Hour * 100 + dtpHoraIni.Value.Minute;
            int horaFin = dtpHoraFin.Value.Hour * 100 + dtpHoraFin.Value.Minute;
            if (horaFin - horaIni > 300 | horaFin - horaIni < 130)
            {
                frmMensaje mensaje = new frmMensaje("La duración de la clase particular debe ser de mínimo 2hrs y máximo 3 hrs", "Error de Servicio", "");
                if(mensaje.ShowDialog() == DialogResult.OK) return false;
            }

            return true;
        }
        public frmGestionarClaseParticular()
        {
            InitializeComponent();
            Formateador f = new Formateador();
            f.iniFormFreddyGestionar(this, "Clase Particular", pnlCtn, btnNuevo, btnBuscar, btnGuardar, btnModificar, btnCancelar, false);
            f.formatearBotonListar(btnBuscarCliente);
            f.formatearBotonListar(btnBuscarDocente);
            f.formatearBotonLila(btnPagarAhora);
            limpiarComponentes();
            descuentos = Program.dbController.listarDescuentos();
            if(descuentos != null)
            {
                cboDescuentos.DataSource = descuentos;
                cboDescuentos.DisplayMember = "Nombre";
            }
            
            //limpiarComponentes();
            estadoComponentes(Estado.Inicial);
            
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmBuscarCliente formBuscarCliente = new frmBuscarCliente(false);
            if (formBuscarCliente.ShowDialog() == DialogResult.OK)
            {
                cliente = formBuscarCliente.ClienteSeleccionado;
                txtDNICliente.Text = cliente.dni;
                txtNombreCliente.Text = cliente.nombre;
            }
            
        }

        private void btnBuscarDocente_Click(object sender, EventArgs e)
        {
            frmBuscarDocente formBuscarDocente = new frmBuscarDocente(false);
            if (formBuscarDocente.ShowDialog() == DialogResult.OK)
            {
                docente = formBuscarDocente.DocenteSeleccionado;
                txtDNIDocente.Text = docente.dni;
                txtNombreDocente.Text = docente.nombre;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarComponentes();
            estadoObjColab = Estado.Nuevo;
            estadoComponentes(Estado.Nuevo);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarComponentes();
            estadoObjColab = Estado.Inicial;
            estadoComponentes(Estado.Inicial);

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            estadoObjColab = Estado.Modificar;
            estadoComponentes(Estado.Modificar);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarClaseParticular formBuscarClaseParticular = new frmBuscarClaseParticular();
            if(formBuscarClaseParticular.ShowDialog() == DialogResult.OK)
            {
                limpiarComponentes();
                cp = formBuscarClaseParticular.ClaseSeleccionada;
                cliente = formBuscarClaseParticular.Cliente;

                txtDNICliente.Text = cliente.dni;
                txtNombreCliente.Text = cliente.nombre;
                txtNombreServicio.Text = cp.nombre;
                txtDescripcion.Text = cp.descripcion;
                txtPrecio.Text = cp.precio.ToString();
                txtObservaciones.Text = cp.observaciones;
                txtDireccion.Text = cp.direccion;
                
                cboDistrito.SelectedItem = cp.distrito;

                dtpFechaMatricula.Value = cp.fecha;

                dtpHoraIni.Value = cp.horaIni;
                dtpHoraFin.Value = cp.horaFin;

                txtDNIDocente.Text = cp.colaborador.dni;
                txtNombreDocente.Text = cp.colaborador.nombre;

                estadoComponentes(Estado.Buscar);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int idClase;
            
            if(cliente != null)
                mat.cliente = cliente;
            else
            {
                frmMensaje m1 = new frmMensaje("Debe seleccionar un cliente", "Error de CLIENTE", ""); if (m1.ShowDialog() == DialogResult.OK) { }
                return;
            }

           
            mat.fecha = DateTime.Today;
            mat.fechaSpecified = true;


            if (!verificarCampos())
                return;

            //clase particular
            
            cp.colaborador = docente;

            cp.nombre = txtNombreServicio.Text;
            cp.descripcion = txtDescripcion.Text;
            cp.direccion = txtDireccion.Text;

            cp.distrito = cboDistrito.SelectedItem.ToString();
            

            if(dtpFechaMatricula.Value >= DateTime.Today)
            {
                cp.fecha = dtpFechaMatricula.Value;
                cp.fechaSpecified = true;
            }
            else
            {
                frmMensaje m1 = new frmMensaje("Campo fecha debe ser posterior a hoy", "Error de FECHA", ""); if (m1.ShowDialog() == DialogResult.OK) { }
                return;
            }

            //se debe revisar la hora en el DateTime
            cp.horaIni = dtpHoraIni.Value;
            cp.horaFin = dtpHoraFin.Value;

            cp.horaFinSpecified = true;
            cp.horaIniSpecified = true;


            

            cp.observaciones = txtObservaciones.Text;


            cp.precio = float.Parse(txtPrecio.Text);


            mat.descuento = (Service.descuento)cboDescuentos.SelectedItem;
            mat.monto = float.Parse(txtTotal.Text);



            if (cp.id_servicio == 0)
            {
                idClase = Program.dbController.insertarClaseParticular(cp);
                cp.id_servicio = idClase;

                mat.servicio = cp;
                Program.dbController.insertarMatricula(mat);

                frmMensaje mensaje = new frmMensaje("Clase Particular registrada", "Mensaje de confirmación", ""); if (mensaje.ShowDialog() == DialogResult.OK) { }

            } else
            {
                Program.dbController.actualizarClaseParticular(cp);
                frmMensaje mensaje = new frmMensaje("Clase Particular actualizada", "Mensaje de confirmación", ""); if (mensaje.ShowDialog() == DialogResult.OK) { }
            }

            limpiarComponentes();
            estadoComponentes(Estado.Inicial);
        }

        private void btnPagarAhora_Click(object sender, EventArgs e)
        {
            float p;

            if (float.TryParse(txtPrecio.Text, out p))
            {
                if (p <= 0)
                {
                    frmMensaje mensaje = new frmMensaje("Ingrese una cantidad numérica mayor a cero", "Error de precio", ""); if (mensaje.ShowDialog() == DialogResult.OK) { }
                    txtPrecio.Text = "";
                    return;
                }
            }else
            {
                frmMensaje mensaje = new frmMensaje("Ingrese una cantidad numérica mayor a cero", "Error de precio", ""); if (mensaje.ShowDialog() == DialogResult.OK) { }
                txtPrecio.Text = "";
                return;
            }


            frmPagoMat formPagoMat = new frmPagoMat(mat);
            if(formPagoMat.ShowDialog() == DialogResult.OK)
            {
                if(formPagoMat.Cuota != null)
                {
                    cuotas = new BindingList<Service.cuota>();
                    cuotas.Add(formPagoMat.Cuota);
                    mat.cuotas = cuotas.ToArray();
                }
                txtSaldo.Text = (float.Parse(txtSaldo.Text) - formPagoMat.Cuota.monto).ToString();
                

                mat.saldo = float.Parse(txtSaldo.Text);
            }

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            float p;
            if (float.TryParse(txtPrecio.Text, out p))
            {
                txtTotal.Text = txtPrecio.Text;
            }
            else
            {
                frmMensaje mensaje = new frmMensaje("Ingrese una cantidad numérica mayor a cero", "Error de precio", ""); if (mensaje.ShowDialog() == DialogResult.OK) { }
                txtPrecio.Text = "";
                txtSaldo.Text = "0";
                txtTotal.Text = "0";
            }
            cboDescuentos.SelectedIndex = -1;

        }



        private void cboDescuentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Service.descuento d = (Service.descuento)cboDescuentos.SelectedItem;
            float t;

            if (float.TryParse(txtPrecio.Text, out t))
            {
                if(d != null)
                {
                    t = (float.Parse(txtPrecio.Text) * (100 - d.porcentaje) / 100);
                } else
                {
                    t = float.Parse(txtPrecio.Text);
                    
                }
                
                txtTotal.Text = t.ToString();
            }
            else
            {
                frmMensaje mensaje = new frmMensaje("Ingrese un precio válido", "Error de precio", ""); if (mensaje.ShowDialog() == DialogResult.OK) { }
                cboDescuentos.SelectedIndex = -1;
                txtSaldo.Text = "0";
                txtTotal.Text = "0";
            }

           

            
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            txtSaldo.Text = txtTotal.Text;
            mat.monto = float.Parse(txtTotal.Text);
            //mat.saldo = float.Parse(txtSaldo.Text);
        }
    }
}
