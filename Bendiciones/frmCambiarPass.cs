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
    public partial class frmCambiarPass : Form
    {
        private Service.colaborador colaborador;
        private Form padre;
        public frmCambiarPass(Service.colaborador colab,Form ventana)
        {
            InitializeComponent();
            Formateador f = new Formateador();
            Paleta colores = new Paleta();
            pnlTitulo.BackColor = colores.Naranja;
            pnlFill.BackColor = colores.Blanco;
            f.formatearBotonNaranja(btnConfirmar);
            btnConfirmar.Left = txtRepetir.Left + txtRepetir.Width - 85;
            lblCoinciden.Visible = false;
            colaborador = colab;
            padre = ventana;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void txtRepetir_TextChanged(object sender, EventArgs e)
        {
            if(txtRepetir.Text.Length == 0)
            {
                lblCoinciden.Visible = false;
            }

            if (!txtNueva.Text.Equals(txtRepetir.Text))
                lblCoinciden.Visible = true;
            else
                lblCoinciden.Visible = false;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if(txtActual.Text.Equals("") || txtNueva.Text.Equals("") || txtRepetir.Text.Equals(""))
            {
                frmMensaje msj = new frmMensaje("Complete todos los campos", "", "");
                if (msj.ShowDialog() == DialogResult.OK) return;
                return;
            }

            if (!txtActual.Text.Equals(colaborador.password))
            {
                frmMensaje msj = new frmMensaje("Contraseña actual incorrecta","", "");
                if (msj.ShowDialog() == DialogResult.OK) return;
                return;
            }
            
            frmMensaje mensaje1 = new frmMensaje("Seguro que desea continuar?","","Confirmar"); 
            if(mensaje1.ShowDialog() == DialogResult.OK)
            {
                colaborador.password = txtNueva.Text;
                Program.dbController.actualizarColaborador(colaborador);
                frmMensaje mensaje2 = new frmMensaje("Cambio de Contraseñas exitoso", "","Confirmar"); 
                if (mensaje2.ShowDialog() == DialogResult.OK)
                {
                    this.Close();
                    Correo c = new Correo();
                    c.CambiarPass(colaborador);
                    padre.Hide();
                    
                }
                FormLogin login = new FormLogin();
                login.Show();
            }
            
        }
    }
}
