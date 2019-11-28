using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bendiciones
{
    public partial class frmReportesTotal : Form
    {

        private Service.curso curso;
        private BindingList<Service.horario> horarios = new BindingList<Service.horario>();

        public frmReportesTotal()
        {
            InitializeComponent();
            Formateador f = new Formateador();
            f.formReportes(this, "Reportes", pnlCtn);
            f.formatearBotonNaranja(btnAsistenciaCurso);
            f.formatearBotonNaranja(btnAsistenciaHorario);
            f.formatearBotonNaranja(btnMonto);
            f.formatearBotonListar(btnbuscarCurso);

        }

        private void btnMonto_Click(object sender, EventArgs e)
        {
            if (cboMesesMonto.SelectedIndex != -1 & cboYearsMonto.SelectedIndex != -1)
            {
                saveFileDialog1.ShowDialog();
                byte[] arreglo
                    = Program.dbController.generarReporteServicioPDF(cboMesesMonto.SelectedIndex + 1, Int32.Parse((String)cboYearsMonto.SelectedItem));
                File.WriteAllBytes(saveFileDialog1.FileName
                    + ".pdf", arreglo);
            }
            else
            {
                frmMensaje mensaje = new frmMensaje("Todos los campos son obligatorios", "Mensaje de advertencia", "");
            }
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
                        horarios.Add(h);
                        Object[] filaHorario = new Object[7];
                        filaHorario[0] = h.clase;
                        filaHorario[1] = h.horaIni.ToShortTimeString();
                        filaHorario[2] = h.horaFin.ToShortTimeString();
                        if (h.colaborador.idPersona != 0)
                        {
                            filaHorario[3] = h.colaborador.nombre;
                        }

                        else
                        {
                            filaHorario[3] = "-";
                        }
                        filaHorario[4] = h.fecha.ToShortDateString();
                        filaHorario[5] = h.sede.direccion;
                        filaHorario[6] = h.numVacantes;
                        dgvHorarios.Rows.Add(filaHorario);
                    }
                }


            }
        }

        private void btnAsistenciaCurso_Click(object sender, EventArgs e)
        {
            if (cboMesesCurso.SelectedIndex != -1 & cboYearsCurso.SelectedIndex != -1)
            {
                saveFileDialog1.ShowDialog();
                byte[] arreglo
                    = Program.dbController.generarReporteAsistenciaPorCursoPDF(cboMesesCurso.SelectedIndex + 1, Int32.Parse((String)cboYearsCurso.SelectedItem));
                File.WriteAllBytes(saveFileDialog1.FileName
                    + ".pdf", arreglo);
            }
            else
            {
                frmMensaje mensaje = new frmMensaje("Todos los campos son obligatorios", "Mensaje de advertencia", "");
            }
        }

        private void btnAsistenciaHorario_Click(object sender, EventArgs e)
        {
            int id;
            if(curso != null)
            {
                if(dgvHorarios.RowCount != 0)
                {
                    id = horarios[dgvHorarios.CurrentRow.Index].idHorario;
                    saveFileDialog1.ShowDialog();
                    byte[] arreglo
                        = Program.dbController.generarReporteAlumnosPorHorarioPDF(horarios[dgvHorarios.CurrentRow.Index].idHorario);
                    File.WriteAllBytes(saveFileDialog1.FileName
                        + ".pdf", arreglo);

                }
                else
                {
                    frmMensaje mensaje = new frmMensaje("No se ha seleccionado un horario", "", "");
                }
            }
            else
            {
                frmMensaje mensaje = new frmMensaje("Seleccione un curso", "", "");
            }


        }
    }
}
