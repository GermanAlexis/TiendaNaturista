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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form invoice = new Factura();
            invoice.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Client = new Cliente();
            Client.Show();
        }
    }
}
