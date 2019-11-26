namespace Bendiciones
{
    partial class frmCuotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCuotas));
            this.btnAbonar = new System.Windows.Forms.Button();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.gbServicio = new System.Windows.Forms.GroupBox();
            this.dtpFechaMatricula = new System.Windows.Forms.DateTimePicker();
            this.lblFechaMatricula = new System.Windows.Forms.Label();
            this.btnListarServicios = new System.Windows.Forms.Button();
            this.lblNombreServicio = new System.Windows.Forms.Label();
            this.txtNombreServicio = new System.Windows.Forms.TextBox();
            this.gbPago = new System.Windows.Forms.GroupBox();
            this.cboFormaPago = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAbonar = new System.Windows.Forms.Label();
            this.txtAbonar = new System.Windows.Forms.TextBox();
            this.lblPendiente = new System.Windows.Forms.Label();
            this.txtPendiente = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlCtn = new System.Windows.Forms.Panel();
            this.gbCliente.SuspendLayout();
            this.gbServicio.SuspendLayout();
            this.gbPago.SuspendLayout();
            this.pnlCtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAbonar
            // 
            this.btnAbonar.FlatAppearance.BorderSize = 0;
            this.btnAbonar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbonar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbonar.Location = new System.Drawing.Point(729, 325);
            this.btnAbonar.Name = "btnAbonar";
            this.btnAbonar.Size = new System.Drawing.Size(94, 20);
            this.btnAbonar.TabIndex = 35;
            this.btnAbonar.Text = "Abonar";
            this.btnAbonar.UseVisualStyleBackColor = true;
            this.btnAbonar.Click += new System.EventHandler(this.btnAbonar_Click);
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.lblNombre);
            this.gbCliente.Controls.Add(this.txtNombreCliente);
            this.gbCliente.Controls.Add(this.btnBuscarCliente);
            this.gbCliente.Controls.Add(this.lblDNI);
            this.gbCliente.Controls.Add(this.txtDNI);
            this.gbCliente.Location = new System.Drawing.Point(126, 20);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(597, 106);
            this.gbCliente.TabIndex = 38;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(3, 73);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(84, 24);
            this.lblNombre.TabIndex = 33;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Enabled = false;
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.HideSelection = false;
            this.txtNombreCliente.Location = new System.Drawing.Point(118, 73);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(377, 26);
            this.txtNombreCliente.TabIndex = 34;
            this.txtNombreCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.FlatAppearance.BorderSize = 0;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.Location = new System.Drawing.Point(290, 24);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(30, 25);
            this.btnBuscarCliente.TabIndex = 32;
            this.btnBuscarCliente.Text = "...";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(3, 24);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(46, 24);
            this.lblDNI.TabIndex = 30;
            this.lblDNI.Text = "DNI:";
            // 
            // txtDNI
            // 
            this.txtDNI.Enabled = false;
            this.txtDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.HideSelection = false;
            this.txtDNI.Location = new System.Drawing.Point(118, 24);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(167, 26);
            this.txtDNI.TabIndex = 31;
            this.txtDNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gbServicio
            // 
            this.gbServicio.Controls.Add(this.dtpFechaMatricula);
            this.gbServicio.Controls.Add(this.lblFechaMatricula);
            this.gbServicio.Controls.Add(this.btnListarServicios);
            this.gbServicio.Controls.Add(this.lblNombreServicio);
            this.gbServicio.Controls.Add(this.txtNombreServicio);
            this.gbServicio.Location = new System.Drawing.Point(126, 141);
            this.gbServicio.Name = "gbServicio";
            this.gbServicio.Size = new System.Drawing.Size(597, 106);
            this.gbServicio.TabIndex = 39;
            this.gbServicio.TabStop = false;
            this.gbServicio.Text = "Servicio";
            // 
            // dtpFechaMatricula
            // 
            this.dtpFechaMatricula.Enabled = false;
            this.dtpFechaMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaMatricula.Location = new System.Drawing.Point(176, 72);
            this.dtpFechaMatricula.Name = "dtpFechaMatricula";
            this.dtpFechaMatricula.Size = new System.Drawing.Size(319, 26);
            this.dtpFechaMatricula.TabIndex = 34;
            // 
            // lblFechaMatricula
            // 
            this.lblFechaMatricula.AutoSize = true;
            this.lblFechaMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaMatricula.Location = new System.Drawing.Point(3, 73);
            this.lblFechaMatricula.Name = "lblFechaMatricula";
            this.lblFechaMatricula.Size = new System.Drawing.Size(176, 24);
            this.lblFechaMatricula.TabIndex = 33;
            this.lblFechaMatricula.Text = "Fecha de matrícula:";
            // 
            // btnListarServicios
            // 
            this.btnListarServicios.FlatAppearance.BorderSize = 0;
            this.btnListarServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarServicios.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarServicios.Location = new System.Drawing.Point(501, 24);
            this.btnListarServicios.Name = "btnListarServicios";
            this.btnListarServicios.Size = new System.Drawing.Size(30, 25);
            this.btnListarServicios.TabIndex = 32;
            this.btnListarServicios.Text = "...";
            this.btnListarServicios.UseVisualStyleBackColor = true;
            this.btnListarServicios.Click += new System.EventHandler(this.btnListarServicios_Click);
            // 
            // lblNombreServicio
            // 
            this.lblNombreServicio.AutoSize = true;
            this.lblNombreServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreServicio.Location = new System.Drawing.Point(2, 24);
            this.lblNombreServicio.Name = "lblNombreServicio";
            this.lblNombreServicio.Size = new System.Drawing.Size(84, 24);
            this.lblNombreServicio.TabIndex = 30;
            this.lblNombreServicio.Text = "Nombre:";
            // 
            // txtNombreServicio
            // 
            this.txtNombreServicio.Enabled = false;
            this.txtNombreServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreServicio.HideSelection = false;
            this.txtNombreServicio.Location = new System.Drawing.Point(176, 24);
            this.txtNombreServicio.Name = "txtNombreServicio";
            this.txtNombreServicio.Size = new System.Drawing.Size(320, 26);
            this.txtNombreServicio.TabIndex = 31;
            this.txtNombreServicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gbPago
            // 
            this.gbPago.Controls.Add(this.cboFormaPago);
            this.gbPago.Controls.Add(this.label1);
            this.gbPago.Controls.Add(this.lblAbonar);
            this.gbPago.Controls.Add(this.txtAbonar);
            this.gbPago.Controls.Add(this.lblPendiente);
            this.gbPago.Controls.Add(this.txtPendiente);
            this.gbPago.Location = new System.Drawing.Point(126, 262);
            this.gbPago.Name = "gbPago";
            this.gbPago.Size = new System.Drawing.Size(597, 159);
            this.gbPago.TabIndex = 39;
            this.gbPago.TabStop = false;
            this.gbPago.Text = "Pago";
            // 
            // cboFormaPago
            // 
            this.cboFormaPago.AutoCompleteCustomSource.AddRange(new string[] {
            "Efectivo",
            "Tarjeta"});
            this.cboFormaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFormaPago.FormattingEnabled = true;
            this.cboFormaPago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta"});
            this.cboFormaPago.Location = new System.Drawing.Point(156, 122);
            this.cboFormaPago.Name = "cboFormaPago";
            this.cboFormaPago.Size = new System.Drawing.Size(168, 28);
            this.cboFormaPago.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 24);
            this.label1.TabIndex = 35;
            this.label1.Text = "Forma de pago:";
            // 
            // lblAbonar
            // 
            this.lblAbonar.AutoSize = true;
            this.lblAbonar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbonar.Location = new System.Drawing.Point(3, 73);
            this.lblAbonar.Name = "lblAbonar";
            this.lblAbonar.Size = new System.Drawing.Size(77, 24);
            this.lblAbonar.TabIndex = 33;
            this.lblAbonar.Text = "Abonar:";
            // 
            // txtAbonar
            // 
            this.txtAbonar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbonar.HideSelection = false;
            this.txtAbonar.Location = new System.Drawing.Point(156, 73);
            this.txtAbonar.Name = "txtAbonar";
            this.txtAbonar.Size = new System.Drawing.Size(168, 26);
            this.txtAbonar.TabIndex = 34;
            this.txtAbonar.Text = "0";
            this.txtAbonar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPendiente
            // 
            this.lblPendiente.AutoSize = true;
            this.lblPendiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendiente.Location = new System.Drawing.Point(3, 24);
            this.lblPendiente.Name = "lblPendiente";
            this.lblPendiente.Size = new System.Drawing.Size(101, 24);
            this.lblPendiente.TabIndex = 30;
            this.lblPendiente.Text = "Pendiente:";
            // 
            // txtPendiente
            // 
            this.txtPendiente.Enabled = false;
            this.txtPendiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPendiente.HideSelection = false;
            this.txtPendiente.Location = new System.Drawing.Point(156, 24);
            this.txtPendiente.Name = "txtPendiente";
            this.txtPendiente.Size = new System.Drawing.Size(168, 26);
            this.txtPendiente.TabIndex = 31;
            this.txtPendiente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(744, 286);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(64, 20);
            this.btnCancelar.TabIndex = 40;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pnlCtn
            // 
            this.pnlCtn.AutoScroll = true;
            this.pnlCtn.Controls.Add(this.gbPago);
            this.pnlCtn.Controls.Add(this.btnAbonar);
            this.pnlCtn.Controls.Add(this.btnCancelar);
            this.pnlCtn.Controls.Add(this.gbServicio);
            this.pnlCtn.Controls.Add(this.gbCliente);
            this.pnlCtn.Location = new System.Drawing.Point(76, 91);
            this.pnlCtn.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCtn.Name = "pnlCtn";
            this.pnlCtn.Size = new System.Drawing.Size(849, 347);
            this.pnlCtn.TabIndex = 41;
            // 
            // frmCuotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(963, 599);
            this.Controls.Add(this.pnlCtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCuotas";
            this.Text = "Pagos";
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.gbServicio.ResumeLayout(false);
            this.gbServicio.PerformLayout();
            this.gbPago.ResumeLayout(false);
            this.gbPago.PerformLayout();
            this.pnlCtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAbonar;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.GroupBox gbServicio;
        private System.Windows.Forms.DateTimePicker dtpFechaMatricula;
        private System.Windows.Forms.Label lblFechaMatricula;
        private System.Windows.Forms.Button btnListarServicios;
        private System.Windows.Forms.Label lblNombreServicio;
        private System.Windows.Forms.TextBox txtNombreServicio;
        private System.Windows.Forms.GroupBox gbPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAbonar;
        private System.Windows.Forms.TextBox txtAbonar;
        protected internal System.Windows.Forms.Label lblPendiente;
        private System.Windows.Forms.TextBox txtPendiente;
        private System.Windows.Forms.ComboBox cboFormaPago;
        private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Panel pnlCtn;
	}
}