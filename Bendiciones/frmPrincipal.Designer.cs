namespace Bendiciones
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.pnlSide = new System.Windows.Forms.Panel();
            this.picCuenta = new System.Windows.Forms.PictureBox();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnClasesParticulares = new System.Windows.Forms.Button();
            this.btnMatricula = new System.Windows.Forms.Button();
            this.pnlPagos = new System.Windows.Forms.Panel();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.btnRegitrarCuota = new System.Windows.Forms.Button();
            this.btnPagos = new System.Windows.Forms.Button();
            this.pnlAsistencia = new System.Windows.Forms.Panel();
            this.btnAsistenciaDocente = new System.Windows.Forms.Button();
            this.btnAsistenciaCliente = new System.Windows.Forms.Button();
            this.btnAsistencia = new System.Windows.Forms.Button();
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.btnCondiciones = new System.Windows.Forms.Button();
            this.btnDescuentos = new System.Windows.Forms.Button();
            this.btnColaborador = new System.Windows.Forms.Button();
            this.btnSede = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.pnlCursos = new System.Windows.Forms.Panel();
            this.btnInscribir = new System.Windows.Forms.Button();
            this.btnAsignarHorario = new System.Windows.Forms.Button();
            this.btnAsignarDesc = new System.Windows.Forms.Button();
            this.btnCursosRegistrar = new System.Windows.Forms.Button();
            this.btnCursos = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblBendiciones = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.imgIsotipo = new System.Windows.Forms.PictureBox();
            this.pnlFiller = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlCuenta = new System.Windows.Forms.Panel();
            this.btnCambiarPass = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.pnlSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCuenta)).BeginInit();
            this.pnlPagos.SuspendLayout();
            this.pnlAsistencia.SuspendLayout();
            this.pnlAdmin.SuspendLayout();
            this.pnlCursos.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgIsotipo)).BeginInit();
            this.pnlFiller.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlCuenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSide
            // 
            this.pnlSide.AutoScroll = true;
            this.pnlSide.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlSide.Controls.Add(this.btnReportes);
            this.pnlSide.Controls.Add(this.btnClasesParticulares);
            this.pnlSide.Controls.Add(this.btnMatricula);
            this.pnlSide.Controls.Add(this.pnlPagos);
            this.pnlSide.Controls.Add(this.btnPagos);
            this.pnlSide.Controls.Add(this.pnlAsistencia);
            this.pnlSide.Controls.Add(this.btnAsistencia);
            this.pnlSide.Controls.Add(this.pnlAdmin);
            this.pnlSide.Controls.Add(this.btnAdmin);
            this.pnlSide.Controls.Add(this.btnCliente);
            this.pnlSide.Controls.Add(this.pnlCursos);
            this.pnlSide.Controls.Add(this.btnCursos);
            this.pnlSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSide.Location = new System.Drawing.Point(0, 84);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(189, 534);
            this.pnlSide.TabIndex = 1;
            // 
            // picCuenta
            // 
            this.picCuenta.Image = ((System.Drawing.Image)(resources.GetObject("picCuenta.Image")));
            this.picCuenta.Location = new System.Drawing.Point(1127, 52);
            this.picCuenta.Name = "picCuenta";
            this.picCuenta.Size = new System.Drawing.Size(27, 29);
            this.picCuenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCuenta.TabIndex = 1;
            this.picCuenta.TabStop = false;
            this.picCuenta.Click += new System.EventHandler(this.picCerraSesion_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.Location = new System.Drawing.Point(0, 570);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(172, 30);
            this.btnReportes.TabIndex = 29;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnClasesParticulares
            // 
            this.btnClasesParticulares.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClasesParticulares.FlatAppearance.BorderSize = 0;
            this.btnClasesParticulares.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClasesParticulares.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClasesParticulares.Location = new System.Drawing.Point(0, 540);
            this.btnClasesParticulares.Name = "btnClasesParticulares";
            this.btnClasesParticulares.Size = new System.Drawing.Size(172, 30);
            this.btnClasesParticulares.TabIndex = 28;
            this.btnClasesParticulares.Text = "Clases Particulares";
            this.btnClasesParticulares.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClasesParticulares.UseVisualStyleBackColor = true;
            this.btnClasesParticulares.Click += new System.EventHandler(this.btnClasesParticulares_Click);
            // 
            // btnMatricula
            // 
            this.btnMatricula.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMatricula.FlatAppearance.BorderSize = 0;
            this.btnMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatricula.Location = new System.Drawing.Point(0, 510);
            this.btnMatricula.Name = "btnMatricula";
            this.btnMatricula.Size = new System.Drawing.Size(172, 30);
            this.btnMatricula.TabIndex = 27;
            this.btnMatricula.Text = "Matrícula";
            this.btnMatricula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMatricula.UseVisualStyleBackColor = true;
            this.btnMatricula.Click += new System.EventHandler(this.btnMatricula_Click);
            // 
            // pnlPagos
            // 
            this.pnlPagos.Controls.Add(this.btnHistorico);
            this.pnlPagos.Controls.Add(this.btnRegitrarCuota);
            this.pnlPagos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPagos.Location = new System.Drawing.Point(0, 450);
            this.pnlPagos.Name = "pnlPagos";
            this.pnlPagos.Size = new System.Drawing.Size(172, 60);
            this.pnlPagos.TabIndex = 1;
            // 
            // btnHistorico
            // 
            this.btnHistorico.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistorico.FlatAppearance.BorderSize = 0;
            this.btnHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnHistorico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorico.Location = new System.Drawing.Point(0, 30);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHistorico.Size = new System.Drawing.Size(172, 30);
            this.btnHistorico.TabIndex = 25;
            this.btnHistorico.Text = "Ver Histórico";
            this.btnHistorico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorico.UseVisualStyleBackColor = true;
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // btnRegitrarCuota
            // 
            this.btnRegitrarCuota.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegitrarCuota.FlatAppearance.BorderSize = 0;
            this.btnRegitrarCuota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegitrarCuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnRegitrarCuota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegitrarCuota.Location = new System.Drawing.Point(0, 0);
            this.btnRegitrarCuota.Name = "btnRegitrarCuota";
            this.btnRegitrarCuota.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRegitrarCuota.Size = new System.Drawing.Size(172, 30);
            this.btnRegitrarCuota.TabIndex = 24;
            this.btnRegitrarCuota.Text = "Registrar Cuota";
            this.btnRegitrarCuota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegitrarCuota.UseVisualStyleBackColor = true;
            this.btnRegitrarCuota.Click += new System.EventHandler(this.btnRegitrarCuota_Click);
            // 
            // btnPagos
            // 
            this.btnPagos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPagos.FlatAppearance.BorderSize = 0;
            this.btnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagos.Location = new System.Drawing.Point(0, 420);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Size = new System.Drawing.Size(172, 30);
            this.btnPagos.TabIndex = 23;
            this.btnPagos.Text = "Pagos";
            this.btnPagos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagos.UseVisualStyleBackColor = true;
            this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click);
            // 
            // pnlAsistencia
            // 
            this.pnlAsistencia.Controls.Add(this.btnAsistenciaDocente);
            this.pnlAsistencia.Controls.Add(this.btnAsistenciaCliente);
            this.pnlAsistencia.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAsistencia.Location = new System.Drawing.Point(0, 360);
            this.pnlAsistencia.Name = "pnlAsistencia";
            this.pnlAsistencia.Size = new System.Drawing.Size(172, 60);
            this.pnlAsistencia.TabIndex = 17;
            // 
            // btnAsistenciaDocente
            // 
            this.btnAsistenciaDocente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAsistenciaDocente.FlatAppearance.BorderSize = 0;
            this.btnAsistenciaDocente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsistenciaDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnAsistenciaDocente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsistenciaDocente.Location = new System.Drawing.Point(0, 33);
            this.btnAsistenciaDocente.Name = "btnAsistenciaDocente";
            this.btnAsistenciaDocente.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAsistenciaDocente.Size = new System.Drawing.Size(172, 33);
            this.btnAsistenciaDocente.TabIndex = 22;
            this.btnAsistenciaDocente.Text = "Docente";
            this.btnAsistenciaDocente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsistenciaDocente.UseVisualStyleBackColor = true;
            this.btnAsistenciaDocente.Click += new System.EventHandler(this.btnAsistenciaDocente_Click);
            // 
            // btnAsistenciaCliente
            // 
            this.btnAsistenciaCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAsistenciaCliente.FlatAppearance.BorderSize = 0;
            this.btnAsistenciaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsistenciaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnAsistenciaCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsistenciaCliente.Location = new System.Drawing.Point(0, 0);
            this.btnAsistenciaCliente.Name = "btnAsistenciaCliente";
            this.btnAsistenciaCliente.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAsistenciaCliente.Size = new System.Drawing.Size(172, 33);
            this.btnAsistenciaCliente.TabIndex = 21;
            this.btnAsistenciaCliente.Text = "Cliente";
            this.btnAsistenciaCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsistenciaCliente.UseVisualStyleBackColor = true;
            this.btnAsistenciaCliente.Click += new System.EventHandler(this.btnAsistenciaCliente_Click);
            // 
            // btnAsistencia
            // 
            this.btnAsistencia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAsistencia.FlatAppearance.BorderSize = 0;
            this.btnAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsistencia.Location = new System.Drawing.Point(0, 330);
            this.btnAsistencia.Name = "btnAsistencia";
            this.btnAsistencia.Size = new System.Drawing.Size(172, 30);
            this.btnAsistencia.TabIndex = 20;
            this.btnAsistencia.Text = "Asistencia";
            this.btnAsistencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsistencia.UseVisualStyleBackColor = true;
            this.btnAsistencia.Click += new System.EventHandler(this.btnAsistencia_Click);
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.Controls.Add(this.btnCondiciones);
            this.pnlAdmin.Controls.Add(this.btnDescuentos);
            this.pnlAdmin.Controls.Add(this.btnColaborador);
            this.pnlAdmin.Controls.Add(this.btnSede);
            this.pnlAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAdmin.Location = new System.Drawing.Point(0, 210);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(172, 120);
            this.pnlAdmin.TabIndex = 10;
            // 
            // btnCondiciones
            // 
            this.btnCondiciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCondiciones.FlatAppearance.BorderSize = 0;
            this.btnCondiciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCondiciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCondiciones.Location = new System.Drawing.Point(0, 90);
            this.btnCondiciones.Name = "btnCondiciones";
            this.btnCondiciones.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCondiciones.Size = new System.Drawing.Size(172, 30);
            this.btnCondiciones.TabIndex = 17;
            this.btnCondiciones.Text = "Condiciones";
            this.btnCondiciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCondiciones.UseVisualStyleBackColor = true;
            this.btnCondiciones.Click += new System.EventHandler(this.btnCondiciones_Click);
            // 
            // btnDescuentos
            // 
            this.btnDescuentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDescuentos.FlatAppearance.BorderSize = 0;
            this.btnDescuentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescuentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescuentos.Location = new System.Drawing.Point(0, 60);
            this.btnDescuentos.Name = "btnDescuentos";
            this.btnDescuentos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDescuentos.Size = new System.Drawing.Size(172, 30);
            this.btnDescuentos.TabIndex = 14;
            this.btnDescuentos.Text = "Descuentos";
            this.btnDescuentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDescuentos.UseVisualStyleBackColor = true;
            this.btnDescuentos.Click += new System.EventHandler(this.btnDescuentos_Click);
            // 
            // btnColaborador
            // 
            this.btnColaborador.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnColaborador.FlatAppearance.BorderSize = 0;
            this.btnColaborador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColaborador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColaborador.Location = new System.Drawing.Point(0, 30);
            this.btnColaborador.Name = "btnColaborador";
            this.btnColaborador.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnColaborador.Size = new System.Drawing.Size(172, 30);
            this.btnColaborador.TabIndex = 15;
            this.btnColaborador.Text = "Colaboradores";
            this.btnColaborador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnColaborador.UseVisualStyleBackColor = true;
            this.btnColaborador.Click += new System.EventHandler(this.btnColaborador_Click);
            // 
            // btnSede
            // 
            this.btnSede.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSede.FlatAppearance.BorderSize = 0;
            this.btnSede.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSede.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSede.Location = new System.Drawing.Point(0, 0);
            this.btnSede.Name = "btnSede";
            this.btnSede.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSede.Size = new System.Drawing.Size(172, 30);
            this.btnSede.TabIndex = 11;
            this.btnSede.Text = "Sede";
            this.btnSede.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSede.UseVisualStyleBackColor = true;
            this.btnSede.Click += new System.EventHandler(this.btnSede_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(0, 180);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(172, 30);
            this.btnAdmin.TabIndex = 9;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Location = new System.Drawing.Point(0, 150);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(172, 30);
            this.btnCliente.TabIndex = 5;
            this.btnCliente.Text = "Clientes";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // pnlCursos
            // 
            this.pnlCursos.Controls.Add(this.btnInscribir);
            this.pnlCursos.Controls.Add(this.btnAsignarHorario);
            this.pnlCursos.Controls.Add(this.btnAsignarDesc);
            this.pnlCursos.Controls.Add(this.btnCursosRegistrar);
            this.pnlCursos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCursos.Location = new System.Drawing.Point(0, 30);
            this.pnlCursos.Name = "pnlCursos";
            this.pnlCursos.Size = new System.Drawing.Size(172, 120);
            this.pnlCursos.TabIndex = 2;
            // 
            // btnInscribir
            // 
            this.btnInscribir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInscribir.FlatAppearance.BorderSize = 0;
            this.btnInscribir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInscribir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscribir.Location = new System.Drawing.Point(0, 90);
            this.btnInscribir.Name = "btnInscribir";
            this.btnInscribir.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnInscribir.Size = new System.Drawing.Size(172, 30);
            this.btnInscribir.TabIndex = 7;
            this.btnInscribir.Text = "Inscribir a Horario";
            this.btnInscribir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInscribir.UseVisualStyleBackColor = true;
            this.btnInscribir.Click += new System.EventHandler(this.btnInscribir_Click);
            // 
            // btnAsignarHorario
            // 
            this.btnAsignarHorario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAsignarHorario.FlatAppearance.BorderSize = 0;
            this.btnAsignarHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarHorario.Location = new System.Drawing.Point(0, 60);
            this.btnAsignarHorario.Name = "btnAsignarHorario";
            this.btnAsignarHorario.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAsignarHorario.Size = new System.Drawing.Size(172, 30);
            this.btnAsignarHorario.TabIndex = 6;
            this.btnAsignarHorario.Text = "Asignar Horario";
            this.btnAsignarHorario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsignarHorario.UseVisualStyleBackColor = true;
            this.btnAsignarHorario.Click += new System.EventHandler(this.btnAsignarHorario_Click);
            // 
            // btnAsignarDesc
            // 
            this.btnAsignarDesc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAsignarDesc.FlatAppearance.BorderSize = 0;
            this.btnAsignarDesc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarDesc.Location = new System.Drawing.Point(0, 30);
            this.btnAsignarDesc.Name = "btnAsignarDesc";
            this.btnAsignarDesc.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAsignarDesc.Size = new System.Drawing.Size(172, 30);
            this.btnAsignarDesc.TabIndex = 5;
            this.btnAsignarDesc.Text = "Asignar Descuento";
            this.btnAsignarDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsignarDesc.UseVisualStyleBackColor = true;
            this.btnAsignarDesc.Click += new System.EventHandler(this.btnAsignarDesc_Click);
            // 
            // btnCursosRegistrar
            // 
            this.btnCursosRegistrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCursosRegistrar.FlatAppearance.BorderSize = 0;
            this.btnCursosRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCursosRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCursosRegistrar.Location = new System.Drawing.Point(0, 0);
            this.btnCursosRegistrar.Name = "btnCursosRegistrar";
            this.btnCursosRegistrar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCursosRegistrar.Size = new System.Drawing.Size(172, 30);
            this.btnCursosRegistrar.TabIndex = 4;
            this.btnCursosRegistrar.Text = "Gestionar";
            this.btnCursosRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCursosRegistrar.UseVisualStyleBackColor = true;
            this.btnCursosRegistrar.Click += new System.EventHandler(this.btnCursosRegistrar_Click);
            // 
            // btnCursos
            // 
            this.btnCursos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCursos.FlatAppearance.BorderSize = 0;
            this.btnCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCursos.Location = new System.Drawing.Point(0, 0);
            this.btnCursos.Name = "btnCursos";
            this.btnCursos.Size = new System.Drawing.Size(172, 30);
            this.btnCursos.TabIndex = 1;
            this.btnCursos.Text = "Cursos";
            this.btnCursos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCursos.UseVisualStyleBackColor = true;
            this.btnCursos.Click += new System.EventHandler(this.btnCursos_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlTop.Controls.Add(this.picCuenta);
            this.pnlTop.Controls.Add(this.lblBendiciones);
            this.pnlTop.Controls.Add(this.lblUsuario);
            this.pnlTop.Controls.Add(this.lblBienvenido);
            this.pnlTop.Controls.Add(this.imgIsotipo);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1166, 84);
            this.pnlTop.TabIndex = 0;
            // 
            // lblBendiciones
            // 
            this.lblBendiciones.AutoSize = true;
            this.lblBendiciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBendiciones.ForeColor = System.Drawing.Color.White;
            this.lblBendiciones.Location = new System.Drawing.Point(981, 9);
            this.lblBendiciones.Name = "lblBendiciones";
            this.lblBendiciones.Size = new System.Drawing.Size(173, 31);
            this.lblBendiciones.TabIndex = 5;
            this.lblBendiciones.Text = "Bendiciones";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(118, 49);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(79, 24);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "usuario";
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.ForeColor = System.Drawing.Color.White;
            this.lblBienvenido.Location = new System.Drawing.Point(3, 9);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(194, 31);
            this.lblBienvenido.TabIndex = 3;
            this.lblBienvenido.Text = "Bienvenido(a)";
            // 
            // imgIsotipo
            // 
            this.imgIsotipo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imgIsotipo.ErrorImage")));
            this.imgIsotipo.Image = ((System.Drawing.Image)(resources.GetObject("imgIsotipo.Image")));
            this.imgIsotipo.Location = new System.Drawing.Point(9, 49);
            this.imgIsotipo.Name = "imgIsotipo";
            this.imgIsotipo.Size = new System.Drawing.Size(24, 24);
            this.imgIsotipo.TabIndex = 0;
            this.imgIsotipo.TabStop = false;
            // 
            // pnlFiller
            // 
            this.pnlFiller.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlFiller.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFiller.Controls.Add(this.pnlCuenta);
            this.pnlFiller.Controls.Add(this.pictureBox1);
            this.pnlFiller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFiller.Location = new System.Drawing.Point(189, 84);
            this.pnlFiller.Name = "pnlFiller";
            this.pnlFiller.Size = new System.Drawing.Size(977, 534);
            this.pnlFiller.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(399, 152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 248);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlCuenta
            // 
            this.pnlCuenta.BackColor = System.Drawing.Color.Red;
            this.pnlCuenta.Controls.Add(this.btnCerrarSesion);
            this.pnlCuenta.Controls.Add(this.btnCambiarPass);
            this.pnlCuenta.Location = new System.Drawing.Point(804, 3);
            this.pnlCuenta.Name = "pnlCuenta";
            this.pnlCuenta.Size = new System.Drawing.Size(172, 60);
            this.pnlCuenta.TabIndex = 1;
            // 
            // btnCambiarPass
            // 
            this.btnCambiarPass.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCambiarPass.Location = new System.Drawing.Point(0, 0);
            this.btnCambiarPass.Name = "btnCambiarPass";
            this.btnCambiarPass.Size = new System.Drawing.Size(172, 30);
            this.btnCambiarPass.TabIndex = 0;
            this.btnCambiarPass.Text = "Cambiar Contraseña";
            this.btnCambiarPass.UseVisualStyleBackColor = true;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 30);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(172, 30);
            this.btnCerrarSesion.TabIndex = 1;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 618);
            this.Controls.Add(this.pnlFiller);
            this.Controls.Add(this.pnlSide);
            this.Controls.Add(this.pnlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1182, 657);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bendiciones";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.pnlSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCuenta)).EndInit();
            this.pnlPagos.ResumeLayout(false);
            this.pnlAsistencia.ResumeLayout(false);
            this.pnlAdmin.ResumeLayout(false);
            this.pnlCursos.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgIsotipo)).EndInit();
            this.pnlFiller.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlCuenta.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlSide;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox imgIsotipo;
        private System.Windows.Forms.Button btnCursos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSede;
        private System.Windows.Forms.Panel pnlCursos;
        private System.Windows.Forms.Button btnCursosRegistrar;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Panel pnlAdmin;
        private System.Windows.Forms.Button btnCondiciones;
        private System.Windows.Forms.Button btnDescuentos;
        private System.Windows.Forms.Button btnColaborador;
        private System.Windows.Forms.Button btnClasesParticulares;
        private System.Windows.Forms.Button btnMatricula;
        private System.Windows.Forms.Panel pnlPagos;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.Button btnRegitrarCuota;
        private System.Windows.Forms.Button btnPagos;
        private System.Windows.Forms.Panel pnlAsistencia;
        private System.Windows.Forms.Button btnAsistenciaDocente;
        private System.Windows.Forms.Button btnAsistenciaCliente;
        private System.Windows.Forms.Button btnAsistencia;
        private System.Windows.Forms.Panel pnlFiller;
        private System.Windows.Forms.Button btnAsignarDesc;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Button btnAsignarHorario;
        private System.Windows.Forms.Button btnInscribir;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Label lblBendiciones;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox picCuenta;
        private System.Windows.Forms.Panel pnlCuenta;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnCambiarPass;
    }
}

