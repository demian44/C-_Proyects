using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MiLibreria;

namespace Supermarket
{
    public partial class VentanaLogin : VentanaBase
    {
        public VentanaLogin()
        {
            InitializeComponent();
            boxAccount.Text = "Pedro_01";
            boxPass.Text = "123456";
        }
        public static string codigo ="";
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string CMD = string.Format("Select * FROM Usuarios Where account = '{0}' AND password = {1}", boxAccount.Text.Trim(),boxPass.Text.Trim());
                DataSet DS = Utilidades.Ejecutar(CMD);
                string cuenta= DS.Tables[0].Rows[0]["account"].ToString().Trim();
                string contra = DS.Tables[0].Rows[0]["password"].ToString().Trim();
                codigo = DS.Tables[0].Rows[0]["id_usuario"].ToString().Trim();
                if(cuenta == boxAccount.Text.Trim() && contra == boxPass.Text.Trim())
                {
                    this.Hide();
                    if (Convert.ToBoolean(DS.Tables[0].Rows[0]["status_admin"]))
                    {
                        VentanaAdmin ventanaAdmin = new VentanaAdmin();
                        ventanaAdmin.Show();
                    }
                    else
                    {
                        VentanaUser ventanaUser = new VentanaUser();
                        ventanaUser.Show();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
                boxAccount.ResetText();
                boxPass.ResetText();
            }
        }

        private void VentanaLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
