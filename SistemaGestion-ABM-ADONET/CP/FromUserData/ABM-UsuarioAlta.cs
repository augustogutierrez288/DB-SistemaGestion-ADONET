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

namespace SistemaGestion_ABM_ADONET.CP.FromUserData
{
    public partial class ABM_UsuarioAlta : Form
    {
        public ABM_UsuarioAlta()
        {
            InitializeComponent();
        }

        private void ABM_UsuarioAlta_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.Nombre = txtName.Text;
            user.Apellido = txtSurname.Text;
            user.NombreUsuario = txtUser.Text;
            user.Mail = txtEmail.Text;
            user.Contraseña = txtPassword.Text; 

            Contexto.CreateUser(user);
            MessageBox.Show("Usuario creado con exito");
        }
    }
}
