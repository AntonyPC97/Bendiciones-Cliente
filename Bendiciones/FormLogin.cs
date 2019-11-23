﻿using System;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace Bendiciones
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("es-MX");
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

            Paleta paleta = new Paleta();
            picName.BackColor = paleta.Naranja;
            this.BackColor = paleta.NaranjaOscuro;
            btnIngresar.BackColor = paleta.Naranja;

            txtUser.Left = (txtUser.Parent.Width - txtUser.Width) / 2;
            txtPassword.Left = (txtPassword.Parent.Width - txtPassword.Width) / 2;
            btnIngresar.Left = (btnIngresar.Parent.Width - btnIngresar.Width) / 2;

            btnIngresar.ForeColor = paleta.Marron;
            lblUsuario.ForeColor = paleta.Marron;
            lblPassword.ForeColor = paleta.Marron;
            pnlLine1.BackColor = paleta.Marron;
            pnlLine2.BackColor = paleta.Marron;

        }
        public int transformar(double minutos)
        {
            int segundos = (int)(60 - minutos);
            return segundos;
        }
        public Service.colaborador verificarCampos()
        {
            double minutos = 0;
            Service.colaborador colaborador = Program.dbController.verificarUsuario(txtUser.Text);

            if (colaborador.idPersona == 0)
            {
                MessageBox.Show("Usuario o Contraseña inválido", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }

            if (colaborador.intentos == 3)
            {
                int  horaCur = DateTime.Now.Hour;
                int minCur = DateTime.Now.Minute;
                int segCur = DateTime.Now.Second;
                DateTime current = new DateTime(1970,1,1,horaCur,minCur,segCur);
                DateTime horaBloqueo = colaborador.horaBloqueo;
                minutos = (current.TimeOfDay - horaBloqueo.TimeOfDay).TotalMinutes;
                if (minutos < 1)
                {
                    MessageBox.Show("Excedio el numero de intentos, vuelva a intentar en " + transformar(minutos) + " segundos");
                    return null;
                }
                else {
                    colaborador.intentos = 0;
                    Program.dbController.actualizarColaborador(colaborador);
                }
            }

            if (txtPassword.Text.Equals(colaborador.password))
                return colaborador;
            else
            {
                if (colaborador.intentos < 3)
                {
                    colaborador.intentos += 1;
                    Program.dbController.actualizarColaborador(colaborador);
                    MessageBox.Show("Contraseña incorrecta \nIntentos restantes: " + (3 - colaborador.intentos), "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (colaborador.intentos == 3)
                    {
                        int hora = DateTime.Now.Hour;
                        int minuto = DateTime.Now.Minute;
                        int seg = DateTime.Now.Second;
                        DateTime bloqueo = new DateTime(1970,1,1,hora,minuto,seg);
                        colaborador.horaBloqueoSpecified = true;
                        colaborador.horaBloqueo = bloqueo;
                        Program.dbController.actualizarColaborador(colaborador);
                    }
                }
            }
           
            return null;  
		}
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(txtUser.Text.Equals("") || txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Ingresar usuario y/o contraseñña", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Service.colaborador colaborador = verificarCampos();
                if (colaborador != null)
                {
                    colaborador.intentos = 0;
                    Program.dbController.actualizarColaborador(colaborador);
                    if (colaborador.tipo.nombre.Equals("Administracion"))
                    {
                        frmPrincipal Principal = new frmPrincipal();
                        Principal.Show();
                        this.Hide();
                    }
                    else if(colaborador.tipo.nombre.Equals("Secretaria"))
                    {
                        frmPrincipalSec Principal = new frmPrincipalSec();
                        Principal.Show();
                        this.Hide();
                    }

                }
            }
            
        }

		private void txtPassword_KeyDown(object sender, KeyEventArgs e)
		{
            if (e.KeyCode == Keys.Enter)
                btnIngresar_Click(sender, e);
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnIngresar_Click(sender, e);
        }
    }
}