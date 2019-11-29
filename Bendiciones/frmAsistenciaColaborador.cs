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
    public partial class frmAsistenciaColaborador : Form
    {
        private BindingList<Service.asistencia> asistencias = new BindingList<Service.asistencia>();
        private BindingList<Service.asistencia> asistenciasReg = new BindingList<Service.asistencia>();
        private Service.colaborador colab;
        private IEnumerable<Service.curso> cursos;
        private IEnumerable<Service.curso> cursosAsis;
        List<Service.curso> data = new List<Service.curso>();
        public frmAsistenciaColaborador()
        {
            InitializeComponent();
            Formateador f = new Formateador();
            f.iniFormAsistencia(this,"Asistencia de Colaborador",pnlCtn,btnRegistrar, btnBuscar);
            dgvPorAsistir.ClearSelection();
            //dgvPorAsistir.
            dgvYaAsistieron.ClearSelection();
            cboCursos.SelectedIndexChanged -= new EventHandler(cboCursos_SelectedIndexChanged);
            IEnumerable<Service.curso> dataSource = Program.dbController.listarCursosPorNombre("");
            if (dataSource != null)
            {
                Service.curso cu = new Service.curso();
                cu.nombre = "Todos";
                data.Add(cu);
                data.AddRange(dataSource.ToList());
                cboCursos.DataSource = data;
            }
            else
                cboCursos.DataSource = dataSource;
            cboCursos.DisplayMember = "Nombre";
            cboCursos.SelectedIndexChanged += new EventHandler(cboCursos_SelectedIndexChanged);
            cursos = Program.dbController.listarDocentesDelDia();
            asistencias.Clear();
            if(cursos != null)
            {
                foreach (Service.curso c in cursos)
                {
                    if(c.horario != null)
                    {
                        foreach (Service.horario h in c.horario)
                        {
                            Object[] fila = new Object[5];
                            fila[0] = h.colaborador.dni;
                            fila[1] = h.colaborador.nombre;
                            fila[2] = c.nombre;
                            fila[3] = h.horaIni.ToShortTimeString();
                            fila[4] = h.horaFin.ToShortTimeString();
                            dgvPorAsistir.Rows.Add(fila);
                            Service.asistencia a = new Service.asistencia();
                            a.horario = h;
                            a.persona = h.colaborador;
                            asistencias.Add(a);
                        }
                    }
                }
            }
            cursosAsis = Program.dbController.listarDocentesYaAsistieron();
            asistenciasReg.Clear();
            if (cursosAsis != null)
            {
                foreach (Service.curso c in cursosAsis)
                {
                    if (c.horario != null)
                    {
                        foreach (Service.horario h in c.horario)
                        {
                            Object[] fila = new Object[5];
                            fila[0] = h.colaborador.dni;
                            fila[1] = h.colaborador.nombre;
                            fila[2] = c.nombre;
                            fila[3] = h.horaIni.ToShortTimeString();
                            fila[4] = h.horaFin.ToShortTimeString();
                            dgvYaAsistieron.Rows.Add(fila);
                            Service.asistencia a = new Service.asistencia();
                            a.horario = h;
                            a.persona = h.colaborador;
                            asistenciasReg.Add(a);
                        }
                    }
                }
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {   
            
            if (asistencias.Any())
            {
                Service.asistencia a = asistencias[dgvPorAsistir.CurrentRow.Index];
                a.asistio = true;
                asistencias.RemoveAt(dgvPorAsistir.CurrentRow.Index);
                Program.dbController.actualizarAsistencia(a);
                Object[] fila = new Object[5];
                fila[0] = dgvPorAsistir.CurrentRow.Cells[0].Value;
                fila[1] = dgvPorAsistir.CurrentRow.Cells[1].Value;
                fila[2] = dgvPorAsistir.CurrentRow.Cells[2].Value;
                fila[3] = dgvPorAsistir.CurrentRow.Cells[3].Value;
                fila[4] = dgvPorAsistir.CurrentRow.Cells[4].Value;
                dgvYaAsistieron.Rows.Add(fila);
                dgvPorAsistir.Rows.RemoveAt(dgvPorAsistir.CurrentRow.Index);
                asistenciasReg.Add(a);

                frmMensaje mensaje = new frmMensaje("Asistencia registrada", "Mensaje de confirmación","Confirmar");if(mensaje.ShowDialog() == DialogResult.OK){};
            }
            else
            {
                frmMensaje mensaje = new frmMensaje("No hay asistentes el día de hoy", "Mensaje de error", ""); if (mensaje.ShowDialog() == DialogResult.OK) { }
            }
            txtDni.Text = "";
            cboCursos_SelectedIndexChanged(sender, e);
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void txtDni_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!txtDni.Text.Equals(""))
                {
                    foreach (DataGridViewRow r in dgvPorAsistir.Rows)
                    {
                        if (!r.Cells[0].Value.Equals(txtDni.Text))
                            r.Visible = false;
                    }

                    foreach (DataGridViewRow r in dgvYaAsistieron.Rows)
                    {
                        if (!r.Cells[0].Value.Equals(txtDni.Text))
                            r.Visible = false;
                    }
                }
                else
                {
                    cboCursos_SelectedIndexChanged(sender, e);
                }
            }
        }

        private void cboCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvPorAsistir.RowCount = 0;
            dgvYaAsistieron.RowCount = 0;
            if (cboCursos.SelectedIndex != 0)
            {
                cursos = Program.dbController.listarDocentesDelDiaPorCurso(((Service.curso)cboCursos.SelectedItem).id_servicio);
                asistencias.Clear();
                if (cursos != null)
                {
                    foreach (Service.curso c in cursos)
                    {
                        if (c.horario != null)
                        {
                            foreach (Service.horario h in c.horario)
                            {
                                Object[] fila = new Object[5];
                                fila[0] = h.colaborador.dni;
                                fila[1] = h.colaborador.nombre;
                                fila[2] = c.nombre;
                                fila[3] = h.horaIni.ToShortTimeString();
                                fila[4] = h.horaFin.ToShortTimeString();
                                dgvPorAsistir.Rows.Add(fila);
                                Service.asistencia a = new Service.asistencia();
                                a.horario = h;
                                a.persona = h.colaborador;
                                asistencias.Add(a);
                            }
                        }
                    }
                }
                cursosAsis = Program.dbController.listarDocentesYaAsistieronPorCurso(((Service.curso)cboCursos.SelectedItem).id_servicio);
                asistenciasReg.Clear();
                if (cursosAsis != null)
                {
                    foreach (Service.curso c in cursosAsis)
                    {
                        if (c.horario != null)
                        {
                            foreach (Service.horario h in c.horario)
                            {
                                Object[] fila = new Object[5];
                                fila[0] = h.colaborador.dni;
                                fila[1] = h.colaborador.nombre;
                                fila[2] = c.nombre;
                                fila[3] = h.horaIni.ToShortTimeString();
                                fila[4] = h.horaFin.ToShortTimeString();
                                dgvYaAsistieron.Rows.Add(fila);
                                Service.asistencia a = new Service.asistencia();
                                a.horario = h;
                                a.persona = h.colaborador;
                                asistenciasReg.Add(a);
                            }
                        }
                    }
                }
            }
            else
            {
                cursos = Program.dbController.listarDocentesDelDia();
                asistencias.Clear();
                if (cursos != null)
                {
                    foreach (Service.curso c in cursos)
                    {
                        if (c.horario != null)
                        {
                            foreach (Service.horario h in c.horario)
                            {
                                Object[] fila = new Object[5];
                                fila[0] = h.colaborador.dni;
                                fila[1] = h.colaborador.nombre;
                                fila[2] = c.nombre;
                                fila[3] = h.horaIni.ToShortTimeString();
                                fila[4] = h.horaFin.ToShortTimeString();
                                dgvPorAsistir.Rows.Add(fila);
                                Service.asistencia a = new Service.asistencia();
                                a.horario = h;
                                a.persona = h.colaborador;
                                asistencias.Add(a);
                            }
                        }
                    }
                }
                cursosAsis = Program.dbController.listarDocentesYaAsistieron();
                asistenciasReg.Clear();
                if (cursosAsis != null)
                {
                    foreach (Service.curso c in cursosAsis)
                    {
                        if (c.horario != null)
                        {
                            foreach (Service.horario h in c.horario)
                            {
                                Object[] fila = new Object[5];
                                fila[0] = h.colaborador.dni;
                                fila[1] = h.colaborador.nombre;
                                fila[2] = c.nombre;
                                fila[3] = h.horaIni.ToShortTimeString();
                                fila[4] = h.horaFin.ToShortTimeString();
                                dgvYaAsistieron.Rows.Add(fila);
                                Service.asistencia a = new Service.asistencia();
                                a.horario = h;
                                a.persona = h.colaborador;
                                asistenciasReg.Add(a);
                            }
                        }
                    }
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!txtDni.Text.Equals(""))
            {
                asistencias.Clear();
                asistenciasReg.Clear();
                foreach (DataGridViewRow r in dgvPorAsistir.Rows)
                {
                    if (!r.Cells[0].Value.Equals(txtDni.Text))
                        r.Visible = false;
                }

                foreach (DataGridViewRow r in dgvYaAsistieron.Rows)
                {
                    if (!r.Cells[0].Value.Equals(txtDni.Text))
                        r.Visible = false;
                }
            }
            else
            {
                cboCursos_SelectedIndexChanged(sender, e);
            }
        }

        private void dgvPorAsistir_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnRegistrar_Click(sender, e);
        }

        private void dgvYaAsistieron_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (asistenciasReg.Any())
            {
                Object[] fila = new Object[5];
                fila[0] = dgvYaAsistieron.CurrentRow.Cells[0].Value;
                fila[1] = dgvYaAsistieron.CurrentRow.Cells[1].Value;
                fila[2] = dgvYaAsistieron.CurrentRow.Cells[2].Value;
                fila[3] = dgvYaAsistieron.CurrentRow.Cells[3].Value;
                fila[4] = dgvYaAsistieron.CurrentRow.Cells[4].Value;

                frmMensaje mensaje = new frmMensaje("¿Está seguro de desmarcar la asistencia de " + fila[1] + "?", "Mensaje de confirmación", "Confirmar");
                if (mensaje.ShowDialog() == DialogResult.OK)
                {
                    Service.asistencia a = asistenciasReg[dgvYaAsistieron.CurrentRow.Index];
                    a.asistio = false;
                    Program.dbController.actualizarAsistencia(a);
                    dgvPorAsistir.Rows.Add(fila);
                    asistencias.Add(a);
                    asistenciasReg.RemoveAt(dgvYaAsistieron.CurrentRow.Index);
                    dgvYaAsistieron.Rows.RemoveAt(dgvYaAsistieron.CurrentRow.Index);
                    
                }

            }
        }
    }
}
