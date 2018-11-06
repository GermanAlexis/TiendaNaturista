using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    class Conexion
    {

        SqlConnection Con = new SqlConnection("Data Source = .; Initial Catalog = TiendaNaturista; Integrated Security = true");

        public void Conectar()
        {
            try
            {
                Con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Desconectar()
        {
            Con.Close();
        }

        //funcion que devuelve la conexion sqlserver
        public SqlConnection Conex()
        {
            return Con;
        }

    }
}
