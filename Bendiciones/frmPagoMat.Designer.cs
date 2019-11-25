namespace Bendiciones
{
    partial class frmPagoMat
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
            this.pnlCtn = new System.Windows.Forms.Panel();
            this.gbPago = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotalAPagar = new System.Windows.Forms.TextBox();
            this.cboFormaPago = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAbonar = new System.Windows.Forms.Label();
            this.txtAbonar = new System.Windows.Forms.TextBox();
            this.lblPendiente = new System.Windows.Forms.Label();
            this.txtPendiente = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pnlCtn.SuspendLayout();
            this.gbPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCtn
            // 
            this.pnlCtn.Controls.Add(this.gbPago);
            this.pnlCtn.Controls.Add(this.btnGuardar);
            this.pnlCtn.Location = new System.Drawing.Point(51, 49);
            this.pnlCtn.Name = "pnlCtn";
            this.pnlCtn.Size = new System.Drawing.Size(465, 348);
            this.pnlCtn.TabIndex = 0;
            // 
            // gbPago
            // 
            this.gbPago.Controls.Add(this.lblTotal);
            this.gbPago.Controls.Add(this.txtTotalAPagar);
            this.gbPago.Controls.Add(this.cboFormaPago);
            this.gbPago.Controls.Add(this.label1);
            this.gbPago.Controls.Add(this.lblAbonar);
            this.gbPago.Controls.Add(this.txtAbonar);
            this.gbPago.Controls.Add(this.lblPendiente);
            this.gbPago.Controls.Add(this.txtPendiente);
            this.gbPago.Location = new System.Drawing.Point(60, 70);
            this.gbPago.Name = "gbPago";
            this.gbPago.Size = new System.Drawing.Size(337, 159);
            this.gbPago.TabIndex = 59;
            this.gbPago.TabStop = false;
            this.gbPago.Text = "Pago";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(3, 25);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(119, 24);
            this.lblTotal.TabIndex = 37;
            this.lblTotal.Text = "Total a pagar";
            // 
            // txtTotalAPagar
            // 
            this.txtTotalAPagar.Enabled = false;
            this.txtTotalAPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAPagar.HideSelection = false;
            this.txtTotalAPagar.Location = new System.Drawing.Point(156, 25);
            this.txtTotalAPagar.Name = "txtTotalAPagar";
            this.txtTotalAPagar.Size = new System.Drawing.Size(168, 26);
            this.txtTotalAPagar.TabIndex = 38;
            this.txtTotalAPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cboFormaPago
            // 
            this.cboFormaPago.AutoCompleteCustomSource.AddRange(new string[] {
            "Efectivo",
            "Tarjeta"});
            this.cboFormaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFormaPago.FormattingEnabled = true;
            this.cboFormaPago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta"});
            this.cboFormaPago.Location = new System.Drawing.Point(156, 122);
            this.cboFormaPago.Name = "cboFormaPago";
            this.cboFormaPago.Size = new System.Drawing.Size(168, 28);
            this.cboFormaPago.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 24);
            this.label1.TabIndex = 35;
            this.label1.Text = "Forma de pago:";
            // 
            // lblAbonar
            // 
            this.lblAbonar.AutoSize = true;
            this.lblAbonar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbonar.Location = new System.Drawing.Point(3, 58);
            this.lblAbonar.Name = "lblAbonar";
            this.lblAbonar.Size = new System.Drawing.Size(77, 24);
            this.lblAbonar.TabIndex = 33;
            this.lblAbonar.Text = "Abonar:";
            // 
            // txtAbonar
            // 
            this.txtAbonar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbonar.HideSelection = false;
            this.txtAbonar.Location = new System.Drawing.Point(156, 58);
            this.txtAbonar.Name = "txtAbonar";
            this.txtAbonar.Size = new System.Drawing.Size(168, 26);
            this.txtAbonar.TabIndex = 34;
            this.txtAbonar.Text = "0";
            this.txtAbonar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAbonar.TextChanged += new System.EventHandler(this.txtAbonar_TextChanged);
            // 
            // lblPendiente
            // 
            this.lblPendiente.AutoSize = true;
            this.lblPendiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendiente.Location = new System.Drawing.Point(3, 90);
            this.lblPendiente.Name = "lblPendiente";
            this.lblPendiente.Size = new System.Drawing.Size(101, 24);
            this.lblPendiente.TabIndex = 30;
            this.lblPendiente.Text = "Pendiente:";
            // 
            // txtPendiente
            // 
            this.txtPendiente.Enabled = false;
            this.txtPendiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPendiente.HideSelection = false;
            this.txtPendiente.Location = new System.Drawing.Point(156, 90);
            this.txtPendiente.Name = "txtPendiente";
            this.txtPendiente.Size = new System.Drawing.Size(168, 26);
            this.txtPendiente.TabIndex = 31;
            this.txtPendiente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(261, 251);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(136, 20);
            this.btnGuardar.TabIndex = 58;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmPagoMat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 450);
            this.Controls.Add(this.pnlCtn);
            this.Name = "frmPagoMat";
            this.Text = "frmPagoMat";
            this.pnlCtn.ResumeLayout(false);
            this.gbPago.ResumeLayout(false);
            this.gbPago.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCtn;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox gbPago;
        protected internal System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotalAPagar;
        private System.Windows.Forms.ComboBox cboFormaPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAbonar;
        private System.Windows.Forms.TextBox txtAbonar;
        protected internal System.Windows.Forms.Label lblPendiente;
        private System.Windows.Forms.TextBox txtPendiente;
    }
}