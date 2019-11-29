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
			this.pnlTitulo = new System.Windows.Forms.Panel();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.pnlMensaje = new System.Windows.Forms.Panel();
			this.txtMensaje = new System.Windows.Forms.TextBox();
			this.pnlTitulo.SuspendLayout();
			this.pnlMensaje.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(299, 144);
			this.btnOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(92, 49);
			this.btnOk.TabIndex = 0;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// pnlTitulo
			// 
			this.pnlTitulo.Controls.Add(this.lblTitulo);
			this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
			this.pnlTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pnlTitulo.Name = "pnlTitulo";
			this.pnlTitulo.Size = new System.Drawing.Size(545, 53);
			this.pnlTitulo.TabIndex = 2;
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Location = new System.Drawing.Point(35, 18);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(57, 17);
			this.lblTitulo.TabIndex = 4;
			this.lblTitulo.Text = "lblTitulo";
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(408, 144);
			this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(92, 49);
			this.btnCancelar.TabIndex = 3;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// pnlMensaje
			// 
			this.pnlMensaje.Controls.Add(this.txtMensaje);
			this.pnlMensaje.Controls.Add(this.btnCancelar);
			this.pnlMensaje.Controls.Add(this.btnOk);
			this.pnlMensaje.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlMensaje.Location = new System.Drawing.Point(0, 53);
			this.pnlMensaje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pnlMensaje.Name = "pnlMensaje";
			this.pnlMensaje.Size = new System.Drawing.Size(545, 216);
			this.pnlMensaje.TabIndex = 4;
			// 
			// txtMensaje
			// 
			this.txtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtMensaje.Location = new System.Drawing.Point(38, 16);
			this.txtMensaje.Multiline = true;
			this.txtMensaje.Name = "txtMensaje";
			this.txtMensaje.Size = new System.Drawing.Size(462, 107);
			this.txtMensaje.TabIndex = 4;
			// 
			// frmMensaje
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(545, 269);
			this.Controls.Add(this.pnlMensaje);
			this.Controls.Add(this.pnlTitulo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
		private System.Windows.Forms.Panel pnlTitulo;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Panel pnlMensaje;
		private System.Windows.Forms.TextBox txtMensaje;
	}
}