﻿namespace Bendiciones
{
    partial class frmAgregarCursoMatricula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarCursoMatricula));
            this.gbServicio = new System.Windows.Forms.GroupBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecioO = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnListarServicios = new System.Windows.Forms.Button();
            this.lblNombreServicio = new System.Windows.Forms.Label();
            this.txtNombreServicio = new System.Windows.Forms.TextBox();
            this.dgvCondicionesMedicas = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.cboDescuentos = new System.Windows.Forms.ComboBox();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.cboFormaPago = new System.Windows.Forms.ComboBox();
            this.lblFormaPago = new System.Windows.Forms.Label();
            this.lblAbonar = new System.Windows.Forms.Label();
            this.txtAbonar = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbRestricciones = new System.Windows.Forms.GroupBox();
            this.gbServicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCondicionesMedicas)).BeginInit();
            this.gbCliente.SuspendLayout();
            this.gbRestricciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbServicio
            // 
            this.gbServicio.Controls.Add(this.txtPrecio);
            this.gbServicio.Controls.Add(this.lblPrecioO);
            this.gbServicio.Controls.Add(this.txtDescripcion);
            this.gbServicio.Controls.Add(this.lblDescripcion);
            this.gbServicio.Controls.Add(this.btnListarServicios);
            this.gbServicio.Controls.Add(this.lblNombreServicio);
            this.gbServicio.Controls.Add(this.txtNombreServicio);
            this.gbServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbServicio.Location = new System.Drawing.Point(16, 23);
            this.gbServicio.Name = "gbServicio";
            this.gbServicio.Size = new System.Drawing.Size(431, 174);
            this.gbServicio.TabIndex = 42;
            this.gbServicio.TabStop = false;
            this.gbServicio.Text = "Servicio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPrecio.Location = new System.Drawing.Point(121, 126);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(264, 26);
            this.txtPrecio.TabIndex = 43;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPrecioO
            // 
            this.lblPrecioO.AutoSize = true;
            this.lblPrecioO.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblPrecioO.Location = new System.Drawing.Point(3, 126);
            this.lblPrecioO.Name = "lblPrecioO";
            this.lblPrecioO.Size = new System.Drawing.Size(69, 24);
            this.lblPrecioO.TabIndex = 42;
            this.lblPrecioO.Text = "Precio:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.HideSelection = false;
            this.txtDescripcion.Location = new System.Drawing.Point(119, 73);
            this.txtDescripcion.MinimumSize = new System.Drawing.Size(264, 41);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(264, 41);
            this.txtDescripcion.TabIndex = 36;
            this.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(3, 73);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(115, 24);
            this.lblDescripcion.TabIndex = 35;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // btnListarServicios
            // 
            this.btnListarServicios.FlatAppearance.BorderSize = 0;
            this.btnListarServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarServicios.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarServicios.Location = new System.Drawing.Point(388, 24);
            this.btnListarServicios.Name = "btnListarServicios";
            this.btnListarServicios.Size = new System.Drawing.Size(32, 20);
            this.btnListarServicios.TabIndex = 32;
            this.btnListarServicios.Text = "...";
            this.btnListarServicios.UseVisualStyleBackColor = true;
            this.btnListarServicios.Click += new System.EventHandler(this.btnListarServicios_Click);
            // 
            // lblNombreServicio
            // 
            this.lblNombreServicio.AutoSize = true;
            this.lblNombreServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreServicio.Location = new System.Drawing.Point(3, 24);
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
            this.txtNombreServicio.Location = new System.Drawing.Point(119, 24);
            this.txtNombreServicio.Name = "txtNombreServicio";
            this.txtNombreServicio.Size = new System.Drawing.Size(264, 26);
            this.txtNombreServicio.TabIndex = 31;
            this.txtNombreServicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgvCondicionesMedicas
            // 
            this.dgvCondicionesMedicas.AllowUserToAddRows = false;
            this.dgvCondicionesMedicas.AllowUserToDeleteRows = false;
            this.dgvCondicionesMedicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCondicionesMedicas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Descripcion});
            this.dgvCondicionesMedicas.Location = new System.Drawing.Point(7, 18);
            this.dgvCondicionesMedicas.Name = "dgvCondicionesMedicas";
            this.dgvCondicionesMedicas.ReadOnly = true;
            this.dgvCondicionesMedicas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCondicionesMedicas.Size = new System.Drawing.Size(413, 109);
            this.dgvCondicionesMedicas.TabIndex = 39;
            this.dgvCondicionesMedicas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCondicionesMedicas_CellFormatting);
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.txtTotal);
            this.gbCliente.Controls.Add(this.labelTotal);
            this.gbCliente.Controls.Add(this.lblSaldo);
            this.gbCliente.Controls.Add(this.txtSaldo);
            this.gbCliente.Controls.Add(this.cboDescuentos);
            this.gbCliente.Controls.Add(this.lblDescuento);
            this.gbCliente.Controls.Add(this.cboFormaPago);
            this.gbCliente.Controls.Add(this.lblFormaPago);
            this.gbCliente.Controls.Add(this.lblAbonar);
            this.gbCliente.Controls.Add(this.txtAbonar);
            this.gbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCliente.Location = new System.Drawing.Point(17, 350);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(332, 283);
            this.gbCliente.TabIndex = 43;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTotal.Location = new System.Drawing.Point(119, 73);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(191, 26);
            this.txtTotal.TabIndex = 44;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.labelTotal.Location = new System.Drawing.Point(3, 73);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(56, 24);
            this.labelTotal.TabIndex = 41;
            this.labelTotal.Text = "Total:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(3, 171);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(63, 24);
            this.lblSaldo.TabIndex = 39;
            this.lblSaldo.Text = "Saldo:";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Enabled = false;
            this.txtSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldo.HideSelection = false;
            this.txtSaldo.Location = new System.Drawing.Point(119, 171);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(192, 26);
            this.txtSaldo.TabIndex = 40;
            this.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cboDescuentos
            // 
            this.cboDescuentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDescuentos.FormattingEnabled = true;
            this.cboDescuentos.Location = new System.Drawing.Point(119, 24);
            this.cboDescuentos.Name = "cboDescuentos";
            this.cboDescuentos.Size = new System.Drawing.Size(192, 28);
            this.cboDescuentos.TabIndex = 38;
            this.cboDescuentos.SelectedIndexChanged += new System.EventHandler(this.cboDescuentos_SelectedIndexChanged);
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.Location = new System.Drawing.Point(3, 24);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(106, 24);
            this.lblDescuento.TabIndex = 37;
            this.lblDescuento.Text = "Descuento:";
            // 
            // cboFormaPago
            // 
            this.cboFormaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFormaPago.FormattingEnabled = true;
            this.cboFormaPago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta"});
            this.cboFormaPago.Location = new System.Drawing.Point(147, 220);
            this.cboFormaPago.Name = "cboFormaPago";
            this.cboFormaPago.Size = new System.Drawing.Size(164, 28);
            this.cboFormaPago.TabIndex = 36;
            // 
            // lblFormaPago
            // 
            this.lblFormaPago.AutoSize = true;
            this.lblFormaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaPago.Location = new System.Drawing.Point(3, 220);
            this.lblFormaPago.Name = "lblFormaPago";
            this.lblFormaPago.Size = new System.Drawing.Size(145, 24);
            this.lblFormaPago.TabIndex = 35;
            this.lblFormaPago.Text = "Forma de pago:";
            // 
            // lblAbonar
            // 
            this.lblAbonar.AutoSize = true;
            this.lblAbonar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbonar.Location = new System.Drawing.Point(3, 122);
            this.lblAbonar.Name = "lblAbonar";
            this.lblAbonar.Size = new System.Drawing.Size(77, 24);
            this.lblAbonar.TabIndex = 33;
            this.lblAbonar.Text = "Abonar:";
            // 
            // txtAbonar
            // 
            this.txtAbonar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbonar.HideSelection = false;
            this.txtAbonar.Location = new System.Drawing.Point(119, 122);
            this.txtAbonar.Name = "txtAbonar";
            this.txtAbonar.Size = new System.Drawing.Size(192, 26);
            this.txtAbonar.TabIndex = 34;
            this.txtAbonar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAbonar.TextChanged += new System.EventHandler(this.txtAbonar_TextChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(355, 395);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 20);
            this.btnCancelar.TabIndex = 45;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(355, 360);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(92, 20);
            this.btnGuardar.TabIndex = 44;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gbRestricciones
            // 
            this.gbRestricciones.Controls.Add(this.dgvCondicionesMedicas);
            this.gbRestricciones.Location = new System.Drawing.Point(16, 202);
            this.gbRestricciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbRestricciones.Name = "gbRestricciones";
            this.gbRestricciones.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbRestricciones.Size = new System.Drawing.Size(431, 143);
            this.gbRestricciones.TabIndex = 46;
            this.gbRestricciones.TabStop = false;
            this.gbRestricciones.Text = "Restricciones Medicas";
            // 
            // frmAgregarCursoMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 645);
            this.Controls.Add(this.gbRestricciones);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.gbServicio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAgregarCursoMatricula";
            this.Text = "Agregar Curso";
            this.gbServicio.ResumeLayout(false);
            this.gbServicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCondicionesMedicas)).EndInit();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.gbRestricciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbServicio;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnListarServicios;
        private System.Windows.Forms.Label lblNombreServicio;
        private System.Windows.Forms.TextBox txtNombreServicio;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.ComboBox cboFormaPago;
        private System.Windows.Forms.Label lblFormaPago;
        private System.Windows.Forms.Label lblAbonar;
        private System.Windows.Forms.TextBox txtAbonar;
        protected internal System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.ComboBox cboDescuentos;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvCondicionesMedicas;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
		private System.Windows.Forms.GroupBox gbRestricciones;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label lblPrecioO;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtTotal;
    }
}