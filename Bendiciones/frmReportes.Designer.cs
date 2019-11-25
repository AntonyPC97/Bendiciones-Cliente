namespace Bendiciones
{
    partial class frmReportes
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
            this.cboMeses = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboYears = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // cboMeses
            // 
            this.cboMeses.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.cboMeses.FormattingEnabled = true;
            this.cboMeses.Items.AddRange(new object[] {
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
            this.cboMeses.Location = new System.Drawing.Point(235, 39);
            this.cboMeses.Name = "cboMeses";
            this.cboMeses.Size = new System.Drawing.Size(196, 21);
            this.cboMeses.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Mes";
            // 
            // cboYears
            // 
            this.cboYears.FormattingEnabled = true;
            this.cboYears.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020"});
            this.cboYears.Location = new System.Drawing.Point(235, 84);
            this.cboYears.Name = "cboYears";
            this.cboYears.Size = new System.Drawing.Size(196, 21);
            this.cboYears.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Año";
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Location = new System.Drawing.Point(282, 152);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(149, 23);
            this.btnGenerarReporte.TabIndex = 49;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.cboYears);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboMeses);
            this.Controls.Add(this.label1);
            this.Name = "frmReportes";
            this.Text = "frmReportes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMeses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboYears;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}