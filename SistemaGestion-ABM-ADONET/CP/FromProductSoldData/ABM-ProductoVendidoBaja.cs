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
    public partial class ABM_ProductoVendidoBaja : Form
    {
        private ProductoVendido _productSold;
        public ABM_ProductoVendidoBaja()
        {
            InitializeComponent();
        }

        public ABM_ProductoVendidoBaja(ProductoVendido productSold)
        {
            InitializeComponent();
            this._productSold = productSold;
        }

        private void ABM_ProductoVendidoBaja_Load(object sender, EventArgs e)
        {
            this.txtStock.Text = this._productSold.Stock.ToString();
            this.txtIdProducto.Text = this._productSold.IdProducto.ToString();
            this.txtIdVenta.Text = this._productSold.IdVenta.ToString();
        }

        private void btnDeleteProductSold_Click(object sender, EventArgs e)
        {
            Contexto.DeleteProductSold(this._productSold);
            MessageBox.Show("Producto vendido eliminado correctamente");
        }
    }
}
