using System;
using System.Collections.Generic;
using System.Data;
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

        public void MostrarProductos(DataGridView dataGridView)
        {
            try
            {
                Con.Conectar();
                string sql = "SELECT * FROM Productos";
                SqlDataAdapter cmd = new SqlDataAdapter(sql, Con.Conex());
                DataTable DT = new DataTable();
                cmd.Fill(DT);
                dataGridView.DataSource = DT;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                Con.Desconectar();
            }
        }

        public void BuscarProducto(int Codigo)
        {
            try
            {
                Con.Conectar();
                string sql = "SELECT * FROM Productos where Pro_Code=@Code";
                SqlCommand cmd = new SqlCommand(sql, Con.Conex());
                cmd.Parameters.AddWithValue("@Code", Codigo);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show(dr.GetInt32(1).ToString());

                }
                else {
                    MessageBox.Show("No existe un producto con este codigo");
                }

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Desconectar();
            }
        }

        /*public SqlDataReader BuscarProductos(int Codigo)
        {
            Con.Conectar();
            string sql = "SELECT * FROM Productos where Pro_Code=@Code";
            SqlCommand cmd = new SqlCommand(sql, Con.Conex());
            cmd.Parameters.AddWithValue("@Code", Codigo);
            SqlDataReader dr = cmd.ExecuteReader();

            dr.Read();
            return dr;
            Con.Desconectar();
        }*/
    }
}
