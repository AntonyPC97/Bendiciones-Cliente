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
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();

        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            if (cboMeses.SelectedIndex != -1 & cboYears.SelectedIndex != -1) {
                saveFileDialog1.ShowDialog();
                byte[] arreglo
                    = Program.dbController.generarReporteServicioPDF(cboMeses.SelectedIndex + 1, Int32.Parse((String)cboYears.SelectedItem));
                File.WriteAllBytes(saveFileDialog1.FileName
                    + ".pdf", arreglo);
            }
            else
            {
                MessageBox.Show("Todos los campos son obligatorios", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
