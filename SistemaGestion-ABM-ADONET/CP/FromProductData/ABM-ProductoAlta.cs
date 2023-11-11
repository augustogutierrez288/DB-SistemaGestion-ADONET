using SistemaGestion_ABM_ADONET.CL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestion_ABM_ADONET.CP
{
    public partial class ABM_ProductoAlta : Form
    {
        public ABM_ProductoAlta()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.Descripciones = txtDes.Text;
            producto.Costo = Convert.ToDecimal(txtCos.Text);
            producto.PrecioVenta = Convert.ToDecimal(txtPreV.Text);
            producto.Stock = Convert.ToInt32(txtStock.Text);
            producto.IdUsuario = Convert.ToInt32(txtIdUs.Text);

            Contexto.CreateProduct(producto);

            MessageBox.Show("Producto cargado correctamente");
        }

        private void ABM_ProductoAlta_Load(object sender, EventArgs e)
        {

        }
    }
}
