namespace Bendiciones
{
    partial class frmReportesTotal
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
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.pnlCtn = new System.Windows.Forms.Panel();
			this.tabReportes = new System.Windows.Forms.TabControl();
			this.tabAsistenciaHorario = new System.Windows.Forms.TabPage();
			this.dgvHorarios = new System.Windows.Forms.DataGridView();
			this.Num_clase = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HoraIni = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Profesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sede = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NumVac = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gbCurso = new System.Windows.Forms.GroupBox();
			this.btnbuscarCurso = new System.Windows.Forms.Button();
			this.lblNombre = new System.Windows.Forms.Label();
			this.txtNombreServicio = new System.Windows.Forms.TextBox();
			this.btnAsistenciaHorario = new System.Windows.Forms.Button();
			this.gbGestaciones = new System.Windows.Forms.GroupBox();
			this.btnSeleccionarGestacion = new System.Windows.Forms.Button();
			this.btnAgregarGestacion = new System.Windows.Forms.Button();
			this.dgvGestaciones = new System.Windows.Forms.DataGridView();
			this.Clinica = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FechaProb = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabAsistenciaCurso = new System.Windows.Forms.TabPage();
			this.cboYearsCurso = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cboMesesCurso = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnAsistenciaCurso = new System.Windows.Forms.Button();
			this.tabMontoRecaudado = new System.Windows.Forms.TabPage();
			this.cboYearsMonto = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cboMesesMonto = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnMonto = new System.Windows.Forms.Button();
			this.pnlCtn.SuspendLayout();
			this.tabReportes.SuspendLayout();
			this.tabAsistenciaHorario.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).BeginInit();
			this.gbCurso.SuspendLayout();
			this.gbGestaciones.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvGestaciones)).BeginInit();
			this.tabAsistenciaCurso.SuspendLayout();
			this.tabMontoRecaudado.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlCtn
			// 
			this.pnlCtn.Controls.Add(this.tabReportes);
			this.pnlCtn.Location = new System.Drawing.Point(97, 65);
			this.pnlCtn.Margin = new System.Windows.Forms.Padding(4);
			this.pnlCtn.Name = "pnlCtn";
			this.pnlCtn.Size = new System.Drawing.Size(858, 486);
			this.pnlCtn.TabIndex = 57;
			// 
			// tabReportes
			// 
			this.tabReportes.Controls.Add(this.tabAsistenciaHorario);
			this.tabReportes.Controls.Add(this.tabAsistenciaCurso);
			this.tabReportes.Controls.Add(this.tabMontoRecaudado);
			this.tabReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabReportes.Location = new System.Drawing.Point(4, 4);
			this.tabReportes.Margin = new System.Windows.Forms.Padding(4);
			this.tabReportes.Name = "tabReportes";
			this.tabReportes.SelectedIndex = 0;
			this.tabReportes.Size = new System.Drawing.Size(850, 478);
			this.tabReportes.TabIndex = 56;
			// 
			// tabAsistenciaHorario
			// 
			this.tabAsistenciaHorario.AutoScrollMargin = new System.Drawing.Size(0, 20);
			this.tabAsistenciaHorario.Controls.Add(this.dgvHorarios);
			this.tabAsistenciaHorario.Controls.Add(this.gbCurso);
			this.tabAsistenciaHorario.Controls.Add(this.btnAsistenciaHorario);
			this.tabAsistenciaHorario.Controls.Add(this.gbGestaciones);
			this.tabAsistenciaHorario.Location = new System.Drawing.Point(4, 29);
			this.tabAsistenciaHorario.Margin = new System.Windows.Forms.Padding(4);
			this.tabAsistenciaHorario.Name = "tabAsistenciaHorario";
			this.tabAsistenciaHorario.Padding = new System.Windows.Forms.Padding(4);
			this.tabAsistenciaHorario.Size = new System.Drawing.Size(842, 445);
			this.tabAsistenciaHorario.TabIndex = 0;
			this.tabAsistenciaHorario.Text = "Asistentes por horario";
			this.tabAsistenciaHorario.UseVisualStyleBackColor = true;
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
			this.dgvHorarios.Location = new System.Drawing.Point(8, 126);
			this.dgvHorarios.Margin = new System.Windows.Forms.Padding(4);
			this.dgvHorarios.Name = "dgvHorarios";
			this.dgvHorarios.ReadOnly = true;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.dgvHorarios.RowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvHorarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvHorarios.Size = new System.Drawing.Size(819, 191);
			this.dgvHorarios.TabIndex = 59;
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
			// gbCurso
			// 
			this.gbCurso.Controls.Add(this.btnbuscarCurso);
			this.gbCurso.Controls.Add(this.lblNombre);
			this.gbCurso.Controls.Add(this.txtNombreServicio);
			this.gbCurso.Location = new System.Drawing.Point(8, 21);
			this.gbCurso.Margin = new System.Windows.Forms.Padding(4);
			this.gbCurso.Name = "gbCurso";
			this.gbCurso.Padding = new System.Windows.Forms.Padding(4);
			this.gbCurso.Size = new System.Drawing.Size(792, 86);
			this.gbCurso.TabIndex = 58;
			this.gbCurso.TabStop = false;
			this.gbCurso.Text = "Curso";
			// 
			// btnbuscarCurso
			// 
			this.btnbuscarCurso.FlatAppearance.BorderSize = 0;
			this.btnbuscarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnbuscarCurso.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnbuscarCurso.Location = new System.Drawing.Point(729, 31);
			this.btnbuscarCurso.Margin = new System.Windows.Forms.Padding(4);
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
			this.txtNombreServicio.Margin = new System.Windows.Forms.Padding(4);
			this.txtNombreServicio.Name = "txtNombreServicio";
			this.txtNombreServicio.Size = new System.Drawing.Size(567, 30);
			this.txtNombreServicio.TabIndex = 31;
			this.txtNombreServicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btnAsistenciaHorario
			// 
			this.btnAsistenciaHorario.FlatAppearance.BorderSize = 0;
			this.btnAsistenciaHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAsistenciaHorario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAsistenciaHorario.Location = new System.Drawing.Point(680, 332);
			this.btnAsistenciaHorario.Margin = new System.Windows.Forms.Padding(4);
			this.btnAsistenciaHorario.Name = "btnAsistenciaHorario";
			this.btnAsistenciaHorario.Size = new System.Drawing.Size(147, 25);
			this.btnAsistenciaHorario.TabIndex = 57;
			this.btnAsistenciaHorario.Text = "Generar reporte";
			this.btnAsistenciaHorario.UseVisualStyleBackColor = true;
			this.btnAsistenciaHorario.Click += new System.EventHandler(this.btnAsistenciaHorario_Click);
			// 
			// gbGestaciones
			// 
			this.gbGestaciones.Controls.Add(this.btnSeleccionarGestacion);
			this.gbGestaciones.Controls.Add(this.btnAgregarGestacion);
			this.gbGestaciones.Controls.Add(this.dgvGestaciones);
			this.gbGestaciones.Location = new System.Drawing.Point(45, 505);
			this.gbGestaciones.Margin = new System.Windows.Forms.Padding(4);
			this.gbGestaciones.Name = "gbGestaciones";
			this.gbGestaciones.Padding = new System.Windows.Forms.Padding(4);
			this.gbGestaciones.Size = new System.Drawing.Size(831, 342);
			this.gbGestaciones.TabIndex = 32;
			this.gbGestaciones.TabStop = false;
			this.gbGestaciones.Text = "Gestaciones";
			// 
			// btnSeleccionarGestacion
			// 
			this.btnSeleccionarGestacion.FlatAppearance.BorderSize = 0;
			this.btnSeleccionarGestacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSeleccionarGestacion.Location = new System.Drawing.Point(492, 23);
			this.btnSeleccionarGestacion.Margin = new System.Windows.Forms.Padding(4);
			this.btnSeleccionarGestacion.Name = "btnSeleccionarGestacion";
			this.btnSeleccionarGestacion.Size = new System.Drawing.Size(161, 34);
			this.btnSeleccionarGestacion.TabIndex = 44;
			this.btnSeleccionarGestacion.Text = "Seleccionar gestación";
			this.btnSeleccionarGestacion.UseVisualStyleBackColor = true;
			// 
			// btnAgregarGestacion
			// 
			this.btnAgregarGestacion.FlatAppearance.BorderSize = 0;
			this.btnAgregarGestacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAgregarGestacion.Location = new System.Drawing.Point(661, 23);
			this.btnAgregarGestacion.Margin = new System.Windows.Forms.Padding(4);
			this.btnAgregarGestacion.Name = "btnAgregarGestacion";
			this.btnAgregarGestacion.Size = new System.Drawing.Size(161, 34);
			this.btnAgregarGestacion.TabIndex = 43;
			this.btnAgregarGestacion.Text = "Agregar gestación";
			this.btnAgregarGestacion.UseVisualStyleBackColor = true;
			// 
			// dgvGestaciones
			// 
			this.dgvGestaciones.AllowUserToAddRows = false;
			this.dgvGestaciones.AllowUserToDeleteRows = false;
			this.dgvGestaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvGestaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clinica,
            this.FechaProb});
			this.dgvGestaciones.Location = new System.Drawing.Point(4, 78);
			this.dgvGestaciones.Margin = new System.Windows.Forms.Padding(4);
			this.dgvGestaciones.Name = "dgvGestaciones";
			this.dgvGestaciones.ReadOnly = true;
			this.dgvGestaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvGestaciones.Size = new System.Drawing.Size(819, 257);
			this.dgvGestaciones.TabIndex = 0;
			// 
			// Clinica
			// 
			this.Clinica.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Clinica.HeaderText = "Clínica";
			this.Clinica.Name = "Clinica";
			this.Clinica.ReadOnly = true;
			// 
			// FechaProb
			// 
			this.FechaProb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.FechaProb.HeaderText = "Fecha probable de parto";
			this.FechaProb.Name = "FechaProb";
			this.FechaProb.ReadOnly = true;
			// 
			// tabAsistenciaCurso
			// 
			this.tabAsistenciaCurso.Controls.Add(this.cboYearsCurso);
			this.tabAsistenciaCurso.Controls.Add(this.label3);
			this.tabAsistenciaCurso.Controls.Add(this.cboMesesCurso);
			this.tabAsistenciaCurso.Controls.Add(this.label4);
			this.tabAsistenciaCurso.Controls.Add(this.btnAsistenciaCurso);
			this.tabAsistenciaCurso.Location = new System.Drawing.Point(4, 29);
			this.tabAsistenciaCurso.Margin = new System.Windows.Forms.Padding(4);
			this.tabAsistenciaCurso.Name = "tabAsistenciaCurso";
			this.tabAsistenciaCurso.Padding = new System.Windows.Forms.Padding(4);
			this.tabAsistenciaCurso.Size = new System.Drawing.Size(842, 445);
			this.tabAsistenciaCurso.TabIndex = 1;
			this.tabAsistenciaCurso.Text = "Asistencia por curso";
			this.tabAsistenciaCurso.UseVisualStyleBackColor = true;
			// 
			// cboYearsCurso
			// 
			this.cboYearsCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboYearsCurso.FormattingEnabled = true;
			this.cboYearsCurso.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020"});
			this.cboYearsCurso.Location = new System.Drawing.Point(333, 166);
			this.cboYearsCurso.Margin = new System.Windows.Forms.Padding(4);
			this.cboYearsCurso.Name = "cboYearsCurso";
			this.cboYearsCurso.Size = new System.Drawing.Size(260, 33);
			this.cboYearsCurso.TabIndex = 67;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(160, 172);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 25);
			this.label3.TabIndex = 66;
			this.label3.Text = "Año";
			// 
			// cboMesesCurso
			// 
			this.cboMesesCurso.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
			this.cboMesesCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboMesesCurso.FormattingEnabled = true;
			this.cboMesesCurso.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Setiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
			this.cboMesesCurso.Location = new System.Drawing.Point(333, 123);
			this.cboMesesCurso.Margin = new System.Windows.Forms.Padding(4);
			this.cboMesesCurso.Name = "cboMesesCurso";
			this.cboMesesCurso.Size = new System.Drawing.Size(260, 33);
			this.cboMesesCurso.TabIndex = 65;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(160, 123);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(50, 25);
			this.label4.TabIndex = 64;
			this.label4.Text = "Mes";
			// 
			// btnAsistenciaCurso
			// 
			this.btnAsistenciaCurso.FlatAppearance.BorderSize = 0;
			this.btnAsistenciaCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAsistenciaCurso.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAsistenciaCurso.Location = new System.Drawing.Point(533, 308);
			this.btnAsistenciaCurso.Margin = new System.Windows.Forms.Padding(4);
			this.btnAsistenciaCurso.Name = "btnAsistenciaCurso";
			this.btnAsistenciaCurso.Size = new System.Drawing.Size(147, 25);
			this.btnAsistenciaCurso.TabIndex = 58;
			this.btnAsistenciaCurso.Text = "Generar reporte";
			this.btnAsistenciaCurso.UseVisualStyleBackColor = true;
			this.btnAsistenciaCurso.Click += new System.EventHandler(this.btnAsistenciaCurso_Click);
			// 
			// tabMontoRecaudado
			// 
			this.tabMontoRecaudado.Controls.Add(this.cboYearsMonto);
			this.tabMontoRecaudado.Controls.Add(this.label2);
			this.tabMontoRecaudado.Controls.Add(this.cboMesesMonto);
			this.tabMontoRecaudado.Controls.Add(this.label1);
			this.tabMontoRecaudado.Controls.Add(this.btnMonto);
			this.tabMontoRecaudado.Location = new System.Drawing.Point(4, 29);
			this.tabMontoRecaudado.Margin = new System.Windows.Forms.Padding(4);
			this.tabMontoRecaudado.Name = "tabMontoRecaudado";
			this.tabMontoRecaudado.Padding = new System.Windows.Forms.Padding(4);
			this.tabMontoRecaudado.Size = new System.Drawing.Size(842, 445);
			this.tabMontoRecaudado.TabIndex = 2;
			this.tabMontoRecaudado.Text = "Monto recaudado";
			this.tabMontoRecaudado.UseVisualStyleBackColor = true;
			// 
			// cboYearsMonto
			// 
			this.cboYearsMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboYearsMonto.FormattingEnabled = true;
			this.cboYearsMonto.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020"});
			this.cboYearsMonto.Location = new System.Drawing.Point(333, 166);
			this.cboYearsMonto.Margin = new System.Windows.Forms.Padding(4);
			this.cboYearsMonto.Name = "cboYearsMonto";
			this.cboYearsMonto.Size = new System.Drawing.Size(260, 33);
			this.cboYearsMonto.TabIndex = 63;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(160, 172);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 25);
			this.label2.TabIndex = 62;
			this.label2.Text = "Año";
			// 
			// cboMesesMonto
			// 
			this.cboMesesMonto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
			this.cboMesesMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboMesesMonto.FormattingEnabled = true;
			this.cboMesesMonto.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Setiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
			this.cboMesesMonto.Location = new System.Drawing.Point(333, 123);
			this.cboMesesMonto.Margin = new System.Windows.Forms.Padding(4);
			this.cboMesesMonto.Name = "cboMesesMonto";
			this.cboMesesMonto.Size = new System.Drawing.Size(260, 33);
			this.cboMesesMonto.TabIndex = 61;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(160, 123);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 25);
			this.label1.TabIndex = 60;
			this.label1.Text = "Mes";
			// 
			// btnMonto
			// 
			this.btnMonto.FlatAppearance.BorderSize = 0;
			this.btnMonto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMonto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMonto.Location = new System.Drawing.Point(533, 308);
			this.btnMonto.Margin = new System.Windows.Forms.Padding(4);
			this.btnMonto.Name = "btnMonto";
			this.btnMonto.Size = new System.Drawing.Size(147, 25);
			this.btnMonto.TabIndex = 59;
			this.btnMonto.Text = "Generar reporte";
			this.btnMonto.UseVisualStyleBackColor = true;
			this.btnMonto.Click += new System.EventHandler(this.btnMonto_Click);
			// 
			// frmReportesTotal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1281, 624);
			this.Controls.Add(this.pnlCtn);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmReportesTotal";
			this.Text = "frmReportesTotal";
			this.pnlCtn.ResumeLayout(false);
			this.tabReportes.ResumeLayout(false);
			this.tabAsistenciaHorario.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).EndInit();
			this.gbCurso.ResumeLayout(false);
			this.gbCurso.PerformLayout();
			this.gbGestaciones.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvGestaciones)).EndInit();
			this.tabAsistenciaCurso.ResumeLayout(false);
			this.tabAsistenciaCurso.PerformLayout();
			this.tabMontoRecaudado.ResumeLayout(false);
			this.tabMontoRecaudado.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel pnlCtn;
        private System.Windows.Forms.TabControl tabReportes;
        private System.Windows.Forms.TabPage tabAsistenciaHorario;
        private System.Windows.Forms.DataGridView dgvHorarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_clase;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraIni;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sede;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumVac;
        private System.Windows.Forms.GroupBox gbCurso;
        private System.Windows.Forms.Button btnbuscarCurso;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombreServicio;
        private System.Windows.Forms.Button btnAsistenciaHorario;
        private System.Windows.Forms.GroupBox gbGestaciones;
        private System.Windows.Forms.Button btnSeleccionarGestacion;
        private System.Windows.Forms.Button btnAgregarGestacion;
        private System.Windows.Forms.DataGridView dgvGestaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clinica;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaProb;
        private System.Windows.Forms.TabPage tabAsistenciaCurso;
        private System.Windows.Forms.ComboBox cboYearsCurso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboMesesCurso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAsistenciaCurso;
        private System.Windows.Forms.TabPage tabMontoRecaudado;
        private System.Windows.Forms.ComboBox cboYearsMonto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboMesesMonto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMonto;
    }
}