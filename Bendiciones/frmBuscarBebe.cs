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
    public partial class frmBuscarBebe : Form
    {
        public frmBuscarBebe()
        {
            InitializeComponent();
            Formateador f = new Formateador();
            f.iniFormFreddyBuscar(this, "Buscar Bebé", "Nombre o DNI:", txtNombre, dgvBebes, btnBuscar, btnSeleccionar,btnEliminar, false, false);
        }
    }
}
