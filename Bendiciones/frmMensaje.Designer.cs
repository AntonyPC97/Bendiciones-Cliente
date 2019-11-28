namespace Bendiciones
{
    partial class frmMensaje
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
            this.btnOk = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlMensaje = new System.Windows.Forms.Panel();
            this.pnlTitulo.SuspendLayout();
            this.pnlMensaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(236, 76);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(69, 40);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(83, 41);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(77, 15);
            this.lblMensaje.TabIndex = 1;
            this.lblMensaje.Text = "lblMensaje";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(409, 43);
            this.pnlTitulo.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(26, 15);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(43, 13);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "lblTitulo";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(330, 76);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(69, 40);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pnlMensaje
            // 
            this.pnlMensaje.Controls.Add(this.lblMensaje);
            this.pnlMensaje.Controls.Add(this.btnCancelar);
            this.pnlMensaje.Controls.Add(this.btnOk);
            this.pnlMensaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMensaje.Location = new System.Drawing.Point(0, 43);
            this.pnlMensaje.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMensaje.Name = "pnlMensaje";
            this.pnlMensaje.Size = new System.Drawing.Size(409, 137);
            this.pnlMensaje.TabIndex = 4;
            // 
            // frmMensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 180);
            this.Controls.Add(this.pnlMensaje);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMensaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mensaje";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlMensaje.ResumeLayout(false);
            this.pnlMensaje.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblMensaje;
		private System.Windows.Forms.Panel pnlTitulo;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Panel pnlMensaje;
	}
}