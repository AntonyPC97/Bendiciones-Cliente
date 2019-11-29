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
    public partial class frmAsignarHorario : Form
    {
        private Service.curso curso;
        private BindingList<Service.horario> horarios = new BindingList<Service.horario>();
        private Service.horario horario;
        private List<Service.asistencia> asist= new List<Service.asistencia>();
        public frmAsignarHorario()
        {
            InitializeComponent();
            Formateador f = new Formateador();
            dgvHorarios.RowCount = 0;
            f.formatearBotonListar(btnbuscarCurso);
            f.formAsignarHorario(this,"Asignar Horario",pnlCtn,gbCurso,btnAddHorario,btnEliminarHorario,dgvHorarios,btnGuardar);
        }

        private void btnbuscarCurso_Click(object sender, EventArgs e)
        {
            dgvHorarios.Rows.Clear();
            horarios = new BindingList<Service.horario>();
            //dgvHorarios.RowCount = 0;
            frmBuscarCurso formBuscarCurso = new frmBuscarCurso(false);
            if (formBuscarCurso.ShowDialog() == DialogResult.OK)
            {
                curso = formBuscarCurso.CursoSeleccionado;
                txtNombreServicio.Text = curso.nombre;


                if (Program.dbController.listarHorariosPorCurso(curso.id_servicio) != null)
                {
                    foreach (Service.horario h in Program.dbController.listarHorariosPorCurso(curso.id_servicio))
                    {
                        Service.asistencia a = new Service.asistencia();
                        a.horario = h;
                       
                        horarios.Add(h);
                        Object[] filaHorario = new Object[7];
                        filaHorario[0] = h.clase;
                        filaHorario[1] = h.horaIni.ToShortTimeString();
                        filaHorario[2] = h.horaFin.ToShortTimeString();
                        if (h.colaborador.idPersona != 0)
                        {
                            filaHorario[3] = h.colaborador.nombre;
                            a.persona = h.colaborador;
                        }

                        else
                        {
                            filaHorario[3] = "-";
                        }
                            
                        filaHorario[4] = h.fecha.ToShortDateString();
                        filaHorario[5] = h.sede.direccion;
                        filaHorario[6] = h.numVacantes;
                        dgvHorarios.Rows.Add(filaHorario);
                        asist.Add(a);
                    }
                }


            }

        }

        private void btnAddHorario_Click(object sender, EventArgs e)
        {
            if (curso == null)
            {
                frmMensaje mensaje = new frmMensaje("Seleccione un curso", "Error", ""); if (mensaje.ShowDialog() == DialogResult.OK) { }
                return;
            }
            frmGestionarHorario formGestionarHorario = new frmGestionarHorario(curso);
            if (formGestionarHorario.ShowDialog() == DialogResult.OK)
            {
                horario = formGestionarHorario.HorarioSeleccionado;
                Service.asistencia a = new Service.asistencia();
                horarios.Add(horario);
                Object[] filaHorario = new Object[7];
                filaHorario[0] = horario.clase;
                filaHorario[1] = horario.horaIni.ToShortTimeString();
                filaHorario[2] = horario.horaFin.ToShortTimeString();
                if (horario.colaborador !=null)
                    filaHorario[3] = horario.colaborador.nombre;
                else
                    filaHorario[3] = "-";

                filaHorario[4] = horario.fecha.ToShortDateString();
                filaHorario[5] = horario.sede.direccion;
                filaHorario[6] = horario.numVacantes;
                dgvHorarios.Rows.Add(filaHorario);
            }
        }

        private void btnEliminarHorario_Click(object sender, EventArgs e)
        {
            if (curso == null)
            {
                frmMensaje mensaje = new frmMensaje("Seleccione un curso", "Error", ""); if (mensaje.ShowDialog() == DialogResult.OK) { }
                return;
            }
            frmMensaje dr = new frmMensaje("Seguro que quiere eliminar horario?","","Confirmar");
            if (dr.ShowDialog() == DialogResult.OK) { 
                if (dr.DialogResult == DialogResult.OK)
                {
                    horario = horarios[dgvHorarios.CurrentRow.Index];
                    horarios.Remove(horario);
                    dgvHorarios.Rows.Remove(dgvHorarios.CurrentRow);
                }
                else if (dr.DialogResult == DialogResult.Cancel)
                {
                    return;
                }
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
             if (curso == null)
            {
                frmMensaje mensaje = new frmMensaje("Seleccione un curso", "Error", ""); if (mensaje.ShowDialog() == DialogResult.OK) { }
                return;
            }
             foreach(Service.asistencia a in asist)
            {
                Program.dbController.eliminarAsistencia(a);
            }
            foreach (Service.horario h in horarios)
            {
                if (h.idHorario != 0)
                {
                    //Console.WriteLine(h.colaborador.idPersona);
                    Program.dbController.actualizarHorario(h);
                }
                else
                {
                    Program.dbController.insertarHorario(h, curso.id_servicio);
                }
            }
            frmMensaje mensaje1 = new frmMensaje("Cambios realizados", "Mensaje de confirmación","Confirmar"); if(mensaje1.ShowDialog() == DialogResult.OK){};
        }

        private void dgvHorarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvHorarios.CurrentRow.Index;
            horario = horarios[index];
            //Console.WriteLine(horario.idHorario+horario.numVacantes);
            frmGestionarHorario formGestionarHorario = new frmGestionarHorario(horario,curso);
            if (formGestionarHorario.ShowDialog() == DialogResult.OK)
            {
                horarios[index] = formGestionarHorario.HorarioSeleccionado;
                //Console.WriteLine(horarios[index].idHorario+ horarios[index].numVacantes);
                DataGridViewRow row = dgvHorarios.CurrentRow;
                row.Cells[0].Value = horarios[index].clase;
                row.Cells[1].Value = horarios[index].horaIni.ToShortTimeString();
                row.Cells[2].Value = horarios[index].horaFin.ToShortTimeString();
                if (horario.colaborador != null)
                    row.Cells[3].Value = horarios[index].colaborador.nombre;
                else
                    row.Cells[3].Value = '-';
                row.Cells[4].Value = horarios[index].fecha.ToShortDateString();
                row.Cells[5].Value = horarios[index].sede.direccion;
                row.Cells[6].Value = horarios[index].numVacantes;
            }

        }
    }
}
