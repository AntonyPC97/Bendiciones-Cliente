using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bendiciones
{
    class Formateador
    {
        private int btnH = 40;
		private int btnW = 85;
		private int btnGap = 10;
		private int pnlGap = 50;

        Paleta colores = new Paleta();

        public void formatearVentanaFull(Form ventana)
        {
            ventana.Height = 600;
            ventana.Width = 1000;
            ventana.BackColor = colores.Blanco;
            ventana.StartPosition = FormStartPosition.CenterScreen;
        }
        public void formatearVentanaMini(Form ventana)
        {
            ventana.Height = 500;
            ventana.Width = 800;
            ventana.BackColor = colores.Blanco;
            ventana.StartPosition = FormStartPosition.CenterScreen;
        }
        public void formatearBotonNaranja(Button boton)
        {
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.BackColor = colores.Naranja;
            boton.ForeColor = colores.Blanco;
            boton.Height = btnH;
            boton.Width = btnW;
            boton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
        public void formatearBotonLila(Button boton)
        {
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.BackColor = colores.Lila;
            boton.ForeColor = colores.Marron;
            boton.Height = btnH;
            boton.Width = btnW;
            boton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
		public void formatearBotonListar(Button boton)
		{
			boton.FlatStyle = FlatStyle.Flat;
			boton.FlatAppearance.BorderSize = 0;
			boton.BackColor = colores.Naranja;
			boton.ForeColor = colores.Blanco;
			boton.Height = 25;
			boton.Width = 40;
			boton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		}
        public void formatearBotonMenu(Button boton)
        {
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.BackColor = colores.NaranjaOscuro;
            boton.ForeColor = colores.Blanco;
			boton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			//boton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        public void formatearBotonSubMenu(Button boton)
        {
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.BackColor = colores.Naranja;
            boton.ForeColor = colores.Blanco;
			boton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			//boton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		}

        public void estiloFormularioGestion(Form ventana, Label titulo, Panel panel,Button btnNuevo, Button btnBuscar, Button btnGuardar, Button btnModificar, Button btnCancelar, Boolean isMini)
        {
            if (isMini == false)
                formatearVentanaFull(ventana);
            else
                formatearVentanaMini(ventana);

			formatearBotonNaranja(btnNuevo);
            formatearBotonNaranja(btnBuscar);
            formatearBotonNaranja(btnGuardar);
            formatearBotonNaranja(btnCancelar);
            formatearBotonLila(btnModificar);

            titulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titulo.Left = pnlGap;
            titulo.Top = pnlGap + btnH - titulo.Height;
            titulo.Width *= 3;

            panel.BackColor = colores.GrisClaro; //////////////
            panel.SendToBack();
            panel.Left = pnlGap;
            panel.Width = ventana.Width - 2 * pnlGap;

			btnNuevo.Top = pnlGap;
            btnBuscar.Top = pnlGap;
            btnGuardar.Top = pnlGap;
            btnCancelar.Top = pnlGap;
            btnModificar.Top = pnlGap;

			btnNuevo.Left = panel.Left + panel.Width - 4 * btnGap - 5 * btnW;
            btnBuscar.Left = btnNuevo.Left + btnNuevo.Width + btnGap;
            btnGuardar.Left = btnBuscar.Left + btnBuscar.Width + btnGap;
            btnModificar.Left = btnGuardar.Left + btnGuardar.Width + btnGap;
            btnCancelar.Left = btnModificar.Left + btnModificar.Width + btnGap;

            panel.Top = btnCancelar.Top + btnCancelar.Height + btnGap;
            panel.Height = ventana.Height - 190;
        }

        public void estiloFormularioBusqueda(Form ventana, Label titulo, String nombre, Panel panel, String criterioBusqueda, TextBox txtCriterio, DataGridView dg, Button btnBuscar, Button btnSeleccionar, Button btnEliminar,Boolean isMini, Boolean eliminar) {
            if (isMini == false)
            {
                formatearVentanaFull(ventana);
            }
            else
            {
                formatearVentanaMini(ventana);
            }

            formatearBotonNaranja(btnBuscar);
            formatearBotonLila(btnSeleccionar);


			
            btnBuscar.Parent = panel;
            btnSeleccionar.Parent = panel;

            

            titulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titulo.Left = pnlGap;
            titulo.Top = pnlGap + btnH - titulo.Height;
            titulo.Width *= 3;

            panel.BackColor = colores.GrisClaro; //////////////
            panel.SendToBack();
            panel.Height = ventana.Height - 200;
            panel.Width = ventana.Width - 50;
            panel.Width = ventana.Width - 2 * pnlGap;

            panel.Top = (ventana.Height - panel.Height) / 2;
            panel.Left = (ventana.Width - panel.Width) / 2;
            
            Label crit = new Label();
            dg.Left = (panel.Width - dg.Width) / 2;

            crit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            crit.Text = criterioBusqueda;
            crit.Parent = panel;
            crit.Top = pnlGap;
            crit.Left = dg.Left;
            crit.Width = 150; 

            txtCriterio.Parent = panel;
            txtCriterio.Top= crit.Top;
            txtCriterio.Left = crit.Left + crit.Width ;
            txtCriterio.Width = dg.Width - crit.Width;

            btnSeleccionar.Top = crit.Top + crit.Height + btnGap;
            btnBuscar.Top = btnSeleccionar.Top;

            if (eliminar)
            {
                formatearBotonNaranja(btnEliminar);
                btnEliminar.Parent = panel;
                btnEliminar.Top = btnBuscar.Top;

                btnEliminar.Left = dg.Left + dg.Width - btnEliminar.Width;
                btnSeleccionar.Left = btnEliminar.Left - btnEliminar.Width - btnGap;
                btnBuscar.Left = btnSeleccionar.Left - btnSeleccionar.Width - btnGap;
            } else
            {
                btnEliminar.Visible = false;
                btnSeleccionar.Left = dg.Left + dg.Width - btnSeleccionar.Width;
                btnBuscar.Left = btnSeleccionar.Left - btnSeleccionar.Width - btnGap;
            }

            

            dg.Parent = panel;
            dg.Top = btnBuscar.Top + btnBuscar.Height + btnGap;
        }

        public void iniFormFreddyGestionar(Form form, String nombre, Panel pnlCtn,Button btnNuevo, Button btnBuscar, Button btnGuardar, Button btnModificar, Button btnCancelar, Boolean isMini) {

            Label titulo = new Label();
            Panel panel = new Panel();

            titulo.Parent = form;
            panel.Parent = form;

			btnNuevo.Text = "Nuevo";
            btnBuscar.Text = "Buscar";
            btnGuardar.Text = "Guardar";
            btnCancelar.Text = "Cancelar";
            btnModificar.Text = "Modificar";

            titulo.Text = nombre;
            estiloFormularioGestion(form, titulo, panel,btnNuevo, btnBuscar, btnGuardar, btnModificar, btnCancelar, isMini);
            centerPanel(form, pnlCtn);
        }

        public void iniFormAsistencia(Form form, String nombre, Panel pnlCtn, Button btnRegistrar, Button btnBuscar)
        {
            Label titulo = new Label();
            Panel panel = new Panel();
            titulo.Parent = form;
			panel.Parent = form;

            btnRegistrar.Text = "Registrar";
            btnBuscar.Text = "Buscar";
            titulo.Text = nombre;
            formatearVentanaFull(form);
            formatearBotonNaranja(btnRegistrar);
            formatearBotonLila(btnBuscar);

            titulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titulo.Left = pnlGap;
            titulo.Top = pnlGap + btnH - titulo.Height;
            titulo.Width *= 4;

            panel.BackColor = colores.GrisClaro;
            panel.SendToBack();
            panel.Left = pnlGap;
            panel.Width = form.Width - 2 * pnlGap;

            panel.Top = titulo.Top + titulo.Height + btnGap;
            panel.Height = form.Height - 190;
            centerPanel(form, pnlCtn);
        }

        public void iniFormFreddyBuscar(Form form, String nombre, String criterioBusqueda, TextBox txtCriterio, DataGridView dg, Button btnBuscar, Button btnSeleccionar,Button btnEliminar ,Boolean isMini, Boolean eliminar) {
            Label titulo = new Label();
            Panel panel = new Panel();

            titulo.Parent = form;
            panel.Parent = form;
            btnBuscar.Text = "Buscar";
            btnSeleccionar.Text = "Seleccionar";
			btnEliminar.Text = "Eliminar";

            titulo.Text = nombre;
            estiloFormularioBusqueda(form,titulo,nombre,panel,criterioBusqueda,txtCriterio,dg,btnBuscar,btnSeleccionar,btnEliminar,isMini, eliminar);
        }
        public void centerPanel(Form formulario, Panel pnl) {
            pnl.Top = (formulario.Height - pnl.Height) / 2;
            pnl.Left = (formulario.Width - pnl.Width) / 2;
            pnl.BackColor = colores.GrisClaro; 
        }
        

		public void formRegistrarCuota(Form form, String nombre, Panel pnlCtn, Boolean isMini)
		{
			Label titulo = new Label();
			Panel panel = new Panel();

			titulo.Parent = form;
			panel.Parent = form;


			titulo.Text = nombre;
			estiloCuotas(form, titulo, panel, isMini);
			centerPanel(form, pnlCtn);
		}

		public void estiloCuotas(Form ventana, Label titulo, Panel panel, Boolean isMini)
		{
			if (isMini == false)
			{
				formatearVentanaFull(ventana);
			}
			else
			{
				formatearVentanaMini(ventana);

			}

			titulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			titulo.Left = pnlGap;
			titulo.Top = pnlGap + btnH - titulo.Height;
			titulo.Width *= 3;

			panel.BackColor = colores.GrisClaro;
			panel.SendToBack();
			panel.Left = pnlGap;
			panel.Width = ventana.Width - 2 * pnlGap;

			panel.Top = titulo.Top + titulo.Height + btnGap;
			panel.Height = ventana.Height - 190;
		}

		public void formMatricula(Form form, String nombre, Panel pnlCtn, Button btnGuardar, Button btnCancelar)
		{
			Label titulo = new Label();
			Panel panel = new Panel();

			titulo.Parent = form;
			panel.Parent = form;

			btnGuardar.Text = "Guardar";
			btnCancelar.Text = "Cancelar";

			titulo.Text = nombre;
			estiloMatricula(form, titulo, panel,btnGuardar, btnCancelar);
			centerPanel(form, pnlCtn);
		}
		public void estiloMatricula(Form ventana, Label titulo, Panel panel, Button btnGuardar, Button btnCancelar)
		{
			formatearVentanaFull(ventana);
			formatearBotonNaranja(btnGuardar);
			formatearBotonNaranja(btnCancelar);

			titulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			titulo.Left = pnlGap;
			titulo.Top = pnlGap -25 + btnH - titulo.Height;
			titulo.Width *= 3;

			panel.BackColor = colores.GrisClaro; //////////////
			panel.SendToBack();
			panel.Left = pnlGap;
			panel.Width = ventana.Width - 2 * pnlGap;

			btnGuardar.Top = pnlGap -25;
			btnCancelar.Top = pnlGap -25;

			btnGuardar.Left = panel.Left + panel.Width -   btnGap - 2 * btnW;
			btnCancelar.Left = btnGuardar.Left + btnGuardar.Width + btnGap;

			panel.Top = btnCancelar.Top + btnCancelar.Height + btnGap;
			panel.Height = ventana.Height - 150;
		}

        public void formAsignarHorario(Form form,String nombre, Panel pnlCtn, GroupBox gbCurso, Button btnAdd, Button btnSub,DataGridView dgv, Button btnGuardar)
        {
            Label titulo = new Label();
            Panel panel = new Panel();

            titulo.Parent = form;
            titulo.Text = nombre;
            panel.Parent = form;

            titulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titulo.Left = pnlGap;
            titulo.Top = pnlGap - titulo.Height;
            titulo.Width *= 3;

            panel.BackColor = colores.GrisClaro;
            panel.SendToBack();
            panel.Left = pnlGap;
            panel.Width = form.Width - 2 * pnlGap;

            panel.Top = titulo.Top + titulo.Height + btnGap;
            panel.Height = form.Height - 180;

            form.BackColor = colores.GrisClaro;
            formatearVentanaFull(form);
            formatearBotonListar(btnAdd);
            formatearBotonListar(btnSub);
            formatearBotonNaranja(btnGuardar);

            dgv.Left = gbCurso.Left;
            dgv.Top = gbCurso.Top + gbCurso.Height + btnH + 2 * btnGap;

            btnAdd.Top = btnSub.Top = dgv.Top - btnGap - 25;
            btnAdd.Left = dgv.Left + dgv.Width - btnGap - 2 * 40;
            btnSub.Left = btnAdd.Left + btnGap + 40;

            btnGuardar.Top = dgv.Top + dgv.Height + btnGap;
            btnGuardar.Left = dgv.Left + dgv.Width - btnW;

            centerPanel(form, pnlCtn);
        }

        public void formAsignarDesc(Form form, String nombre,Panel pnlCtn,GroupBox gbCurso,Button btnBuscar,DataGridView dgv,Button btnGuardar)
        {
            Label titulo = new Label();
            Panel panel = new Panel();
            
            titulo.Parent = form;
            titulo.Text = nombre;
            panel.Parent = form;
            formatearVentanaFull(form);

            titulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titulo.Left = pnlGap;
            titulo.Top = pnlGap +2*btnGap - titulo.Height;
            titulo.Width *= 3;

            panel.BackColor = colores.GrisClaro;
            panel.SendToBack();
            panel.Left = pnlGap;
            panel.Width = form.Width - 2 * pnlGap;

            panel.Top = titulo.Top + titulo.Height + btnGap;
            panel.Height = form.Height -200 ;


            formatearBotonListar(btnBuscar);
            formatearBotonNaranja(btnGuardar);

            dgv.Left = gbCurso.Left;
            dgv.Top = gbCurso.Top + gbCurso.Height + btnGap;

            btnGuardar.Top = dgv.Top + dgv.Height + btnGap;
            btnGuardar.Left = dgv.Left + dgv.Width - btnW;
            centerPanel(form, pnlCtn);
        }
        public void formInscribir(Form form, String nombre, Panel pnlCtn,GroupBox gbServicio, Button btnSeleccionarHorario)
        {
            Label titulo = new Label();
            Panel panel = new Panel();

            titulo.Parent = form;
            titulo.Text = nombre;
            panel.Parent = form;
            formatearVentanaFull(form);

            titulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titulo.Left = pnlGap;
            titulo.Top = pnlGap - titulo.Height;
            titulo.Width *= 3;

            panel.BackColor = colores.GrisClaro;
            panel.SendToBack();
            panel.Left = pnlGap;
            panel.Width = form.Width - 2 * pnlGap;

            panel.Top = titulo.Top + titulo.Height + btnGap;
            panel.Height = form.Height - 140;
            formatearBotonNaranja(btnSeleccionarHorario);
            btnSeleccionarHorario.Top = gbServicio.Top + gbServicio.Height + btnGap;
            btnSeleccionarHorario.Left = gbServicio.Left + gbServicio.Width - btnW;
            centerPanel(form,pnlCtn);
        }

        public void formGestionarHorario(Form form,String nombre, Panel pnlCtn,Button btnGuardar, Button btnModificar, Button btnCancelar)
        {
            Label titulo = new Label();

            titulo.Parent = form;
            titulo.Text = nombre;
            form.Height = pnlCtn.Height + pnlGap + 2*btnH;

            titulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titulo.Left = pnlCtn.Left;
            titulo.Top = pnlGap;
            titulo.Width *= 3;
            form.BackColor = colores.Blanco;
            pnlCtn.Top = titulo.Top + titulo.Height + btnGap;

            formatearBotonNaranja(btnGuardar);
            formatearBotonLila(btnModificar);
            formatearBotonNaranja(btnCancelar);

            btnCancelar.Top = btnGuardar.Top = btnModificar.Top = pnlCtn.Top - btnGap - btnH;
            btnGuardar.Left = pnlCtn.Left + pnlCtn.Width - 2 * btnGap - 3 * btnW;
            btnModificar.Left = btnGuardar.Left + btnW + btnGap;
            btnCancelar.Left = btnModificar.Left + btnW + btnGap;

        }
		public void formMensaje(Panel pnlTitulo, Panel pnlMensaje, Label lblTitulo, Label lblMensaje,Button btnOk, Button btnCancel,string tipo)
		{
			formatearBotonNaranja(btnOk);
			formatearBotonNaranja(btnCancel);
			if (tipo.Equals("Confirmar"))
				pnlTitulo.BackColor = colores.Naranja;
			else
				pnlTitulo.BackColor = colores.Amarillo;
			pnlMensaje.BackColor = colores.Blanco;

			lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			lblTitulo.Top = (pnlTitulo.Height - lblTitulo.Height) / 2;
			lblTitulo.Left = pnlTitulo.Left + btnGap;

			lblMensaje.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			lblMensaje.Top = (pnlMensaje.Height - lblMensaje.Height) / 2 - 2*btnGap;
			lblMensaje.Left = pnlMensaje.Left + btnGap;

			btnCancel.Top = btnOk.Top = pnlMensaje.Top + pnlMensaje.Height - 2*btnH - btnGap;
			btnOk.Left = pnlMensaje.Left + pnlMensaje.Width - 3 * btnGap - 2 * btnW;
			btnCancel.Left = btnOk.Left + btnOk.Width + btnGap;
		}

        public void formReportes(Form form, String nombre, Panel pnlCtn)
        {

            Label titulo = new Label();
            Panel panel = new Panel();

            titulo.Parent = form;
            titulo.Text = nombre;
            panel.Parent = form;


            titulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titulo.Left = pnlGap;
            titulo.Top = pnlGap + btnH - titulo.Height;
            titulo.Width *= 3;

            panel.BackColor = colores.GrisClaro; //////////////
            panel.SendToBack();
            panel.Left = pnlGap;
            panel.Width = form.Width - 2 * pnlGap;

            

            panel.Top = titulo.Top + titulo.Height + btnGap;
            panel.Height = form.Height - 150;

            form.BackColor = colores.GrisClaro;
            formatearVentanaFull(form);

            centerPanel(form, pnlCtn);
        }

		public void formCliente(Form form, String nombre, Panel pnlCtn, Button btnNuevo, Button btnBuscar, Button btnGuardar, Button btnModificar, Button btnCancelar)
		{
			Label titulo = new Label();
			Panel panel = new Panel();

			titulo.Parent = form;
			panel.Parent = form;

			titulo.Text = nombre;
			estiloCliente(form, titulo, panel,btnNuevo,btnBuscar, btnGuardar,btnModificar, btnCancelar);
			centerPanel(form, pnlCtn);
		}
		public void estiloCliente(Form ventana, Label titulo, Panel panel, Button btnNuevo, Button btnBuscar, Button btnGuardar, Button btnModificar, Button btnCancelar)
		{
			formatearVentanaFull(ventana);
			formatearBotonNaranja(btnModificar);
			formatearBotonNaranja(btnNuevo);
			formatearBotonNaranja(btnBuscar);
			formatearBotonNaranja(btnGuardar);
			formatearBotonNaranja(btnCancelar);

			titulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			titulo.Left = pnlGap;
			titulo.Top = pnlGap - 25 + btnH - titulo.Height;
			titulo.Width *= 3;

			panel.BackColor = colores.GrisClaro; //////////////
			panel.SendToBack();
			panel.Left = pnlGap;
			panel.Width = ventana.Width - 2 * pnlGap;

			btnGuardar.Top =btnBuscar.Top = btnCancelar.Top = btnNuevo.Top = btnModificar.Top = pnlGap - 25;

			btnNuevo.Left = panel.Left + panel.Width - 4*btnGap - 5 * btnW;
			btnBuscar.Left = btnNuevo.Left + btnNuevo.Width + btnGap;
			btnGuardar.Left = btnBuscar.Left + btnBuscar.Width + btnGap;
			btnModificar.Left = btnGuardar.Left + btnGuardar.Width + btnGap;
			btnCancelar.Left = btnModificar.Left + btnModificar.Width + btnGap;

			panel.Top = btnCancelar.Top + btnCancelar.Height + btnGap;
			panel.Height = ventana.Height - 150;
		}
	}

}
