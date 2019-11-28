namespace Bendiciones
{
    partial class frmInscribirAHorario
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.pnlCtn = new System.Windows.Forms.Panel();
			this.btnSeleccionarHorario = new System.Windows.Forms.Button();
			this.gbServicio = new System.Windows.Forms.GroupBox();
			this.btnBuscarHorarios = new System.Windows.Forms.Button();
			this.dgvHorarios = new System.Windows.Forms.DataGridView();
			this.Clase = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sede = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HoraIni = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NumVac = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cboServicios = new System.Windows.Forms.ComboBox();
			this.gbCliente = new System.Windows.Forms.GroupBox();
			this.lblBebe = new System.Windows.Forms.Label();
			this.cboBebes = new System.Windows.Forms.ComboBox();
			this.lblNombre = new System.Windows.Forms.Label();
			this.txtNombreCliente = new System.Windows.Forms.TextBox();
			this.btnBuscarCliente = new System.Windows.Forms.Button();
			this.lblDNI = new System.Windows.Forms.Label();
			this.txtDNI = new System.Windows.Forms.TextBox();
			this.listarMatriculaActivaPorGestanteResponseBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.pnlCtn.SuspendLayout();
			this.gbServicio.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).BeginInit();
			this.gbCliente.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.listarMatriculaActivaPorGestanteResponseBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlCtn
			// 
			this.pnlCtn.AutoScroll = true;
			this.pnlCtn.Controls.Add(this.btnSeleccionarHorario);
			this.pnlCtn.Controls.Add(this.gbServicio);
			this.pnlCtn.Controls.Add(this.gbCliente);
			this.pnlCtn.Location = new System.Drawing.Point(40, 39);
			this.pnlCtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pnlCtn.Name = "pnlCtn";
			this.pnlCtn.Size = new System.Drawing.Size(923, 523);
			this.pnlCtn.TabIndex = 0;
			// 
			// btnSeleccionarHorario
			// 
			this.btnSeleccionarHorario.FlatAppearance.BorderSize = 0;
			this.btnSeleccionarHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSeleccionarHorario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSeleccionarHorario.Location = new System.Drawing.Point(675, 550);
			this.btnSeleccionarHorario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnSeleccionarHorario.Name = "btnSeleccionarHorario";
			this.btnSeleccionarHorario.Size = new System.Drawing.Size(212, 31);
			this.btnSeleccionarHorario.TabIndex = 40;
			this.btnSeleccionarHorario.Text = "Seleccionar Horario";
			this.btnSeleccionarHorario.UseVisualStyleBackColor = true;
			this.btnSeleccionarHorario.Click += new System.EventHandler(this.btnSeleccionarHorario_Click);
			// 
			// gbServicio
			// 
			this.gbServicio.Controls.Add(this.btnBuscarHorarios);
			this.gbServicio.Controls.Add(this.dgvHorarios);
			this.gbServicio.Controls.Add(this.cboServicios);
			this.gbServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbServicio.Location = new System.Drawing.Point(4, 208);
			this.gbServicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.gbServicio.Name = "gbServicio";
			this.gbServicio.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.gbServicio.Size = new System.Drawing.Size(883, 335);
			this.gbServicio.TabIndex = 43;
			this.gbServicio.TabStop = false;
			this.gbServicio.Text = "Servicio";
			// 
			// btnBuscarHorarios
			// 
			this.btnBuscarHorarios.FlatAppearance.BorderSize = 0;
			this.btnBuscarHorarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuscarHorarios.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscarHorarios.Location = new System.Drawing.Point(663, 25);
			this.btnBuscarHorarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnBuscarHorarios.Name = "btnBuscarHorarios";
			this.btnBuscarHorarios.Size = new System.Drawing.Size(192, 31);
			this.btnBuscarHorarios.TabIndex = 44;
			this.btnBuscarHorarios.Text = "Buscar Horarios";
			this.btnBuscarHorarios.UseVisualStyleBackColor = true;
			this.btnBuscarHorarios.Click += new System.EventHandler(this.btnBuscarHorarios_Click);
			// 
			// dgvHorarios
			// 
			this.dgvHorarios.AllowUserToAddRows = false;
			this.dgvHorarios.AllowUserToDeleteRows = false;
			this.dgvHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHorarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clase,
            this.Sede,
            this.HoraIni,
            this.HoraFin,
            this.Fecha,
            this.NumVac});
			this.dgvHorarios.Location = new System.Drawing.Point(9, 90);
			this.dgvHorarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dgvHorarios.Name = "dgvHorarios";
			this.dgvHorarios.ReadOnly = true;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.dgvHorarios.RowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvHorarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvHorarios.Size = new System.Drawing.Size(865, 238);
			this.dgvHorarios.TabIndex = 39;
			// 
			// Clase
			// 
			this.Clase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Clase.HeaderText = "Clase";
			this.Clase.Name = "Clase";
			this.Clase.ReadOnly = true;
			// 
			// Sede
			// 
			this.Sede.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Sede.HeaderText = "Sede";
			this.Sede.Name = "Sede";
			this.Sede.ReadOnly = true;
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
			this.HoraFin.HeaderText = "Hora fin";
			this.HoraFin.Name = "HoraFin";
			this.HoraFin.ReadOnly = true;
			// 
			// Fecha
			// 
			this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Fecha.HeaderText = "Fecha";
			this.Fecha.Name = "Fecha";
			this.Fecha.ReadOnly = true;
			// 
			// NumVac
			// 
			this.NumVac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.NumVac.HeaderText = "Número de vacantes";
			this.NumVac.Name = "NumVac";
			this.NumVac.ReadOnly = true;
			// 
			// cboServicios
			// 
			this.cboServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboServicios.FormattingEnabled = true;
			this.cboServicios.Location = new System.Drawing.Point(119, 25);
			this.cboServicios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cboServicios.Name = "cboServicios";
			this.cboServicios.Size = new System.Drawing.Size(535, 33);
			this.cboServicios.TabIndex = 38;
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
			this.gbCliente.Location = new System.Drawing.Point(4, 4);
			this.gbCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.gbCliente.Name = "gbCliente";
			this.gbCliente.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.gbCliente.Size = new System.Drawing.Size(883, 197);
			this.gbCliente.TabIndex = 41;
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
			this.btnBuscarCliente.Location = new System.Drawing.Point(349, 30);
			this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnBuscarCliente.Name = "btnBuscarCliente";
			this.btnBuscarCliente.Size = new System.Drawing.Size(53, 31);
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
			// listarMatriculaActivaPorGestanteResponseBindingSource
			// 
			this.listarMatriculaActivaPorGestanteResponseBindingSource.DataSource = typeof(Bendiciones.Service.listarMatriculaActivaPorGestanteResponse);
			// 
			// frmInscribirAHorario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1319, 729);
			this.Controls.Add(this.pnlCtn);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "frmInscribirAHorario";
			this.Text = "frmInscribirAHorario";
			this.pnlCtn.ResumeLayout(false);
			this.gbServicio.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).EndInit();
			this.gbCliente.ResumeLayout(false);
			this.gbCliente.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.listarMatriculaActivaPorGestanteResponseBindingSource)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCtn;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Label lblBebe;
        private System.Windows.Forms.ComboBox cboBebes;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.GroupBox gbServicio;
        private System.Windows.Forms.DataGridView dgvHorarios;
        private System.Windows.Forms.ComboBox cboServicios;
        private System.Windows.Forms.Button btnSeleccionarHorario;
        private System.Windows.Forms.Button btnBuscarHorarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clase;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sede;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraIni;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumVac;
        private System.Windows.Forms.BindingSource listarMatriculaActivaPorGestanteResponseBindingSource;
    }
}