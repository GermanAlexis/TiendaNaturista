namespace TiendaNaturista
{
    partial class Factura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factura));
            this.CodeFact = new System.Windows.Forms.TextBox();
            this.Cantidad = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.AddProduc = new System.Windows.Forms.Button();
            this.TerminarFact = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VendedorFac = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DetalleCarrito = new System.Windows.Forms.DataGridView();
            this.comboBox_Cliente = new System.Windows.Forms.ComboBox();
            this.comboBoxProducto = new System.Windows.Forms.ComboBox();
            this.Back = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.GeneraFac = new System.Windows.Forms.Button();
            this.comboBoxVendedor = new System.Windows.Forms.ComboBox();
            this.ValorTotalFactura = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleCarrito)).BeginInit();
            this.SuspendLayout();
            // 
            // CodeFact
            // 
            this.CodeFact.Location = new System.Drawing.Point(121, 46);
            this.CodeFact.Margin = new System.Windows.Forms.Padding(4);
            this.CodeFact.Name = "CodeFact";
            this.CodeFact.Size = new System.Drawing.Size(148, 25);
            this.CodeFact.TabIndex = 0;
            // 
            // Cantidad
            // 
            this.Cantidad.Location = new System.Drawing.Point(121, 353);
            this.Cantidad.Margin = new System.Windows.Forms.Padding(4);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(235, 25);
            this.Cantidad.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(37, 217);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(319, 25);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.TabStop = false;
            // 
            // AddProduc
            // 
            this.AddProduc.BackColor = System.Drawing.Color.LightGreen;
            this.AddProduc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProduc.ForeColor = System.Drawing.Color.Blue;
            this.AddProduc.Image = ((System.Drawing.Image)(resources.GetObject("AddProduc.Image")));
            this.AddProduc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddProduc.Location = new System.Drawing.Point(408, 338);
            this.AddProduc.Margin = new System.Windows.Forms.Padding(4);
            this.AddProduc.Name = "AddProduc";
            this.AddProduc.Size = new System.Drawing.Size(172, 42);
            this.AddProduc.TabIndex = 5;
            this.AddProduc.Text = "Agregar Producto";
            this.AddProduc.UseVisualStyleBackColor = false;
            this.AddProduc.Click += new System.EventHandler(this.AddProduc_Click);
            // 
            // TerminarFact
            // 
            this.TerminarFact.BackColor = System.Drawing.Color.Brown;
            this.TerminarFact.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TerminarFact.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TerminarFact.Image = ((System.Drawing.Image)(resources.GetObject("TerminarFact.Image")));
            this.TerminarFact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TerminarFact.Location = new System.Drawing.Point(599, 338);
            this.TerminarFact.Margin = new System.Windows.Forms.Padding(4);
            this.TerminarFact.Name = "TerminarFact";
            this.TerminarFact.Size = new System.Drawing.Size(191, 40);
            this.TerminarFact.TabIndex = 6;
            this.TerminarFact.Text = "Terminar Factura";
            this.TerminarFact.UseVisualStyleBackColor = false;
            this.TerminarFact.Click += new System.EventHandler(this.TerminarFact_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cliente";
            // 
            // VendedorFac
            // 
            this.VendedorFac.AutoSize = true;
            this.VendedorFac.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendedorFac.Location = new System.Drawing.Point(34, 154);
            this.VendedorFac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VendedorFac.Name = "VendedorFac";
            this.VendedorFac.Size = new System.Drawing.Size(72, 18);
            this.VendedorFac.TabIndex = 13;
            this.VendedorFac.Text = "Vendedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 356);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 279);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Valor Total";
            // 
            // DetalleCarrito
            // 
            this.DetalleCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalleCarrito.Location = new System.Drawing.Point(444, 46);
            this.DetalleCarrito.Name = "DetalleCarrito";
            this.DetalleCarrito.Size = new System.Drawing.Size(355, 181);
            this.DetalleCarrito.TabIndex = 17;
            this.DetalleCarrito.TabStop = false;
            // 
            // comboBox_Cliente
            // 
            this.comboBox_Cliente.FormattingEnabled = true;
            this.comboBox_Cliente.Location = new System.Drawing.Point(121, 90);
            this.comboBox_Cliente.Name = "comboBox_Cliente";
            this.comboBox_Cliente.Size = new System.Drawing.Size(235, 26);
            this.comboBox_Cliente.TabIndex = 2;
            // 
            // comboBoxProducto
            // 
            this.comboBoxProducto.FormattingEnabled = true;
            this.comboBoxProducto.Location = new System.Drawing.Point(118, 305);
            this.comboBoxProducto.Name = "comboBoxProducto";
            this.comboBoxProducto.Size = new System.Drawing.Size(235, 26);
            this.comboBoxProducto.TabIndex = 3;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Back.Image = ((System.Drawing.Image)(resources.GetObject("Back.Image")));
            this.Back.Location = new System.Drawing.Point(20, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(92, 23);
            this.Back.TabIndex = 19;
            this.Back.TabStop = false;
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Producto";
            // 
            // GeneraFac
            // 
            this.GeneraFac.BackColor = System.Drawing.Color.Turquoise;
            this.GeneraFac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GeneraFac.Location = new System.Drawing.Point(133, 262);
            this.GeneraFac.Name = "GeneraFac";
            this.GeneraFac.Size = new System.Drawing.Size(198, 35);
            this.GeneraFac.TabIndex = 22;
            this.GeneraFac.Text = "Generar Factura";
            this.GeneraFac.UseVisualStyleBackColor = false;
            this.GeneraFac.Click += new System.EventHandler(this.GeneraFac_Click);
            // 
            // comboBoxVendedor
            // 
            this.comboBoxVendedor.FormattingEnabled = true;
            this.comboBoxVendedor.Location = new System.Drawing.Point(121, 150);
            this.comboBoxVendedor.Name = "comboBoxVendedor";
            this.comboBoxVendedor.Size = new System.Drawing.Size(232, 26);
            this.comboBoxVendedor.TabIndex = 23;
            // 
            // ValorTotalFactura
            // 
            this.ValorTotalFactura.Location = new System.Drawing.Point(523, 276);
            this.ValorTotalFactura.Margin = new System.Windows.Forms.Padding(4);
            this.ValorTotalFactura.Name = "ValorTotalFactura";
            this.ValorTotalFactura.Size = new System.Drawing.Size(148, 25);
            this.ValorTotalFactura.TabIndex = 24;
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(811, 420);
            this.ControlBox = false;
            this.Controls.Add(this.ValorTotalFactura);
            this.Controls.Add(this.comboBoxVendedor);
            this.Controls.Add(this.GeneraFac);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.comboBoxProducto);
            this.Controls.Add(this.comboBox_Cliente);
            this.Controls.Add(this.DetalleCarrito);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.VendedorFac);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TerminarFact);
            this.Controls.Add(this.AddProduc);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Cantidad);
            this.Controls.Add(this.CodeFact);
            this.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Factura";
            this.Text = "Factura";
            ((System.ComponentModel.ISupportInitialize)(this.DetalleCarrito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CodeFact;
        private System.Windows.Forms.TextBox Cantidad;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button AddProduc;
        private System.Windows.Forms.Button TerminarFact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label VendedorFac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DetalleCarrito;
        private System.Windows.Forms.ComboBox comboBox_Cliente;
        private System.Windows.Forms.ComboBox comboBoxProducto;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GeneraFac;
        private System.Windows.Forms.ComboBox comboBoxVendedor;
        private System.Windows.Forms.TextBox ValorTotalFactura;
    }
}