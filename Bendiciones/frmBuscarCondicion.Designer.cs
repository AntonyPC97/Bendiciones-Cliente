namespace Bendiciones
{
    partial class frmBuscarCondicion
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarCondicion));
			this.dgvCondiciones = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnSeleccionar = new System.Windows.Forms.Button();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.btnEliminar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvCondiciones)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvCondiciones
			// 
			this.dgvCondiciones.AllowUserToAddRows = false;
			this.dgvCondiciones.AllowUserToDeleteRows = false;
			this.dgvCondiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCondiciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre});
			this.dgvCondiciones.Location = new System.Drawing.Point(41, 212);
			this.dgvCondiciones.Margin = new System.Windows.Forms.Padding(4);
			this.dgvCondiciones.Name = "dgvCondiciones";
			this.dgvCondiciones.ReadOnly = true;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvCondiciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.dgvCondiciones.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvCondiciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCondiciones.Size = new System.Drawing.Size(860, 307);
			this.dgvCondiciones.TabIndex = 12;
			this.dgvCondiciones.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCondiciones_CellFormatting);
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Width = 50;
			// 
			// Nombre
			// 
			this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Nombre.HeaderText = "Nombre";
			this.Nombre.Name = "Nombre";
			this.Nombre.ReadOnly = true;
			// 
			// btnSeleccionar
			// 
			this.btnSeleccionar.FlatAppearance.BorderSize = 0;
			this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSeleccionar.Location = new System.Drawing.Point(719, 154);
			this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(4);
			this.btnSeleccionar.Name = "btnSeleccionar";
			this.btnSeleccionar.Size = new System.Drawing.Size(133, 37);
			this.btnSeleccionar.TabIndex = 11;
			this.btnSeleccionar.Text = "Seleccionar";
			this.btnSeleccionar.UseVisualStyleBackColor = true;
			this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
			// 
			// btnBuscar
			// 
			this.btnBuscar.FlatAppearance.BorderSize = 0;
			this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuscar.Location = new System.Drawing.Point(569, 154);
			this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(133, 37);
			this.btnBuscar.TabIndex = 10;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(245, 122);
			this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(607, 22);
			this.txtNombre.TabIndex = 8;
			// 
			// btnEliminar
			// 
			this.btnEliminar.FlatAppearance.BorderSize = 0;
			this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEliminar.Location = new System.Drawing.Point(449, 154);
			this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(133, 37);
			this.btnEliminar.TabIndex = 13;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// frmBuscarCondicion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(987, 532);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.dgvCondiciones);
			this.Controls.Add(this.btnSeleccionar);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.txtNombre);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmBuscarCondicion";
			this.Text = "Buscar Condiciones";
			((System.ComponentModel.ISupportInitialize)(this.dgvCondiciones)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCondiciones;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}