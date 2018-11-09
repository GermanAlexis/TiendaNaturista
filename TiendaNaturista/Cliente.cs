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
        Logica.LogicaCliente CL = new Logica.LogicaCliente();
        public Cliente()
        {
            InitializeComponent();
            CL.MostrarClientes(dataGridView2);
        }

        private void SaveClient_Click(object sender, EventArgs e)
        {
            CL.AgregarCliente(Document.Text, NameClient.Text,AddresClient.Text, PhoneClient.Text, Email.Text);
            Document.Clear();
            NameClient.Clear();
            AddresClient.Clear();
            PhoneClient.Clear();
            Email.Clear();
            Document.Focus();
            CL.MostrarClientes(dataGridView2);
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

        private void Consultar_Modificar_Cliente_Click(object sender, EventArgs e)
        {
            string[] vector;
            vector = new string[5];
            vector = CL.BuscarCliente(DocumentConsulta.Text);
            NameMod.Text = vector[1];
            AddresMod.Text = vector[2];
            PhoneMod.Text = vector[3];
            EmailMod.Text = vector[4];
        }

        private void Guardar_Cliente_Click(object sender, EventArgs e)
        {
            if (ClearClie.Checked)
            {
                CL.ElminarCliente(DocumentConsulta.Text);
                DocumentConsulta.Clear();
                NameMod.Clear();
                PhoneMod.Clear();
                EmailMod.Clear();
                AddresMod.Clear();
                CL.MostrarClientes(dataGridView2);
            }
            else if (ModificarCli.Checked)
            {
                CL.ActualizarCliente(DocumentConsulta.Text, NameMod.Text, AddresMod.Text, PhoneMod.Text, EmailMod.Text);
                DocumentConsulta.Clear();
                NameMod.Clear();
                PhoneMod.Clear();
                EmailMod.Clear();
                AddresMod.Clear();
                CL.MostrarClientes(dataGridView2);
            }
        }
    }
}
