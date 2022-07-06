using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesProducto;

namespace WindFormsProductos2
{
    public partial class FormProductos : Form
    {
        Producto Nuevoproducto;
        Producto ProdExistente;
        bool nuevo = true;
        int fila;

        public FormProductos()
        {
            InitializeComponent();
        }

        private void BtAceptar_Click(object sender, EventArgs e)
        {
            if(nuevo == true)
            {
                if(rdIngreso.Checked == true)
                {
                    Nuevoproducto.Ingreso(int.Parse(txtCantidad.Text));
                }
                if(rdEgreso.Checked == true)
                {
                    Nuevoproducto.Salida(int.Parse(txtCantidad.Text));
                }
                LlevarProdAldgv(Nuevoproducto, fila);

            }
            else
            {
                if(rdIngreso.Checked == true)
                {
                    ProdExistente.Ingreso(int.Parse(txtCantidad.Text)); 
                }

                if (rdEgreso.Checked == true)
                {
                    ProdExistente.Salida(int.Parse(txtCantidad.Text));
                }
                LlevarProdAldgv(Nuevoproducto, fila);
            }

        }

        private void btCargar_Click(object sender, EventArgs e)
        {
            

            Nuevoproducto = new Producto(int.Parse(txtCodigo.Text), txtDesc.Text);
            lblCodigo.Text = "Codigo: "+Nuevoproducto.p_codigo.ToString(); 
            lblDesc.Text="Descripsion: "+Nuevoproducto.P_descripcion;
            lblStock.Text = "Stock: "+Nuevoproducto.p_stock.ToString();


            tabC_Productos.SelectedTab = tabP_Movimiento;
            txtCantidad.Clear(); 
            txtCantidad.Focus(); 

            LlevarProdAldgv(Nuevoproducto);

        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            dgvProductos.Columns.Add("0", "Codigo");
            dgvProductos.Columns.Add("1", "Descripcion");
            dgvProductos.Columns.Add("2", "Stock");

            dgvProductos.Columns[0].Width = 100; 
            dgvProductos.Columns[1].Width = 300;
            dgvProductos.Columns[2].Width = 60; 


        }

        void LlevarProdAldgv(Producto Prod)
        {
            dgvProductos.Rows.Add(Prod.p_codigo.ToString(),Prod.P_descripcion,Prod.p_stock.ToString());
            fila = (dgvProductos.Rows.Count - 1); 
        }
        void LlevarProdAldgv(Producto Prod, int lugar)
        {
            dgvProductos[0, lugar].Value= Prod.p_codigo.ToString();
            dgvProductos[1, lugar].Value = Prod.P_descripcion;
            dgvProductos[2, lugar].Value = Prod.p_stock.ToString();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdExistente= new Producto(System.Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value),
                dgvProductos.CurrentRow.Cells[0].Value.ToString(), 
                System.Convert.ToInt32(dgvProductos.CurrentRow.Cells[2].Value));

            lblCodigo.Text = ProdExistente.p_codigo.ToString();
            lblDesc.Text = ProdExistente.P_descripcion;
            lblStock.Text= "Hay "+ ProdExistente.p_stock.ToString()+ " unidades";

            txtCantidad.Clear();
            fila = e.RowIndex;

            nuevo=false;
        }
    }
}
