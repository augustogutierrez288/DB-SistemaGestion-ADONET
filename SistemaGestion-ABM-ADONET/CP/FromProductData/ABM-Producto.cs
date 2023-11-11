using SistemaGestion_ABM_ADONET.CL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestion_ABM_ADONET.CP
{
    public partial class ABM_Producto : Form
    {
        public ABM_Producto()
        {
            InitializeComponent();
        }

        private void LoadProduct()
        {
            List<Producto> list = Contexto.LoadProduct();
            dtgvProducts.AutoGenerateColumns = false;
            dtgvProducts.DataSource = list;
        }

        private void ABM_Producto_Load(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;

            int Id = (int)this.dtgvProducts.Rows[e.RowIndex].Cells["Id"].Value;

            Producto product = Contexto.LoadProduct().Where(x => x.Id == Id).FirstOrDefault();

            if (this.dtgvProducts.Columns[e.ColumnIndex].Name == "Modificar")
            {

                ABM_ProductoModificar frmUpdateProduct = new ABM_ProductoModificar(product);
                frmUpdateProduct.FormClosed += FrmAltaProduct_FormClosed;
                frmUpdateProduct.ShowDialog();
            }
            else if (this.dtgvProducts.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                ABM_ProductoEliminar frmDeleteProduct = new ABM_ProductoEliminar(product);
                frmDeleteProduct.FormClosed += FrmAltaProduct_FormClosed;
                frmDeleteProduct.ShowDialog();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Home frmHome = new Home();
            frmHome.Show();
            this.Close();
        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            ABM_ProductoAlta frmAltaProduct = new ABM_ProductoAlta();
            frmAltaProduct.FormClosed += FrmAltaProduct_FormClosed;
            frmAltaProduct.ShowDialog();
        }

        private void FrmAltaProduct_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.LoadProduct();
        }
    }
}
