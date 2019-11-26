namespace Bendiciones
{
    partial class frmAsignarDescuento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsignarDescuento));
            this.dgvDescuentos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gbCurso = new System.Windows.Forms.GroupBox();
            this.btnbuscarCurso = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombreServicio = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pnlCtn = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescuentos)).BeginInit();
            this.gbCurso.SuspendLayout();
            this.pnlCtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDescuentos
            // 
            this.dgvDescuentos.AllowUserToAddRows = false;
            this.dgvDescuentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDescuentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Sel});
            this.dgvDescuentos.Location = new System.Drawing.Point(3, 82);
            this.dgvDescuentos.Name = "dgvDescuentos";
            this.dgvDescuentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDescuentos.Size = new System.Drawing.Size(576, 168);
            this.dgvDescuentos.TabIndex = 1;
            this.dgvDescuentos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDescuentos_CellFormatting);
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
            // gbCurso
            // 
            this.gbCurso.Controls.Add(this.btnbuscarCurso);
            this.gbCurso.Controls.Add(this.lblNombre);
            this.gbCurso.Controls.Add(this.txtNombreServicio);
            this.gbCurso.Location = new System.Drawing.Point(3, 3);
            this.gbCurso.Name = "gbCurso";
            this.gbCurso.Size = new System.Drawing.Size(576, 73);
            this.gbCurso.TabIndex = 41;
            this.gbCurso.TabStop = false;
            this.gbCurso.Text = "Curso";
            // 
            // btnbuscarCurso
            // 
            this.btnbuscarCurso.FlatAppearance.BorderSize = 0;
            this.btnbuscarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscarCurso.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscarCurso.Location = new System.Drawing.Point(518, 26);
            this.btnbuscarCurso.Name = "btnbuscarCurso";
            this.btnbuscarCurso.Size = new System.Drawing.Size(40, 25);
            this.btnbuscarCurso.TabIndex = 32;
            this.btnbuscarCurso.Text = "...";
            this.btnbuscarCurso.UseVisualStyleBackColor = true;
            this.btnbuscarCurso.Click += new System.EventHandler(this.btnbuscarCurso_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(26, 27);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(84, 24);
            this.lblNombre.TabIndex = 30;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombreServicio
            // 
            this.txtNombreServicio.Enabled = false;
            this.txtNombreServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreServicio.HideSelection = false;
            this.txtNombreServicio.Location = new System.Drawing.Point(116, 26);
            this.txtNombreServicio.Name = "txtNombreServicio";
            this.txtNombreServicio.Size = new System.Drawing.Size(396, 26);
            this.txtNombreServicio.TabIndex = 31;
            this.txtNombreServicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(403, 270);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(176, 25);
            this.btnGuardar.TabIndex = 42;
            this.btnGuardar.Text = "Guardar cambios";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pnlCtn
            // 
            this.pnlCtn.Controls.Add(this.btnGuardar);
            this.pnlCtn.Controls.Add(this.gbCurso);
            this.pnlCtn.Controls.Add(this.dgvDescuentos);
            this.pnlCtn.Location = new System.Drawing.Point(27, 42);
            this.pnlCtn.Name = "pnlCtn";
            this.pnlCtn.Size = new System.Drawing.Size(594, 315);
            this.pnlCtn.TabIndex = 43;
            // 
            // frmAsignarDescuento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 399);
            this.Controls.Add(this.pnlCtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAsignarDescuento";
            this.Text = "Asignar Descuento";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescuentos)).EndInit();
            this.gbCurso.ResumeLayout(false);
            this.gbCurso.PerformLayout();
            this.pnlCtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDescuentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Sel;
        private System.Windows.Forms.GroupBox gbCurso;
        private System.Windows.Forms.Button btnbuscarCurso;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombreServicio;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel pnlCtn;
    }
}