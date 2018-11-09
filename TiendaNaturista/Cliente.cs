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
            MessageBox.Show("Guardado Exitosamente");
        }

        private void Back_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form back = new Menu();
            back.Show();
            this.Hide();
        }

        private void ModificarCli_CheckedChanged(object sender, EventArgs e)
        {
            if(ModificarCli.Checked == true)
            {
                NameMod.Enabled = true;
                AddresMod.Enabled = true;
                PhoneMod.Enabled = true;
                EmailMod.Enabled = true;
            }
            else if (ModificarCli.Checked == false)
            {
                NameMod.Enabled = false;
                AddresMod.Enabled = false;
                PhoneMod.Enabled = false;
                EmailMod.Enabled = false;
            }

        }

        private void ClearClient_Click(object sender, EventArgs e)
        {
            Document.Clear();
            NameClient.Clear();
            PhoneClient.Clear();
            Email.Clear();
            AddresClient.Clear();
        }
    }
}
