namespace Bendiciones
{
    partial class frmBuscarColaborador
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarColaborador));
			this.dgvColaborador = new System.Windows.Forms.DataGridView();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnSeleccionar = new System.Windows.Forms.Button();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.btnEliminar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvColaborador)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvColaborador
			// 
			this.dgvColaborador.AllowUserToAddRows = false;
			this.dgvColaborador.AllowUserToDeleteRows = false;
			this.dgvColaborador.AllowUserToResizeRows = false;
			this.dgvColaborador.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvColaborador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvColaborador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Tipo});
			this.dgvColaborador.Location = new System.Drawing.Point(66, 205);
			this.dgvColaborador.Margin = new System.Windows.Forms.Padding(4);
			this.dgvColaborador.Name = "dgvColaborador";
			this.dgvColaborador.ReadOnly = true;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.dgvColaborador.RowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvColaborador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvColaborador.Size = new System.Drawing.Size(860, 307);
			this.dgvColaborador.TabIndex = 21;
			this.dgvColaborador.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvColaborador_CellFormatting);
			// 
			// Nombre
			// 
			this.Nombre.HeaderText = "Nombre";
			this.Nombre.Name = "Nombre";
			this.Nombre.ReadOnly = true;
			this.Nombre.Width = 420;
			// 
			// Tipo
			// 
			this.Tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Tipo.HeaderText = "Tipo";
			this.Tipo.Name = "Tipo";
			this.Tipo.ReadOnly = true;
			// 
			// btnSeleccionar
			// 
			this.btnSeleccionar.FlatAppearance.BorderSize = 0;
			this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSeleccionar.Location = new System.Drawing.Point(732, 125);
			this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(4);
			this.btnSeleccionar.Name = "btnSeleccionar";
			this.btnSeleccionar.Size = new System.Drawing.Size(133, 37);
			this.btnSeleccionar.TabIndex = 20;
			this.btnSeleccionar.Text = "Seleccionar";
			this.btnSeleccionar.UseVisualStyleBackColor = true;
			this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
			// 
			// btnBuscar
			// 
			this.btnBuscar.FlatAppearance.BorderSize = 0;
			this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuscar.Location = new System.Drawing.Point(569, 125);
			this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(133, 37);
			this.btnBuscar.TabIndex = 19;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// txtNombre
			// 
			this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(338, 64);
			this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(607, 30);
			this.txtNombre.TabIndex = 18;
			// 
			// btnEliminar
			// 
			this.btnEliminar.FlatAppearance.BorderSize = 0;
			this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEliminar.Location = new System.Drawing.Point(873, 125);
			this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(133, 37);
			this.btnEliminar.TabIndex = 22;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// frmBuscarColaborador
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 554);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.dgvColaborador);
			this.Controls.Add(this.btnSeleccionar);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.txtNombre);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmBuscarColaborador";
			this.Text = "Buscar Colaborador";
			((System.ComponentModel.ISupportInitialize)(this.dgvColaborador)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvColaborador;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
    }
}