namespace Bendiciones
{
    partial class frmGestionarClaseParticular
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pnlCtn = new System.Windows.Forms.Panel();
            this.gbPago = new System.Windows.Forms.GroupBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cboDescuentos = new System.Windows.Forms.ComboBox();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.btnPagarAhora = new System.Windows.Forms.Button();
            this.gbDocente = new System.Windows.Forms.GroupBox();
            this.lblNombreDocente = new System.Windows.Forms.Label();
            this.txtNombreDocente = new System.Windows.Forms.TextBox();
            this.btnBuscarDocente = new System.Windows.Forms.Button();
            this.lblDNIDocente = new System.Windows.Forms.Label();
            this.txtDNIDocente = new System.Windows.Forms.TextBox();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtDNICliente = new System.Windows.Forms.TextBox();
            this.gbServicio = new System.Windows.Forms.GroupBox();
            this.cboHoraFin = new System.Windows.Forms.ComboBox();
            this.lblHoraFin = new System.Windows.Forms.Label();
            this.lblHoraIni = new System.Windows.Forms.Label();
            this.cboHoraIni = new System.Windows.Forms.ComboBox();
            this.dtpFechaMatricula = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cboDistrito = new System.Windows.Forms.ComboBox();
            this.lblDirección = new System.Windows.Forms.Label();
            this.lblDistrito = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombreServicio = new System.Windows.Forms.Label();
            this.txtNombreServicio = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.pnlCtn.SuspendLayout();
            this.gbPago.SuspendLayout();
            this.gbDocente.SuspendLayout();
            this.gbCliente.SuspendLayout();
            this.gbServicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(586, 50);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(136, 20);
            this.btnCancelar.TabIndex = 49;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(183, 24);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(136, 20);
            this.btnGuardar.TabIndex = 48;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(312, 24);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(136, 20);
            this.btnModificar.TabIndex = 50;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(67, 50);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(136, 20);
            this.btnBuscar.TabIndex = 69;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pnlCtn
            // 
            this.pnlCtn.AutoScroll = true;
            this.pnlCtn.Controls.Add(this.gbPago);
            this.pnlCtn.Controls.Add(this.btnPagarAhora);
            this.pnlCtn.Controls.Add(this.gbDocente);
            this.pnlCtn.Controls.Add(this.gbCliente);
            this.pnlCtn.Controls.Add(this.gbServicio);
            this.pnlCtn.Location = new System.Drawing.Point(26, 104);
            this.pnlCtn.Name = "pnlCtn";
            this.pnlCtn.Size = new System.Drawing.Size(854, 347);
            this.pnlCtn.TabIndex = 70;
            // 
            // gbPago
            // 
            this.gbPago.Controls.Add(this.txtSaldo);
            this.gbPago.Controls.Add(this.label1);
            this.gbPago.Controls.Add(this.lblTotal);
            this.gbPago.Controls.Add(this.txtTotal);
            this.gbPago.Controls.Add(this.cboDescuentos);
            this.gbPago.Controls.Add(this.lblDescuento);
            this.gbPago.Location = new System.Drawing.Point(41, 724);
            this.gbPago.Name = "gbPago";
            this.gbPago.Size = new System.Drawing.Size(726, 125);
            this.gbPago.TabIndex = 72;
            this.gbPago.TabStop = false;
            this.gbPago.Text = "Pago";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Enabled = false;
            this.txtSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldo.HideSelection = false;
            this.txtSaldo.Location = new System.Drawing.Point(260, 89);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(164, 26);
            this.txtSaldo.TabIndex = 44;
            this.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 43;
            this.label1.Text = "Saldo:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(118, 56);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(124, 24);
            this.lblTotal.TabIndex = 41;
            this.lblTotal.Text = "Total a pagar:";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.HideSelection = false;
            this.txtTotal.Location = new System.Drawing.Point(260, 54);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(164, 26);
            this.txtTotal.TabIndex = 42;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // cboDescuentos
            // 
            this.cboDescuentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDescuentos.FormattingEnabled = true;
            this.cboDescuentos.Location = new System.Drawing.Point(260, 22);
            this.cboDescuentos.Name = "cboDescuentos";
            this.cboDescuentos.Size = new System.Drawing.Size(164, 28);
            this.cboDescuentos.TabIndex = 38;
            this.cboDescuentos.SelectedIndexChanged += new System.EventHandler(this.cboDescuentos_SelectedIndexChanged);
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.Location = new System.Drawing.Point(118, 20);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(106, 24);
            this.lblDescuento.TabIndex = 37;
            this.lblDescuento.Text = "Descuento:";
            // 
            // btnPagarAhora
            // 
            this.btnPagarAhora.FlatAppearance.BorderSize = 0;
            this.btnPagarAhora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagarAhora.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagarAhora.Location = new System.Drawing.Point(631, 867);
            this.btnPagarAhora.Name = "btnPagarAhora";
            this.btnPagarAhora.Size = new System.Drawing.Size(136, 20);
            this.btnPagarAhora.TabIndex = 71;
            this.btnPagarAhora.Text = "Pagar ahora";
            this.btnPagarAhora.UseVisualStyleBackColor = true;
            this.btnPagarAhora.Click += new System.EventHandler(this.btnPagarAhora_Click);
            // 
            // gbDocente
            // 
            this.gbDocente.Controls.Add(this.lblNombreDocente);
            this.gbDocente.Controls.Add(this.txtNombreDocente);
            this.gbDocente.Controls.Add(this.btnBuscarDocente);
            this.gbDocente.Controls.Add(this.lblDNIDocente);
            this.gbDocente.Controls.Add(this.txtDNIDocente);
            this.gbDocente.Location = new System.Drawing.Point(41, 605);
            this.gbDocente.Name = "gbDocente";
            this.gbDocente.Size = new System.Drawing.Size(726, 113);
            this.gbDocente.TabIndex = 56;
            this.gbDocente.TabStop = false;
            this.gbDocente.Text = "Docente";
            // 
            // lblNombreDocente
            // 
            this.lblNombreDocente.AutoSize = true;
            this.lblNombreDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDocente.Location = new System.Drawing.Point(116, 75);
            this.lblNombreDocente.Name = "lblNombreDocente";
            this.lblNombreDocente.Size = new System.Drawing.Size(84, 24);
            this.lblNombreDocente.TabIndex = 33;
            this.lblNombreDocente.Text = "Nombre:";
            // 
            // txtNombreDocente
            // 
            this.txtNombreDocente.Enabled = false;
            this.txtNombreDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreDocente.HideSelection = false;
            this.txtNombreDocente.Location = new System.Drawing.Point(206, 75);
            this.txtNombreDocente.Name = "txtNombreDocente";
            this.txtNombreDocente.Size = new System.Drawing.Size(377, 26);
            this.txtNombreDocente.TabIndex = 34;
            this.txtNombreDocente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBuscarDocente
            // 
            this.btnBuscarDocente.FlatAppearance.BorderSize = 0;
            this.btnBuscarDocente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarDocente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarDocente.Location = new System.Drawing.Point(379, 25);
            this.btnBuscarDocente.Name = "btnBuscarDocente";
            this.btnBuscarDocente.Size = new System.Drawing.Size(30, 25);
            this.btnBuscarDocente.TabIndex = 32;
            this.btnBuscarDocente.Text = "...";
            this.btnBuscarDocente.UseVisualStyleBackColor = true;
            this.btnBuscarDocente.Click += new System.EventHandler(this.btnBuscarDocente_Click);
            // 
            // lblDNIDocente
            // 
            this.lblDNIDocente.AutoSize = true;
            this.lblDNIDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNIDocente.Location = new System.Drawing.Point(116, 25);
            this.lblDNIDocente.Name = "lblDNIDocente";
            this.lblDNIDocente.Size = new System.Drawing.Size(46, 24);
            this.lblDNIDocente.TabIndex = 30;
            this.lblDNIDocente.Text = "DNI:";
            // 
            // txtDNIDocente
            // 
            this.txtDNIDocente.Enabled = false;
            this.txtDNIDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNIDocente.HideSelection = false;
            this.txtDNIDocente.Location = new System.Drawing.Point(206, 25);
            this.txtDNIDocente.Name = "txtDNIDocente";
            this.txtDNIDocente.Size = new System.Drawing.Size(167, 26);
            this.txtDNIDocente.TabIndex = 31;
            this.txtDNIDocente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.lblNombreCliente);
            this.gbCliente.Controls.Add(this.txtNombreCliente);
            this.gbCliente.Controls.Add(this.btnBuscarCliente);
            this.gbCliente.Controls.Add(this.lblDNI);
            this.gbCliente.Controls.Add(this.txtDNICliente);
            this.gbCliente.Location = new System.Drawing.Point(41, 15);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(726, 113);
            this.gbCliente.TabIndex = 53;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.Location = new System.Drawing.Point(116, 75);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(84, 24);
            this.lblNombreCliente.TabIndex = 33;
            this.lblNombreCliente.Text = "Nombre:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Enabled = false;
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.HideSelection = false;
            this.txtNombreCliente.Location = new System.Drawing.Point(206, 75);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(377, 26);
            this.txtNombreCliente.TabIndex = 34;
            this.txtNombreCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.FlatAppearance.BorderSize = 0;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.Location = new System.Drawing.Point(379, 15);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(30, 25);
            this.btnBuscarCliente.TabIndex = 32;
            this.btnBuscarCliente.Text = "...";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(116, 15);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(46, 24);
            this.lblDNI.TabIndex = 30;
            this.lblDNI.Text = "DNI:";
            // 
            // txtDNICliente
            // 
            this.txtDNICliente.Enabled = false;
            this.txtDNICliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNICliente.HideSelection = false;
            this.txtDNICliente.Location = new System.Drawing.Point(206, 15);
            this.txtDNICliente.Name = "txtDNICliente";
            this.txtDNICliente.Size = new System.Drawing.Size(167, 26);
            this.txtDNICliente.TabIndex = 31;
            this.txtDNICliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gbServicio
            // 
            this.gbServicio.Controls.Add(this.cboHoraFin);
            this.gbServicio.Controls.Add(this.lblHoraFin);
            this.gbServicio.Controls.Add(this.lblHoraIni);
            this.gbServicio.Controls.Add(this.cboHoraIni);
            this.gbServicio.Controls.Add(this.dtpFechaMatricula);
            this.gbServicio.Controls.Add(this.lblFecha);
            this.gbServicio.Controls.Add(this.cboDistrito);
            this.gbServicio.Controls.Add(this.lblDirección);
            this.gbServicio.Controls.Add(this.lblDistrito);
            this.gbServicio.Controls.Add(this.txtDireccion);
            this.gbServicio.Controls.Add(this.txtObservaciones);
            this.gbServicio.Controls.Add(this.lblObservaciones);
            this.gbServicio.Controls.Add(this.lblPrecio);
            this.gbServicio.Controls.Add(this.txtPrecio);
            this.gbServicio.Controls.Add(this.txtDescripcion);
            this.gbServicio.Controls.Add(this.lblDescripcion);
            this.gbServicio.Controls.Add(this.lblNombreServicio);
            this.gbServicio.Controls.Add(this.txtNombreServicio);
            this.gbServicio.Location = new System.Drawing.Point(41, 134);
            this.gbServicio.Name = "gbServicio";
            this.gbServicio.Size = new System.Drawing.Size(726, 465);
            this.gbServicio.TabIndex = 54;
            this.gbServicio.TabStop = false;
            this.gbServicio.Text = "Clase Particular";
            // 
            // cboHoraFin
            // 
            this.cboHoraFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHoraFin.FormattingEnabled = true;
            this.cboHoraFin.Items.AddRange(new object[] {
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00"});
            this.cboHoraFin.Location = new System.Drawing.Point(260, 419);
            this.cboHoraFin.Name = "cboHoraFin";
            this.cboHoraFin.Size = new System.Drawing.Size(144, 28);
            this.cboHoraFin.TabIndex = 50;
            // 
            // lblHoraFin
            // 
            this.lblHoraFin.AutoSize = true;
            this.lblHoraFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraFin.Location = new System.Drawing.Point(112, 425);
            this.lblHoraFin.Name = "lblHoraFin";
            this.lblHoraFin.Size = new System.Drawing.Size(88, 24);
            this.lblHoraFin.TabIndex = 49;
            this.lblHoraFin.Text = "Hora Fin:";
            // 
            // lblHoraIni
            // 
            this.lblHoraIni.AutoSize = true;
            this.lblHoraIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraIni.Location = new System.Drawing.Point(112, 385);
            this.lblHoraIni.Name = "lblHoraIni";
            this.lblHoraIni.Size = new System.Drawing.Size(105, 24);
            this.lblHoraIni.TabIndex = 47;
            this.lblHoraIni.Text = "Hora Inicio:";
            // 
            // cboHoraIni
            // 
            this.cboHoraIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHoraIni.FormattingEnabled = true;
            this.cboHoraIni.Items.AddRange(new object[] {
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00"});
            this.cboHoraIni.Location = new System.Drawing.Point(260, 385);
            this.cboHoraIni.Name = "cboHoraIni";
            this.cboHoraIni.Size = new System.Drawing.Size(144, 28);
            this.cboHoraIni.TabIndex = 45;
            // 
            // dtpFechaMatricula
            // 
            this.dtpFechaMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaMatricula.Location = new System.Drawing.Point(260, 343);
            this.dtpFechaMatricula.Name = "dtpFechaMatricula";
            this.dtpFechaMatricula.Size = new System.Drawing.Size(249, 26);
            this.dtpFechaMatricula.TabIndex = 44;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(112, 345);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(69, 24);
            this.lblFecha.TabIndex = 43;
            this.lblFecha.Text = "Fecha:";
            // 
            // cboDistrito
            // 
            this.cboDistrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDistrito.FormattingEnabled = true;
            this.cboDistrito.Items.AddRange(new object[] {
            "San Miguel",
            "Jesús María",
            "Magdalena",
            "Lima",
            "Surco",
            "Chorrillos"});
            this.cboDistrito.Location = new System.Drawing.Point(260, 305);
            this.cboDistrito.Name = "cboDistrito";
            this.cboDistrito.Size = new System.Drawing.Size(249, 28);
            this.cboDistrito.TabIndex = 42;
            // 
            // lblDirección
            // 
            this.lblDirección.AutoSize = true;
            this.lblDirección.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirección.Location = new System.Drawing.Point(112, 265);
            this.lblDirección.Name = "lblDirección";
            this.lblDirección.Size = new System.Drawing.Size(95, 24);
            this.lblDirección.TabIndex = 41;
            this.lblDirección.Text = "Dirección:";
            // 
            // lblDistrito
            // 
            this.lblDistrito.AutoSize = true;
            this.lblDistrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistrito.Location = new System.Drawing.Point(112, 305);
            this.lblDistrito.Name = "lblDistrito";
            this.lblDistrito.Size = new System.Drawing.Size(70, 24);
            this.lblDistrito.TabIndex = 41;
            this.lblDistrito.Text = "Distrito:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.HideSelection = false;
            this.txtDireccion.Location = new System.Drawing.Point(260, 265);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(356, 26);
            this.txtDireccion.TabIndex = 42;
            this.txtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Enabled = false;
            this.txtObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.HideSelection = false;
            this.txtObservaciones.Location = new System.Drawing.Point(260, 185);
            this.txtObservaciones.MinimumSize = new System.Drawing.Size(300, 50);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(356, 66);
            this.txtObservaciones.TabIndex = 40;
            this.txtObservaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.Location = new System.Drawing.Point(112, 185);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(142, 24);
            this.lblObservaciones.TabIndex = 39;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(112, 145);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(69, 24);
            this.lblPrecio.TabIndex = 37;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.HideSelection = false;
            this.txtPrecio.Location = new System.Drawing.Point(260, 145);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(144, 26);
            this.txtPrecio.TabIndex = 38;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.HideSelection = false;
            this.txtDescripcion.Location = new System.Drawing.Point(260, 73);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(356, 66);
            this.txtDescripcion.TabIndex = 36;
            this.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(112, 70);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(115, 24);
            this.lblDescripcion.TabIndex = 35;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblNombreServicio
            // 
            this.lblNombreServicio.AutoSize = true;
            this.lblNombreServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreServicio.Location = new System.Drawing.Point(116, 30);
            this.lblNombreServicio.Name = "lblNombreServicio";
            this.lblNombreServicio.Size = new System.Drawing.Size(84, 24);
            this.lblNombreServicio.TabIndex = 30;
            this.lblNombreServicio.Text = "Nombre:";
            // 
            // txtNombreServicio
            // 
            this.txtNombreServicio.Enabled = false;
            this.txtNombreServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreServicio.HideSelection = false;
            this.txtNombreServicio.Location = new System.Drawing.Point(260, 30);
            this.txtNombreServicio.Name = "txtNombreServicio";
            this.txtNombreServicio.Size = new System.Drawing.Size(356, 26);
            this.txtNombreServicio.TabIndex = 31;
            this.txtNombreServicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(444, 50);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(136, 20);
            this.btnNuevo.TabIndex = 51;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmGestionarClaseParticular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 554);
            this.Controls.Add(this.pnlCtn);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Name = "frmGestionarClaseParticular";
            this.Text = "frmGestionarClaseParticular";
            this.pnlCtn.ResumeLayout(false);
            this.gbPago.ResumeLayout(false);
            this.gbPago.PerformLayout();
            this.gbDocente.ResumeLayout(false);
            this.gbDocente.PerformLayout();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.gbServicio.ResumeLayout(false);
            this.gbServicio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel pnlCtn;
        private System.Windows.Forms.GroupBox gbDocente;
        private System.Windows.Forms.Label lblNombreDocente;
        private System.Windows.Forms.TextBox txtNombreDocente;
        private System.Windows.Forms.Button btnBuscarDocente;
        private System.Windows.Forms.Label lblDNIDocente;
        private System.Windows.Forms.TextBox txtDNIDocente;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtDNICliente;
        private System.Windows.Forms.GroupBox gbServicio;
        private System.Windows.Forms.Label lblHoraFin;
        private System.Windows.Forms.Label lblHoraIni;
        private System.Windows.Forms.ComboBox cboHoraIni;
        private System.Windows.Forms.DateTimePicker dtpFechaMatricula;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox cboDistrito;
        private System.Windows.Forms.Label lblDirección;
        private System.Windows.Forms.Label lblDistrito;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombreServicio;
        private System.Windows.Forms.TextBox txtNombreServicio;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ComboBox cboHoraFin;
        private System.Windows.Forms.Button btnPagarAhora;
        private System.Windows.Forms.GroupBox gbPago;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ComboBox cboDescuentos;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label1;
    }
}