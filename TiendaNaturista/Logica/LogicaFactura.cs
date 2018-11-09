using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp;

namespace TiendaNaturista.Logica
{
    class LogicaFactura
    {
        Conexion Con = new Conexion();
        public void LlenarClientes(ComboBox box)
        {
            try
            {
                Con.Conectar();
                string sql = "SELECT * FROM Clientes";
                SqlCommand cmd = new SqlCommand(sql, Con.Conex());
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    box.Items.Add(sdr.GetInt32(0).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                Con.Desconectar();
            }
        }

        public void LlenarVendedor(ComboBox box)
        {
            try
            {
                Con.Conectar();
                string sql = "SELECT * FROM Vendedor";
                SqlCommand cmd = new SqlCommand(sql, Con.Conex());
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    box.Items.Add(sdr.GetString(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                Con.Desconectar();
            }
        }
        public void LlenarProductos(ComboBox box)
        {
            try
            {
                Con.Conectar();
                string sql = "SELECT * FROM Productos";
                SqlCommand cmd = new SqlCommand(sql, Con.Conex());
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    box.Items.Add(sdr.GetInt32(0).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                Con.Desconectar();
            }
        }

        public void InsertarFactura(string CodigoFactura, string Fecha, string IdCliente, string VendedorFactura)
        {
            try
            {
                Con.Conectar();
                string sql = "INSERT INTO Factura VALUES(@CodeFac, @Fecha, @ClienteFac, @ValorFac, @VendedorFac)";
                SqlCommand cmd = new SqlCommand(sql, Con.Conex());
                cmd.Parameters.AddWithValue("@CodeFac", CodigoFactura);
                cmd.Parameters.AddWithValue("@Fecha", Fecha);
                cmd.Parameters.AddWithValue("@ClienteFac", IdCliente);
                cmd.Parameters.AddWithValue("@ValorFac", 0);
                cmd.Parameters.AddWithValue("@VendedorFac", VendedorFactura);
                int result = cmd.ExecuteNonQuery();

                if (result == 1)
                {
                    MessageBox.Show("Factura creada exitosamente");
                }
                else
                {
                    MessageBox.Show("No se pudo crear la factura. Intente mas tarde");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                Con.Desconectar();
            }
        }

        public void LlenarDetallefactura(string CodigoFactura, string CodigoProducto, string Cantidad, string Subtotal)
        {
            try
            {
                Con.Conectar();
                string sql = "INSERT INTO Detalle_Factura VALUES(@CodeFac, @CodeProduc, @CantidadProduc, @SubtotalProduc)";
                SqlCommand cmd = new SqlCommand(sql, Con.Conex());
                cmd.Parameters.AddWithValue("@CodeFac", CodigoFactura);
                cmd.Parameters.AddWithValue("@CodeProduc", CodigoProducto);
                cmd.Parameters.AddWithValue("@CantidadProduc", Cantidad);
                cmd.Parameters.AddWithValue("@SubtotalProduc", Subtotal);
                
                int result = cmd.ExecuteNonQuery();

                if (result == 1)
                {
                    MessageBox.Show("Producto agregado a carrito");
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el producto. Intente mas tarde");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                Con.Desconectar();
            }
        }

        public void MostrarCarritoFactura(DataGridView dataGridView, int CodigoFactura)
        {
            try
            {
                Con.Conectar();
                string sql = "SELECT * FROM  Detalle_Factura WHERE DFac_Number = '" + CodigoFactura +"'";
                SqlCommand cmd = Con.Create();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                DataTable DT = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(DT);
                dataGridView.DataSource = DT;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                Con.Desconectar();
            }
        }

        public string [] ValorProducto(int Codigo)
        {
            string[] dat = new string[1];
            Con.Conectar();

            try
            {
                String sql = "SELECT Pro_Valor FROM Productos Prod WHERE Pro_Code=@CodigoPro";
                SqlCommand cmd = new SqlCommand(sql, Con.Conex());
                cmd.Parameters.AddWithValue("@CodigoPro", Codigo);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dat[0] = dr.GetDouble(0).ToString();                  
                }
                else
                {
                    MessageBox.Show("No se encuentra");
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

        public void ActulizarValorFactura(string ValorFactura, string CodigoFactura)
        {
            try
            {
                Con.Conectar();
                string sql = "UPDATE Factura SET Fac_ValorTotal = @TotalFactura WHERE Fac_Number = @CodigoFactura";
                SqlCommand cmd = new SqlCommand(sql, Con.Conex());
                cmd.Parameters.AddWithValue("@TotalFactura", ValorFactura);
                cmd.Parameters.AddWithValue("@CodigoFactura", CodigoFactura);
                int result = cmd.ExecuteNonQuery();

                if (result == 1)
                {
                    MessageBox.Show("Factura finalizada exitosamente");
                }
                else
                {
                    MessageBox.Show("No se pudo finalizar la factura. Intente mas tarde");
                }
            }
            catch (Exception ex)
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
