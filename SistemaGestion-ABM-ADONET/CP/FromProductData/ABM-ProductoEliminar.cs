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
    public partial class ABM_ProductoEliminar : Form
    {
        private Producto _product;
        public ABM_ProductoEliminar()
        {
            InitializeComponent();
        }
        public ABM_ProductoEliminar(Producto product)
        {
            InitializeComponent();
            this._product = product;
        }
        private void ABM_ProductoEliminar_Load(object sender, EventArgs e)
        {
            this.txtDes.Text = this._product.Descripciones;
            this.txtCos.Text = this._product.Costo.ToString();
            this.txtPreV.Text = this._product.PrecioVenta.ToString();
            this.txtStock.Text = this._product.Stock.ToString();
            this.txtIdUs.Text = this._product.IdUsuario.ToString();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            Contexto.DeleteProduct(this._product);
            MessageBox.Show("Producto eliminado correctamente");
        }
    }
}
