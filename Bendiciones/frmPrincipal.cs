﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;


namespace Bendiciones
{
    public partial class frmPrincipal : Form
    {
        private Form activeForm = null;
        private Service.colaborador colab;
        int btnHeight = 30;
        int btnWidth = 172;


        public frmPrincipal(Service.colaborador colaborador)
        {
            InitializeComponent();

            Paleta paleta = new Paleta();
            pnlTop.BackColor = paleta.GrisOscuro;
            pnlSide.BackColor = paleta.NaranjaOscuro;
            pnlCuenta.BackColor = paleta.NaranjaOscuro;
            lblNombre.Text = colaborador.nombre;
            lblNombre.Left = lblBienvenido.Width - lblNombre.Width;
            estadoInicialBarraLateral();
            colab = colaborador;
            customDesign();
        }

        #region CONFIGURACIONES
        public void estadoInicialBarraLateral()
        {
            Formateador f = new Formateador();

            #region Tamaños
            btnCursos.Height = btnHeight;
            btnCliente.Height = btnHeight;
            btnAdmin.Height = btnHeight;
            btnAsistencia.Height = btnHeight;
            btnPagos.Height = btnHeight;
            btnMatricula.Height = btnHeight;
            btnClasesParticulares.Height = btnHeight;
            btnCursosRegistrar.Height = btnHeight;
            btnAsignarDesc.Height = btnHeight;
            btnSede.Height = btnHeight;
            btnColaborador.Height = btnHeight;
            btnDescuentos.Height = btnHeight;
            btnCondiciones.Height = btnHeight;
            btnAsistenciaCliente.Height = btnHeight;
            btnAsistenciaDocente.Height = btnHeight;
            btnRegitrarCuota.Height = btnHeight;
            btnHistorico.Height = btnHeight;
            btnAsignarHorario.Height = btnHeight;
            btnInscribir.Height = btnHeight;
            btnReportes.Height = btnHeight;


            btnCursos.Width = btnWidth;
            btnCliente.Width = btnWidth;
            btnAdmin.Width = btnWidth;
            btnAsistencia.Width = btnWidth;
            btnPagos.Width = btnWidth;
            btnMatricula.Width = btnWidth;
            btnClasesParticulares.Width = btnWidth;
            btnCursosRegistrar.Width = btnWidth;
            btnAsignarDesc.Width = btnWidth;
            btnSede.Width = btnWidth;
            btnColaborador.Width = btnWidth;
            btnDescuentos.Width = btnWidth;
            btnCondiciones.Width = btnWidth;
            btnAsistenciaCliente.Width = btnWidth;
            btnAsistenciaDocente.Width = btnWidth;
            btnRegitrarCuota.Width = btnWidth;
            btnHistorico.Width = btnWidth;
            btnAsignarHorario.Width = btnWidth;
            btnInscribir.Width = btnWidth;
            btnReportes.Width = btnWidth;
            #endregion

            #region Formato de Botones
            f.formatearBotonMenu(btnCursos);
            f.formatearBotonMenu(btnCliente);
            f.formatearBotonMenu(btnAdmin);
            f.formatearBotonMenu(btnAsistencia);
            f.formatearBotonMenu(btnMatricula);
            f.formatearBotonMenu(btnClasesParticulares);
            f.formatearBotonSubMenu(btnCursosRegistrar);
            f.formatearBotonSubMenu(btnAsignarDesc);
            f.formatearBotonSubMenu(btnSede);
            f.formatearBotonSubMenu(btnColaborador);
            f.formatearBotonSubMenu(btnDescuentos);
            f.formatearBotonSubMenu(btnCondiciones);
            f.formatearBotonSubMenu(btnAsistenciaCliente);
            f.formatearBotonSubMenu(btnAsistenciaDocente);
            f.formatearBotonSubMenu(btnRegitrarCuota);
            f.formatearBotonSubMenu(btnHistorico);
            f.formatearBotonSubMenu(btnAsignarHorario);
            f.formatearBotonMenu(btnPagos);
            f.formatearBotonSubMenu(btnInscribir);
            f.formatearBotonMenu(btnReportes);
            f.formatearBotonSubMenu(btnCerrarSesion);
            f.formatearBotonSubMenu(btnCambiarPass);
            #endregion

        }
        private void customDesign()
        {
            pnlCursos.Visible = false;
            pnlAdmin.Visible = false;
            pnlAsistencia.Visible = false;
            pnlPagos.Visible = false;
            pnlCuenta.Visible = false;
        }

