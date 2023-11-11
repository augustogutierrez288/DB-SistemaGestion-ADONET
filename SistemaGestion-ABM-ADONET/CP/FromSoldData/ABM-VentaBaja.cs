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

namespace SistemaGestion_ABM_ADONET.CP.FromSoldData
{
    public partial class ABM_VentaBaja : Form
    {
        private Venta _sold;
        public ABM_VentaBaja()
        {
            InitializeComponent();
        }

        public ABM_VentaBaja(Venta sold)
        {
            InitializeComponent();
            this._sold = sold;
        }
        private void ABM_VentaBaja_Load(object sender, EventArgs e)
        {
            txtCommit.Text = this._sold.Comentarios;
            txtIDUser.Text = this._sold.IdUsuario.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contexto.DeleteSold(this._sold);

            MessageBox.Show("Producto eliminado correctamente");
        }
    }
}
