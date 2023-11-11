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
    public partial class ABM_ProductoModificar : Form
    {
        private Producto _product;
        public ABM_ProductoModificar()
        {
            InitializeComponent();
        }

        public ABM_ProductoModificar(Producto product)
        {
            InitializeComponent();
            this._product = product;

        }
        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            this._product.Descripciones = txtDes.Text;
            this._product.Costo = Convert.ToDecimal(txtCos.Text);
            this._product.PrecioVenta = Convert.ToDecimal(txtPreV.Text);
            this._product.Stock = Convert.ToInt32(txtStock.Text);
            this._product.IdUsuario = Convert.ToInt32(txtIdUs.Text);

            Contexto.UpdateProduct(this._product);
            MessageBox.Show("Producto modificado correctamente");
        }

        private void ABM_ProductoModificar_Load(object sender, EventArgs e)
        {
            this.txtDes.Text = this._product.Descripciones;
            this.txtCos.Text = this._product.Costo.ToString();
            this.txtPreV.Text = this._product.PrecioVenta.ToString();
            this.txtStock.Text = this._product.Stock.ToString();
            this.txtIdUs.Text = this._product.IdUsuario.ToString();
        }
    }
}
