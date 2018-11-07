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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SaveProduc = new System.Windows.Forms.Button();
            this.CantidadProduc = new System.Windows.Forms.TextBox();
            this.ValorProduc = new System.Windows.Forms.TextBox();
            this.DescriProdc = new System.Windows.Forms.TextBox();
            this.CodeProduc = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.IngresarPro.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IngresarPro
            // 
            this.IngresarPro.Controls.Add(this.tabPage1);
            this.IngresarPro.Controls.Add(this.tabPage2);
            this.IngresarPro.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngresarPro.Location = new System.Drawing.Point(13, 28);
            this.IngresarPro.Name = "IngresarPro";
            this.IngresarPro.SelectedIndex = 0;
            this.IngresarPro.Size = new System.Drawing.Size(507, 273);
            this.IngresarPro.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.SaveProduc);
            this.tabPage1.Controls.Add(this.CantidadProduc);
            this.tabPage1.Controls.Add(this.ValorProduc);
            this.tabPage1.Controls.Add(this.DescriProdc);
            this.tabPage1.Controls.Add(this.CodeProduc);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(499, 242);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ingresar Producto";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(315, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Limpiar ";
            this.button2.UseVisualStyleBackColor = true;
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(499, 242);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 329);
            this.Controls.Add(this.IngresarPro);
            this.Name = "Productos";
            this.Text = "Productos";
            this.IngresarPro.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl IngresarPro;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button SaveProduc;
        private System.Windows.Forms.TextBox CantidadProduc;
        private System.Windows.Forms.TextBox ValorProduc;
        private System.Windows.Forms.TextBox DescriProdc;
        private System.Windows.Forms.TextBox CodeProduc;
        private System.Windows.Forms.TabPage tabPage2;
    }
}