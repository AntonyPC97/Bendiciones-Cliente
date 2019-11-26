namespace Bendiciones
{
    partial class frmGestionarGestacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionarGestacion));
            this.pnlCtn = new System.Windows.Forms.Panel();
            this.gbDatosGenerales = new System.Windows.Forms.GroupBox();
            this.lblNumEmbarazo = new System.Windows.Forms.Label();
            this.txtMedico = new System.Windows.Forms.TextBox();
            this.lblMedico = new System.Windows.Forms.Label();
            this.txtClinica = new System.Windows.Forms.TextBox();
            this.lblClinica = new System.Windows.Forms.Label();
            this.dtpFPP = new System.Windows.Forms.DateTimePicker();
            this.lblFPP = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.udNumeroEmb = new System.Windows.Forms.NumericUpDown();
            this.pnlCtn.SuspendLayout();
            this.gbDatosGenerales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udNumeroEmb)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCtn
            // 
            this.pnlCtn.AutoScroll = true;
            this.pnlCtn.Controls.Add(this.gbDatosGenerales);
            this.pnlCtn.Location = new System.Drawing.Point(58, 38);
            this.pnlCtn.Name = "pnlCtn";
            this.pnlCtn.Size = new System.Drawing.Size(670, 311);
            this.pnlCtn.TabIndex = 60;
            // 
            // gbDatosGenerales
            // 
            this.gbDatosGenerales.Controls.Add(this.udNumeroEmb);
            this.gbDatosGenerales.Controls.Add(this.lblNumEmbarazo);
            this.gbDatosGenerales.Controls.Add(this.txtMedico);
            this.gbDatosGenerales.Controls.Add(this.lblMedico);
            this.gbDatosGenerales.Controls.Add(this.txtClinica);
            this.gbDatosGenerales.Controls.Add(this.lblClinica);
            this.gbDatosGenerales.Controls.Add(this.dtpFPP);
            this.gbDatosGenerales.Controls.Add(this.lblFPP);
            this.gbDatosGenerales.Location = new System.Drawing.Point(96, 53);
            this.gbDatosGenerales.Name = "gbDatosGenerales";
            this.gbDatosGenerales.Size = new System.Drawing.Size(461, 188);
            this.gbDatosGenerales.TabIndex = 31;
            this.gbDatosGenerales.TabStop = false;
            this.gbDatosGenerales.Text = "Datos Generales";
            // 
            // lblNumEmbarazo
            // 
            this.lblNumEmbarazo.AutoSize = true;
            this.lblNumEmbarazo.Location = new System.Drawing.Point(33, 134);
            this.lblNumEmbarazo.Name = "lblNumEmbarazo";
            this.lblNumEmbarazo.Size = new System.Drawing.Size(108, 13);
            this.lblNumEmbarazo.TabIndex = 34;
            this.lblNumEmbarazo.Text = "Número de embarazo";
            // 
            // txtMedico
            // 
            this.txtMedico.Location = new System.Drawing.Point(207, 99);
            this.txtMedico.Name = "txtMedico";
            this.txtMedico.Size = new System.Drawing.Size(197, 20);
            this.txtMedico.TabIndex = 33;
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.Location = new System.Drawing.Point(33, 107);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(42, 13);
            this.lblMedico.TabIndex = 32;
            this.lblMedico.Text = "Médico";
            // 
            // txtClinica
            // 
            this.txtClinica.Location = new System.Drawing.Point(207, 65);
            this.txtClinica.Name = "txtClinica";
            this.txtClinica.Size = new System.Drawing.Size(197, 20);
            this.txtClinica.TabIndex = 31;
            // 
            // lblClinica
            // 
            this.lblClinica.AutoSize = true;
            this.lblClinica.Location = new System.Drawing.Point(33, 73);
            this.lblClinica.Name = "lblClinica";
            this.lblClinica.Size = new System.Drawing.Size(40, 13);
            this.lblClinica.TabIndex = 30;
            this.lblClinica.Text = "Clínica";
            // 
            // dtpFPP
            // 
            this.dtpFPP.Location = new System.Drawing.Point(207, 36);
            this.dtpFPP.Name = "dtpFPP";
            this.dtpFPP.Size = new System.Drawing.Size(197, 20);
            this.dtpFPP.TabIndex = 29;
            // 
            // lblFPP
            // 
            this.lblFPP.AutoSize = true;
            this.lblFPP.Location = new System.Drawing.Point(33, 36);
            this.lblFPP.Name = "lblFPP";
            this.lblFPP.Size = new System.Drawing.Size(123, 13);
            this.lblFPP.TabIndex = 28;
            this.lblFPP.Text = "Fecha probable de parto";
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(652, 384);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(136, 20);
            this.btnBuscar.TabIndex = 65;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(296, 384);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(136, 20);
            this.btnNuevo.TabIndex = 64;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(154, 384);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(136, 20);
            this.btnModificar.TabIndex = 63;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(457, 384);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(136, 20);
            this.btnCancelar.TabIndex = 62;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(-8, 384);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(136, 20);
            this.btnGuardar.TabIndex = 61;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // udNumeroEmb
            // 
            this.udNumeroEmb.Location = new System.Drawing.Point(207, 134);
            this.udNumeroEmb.Name = "udNumeroEmb";
            this.udNumeroEmb.Size = new System.Drawing.Size(103, 20);
            this.udNumeroEmb.TabIndex = 35;
            // 
            // frmGestionarGestacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pnlCtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGestionarGestacion";
            this.Text = "Gestionar Gestacion";
            this.pnlCtn.ResumeLayout(false);
            this.gbDatosGenerales.ResumeLayout(false);
            this.gbDatosGenerales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udNumeroEmb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlCtn;
        private System.Windows.Forms.GroupBox gbDatosGenerales;
        private System.Windows.Forms.Label lblNumEmbarazo;
        private System.Windows.Forms.TextBox txtMedico;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.TextBox txtClinica;
        private System.Windows.Forms.Label lblClinica;
        private System.Windows.Forms.DateTimePicker dtpFPP;
        private System.Windows.Forms.Label lblFPP;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.NumericUpDown udNumeroEmb;
    }
}