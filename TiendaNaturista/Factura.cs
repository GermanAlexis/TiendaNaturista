using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaNaturista
{
    public partial class Factura : System.Windows.Forms.Form
    {
        Logica.LogicaFactura LF = new Logica.LogicaFactura();
        public Factura()
        {
            InitializeComponent();
            LF.LlenarClientes(comboBox_Cliente);
            LF.LlenarProductos(comboBoxProducto);
            LF.LlenarVendedor(comboBoxVendedor);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form back = new Menu();
            back.Show();
            this.Hide();
        }

        private void GeneraFac_Click(object sender, EventArgs e)
        {
            string Codigo = CodeFact.Text;

            LF.InsertarFactura(Codigo, dateTimePicker1.Value.ToShortDateString(), comboBox_Cliente.SelectedItem.ToString(), comboBoxVendedor.SelectedItem.ToString());
            CodeFact.Enabled = false;
            comboBox_Cliente.Enabled = false;
            comboBoxVendedor.Enabled = false;
        }

        private void AddProduc_Click(object sender, EventArgs e)
        {
            string[] vector = new string[1];
            string Codigo = CodeFact.Text;
            string Producto = comboBoxProducto.SelectedItem.ToString();
            string CantidadPro = Cantidad.Text;

            vector = LF.ValorProducto(int.Parse(CodeFact.Text));

            float subtotal = float.Parse(vector[0]) * float.Parse(CantidadPro);

            LF.LlenarDetallefactura(Codigo, Producto, CantidadPro, subtotal.ToString());

            LF.MostrarCarritoFactura(this.DetalleCarrito, int.Parse(CodeFact.Text));

            double total = 0;

            foreach (DataGridViewRow row in DetalleCarrito.Rows)
            {
                total += Convert.ToDouble(row.Cells["DFac_Subtotal"].Value);
            }

            ValorTotalFactura.Text = Convert.ToString(total);
        }

        private void TerminarFact_Click(object sender, EventArgs e)
        {
            LF.ActulizarValorFactura(ValorTotalFactura.Text, CodeFact.Text);
        }
    }
}
