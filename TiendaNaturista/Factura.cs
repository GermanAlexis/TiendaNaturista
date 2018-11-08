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
    public partial class Factura : System.Windows.Forms.Form
    {
        public Factura()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form back = new Menu();
            back.Show();
            this.Hide();
        }

        private void GeneraFac_Click(object sender, EventArgs e)
        {
            if(GeneraFac.Enabled == true)
            {
                CodeFact.Enabled = false;
                comboBox_Cliente.Enabled = false;
                comboBoxVendedor.Enabled = false;
            }
        }
    }
}
