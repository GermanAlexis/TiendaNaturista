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
    class LogicaCliente
    {
        WindowsFormsApp.Conexion Con = new WindowsFormsApp.Conexion();

        public void AgregarCliente(string documento, string nombre, string direccion, string telefono, string mail)
        {
            try
            {
                Con.Conectar();
                string sql = "INSERT INTO Clientes VALUES(@ID_Document, @ID_Name, @ID_Addres, @ID_Phone, @ID_Email)";
                SqlCommand cmd = new SqlCommand(sql, Con.Conex());
                cmd.Parameters.AddWithValue("@ID_Document", documento);
                cmd.Parameters.AddWithValue("@ID_Name", nombre);
                cmd.Parameters.AddWithValue("@ID_Addres", direccion);
                cmd.Parameters.AddWithValue("@ID_Phone", telefono);
                cmd.Parameters.AddWithValue("@ID_Email", mail);
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Cliente agregado con exito");
                }
                else
                {
                    MessageBox.Show("El cliente no pudo ser agregado con exito");
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
        }
        public string[] BuscarCliente(string ID_Cliente)
        {
            string[] dat;
            dat = new string[5];
            try
            {

                Con.Conectar();
                String sql = "SELECT * FROM Clientes WHERE ID_Document=@ID_Doc";
                SqlCommand cmd = new SqlCommand(sql, Con.Conex());
                cmd.Parameters.AddWithValue("@ID_Doc", ID_Cliente);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dat[0] = dr.GetInt32(0).ToString();
                    dat[1] = dr.GetString(1);
                    dat[2] = dr.GetString(2);
                    dat[3] = dr.GetString(3);
                    dat[4] = dr.GetString(4);
                }
                else
                {
                    MessageBox.Show("No se encuentra el Cliente");
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
        public void MostrarClientes(DataGridView dataGridView)
        {
            try
            {
                Con.Conectar();
                string sql = "SELECT * FROM Clientes";
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
        public void ActualizarCliente(string ID_Cliente, string nombre, string direccion, string telefono, string mail)
        {
            try
            {
                Con.Conectar();
                string sql = "UPDATE Clientes SET  ID_Name = @nomb, ID_Addres = @dir, ID_Phone = @tel, ID_Email = @mail  WHERE ID_Document = @IDC";
                SqlCommand cmd = new SqlCommand(sql, Con.Conex());
                cmd.Parameters.AddWithValue("@IDC", ID_Cliente);
                cmd.Parameters.AddWithValue("@nomb", nombre);
                cmd.Parameters.AddWithValue("@dir", direccion);
                cmd.Parameters.AddWithValue("@tel", telefono);
                cmd.Parameters.AddWithValue("@mail", mail);
                int result = cmd.ExecuteNonQuery();

                if (result == 1)
                {
                    MessageBox.Show("Cliente actualizado exitosamente");
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el cliente Intente mas tarde");
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
        public void ElminarCliente(string Codigo)
        {
            try
            {
                Con.Conectar();
                string sql = "DELETE FROM Clientes WHERE ID_Document = @CodeClient";
                SqlCommand cmd = new SqlCommand(sql, Con.Conex());
                cmd.Parameters.AddWithValue("@CodeClient", Codigo);
                int result = cmd.ExecuteNonQuery();

                if (result == 1)
                {
                    MessageBox.Show("Producto eliminado exitosamente");
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el producto. Intente mas tarde");
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
