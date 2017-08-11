using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiLibreria;

namespace Supermarket
{
    public partial class VentanaUser : VentanaBase
    {
        public VentanaUser()
        {
            InitializeComponent();
        }


        private void VentanaUser_Load(object sender, EventArgs e)
        {
            string cmd = "SELECT * FROM Usuarios Where id_usuario=" + VentanaLogin.codigo;
            DataSet dataSet = Utilidades.Ejecutar(cmd);
            labelNombre.Text = dataSet.Tables[0].Rows[0]["nombre_usuario"].ToString();
            label_Code.Text = dataSet.Tables[0].Rows[0]["id_usuario"].ToString();
            label_User.Text = dataSet.Tables[0].Rows[0]["account"].ToString();
            string url = dataSet.Tables[0].Rows[0]["url_imagen"].ToString();
            pictureBox1.Image = Image.FromFile(url);
        }


        private void VentanaUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            VentanaLogin ventanaLogin = new VentanaLogin();
            ventanaLogin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContenedorPrincipal Contenedor_Principal = new ContenedorPrincipal();
            Hide();
            Contenedor_Principal.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
