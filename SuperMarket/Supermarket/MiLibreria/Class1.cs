using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace MiLibreria
{
    public class Utilidades
    {
        public static DataSet Ejecutar(string cmd)
        {
            SqlConnection ConectionSql = new SqlConnection("Data Source=.;Initial Catalog=Administración;Integrated Security=True");
            ConectionSql.Open();
            DataSet DS = new DataSet();
            SqlDataAdapter DP = new SqlDataAdapter(cmd,ConectionSql);
            DP.Fill(DS);
            ConectionSql.Close();
            return DS;
        }

        public static Boolean ValidarFormulario(Control Objeto, ErrorProvider Error_Provider)
        {
            Boolean HayErrores = false;
            foreach(Control Item in Objeto.Controls)
            {
                if (Item is ErrorTextBox)
                {
                    ErrorTextBox obj = (ErrorTextBox)Item;
                    if(obj.Validar== true)
                    {
                        if (string.IsNullOrEmpty(obj.Text.Trim()))
                        {
                            Error_Provider.SetError(obj, "No puede estar vacío.");
                            HayErrores = true;
                        }
                    }
                   
                    if(obj.SoloNumeros ==true)
                    {
                        int contador = 0, letrasEncontradas = 0;
                        foreach(char letra in obj.Text.Trim())
                        {
                            if (char.IsLetter(obj.Text.Trim(), contador))
                            {
                                letrasEncontradas++;
                            }
                            contador++;
                        }
                        if (letrasEncontradas != 0)
                        {
                            HayErrores = true;
                            Error_Provider.SetError(obj, "Ingresar sólo números.");
                        }
                    }
                }
                
            }
            return HayErrores;
        }
    }
}
