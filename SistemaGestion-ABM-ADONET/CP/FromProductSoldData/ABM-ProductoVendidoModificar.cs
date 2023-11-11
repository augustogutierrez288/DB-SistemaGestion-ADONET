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
    public partial class ABM_ProductoVendidoModificacion : Form
    {
        private ProductoVendido _productSold;
        public ABM_ProductoVendidoModificacion()
        {
            InitializeComponent();
        }

        public ABM_ProductoVendidoModificacion(ProductoVendido productSold)
        {
            InitializeComponent();
            this._productSold = productSold;
        }
        private void btnUpdateProductSold_Click(object sender, EventArgs e)
        {
            this._productSold.Stock = Convert.ToInt32(txtStock.Text);
            this._productSold.IdProducto = Convert.ToInt32(txtIdProducto.Text);
            this._productSold.IdVenta = Convert.ToInt32(txtIdVenta.Text);

            Contexto.UpdateProductSold(this._productSold);
            MessageBox.Show("Producto modificado correctamente");
        }

        private void ABM_ProductoVendidoModificacion_Load(object sender, EventArgs e)
        {
            this.txtStock.Text = this._productSold.Stock.ToString();
            this.txtIdProducto.Text = this._productSold.IdProducto.ToString();
            this.txtIdVenta.Text = this._productSold.IdVenta.ToString();
        }
    }
}
