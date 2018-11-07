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
            this.label5 = new System.Windows.Forms.Label();
            this.IngresarPro = new System.Windows.Forms.TabControl();
            this.IngresarCliente = new System.Windows.Forms.TabPage();
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.correo = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DocumentConsulta = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.DocumentoModificar = new System.Windows.Forms.TextBox();
            this.Consultar_Modificar_Cliente = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Guardar_Modificar_Cliente = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.IngresarPro.SuspendLayout();
            this.IngresarCliente.SuspendLayout();
            this.ConsultarCliente.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(172, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 31);
            this.label5.TabIndex = 2;
            this.label5.Text = "Gestion  de Cliente";
            // 
            // IngresarPro
            // 
            this.IngresarPro.Controls.Add(this.IngresarCliente);
            this.IngresarPro.Controls.Add(this.ConsultarCliente);
            this.IngresarPro.Controls.Add(this.tabPage1);
            this.IngresarPro.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngresarPro.Location = new System.Drawing.Point(51, 43);
            this.IngresarPro.Name = "IngresarPro";
            this.IngresarPro.SelectedIndex = 0;
            this.IngresarPro.Size = new System.Drawing.Size(507, 318);
            this.IngresarPro.TabIndex = 3;
            // 
            // IngresarCliente
            // 
            this.IngresarCliente.BackColor = System.Drawing.SystemColors.ActiveBorder;
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
            this.IngresarCliente.Size = new System.Drawing.Size(499, 287);
            this.IngresarCliente.TabIndex = 0;
            this.IngresarCliente.Text = "Ingresar Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Direccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 87);
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
            this.ClearClient.Location = new System.Drawing.Point(315, 147);
            this.ClearClient.Name = "ClearClient";
            this.ClearClient.Size = new System.Drawing.Size(144, 25);
            this.ClearClient.TabIndex = 5;
            this.ClearClient.Text = "Limpiar ";
            this.ClearClient.UseVisualStyleBackColor = true;
            // 
            // SaveClient
            // 
            this.SaveClient.Location = new System.Drawing.Point(315, 55);
            this.SaveClient.Name = "SaveClient";
            this.SaveClient.Size = new System.Drawing.Size(144, 23);
            this.SaveClient.TabIndex = 4;
            this.SaveClient.Text = "Guardar Cliente";
            this.SaveClient.UseVisualStyleBackColor = true;
            // 
            // PhoneClient
            // 
            this.PhoneClient.Location = new System.Drawing.Point(138, 198);
            this.PhoneClient.Name = "PhoneClient";
            this.PhoneClient.Size = new System.Drawing.Size(144, 25);
            this.PhoneClient.TabIndex = 3;
            // 
            // AddresClient
            // 
            this.AddresClient.Location = new System.Drawing.Point(138, 147);
            this.AddresClient.Name = "AddresClient";
            this.AddresClient.Size = new System.Drawing.Size(144, 25);
            this.AddresClient.TabIndex = 2;
            // 
            // NameClient
            // 
            this.NameClient.Location = new System.Drawing.Point(138, 87);
            this.NameClient.Name = "NameClient";
            this.NameClient.Size = new System.Drawing.Size(144, 25);
            this.NameClient.TabIndex = 1;
            // 
            // Document
            // 
            this.Document.Location = new System.Drawing.Point(138, 30);
            this.Document.Name = "Document";
            this.Document.Size = new System.Drawing.Size(144, 25);
            this.Document.TabIndex = 0;
            // 
            // ConsultarCliente
            // 
            this.ConsultarCliente.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ConsultarCliente.Controls.Add(this.listView1);
            this.ConsultarCliente.Controls.Add(this.DocumentConsulta);
            this.ConsultarCliente.Controls.Add(this.label6);
            this.ConsultarCliente.Location = new System.Drawing.Point(4, 27);
            this.ConsultarCliente.Name = "ConsultarCliente";
            this.ConsultarCliente.Padding = new System.Windows.Forms.Padding(3);
            this.ConsultarCliente.Size = new System.Drawing.Size(499, 287);
            this.ConsultarCliente.TabIndex = 1;
            this.ConsultarCliente.Text = "Consultar Cliente";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.Guardar_Modificar_Cliente);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.Consultar_Modificar_Cliente);
            this.tabPage1.Controls.Add(this.DocumentoModificar);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(499, 287);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Modificar Cliente";
            // 
            // correo
            // 
            this.correo.AutoSize = true;
            this.correo.Location = new System.Drawing.Point(34, 246);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(55, 18);
            this.correo.TabIndex = 10;
            this.correo.Text = "Correo";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(138, 246);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(144, 25);
            this.Email.TabIndex = 11;
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
            // DocumentConsulta
            // 
            this.DocumentConsulta.Location = new System.Drawing.Point(257, 31);
            this.DocumentConsulta.Name = "DocumentConsulta";
            this.DocumentConsulta.Size = new System.Drawing.Size(164, 25);
            this.DocumentConsulta.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(59, 123);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(362, 140);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Documento Cliente";
            // 
            // DocumentoModificar
            // 
            this.DocumentoModificar.Location = new System.Drawing.Point(237, 29);
            this.DocumentoModificar.Name = "DocumentoModificar";
            this.DocumentoModificar.Size = new System.Drawing.Size(148, 25);
            this.DocumentoModificar.TabIndex = 1;
            // 
            // Consultar_Modificar_Cliente
            // 
            this.Consultar_Modificar_Cliente.Location = new System.Drawing.Point(135, 73);
            this.Consultar_Modificar_Cliente.Name = "Consultar_Modificar_Cliente";
            this.Consultar_Modificar_Cliente.Size = new System.Drawing.Size(176, 26);
            this.Consultar_Modificar_Cliente.TabIndex = 2;
            this.Consultar_Modificar_Cliente.Text = "Consultar";
            this.Consultar_Modificar_Cliente.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(85, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 18);
            this.label8.TabIndex = 3;
            this.label8.Text = "Nombre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(85, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 18);
            this.label9.TabIndex = 4;
            this.label9.Text = "Direccion";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(85, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 18);
            this.label10.TabIndex = 5;
            this.label10.Text = "Telefono";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(177, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 25);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(177, 164);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 25);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(177, 211);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(158, 25);
            this.textBox3.TabIndex = 8;
            // 
            // Guardar_Modificar_Cliente
            // 
            this.Guardar_Modificar_Cliente.Location = new System.Drawing.Point(350, 150);
            this.Guardar_Modificar_Cliente.Name = "Guardar_Modificar_Cliente";
            this.Guardar_Modificar_Cliente.Size = new System.Drawing.Size(132, 39);
            this.Guardar_Modificar_Cliente.TabIndex = 9;
            this.Guardar_Modificar_Cliente.Text = "Guardar";
            this.Guardar_Modificar_Cliente.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(177, 251);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(158, 25);
            this.textBox4.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(85, 254);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 18);
            this.label11.TabIndex = 11;
            this.label11.Text = "Correo";
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(609, 373);
            this.Controls.Add(this.IngresarPro);
            this.Controls.Add(this.label5);
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.IngresarPro.ResumeLayout(false);
            this.IngresarCliente.ResumeLayout(false);
            this.IngresarCliente.PerformLayout();
            this.ConsultarCliente.ResumeLayout(false);
            this.ConsultarCliente.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label correo;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox DocumentConsulta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DocumentoModificar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button Guardar_Modificar_Cliente;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Consultar_Modificar_Cliente;
    }
}