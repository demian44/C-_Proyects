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
    public partial class MantenimientoCliente : Mantenimiento
    {
        public MantenimientoCliente()
        {
            InitializeComponent();
        }
        public override bool Guardar()
        {
            
            Boolean retorno = false;
            if (Utilidades.ValidarFormulario(this, errorProvider1) == false)
            {
                if (!ExisteCliente())
                    retorno = true;
            }
            if (retorno)
            {
                if (MessageBox.Show("Está a punto de guardar al cliente de Id: " + textId_Cli.Text, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    try
                    {
                        string cmd = string.Format("Exec ActualizarCliente '{0}','{1}','{2}'", textId_Cli.Text.Trim(), textNom_Cli.Text.Trim(), textApellido.Text.Trim());
                        Utilidades.Ejecutar(cmd);
                        MessageBox.Show("Se actualizó la base de datos.");
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Error: " + error.Message);
                        retorno = false;
                    }
                }                
            }
            else
            {                
                MessageBox.Show("EHJAA");
            }
            textId_Cli.Focus();
            return retorno;
        }
        public override void Eliminar()
        {
            if (MessageBox.Show("Está a punto de eliminar al Id: " + textId_Cli.Text, "Aviso",MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                try
                {
                    string cmd = string.Format("Exec EliminarCliente '{0}'", textId_Cli.Text.Trim());
                    Utilidades.Ejecutar(cmd);
                    MessageBox.Show("Cliente eliminado exitosamente.");
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error: " + error.Message);
                }
            }         
            
        }
        public override void Nuevo()
        {
            textNom_Cli.Text = "";
            textId_Cli.Text = "";
            textApellido.Text = "";
        }        
        public  Boolean ExisteCliente()
        {
            Boolean retorno = false;
            try
            {
                string cmd = "Select * From Cliente Where id_clientes = " + textId_Cli.Text.Trim();
                DataSet DS = new DataSet();
                DS = Utilidades.Ejecutar(cmd);
                DS.Tables[0].Rows[0].ToString();
                MessageBox.Show("OISAD");
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
            ConsultarClientes Consultar_Clientes = new ConsultarClientes();
            Consultar_Clientes.ShowDialog();
            if (Consultar_Clientes.DialogResult == DialogResult.OK)
            {
                textId_Cli.Text = Consultar_Clientes.dataGridView1.Rows[Consultar_Clientes.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                textNom_Cli.Text = Consultar_Clientes.dataGridView1.Rows[Consultar_Clientes.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                textApellido.Text = Consultar_Clientes.dataGridView1.Rows[Consultar_Clientes.dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
            }
        }

    }
}


