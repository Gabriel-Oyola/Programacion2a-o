using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;



namespace WindowsFomsProducto1
{
    public partial class FormsProductos : Form
    {
        Producto producto;
        public ListaProducto lista { get; set; } = new ListaProducto();
        public FormsProductos()
        {
            InitializeComponent(); 
            dgvProductos.DataSource = lista.ListaProductos;
        }

        private void btCargar_Click(object sender, EventArgs e)
        {
           

            producto = new Producto(txtDesc.Text, int.Parse(txtStock.Text));



            lista.NuevoProducto(producto);

            


        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            producto = lista.BuscarProducto(int.Parse(txtBuscar.Text));

            if (producto.pcodigo > 0)
            {
                lbCodMov.Text= "Codigo "+ producto.pcodigo.ToString();
                lbDescMov.Text = "Descripcion: "+ producto.PDescripcion;
                lblStockActual.Text="Stock: "+producto.PStock.ToString();
            }
            else
            {
                MessageBox.Show("El producto no existe");
            }
        }

        private void btCargaM_Click(object sender, EventArgs e)
        {
            if (rbEgreso.Checked == true)
            {
                producto.Salida(int.Parse(txtCant.Text));
                lista.NuevoProducto(producto);
            }

            if (rbIngreso.Checked == true)
            {
                producto.Ingreso(int.Parse(txtCant.Text));
                lista.NuevoProducto(producto);
            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (lista.DeleteProducto(producto))
            {
                Limpiar();
            }
            else
            {
                MessageBox.Show("El producto codigo " + producto.pcodigo + " no se pudo borrar");
                Limpiar();
            }
        }

        private void Limpiar()
        {
            lbCodMov.Text = "Codigo: ";
            lbDescMov.Text = "Descripcion: ";
            lblStockActual.Text = "Stock: "; 
        }
    }
}
