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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lblTitleLogin_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string valueUser = txtUserName.Text;
            string valuePassword = txtPassword.Text;

            if (valueUser == "admin" &&  valuePassword == "1234") { 
                Home frmHome = new Home();
                frmHome.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuario incorrecto");
            }
        }
    }
}
