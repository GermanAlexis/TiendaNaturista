namespace TiendaNaturista
{
    partial class Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            this.label5 = new System.Windows.Forms.Label();
            this.IngresarPro = new System.Windows.Forms.TabControl();
            this.IngresarCliente = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Email = new System.Windows.Forms.TextBox();
            this.correo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ClearClient = new System.Windows.Forms.Button();
            this.SaveClient = new System.Windows.Forms.Button();
            this.PhoneClient = new System.Windows.Forms.TextBox();
            this.AddresClient = new System.Windows.Forms.TextBox();
            this.NameClient = new System.Windows.Forms.TextBox();
            this.Document = new System.Windows.Forms.TextBox();
            this.ConsultarCliente = new System.Windows.Forms.TabPage();
            this.ClearClie = new System.Windows.Forms.CheckBox();
            this.ModificarCli = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.EmailMod = new System.Windows.Forms.TextBox();
            this.Guardar_Cliente = new System.Windows.Forms.Button();
            this.PhoneMod = new System.Windows.Forms.TextBox();
            this.AddresMod = new System.Windows.Forms.TextBox();
            this.NameMod = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Consultar_Modificar_Cliente = new System.Windows.Forms.Button();
            this.DocumentConsulta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.IngresarPro.SuspendLayout();
            this.IngresarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.ConsultarCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(330, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 31);
            this.label5.TabIndex = 2;
            this.label5.Text = "Gestion  de Cliente";
            // 
            // IngresarPro
            // 
            this.IngresarPro.Controls.Add(this.IngresarCliente);
            this.IngresarPro.Controls.Add(this.ConsultarCliente);
            this.IngresarPro.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngresarPro.Location = new System.Drawing.Point(51, 43);
            this.IngresarPro.Name = "IngresarPro";
            this.IngresarPro.SelectedIndex = 0;
            this.IngresarPro.Size = new System.Drawing.Size(587, 399);
            this.IngresarPro.TabIndex = 9;
            // 
            // IngresarCliente
            // 
            this.IngresarCliente.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.IngresarCliente.Controls.Add(this.dataGridView2);
            this.IngresarCliente.Controls.Add(this.Email);
            this.IngresarCliente.Controls.Add(this.correo);
            this.IngresarCliente.Controls.Add(this.label4);
            this.IngresarCliente.Controls.Add(this.label3);
            this.IngresarCliente.Controls.Add(this.label2);
            this.IngresarCliente.Controls.Add(this.label1);
            this.IngresarCliente.Controls.Add(this.ClearClient);
            this.IngresarCliente.Controls.Add(this.SaveClient);
            this.IngresarCliente.Controls.Add(this.PhoneClient);
            this.IngresarCliente.Controls.Add(this.AddresClient);
            this.IngresarCliente.Controls.Add(this.NameClient);
            this.IngresarCliente.Controls.Add(this.Document);
            this.IngresarCliente.Location = new System.Drawing.Point(4, 27);
            this.IngresarCliente.Name = "IngresarCliente";
            this.IngresarCliente.Padding = new System.Windows.Forms.Padding(3);
            this.IngresarCliente.Size = new System.Drawing.Size(579, 368);
            this.IngresarCliente.TabIndex = 0;
            this.IngresarCliente.Text = "Ingresar Cliente";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(281, 205);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(263, 136);
            this.dataGridView2.TabIndex = 11;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(138, 141);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(144, 25);
            this.Email.TabIndex = 6;
            // 
            // correo
            // 
            this.correo.AutoSize = true;
            this.correo.Location = new System.Drawing.Point(28, 144);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(55, 18);
            this.correo.TabIndex = 10;
            this.correo.Text = "Correo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Direccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Documento";
            // 
            // ClearClient
            // 
            this.ClearClient.Location = new System.Drawing.Point(59, 282);
            this.ClearClient.Name = "ClearClient";
            this.ClearClient.Size = new System.Drawing.Size(144, 25);
            this.ClearClient.TabIndex = 8;
            this.ClearClient.Text = "Limpiar ";
            this.ClearClient.UseVisualStyleBackColor = true;
            this.ClearClient.Click += new System.EventHandler(this.ClearClient_Click);
            // 
            // SaveClient
            // 
            this.SaveClient.Location = new System.Drawing.Point(59, 205);
            this.SaveClient.Name = "SaveClient";
            this.SaveClient.Size = new System.Drawing.Size(144, 23);
            this.SaveClient.TabIndex = 7;
            this.SaveClient.Text = "Guardar Cliente";
            this.SaveClient.UseVisualStyleBackColor = true;
            this.SaveClient.Click += new System.EventHandler(this.SaveClient_Click);
            // 
            // PhoneClient
            // 
            this.PhoneClient.Location = new System.Drawing.Point(400, 92);
            this.PhoneClient.Name = "PhoneClient";
            this.PhoneClient.Size = new System.Drawing.Size(144, 25);
            this.PhoneClient.TabIndex = 5;
            // 
            // AddresClient
            // 
            this.AddresClient.Location = new System.Drawing.Point(138, 89);
            this.AddresClient.Name = "AddresClient";
            this.AddresClient.Size = new System.Drawing.Size(144, 25);
            this.AddresClient.TabIndex = 4;
            // 
            // NameClient
            // 
            this.NameClient.Location = new System.Drawing.Point(400, 30);
            this.NameClient.Name = "NameClient";
            this.NameClient.Size = new System.Drawing.Size(144, 25);
            this.NameClient.TabIndex = 3;
            // 
            // Document
            // 
            this.Document.Location = new System.Drawing.Point(138, 30);
            this.Document.Name = "Document";
            this.Document.Size = new System.Drawing.Size(144, 25);
            this.Document.TabIndex = 2;
            // 
            // ConsultarCliente
            // 
            this.ConsultarCliente.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ConsultarCliente.Controls.Add(this.ClearClie);
            this.ConsultarCliente.Controls.Add(this.ModificarCli);
            this.ConsultarCliente.Controls.Add(this.label11);
            this.ConsultarCliente.Controls.Add(this.EmailMod);
            this.ConsultarCliente.Controls.Add(this.Guardar_Cliente);
            this.ConsultarCliente.Controls.Add(this.PhoneMod);
            this.ConsultarCliente.Controls.Add(this.AddresMod);
            this.ConsultarCliente.Controls.Add(this.NameMod);
            this.ConsultarCliente.Controls.Add(this.label10);
            this.ConsultarCliente.Controls.Add(this.label9);
            this.ConsultarCliente.Controls.Add(this.label8);
            this.ConsultarCliente.Controls.Add(this.Consultar_Modificar_Cliente);
            this.ConsultarCliente.Controls.Add(this.DocumentConsulta);
            this.ConsultarCliente.Controls.Add(this.label6);
            this.ConsultarCliente.Location = new System.Drawing.Point(4, 27);
            this.ConsultarCliente.Name = "ConsultarCliente";
            this.ConsultarCliente.Padding = new System.Windows.Forms.Padding(3);
            this.ConsultarCliente.Size = new System.Drawing.Size(579, 368);
            this.ConsultarCliente.TabIndex = 1;
            this.ConsultarCliente.Text = "Consultar Cliente";
            // 
            // ClearClie
            // 
            this.ClearClie.AutoSize = true;
            this.ClearClie.Location = new System.Drawing.Point(334, 105);
            this.ClearClie.Name = "ClearClie";
            this.ClearClie.Size = new System.Drawing.Size(87, 22);
            this.ClearClie.TabIndex = 4;
            this.ClearClie.Text = "Eliminar";
            this.ClearClie.UseVisualStyleBackColor = true;
            // 
            // ModificarCli
            // 
            this.ModificarCli.AutoSize = true;
            this.ModificarCli.Location = new System.Drawing.Point(152, 105);
            this.ModificarCli.Name = "ModificarCli";
            this.ModificarCli.Size = new System.Drawing.Size(92, 22);
            this.ModificarCli.TabIndex = 3;
            this.ModificarCli.Text = "Modificar";
            this.ModificarCli.UseVisualStyleBackColor = true;
            this.ModificarCli.CheckedChanged += new System.EventHandler(this.ModificarCli_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 269);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 18);
            this.label11.TabIndex = 20;
            this.label11.Text = "Correo";
            // 
            // EmailMod
            // 
            this.EmailMod.Enabled = false;
            this.EmailMod.Location = new System.Drawing.Point(123, 266);
            this.EmailMod.Name = "EmailMod";
            this.EmailMod.Size = new System.Drawing.Size(310, 25);
            this.EmailMod.TabIndex = 8;
            // 
            // Guardar_Cliente
            // 
            this.Guardar_Cliente.Location = new System.Drawing.Point(202, 306);
            this.Guardar_Cliente.Name = "Guardar_Cliente";
            this.Guardar_Cliente.Size = new System.Drawing.Size(125, 30);
            this.Guardar_Cliente.TabIndex = 9;
            this.Guardar_Cliente.Text = "Guardar";
            this.Guardar_Cliente.UseVisualStyleBackColor = true;
            this.Guardar_Cliente.Click += new System.EventHandler(this.Guardar_Cliente_Click);
            // 
            // PhoneMod
            // 
            this.PhoneMod.Enabled = false;
            this.PhoneMod.Location = new System.Drawing.Point(123, 225);
            this.PhoneMod.Name = "PhoneMod";
            this.PhoneMod.Size = new System.Drawing.Size(310, 25);
            this.PhoneMod.TabIndex = 7;
            // 
            // AddresMod
            // 
            this.AddresMod.Enabled = false;
            this.AddresMod.Location = new System.Drawing.Point(123, 189);
            this.AddresMod.Name = "AddresMod";
            this.AddresMod.Size = new System.Drawing.Size(310, 25);
            this.AddresMod.TabIndex = 6;
            // 
            // NameMod
            // 
            this.NameMod.Enabled = false;
            this.NameMod.Location = new System.Drawing.Point(123, 148);
            this.NameMod.Name = "NameMod";
            this.NameMod.Size = new System.Drawing.Size(310, 25);
            this.NameMod.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 18);
            this.label10.TabIndex = 14;
            this.label10.Text = "Telefono";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 18);
            this.label9.TabIndex = 13;
            this.label9.Text = "Direccion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Nombre";
            // 
            // Consultar_Modificar_Cliente
            // 
            this.Consultar_Modificar_Cliente.Location = new System.Drawing.Point(257, 64);
            this.Consultar_Modificar_Cliente.Name = "Consultar_Modificar_Cliente";
            this.Consultar_Modificar_Cliente.Size = new System.Drawing.Size(176, 26);
            this.Consultar_Modificar_Cliente.TabIndex = 2;
            this.Consultar_Modificar_Cliente.Text = "Consultar";
            this.Consultar_Modificar_Cliente.UseVisualStyleBackColor = true;
            this.Consultar_Modificar_Cliente.Click += new System.EventHandler(this.Consultar_Modificar_Cliente_Click);
            // 
            // DocumentConsulta
            // 
            this.DocumentConsulta.Location = new System.Drawing.Point(257, 24);
            this.DocumentConsulta.Name = "DocumentConsulta";
            this.DocumentConsulta.Size = new System.Drawing.Size(286, 25);
            this.DocumentConsulta.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = " Documento del Cliente";
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Back.Image = ((System.Drawing.Image)(resources.GetObject("Back.Image")));
            this.Back.Location = new System.Drawing.Point(12, 14);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(92, 23);
            this.Back.TabIndex = 10;
            this.Back.TabStop = false;
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(660, 454);
            this.ControlBox = false;
            this.Controls.Add(this.Back);
            this.Controls.Add(this.IngresarPro);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.TopMost = true;
            this.IngresarPro.ResumeLayout(false);
            this.IngresarCliente.ResumeLayout(false);
            this.IngresarCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ConsultarCliente.ResumeLayout(false);
            this.ConsultarCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl IngresarPro;
        private System.Windows.Forms.TabPage IngresarCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClearClient;
        private System.Windows.Forms.Button SaveClient;
        private System.Windows.Forms.TextBox PhoneClient;
        private System.Windows.Forms.TextBox AddresClient;
        private System.Windows.Forms.TextBox NameClient;
        private System.Windows.Forms.TextBox Document;
        private System.Windows.Forms.TabPage ConsultarCliente;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label correo;
        private System.Windows.Forms.TextBox DocumentConsulta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ClearClie;
        private System.Windows.Forms.CheckBox ModificarCli;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox EmailMod;
        private System.Windows.Forms.Button Guardar_Cliente;
        private System.Windows.Forms.TextBox PhoneMod;
        private System.Windows.Forms.TextBox AddresMod;
        private System.Windows.Forms.TextBox NameMod;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Consultar_Modificar_Cliente;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}