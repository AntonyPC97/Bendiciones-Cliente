namespace Bendiciones
{
    partial class frmGestionarHorario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionarHorario));
            this.pnlCtn = new System.Windows.Forms.Panel();
            this.gbServicio = new System.Windows.Forms.GroupBox();
            this.dtpHoraFin = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraIni = new System.Windows.Forms.DateTimePicker();
            this.txtNumVac = new System.Windows.Forms.TextBox();
            this.lblVacantes = new System.Windows.Forms.Label();
            this.txtNumClase = new System.Windows.Forms.TextBox();
            this.lblNumClase = new System.Windows.Forms.Label();
            this.lblHoraFin = new System.Windows.Forms.Label();
            this.lblHoraIni = new System.Windows.Forms.Label();
            this.dtpFechaMatricula = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cboSede = new System.Windows.Forms.ComboBox();
            this.lblSede = new System.Windows.Forms.Label();
            this.gbDocente = new System.Windows.Forms.GroupBox();
            this.btnEliminarDocente = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombreDocente = new System.Windows.Forms.TextBox();
            this.btnBuscarDocente = new System.Windows.Forms.Button();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtDNIDocente = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pnlCtn.SuspendLayout();
            this.gbServicio.SuspendLayout();
            this.gbDocente.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCtn
            // 
            this.pnlCtn.Controls.Add(this.gbServicio);
            this.pnlCtn.Controls.Add(this.gbDocente);
            this.pnlCtn.Location = new System.Drawing.Point(12, 92);
            this.pnlCtn.Name = "pnlCtn";
            this.pnlCtn.Size = new System.Drawing.Size(571, 447);
            this.pnlCtn.TabIndex = 19;
            // 
            // gbServicio
            // 
            this.gbServicio.Controls.Add(this.dtpHoraFin);
            this.gbServicio.Controls.Add(this.dtpHoraIni);
            this.gbServicio.Controls.Add(this.txtNumVac);
            this.gbServicio.Controls.Add(this.lblVacantes);
            this.gbServicio.Controls.Add(this.txtNumClase);
            this.gbServicio.Controls.Add(this.lblNumClase);
            this.gbServicio.Controls.Add(this.lblHoraFin);
            this.gbServicio.Controls.Add(this.lblHoraIni);
            this.gbServicio.Controls.Add(this.dtpFechaMatricula);
            this.gbServicio.Controls.Add(this.lblFecha);
            this.gbServicio.Controls.Add(this.cboSede);
            this.gbServicio.Controls.Add(this.lblSede);
            this.gbServicio.Location = new System.Drawing.Point(3, 3);
            this.gbServicio.Name = "gbServicio";
            this.gbServicio.Size = new System.Drawing.Size(560, 316);
            this.gbServicio.TabIndex = 59;
            this.gbServicio.TabStop = false;
            this.gbServicio.Text = "Horario";
            // 
            // dtpHoraFin
            // 
            this.dtpHoraFin.CustomFormat = "HH:mm ";
            this.dtpHoraFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraFin.Location = new System.Drawing.Point(172, 166);
            this.dtpHoraFin.Name = "dtpHoraFin";
            this.dtpHoraFin.ShowUpDown = true;
            this.dtpHoraFin.Size = new System.Drawing.Size(89, 26);
            this.dtpHoraFin.TabIndex = 55;
            this.dtpHoraFin.Value = new System.DateTime(2019, 11, 23, 15, 30, 0, 0);
            // 
            // dtpHoraIni
            // 
            this.dtpHoraIni.CustomFormat = "HH:mm";
            this.dtpHoraIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpHoraIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraIni.Location = new System.Drawing.Point(172, 116);
            this.dtpHoraIni.MinDate = new System.DateTime(1753, 1, 1, 9, 0, 0, 0);
            this.dtpHoraIni.Name = "dtpHoraIni";
            this.dtpHoraIni.ShowUpDown = true;
            this.dtpHoraIni.Size = new System.Drawing.Size(89, 26);
            this.dtpHoraIni.TabIndex = 54;
            this.dtpHoraIni.Value = new System.DateTime(2019, 11, 23, 15, 30, 0, 0);
            // 
            // txtNumVac
            // 
            this.txtNumVac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumVac.HideSelection = false;
            this.txtNumVac.Location = new System.Drawing.Point(172, 266);
            this.txtNumVac.Name = "txtNumVac";
            this.txtNumVac.Size = new System.Drawing.Size(89, 26);
            this.txtNumVac.TabIndex = 52;
            this.txtNumVac.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNumVac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumVac_KeyPress);
            // 
            // lblVacantes
            // 
            this.lblVacantes.AutoSize = true;
            this.lblVacantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVacantes.Location = new System.Drawing.Point(6, 266);
            this.lblVacantes.Name = "lblVacantes";
            this.lblVacantes.Size = new System.Drawing.Size(93, 24);
            this.lblVacantes.TabIndex = 51;
            this.lblVacantes.Text = "Vacantes:";
            // 
            // txtNumClase
            // 
            this.txtNumClase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumClase.HideSelection = false;
            this.txtNumClase.Location = new System.Drawing.Point(172, 216);
            this.txtNumClase.Name = "txtNumClase";
            this.txtNumClase.Size = new System.Drawing.Size(89, 26);
            this.txtNumClase.TabIndex = 35;
            this.txtNumClase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNumClase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumClase_KeyPress);
            // 
            // lblNumClase
            // 
            this.lblNumClase.AutoSize = true;
            this.lblNumClase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumClase.Location = new System.Drawing.Point(6, 216);
            this.lblNumClase.Name = "lblNumClase";
            this.lblNumClase.Size = new System.Drawing.Size(160, 24);
            this.lblNumClase.TabIndex = 50;
            this.lblNumClase.Text = "Número de clase:";
            // 
            // lblHoraFin
            // 
            this.lblHoraFin.AutoSize = true;
            this.lblHoraFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraFin.Location = new System.Drawing.Point(6, 166);
            this.lblHoraFin.Name = "lblHoraFin";
            this.lblHoraFin.Size = new System.Drawing.Size(88, 24);
            this.lblHoraFin.TabIndex = 49;
            this.lblHoraFin.Text = "Hora Fin:";
            // 
            // lblHoraIni
            // 
            this.lblHoraIni.AutoSize = true;
            this.lblHoraIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraIni.Location = new System.Drawing.Point(6, 116);
            this.lblHoraIni.Name = "lblHoraIni";
            this.lblHoraIni.Size = new System.Drawing.Size(105, 24);
            this.lblHoraIni.TabIndex = 47;
            this.lblHoraIni.Text = "Hora Inicio:";
            // 
            // dtpFechaMatricula
            // 
            this.dtpFechaMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaMatricula.Location = new System.Drawing.Point(172, 66);
            this.dtpFechaMatricula.Name = "dtpFechaMatricula";
            this.dtpFechaMatricula.Size = new System.Drawing.Size(326, 26);
            this.dtpFechaMatricula.TabIndex = 44;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(6, 66);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(69, 24);
            this.lblFecha.TabIndex = 43;
            this.lblFecha.Text = "Fecha:";
            // 
            // cboSede
            // 
            this.cboSede.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSede.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSede.Items.AddRange(new object[] {
            "Curso 1",
            "Curso 2",
            "Curso 3"});
            this.cboSede.Location = new System.Drawing.Point(172, 16);
            this.cboSede.Name = "cboSede";
            this.cboSede.Size = new System.Drawing.Size(287, 28);
            this.cboSede.TabIndex = 42;
            // 
            // lblSede
            // 
            this.lblSede.AutoSize = true;
            this.lblSede.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSede.Location = new System.Drawing.Point(6, 16);
            this.lblSede.Name = "lblSede";
            this.lblSede.Size = new System.Drawing.Size(60, 24);
            this.lblSede.TabIndex = 41;
            this.lblSede.Text = "Sede:";
            // 
            // gbDocente
            // 
            this.gbDocente.Controls.Add(this.btnEliminarDocente);
            this.gbDocente.Controls.Add(this.lblNombre);
            this.gbDocente.Controls.Add(this.txtNombreDocente);
            this.gbDocente.Controls.Add(this.btnBuscarDocente);
            this.gbDocente.Controls.Add(this.lblDNI);
            this.gbDocente.Controls.Add(this.txtDNIDocente);
            this.gbDocente.Location = new System.Drawing.Point(3, 325);
            this.gbDocente.Name = "gbDocente";
            this.gbDocente.Size = new System.Drawing.Size(560, 113);
            this.gbDocente.TabIndex = 58;
            this.gbDocente.TabStop = false;
            this.gbDocente.Text = "Docente";
            // 
            // btnEliminarDocente
            // 
            this.btnEliminarDocente.Location = new System.Drawing.Point(391, 16);
            this.btnEliminarDocente.Name = "btnEliminarDocente";
            this.btnEliminarDocente.Size = new System.Drawing.Size(158, 39);
            this.btnEliminarDocente.TabIndex = 55;
            this.btnEliminarDocente.Text = "Eliminar Docente";
            this.btnEliminarDocente.UseVisualStyleBackColor = true;
            this.btnEliminarDocente.Click += new System.EventHandler(this.btnEliminarDocente_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(6, 66);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(84, 24);
            this.lblNombre.TabIndex = 33;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombreDocente
            // 
            this.txtNombreDocente.Enabled = false;
            this.txtNombreDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreDocente.HideSelection = false;
            this.txtNombreDocente.Location = new System.Drawing.Point(172, 66);
            this.txtNombreDocente.Name = "txtNombreDocente";
            this.txtNombreDocente.Size = new System.Drawing.Size(377, 26);
            this.txtNombreDocente.TabIndex = 34;
            this.txtNombreDocente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBuscarDocente
            // 
            this.btnBuscarDocente.FlatAppearance.BorderSize = 0;
            this.btnBuscarDocente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarDocente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarDocente.Location = new System.Drawing.Point(345, 20);
            this.btnBuscarDocente.Name = "btnBuscarDocente";
            this.btnBuscarDocente.Size = new System.Drawing.Size(40, 25);
            this.btnBuscarDocente.TabIndex = 32;
            this.btnBuscarDocente.Text = "...";
            this.btnBuscarDocente.UseVisualStyleBackColor = true;
            this.btnBuscarDocente.Click += new System.EventHandler(this.btnBuscarDocente_Click);
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(6, 16);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(43, 24);
            this.lblDNI.TabIndex = 30;
            this.lblDNI.Text = "Dni:";
            // 
            // txtDNIDocente
            // 
            this.txtDNIDocente.Enabled = false;
            this.txtDNIDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNIDocente.HideSelection = false;
            this.txtDNIDocente.Location = new System.Drawing.Point(172, 20);
            this.txtDNIDocente.Name = "txtDNIDocente";
            this.txtDNIDocente.Size = new System.Drawing.Size(167, 26);
            this.txtDNIDocente.TabIndex = 31;
            this.txtDNIDocente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnModificar
            // 
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(305, 66);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(136, 20);
            this.btnModificar.TabIndex = 54;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(447, 66);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(136, 20);
            this.btnCancelar.TabIndex = 53;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(187, 66);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(136, 20);
            this.btnGuardar.TabIndex = 52;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmGestionarHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 562);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pnlCtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(50, 80);
            this.MaximizeBox = false;
            this.Name = "frmGestionarHorario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionar Horario";
            this.pnlCtn.ResumeLayout(false);
            this.gbServicio.ResumeLayout(false);
            this.gbServicio.PerformLayout();
            this.gbDocente.ResumeLayout(false);
            this.gbDocente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlCtn;
        private System.Windows.Forms.GroupBox gbDocente;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombreDocente;
        private System.Windows.Forms.Button btnBuscarDocente;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtDNIDocente;
        private System.Windows.Forms.GroupBox gbServicio;
        private System.Windows.Forms.Label lblHoraFin;
        private System.Windows.Forms.Label lblHoraIni;
        private System.Windows.Forms.DateTimePicker dtpFechaMatricula;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox cboSede;
        private System.Windows.Forms.Label lblSede;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNumClase;
        private System.Windows.Forms.Label lblNumClase;
        private System.Windows.Forms.TextBox txtNumVac;
        private System.Windows.Forms.Label lblVacantes;
        private System.Windows.Forms.DateTimePicker dtpHoraIni;
        private System.Windows.Forms.DateTimePicker dtpHoraFin;
        private System.Windows.Forms.Button btnEliminarDocente;
    }
}