namespace Bendiciones
{
    partial class frmBuscarDocente
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarDocente));
			this.dgvProfesores = new System.Windows.Forms.DataGridView();
			this.btnSeleccionar = new System.Windows.Forms.Button();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Profesion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvProfesores)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvProfesores
			// 
			this.dgvProfesores.AllowUserToAddRows = false;
			this.dgvProfesores.AllowUserToDeleteRows = false;
			this.dgvProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProfesores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DNI,
            this.Nombre,
            this.Profesion,
            this.Sexo});
			this.dgvProfesores.Location = new System.Drawing.Point(66, 191);
			this.dgvProfesores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dgvProfesores.Name = "dgvProfesores";
			this.dgvProfesores.ReadOnly = true;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvProfesores.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.dgvProfesores.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvProfesores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvProfesores.Size = new System.Drawing.Size(860, 307);
			this.dgvProfesores.TabIndex = 17;
			this.dgvProfesores.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvProfesores_CellFormatting);
			// 
			// btnSeleccionar
			// 
			this.btnSeleccionar.FlatAppearance.BorderSize = 0;
			this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSeleccionar.Location = new System.Drawing.Point(571, 146);
			this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnSeleccionar.Name = "btnSeleccionar";
			this.btnSeleccionar.Size = new System.Drawing.Size(133, 37);
			this.btnSeleccionar.TabIndex = 16;
			this.btnSeleccionar.Text = "Seleccionar";
			this.btnSeleccionar.UseVisualStyleBackColor = true;
			this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
			// 
			// btnBuscar
			// 
			this.btnBuscar.FlatAppearance.BorderSize = 0;
			this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuscar.Location = new System.Drawing.Point(421, 146);
			this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(133, 37);
			this.btnBuscar.TabIndex = 15;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// txtNombre
			// 
			this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(243, 114);
			this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(607, 30);
			this.txtNombre.TabIndex = 13;
			// 
			// btnEliminar
			// 
			this.btnEliminar.FlatAppearance.BorderSize = 0;
			this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEliminar.Location = new System.Drawing.Point(717, 146);
			this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(133, 37);
			this.btnEliminar.TabIndex = 18;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// DNI
			// 
			this.DNI.HeaderText = "DNI";
			this.DNI.Name = "DNI";
			this.DNI.ReadOnly = true;
			// 
			// Nombre
			// 
			this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Nombre.HeaderText = "Nombre";
			this.Nombre.Name = "Nombre";
			this.Nombre.ReadOnly = true;
			// 
			// Profesion
			// 
			this.Profesion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Profesion.HeaderText = "Profesión";
			this.Profesion.Name = "Profesion";
			this.Profesion.ReadOnly = true;
			// 
			// Sexo
			// 
			this.Sexo.HeaderText = "Sexo";
			this.Sexo.Name = "Sexo";
			this.Sexo.ReadOnly = true;
			// 
			// frmBuscarDocente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(981, 517);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.dgvProfesores);
			this.Controls.Add(this.btnSeleccionar);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.txtNombre);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "frmBuscarDocente";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Buscar Docente";
			((System.ComponentModel.ISupportInitialize)(this.dgvProfesores)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProfesores;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn Profesion;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
	}
}