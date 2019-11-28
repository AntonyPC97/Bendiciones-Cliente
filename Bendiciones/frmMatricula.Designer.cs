namespace Bendiciones
{
    partial class frmMatricula
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
			this.gbCliente = new System.Windows.Forms.GroupBox();
			this.lblBebe = new System.Windows.Forms.Label();
			this.cboBebes = new System.Windows.Forms.ComboBox();
			this.lblNombre = new System.Windows.Forms.Label();
			this.txtNombreCliente = new System.Windows.Forms.TextBox();
			this.btnBuscarCliente = new System.Windows.Forms.Button();
			this.lblDNI = new System.Windows.Forms.Label();
			this.txtDNI = new System.Windows.Forms.TextBox();
			this.gbCursos = new System.Windows.Forms.GroupBox();
			this.btnEliminarCurso = new System.Windows.Forms.Button();
			this.btnAgregarCurso = new System.Windows.Forms.Button();
			this.dgvMatriculas = new System.Windows.Forms.DataGridView();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MontoAPagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.pnlCtn = new System.Windows.Forms.Panel();
			this.gbCliente.SuspendLayout();
			this.gbCursos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvMatriculas)).BeginInit();
			this.pnlCtn.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbCliente
			// 
			this.gbCliente.Controls.Add(this.lblBebe);
			this.gbCliente.Controls.Add(this.cboBebes);
			this.gbCliente.Controls.Add(this.lblNombre);
			this.gbCliente.Controls.Add(this.txtNombreCliente);
			this.gbCliente.Controls.Add(this.btnBuscarCliente);
			this.gbCliente.Controls.Add(this.lblDNI);
			this.gbCliente.Controls.Add(this.txtDNI);
			this.gbCliente.Location = new System.Drawing.Point(16, 33);
			this.gbCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.gbCliente.Name = "gbCliente";
			this.gbCliente.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.gbCliente.Size = new System.Drawing.Size(883, 197);
			this.gbCliente.TabIndex = 39;
			this.gbCliente.TabStop = false;
			this.gbCliente.Text = "Cliente";
			// 
			// lblBebe
			// 
			this.lblBebe.AutoSize = true;
			this.lblBebe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBebe.Location = new System.Drawing.Point(4, 150);
			this.lblBebe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblBebe.Name = "lblBebe";
			this.lblBebe.Size = new System.Drawing.Size(77, 29);
			this.lblBebe.TabIndex = 37;
			this.lblBebe.Text = "Bebé:";
			// 
			// cboBebes
			// 
			this.cboBebes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboBebes.FormattingEnabled = true;
			this.cboBebes.Location = new System.Drawing.Point(119, 150);
			this.cboBebes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cboBebes.Name = "cboBebes";
			this.cboBebes.Size = new System.Drawing.Size(501, 33);
			this.cboBebes.TabIndex = 35;
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
			this.txtNombreCliente.Location = new System.Drawing.Point(119, 90);
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
			this.btnBuscarCliente.Location = new System.Drawing.Point(348, 30);
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
			this.txtDNI.Location = new System.Drawing.Point(119, 30);
			this.txtDNI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtDNI.Name = "txtDNI";
			this.txtDNI.Size = new System.Drawing.Size(221, 30);
			this.txtDNI.TabIndex = 31;
			this.txtDNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// gbCursos
			// 
			this.gbCursos.Controls.Add(this.btnEliminarCurso);
			this.gbCursos.Controls.Add(this.btnAgregarCurso);
			this.gbCursos.Controls.Add(this.dgvMatriculas);
			this.gbCursos.Location = new System.Drawing.Point(16, 238);
			this.gbCursos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.gbCursos.Name = "gbCursos";
			this.gbCursos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.gbCursos.Size = new System.Drawing.Size(883, 276);
			this.gbCursos.TabIndex = 42;
			this.gbCursos.TabStop = false;
			this.gbCursos.Text = "Cursos";
			// 
			// btnEliminarCurso
			// 
			this.btnEliminarCurso.FlatAppearance.BorderSize = 0;
			this.btnEliminarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEliminarCurso.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminarCurso.Location = new System.Drawing.Point(728, 23);
			this.btnEliminarCurso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnEliminarCurso.Name = "btnEliminarCurso";
			this.btnEliminarCurso.Size = new System.Drawing.Size(147, 31);
			this.btnEliminarCurso.TabIndex = 34;
			this.btnEliminarCurso.Text = "Eliminar Curso";
			this.btnEliminarCurso.UseVisualStyleBackColor = true;
			this.btnEliminarCurso.Click += new System.EventHandler(this.btnEliminarCurso_Click);
			// 
			// btnAgregarCurso
			// 
			this.btnAgregarCurso.FlatAppearance.BorderSize = 0;
			this.btnAgregarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAgregarCurso.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregarCurso.Location = new System.Drawing.Point(573, 23);
			this.btnAgregarCurso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnAgregarCurso.Name = "btnAgregarCurso";
			this.btnAgregarCurso.Size = new System.Drawing.Size(147, 31);
			this.btnAgregarCurso.TabIndex = 33;
			this.btnAgregarCurso.Text = "Agregar Curso";
			this.btnAgregarCurso.UseVisualStyleBackColor = true;
			this.btnAgregarCurso.Click += new System.EventHandler(this.btnAgregarCurso_Click);
			// 
			// dgvMatriculas
			// 
			this.dgvMatriculas.AllowUserToAddRows = false;
			this.dgvMatriculas.AllowUserToDeleteRows = false;
			this.dgvMatriculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMatriculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Fecha,
            this.Precio,
            this.MontoAPagar,
            this.Saldo,
            this.Descuento});
			this.dgvMatriculas.Location = new System.Drawing.Point(8, 62);
			this.dgvMatriculas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dgvMatriculas.Name = "dgvMatriculas";
			this.dgvMatriculas.ReadOnly = true;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.dgvMatriculas.RowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvMatriculas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvMatriculas.Size = new System.Drawing.Size(867, 196);
			this.dgvMatriculas.TabIndex = 1;
			// 
			// Nombre
			// 
			this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Nombre.HeaderText = "Nombre";
			this.Nombre.Name = "Nombre";
			this.Nombre.ReadOnly = true;
			// 
			// Fecha
			// 
			this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Fecha.HeaderText = "Fecha";
			this.Fecha.Name = "Fecha";
			this.Fecha.ReadOnly = true;
			// 
			// Precio
			// 
			this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Precio.HeaderText = "Precio";
			this.Precio.Name = "Precio";
			this.Precio.ReadOnly = true;
			// 
			// MontoAPagar
			// 
			this.MontoAPagar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.MontoAPagar.HeaderText = "Monto a Pagar";
			this.MontoAPagar.Name = "MontoAPagar";
			this.MontoAPagar.ReadOnly = true;
			// 
			// Saldo
			// 
			this.Saldo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Saldo.HeaderText = "Saldo";
			this.Saldo.Name = "Saldo";
			this.Saldo.ReadOnly = true;
			// 
			// Descuento
			// 
			this.Descuento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Descuento.HeaderText = "Descuento";
			this.Descuento.Name = "Descuento";
			this.Descuento.ReadOnly = true;
			// 
			// btnGuardar
			// 
			this.btnGuardar.FlatAppearance.BorderSize = 0;
			this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGuardar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardar.Location = new System.Drawing.Point(1049, 209);
			this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(181, 25);
			this.btnGuardar.TabIndex = 34;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.FlatAppearance.BorderSize = 0;
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.Location = new System.Drawing.Point(1049, 437);
			this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(181, 25);
			this.btnCancelar.TabIndex = 43;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// pnlCtn
			// 
			this.pnlCtn.Controls.Add(this.gbCursos);
			this.pnlCtn.Controls.Add(this.gbCliente);
			this.pnlCtn.Location = new System.Drawing.Point(63, 49);
			this.pnlCtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pnlCtn.Name = "pnlCtn";
			this.pnlCtn.Size = new System.Drawing.Size(941, 528);
			this.pnlCtn.TabIndex = 44;
			// 
			// frmMatricula
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1283, 665);
			this.Controls.Add(this.pnlCtn);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnGuardar);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "frmMatricula";
			this.Text = "frmMatricula";
			this.gbCliente.ResumeLayout(false);
			this.gbCliente.PerformLayout();
			this.gbCursos.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvMatriculas)).EndInit();
			this.pnlCtn.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.GroupBox gbCursos;
        private System.Windows.Forms.DataGridView dgvMatriculas;
        private System.Windows.Forms.Button btnAgregarCurso;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblBebe;
        private System.Windows.Forms.ComboBox cboBebes;
		private System.Windows.Forms.Panel pnlCtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoAPagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.Button btnEliminarCurso;
    }
}