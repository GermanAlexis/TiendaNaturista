using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaNaturista
{
    public partial class Cliente : System.Windows.Forms.Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void SaveClient_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola cole");
        }

        private void Back_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form back = new Menu();
            back.Show();
            this.Hide();
        }
    }
}
