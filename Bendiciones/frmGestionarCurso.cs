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
    public partial class frmGestionarCurso : Form
    {
        private Service.curso curso= new Service.curso();
        Estado estadoObjCur;
        public frmGestionarCurso()
        {
            InitializeComponent();
            dgvCondiciones.AutoGenerateColumns = false;
            dgvCondiciones.DataSource = Program.dbController.listarCondMedicasPorNombre("");
            Formateador f = new Formateador();
            f.iniFormFreddyGestionar(this, "Gestionar Curso", pnlCtn,btnNuevo,btnBuscar, btnGuardar, btnModificar, btnCancelar,false);
			limpiarComponentes();
			estadoComponentes(Estado.Inicial);
        }

        public void estadoComponentes(Estado estado)
        {
            switch (estado)
            {
                case Estado.Inicial:
                    txtNombreCurso.Enabled = false;
                    txtDescripcion.Enabled = false;
                    txtPrecio.Enabled = false;
                    udNumClases.Enabled = false;
					dgvCondiciones.Enabled = false;

					btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnModificar.Enabled = false;
                    break;
				case Estado.Nuevo:
					txtNombreCurso.Enabled = true;
					txtDescripcion.Enabled = true;
					txtPrecio.Enabled = true;
					udNumClases.Enabled = true;
					dgvCondiciones.Enabled = true;

					btnNuevo.Enabled = false;
					btnGuardar.Enabled = true;
					btnCancelar.Enabled = true;
					btnBuscar.Enabled = false;
					btnModificar.Enabled = false;
					break;
                case Estado.Buscar:
                    txtNombreCurso.Enabled = false;
                    txtDescripcion.Enabled = false;
                    txtPrecio.Enabled = false;
                    udNumClases.Enabled = false;
					dgvCondiciones.Enabled = false;

					btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = true;
                    btnModificar.Enabled = true;
                    break;
                case Estado.Modificar:
                    txtNombreCurso.Enabled = true;
                    txtDescripcion.Enabled = true;
                    txtPrecio.Enabled = true;
                    udNumClases.Enabled = true;
					dgvCondiciones.Enabled = true;

					btnNuevo.Enabled = false;
					btnGuardar.Enabled = true;
					btnCancelar.Enabled = true;
					btnBuscar.Enabled = false;
					btnModificar.Enabled = false;
					break;
            }
        }
		public void limpiarComponentes()
		{
			txtNombreCurso.Text = "";
			txtDescripcion.Text = "";
			txtPrecio.Text = "";
			dgvCondiciones.AutoGenerateColumns = false;
			dgvCondiciones.DataSource = Program.dbController.listarCondMedicasPorNombre("");
		}

		public bool verificarCampos()
		{
			
			float i;
			if (txtNombreCurso.Text.Equals("")|| txtDescripcion.Text.Equals("") || txtPrecio.Text.Equals(""))
			{
				frmMensaje mensaje = new frmMensaje("Todos los campos son obligatorios", "Error de campos","Confirmar"); 
				if(mensaje.ShowDialog() == DialogResult.OK) return false;
			}
			if(!float.TryParse(txtPrecio.Text,out i))
			{
				frmMensaje mensaje = new frmMensaje("Añada un precio válido", "Error en Precio", "");
				if(mensaje.ShowDialog() == DialogResult.OK) return false;
			}
			
			return true;
		}
        private void btnGuardar_Click(object sender, EventArgs e)
        {
			if (verificarCampos())
			{
				curso.nombre = txtNombreCurso.Text;
				curso.numClases = (int)udNumClases.Value;
				curso.precio = float.Parse(txtPrecio.Text);
				curso.descripcion = txtDescripcion.Text;

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
				curso.condMedicas = condicionMedicas.ToArray<Service.condicionMedica>();
				if (estadoObjCur == Estado.Nuevo)
				{
					Program.dbController.insertarCurso(curso);
					frmMensaje mensaje = new frmMensaje("Curso Registrado exitosamente", "Mensaje Confirmacion", "Confirmar");   if(mensaje.ShowDialog() == DialogResult.OK){};
				}
				else if (estadoObjCur == Estado.Modificar)
				{
					Program.dbController.actualizarCurso(curso);
					frmMensaje mensaje = new frmMensaje("Se han actualizado los datos", "Mensaje Confirmacion", "Confirmar");   if(mensaje.ShowDialog() == DialogResult.OK){};
				}
				limpiarComponentes();
				estadoComponentes(Estado.Inicial);
			}
			

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
			limpiarComponentes();
			estadoComponentes(Estado.Inicial);  
        }

        private void dgvCondiciones_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Service.condicionMedica conFila = (Service.condicionMedica)dgvCondiciones.Rows[e.RowIndex].DataBoundItem;
            if(conFila != null)
                dgvCondiciones.Rows[e.RowIndex].Cells["Nombre"].Value = conFila.nombre;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarCurso formCurso = new frmBuscarCurso(true);
            if (formCurso.ShowDialog() == DialogResult.OK)
            {
                curso = formCurso.CursoSeleccionado;
                txtNombreCurso.Text = curso.nombre;
                txtDescripcion.Text = curso.descripcion;
                txtPrecio.Text = curso.precio.ToString("0.0");
                udNumClases.Value = curso.numClases;
                dgvCondiciones.DataSource = curso.condMedicas;
                for (int i = 0; i < dgvCondiciones.RowCount; i++)
                    dgvCondiciones.Rows[i].Cells[1].Value = true;
				estadoComponentes(Estado.Buscar);
			}
			else
			{
				limpiarComponentes();
				estadoComponentes(Estado.Inicial);
			}
        }

		private void btnModificar_Click(object sender, EventArgs e)
		{
			estadoObjCur = Estado.Modificar;
            dgvCondiciones.DataSource = Program.dbController.listarCondMedicasPorNombre("");
			foreach(Service.condicionMedica con in curso.condMedicas){
				for (int i = 0; i < dgvCondiciones.RowCount; i++){
					if (con.nombre.Equals(((Service.condicionMedica)dgvCondiciones.Rows[i].DataBoundItem).nombre)){
						dgvCondiciones.Rows[i].Cells[1].Value = true;
						i = dgvCondiciones.RowCount;
					}
				}
			}
			estadoComponentes(Estado.Modificar);
		}

		private void btnNuevo_Click(object sender, EventArgs e)
		{
			estadoObjCur = Estado.Nuevo;
			estadoComponentes(Estado.Nuevo);
		}
	}
}
