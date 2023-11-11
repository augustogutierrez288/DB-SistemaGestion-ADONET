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
    public partial class ABM_VentaAlta : Form
    {
        public ABM_VentaAlta()
        {
            InitializeComponent();
        }

        private void ABM_VentaAlta_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Venta sold = new Venta();
            sold.Comentarios = txtCommit.Text;
            sold.IdUsuario = Convert.ToInt32(txtIDUser.Text);

            Contexto.CreateSold(sold);

            MessageBox.Show("Venta cargada correctamente");
        }
    }
}
