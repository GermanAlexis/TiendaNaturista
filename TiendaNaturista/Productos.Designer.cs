<<<<<<< Updated upstream
﻿using System.Windows.Forms;

=======
>>>>>>> Stashed changes
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
            this.CantidadPro_Ingresar = new System.Windows.Forms.TextBox();
            this.ValorPro_Ingresar = new System.Windows.Forms.TextBox();
            this.DescripcionPro_Ingresar = new System.Windows.Forms.TextBox();
            this.CodePro_Ingresar = new System.Windows.Forms.TextBox();
            this.DatosProductos = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
<<<<<<< HEAD
            this.CantidadSearch = new System.Windows.Forms.TextBox();
            this.ValorSearch = new System.Windows.Forms.TextBox();
            this.DescripcionSearch = new System.Windows.Forms.TextBox();
            this.AceptarConsulta = new System.Windows.Forms.Button();
=======
<<<<<<< Updated upstream
            this.CantidadPro_Consulta = new System.Windows.Forms.TextBox();
            this.ValorPro_Consulta = new System.Windows.Forms.TextBox();
            this.DescripcionPro_Consulta = new System.Windows.Forms.TextBox();
=======
>>>>>>> Stashed changes
>>>>>>> master
            this.EliminarConsulta = new System.Windows.Forms.CheckBox();
            this.ModificarConsulta = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ConsultarPro_ = new System.Windows.Forms.Button();
            this.CodigoPro_Consulta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
<<<<<<< HEAD
=======
<<<<<<< Updated upstream
            this.ConfirmaPro_Consulta = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
=======
>>>>>>> Stashed changes
>>>>>>> master
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
            this.IngresarPro.Size = new System.Drawing.Size(664, 415);
            this.IngresarPro.TabIndex = 2;
            // 
            // IngresarProdcutos
            // 
            this.IngresarProdcutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.IngresarProdcutos.Controls.Add(this.label4);
            this.IngresarProdcutos.Controls.Add(this.label3);
            this.IngresarProdcutos.Controls.Add(this.label2);
            this.IngresarProdcutos.Controls.Add(this.label1);
            this.IngresarProdcutos.Controls.Add(this.ClearPro);
            this.IngresarProdcutos.Controls.Add(this.SaveProduc);
            this.IngresarProdcutos.Controls.Add(this.CantidadPro_Ingresar);
            this.IngresarProdcutos.Controls.Add(this.ValorPro_Ingresar);
            this.IngresarProdcutos.Controls.Add(this.DescripcionPro_Ingresar);
            this.IngresarProdcutos.Controls.Add(this.CodePro_Ingresar);
            this.IngresarProdcutos.Location = new System.Drawing.Point(4, 27);
            this.IngresarProdcutos.Name = "IngresarProdcutos";
            this.IngresarProdcutos.Padding = new System.Windows.Forms.Padding(3);
<<<<<<< HEAD
            this.IngresarProdcutos.Size = new System.Drawing.Size(682, 384);
=======
            this.IngresarProdcutos.Size = new System.Drawing.Size(656, 384);
>>>>>>> master
            this.IngresarProdcutos.TabIndex = 0;
            this.IngresarProdcutos.Text = "Ingresar Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Codigo";
            // 
            // ClearPro
            // 
            this.ClearPro.Location = new System.Drawing.Point(173, 268);
            this.ClearPro.Name = "ClearPro";
            this.ClearPro.Size = new System.Drawing.Size(94, 23);
            this.ClearPro.TabIndex = 5;
            this.ClearPro.Text = "Limpiar ";
            this.ClearPro.UseVisualStyleBackColor = true;
            // 
            // SaveProduc
            // 
            this.SaveProduc.Location = new System.Drawing.Point(378, 268);
            this.SaveProduc.Name = "SaveProduc";
            this.SaveProduc.Size = new System.Drawing.Size(144, 23);
            this.SaveProduc.TabIndex = 4;
            this.SaveProduc.Text = "Guardar Producto";
            this.SaveProduc.UseVisualStyleBackColor = true;
            this.SaveProduc.Click += new System.EventHandler(this.SaveProduc_Click);
            // 
            // CantidadPro_Ingresar
            // 
            this.CantidadPro_Ingresar.Location = new System.Drawing.Point(429, 152);
            this.CantidadPro_Ingresar.Name = "CantidadPro_Ingresar";
            this.CantidadPro_Ingresar.Size = new System.Drawing.Size(123, 25);
            this.CantidadPro_Ingresar.TabIndex = 3;
            // 
            // ValorPro_Ingresar
            // 
            this.ValorPro_Ingresar.Location = new System.Drawing.Point(429, 60);
            this.ValorPro_Ingresar.Name = "ValorPro_Ingresar";
            this.ValorPro_Ingresar.Size = new System.Drawing.Size(123, 25);
            this.ValorPro_Ingresar.TabIndex = 2;
            // 
            // DescripcionPro_Ingresar
            // 
            this.DescripcionPro_Ingresar.Location = new System.Drawing.Point(138, 152);
            this.DescripcionPro_Ingresar.Name = "DescripcionPro_Ingresar";
            this.DescripcionPro_Ingresar.Size = new System.Drawing.Size(144, 25);
            this.DescripcionPro_Ingresar.TabIndex = 1;
            // 
            // CodePro_Ingresar
            // 
            this.CodePro_Ingresar.Location = new System.Drawing.Point(138, 60);
            this.CodePro_Ingresar.Name = "CodePro_Ingresar";
            this.CodePro_Ingresar.Size = new System.Drawing.Size(144, 25);
            this.CodePro_Ingresar.TabIndex = 0;
            // 
            // DatosProductos
            // 
            this.DatosProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DatosProductos.Controls.Add(this.ConfirmaPro_Consulta);
            this.DatosProductos.Controls.Add(this.dataGridView1);
