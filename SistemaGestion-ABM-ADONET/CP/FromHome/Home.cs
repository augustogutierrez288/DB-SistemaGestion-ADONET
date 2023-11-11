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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ABM_Producto frmProducts = new ABM_Producto();
            frmProducts.Show();
            this.Close();
        }

        private void btnSignoff_Click(object sender, EventArgs e)
        {
            Login frmLogin = new Login();
            frmLogin.Show();
            this.Close();
        }

        private void btnProductSold_Click(object sender, EventArgs e)
        {
            ABM_ProductosVendidos frmProductSold = new ABM_ProductosVendidos();
            frmProductSold.Show();
            this.Close();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            ABM_Usuario frmUser = new ABM_Usuario();
            frmUser.Show();
            this.Close();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            ABM_Venta frmSale = new ABM_Venta();
            frmSale.Show();
            this.Close();
        }
    }
}
