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
    public partial class CambioContraseña : VentanaBase
    {
        public CambioContraseña()
        {
            InitializeComponent();
          
        }
        static int originalPass;
        static string cmd;
        static DataSet DS;
        private void CambioContraseña_Load(object sender, EventArgs e)
        {
            cmd = "Select * from Usuarios where id_usuario = " + VentanaLogin.codigo.ToString().Trim();
            DS = Utilidades.Ejecutar(cmd);
            int.TryParse(DS.Tables[0].Rows[0]["password"].ToString().Trim(), out originalPass);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (Utilidades.ValidarFormulario(this, errorProvider1) == true)
                return;
            if (originalPass.ToString().Trim() == textBoxPass.Text.Trim())
            {
                if (textBoxNewPass.Text.Trim() == textBoxRepPass.Text.Trim())
                {
                    if(textBoxNewPass.Text.Trim()==textBoxPass.Text.Trim())
                    {
                        MessageBox.Show("La contraseña actual y la nueva contraseña son iguale.");
                        textBoxNewPass.Focus();
                        return;
                    }
                    cmd = "update Usuarios set password=" + textBoxNewPass.Text.Trim() + "where id_usuario=" + VentanaLogin.codigo;
                    Utilidades.Ejecutar(cmd);
                    MessageBox.Show("Contraseña modificada!");
                    textBoxNewPass.Text = "";
                    textBoxPass.Text = "";
                    textBoxRepPass.Text = "";
                    int.TryParse(textBoxNewPass.Text.Trim(),out originalPass);
                    btnSalir.Focus();
                }
                else
                {
                    MessageBox.Show("Contraseñas no coinciden.");
                    textBoxNewPass.Focus();

                }
            }
            else
            {
                MessageBox.Show("Contraseña actual incorrecta.");
                textBoxPass.Focus();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
