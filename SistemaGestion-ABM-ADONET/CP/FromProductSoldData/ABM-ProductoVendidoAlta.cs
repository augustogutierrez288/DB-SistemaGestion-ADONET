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

namespace SistemaGestion_ABM_ADONET.CP.FromProductSoldData
{
    public partial class ABM_ProductoVendidoAlta : Form
    {
        public ABM_ProductoVendidoAlta()
        {
            InitializeComponent();
        }

        private void btnAddProductSold_Click(object sender, EventArgs e)
        {
            ProductoVendido productSold = new ProductoVendido();
            productSold.Stock = Convert.ToInt32(txtStock.Text);
            productSold.IdProducto = Convert.ToInt32(txtIdProducto.Text);
            productSold.IdVenta = Convert.ToInt32(txtIdVenta.Text);


            Contexto.CreateProductSold(productSold);

            MessageBox.Show("Producto vendido cargado correctamente");
        }
    }
}
