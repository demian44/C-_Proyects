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
    public partial class Facturacion : VentanaBase
    {
        public Facturacion()
        {
            InitializeComponent();
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            string cmd = "Select * from Usuarios where id_usuario = " + VentanaLogin.codigo;
            lblTotal.Text = "$ 0,00";
            DataSet DS = Utilidades.Ejecutar(cmd);
            lblAtiende.Text = DS.Tables[0].Rows[0]["nombre_usuario"].ToString().Trim();
            txtBoxCliente.Enabled= txtDecripcion.Enabled = txtPrecio.Enabled = false;
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCodigo.Text.Trim()) == false)
                {
                
                    string cmd = string.Format("Select nombre_clientes from Cliente where id_clientes='{0}'", txtCodigo.Text.Trim());
                    DataSet DS = Utilidades.Ejecutar(cmd);
                    txtBoxCliente.Text = DS.Tables[0].Rows[0]["nombre_clientes"].ToString().Trim();
                    txtCodPro.Focus();                    
                }
            }
            catch 
            {
                MessageBox.Show("Usuario no encontrado.");
            }
        }
        public static int contadorFila = 0;
        public static float auxCant, auxPrecio, total = 0;

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (contadorFila > 0)
            {
                float.TryParse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString(),out auxPrecio);
                total -= auxPrecio;
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                contadorFila--;
                lblTotal.Text = total.ToString("n2");

            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ConsultarClientes Consultar_Clientes = new ConsultarClientes();
            Consultar_Clientes.ShowDialog();
            if(Consultar_Clientes.DialogResult == DialogResult.OK)
            {
                txtCodigo.Text = Consultar_Clientes.dataGridView1.Rows[Consultar_Clientes.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                txtBoxCliente.Text = Consultar_Clientes.dataGridView1.Rows[Consultar_Clientes.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                txtCodPro.Focus();
            }
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            ConsultarProductos Consultar_Productos = new ConsultarProductos();
            Consultar_Productos.ShowDialog();
            if(Consultar_Productos.DialogResult==DialogResult.OK)
            {
                txtCodPro.Text = Consultar_Productos.dataGridView1.Rows[Consultar_Productos.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                txtDecripcion.Text = Consultar_Productos.dataGridView1.Rows[Consultar_Productos.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                txtPrecio.Text = Consultar_Productos.dataGridView1.Rows[Consultar_Productos.dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                txtCant.Focus();

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }
        public override void Nuevo()
        {
            txtCodigo.Text = "";
            txtBoxCliente.Text = "";
            txtCodPro.Text = "";
            txtDecripcion.Text = "";
            txtPrecio.Text = "";
            txtCant.Text = "";
            lblTotal.Text = "$ 0,00";
            dataGridView1.Rows.Clear();
            contadorFila = 0;
            total = 0;
            txtCodigo.Focus();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            if (contadorFila != 0)
            {
                try
                {
                    string cmd = string.Format("Exec ActualizarFacturas '{0}'", txtCodigo.Text.Trim());
                    DataSet DS = Utilidades.Ejecutar(cmd);
                    string numFac = DS.Tables[0].Rows[0]["NumFac"].ToString().Trim();
                    foreach(DataGridViewRow Fila  in dataGridView1.Rows)
                    {                             
                        cmd = string.Format("Exec ActualizarDetalles '{0}','{1}','{2}','{3}'", numFac,Fila.Cells[0].Value.ToString(),Fila.Cells[2].Value.ToString().Replace(',', '.'), Fila.Cells[3].Value.ToString());
                        DS = Utilidades.Ejecutar(cmd);
                    }
                    cmd = "Exec DatosFactura " + numFac;
                    DS = Utilidades.Ejecutar(cmd);
                    //Ventana reporte
                    Reporte Rep = new Reporte();
                    Rep.reportViewer1.LocalReport.DataSources[0].Value = DS.Tables[0];
                    Rep.ShowDialog();

                    Nuevo();
                }
                catch(Exception error)
                {
                    MessageBox.Show("Error: " + error.Message);
                }
                Nuevo();
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCodigo.Text.Trim()) == false)
                {

                    string cmd = "Select * from Articulo where id_producto="+ txtCodPro.Text.Trim();
                    DataSet DS = Utilidades.Ejecutar(cmd);
                    txtDecripcion.Text = DS.Tables[0].Rows[0]["nom_producto"].ToString().Trim();
                    txtPrecio.Text = DS.Tables[0].Rows[0]["precio"].ToString().Trim();
                    txtPrecio.Focus();
                }
            }
            catch 
            {
                MessageBox.Show("Producto no encontrado.");
                txtCodPro.Clear();
            }
        }

        private void btnColocar_Click(object sender, EventArgs e)
        {
            if (Utilidades.ValidarFormulario(this, errorProvider1) == false)
            {
                bool existe = false;
                int num_fila = 0;
                float importe;
                
                if (contadorFila == 0)
                {
                    float.TryParse(txtPrecio.Text, out auxPrecio);
                    txtPrecio.Text = auxPrecio.ToString("n2");//
                    dataGridView1.Rows.Add(txtCodPro.Text, txtDecripcion.Text, txtPrecio.Text, txtCant.Text);
                    float.TryParse(dataGridView1.Rows[contadorFila].Cells[2].Value.ToString(), out auxPrecio);
                    float.TryParse(dataGridView1.Rows[contadorFila].Cells[3].Value.ToString(), out auxCant );
                    importe = auxCant * auxPrecio;
                    dataGridView1.Rows[contadorFila].Cells[4].Value = importe.ToString("n2");//
                    contadorFila++;
                }
                else
                {
                    foreach(DataGridViewRow fila in dataGridView1.Rows)
                    {
                        if (fila.Cells[0].Value.ToString()== txtCodPro.Text)
                        {
                            existe = true;
                            num_fila = fila.Index;
                            break;
                        }
                    }
                    if (existe)
                    {
                        float.TryParse(txtCant.Text, out auxCant);
                        dataGridView1.Rows[num_fila].Cells[3].Value = (Convert.ToDouble(dataGridView1.Rows[num_fila].Cells[3].Value) + auxCant).ToString();
                        float.TryParse(dataGridView1.Rows[num_fila].Cells[2].Value.ToString(), out auxPrecio);
                        float.TryParse(dataGridView1.Rows[num_fila].Cells[3].Value.ToString(), out auxCant);
                        txtPrecio.Text = auxPrecio.ToString("n2"); //
                        importe = auxCant * auxPrecio;
                        dataGridView1.Rows[num_fila].Cells[4].Value = importe.ToString("n2"); //

                    }
                    else
                    {
                        dataGridView1.Rows.Add(txtCodPro.Text, txtDecripcion.Text, txtPrecio.Text, txtCant.Text);
                        float.TryParse(dataGridView1.Rows[contadorFila].Cells[2].Value.ToString(), out auxPrecio);
                        float.TryParse(dataGridView1.Rows[contadorFila].Cells[3].Value.ToString(), out auxCant);
                        txtPrecio.Text = auxPrecio.ToString("n2");//
                        importe = auxCant * auxPrecio;
                        dataGridView1.Rows[contadorFila].Cells[4].Value = importe.ToString("n2");//
                        contadorFila++;
                    }
                }
            }
            total = 0;
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                float.TryParse(fila.Cells[4].Value.ToString(), out auxPrecio);
                total += auxPrecio;
            }
            lblTotal.Text = "$ "+total.ToString("n2");
            txtCodPro.Clear();
            txtCant.Clear();
            txtDecripcion.Text = "";
            txtPrecio.Text = "";
            txtBoxCliente.Clear();
            txtCodigo.Clear();
        }

        private void Facturacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            contadorFila = 0;
        }
    }

}
