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
    public partial class MantenimientoProducto : Mantenimiento
    {
        public MantenimientoProducto()
        {
            InitializeComponent();
        }
        public override bool Guardar()
        {
            Boolean retorno = false;
            if (Utilidades.ValidarFormulario(this, errorProvider1) == false)
            {


                if (!ExisteProducto())
                {

                    try
                    {
                        string cmd = string.Format("EXEC ActualizarArticulos '{0}','{1}','{2}'", textId_P.Text.Trim(), textNom_Prod.Text.Trim(), textPrecio.Text.Trim());
                        Utilidades.Ejecutar(cmd);
                        MessageBox.Show("Se ha guardado correctamente.");
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Ha ocurrido un error: " + error.Message);
                        retorno = false;
                    }
                }
                else
                    MessageBox.Show("Ya existe un producto con ese Id");
            }
            return retorno;
        }
        public override void Eliminar()
        {
            if (Utilidades.ValidarFormulario(this, errorProvider1) == false)
            {
                if (ExisteProducto())
                {
                    if (MessageBox.Show("Está a punto de eliminar al Id: " + textId_P.Text, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        try
                        {
                            string cmd = string.Format("EXEC EliminarArticulos '{0}'", textId_P.Text.Trim());
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
                    MessageBox.Show("No existe un producto con ese Id");
            }
        }

        public override void Consultar()
        {

        }

        private void textId_P_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Utilidades.ValidarFormulario(this, errorProvider1) == false)
            {
                MessageBox.Show("EHJAA");
            }
        }
        public Boolean ExisteProducto()
        {
            Boolean retorno = false;
            try
            {
                string cmd = "Select * From Articulo Where id_producto = " + textId_P.Text.Trim();
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ConsultarProductos Consultar_Productos = new ConsultarProductos();
            Consultar_Productos.ShowDialog();
            if (Consultar_Productos.DialogResult == DialogResult.OK)
            {
                textId_P.Text = Consultar_Productos.dataGridView1.Rows[Consultar_Productos.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                textNom_Prod.Text = Consultar_Productos.dataGridView1.Rows[Consultar_Productos.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                textPrecio.Text = Consultar_Productos.dataGridView1.Rows[Consultar_Productos.dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            textId_P.Text = "";
            textNom_Prod.Text = "";
            textPrecio.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
