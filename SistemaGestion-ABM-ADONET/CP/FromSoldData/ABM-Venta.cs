using SistemaGestion_ABM_ADONET.CL;
using SistemaGestion_ABM_ADONET.CP.FromProductSoldData;
using SistemaGestion_ABM_ADONET.CP.FromSoldData;
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
    public partial class ABM_Venta : Form
    {
        public ABM_Venta()
        {
            InitializeComponent();
        }

        private void LoadSold()
        {
            List<Venta> listSold = Contexto.LoadSold();
            dtgvSale.AutoGenerateColumns = false;
            dtgvSale.DataSource = listSold;
        }
        private void ABM_Venta_Load(object sender, EventArgs e)
        {
            this.LoadSold();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Home frmHome = new Home();
            frmHome.Show();
            this.Close();
        }

        private void btnNewSale_Click(object sender, EventArgs e)
        {
            ABM_VentaAlta frmSoldHight = new ABM_VentaAlta();
            frmSoldHight.FormClosed += FrmSoldHight_FormClosed;
            frmSoldHight.ShowDialog();
        }

        private void FrmSoldHight_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.LoadSold();
        }

        private void dtgvSale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;

            int Id = (int)this.dtgvSale.Rows[e.RowIndex].Cells["Id"].Value;

            Venta sold = Contexto.LoadSold().Where(x => x.Id == Id).FirstOrDefault();

            if (this.dtgvSale.Columns[e.ColumnIndex].Name == "Update")
            {
                ABM_VentaModificar frmUpdateSold = new ABM_VentaModificar(sold);
                frmUpdateSold.FormClosed += FrmSoldHight_FormClosed;
                frmUpdateSold.ShowDialog();
            }
            else if (this.dtgvSale.Columns[e.ColumnIndex].Name == "Delete")
            {
                ABM_VentaBaja frmDeleteSold = new ABM_VentaBaja(sold);
                frmDeleteSold.FormClosed += FrmSoldHight_FormClosed;
                frmDeleteSold.ShowDialog();
            }
        }
    }
}
