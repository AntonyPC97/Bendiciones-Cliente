﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bendiciones.Service;

namespace Bendiciones
{
    public partial class frmBuscarServicioDeudaPorCliente : Form
    {
        private Service.matricula servMat;
        private List<Service.matricula> matriculas;
        public frmBuscarServicioDeudaPorCliente(Service.cliente c)
        {
            InitializeComponent();
            dgvMatriculas.AutoGenerateColumns = false;
			Formateador f = new Formateador();
			Paleta p = new Paleta();
			this.BackColor = p.Blanco;
			f.formatearBotonNaranja(btnSeleccionar);

			btnSeleccionar.Top = dgvMatriculas.Top + dgvMatriculas.Height + 10;
			btnSeleccionar.Left = dgvMatriculas.Left + dgvMatriculas.Width - 85;

			if (c is Service.apoderado)
            {
                matriculas = Program.dbController.listarMatriculaSaldoPorApoderado(c.idPersona).ToList<Service.matricula>();
            } else
            {
                matriculas = Program.dbController.listarMatriculaSaldoPorGestante(c.idPersona).ToList<Service.matricula>();
            }

            foreach (Service.matricula m in matriculas)
            {
                Object[] fila = new Object[3];
                fila[0] = m.servicio.nombre;
                fila[1] = m.fecha;
                fila[2] = m.saldo;
                dgvMatriculas.Rows.Add(fila);
            }
        }

        public matricula ServMat { get => servMat; set => servMat = value; }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            //ServMat = (Service.matricula)dgvMatriculas.CurrentRow.DataBoundItem;
            servMat = matriculas[dgvMatriculas.CurrentCell.RowIndex];
            this.DialogResult = DialogResult.OK;
        }
    }
}
