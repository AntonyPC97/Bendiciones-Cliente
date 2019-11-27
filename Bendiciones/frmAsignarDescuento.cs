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
    public partial class frmAsignarDescuento : Form
    {
        
        private Service.curso curso;
        public frmAsignarDescuento()
        {
            Formateador f = new Formateador();
            InitializeComponent();
            f.formAsignarDesc(this,"Asignar Descuento",pnlCtn,gbCurso,btnbuscarCurso,dgvDescuentos,btnGuardar);
            dgvDescuentos.AutoGenerateColumns = false;
            dgvDescuentos.DataSource = Program.dbController.listarDescuentos();
        }

        private void btnbuscarCurso_Click(object sender, EventArgs e)
        {
            frmBuscarCurso formBuscarCurso = new frmBuscarCurso(false);
            if (formBuscarCurso.ShowDialog() == DialogResult.OK)
            {
                curso = formBuscarCurso.CursoSeleccionado;
                txtNombreServicio.Text = curso.nombre;
                dgvDescuentos.DataSource = Program.dbController.listarDescuentos();
                if (curso.desAplicables != null)
                {
                    foreach (Service.descuento des in curso.desAplicables)
                        for (int i = 0; i < dgvDescuentos.Rows.Count; i++)
                            if (des.nombre.Equals(((Service.descuento)dgvDescuentos.Rows[i].DataBoundItem).nombre)){
                                dgvDescuentos.Rows[i].Cells[1].Value = true;
                                i = dgvDescuentos.Rows.Count;
                            }
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            List<Service.descuento> descuentos = new List<Service.descuento>();
            for (int i = 0; i < dgvDescuentos.Rows.Count; i++)
            {
                if (dgvDescuentos.Rows[i].Cells[1].Value == null)
                { }
                else if ((bool)dgvDescuentos.Rows[i].Cells[1].Value == true)
                {
                    Service.descuento des = new Service.descuento();
                    des = (Service.descuento)dgvDescuentos.Rows[i].DataBoundItem;
                    descuentos.Add(des);
                }
            }
            curso.desAplicables = descuentos.ToArray<Service.descuento>();
            Program.dbController.actualizarCurso(curso);
            frmMensaje mensaje = new frmMensaje("Descuentos actualizados", "Mensaje de confirmación", "Confirmar");

        }

        private void dgvDescuentos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Service.descuento data = (Service.descuento)dgvDescuentos.Rows[e.RowIndex].DataBoundItem;
            if (data != null)
                dgvDescuentos.Rows[e.RowIndex].Cells["Nombre"].Value = data.nombre;
        }
    }
}
