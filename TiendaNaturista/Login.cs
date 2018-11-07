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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void IngresarLogin_Click(object sender, EventArgs e)
        {
            string user = User.Text;
            string pass = Passwork.Text;

            Conexion Con = new Conexion();

            try
            {
                string sql = "SELECT * FROM Vendedor where Ven_User=@user and Ven_Password=@password";
                SqlCommand cmd = new SqlCommand(sql, Con.Conex());

                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@password", pass);
                Con.Conectar();

                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet dse = new DataSet();

                adapt.Fill(dse);
                Con.Desconectar();

                int count = dse.Tables[0].Rows.Count;

                if (count == 1)
                {
                    MessageBox.Show("Bienvenido al sistema");
                    this.Hide();
                    Menu MP = new Menu();
                    MP.Show();

                }
                else
                {
                    MessageBox.Show("No existe ningun usuario registrado");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Passwork_TextChanged(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                IngresarLogin.PerformClick();
            }
        }
    }
}
