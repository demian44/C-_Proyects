using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket
{
    public partial class MantenimientoUsuario : Mantenimiento
    {
        public MantenimientoUsuario()
        {
            InitializeComponent();
        }

        /*

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
   if (MessageBox.Show("Está a punto de eliminar al Id: " + textId_Cli.Text, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
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

private void textNom_Cli_TextChanged(object sender, EventArgs e)
{

}
public Boolean ExisteCliente()
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

}*/

    }
}
