﻿namespace Bendiciones
{
    partial class frmAsignarHorario
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
			this.gbCurso = new System.Windows.Forms.GroupBox();
			this.btnbuscarCurso = new System.Windows.Forms.Button();
			this.lblNombre = new System.Windows.Forms.Label();
			this.txtNombreServicio = new System.Windows.Forms.TextBox();
			this.dgvHorarios = new System.Windows.Forms.DataGridView();
			this.Num_clase = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HoraIni = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Profesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sede = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NumVac = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnAddHorario = new System.Windows.Forms.Button();
			this.btnEliminarHorario = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.pnlCtn = new System.Windows.Forms.Panel();
			this.gbCurso.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).BeginInit();
			this.pnlCtn.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbCurso
			// 
			this.gbCurso.Controls.Add(this.btnbuscarCurso);
			this.gbCurso.Controls.Add(this.lblNombre);
			this.gbCurso.Controls.Add(this.txtNombreServicio);
			this.gbCurso.Location = new System.Drawing.Point(43, 4);
			this.gbCurso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.gbCurso.Name = "gbCurso";
			this.gbCurso.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.gbCurso.Size = new System.Drawing.Size(940, 90);
			this.gbCurso.TabIndex = 40;
			this.gbCurso.TabStop = false;
			this.gbCurso.Text = "Curso";
			// 
			// btnbuscarCurso
			// 
			this.btnbuscarCurso.FlatAppearance.BorderSize = 0;
			this.btnbuscarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnbuscarCurso.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnbuscarCurso.Location = new System.Drawing.Point(879, 30);
			this.btnbuscarCurso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnbuscarCurso.Name = "btnbuscarCurso";
			this.btnbuscarCurso.Size = new System.Drawing.Size(53, 31);
			this.btnbuscarCurso.TabIndex = 32;
			this.btnbuscarCurso.Text = "...";
			this.btnbuscarCurso.UseVisualStyleBackColor = true;
			this.btnbuscarCurso.Click += new System.EventHandler(this.btnbuscarCurso_Click);
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombre.Location = new System.Drawing.Point(35, 33);
			this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(107, 29);
			this.lblNombre.TabIndex = 30;
			this.lblNombre.Text = "Nombre:";
			// 
			// txtNombreServicio
			// 
			this.txtNombreServicio.Enabled = false;
			this.txtNombreServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombreServicio.HideSelection = false;
			this.txtNombreServicio.Location = new System.Drawing.Point(153, 30);
			this.txtNombreServicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtNombreServicio.Name = "txtNombreServicio";
			this.txtNombreServicio.Size = new System.Drawing.Size(716, 30);
			this.txtNombreServicio.TabIndex = 31;
			this.txtNombreServicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// dgvHorarios
			// 
			this.dgvHorarios.AllowUserToAddRows = false;
			this.dgvHorarios.AllowUserToDeleteRows = false;
			this.dgvHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHorarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num_clase,
            this.HoraIni,
            this.HoraFin,
            this.Profesor,
            this.Fecha,
            this.Sede,
            this.NumVac});
			this.dgvHorarios.Location = new System.Drawing.Point(43, 161);
			this.dgvHorarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dgvHorarios.Name = "dgvHorarios";
			this.dgvHorarios.ReadOnly = true;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.dgvHorarios.RowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvHorarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvHorarios.Size = new System.Drawing.Size(975, 299);
			this.dgvHorarios.TabIndex = 41;
			this.dgvHorarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHorarios_CellDoubleClick);
			// 
			// Num_clase
			// 
			this.Num_clase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Num_clase.HeaderText = "Número de clase";
			this.Num_clase.Name = "Num_clase";
			this.Num_clase.ReadOnly = true;
			// 
			// HoraIni
			// 
			this.HoraIni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.HoraIni.HeaderText = "Hora Inicio";
			this.HoraIni.Name = "HoraIni";
			this.HoraIni.ReadOnly = true;
			// 
			// HoraFin
			// 
			this.HoraFin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.HoraFin.HeaderText = "Hora Fin";
			this.HoraFin.Name = "HoraFin";
			this.HoraFin.ReadOnly = true;
			// 
			// Profesor
			// 
			this.Profesor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Profesor.HeaderText = "Profesor";
			this.Profesor.Name = "Profesor";
			this.Profesor.ReadOnly = true;
			// 
			// Fecha
			// 
			this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Fecha.HeaderText = "Fecha";
			this.Fecha.Name = "Fecha";
			this.Fecha.ReadOnly = true;
			// 
			// Sede
			// 
			this.Sede.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Sede.HeaderText = "Sede";
			this.Sede.Name = "Sede";
			this.Sede.ReadOnly = true;
			// 
			// NumVac
			// 
			this.NumVac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.NumVac.HeaderText = "Vacantes";
			this.NumVac.Name = "NumVac";
			this.NumVac.ReadOnly = true;
			// 
			// btnAddHorario
			// 
			this.btnAddHorario.FlatAppearance.BorderSize = 0;
			this.btnAddHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddHorario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddHorario.Location = new System.Drawing.Point(860, 108);
			this.btnAddHorario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnAddHorario.Name = "btnAddHorario";
			this.btnAddHorario.Size = new System.Drawing.Size(53, 31);
			this.btnAddHorario.TabIndex = 33;
			this.btnAddHorario.Text = "+";
			this.btnAddHorario.UseVisualStyleBackColor = true;
			this.btnAddHorario.Click += new System.EventHandler(this.btnAddHorario_Click);
			// 
			// btnEliminarHorario
			// 
			this.btnEliminarHorario.FlatAppearance.BorderSize = 0;
			this.btnEliminarHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEliminarHorario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminarHorario.Location = new System.Drawing.Point(921, 108);
			this.btnEliminarHorario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnEliminarHorario.Name = "btnEliminarHorario";
			this.btnEliminarHorario.Size = new System.Drawing.Size(53, 31);
			this.btnEliminarHorario.TabIndex = 42;
			this.btnEliminarHorario.Text = "-";
			this.btnEliminarHorario.UseVisualStyleBackColor = true;
			this.btnEliminarHorario.Click += new System.EventHandler(this.btnEliminarHorario_Click);
			// 
			// btnGuardar
			// 
			this.btnGuardar.FlatAppearance.BorderSize = 0;
			this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGuardar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardar.Location = new System.Drawing.Point(748, 490);
			this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(235, 31);
			this.btnGuardar.TabIndex = 33;
			this.btnGuardar.Text = "Guardar cambios";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// pnlCtn
			// 
			this.pnlCtn.Controls.Add(this.btnGuardar);
			this.pnlCtn.Controls.Add(this.btnEliminarHorario);
			this.pnlCtn.Controls.Add(this.btnAddHorario);
			this.pnlCtn.Controls.Add(this.dgvHorarios);
			this.pnlCtn.Controls.Add(this.gbCurso);
			this.pnlCtn.Location = new System.Drawing.Point(93, 80);
			this.pnlCtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pnlCtn.Name = "pnlCtn";
			this.pnlCtn.Size = new System.Drawing.Size(1047, 554);
			this.pnlCtn.TabIndex = 43;
			// 
			// frmAsignarHorario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1327, 747);
			this.Controls.Add(this.pnlCtn);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "frmAsignarHorario";
			this.Text = "frmAsignarHorario";
			this.gbCurso.ResumeLayout(false);
			this.gbCurso.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).EndInit();
			this.pnlCtn.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCurso;
        private System.Windows.Forms.Button btnbuscarCurso;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombreServicio;
        private System.Windows.Forms.DataGridView dgvHorarios;
        private System.Windows.Forms.DataGridViewButtonColumn AddDocente;
        private System.Windows.Forms.Button btnAddHorario;
        private System.Windows.Forms.Button btnEliminarHorario;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel pnlCtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_clase;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraIni;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sede;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumVac;
    }
}