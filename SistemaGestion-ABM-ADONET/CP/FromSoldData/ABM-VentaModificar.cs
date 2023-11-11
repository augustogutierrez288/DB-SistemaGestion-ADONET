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
    public partial class ABM_VentaModificar : Form
    {
        private Venta _sold;
        public ABM_VentaModificar()
        {
            InitializeComponent();
        }

        public ABM_VentaModificar(Venta sold)
        {
            InitializeComponent();
            this._sold = sold;
        }

        private void ABM_VentaModificar_Load(object sender, EventArgs e)
        {
            txtCommit.Text = this._sold.Comentarios;
            txtIDUser.Text = this._sold.IdUsuario.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this._sold.Comentarios = txtCommit.Text;
            this._sold.IdUsuario = Convert.ToInt32(txtIDUser.Text);

            Contexto.UpdateSold(this._sold);

            MessageBox.Show("Venta modificada correctamente");
        }
    }
}
