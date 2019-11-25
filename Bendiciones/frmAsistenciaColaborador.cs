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
        private Service.colaborador colab;
        private IEnumerable<Service.curso> cursos;
        private IEnumerable<Service.curso> cursosAsis;
        List<Service.curso> data = new List<Service.curso>();
        public frmAsistenciaColaborador()
        {
            InitializeComponent();
            Formateador f = new Formateador();
            f.iniFormAsistencia(this,"Asistencia de Colaborador",pnlCtn,btnRegistrar);
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

                MessageBox.Show("Asistencia registrada", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Debe seleccionar a un colaborador", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
                                Console.WriteLine("Si");
                            }
                        }
                    }
                }
            }
            else
            {
                cursos = Program.dbController.listarDocentesDelDia();
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
                            }
                        }
                    }
                }
            }
        }
    }
}
