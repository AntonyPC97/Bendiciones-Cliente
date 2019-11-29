namespace Bendiciones
{
    partial class frmAsistenciaCliente
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
            this.pnlCtn = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cboCursos = new System.Windows.Forms.ComboBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.tabAsistencia = new System.Windows.Forms.TabControl();
            this.tpPorAsistir = new System.Windows.Forms.TabPage();
            this.dgvPorAsistir = new System.Windows.Forms.DataGridView();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraIni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpYaAsistieron = new System.Windows.Forms.TabPage();
            this.dgvYaAsistieron = new System.Windows.Forms.DataGridView();
            this.dn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nomb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.pnlCtn.SuspendLayout();
            this.tabAsistencia.SuspendLayout();
            this.tpPorAsistir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPorAsistir)).BeginInit();
            this.tpYaAsistieron.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYaAsistieron)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCtn
            // 
            this.pnlCtn.Controls.Add(this.btnBuscar);
            this.pnlCtn.Controls.Add(this.cboCursos);
            this.pnlCtn.Controls.Add(this.lblCurso);
            this.pnlCtn.Controls.Add(this.btnRegistrar);
            this.pnlCtn.Controls.Add(this.tabAsistencia);
            this.pnlCtn.Controls.Add(this.txtDni);
            this.pnlCtn.Controls.Add(this.lblDni);
            this.pnlCtn.Location = new System.Drawing.Point(67, 60);
            this.pnlCtn.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCtn.Name = "pnlCtn";
            this.pnlCtn.Size = new System.Drawing.Size(933, 433);
            this.pnlCtn.TabIndex = 27;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(487, 20);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(161, 28);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cboCursos
            // 
            this.cboCursos.FormattingEnabled = true;
            this.cboCursos.Location = new System.Drawing.Point(208, 79);
            this.cboCursos.Margin = new System.Windows.Forms.Padding(4);
            this.cboCursos.Name = "cboCursos";
            this.cboCursos.Size = new System.Drawing.Size(552, 24);
            this.cboCursos.TabIndex = 17;
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.Location = new System.Drawing.Point(93, 79);
            this.lblCurso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(83, 29);
            this.lblCurso.TabIndex = 16;
            this.lblCurso.Text = "Curso:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(669, 20);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(161, 28);
            this.btnRegistrar.TabIndex = 15;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // tabAsistencia
            // 
            this.tabAsistencia.Controls.Add(this.tpPorAsistir);
            this.tabAsistencia.Controls.Add(this.tpYaAsistieron);
            this.tabAsistencia.Location = new System.Drawing.Point(83, 153);
            this.tabAsistencia.Margin = new System.Windows.Forms.Padding(4);
            this.tabAsistencia.Name = "tabAsistencia";
            this.tabAsistencia.SelectedIndex = 0;
            this.tabAsistencia.Size = new System.Drawing.Size(787, 276);
            this.tabAsistencia.TabIndex = 9;
            // 
            // tpPorAsistir
            // 
            this.tpPorAsistir.Controls.Add(this.dgvPorAsistir);
            this.tpPorAsistir.Location = new System.Drawing.Point(4, 25);
            this.tpPorAsistir.Margin = new System.Windows.Forms.Padding(4);
            this.tpPorAsistir.Name = "tpPorAsistir";
            this.tpPorAsistir.Padding = new System.Windows.Forms.Padding(4);
            this.tpPorAsistir.Size = new System.Drawing.Size(779, 247);
            this.tpPorAsistir.TabIndex = 0;
            this.tpPorAsistir.Text = "Por Asistir";
            this.tpPorAsistir.UseVisualStyleBackColor = true;
            // 
            // dgvPorAsistir
            // 
            this.dgvPorAsistir.AllowUserToAddRows = false;
            this.dgvPorAsistir.AllowUserToDeleteRows = false;
            this.dgvPorAsistir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPorAsistir.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DNI,
            this.Nombre,
            this.Curso,
            this.HoraIni,
            this.HoraFin});
            this.dgvPorAsistir.Location = new System.Drawing.Point(4, 20);
            this.dgvPorAsistir.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPorAsistir.Name = "dgvPorAsistir";
            this.dgvPorAsistir.ReadOnly = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvPorAsistir.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPorAsistir.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPorAsistir.Size = new System.Drawing.Size(764, 185);
            this.dgvPorAsistir.TabIndex = 0;
            this.dgvPorAsistir.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPorAsistir_CellDoubleClick);
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
            // Curso
            // 
            this.Curso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Curso.HeaderText = "Curso";
            this.Curso.Name = "Curso";
            this.Curso.ReadOnly = true;
            // 
            // HoraIni
            // 
            this.HoraIni.HeaderText = "Hora inicio";
            this.HoraIni.Name = "HoraIni";
            this.HoraIni.ReadOnly = true;
            // 
            // HoraFin
            // 
            this.HoraFin.HeaderText = "Hora fin";
            this.HoraFin.Name = "HoraFin";
            this.HoraFin.ReadOnly = true;
            // 
            // tpYaAsistieron
            // 
            this.tpYaAsistieron.BackColor = System.Drawing.Color.White;
            this.tpYaAsistieron.Controls.Add(this.dgvYaAsistieron);
            this.tpYaAsistieron.Location = new System.Drawing.Point(4, 25);
            this.tpYaAsistieron.Margin = new System.Windows.Forms.Padding(4);
            this.tpYaAsistieron.Name = "tpYaAsistieron";
            this.tpYaAsistieron.Padding = new System.Windows.Forms.Padding(4);
            this.tpYaAsistieron.Size = new System.Drawing.Size(779, 247);
            this.tpYaAsistieron.TabIndex = 1;
            this.tpYaAsistieron.Text = "Ya asistieron";
            // 
            // dgvYaAsistieron
            // 
            this.dgvYaAsistieron.AllowUserToAddRows = false;
            this.dgvYaAsistieron.AllowUserToDeleteRows = false;
            this.dgvYaAsistieron.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYaAsistieron.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dn,
            this.Nomb,
            this.Curs,
            this.HoraIn,
            this.HoraFi});
            this.dgvYaAsistieron.Location = new System.Drawing.Point(4, 20);
            this.dgvYaAsistieron.Margin = new System.Windows.Forms.Padding(4);
            this.dgvYaAsistieron.Name = "dgvYaAsistieron";
            this.dgvYaAsistieron.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvYaAsistieron.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvYaAsistieron.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvYaAsistieron.Size = new System.Drawing.Size(764, 185);
            this.dgvYaAsistieron.TabIndex = 1;
            this.dgvYaAsistieron.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvYaAsistieron_CellDoubleClick);
            // 
            // dn
            // 
            this.dn.HeaderText = "DNI";
            this.dn.Name = "dn";
            this.dn.ReadOnly = true;
            // 
            // Nomb
            // 
            this.Nomb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nomb.HeaderText = "Nombre";
            this.Nomb.Name = "Nomb";
            this.Nomb.ReadOnly = true;
            // 
            // Curs
            // 
            this.Curs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Curs.HeaderText = "Curso";
            this.Curs.Name = "Curs";
            this.Curs.ReadOnly = true;
            // 
            // HoraIn
            // 
            this.HoraIn.HeaderText = "Hora inicio";
            this.HoraIn.Name = "HoraIn";
            this.HoraIn.ReadOnly = true;
            // 
            // HoraFi
            // 
            this.HoraFi.HeaderText = "Hora fin";
            this.HoraFi.Name = "HoraFi";
            this.HoraFi.ReadOnly = true;
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(208, 16);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(251, 30);
            this.txtDni.TabIndex = 8;
            this.txtDni.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDni_KeyDown);
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(93, 16);
            this.lblDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(60, 29);
            this.lblDni.TabIndex = 7;
            this.lblDni.Text = "DNI:";
            // 
            // frmAsistenciaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pnlCtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAsistenciaCliente";
            this.Text = "frmAsistenciaCliente";
            this.pnlCtn.ResumeLayout(false);
            this.pnlCtn.PerformLayout();
            this.tabAsistencia.ResumeLayout(false);
            this.tpPorAsistir.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPorAsistir)).EndInit();
            this.tpYaAsistieron.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvYaAsistieron)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCtn;
        private System.Windows.Forms.ComboBox cboCursos;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TabControl tabAsistencia;
        private System.Windows.Forms.TabPage tpPorAsistir;
        private System.Windows.Forms.DataGridView dgvPorAsistir;
        private System.Windows.Forms.TabPage tpYaAsistieron;
        private System.Windows.Forms.DataGridView dgvYaAsistieron;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn s;
        private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
		private System.Windows.Forms.DataGridViewTextBoxColumn HoraIni;
		private System.Windows.Forms.DataGridViewTextBoxColumn HoraFin;
		private System.Windows.Forms.DataGridViewTextBoxColumn dn;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nomb;
		private System.Windows.Forms.DataGridViewTextBoxColumn Curs;
		private System.Windows.Forms.DataGridViewTextBoxColumn HoraIn;
		private System.Windows.Forms.DataGridViewTextBoxColumn HoraFi;
	}
}