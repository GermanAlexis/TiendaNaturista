using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaNaturista.Logica
{
    class LogicaProductos
    {
        WindowsFormsApp.Conexion Con = new WindowsFormsApp.Conexion();
        public void InsertarProducto(string CodigoProducto, string DescripcionProducto, string ValorProducto, string CantProducto)
        {
            try
            {

                string sql = "INSERT INTO Productos VALUES(@CodeProduc, @DescriProdc, @ValorProduc, @CantidadProduc)";
                SqlCommand cmd = new SqlCommand(sql, Con.Conex());
                cmd.Parameters.AddWithValue("@CodeProduc", CodigoProducto);
                cmd.Parameters.AddWithValue("@DescriProdc", DescripcionProducto);
                cmd.Parameters.AddWithValue("@ValorProduc", ValorProducto);
                cmd.Parameters.AddWithValue("@CantidadProduc", CantProducto);
                Con.Conectar();
                int result = cmd.ExecuteNonQuery();

                if (result == 1)
                {
                    MessageBox.Show("Producto agregado exitosamente");
                } else
                {
                    MessageBox.Show("No se pudo guardar el product. Intente mas tarde");
                }

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                Con.Desconectar();
            }

        }
    }
}
