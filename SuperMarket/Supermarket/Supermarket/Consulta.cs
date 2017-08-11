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
    public partial class Consulta : VentanaBase
    {
        public Consulta()
        {
            InitializeComponent();
        }
        public DataSet LlenarDataGV(string tabla)
        {
            DataSet DS;
            string cmd = string.Format("Select * from " + tabla);
            DS = Utilidades.Ejecutar(cmd);
            return DS;

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
               return;
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
