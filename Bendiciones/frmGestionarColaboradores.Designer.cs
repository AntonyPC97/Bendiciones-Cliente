namespace Bendiciones
{
    partial class frmGestionarColaboradores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlCtn = new System.Windows.Forms.Panel();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.lblReferencia = new System.Windows.Forms.Label();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblProfesión = new System.Windows.Forms.Label();
            this.txtProfesion = new System.Windows.Forms.TextBox();
            this.lblNUmColegia = new System.Windows.Forms.Label();
            this.txtNumColeg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.pnlCtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCtn
            // 
            this.pnlCtn.Controls.Add(this.dtpFechaNac);
            this.pnlCtn.Controls.Add(this.lblFechaNac);
            this.pnlCtn.Controls.Add(this.lblReferencia);
            this.pnlCtn.Controls.Add(this.txtReferencia);
            this.pnlCtn.Controls.Add(this.lblDireccion);
            this.pnlCtn.Controls.Add(this.txtDireccion);
            this.pnlCtn.Controls.Add(this.lblUsuario);
            this.pnlCtn.Controls.Add(this.txtUsuario);
            this.pnlCtn.Controls.Add(this.lblPassword);
            this.pnlCtn.Controls.Add(this.txtPassword);
            this.pnlCtn.Controls.Add(this.lblProfesión);
            this.pnlCtn.Controls.Add(this.txtProfesion);
            this.pnlCtn.Controls.Add(this.lblNUmColegia);
            this.pnlCtn.Controls.Add(this.txtNumColeg);
            this.pnlCtn.Controls.Add(this.label6);
            this.pnlCtn.Controls.Add(this.txtNombre);
            this.pnlCtn.Controls.Add(this.cboTipo);
            this.pnlCtn.Controls.Add(this.label1);
            this.pnlCtn.Controls.Add(this.label12);
            this.pnlCtn.Controls.Add(this.label5);
            this.pnlCtn.Controls.Add(this.label4);
            this.pnlCtn.Controls.Add(this.label2);
            this.pnlCtn.Controls.Add(this.txtCorreo);
            this.pnlCtn.Controls.Add(this.txtTelefono);
            this.pnlCtn.Controls.Add(this.txtDNI);
            this.pnlCtn.Controls.Add(this.rbMasculino);
            this.pnlCtn.Controls.Add(this.rbFemenino);
            this.pnlCtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCtn.Location = new System.Drawing.Point(40, 148);
            this.pnlCtn.Name = "pnlCtn";
            this.pnlCtn.Size = new System.Drawing.Size(897, 332);
            this.pnlCtn.TabIndex = 8;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(116, 185);
            this.dtpFechaNac.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(318, 28);
            this.dtpFechaNac.TabIndex = 5;
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(4, 190);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(110, 24);
            this.lblFechaNac.TabIndex = 106;
            this.lblFechaNac.Text = "Nacimiento:";
            // 
            // lblReferencia
            // 
            this.lblReferencia.AutoSize = true;
            this.lblReferencia.Location = new System.Drawing.Point(4, 150);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Size = new System.Drawing.Size(106, 24);
            this.lblReferencia.TabIndex = 105;
            this.lblReferencia.Text = "Referencia:";
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(116, 147);
            this.txtReferencia.MaxLength = 150;
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(318, 28);
            this.txtReferencia.TabIndex = 4;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(464, 230);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(114, 24);
            this.lblDireccion.TabIndex = 103;
            this.lblDireccion.Text = "Dirección(*):";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(644, 228);
            this.txtDireccion.MaxLength = 150;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(221, 28);
            this.txtDireccion.TabIndex = 14;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(464, 150);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(79, 24);
            this.lblUsuario.TabIndex = 101;
            this.lblUsuario.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(644, 147);
            this.txtUsuario.MaxLength = 25;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(221, 28);
            this.txtUsuario.TabIndex = 12;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(464, 190);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(111, 24);
            this.lblPassword.TabIndex = 99;
            this.lblPassword.Text = "Contraseña:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(644, 187);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(221, 28);
            this.txtPassword.TabIndex = 13;
            // 
            // lblProfesión
            // 
            this.lblProfesión.AutoSize = true;
            this.lblProfesión.Location = new System.Drawing.Point(464, 110);
            this.lblProfesión.Name = "lblProfesión";
            this.lblProfesión.Size = new System.Drawing.Size(113, 24);
            this.lblProfesión.TabIndex = 97;
            this.lblProfesión.Text = "Profesión(*):";
            // 
            // txtProfesion
            // 
            this.txtProfesion.Location = new System.Drawing.Point(644, 107);
            this.txtProfesion.MaxLength = 150;
            this.txtProfesion.Name = "txtProfesion";
            this.txtProfesion.Size = new System.Drawing.Size(221, 28);
            this.txtProfesion.TabIndex = 11;
            // 
            // lblNUmColegia
            // 
            this.lblNUmColegia.AutoSize = true;
            this.lblNUmColegia.Location = new System.Drawing.Point(464, 70);
            this.lblNUmColegia.Name = "lblNUmColegia";
            this.lblNUmColegia.Size = new System.Drawing.Size(161, 24);
            this.lblNUmColegia.TabIndex = 95;
            this.lblNUmColegia.Text = "Num. Colegiatura:";
            // 
            // txtNumColeg
            // 
            this.txtNumColeg.Location = new System.Drawing.Point(644, 67);
            this.txtNumColeg.MaxLength = 6;
            this.txtNumColeg.Name = "txtNumColeg";
            this.txtNumColeg.Size = new System.Drawing.Size(221, 28);
            this.txtNumColeg.TabIndex = 10;
            this.txtNumColeg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumColeg_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 24);
            this.label6.TabIndex = 93;
            this.label6.Text = "Nombre(*):";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(116, 27);
            this.txtNombre.MaxLength = 60;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(318, 28);
            this.txtNombre.TabIndex = 1;
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(669, 27);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(196, 30);
            this.cboTipo.TabIndex = 9;
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 24);
            this.label1.TabIndex = 90;
            this.label1.Text = "Tipo de colaborador(*):";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 270);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 24);
            this.label12.TabIndex = 89;
            this.label12.Text = "Sexo(*):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 24);
            this.label5.TabIndex = 88;
            this.label5.Text = "Teléfono(*):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 87;
            this.label4.Text = "Correo(*):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 86;
            this.label2.Text = "DNI(*):";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(116, 107);
            this.txtCorreo.MaxLength = 150;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(318, 28);
            this.txtCorreo.TabIndex = 3;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(116, 227);
            this.txtTelefono.MaxLength = 9;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(318, 28);
            this.txtTelefono.TabIndex = 6;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(116, 67);
            this.txtDNI.MaxLength = 8;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(318, 28);
            this.txtDNI.TabIndex = 2;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(90, 270);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(114, 28);
            this.rbMasculino.TabIndex = 7;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            this.rbMasculino.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbMasculino_KeyDown);
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(230, 270);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(115, 28);
            this.rbFemenino.TabIndex = 8;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            this.rbFemenino.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbFemenino_KeyDown);
            // 
            // btnModificar
            // 
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(270, 41);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(136, 20);
            this.btnModificar.TabIndex = 18;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(554, 41);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(136, 20);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(108, 41);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(136, 20);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(40, 84);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(136, 20);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(338, 113);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(136, 20);
            this.btnNuevo.TabIndex = 15;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmGestionarColaboradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 610);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pnlCtn);
            this.Name = "frmGestionarColaboradores";
            this.Text = "frmGestionarColaboradores";
            this.pnlCtn.ResumeLayout(false);
            this.pnlCtn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlCtn;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.Label lblReferencia;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblProfesión;
        private System.Windows.Forms.TextBox txtProfesion;
        private System.Windows.Forms.Label lblNUmColegia;
        private System.Windows.Forms.TextBox txtNumColeg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFemenino;
    }
}