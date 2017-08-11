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
    public partial class ConsultarClientes : Consulta
    {
        public ConsultarClientes()
        {
            InitializeComponent();
        }

        private void ConsultarClientes_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LlenarDataGV("Cliente").Tables[0];
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()) == false)
            {
                try
                {
                    DataSet DS;
                    string cmd = "Select * from cliente where nombre_clientes like ('%" + textBox1.Text.Trim() + "%')";
                    DS = Utilidades.Ejecutar(cmd);
                    dataGridView1.DataSource = DS.Tables[0];
                }
                catch(Exception error)
                {
                    MessageBox.Show("Error: " + error.Message);
                }
            }
        }
    }
}
