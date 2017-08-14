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
    public partial class VentanaAdmin : VentanaBase
    {
        public VentanaAdmin()
        {
            InitializeComponent();
        }

        private void VentanaAdmin_Load(object sender, EventArgs e)
        {
            string cmd = "SELECT * FROM Usuarios Where id_usuario=" + VentanaLogin.codigo;
            DataSet dataSet = Utilidades.Ejecutar(cmd);
            label_Admin.Text = dataSet.Tables[0].Rows[0]["nombre_usuario"].ToString();
            label_Code.Text = dataSet.Tables[0].Rows[0]["id_usuario"].ToString();
            label_User.Text = dataSet.Tables[0].Rows[0]["account"].ToString();
            string url = dataSet.Tables[0].Rows[0]["url_imagen"].ToString();
            pictureBox1.Image = Image.FromFile(url);
        }

        private void VentanaAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            VentanaLogin ventanaLogin = new VentanaLogin();
            ventanaLogin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContenedorPrincipal Contenedor_Principal = new ContenedorPrincipal();
            Contenedor_Principal.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MantenimientoUsuario Mantenimiento_Usuarios = new MantenimientoUsuario();
            Mantenimiento_Usuarios.ShowDialog();           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            VentanaLogin ventanaLogin = new VentanaLogin();
            ventanaLogin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CambioContraseña cambiarContraseña = new CambioContraseña();
            cambiarContraseña.ShowDialog();
        }
    }
}