namespace Bendiciones
{
    partial class frmCambiarPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCambiarPass));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtActual = new System.Windows.Forms.TextBox();
            this.txtNueva = new System.Windows.Forms.TextBox();
            this.txtRepetir = new System.Windows.Forms.TextBox();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlFill = new System.Windows.Forms.Panel();
            this.lblCoinciden = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.pnlTitulo.SuspendLayout();
            this.pnlFill.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contraseña Actual:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña Nueva:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Repetir contraseña nueva:";
            // 
            // txtActual
            // 
            this.txtActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActual.Location = new System.Drawing.Point(189, 33);
            this.txtActual.Name = "txtActual";
            this.txtActual.PasswordChar = '*';
            this.txtActual.Size = new System.Drawing.Size(256, 26);
            this.txtActual.TabIndex = 3;
            // 
            // txtNueva
            // 
            this.txtNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNueva.Location = new System.Drawing.Point(189, 83);
            this.txtNueva.Name = "txtNueva";
            this.txtNueva.PasswordChar = '*';
            this.txtNueva.Size = new System.Drawing.Size(256, 26);
            this.txtNueva.TabIndex = 4;
            // 
            // txtRepetir
            // 
            this.txtRepetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepetir.Location = new System.Drawing.Point(248, 133);
            this.txtRepetir.Name = "txtRepetir";
            this.txtRepetir.PasswordChar = '*';
            this.txtRepetir.Size = new System.Drawing.Size(197, 26);
            this.txtRepetir.TabIndex = 5;
            this.txtRepetir.TextChanged += new System.EventHandler(this.txtRepetir_TextChanged);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(540, 45);
            this.pnlTitulo.TabIndex = 6;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(3, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(227, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cambiar Contraseña";
            // 
            // pnlFill
            // 
            this.pnlFill.Controls.Add(this.lblCoinciden);
            this.pnlFill.Controls.Add(this.btnConfirmar);
            this.pnlFill.Controls.Add(this.label1);
            this.pnlFill.Controls.Add(this.label2);
            this.pnlFill.Controls.Add(this.txtRepetir);
            this.pnlFill.Controls.Add(this.label3);
            this.pnlFill.Controls.Add(this.txtNueva);
            this.pnlFill.Controls.Add(this.txtActual);
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFill.Location = new System.Drawing.Point(0, 45);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(540, 252);
            this.pnlFill.TabIndex = 7;
            // 
            // lblCoinciden
            // 
            this.lblCoinciden.AutoSize = true;
            this.lblCoinciden.ForeColor = System.Drawing.Color.Red;
            this.lblCoinciden.Location = new System.Drawing.Point(315, 162);
            this.lblCoinciden.Name = "lblCoinciden";
            this.lblCoinciden.Size = new System.Drawing.Size(130, 13);
            this.lblCoinciden.TabIndex = 8;
            this.lblCoinciden.Text = "Contraseñas no coinciden";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(370, 192);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 6;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // frmCambiarPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 297);
            this.Controls.Add(this.pnlFill);
            this.Controls.Add(this.pnlTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCambiarPass";
            this.Text = "Cambiar Contraseña";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlFill.ResumeLayout(false);
            this.pnlFill.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtActual;
        private System.Windows.Forms.TextBox txtNueva;
        private System.Windows.Forms.TextBox txtRepetir;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlFill;
        private System.Windows.Forms.Label lblCoinciden;
        private System.Windows.Forms.Button btnConfirmar;
    }
}