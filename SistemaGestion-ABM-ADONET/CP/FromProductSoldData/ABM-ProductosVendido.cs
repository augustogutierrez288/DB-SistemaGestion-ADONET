using SistemaGestion_ABM_ADONET.CL;
using SistemaGestion_ABM_ADONET.CP.FromProductSoldData;
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
    public partial class ABM_ProductosVendidos : Form
    {
        public ABM_ProductosVendidos()
        {
            InitializeComponent();
        }

        private void LoadProductSold()
        {
            List<ProductoVendido> listProductSold = Contexto.LoadProductSold();
            dtgvProductSold.AutoGenerateColumns = false;
            dtgvProductSold.DataSource = listProductSold;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Home frmHome = new Home();
            frmHome.Show();
            this.Close();
        }

        private void ABM_ProductosVendidos_Load(object sender, EventArgs e)
        {
            this.LoadProductSold();
        }

        private void btnNewProductSold_Click(object sender, EventArgs e)
        {
            ABM_ProductoVendidoAlta frmProductSoldHigh = new ABM_ProductoVendidoAlta();
            frmProductSoldHigh.FormClosed += FrmProductSoldHigh_FormClosed;
            frmProductSoldHigh.ShowDialog();
        }

        private void FrmProductSoldHigh_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.LoadProductSold();
        }

        private void dtgvProductSold_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;

            int Id = (int)this.dtgvProductSold.Rows[e.RowIndex].Cells["Id"].Value;

            ProductoVendido productSold = Contexto.LoadProductSold().Where(x => x.Id == Id).FirstOrDefault();

            if (this.dtgvProductSold.Columns[e.ColumnIndex].Name == "Update")
            {

                ABM_ProductoVendidoModificacion frmUpdateProductSold = new ABM_ProductoVendidoModificacion(productSold);
                frmUpdateProductSold.FormClosed += FrmProductSoldHigh_FormClosed;
                frmUpdateProductSold.ShowDialog();
            }
            else if (this.dtgvProductSold.Columns[e.ColumnIndex].Name == "Delete")
            {
                ABM_ProductoVendidoBaja frmDeleteProductSold = new ABM_ProductoVendidoBaja(productSold);
                frmDeleteProductSold.FormClosed += FrmProductSoldHigh_FormClosed;
                frmDeleteProductSold.ShowDialog();
            }
        }
    }
}