<<<<<<< HEAD
            this.DatosProductos.Controls.Add(this.CantidadSearch);
            this.DatosProductos.Controls.Add(this.ValorSearch);
            this.DatosProductos.Controls.Add(this.DescripcionSearch);
            this.DatosProductos.Controls.Add(this.AceptarConsulta);
=======
            this.DatosProductos.Controls.Add(this.CantidadPro_Consulta);
            this.DatosProductos.Controls.Add(this.ValorPro_Consulta);
            this.DatosProductos.Controls.Add(this.DescripcionPro_Consulta);
>>>>>>> master
            this.DatosProductos.Controls.Add(this.EliminarConsulta);
            this.DatosProductos.Controls.Add(this.ModificarConsulta);
            this.DatosProductos.Controls.Add(this.label8);
            this.DatosProductos.Controls.Add(this.label7);
            this.DatosProductos.Controls.Add(this.label6);
            this.DatosProductos.Controls.Add(this.ConsultarPro_);
            this.DatosProductos.Controls.Add(this.CodigoPro_Consulta);
            this.DatosProductos.Controls.Add(this.label5);
            this.DatosProductos.Location = new System.Drawing.Point(4, 27);
            this.DatosProductos.Name = "DatosProductos";
            this.DatosProductos.Padding = new System.Windows.Forms.Padding(3);
            this.DatosProductos.Size = new System.Drawing.Size(656, 384);
            this.DatosProductos.TabIndex = 1;
            this.DatosProductos.Text = "Datos Productos";
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(354, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(273, 266);
            this.dataGridView1.TabIndex = 12;
            // 
<<<<<<< HEAD
            // CantidadSearch
            // 
            this.CantidadSearch.Location = new System.Drawing.Point(130, 258);
            this.CantidadSearch.Name = "CantidadSearch";
            this.CantidadSearch.Size = new System.Drawing.Size(160, 25);
            this.CantidadSearch.TabIndex = 11;
            // 
            // ValorSearch
            // 
            this.ValorSearch.Location = new System.Drawing.Point(130, 196);
            this.ValorSearch.Name = "ValorSearch";
            this.ValorSearch.Size = new System.Drawing.Size(160, 25);
            this.ValorSearch.TabIndex = 10;
            // 
            // DescripcionSearch
            // 
            this.DescripcionSearch.Location = new System.Drawing.Point(130, 139);
            this.DescripcionSearch.Name = "DescripcionSearch";
            this.DescripcionSearch.Size = new System.Drawing.Size(160, 25);
            this.DescripcionSearch.TabIndex = 9;
=======
            // CantidadPro_Consulta
            // 
            this.CantidadPro_Consulta.Location = new System.Drawing.Point(130, 258);
            this.CantidadPro_Consulta.Name = "CantidadPro_Consulta";
            this.CantidadPro_Consulta.Size = new System.Drawing.Size(160, 25);
            this.CantidadPro_Consulta.TabIndex = 11;
            // 
            // ValorPro_Consulta
            // 
            this.ValorPro_Consulta.Location = new System.Drawing.Point(130, 196);
            this.ValorPro_Consulta.Name = "ValorPro_Consulta";
            this.ValorPro_Consulta.Size = new System.Drawing.Size(160, 25);
            this.ValorPro_Consulta.TabIndex = 10;
>>>>>>> master
            // 
            // DescripcionPro_Consulta
            // 
<<<<<<< HEAD
            this.AceptarConsulta.Location = new System.Drawing.Point(214, 319);
            this.AceptarConsulta.Name = "AceptarConsulta";
            this.AceptarConsulta.Size = new System.Drawing.Size(76, 30);
            this.AceptarConsulta.TabIndex = 8;
            this.AceptarConsulta.Text = "Aceptar";
            this.AceptarConsulta.UseVisualStyleBackColor = true;
=======
            this.DescripcionPro_Consulta.Location = new System.Drawing.Point(130, 142);
            this.DescripcionPro_Consulta.Name = "DescripcionPro_Consulta";
            this.DescripcionPro_Consulta.Size = new System.Drawing.Size(160, 25);
            this.DescripcionPro_Consulta.TabIndex = 13;
>>>>>>> master
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
            // ConsultarPro_
            // 
<<<<<<< HEAD
            this.BtnConsultarPro.Location = new System.Drawing.Point(379, 16);
            this.BtnConsultarPro.Name = "BtnConsultarPro";
            this.BtnConsultarPro.Size = new System.Drawing.Size(118, 23);
            this.BtnConsultarPro.TabIndex = 2;
            this.BtnConsultarPro.Text = "Consultar";
            this.BtnConsultarPro.UseVisualStyleBackColor = true;
            this.BtnConsultarPro.Click += new System.EventHandler(this.BtnConsultarPro_Click);
=======
            this.ConsultarPro_.Location = new System.Drawing.Point(379, 16);
            this.ConsultarPro_.Name = "ConsultarPro_";
            this.ConsultarPro_.Size = new System.Drawing.Size(118, 23);
            this.ConsultarPro_.TabIndex = 2;
            this.ConsultarPro_.Text = "Consultar";
            this.ConsultarPro_.UseVisualStyleBackColor = true;
            this.ConsultarPro_.Click += new System.EventHandler(this.BtnConsultarPro_Click);
>>>>>>> master
            // 
            // CodigoPro_Consulta
            // 
            this.CodigoPro_Consulta.Location = new System.Drawing.Point(130, 19);
            this.CodigoPro_Consulta.Name = "CodigoPro_Consulta";
            this.CodigoPro_Consulta.Size = new System.Drawing.Size(181, 25);
            this.CodigoPro_Consulta.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Codigo";
<<<<<<< HEAD
=======
            // 
            // ConfirmaPro_Consulta
            // 
            this.ConfirmaPro_Consulta.Location = new System.Drawing.Point(139, 313);
            this.ConfirmaPro_Consulta.Name = "ConfirmaPro_Consulta";
            this.ConfirmaPro_Consulta.Size = new System.Drawing.Size(116, 27);
            this.ConfirmaPro_Consulta.TabIndex = 14;
            this.ConfirmaPro_Consulta.Text = "Confirmar";
            this.ConfirmaPro_Consulta.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(372, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(239, 29);
            this.label9.TabIndex = 3;
            this.label9.Text = "Gestion de Productos";
>>>>>>> master
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(715, 455);
            this.Controls.Add(this.label9);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl IngresarPro;
        private System.Windows.Forms.TabPage IngresarProdcutos;

        public DataGridView MostrarProductos { get; private set; }

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClearPro;
        private System.Windows.Forms.Button SaveProduc;
        private System.Windows.Forms.TextBox CantidadPro_Ingresar;
        private System.Windows.Forms.TextBox ValorPro_Ingresar;
        private System.Windows.Forms.TextBox DescripcionPro_Ingresar;
        private System.Windows.Forms.TextBox CodePro_Ingresar;
        private System.Windows.Forms.TabPage DatosProductos;
        private System.Windows.Forms.CheckBox EliminarConsulta;
        private System.Windows.Forms.CheckBox ModificarConsulta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ConsultarPro_;
        private System.Windows.Forms.TextBox CodigoPro_Consulta;
        private System.Windows.Forms.Label label5;
<<<<<<< HEAD
        private System.Windows.Forms.TextBox CantidadSearch;
        private System.Windows.Forms.TextBox ValorSearch;
        private System.Windows.Forms.TextBox DescripcionSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView MostrarProductos;
        private System.Windows.Forms.Button button1;
        public int HEAD { get; private set; }

=======
        private System.Windows.Forms.TextBox CantidadPro_Consulta;
        private System.Windows.Forms.TextBox ValorPro_Consulta;
        private System.Windows.Forms.TextBox DescripcionPro_Consulta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Button ConfirmaPro_Consulta;
        private Label label9;
>>>>>>> master
    }
}