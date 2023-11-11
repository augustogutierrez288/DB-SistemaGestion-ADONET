namespace SistemaGestion_ABM_ADONET.CP.FromUserData
{
    partial class ABM_UsuarioBaja
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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtUser = new TextBox();
            txtSurname = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnDeleteUser = new Button();
            txtName = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 251);
            label5.Name = "label5";
            label5.Size = new Size(101, 25);
            label5.TabIndex = 21;
            label5.Text = "Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 196);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 20;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 140);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 19;
            label3.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 82);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 18;
            label2.Text = "Apellido";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(154, 134);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(299, 31);
            txtUser.TabIndex = 17;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(154, 76);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(299, 31);
            txtSurname.TabIndex = 16;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(154, 190);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(299, 31);
            txtEmail.TabIndex = 15;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(154, 251);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(299, 31);
            txtPassword.TabIndex = 14;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(29, 329);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(148, 54);
            btnDeleteUser.TabIndex = 13;
            btnDeleteUser.Text = "Guardar";
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnUpdateUser_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(154, 18);
            txtName.Name = "txtName";
            txtName.Size = new Size(299, 31);
            txtName.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 24);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 11;
            label1.Text = "Nombre";
            // 
            // ABM_UsuarioBaja
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
            Controls.Add(btnDeleteUser);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "ABM_UsuarioBaja";
            Text = "Baja de usuario";
            Load += ABM_UsuarioBaja_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtUser;
        private TextBox txtSurname;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnDeleteUser;
        private TextBox txtName;
        private Label label1;
    }
}