        private void hideSubMenu()
        {
            if (pnlCursos.Visible == true)
                pnlCursos.Visible = false;
            if (pnlPagos.Visible == true)
                pnlPagos.Visible = false;
            if (pnlAsistencia.Visible == true)
                pnlAsistencia.Visible = false;
            if (pnlAdmin.Visible == true)
                pnlAdmin.Visible = false;
            if (pnlCuenta.Visible == true)
                pnlCuenta.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void openChildForm(Form hijo)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = hijo;
            hijo.TopLevel = false;
            hijo.FormBorderStyle = FormBorderStyle.None;
            hijo.Dock = DockStyle.Fill;
            pnlFiller.Controls.Add(hijo);
            pnlFiller.Tag = hijo;
            hijo.BringToFront();
            hijo.Show();
        }
        #endregion

        #region Paneles
        private void btnCursos_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlCursos);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlAdmin);
        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlAsistencia);
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlPagos);
        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlCuenta);
            pnlCuenta.BringToFront();
        }
        #endregion


        #region Abrir Forms
        private void btnClasesParticulares_Click(object sender, EventArgs e)
        {
            frmGestionarClaseParticular formGestionarClase = new frmGestionarClaseParticular();
            openChildForm(formGestionarClase);
            customDesign();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmGestionarCliente formCliente = new frmGestionarCliente();
            openChildForm(formCliente);
            customDesign();
        }
        private void btnCursosRegistrar_Click(object sender, EventArgs e)
        {
            frmGestionarCurso formRegistrarCurso = new frmGestionarCurso();
            openChildForm(formRegistrarCurso);
            customDesign();

        }
        private void btnSede_Click(object sender, EventArgs e)
        {
            frmGestionarSede formGestionarSede = new frmGestionarSede();
            openChildForm(formGestionarSede);
            customDesign();
        }


        private void btnColaborador_Click(object sender, EventArgs e)
        {
            frmGestionarColaboradores formColab = new frmGestionarColaboradores();
            openChildForm(formColab);
            customDesign();
        }

        private void btnDescuentos_Click(object sender, EventArgs e)
        {
            frmGestionarDescuento formDesc = new frmGestionarDescuento();
            openChildForm(formDesc);
            customDesign();
        }

        private void btnCondiciones_Click(object sender, EventArgs e)
        {
            frmGestionarCondicion formCondicion = new frmGestionarCondicion();
            openChildForm(formCondicion);
            customDesign();
        }

        private void btnAsistenciaCliente_Click(object sender, EventArgs e)
        {
            frmAsistenciaCliente formAsistenciaCliente = new frmAsistenciaCliente();
            openChildForm(formAsistenciaCliente);
            customDesign();
        }

        private void btnAsistenciaDocente_Click(object sender, EventArgs e)
        {
            frmAsistenciaColaborador formAsistenciaColaborador = new frmAsistenciaColaborador();
            openChildForm(formAsistenciaColaborador);
            customDesign();
        }

        private void btnRegitrarCuota_Click(object sender, EventArgs e)
        {
            frmCuotas formCuotas = new frmCuotas();
            openChildForm(formCuotas);
            customDesign();
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            frmHistoricoCuotasServicio formHistorico = new frmHistoricoCuotasServicio();
			formHistorico.Show();
            customDesign();
        }

        private void btnMatricula_Click(object sender, EventArgs e)
        {
            frmMatricula formMatricula = new frmMatricula();
            openChildForm(formMatricula);
            customDesign();
        }

        private void bntBuscarParticular_Click(object sender, EventArgs e)
        {
            frmBuscarClaseParticular formBuscarClase = new frmBuscarClaseParticular();
            openChildForm(formBuscarClase);
            customDesign();
        }

        private void btnNuevoParticular_Click(object sender, EventArgs e)
        {
            frmGestionarClaseParticular formGestionarClase = new frmGestionarClaseParticular();
            openChildForm(formGestionarClase);
            customDesign();
        }
    
        private void btnAsignarHorario_Click(object sender, EventArgs e)
        {
            frmAsignarHorario formAsignarHorario = new frmAsignarHorario();
            openChildForm(formAsignarHorario);
            customDesign();
        }

		
        private void btnAsignarDesc_Click(object sender, EventArgs e)
        {
            frmAsignarDescuento formAsignarDescuento = new frmAsignarDescuento();
            openChildForm(formAsignarDescuento);
            customDesign();
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            frmInscribirAHorario formInscribirAHorario = new frmInscribirAHorario();
            openChildForm(formInscribirAHorario);
            customDesign();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            frmReportesTotal formReportes = new frmReportesTotal();
            //frmReportes formReportes = new frmReportes();
            openChildForm(formReportes);
            customDesign();
        }
        #endregion
        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            frmMensaje mensaje = new frmMensaje("Seguro que quiere cerrar sesion?","","Confirmar");
            if(mensaje.ShowDialog() == DialogResult.OK)
            {
                this.Hide();
                FormLogin login = new FormLogin();
                login.Show();
            }
        }

        private void btnCambiarPass_Click(object sender, EventArgs e)
        {
            frmCambiarPass cambiar = new frmCambiarPass(colab,this);
            
            cambiar.Show();
        }
    }
}
