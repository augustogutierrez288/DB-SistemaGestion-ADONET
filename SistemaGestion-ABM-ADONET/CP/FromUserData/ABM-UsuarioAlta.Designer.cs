namespace SistemaGestion_ABM_ADONET.CP.FromUserData
{
    partial class ABM_UsuarioAlta
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
            label1 = new Label();
            txtName = new TextBox();
            btnAddUser = new Button();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtSurname = new TextBox();
            txtUser = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 52);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(171, 46);
            txtName.Name = "txtName";
            txtName.Size = new Size(299, 31);
            txtName.TabIndex = 1;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(46, 357);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(148, 54);
            btnAddUser.TabIndex = 2;
            btnAddUser.Text = "Guardar";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(171, 279);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(299, 31);
            txtPassword.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(171, 218);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(299, 31);
            txtEmail.TabIndex = 4;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(171, 104);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(299, 31);
            txtSurname.TabIndex = 5;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(171, 162);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(299, 31);
            txtUser.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 110);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 7;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 168);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 8;
            label3.Text = "Usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 224);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 9;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 279);
            label5.Name = "label5";
            label5.Size = new Size(101, 25);
            label5.TabIndex = 10;
            label5.Text = "Contraseña";
            // 
            // ABM_UsuarioAlta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtUser);
            Controls.Add(txtSurname);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(btnAddUser);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "ABM_UsuarioAlta";
            Text = "Cargar usuario";
            Load += ABM_UsuarioAlta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Button btnAddUser;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private TextBox txtSurname;
        private TextBox txtUser;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}