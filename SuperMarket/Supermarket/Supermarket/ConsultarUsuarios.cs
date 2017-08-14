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
    public partial class ConsultarUsuarios : VentanaBase
    {
        public ConsultarUsuarios()
        {
            InitializeComponent();
        }
        public DataSet llenarDataGriwView()
        {
            DataSet DS;
            string cmd= string.Format("Select * from Usuarios");
            DS = Utilidades.Ejecutar(cmd);
            return DS;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void ConsultarUsuarios_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource=llenarDataGriwView().Tables[0];
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = llenarDataGriwView().Tables[0];
            if (string.IsNullOrEmpty(textBox2.Text.Trim()) == false)
            {
                dataGridView1.DataSource = llenarDataGriwView().Tables[0];
                    DataSet DS;
                    string cmd = "Select * from Usuarios where nombre_usuario  like ('%" + textBox2.Text.Trim() + "%')";
                    DS = Utilidades.Ejecutar(cmd);
                    dataGridView1.DataSource = DS.Tables[0];                                    
            }
            else
            {
                dataGridView1.DataSource = llenarDataGriwView().Tables[0];
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text.Trim()) == true)
            {
                dataGridView1.DataSource = llenarDataGriwView().Tables[0];
            }
        }
    }

}
