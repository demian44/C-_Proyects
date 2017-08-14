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
using System.IO;

namespace Supermarket
{
    public partial class MantenimientoUsuario : Mantenimiento
    {
        public static int generadorId=0;
        public MantenimientoUsuario()
        {
            InitializeComponent();
        }
        private void MantenimientoUsuario_Load(object sender, EventArgs e)
        {
            generadorId = BuscarIdMaximo();
            pictureBox1.ImageLocation = "C:/Users/DEM/Documents/Visual Studio 2017/Projects/SuperMarket/Supermarket/Imagenes/SIN_FOTO.png";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ConsultarUsuarios Consultar_Usuarios = new ConsultarUsuarios();
            Consultar_Usuarios.ShowDialog();
            try
            {
                if (Consultar_Usuarios.DialogResult == DialogResult.OK)
                {
                    TextId.Text = Consultar_Usuarios.dataGridView1.Rows[Consultar_Usuarios.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                    textNombre.Text = Consultar_Usuarios.dataGridView1.Rows[Consultar_Usuarios.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                    textUsuario.Text = Consultar_Usuarios.dataGridView1.Rows[Consultar_Usuarios.dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                    textRepPass.Text = textPass.Text = Consultar_Usuarios.dataGridView1.Rows[Consultar_Usuarios.dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
                    textUrl.Text = Consultar_Usuarios.dataGridView1.Rows[Consultar_Usuarios.dataGridView1.CurrentRow.Index].Cells[5].Value.ToString();
                    pictureBox1.Image = Image.FromFile(textUrl.Text.Trim().ToString());
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: ", error.Message);
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (Utilidades.ValidarFormulario(this, errorProvider1) == false)
            {
                if (textPass.Text.Trim() != textRepPass.Text.Trim())
                {
                    MessageBox.Show("La repeticiónd e la contraseña no coincide.");
                    return;
                }
                if (!ExisteUsuario())
                {
                    try
                    {
                        generadorId++;
                        string cmd = string.Format("EXEC ActualizarUsuarios '{0}','{1}','{2}','{3}','{4}','{5}'", generadorId, textNombre.Text.Trim(), textUsuario.Text.Trim(), textPass.Text.Trim(), radioAdminYes.Checked, textUrl.Text.Trim());
                        Utilidades.Ejecutar(cmd);
                        MessageBox.Show("Se ha guardado correctamente.");
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Ha ocurrido un error: " + error.Message);
                    }
                }
                else
                    MessageBox.Show("Ya existe un Usuario con ese Id");
            }
        }

        public Boolean ExisteUsuario()
        {
            Boolean retorno = false;
            try
            {
                string cmd = "Select * From Usuarios Where id_usuario = " + TextId.Text.Trim();
                DataSet DS = new DataSet();
                DS = Utilidades.Ejecutar(cmd);
                DS.Tables[0].Rows[0].ToString();
                retorno = true;
            }
            catch
            {
                retorno = false;
            }
            return retorno;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            TextId.Text = "";
            textNombre.Text = "";
            textUsuario.Text = "";
            textPass.Text = "";
            textUrl.Text = "";
            pictureBox1.ImageLocation = "C:/Users/DEM/Documents/Visual Studio 2017/Projects/SuperMarket/Supermarket/Imagenes/SIN_FOTO.png";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (Utilidades.ValidarFormulario(this, errorProvider1) == false)
            {
                MessageBox.Show("NISMAN");
                if (textPass.Text.Trim() != textRepPass.Text.Trim())
                {
                    MessageBox.Show("La repeticiónd e la contraseña no coincide.");
                    return;
                }
                if (ExisteUsuario())
                {

                    try
                    {

                        string cmd = string.Format("EXEC ActualizarUsuarios '{0}','{1}','{2}','{3}','{4}','{5}'", TextId.Text.Trim(), textNombre.Text.Trim(), textUsuario.Text.Trim(), textPass.Text.Trim(), radioAdminYes.Checked, textUrl.Text.Trim());
                        Utilidades.Ejecutar(cmd);
                        MessageBox.Show("Se ha guardado correctamente.");
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Ha ocurrido un error: " + error.Message);
                    }
                }
                else
                    MessageBox.Show("NO existe un Usuario con ese Id");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Utilidades.ValidarFormulario(this, errorProvider1) == false)
            {
                if (ExisteUsuario())
                {
                    if (MessageBox.Show("Está a punto de eliminar al Id: " + TextId.Text, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        try
                        {
                            string cmd = string.Format("EXEC EliminarUsuario '{0}'", TextId.Text.Trim());
                            Utilidades.Ejecutar(cmd);
                            MessageBox.Show("Se ha eliminado con éxito.");
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show("Error: " + error.Message);
                        }
                    }
                }
                else
                    MessageBox.Show("No existe un usuarios con ese Id");
            }
        }
        private int BuscarIdMaximo()
        {
            int idRetorno = 0;
            string cmd = "select id_usuario from Usuarios where id_usuario=(Select Max(id_usuario) from Usuarios)";
            DataSet DS;
            DS = Utilidades.Ejecutar(cmd);
            int.TryParse(DS.Tables[0].Rows[0]["id_usuario"].ToString().Trim(), out idRetorno);
            return idRetorno;
        }
    }
}

