namespace Bendiciones
{
    partial class frmHistoricoCuotasServicio
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistoricoCuotasServicio));
			this.gbServicio = new System.Windows.Forms.GroupBox();
			this.txtDescuento = new System.Windows.Forms.TextBox();
			this.lblDescuento = new System.Windows.Forms.Label();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.lblPrecio = new System.Windows.Forms.Label();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.lblDescripcion = new System.Windows.Forms.Label();
			this.dtpFechaMatricula = new System.Windows.Forms.DateTimePicker();
			this.lblFechaMatricula = new System.Windows.Forms.Label();
			this.btnListarServicios = new System.Windows.Forms.Button();
			this.lblNombreServicio = new System.Windows.Forms.Label();
			this.txtNombreServicio = new System.Windows.Forms.TextBox();
			this.gbCliente = new System.Windows.Forms.GroupBox();
			this.lblNombre = new System.Windows.Forms.Label();
			this.txtNombreCliente = new System.Windows.Forms.TextBox();
			this.btnBuscarCliente = new System.Windows.Forms.Button();
			this.lblDNI = new System.Windows.Forms.Label();
			this.txtDNI = new System.Windows.Forms.TextBox();
			this.gbHistorico = new System.Windows.Forms.GroupBox();
			this.txtSaldo = new System.Windows.Forms.TextBox();
			this.lblSaldo = new System.Windows.Forms.Label();
			this.dgvHistorico = new System.Windows.Forms.DataGridView();
			this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FormaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gbServicio.SuspendLayout();
			this.gbCliente.SuspendLayout();
			this.gbHistorico.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).BeginInit();
			this.SuspendLayout();
			// 
			// gbServicio
			// 
			this.gbServicio.Controls.Add(this.txtDescuento);
			this.gbServicio.Controls.Add(this.lblDescuento);
			this.gbServicio.Controls.Add(this.txtPrecio);
			this.gbServicio.Controls.Add(this.lblPrecio);
			this.gbServicio.Controls.Add(this.txtDescripcion);
			this.gbServicio.Controls.Add(this.lblDescripcion);
			this.gbServicio.Controls.Add(this.dtpFechaMatricula);
			this.gbServicio.Controls.Add(this.lblFechaMatricula);
			this.gbServicio.Controls.Add(this.btnListarServicios);
			this.gbServicio.Controls.Add(this.lblNombreServicio);
			this.gbServicio.Controls.Add(this.txtNombreServicio);
			this.gbServicio.Location = new System.Drawing.Point(69, 175);
			this.gbServicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.gbServicio.Name = "gbServicio";
			this.gbServicio.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.gbServicio.Size = new System.Drawing.Size(704, 343);
			this.gbServicio.TabIndex = 41;
			this.gbServicio.TabStop = false;
			this.gbServicio.Text = "Servicio";
			// 
			// txtDescuento
			// 
			this.txtDescuento.Enabled = false;
			this.txtDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDescuento.HideSelection = false;
			this.txtDescuento.Location = new System.Drawing.Point(177, 224);
			this.txtDescuento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtDescuento.Name = "txtDescuento";
			this.txtDescuento.Size = new System.Drawing.Size(245, 30);
			this.txtDescuento.TabIndex = 42;
			this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lblDescuento
			// 
			this.lblDescuento.AutoSize = true;
			this.lblDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDescuento.Location = new System.Drawing.Point(9, 226);
			this.lblDescuento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDescuento.Name = "lblDescuento";
			this.lblDescuento.Size = new System.Drawing.Size(134, 29);
			this.lblDescuento.TabIndex = 41;
			this.lblDescuento.Text = "Descuento:";
			// 
			// txtPrecio
			// 
			this.txtPrecio.Enabled = false;
			this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrecio.HideSelection = false;
			this.txtPrecio.Location = new System.Drawing.Point(177, 283);
			this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(119, 30);
			this.txtPrecio.TabIndex = 40;
			this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lblPrecio
			// 
			this.lblPrecio.AutoSize = true;
			this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPrecio.Location = new System.Drawing.Point(4, 283);
			this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblPrecio.Name = "lblPrecio";
			this.lblPrecio.Size = new System.Drawing.Size(161, 29);
			this.lblPrecio.TabIndex = 37;
			this.lblPrecio.Text = "Total a pagar:";
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Enabled = false;
			this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDescripcion.HideSelection = false;
			this.txtDescripcion.Location = new System.Drawing.Point(177, 149);
			this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtDescripcion.MinimumSize = new System.Drawing.Size(399, 50);
			this.txtDescripcion.Multiline = true;
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(441, 50);
			this.txtDescripcion.TabIndex = 36;
			this.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lblDescripcion
			// 
			this.lblDescripcion.AutoSize = true;
			this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDescripcion.Location = new System.Drawing.Point(4, 150);
			this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDescripcion.Name = "lblDescripcion";
			this.lblDescripcion.Size = new System.Drawing.Size(147, 29);
			this.lblDescripcion.TabIndex = 35;
			this.lblDescripcion.Text = "Descripción:";
			// 
			// dtpFechaMatricula
			// 
			this.dtpFechaMatricula.Enabled = false;
			this.dtpFechaMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFechaMatricula.Location = new System.Drawing.Point(235, 89);
			this.dtpFechaMatricula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dtpFechaMatricula.Name = "dtpFechaMatricula";
			this.dtpFechaMatricula.Size = new System.Drawing.Size(383, 30);
			this.dtpFechaMatricula.TabIndex = 34;
			// 
			// lblFechaMatricula
			// 
			this.lblFechaMatricula.AutoSize = true;
			this.lblFechaMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFechaMatricula.Location = new System.Drawing.Point(4, 90);
			this.lblFechaMatricula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblFechaMatricula.Name = "lblFechaMatricula";
			this.lblFechaMatricula.Size = new System.Drawing.Size(223, 29);
			this.lblFechaMatricula.TabIndex = 33;
			this.lblFechaMatricula.Text = "Fecha de matrícula:";
			// 
			// btnListarServicios
			// 
			this.btnListarServicios.FlatAppearance.BorderSize = 0;
			this.btnListarServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnListarServicios.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnListarServicios.Location = new System.Drawing.Point(637, 30);
			this.btnListarServicios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnListarServicios.Name = "btnListarServicios";
			this.btnListarServicios.Size = new System.Drawing.Size(43, 25);
			this.btnListarServicios.TabIndex = 32;
			this.btnListarServicios.Text = "...";
			this.btnListarServicios.UseVisualStyleBackColor = true;
			this.btnListarServicios.Click += new System.EventHandler(this.btnListarServicios_Click);
			// 
			// lblNombreServicio
			// 
			this.lblNombreServicio.AutoSize = true;
			this.lblNombreServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombreServicio.Location = new System.Drawing.Point(4, 30);
			this.lblNombreServicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblNombreServicio.Name = "lblNombreServicio";
			this.lblNombreServicio.Size = new System.Drawing.Size(107, 29);
			this.lblNombreServicio.TabIndex = 30;
			this.lblNombreServicio.Text = "Nombre:";
			// 
			// txtNombreServicio
			// 
			this.txtNombreServicio.Enabled = false;
			this.txtNombreServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombreServicio.HideSelection = false;
			this.txtNombreServicio.Location = new System.Drawing.Point(119, 30);
			this.txtNombreServicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtNombreServicio.Name = "txtNombreServicio";
			this.txtNombreServicio.Size = new System.Drawing.Size(499, 30);
			this.txtNombreServicio.TabIndex = 31;
			this.txtNombreServicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// gbCliente
			// 
			this.gbCliente.Controls.Add(this.lblNombre);
			this.gbCliente.Controls.Add(this.txtNombreCliente);
			this.gbCliente.Controls.Add(this.btnBuscarCliente);
			this.gbCliente.Controls.Add(this.lblDNI);
			this.gbCliente.Controls.Add(this.txtDNI);
			this.gbCliente.Location = new System.Drawing.Point(69, 26);
			this.gbCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.gbCliente.Name = "gbCliente";
			this.gbCliente.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.gbCliente.Size = new System.Drawing.Size(704, 142);
			this.gbCliente.TabIndex = 40;
			this.gbCliente.TabStop = false;
			this.gbCliente.Text = "Cliente";
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombre.Location = new System.Drawing.Point(4, 90);
			this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(107, 29);
			this.lblNombre.TabIndex = 33;
			this.lblNombre.Text = "Nombre:";
			// 
			// txtNombreCliente
			// 
			this.txtNombreCliente.Enabled = false;
			this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombreCliente.HideSelection = false;
			this.txtNombreCliente.Location = new System.Drawing.Point(117, 90);
			this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtNombreCliente.Name = "txtNombreCliente";
			this.txtNombreCliente.Size = new System.Drawing.Size(501, 30);
			this.txtNombreCliente.TabIndex = 34;
			this.txtNombreCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btnBuscarCliente
			// 
			this.btnBuscarCliente.FlatAppearance.BorderSize = 0;
			this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuscarCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscarCliente.Location = new System.Drawing.Point(363, 30);
			this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnBuscarCliente.Name = "btnBuscarCliente";
			this.btnBuscarCliente.Size = new System.Drawing.Size(43, 25);
			this.btnBuscarCliente.TabIndex = 32;
			this.btnBuscarCliente.Text = "...";
			this.btnBuscarCliente.UseVisualStyleBackColor = true;
			this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
			// 
			// lblDNI
			// 
			this.lblDNI.AutoSize = true;
			this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDNI.Location = new System.Drawing.Point(4, 30);
			this.lblDNI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDNI.Name = "lblDNI";
			this.lblDNI.Size = new System.Drawing.Size(60, 29);
			this.lblDNI.TabIndex = 30;
			this.lblDNI.Text = "DNI:";
			// 
			// txtDNI
			// 
			this.txtDNI.Enabled = false;
			this.txtDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDNI.HideSelection = false;
			this.txtDNI.Location = new System.Drawing.Point(117, 30);
			this.txtDNI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtDNI.Name = "txtDNI";
			this.txtDNI.Size = new System.Drawing.Size(221, 30);
			this.txtDNI.TabIndex = 31;
			this.txtDNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// gbHistorico
			// 
			this.gbHistorico.Controls.Add(this.txtSaldo);
			this.gbHistorico.Controls.Add(this.lblSaldo);
			this.gbHistorico.Controls.Add(this.dgvHistorico);
			this.gbHistorico.Location = new System.Drawing.Point(79, 555);
			this.gbHistorico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.gbHistorico.Name = "gbHistorico";
			this.gbHistorico.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.gbHistorico.Size = new System.Drawing.Size(704, 289);
			this.gbHistorico.TabIndex = 41;
			this.gbHistorico.TabStop = false;
			this.gbHistorico.Text = "Histórico";
			// 
			// txtSaldo
			// 
			this.txtSaldo.Enabled = false;
			this.txtSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSaldo.HideSelection = false;
			this.txtSaldo.Location = new System.Drawing.Point(521, 231);
			this.txtSaldo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtSaldo.Name = "txtSaldo";
			this.txtSaldo.Size = new System.Drawing.Size(159, 30);
			this.txtSaldo.TabIndex = 39;
			this.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lblSaldo
			// 
			this.lblSaldo.AutoSize = true;
			this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSaldo.Location = new System.Drawing.Point(415, 231);
			this.lblSaldo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblSaldo.Name = "lblSaldo";
			this.lblSaldo.Size = new System.Drawing.Size(82, 29);
			this.lblSaldo.TabIndex = 40;
			this.lblSaldo.Text = "Saldo:";
			// 
			// dgvHistorico
			// 
			this.dgvHistorico.AllowUserToAddRows = false;
			this.dgvHistorico.AllowUserToDeleteRows = false;
			this.dgvHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHistorico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Monto,
            this.FormaPago});
			this.dgvHistorico.Location = new System.Drawing.Point(4, 30);
			this.dgvHistorico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dgvHistorico.Name = "dgvHistorico";
			this.dgvHistorico.ReadOnly = true;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.dgvHistorico.RowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvHistorico.Size = new System.Drawing.Size(676, 185);
			this.dgvHistorico.TabIndex = 0;
			// 
			// Fecha
			// 
			this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Fecha.HeaderText = "Fecha";
			this.Fecha.Name = "Fecha";
			this.Fecha.ReadOnly = true;
			// 
			// Monto
			// 
			this.Monto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Monto.HeaderText = "Monto";
			this.Monto.Name = "Monto";
			this.Monto.ReadOnly = true;
			// 
			// FormaPago
			// 
			this.FormaPago.HeaderText = "Forma de Pago";
			this.FormaPago.Name = "FormaPago";
			this.FormaPago.ReadOnly = true;
			this.FormaPago.Width = 182;
			// 
			// frmHistoricoCuotasServicio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(837, 873);
			this.Controls.Add(this.gbHistorico);
			this.Controls.Add(this.gbServicio);
			this.Controls.Add(this.gbCliente);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "frmHistoricoCuotasServicio";
			this.Text = "Historial de Cuotas";
			this.gbServicio.ResumeLayout(false);
			this.gbServicio.PerformLayout();
			this.gbCliente.ResumeLayout(false);
			this.gbCliente.PerformLayout();
			this.gbHistorico.ResumeLayout(false);
			this.gbHistorico.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbServicio;
        private System.Windows.Forms.Label lblNombreServicio;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.DateTimePicker dtpFechaMatricula;
        private System.Windows.Forms.Label lblFechaMatricula;
        private System.Windows.Forms.Button btnListarServicios;
        private System.Windows.Forms.TextBox txtNombreServicio;
        private System.Windows.Forms.GroupBox gbHistorico;
        private System.Windows.Forms.DataGridView dgvHistorico;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormaPago;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label lblDescuento;
    }
}