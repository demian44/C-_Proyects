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
            if (Utilidades.ValidarFormulario(this, errorProvider1) == false)
            {

                try
                {
                    string cmd = string.Format("EXEC ActualizarArticulos '{0}','{1}','{2}'", textId_P.Text.Trim(), textNom_Prod.Text.Trim(), textPrecio.Text.Trim());
                    Utilidades.Ejecutar(cmd);
                    MessageBox.Show("Se ha guardado correctamente.");
                    return true;
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error: " + error.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public override void Eliminar()
        {
            try
            {
                string cmd = string.Format("EXEC EliminarArticulos '{0}'", textId_P.Text.Trim());
                Utilidades.Ejecutar(cmd);
                MessageBox.Show("Se ha eliminado con éxito.");

            }
            catch(Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
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
    }
}
