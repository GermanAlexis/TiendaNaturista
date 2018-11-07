namespace TiendaNaturista
{
    partial class Productos
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
            this.IngresarPro = new System.Windows.Forms.TabControl();
            this.IngresarProdcutos = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ClearPro = new System.Windows.Forms.Button();
            this.SaveProduc = new System.Windows.Forms.Button();
            this.CantidadProduc = new System.Windows.Forms.TextBox();
            this.ValorProduc = new System.Windows.Forms.TextBox();
            this.DescriProdc = new System.Windows.Forms.TextBox();
            this.CodeProduc = new System.Windows.Forms.TextBox();
            this.DatosProductos = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.AceptarConsulta = new System.Windows.Forms.Button();
            this.EliminarConsulta = new System.Windows.Forms.CheckBox();
            this.ModificarConsulta = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnConsultarPro = new System.Windows.Forms.Button();
            this.ConsultarPro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.IngresarPro.SuspendLayout();
            this.IngresarProdcutos.SuspendLayout();
            this.DatosProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // IngresarPro
            // 
            this.IngresarPro.Controls.Add(this.IngresarProdcutos);
            this.IngresarPro.Controls.Add(this.DatosProductos);
            this.IngresarPro.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngresarPro.Location = new System.Drawing.Point(13, 28);
            this.IngresarPro.Name = "IngresarPro";
            this.IngresarPro.SelectedIndex = 0;
            this.IngresarPro.Size = new System.Drawing.Size(664, 412);
            this.IngresarPro.TabIndex = 2;
            // 
            // IngresarProdcutos
            // 
            this.IngresarProdcutos.Controls.Add(this.label4);
            this.IngresarProdcutos.Controls.Add(this.label3);
            this.IngresarProdcutos.Controls.Add(this.label2);
            this.IngresarProdcutos.Controls.Add(this.label1);
            this.IngresarProdcutos.Controls.Add(this.ClearPro);
            this.IngresarProdcutos.Controls.Add(this.SaveProduc);
            this.IngresarProdcutos.Controls.Add(this.CantidadProduc);
            this.IngresarProdcutos.Controls.Add(this.ValorProduc);
            this.IngresarProdcutos.Controls.Add(this.DescriProdc);
            this.IngresarProdcutos.Controls.Add(this.CodeProduc);
            this.IngresarProdcutos.Location = new System.Drawing.Point(4, 27);
            this.IngresarProdcutos.Name = "IngresarProdcutos";
            this.IngresarProdcutos.Padding = new System.Windows.Forms.Padding(3);
            this.IngresarProdcutos.Size = new System.Drawing.Size(656, 381);
            this.IngresarProdcutos.TabIndex = 0;
            this.IngresarProdcutos.Text = "Ingresar Producto";
            this.IngresarProdcutos.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Codigo";
            // 
            // ClearPro
            // 
            this.ClearPro.Location = new System.Drawing.Point(315, 147);
            this.ClearPro.Name = "ClearPro";
            this.ClearPro.Size = new System.Drawing.Size(94, 23);
            this.ClearPro.TabIndex = 5;
            this.ClearPro.Text = "Limpiar ";
            this.ClearPro.UseVisualStyleBackColor = true;
            // 
            // SaveProduc
            // 
            this.SaveProduc.Location = new System.Drawing.Point(315, 55);
            this.SaveProduc.Name = "SaveProduc";
            this.SaveProduc.Size = new System.Drawing.Size(144, 23);
            this.SaveProduc.TabIndex = 4;
            this.SaveProduc.Text = "Guardar Producto";
            this.SaveProduc.UseVisualStyleBackColor = true;
            this.SaveProduc.Click += new System.EventHandler(this.SaveProduc_Click);
            // 
            // CantidadProduc
            // 
            this.CantidadProduc.Location = new System.Drawing.Point(138, 198);
            this.CantidadProduc.Name = "CantidadProduc";
            this.CantidadProduc.Size = new System.Drawing.Size(100, 25);
            this.CantidadProduc.TabIndex = 3;
            // 
            // ValorProduc
            // 
            this.ValorProduc.Location = new System.Drawing.Point(138, 147);
            this.ValorProduc.Name = "ValorProduc";
            this.ValorProduc.Size = new System.Drawing.Size(100, 25);
            this.ValorProduc.TabIndex = 2;
            // 
            // DescriProdc
            // 
            this.DescriProdc.Location = new System.Drawing.Point(138, 87);
            this.DescriProdc.Name = "DescriProdc";
            this.DescriProdc.Size = new System.Drawing.Size(144, 25);
            this.DescriProdc.TabIndex = 1;
            // 
            // CodeProduc
            // 
            this.CodeProduc.Location = new System.Drawing.Point(138, 30);
            this.CodeProduc.Name = "CodeProduc";
            this.CodeProduc.Size = new System.Drawing.Size(100, 25);
            this.CodeProduc.TabIndex = 0;
            // 
            // DatosProductos
            // 
            this.DatosProductos.Controls.Add(this.button1);
            this.DatosProductos.Controls.Add(this.dataGridView1);
            this.DatosProductos.Controls.Add(this.textBox4);
            this.DatosProductos.Controls.Add(this.textBox3);
            this.DatosProductos.Controls.Add(this.textBox2);
            this.DatosProductos.Controls.Add(this.AceptarConsulta);
            this.DatosProductos.Controls.Add(this.EliminarConsulta);
            this.DatosProductos.Controls.Add(this.ModificarConsulta);
            this.DatosProductos.Controls.Add(this.label8);
            this.DatosProductos.Controls.Add(this.label7);
            this.DatosProductos.Controls.Add(this.label6);
            this.DatosProductos.Controls.Add(this.BtnConsultarPro);
            this.DatosProductos.Controls.Add(this.ConsultarPro);
            this.DatosProductos.Controls.Add(this.label5);
            this.DatosProductos.Location = new System.Drawing.Point(4, 27);
            this.DatosProductos.Name = "DatosProductos";
            this.DatosProductos.Padding = new System.Windows.Forms.Padding(3);
            this.DatosProductos.Size = new System.Drawing.Size(656, 381);
            this.DatosProductos.TabIndex = 1;
            this.DatosProductos.Text = "Datos Productos";
            this.DatosProductos.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(354, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(273, 266);
            this.dataGridView1.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(130, 258);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(160, 25);
            this.textBox4.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(130, 196);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(160, 25);
            this.textBox3.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(130, 139);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 25);
            this.textBox2.TabIndex = 9;
            // 
            // AceptarConsulta
            // 
            this.AceptarConsulta.Location = new System.Drawing.Point(214, 319);
            this.AceptarConsulta.Name = "AceptarConsulta";
            this.AceptarConsulta.Size = new System.Drawing.Size(76, 30);
            this.AceptarConsulta.TabIndex = 8;
            this.AceptarConsulta.Text = "Aceptar";
            this.AceptarConsulta.UseVisualStyleBackColor = true;
            // 
            // EliminarConsulta
            // 
            this.EliminarConsulta.AutoSize = true;
            this.EliminarConsulta.Location = new System.Drawing.Point(230, 83);
            this.EliminarConsulta.Name = "EliminarConsulta";
            this.EliminarConsulta.Size = new System.Drawing.Size(87, 22);
            this.EliminarConsulta.TabIndex = 7;
            this.EliminarConsulta.Text = "Eliminar";
            this.EliminarConsulta.UseVisualStyleBackColor = true;
            // 
            // ModificarConsulta
            // 
            this.ModificarConsulta.AutoSize = true;
            this.ModificarConsulta.Location = new System.Drawing.Point(68, 83);
            this.ModificarConsulta.Name = "ModificarConsulta";
            this.ModificarConsulta.Size = new System.Drawing.Size(92, 22);
            this.ModificarConsulta.TabIndex = 6;
            this.ModificarConsulta.Text = "Modificar";
            this.ModificarConsulta.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 18);
            this.label8.TabIndex = 5;
            this.label8.Text = "Cantidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "Valor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Descripcion";
            // 
            // BtnConsultarPro
            // 
            this.BtnConsultarPro.Location = new System.Drawing.Point(379, 16);
            this.BtnConsultarPro.Name = "BtnConsultarPro";
            this.BtnConsultarPro.Size = new System.Drawing.Size(118, 23);
            this.BtnConsultarPro.TabIndex = 2;
            this.BtnConsultarPro.Text = "Consultar";
            this.BtnConsultarPro.UseVisualStyleBackColor = true;
            // 
            // ConsultarPro
            // 
            this.ConsultarPro.Location = new System.Drawing.Point(130, 19);
            this.ConsultarPro.Name = "ConsultarPro";
            this.ConsultarPro.Size = new System.Drawing.Size(181, 25);
            this.ConsultarPro.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Codigo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 455);
            this.Controls.Add(this.IngresarPro);
            this.Name = "Productos";
            this.Text = "Productos";
            this.IngresarPro.ResumeLayout(false);
            this.IngresarProdcutos.ResumeLayout(false);
            this.IngresarProdcutos.PerformLayout();
            this.DatosProductos.ResumeLayout(false);
            this.DatosProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl IngresarPro;
        private System.Windows.Forms.TabPage IngresarProdcutos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClearPro;
        private System.Windows.Forms.Button SaveProduc;
        private System.Windows.Forms.TextBox CantidadProduc;
        private System.Windows.Forms.TextBox ValorProduc;
        private System.Windows.Forms.TextBox DescriProdc;
        private System.Windows.Forms.TextBox CodeProduc;
        private System.Windows.Forms.TabPage DatosProductos;
        private System.Windows.Forms.Button AceptarConsulta;
        private System.Windows.Forms.CheckBox EliminarConsulta;
        private System.Windows.Forms.CheckBox ModificarConsulta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnConsultarPro;
        private System.Windows.Forms.TextBox ConsultarPro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}