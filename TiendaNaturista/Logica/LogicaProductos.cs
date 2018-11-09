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
                Con.Conectar();
                string sql = "INSERT INTO Productos VALUES(@CodeProduc, @DescriProdc, @ValorProduc, @CantidadProduc)";
                SqlCommand cmd = new SqlCommand(sql, Con.Conex());
                cmd.Parameters.AddWithValue("@CodeProduc", CodigoProducto);
                cmd.Parameters.AddWithValue("@DescriProdc", DescripcionProducto);
                cmd.Parameters.AddWithValue("@ValorProduc", ValorProducto);
                cmd.Parameters.AddWithValue("@CantidadProduc", CantProducto);
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

        public void ActualizarProducto(string CodigoProducto, string DescripcionProducto, string ValorProducto, string CantProducto)
        {
            try
            {
                Con.Conectar();
                string sql = "UPDATE Productos SET Pro_Descripcion = @DescriProduc, Pro_Valor = @ValorProduc, Pro_Cantidad = @CantidadProduc WHERE Pro_Code = @CodeProduc";
                SqlCommand cmd = new SqlCommand(sql, Con.Conex());
                cmd.Parameters.AddWithValue("@DescriProduc", DescripcionProducto);
                cmd.Parameters.AddWithValue("@ValorProduc", ValorProducto);
                cmd.Parameters.AddWithValue("@CantidadProduc", CantProducto);
                cmd.Parameters.AddWithValue("@CodeProduc", CodigoProducto);                
                int result = cmd.ExecuteNonQuery();

                if (result == 1)
                {
                    MessageBox.Show("Producto actualizado exitosamente");
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el producto. Intente mas tarde");
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

        public void ElminarProducto(int Codigo)
        {
            try
            {
                Con.Conectar();
                string sql = "DELETE FROM Productos WHERE Pro_Code = @CodeProduc";
                SqlCommand cmd = new SqlCommand(sql, Con.Conex());
                cmd.Parameters.AddWithValue("@CodeProduc", Codigo);
                int result = cmd.ExecuteNonQuery();
          
                if (result == 1)
                {
                    MessageBox.Show("Producto eliminado exitosamente");
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el producto. Intente mas tarde");
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
        public string[] BuscarProducto(string ID_Producto)
        {
            string[] dat;
            dat = new string[4];
            try
            {

                Con.Conectar();
                String sql = "SELECT * FROM Productos WHERE Pro_Code=@ID_pro";
                SqlCommand cmd = new SqlCommand(sql, Con.Conex());
                cmd.Parameters.AddWithValue("@ID_pro", ID_Producto);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dat[0] = dr.GetInt32(0).ToString();
                    dat[1] = dr.GetString(1);
                    dat[2] = dr.GetDouble(2).ToString();
                    dat[3] = dr.GetInt32(3).ToString();
                }
                else
                {
                    MessageBox.Show("No se encuentra el Producto");
                }

            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Con.Desconectar();
            }
            return dat;
        }
    }
}
