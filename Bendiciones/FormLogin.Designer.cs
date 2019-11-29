namespace Bendiciones
{
    partial class FormLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
			this.pnlMain = new System.Windows.Forms.Panel();
			this.btnOlvide = new System.Windows.Forms.Button();
			this.pnlLine1 = new System.Windows.Forms.Panel();
			this.lblPassword = new System.Windows.Forms.Label();
			this.lblUsuario = new System.Windows.Forms.Label();
			this.pnlLine2 = new System.Windows.Forms.Panel();
			this.btnIngresar = new System.Windows.Forms.Button();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.picLogo = new System.Windows.Forms.PictureBox();
			this.picName = new System.Windows.Forms.PictureBox();
			this.btnSalir = new System.Windows.Forms.Button();
			this.pnlMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picName)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlMain
			// 
			this.pnlMain.BackColor = System.Drawing.Color.White;
			this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlMain.Controls.Add(this.btnOlvide);
			this.pnlMain.Controls.Add(this.pnlLine1);
			this.pnlMain.Controls.Add(this.lblPassword);
			this.pnlMain.Controls.Add(this.lblUsuario);
			this.pnlMain.Controls.Add(this.pnlLine2);
			this.pnlMain.Controls.Add(this.btnIngresar);
			this.pnlMain.Controls.Add(this.txtPassword);
			this.pnlMain.Controls.Add(this.txtUser);
			this.pnlMain.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlMain.Location = new System.Drawing.Point(0, 222);
			this.pnlMain.Margin = new System.Windows.Forms.Padding(4);
			this.pnlMain.Name = "pnlMain";
			this.pnlMain.Size = new System.Drawing.Size(480, 443);
			this.pnlMain.TabIndex = 1;
			// 
			// btnOlvide
			// 
			this.btnOlvide.FlatAppearance.BorderSize = 0;
			this.btnOlvide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOlvide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnOlvide.Location = new System.Drawing.Point(143, 379);
			this.btnOlvide.Name = "btnOlvide";
			this.btnOlvide.Size = new System.Drawing.Size(189, 26);
			this.btnOlvide.TabIndex = 8;
			this.btnOlvide.Text = "Olvide mi contraseña";
			this.btnOlvide.UseVisualStyleBackColor = true;
			this.btnOlvide.Click += new System.EventHandler(this.btnOlvide_Click);
			// 
			// pnlLine1
			// 
			this.pnlLine1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlLine1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.pnlLine1.Location = new System.Drawing.Point(101, 140);
			this.pnlLine1.Margin = new System.Windows.Forms.Padding(4);
			this.pnlLine1.Name = "pnlLine1";
			this.pnlLine1.Size = new System.Drawing.Size(266, 1);
			this.pnlLine1.TabIndex = 5;
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPassword.Location = new System.Drawing.Point(97, 185);
			this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(104, 20);
			this.lblPassword.TabIndex = 7;
			this.lblPassword.Text = "Contraseña";
			// 
			// lblUsuario
			// 
			this.lblUsuario.AutoSize = true;
			this.lblUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsuario.Location = new System.Drawing.Point(97, 81);
			this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(73, 20);
			this.lblUsuario.TabIndex = 6;
			this.lblUsuario.Text = "Usuario";
			// 
			// pnlLine2
			// 
			this.pnlLine2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlLine2.Location = new System.Drawing.Point(101, 254);
			this.pnlLine2.Margin = new System.Windows.Forms.Padding(4);
			this.pnlLine2.Name = "pnlLine2";
			this.pnlLine2.Size = new System.Drawing.Size(266, 1);
			this.pnlLine2.TabIndex = 4;
			// 
			// btnIngresar
			// 
			this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnIngresar.FlatAppearance.BorderSize = 0;
			this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnIngresar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIngresar.ForeColor = System.Drawing.Color.SeaShell;
			this.btnIngresar.Location = new System.Drawing.Point(101, 315);
			this.btnIngresar.Margin = new System.Windows.Forms.Padding(4);
			this.btnIngresar.Name = "btnIngresar";
			this.btnIngresar.Size = new System.Drawing.Size(267, 57);
			this.btnIngresar.TabIndex = 3;
			this.btnIngresar.Text = "Ingresar";
			this.btnIngresar.UseVisualStyleBackColor = false;
			this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
			// 
			// txtPassword
			// 
			this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(101, 226);
			this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(267, 19);
			this.txtPassword.TabIndex = 2;
			this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
			// 
			// txtUser
			// 
			this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUser.Location = new System.Drawing.Point(101, 114);
			this.txtUser.Margin = new System.Windows.Forms.Padding(4);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(267, 19);
			this.txtUser.TabIndex = 1;
			this.txtUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUser_KeyDown);
			// 
			// picLogo
			// 
			this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
			this.picLogo.Location = new System.Drawing.Point(72, 76);
			this.picLogo.Margin = new System.Windows.Forms.Padding(4);
			this.picLogo.Name = "picLogo";
			this.picLogo.Size = new System.Drawing.Size(73, 79);
			this.picLogo.TabIndex = 2;
			this.picLogo.TabStop = false;
			// 
			// picName
			// 
			this.picName.Image = ((System.Drawing.Image)(resources.GetObject("picName.Image")));
			this.picName.Location = new System.Drawing.Point(144, 76);
			this.picName.Margin = new System.Windows.Forms.Padding(4);
			this.picName.Name = "picName";
			this.picName.Size = new System.Drawing.Size(240, 79);
			this.picName.TabIndex = 3;
			this.picName.TabStop = false;
			// 
			// btnSalir
			// 
			this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.btnSalir.FlatAppearance.BorderSize = 0;
			this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalir.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.ForeColor = System.Drawing.Color.SeaShell;
			this.btnSalir.Location = new System.Drawing.Point(407, 13);
			this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(60, 26);
			this.btnSalir.TabIndex = 10;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = false;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// FormLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.ClientSize = new System.Drawing.Size(480, 665);
			this.ControlBox = false;
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.picName);
			this.Controls.Add(this.picLogo);
			this.Controls.Add(this.pnlMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FormLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.pnlMain.ResumeLayout(false);
			this.pnlMain.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picName)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Panel pnlLine2;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Panel pnlLine1;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picName;
		private System.Windows.Forms.Button btnOlvide;
		private System.Windows.Forms.Button btnSalir;
	}
}

