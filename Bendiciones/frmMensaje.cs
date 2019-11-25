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
    public partial class frmMensaje : Form
    {
        public frmMensaje(string mensaje, string titulo,string tipo)
        {
            InitializeComponent();
			lblTitulo.Text = titulo;
			lblMensaje.Text = mensaje;
			Formateador f = new Formateador();
			f.formMensaje(pnlTitulo,pnlMensaje,lblTitulo,lblMensaje,btnOk,btnCancelar,tipo);
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Show();

        }

        public void ventanaMensaje(String mensaje) {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
			this.DialogResult = DialogResult.OK;
			this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
