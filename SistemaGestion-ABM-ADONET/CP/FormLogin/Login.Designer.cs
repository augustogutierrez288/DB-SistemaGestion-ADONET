namespace SistemaGestion_ABM_ADONET.CP
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogin = new Button();
            txtUserName = new TextBox();
            lblTitleLogin = new Label();
            lblUserName = new Label();
            lblPassword = new Label();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(118, 291);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 34);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Iniciar Sesion";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(312, 141);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(166, 31);
            txtUserName.TabIndex = 1;
            // 
            // lblTitleLogin
            // 
            lblTitleLogin.AutoSize = true;
            lblTitleLogin.Location = new Point(312, 65);
            lblTitleLogin.Name = "lblTitleLogin";
            lblTitleLogin.Size = new Size(140, 25);
            lblTitleLogin.TabIndex = 2;
            lblTitleLogin.Text = "INICIAR SESION";
            lblTitleLogin.Click += lblTitleLogin_Click;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(118, 141);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(166, 25);
            lblUserName.TabIndex = 3;
            lblUserName.Text = "Nombre de usuario";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(118, 210);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(101, 25);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Contraseña";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(312, 210);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(166, 31);
            txtPassword.TabIndex = 5;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblUserName);
            Controls.Add(lblTitleLogin);
            Controls.Add(txtUserName);
            Controls.Add(btnLogin);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtUserName;
        private Label lblTitleLogin;
        private Label lblUserName;
        private Label lblPassword;
        private TextBox txtPassword;
    }
}