﻿namespace Bendiciones
{
    partial class frmBuscarClaseParticular
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
			this.lblBuscarClaseParticular = new System.Windows.Forms.Label();
			this.pnlContainer = new System.Windows.Forms.Panel();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.gbCliente = new System.Windows.Forms.GroupBox();
			this.lblNombre = new System.Windows.Forms.Label();
			this.txtNombreCliente = new System.Windows.Forms.TextBox();
			this.btnBuscarCliente = new System.Windows.Forms.Button();
			this.lblDNI = new System.Windows.Forms.Label();
			this.txtDNI = new System.Windows.Forms.TextBox();
			this.dgvClasesParticulares = new System.Windows.Forms.DataGridView();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FechaServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnSeleccionar = new System.Windows.Forms.Button();
			this.pnlContainer.SuspendLayout();
			this.gbCliente.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvClasesParticulares)).BeginInit();
			this.SuspendLayout();
			// 
			// lblBuscarClaseParticular
			// 
			this.lblBuscarClaseParticular.AutoSize = true;
			this.lblBuscarClaseParticular.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBuscarClaseParticular.Location = new System.Drawing.Point(92, 38);
			this.lblBuscarClaseParticular.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblBuscarClaseParticular.Name = "lblBuscarClaseParticular";
			this.lblBuscarClaseParticular.Size = new System.Drawing.Size(289, 28);
			this.lblBuscarClaseParticular.TabIndex = 5;
			this.lblBuscarClaseParticular.Text = "Buscar Clase Particular";
			// 
			// pnlContainer
			// 
			this.pnlContainer.Controls.Add(this.btnEliminar);
			this.pnlContainer.Controls.Add(this.gbCliente);
			this.pnlContainer.Controls.Add(this.dgvClasesParticulares);
			this.pnlContainer.Controls.Add(this.btnSeleccionar);
			this.pnlContainer.Location = new System.Drawing.Point(97, 102);
			this.pnlContainer.Margin = new System.Windows.Forms.Padding(4);
			this.pnlContainer.Name = "pnlContainer";
			this.pnlContainer.Size = new System.Drawing.Size(879, 481);
			this.pnlContainer.TabIndex = 4;
			// 
			// btnEliminar
			// 
			this.btnEliminar.FlatAppearance.BorderSize = 0;
			this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEliminar.Location = new System.Drawing.Point(524, 187);
			this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(133, 37);
			this.btnEliminar.TabIndex = 43;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// gbCliente
			// 
			this.gbCliente.Controls.Add(this.lblNombre);
			this.gbCliente.Controls.Add(this.txtNombreCliente);
			this.gbCliente.Controls.Add(this.btnBuscarCliente);
			this.gbCliente.Controls.Add(this.lblDNI);
			this.gbCliente.Controls.Add(this.txtDNI);
			this.gbCliente.Location = new System.Drawing.Point(83, 23);
			this.gbCliente.Margin = new System.Windows.Forms.Padding(4);
			this.gbCliente.Name = "gbCliente";
			this.gbCliente.Padding = new System.Windows.Forms.Padding(4);
			this.gbCliente.Size = new System.Drawing.Size(716, 139);
			this.gbCliente.TabIndex = 42;
			this.gbCliente.TabStop = false;
			this.gbCliente.Text = "Cliente";
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombre.Location = new System.Drawing.Point(67, 82);
			this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(68, 20);
			this.lblNombre.TabIndex = 33;
			this.lblNombre.Text = "Nombre";
			// 
			// txtNombreCliente
			// 
			this.txtNombreCliente.Enabled = false;
			this.txtNombreCliente.HideSelection = false;
			this.txtNombreCliente.Location = new System.Drawing.Point(171, 82);
			this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(4);
			this.txtNombreCliente.Name = "txtNombreCliente";
			this.txtNombreCliente.Size = new System.Drawing.Size(501, 22);
			this.txtNombreCliente.TabIndex = 34;
			this.txtNombreCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btnBuscarCliente
			// 
			this.btnBuscarCliente.FlatAppearance.BorderSize = 0;
			this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuscarCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscarCliente.Location = new System.Drawing.Point(413, 32);
			this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(4);
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
			this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDNI.Location = new System.Drawing.Point(67, 32);
			this.lblDNI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDNI.Name = "lblDNI";
			this.lblDNI.Size = new System.Drawing.Size(38, 20);
			this.lblDNI.TabIndex = 30;
			this.lblDNI.Text = "DNI";
			// 
			// txtDNI
			// 
			this.txtDNI.Enabled = false;
			this.txtDNI.HideSelection = false;
			this.txtDNI.Location = new System.Drawing.Point(171, 32);
			this.txtDNI.Margin = new System.Windows.Forms.Padding(4);
			this.txtDNI.Name = "txtDNI";
			this.txtDNI.Size = new System.Drawing.Size(221, 22);
			this.txtDNI.TabIndex = 31;
			this.txtDNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// dgvClasesParticulares
			// 
			this.dgvClasesParticulares.AllowUserToAddRows = false;
			this.dgvClasesParticulares.AllowUserToDeleteRows = false;
			this.dgvClasesParticulares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvClasesParticulares.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Precio,
            this.FechaServicio});
			this.dgvClasesParticulares.Location = new System.Drawing.Point(97, 257);
			this.dgvClasesParticulares.Margin = new System.Windows.Forms.Padding(4);
			this.dgvClasesParticulares.Name = "dgvClasesParticulares";
			this.dgvClasesParticulares.ReadOnly = true;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.dgvClasesParticulares.RowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvClasesParticulares.Size = new System.Drawing.Size(701, 185);
			this.dgvClasesParticulares.TabIndex = 17;
			// 
			// Nombre
			// 
			this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Nombre.HeaderText = "Nombre";
			this.Nombre.Name = "Nombre";
			this.Nombre.ReadOnly = true;
			// 
			// Precio
			// 
			this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Precio.HeaderText = "Precio";
			this.Precio.Name = "Precio";
			this.Precio.ReadOnly = true;
			// 
			// FechaServicio
			// 
			this.FechaServicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.FechaServicio.HeaderText = "FechaServicio";
			this.FechaServicio.Name = "FechaServicio";
			this.FechaServicio.ReadOnly = true;
			// 
			// btnSeleccionar
			// 
			this.btnSeleccionar.FlatAppearance.BorderSize = 0;
			this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSeleccionar.Location = new System.Drawing.Point(665, 187);
			this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(4);
			this.btnSeleccionar.Name = "btnSeleccionar";
			this.btnSeleccionar.Size = new System.Drawing.Size(133, 37);
			this.btnSeleccionar.TabIndex = 16;
			this.btnSeleccionar.Text = "Seleccionar";
			this.btnSeleccionar.UseVisualStyleBackColor = true;
			this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
			// 
			// frmBuscarClaseParticular
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 657);
			this.Controls.Add(this.lblBuscarClaseParticular);
			this.Controls.Add(this.pnlContainer);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmBuscarClaseParticular";
			this.Text = "frmBuscarClaseParticular";
			this.pnlContainer.ResumeLayout(false);
			this.gbCliente.ResumeLayout(false);
			this.gbCliente.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvClasesParticulares)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscarClaseParticular;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.DataGridView dgvClasesParticulares;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaServicio;
    }
}