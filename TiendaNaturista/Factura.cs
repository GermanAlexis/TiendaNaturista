using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            LF.MostrarCarritoFactura(this.DetalleCarrito, CodeFact.Text);
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
            string Codigo = CodeFact.Text;
            string Producto = comboBoxProducto.SelectedItem.ToString();
            string CantidadPro = Cantidad.Text;
            LF.LlenarDetallefactura(Codigo, Producto, CantidadPro);
            LF.MostrarCarritoFactura(this.DetalleCarrito, CodeFact.Text);
        }
    }
}
