namespace TiendaNaturista
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.TextBox();
            this.Passwork = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IngresarLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // User
            // 
            this.User.Location = new System.Drawing.Point(124, 101);
            this.User.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(164, 26);
            this.User.TabIndex = 1;
            // 
            // Passwork
            // 
            this.Passwork.Location = new System.Drawing.Point(124, 191);
            this.Passwork.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Passwork.Name = "Passwork";
            this.Passwork.PasswordChar = '*';
            this.Passwork.Size = new System.Drawing.Size(164, 26);
            this.Passwork.TabIndex = 2;
            this.Passwork.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Passwork_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(138, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tienda Naturista\r\nNaturVida";
            // 
            // IngresarLogin
            // 
            this.IngresarLogin.Location = new System.Drawing.Point(141, 256);
            this.IngresarLogin.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.IngresarLogin.Name = "IngresarLogin";
            this.IngresarLogin.Size = new System.Drawing.Size(125, 32);
            this.IngresarLogin.TabIndex = 3;
            this.IngresarLogin.Text = "Ingresar";
            this.IngresarLogin.UseVisualStyleBackColor = true;
            this.IngresarLogin.Click += new System.EventHandler(this.IngresarLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(417, 340);
            this.Controls.Add(this.IngresarLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Passwork);
            this.Controls.Add(this.User);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.OrangeRed;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.TextBox Passwork;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button IngresarLogin;
    }
}