
﻿using System.Windows.Forms;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.IngresarPro = new System.Windows.Forms.TabControl();
            this.IngresarProdcutos = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
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
            this.ConsultarPro = new System.Windows.Forms.Button();
            this.ConfirmarPro = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CantidadSearch = new System.Windows.Forms.TextBox();
            this.ValorSearch = new System.Windows.Forms.TextBox();
            this.DescripcionSearch = new System.Windows.Forms.TextBox();
            this.EliminarConsulta = new System.Windows.Forms.CheckBox();
            this.ModificarConsulta = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CodigoPro_Consulta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Atras = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.IngresarPro.SuspendLayout();
            this.IngresarProdcutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.DatosProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // IngresarPro
            // 
            this.IngresarPro.Controls.Add(this.IngresarProdcutos);
            this.IngresarPro.Controls.Add(this.DatosProductos);
            this.IngresarPro.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngresarPro.Location = new System.Drawing.Point(41, 44);
            this.IngresarPro.Name = "IngresarPro";
            this.IngresarPro.SelectedIndex = 0;
            this.IngresarPro.Size = new System.Drawing.Size(664, 415);
            this.IngresarPro.TabIndex = 2;
            // 
            // IngresarProdcutos
            // 
            this.IngresarProdcutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.IngresarProdcutos.Controls.Add(this.dataGridView2);
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
            this.IngresarProdcutos.Size = new System.Drawing.Size(656, 384);
            this.IngresarProdcutos.TabIndex = 0;
            this.IngresarProdcutos.Text = "Ingresar Producto";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(86, 248);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(478, 121);
            this.dataGridView2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Codigo";
            // 
            // ClearPro
            // 
            this.ClearPro.Location = new System.Drawing.Point(167, 187);
            this.ClearPro.Name = "ClearPro";
            this.ClearPro.Size = new System.Drawing.Size(94, 30);
            this.ClearPro.TabIndex = 5;
            this.ClearPro.Text = "Limpiar ";
            this.ClearPro.UseVisualStyleBackColor = true;
            // 
            // SaveProduc
            // 
            this.SaveProduc.Location = new System.Drawing.Point(371, 187);
            this.SaveProduc.Name = "SaveProduc";
            this.SaveProduc.Size = new System.Drawing.Size(144, 30);
            this.SaveProduc.TabIndex = 4;
            this.SaveProduc.Text = "Guardar Producto";
            this.SaveProduc.UseVisualStyleBackColor = true;
            this.SaveProduc.Click += new System.EventHandler(this.SaveProduc_Click);
            // 
            // CantidadPro_Ingresar
            // 
            this.CantidadPro_Ingresar.Location = new System.Drawing.Point(429, 111);
            this.CantidadPro_Ingresar.Name = "CantidadPro_Ingresar";
            this.CantidadPro_Ingresar.Size = new System.Drawing.Size(123, 25);
            this.CantidadPro_Ingresar.TabIndex = 3;
            // 
            // ValorPro_Ingresar
            // 
            this.ValorPro_Ingresar.Location = new System.Drawing.Point(429, 32);
            this.ValorPro_Ingresar.Name = "ValorPro_Ingresar";
            this.ValorPro_Ingresar.Size = new System.Drawing.Size(123, 25);
            this.ValorPro_Ingresar.TabIndex = 2;
            // 
            // DescripcionPro_Ingresar
            // 
            this.DescripcionPro_Ingresar.Location = new System.Drawing.Point(138, 107);
            this.DescripcionPro_Ingresar.Name = "DescripcionPro_Ingresar";
            this.DescripcionPro_Ingresar.Size = new System.Drawing.Size(144, 25);
            this.DescripcionPro_Ingresar.TabIndex = 1;
            // 
            // CodePro_Ingresar
            // 
            this.CodePro_Ingresar.Location = new System.Drawing.Point(138, 32);
            this.CodePro_Ingresar.Name = "CodePro_Ingresar";
            this.CodePro_Ingresar.Size = new System.Drawing.Size(144, 25);
            this.CodePro_Ingresar.TabIndex = 0;
            // 
            // DatosProductos
            // 
            this.DatosProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DatosProductos.Controls.Add(this.ConsultarPro);
            this.DatosProductos.Controls.Add(this.ConfirmarPro);
            this.DatosProductos.Controls.Add(this.dataGridView1);
            this.DatosProductos.Controls.Add(this.CantidadSearch);
            this.DatosProductos.Controls.Add(this.ValorSearch);
            this.DatosProductos.Controls.Add(this.DescripcionSearch);
            this.DatosProductos.Controls.Add(this.EliminarConsulta);
            this.DatosProductos.Controls.Add(this.ModificarConsulta);
            this.DatosProductos.Controls.Add(this.label8);
            this.DatosProductos.Controls.Add(this.label7);
            this.DatosProductos.Controls.Add(this.label6);
            this.DatosProductos.Controls.Add(this.CodigoPro_Consulta);
            this.DatosProductos.Controls.Add(this.label5);
            this.DatosProductos.Location = new System.Drawing.Point(4, 27);
            this.DatosProductos.Name = "DatosProductos";
            this.DatosProductos.Padding = new System.Windows.Forms.Padding(3);
            this.DatosProductos.Size = new System.Drawing.Size(656, 384);
            this.DatosProductos.TabIndex = 1;
            this.DatosProductos.Text = "Datos Productos";
            // 
            // ConsultarPro
            // 
            this.ConsultarPro.Location = new System.Drawing.Point(354, 20);
            this.ConsultarPro.Name = "ConsultarPro";
            this.ConsultarPro.Size = new System.Drawing.Size(169, 24);
            this.ConsultarPro.TabIndex = 14;
            this.ConsultarPro.Text = "Consultar Producto";
            this.ConsultarPro.UseVisualStyleBackColor = true;
            this.ConsultarPro.Click += new System.EventHandler(this.ConsultarPro_Click);
            // 
            // ConfirmarPro
            // 
            this.ConfirmarPro.Location = new System.Drawing.Point(130, 314);
            this.ConfirmarPro.Name = "ConfirmarPro";
            this.ConfirmarPro.Size = new System.Drawing.Size(114, 35);
            this.ConfirmarPro.TabIndex = 13;
            this.ConfirmarPro.Text = "Aceptar";
            this.ConfirmarPro.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(354, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(273, 266);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.TabStop = false;
            // 
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
            // 
            // EliminarConsulta
            // 
            this.EliminarConsulta.AutoSize = true;
            this.EliminarConsulta.Location = new System.Drawing.Point(230, 83);
            this.EliminarConsulta.Name = "EliminarConsulta";
            this.EliminarConsulta.Size = new System.Drawing.Size(87, 22);
            this.EliminarConsulta.TabIndex = 4;
            this.EliminarConsulta.Text = "Eliminar";
            this.EliminarConsulta.UseVisualStyleBackColor = true;
            // 
            // ModificarConsulta
            // 
            this.ModificarConsulta.AutoSize = true;
            this.ModificarConsulta.Location = new System.Drawing.Point(68, 83);
            this.ModificarConsulta.Name = "ModificarConsulta";
            this.ModificarConsulta.Size = new System.Drawing.Size(92, 22);
            this.ModificarConsulta.TabIndex = 3;
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
            // Atras
            // 
            this.Atras.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Atras.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Atras.Image = ((System.Drawing.Image)(resources.GetObject("Atras.Image")));
            this.Atras.Location = new System.Drawing.Point(31, 12);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(75, 23);
            this.Atras.TabIndex = 3;
            this.Atras.UseVisualStyleBackColor = false;
            this.Atras.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(380, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(229, 29);
            this.label10.TabIndex = 4;
            this.label10.Text = "Gestor de Productos";
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(727, 471);
            this.ControlBox = false;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Atras);
            this.Controls.Add(this.IngresarPro);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Productos";
            this.ShowIcon = false;
            this.Text = "Productos";
            this.IngresarPro.ResumeLayout(false);
            this.IngresarProdcutos.ResumeLayout(false);
            this.IngresarProdcutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.TextBox CodigoPro_Consulta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CantidadSearch;
        private System.Windows.Forms.TextBox ValorSearch;
        private System.Windows.Forms.TextBox DescripcionSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        public int HEAD { get; private set; }
        private Button Atras;
        private Button ConfirmarPro;
        private Button ConsultarPro;
        private Label label10;
        private DataGridView dataGridView2;
    }
}