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
    public partial class ABM_UsuarioModificar : Form
    {
        private Usuario _user;
        public ABM_UsuarioModificar()
        {
            InitializeComponent();
        }

        public ABM_UsuarioModificar(Usuario user)
        {
            InitializeComponent();
            this._user = user;
        }
        private void ABM_UsuarioModificar_Load(object sender, EventArgs e)
        {
            txtName.Text = this._user.Nombre;
            txtSurname.Text = this._user.Apellido;
            txtUser.Text = this._user.NombreUsuario;
            txtEmail.Text = this._user.Mail;
            txtPassword.Text = this._user.Contraseña;
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            this._user.Nombre = txtName.Text;
            this._user.Apellido = txtSurname.Text;
            this._user.NombreUsuario = txtUser.Text;
            this._user.Mail = txtEmail.Text;
            this._user.Contraseña = txtPassword.Text;

            Contexto.UpdateUser(this._user);
            MessageBox.Show("Usuario modificado correctamente");
        }
    }
}
