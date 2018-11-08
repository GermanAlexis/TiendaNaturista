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
    public partial class Productos : Form
    {
        Logica.LogicaProductos LP = new Logica.LogicaProductos();
        public Productos()
        {
            InitializeComponent();
            LP.MostrarProductos(this.MostrarProductos);
        }

        private void SaveProduc_Click(object sender, EventArgs e)
        {
            string CodigoProducto = CodePro_Ingresar.Text;
            string DescripcionProducto = DescripcionPro_Ingresar.Text;
            string ValorProducto = ValorPro_Ingresar.Text;
            string CantidadProducto = CantidadPro_Ingresar.Text;

            LP.InsertarProducto(CodigoProducto, DescripcionProducto, ValorProducto, CantidadProducto);
        }

        private void BtnConsultarPro_Click(object sender, EventArgs e)
        {
            int Codigo = Int32.Parse(CodigoPro_Consulta.Text);

            //SqlDataReader sdr = LP.BuscarProductos(Codigo);

            /*DescripcionSearch.Text = sdr.GetString(1);
            ValorSearch.Text = sdr.GetDouble(2).ToString();
            CantidadSearch.Text = sdr.GetInt32(3).ToString();*/
        }
    }
}
