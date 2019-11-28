namespace Bendiciones
{
    partial class frmGestionarCurso
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
			this.gbDatosGenerales = new System.Windows.Forms.GroupBox();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.udNumClases = new System.Windows.Forms.NumericUpDown();
			this.txtNombreCurso = new System.Windows.Forms.TextBox();
			this.lblNumClases = new System.Windows.Forms.Label();
			this.lblDescripcion = new System.Windows.Forms.Label();
			this.lblNombreCurso = new System.Windows.Forms.Label();
			this.lblPrecio = new System.Windows.Forms.Label();
			this.gbCondicionesMedicas = new System.Windows.Forms.GroupBox();
			this.dgvCondiciones = new System.Windows.Forms.DataGridView();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.pnlCtn = new System.Windows.Forms.Panel();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.gbDatosGenerales.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.udNumClases)).BeginInit();
			this.gbCondicionesMedicas.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCondiciones)).BeginInit();
			this.pnlCtn.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbDatosGenerales
			// 
			this.gbDatosGenerales.Controls.Add(this.txtDescripcion);
			this.gbDatosGenerales.Controls.Add(this.txtPrecio);
			this.gbDatosGenerales.Controls.Add(this.udNumClases);
			this.gbDatosGenerales.Controls.Add(this.txtNombreCurso);
			this.gbDatosGenerales.Controls.Add(this.lblNumClases);
			this.gbDatosGenerales.Controls.Add(this.lblDescripcion);
			this.gbDatosGenerales.Controls.Add(this.lblNombreCurso);
			this.gbDatosGenerales.Controls.Add(this.lblPrecio);
			this.gbDatosGenerales.Location = new System.Drawing.Point(4, 4);
			this.gbDatosGenerales.Margin = new System.Windows.Forms.Padding(4);
			this.gbDatosGenerales.Name = "gbDatosGenerales";
			this.gbDatosGenerales.Padding = new System.Windows.Forms.Padding(4);
			this.gbDatosGenerales.Size = new System.Drawing.Size(457, 250);
			this.gbDatosGenerales.TabIndex = 60;
			this.gbDatosGenerales.TabStop = false;
			this.gbDatosGenerales.Text = "Datos Generales";
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Location = new System.Drawing.Point(172, 113);
			this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
			this.txtDescripcion.MaxLength = 150;
			this.txtDescripcion.Multiline = true;
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(257, 59);
			this.txtDescripcion.TabIndex = 3;
			// 
			// txtPrecio
			// 
			this.txtPrecio.Location = new System.Drawing.Point(172, 76);
			this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
			this.txtPrecio.MaxLength = 7;
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(257, 22);
			this.txtPrecio.TabIndex = 2;
			// 
			// udNumClases
			// 
			this.udNumClases.Location = new System.Drawing.Point(361, 207);
			this.udNumClases.Margin = new System.Windows.Forms.Padding(4);
			this.udNumClases.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
			this.udNumClases.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.udNumClases.Name = "udNumClases";
			this.udNumClases.Size = new System.Drawing.Size(69, 22);
			this.udNumClases.TabIndex = 4;
			this.udNumClases.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// txtNombreCurso
			// 
			this.txtNombreCurso.Location = new System.Drawing.Point(172, 36);
			this.txtNombreCurso.Margin = new System.Windows.Forms.Padding(4);
			this.txtNombreCurso.MaxLength = 100;
			this.txtNombreCurso.Name = "txtNombreCurso";
			this.txtNombreCurso.Size = new System.Drawing.Size(257, 22);
			this.txtNombreCurso.TabIndex = 1;
			// 
			// lblNumClases
			// 
			this.lblNumClases.AutoSize = true;
			this.lblNumClases.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumClases.Location = new System.Drawing.Point(33, 207);
			this.lblNumClases.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblNumClases.Name = "lblNumClases";
			this.lblNumClases.Size = new System.Drawing.Size(175, 25);
			this.lblNumClases.TabIndex = 26;
			this.lblNumClases.Text = "Número de clases:";
			// 
			// lblDescripcion
			// 
			this.lblDescripcion.AutoSize = true;
			this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDescripcion.Location = new System.Drawing.Point(33, 111);
			this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDescripcion.Name = "lblDescripcion";
			this.lblDescripcion.Size = new System.Drawing.Size(120, 25);
			this.lblDescripcion.TabIndex = 25;
			this.lblDescripcion.Text = "Descripción:";
			// 
			// lblNombreCurso
			// 
			this.lblNombreCurso.AutoSize = true;
			this.lblNombreCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombreCurso.Location = new System.Drawing.Point(33, 37);
			this.lblNombreCurso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblNombreCurso.Name = "lblNombreCurso";
			this.lblNombreCurso.Size = new System.Drawing.Size(87, 25);
			this.lblNombreCurso.TabIndex = 24;
			this.lblNombreCurso.Text = "Nombre:";
			// 
			// lblPrecio
			// 
			this.lblPrecio.AutoSize = true;
			this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPrecio.Location = new System.Drawing.Point(33, 74);
			this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblPrecio.Name = "lblPrecio";
			this.lblPrecio.Size = new System.Drawing.Size(73, 25);
			this.lblPrecio.TabIndex = 23;
			this.lblPrecio.Text = "Precio:";
			// 
			// gbCondicionesMedicas
			// 
			this.gbCondicionesMedicas.Controls.Add(this.dgvCondiciones);
			this.gbCondicionesMedicas.Location = new System.Drawing.Point(488, 4);
			this.gbCondicionesMedicas.Margin = new System.Windows.Forms.Padding(4);
			this.gbCondicionesMedicas.Name = "gbCondicionesMedicas";
			this.gbCondicionesMedicas.Padding = new System.Windows.Forms.Padding(4);
			this.gbCondicionesMedicas.Size = new System.Drawing.Size(476, 250);
			this.gbCondicionesMedicas.TabIndex = 61;
			this.gbCondicionesMedicas.TabStop = false;
			this.gbCondicionesMedicas.Text = "Condiciones Médicas";
			// 
			// dgvCondiciones
			// 
			this.dgvCondiciones.AllowUserToAddRows = false;
			this.dgvCondiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCondiciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Sel});
			this.dgvCondiciones.Location = new System.Drawing.Point(27, 36);
			this.dgvCondiciones.Margin = new System.Windows.Forms.Padding(4);
			this.dgvCondiciones.Name = "dgvCondiciones";
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.dgvCondiciones.RowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvCondiciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCondiciones.Size = new System.Drawing.Size(441, 207);
			this.dgvCondiciones.TabIndex = 0;
			this.dgvCondiciones.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCondiciones_CellFormatting);
			// 
			// Nombre
			// 
			this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Nombre.HeaderText = "Nombre";
			this.Nombre.Name = "Nombre";
			// 
			// Sel
			// 
			this.Sel.HeaderText = "Sel";
			this.Sel.Name = "Sel";
			this.Sel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Sel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.Sel.Width = 50;
			// 
			// pnlCtn
			// 
			this.pnlCtn.Controls.Add(this.gbDatosGenerales);
			this.pnlCtn.Controls.Add(this.gbCondicionesMedicas);
			this.pnlCtn.Location = new System.Drawing.Point(113, 146);
			this.pnlCtn.Margin = new System.Windows.Forms.Padding(4);
			this.pnlCtn.Name = "pnlCtn";
			this.pnlCtn.Size = new System.Drawing.Size(968, 258);
			this.pnlCtn.TabIndex = 63;
			// 
			// btnModificar
			// 
			this.btnModificar.FlatAppearance.BorderSize = 0;
			this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnModificar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModificar.Location = new System.Drawing.Point(367, 487);
			this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(181, 25);
			this.btnModificar.TabIndex = 8;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.FlatAppearance.BorderSize = 0;
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.Location = new System.Drawing.Point(745, 487);
			this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(181, 25);
			this.btnCancelar.TabIndex = 9;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnGuardar
			// 
			this.btnGuardar.FlatAppearance.BorderSize = 0;
			this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGuardar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardar.Location = new System.Drawing.Point(151, 487);
			this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(181, 25);
			this.btnGuardar.TabIndex = 7;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// btnBuscar
			// 
			this.btnBuscar.FlatAppearance.BorderSize = 0;
			this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscar.Location = new System.Drawing.Point(16, 487);
			this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(181, 25);
			this.btnBuscar.TabIndex = 6;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// btnNuevo
			// 
			this.btnNuevo.FlatAppearance.BorderSize = 0;
			this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNuevo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNuevo.Location = new System.Drawing.Point(539, 487);
			this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(181, 25);
			this.btnNuevo.TabIndex = 5;
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.UseVisualStyleBackColor = true;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// frmGestionarCurso
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1112, 617);
			this.Controls.Add(this.btnNuevo);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.pnlCtn);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmGestionarCurso";
			this.Text = "frmGestionarCurso";
			this.gbDatosGenerales.ResumeLayout(false);
			this.gbDatosGenerales.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.udNumClases)).EndInit();
			this.gbCondicionesMedicas.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvCondiciones)).EndInit();
			this.pnlCtn.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbDatosGenerales;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.NumericUpDown udNumClases;
        private System.Windows.Forms.TextBox txtNombreCurso;
        private System.Windows.Forms.Label lblNumClases;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombreCurso;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.GroupBox gbCondicionesMedicas;
        private System.Windows.Forms.Panel pnlCtn;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvCondiciones;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Sel;
	}
}