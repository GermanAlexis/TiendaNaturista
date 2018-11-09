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

        public void LlenarDetallefactura(string CodigoFactura, string CodigoProducto, string Cantidad)
        {
            try
            {
                Con.Conectar();
                string sql = "INSERT INTO Detalle_Factura VALUES(@CodeFac, @CodeProduc, @CantidadProduc)";
                SqlCommand cmd = new SqlCommand(sql, Con.Conex());
                cmd.Parameters.AddWithValue("@CodeFac", CodigoFactura);
                cmd.Parameters.AddWithValue("@CodeProduc", CodigoProducto);
                cmd.Parameters.AddWithValue("@CantidadProduc", Cantidad);
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

        public void MostrarCarritoFactura(DataGridView dataGridView, string CodigoFactura)
        {
            try
            {
                Con.Conectar();
                string sql = "SELECT * FROM Productos WHERE DFac_Number = "+CodigoFactura+"";
                SqlDataAdapter cmd = new SqlDataAdapter(sql, Con.Conex());
                DataTable DT = new DataTable();
                cmd.Fill(DT);
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
    }
}
