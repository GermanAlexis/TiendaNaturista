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
using WindowsFormsApp;

namespace TiendaNaturista
{
    public partial class Productos : System.Windows.Forms.Form
    {
        Logica.LogicaProductos LP = new Logica.LogicaProductos();
        Conexion Con = new Conexion();
        public Productos()
        {
            InitializeComponent();
            LP.MostrarProductos(this.MostrarTodosProducto);
        }

        private void SaveProduc_Click(object sender, EventArgs e)
        {
            string CodigoProducto = CodePro_Ingresar.Text;
            string DescripcionProducto = DescripcionPro_Ingresar.Text;
            string ValorProducto = ValorPro_Ingresar.Text;
            string CantidadProducto = CantidadPro_Ingresar.Text;

            LP.InsertarProducto(CodigoProducto, DescripcionProducto, ValorProducto, CantidadProducto);
            LP.MostrarProductos(this.MostrarTodosProducto);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form back = new Menu();
            back.Show();
            this.Hide();
        }

        private void ConsultarPro_Click(object sender, EventArgs e)
        {
            string[] vector;
            vector = new string[4];
            vector = LP.BuscarProducto(CodigoPro_Consulta.Text);
            DescripcionSearch.Text = vector[1];
            ValorSearch.Text = vector[2];
            CantidadSearch.Text = vector[3];
        }

        private void ConfirmarPro_Click(object sender, EventArgs e)
        {
            string CodigoP = CodigoPro_Consulta.Text;
            string Descripcion = DescripcionSearch.Text;
            string Valor = ValorSearch.Text;
            string Cantidad = CantidadSearch.Text;
            int Codigo = Int32.Parse(CodigoPro_Consulta.Text);
            if (EliminarConsulta.Checked)
            {
                LP.ElminarProducto(Codigo);
            }
            else if (ModificarConsulta.Checked)
            {
                LP.ActualizarProducto(CodigoP, Descripcion, Valor, Cantidad);
            }
            CodigoPro_Consulta.Text = "";
            DescripcionSearch.Text = "";
            ValorSearch.Text = "";
            CantidadSearch.Text = "";
            CodigoPro_Consulta.Focus();
            LP.MostrarProductos(this.MostrarTodosProducto);
        }

        private void ClearPro_Click(object sender, EventArgs e)
        {
            CodePro_Ingresar.Clear();
            DescripcionPro_Ingresar.Clear();
            ValorPro_Ingresar.Clear();
            CantidadPro_Ingresar.Clear();
            
        }

        private void ModificarConsulta_CheckedChanged(object sender, EventArgs e)
        {
            
                if (ModificarConsulta.Checked == true)
                {
                    DescripcionSearch.Enabled = true;
                    ValorSearch.Enabled = true;
                    CantidadSearch.Enabled = true;
                }
                else if(  ModificarConsulta.Checked == false )
                {
                    DescripcionSearch.Enabled = false;
                    ValorSearch.Enabled = false;
                    CantidadSearch.Enabled = false;
                }
            
        }
    }
}
