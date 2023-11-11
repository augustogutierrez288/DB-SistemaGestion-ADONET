using SistemaGestion_ABM_ADONET.CL;
using SistemaGestion_ABM_ADONET.CP.FromSoldData;
using SistemaGestion_ABM_ADONET.CP.FromUserData;
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
    public partial class ABM_Usuario : Form
    {
        public ABM_Usuario()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Home frmHome = new Home();
            frmHome.Show();
            this.Close();
        }

        private void LoadUser()
        {
            List<Usuario> listUser = Contexto.LoadUser();
            dtgvUser.AutoGenerateColumns = false;
            dtgvUser.DataSource = listUser;
        }
        private void ABM_Usuario_Load(object sender, EventArgs e)
        {
            this.LoadUser();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            ABM_UsuarioAlta frmUserHight = new ABM_UsuarioAlta();
            frmUserHight.FormClosed += FrmUserHight_FormClosed;
            frmUserHight.ShowDialog();
        }

        private void FrmUserHight_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.LoadUser();
        }

        private void dtgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;

            int Id = (int)this.dtgvUser.Rows[e.RowIndex].Cells["Id"].Value;

            Usuario user = Contexto.LoadUser().Where(x => x.Id == Id).FirstOrDefault();

            if (this.dtgvUser.Columns[e.ColumnIndex].Name == "Update")
            {
                ABM_UsuarioModificar frmUpdateSold = new ABM_UsuarioModificar(user);
                frmUpdateSold.FormClosed += FrmUserHight_FormClosed;
                frmUpdateSold.ShowDialog();
            }
            else if (this.dtgvUser.Columns[e.ColumnIndex].Name == "Delete")
            {
                ABM_UsuarioBaja frmDeleteSold = new ABM_UsuarioBaja(user);
                frmDeleteSold.FormClosed += FrmUserHight_FormClosed;
                frmDeleteSold.ShowDialog();
            }
        }
    }
}
