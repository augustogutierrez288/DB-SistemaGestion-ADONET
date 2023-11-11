namespace SistemaGestion_ABM_ADONET.CP
{
    partial class ABM_Usuario
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
            btnNewUser = new Button();
            btnBack = new Button();
            dtgvUser = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            NombreUsuario = new DataGridViewTextBoxColumn();
            Contraseña = new DataGridViewTextBoxColumn();
            Mail = new DataGridViewTextBoxColumn();
            Update = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dtgvUser).BeginInit();
            SuspendLayout();
            // 
            // btnNewUser
            // 
            btnNewUser.Location = new Point(1067, 13);
            btnNewUser.Name = "btnNewUser";
            btnNewUser.Size = new Size(172, 44);
            btnNewUser.TabIndex = 5;
            btnNewUser.Text = "Cargar Usuario";
            btnNewUser.UseVisualStyleBackColor = true;
            btnNewUser.Click += btnNewUser_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(61, 13);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(172, 44);
            btnBack.TabIndex = 4;
            btnBack.Text = "Volver";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dtgvUser
            // 
            dtgvUser.AllowUserToAddRows = false;
            dtgvUser.AllowUserToDeleteRows = false;
            dtgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvUser.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Apellido, NombreUsuario, Contraseña, Mail, Update, Delete });
            dtgvUser.Location = new Point(13, 76);
            dtgvUser.Name = "dtgvUser";
            dtgvUser.ReadOnly = true;
            dtgvUser.RowHeadersWidth = 62;
            dtgvUser.RowTemplate.Height = 33;
            dtgvUser.Size = new Size(1261, 427);
            dtgvUser.TabIndex = 3;
            dtgvUser.CellContentClick += dtgvUser_CellContentClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "ID";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 150;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 150;
            // 
            // Apellido
            // 
            Apellido.DataPropertyName = "Apellido";
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 8;
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            Apellido.Width = 150;
            // 
            // NombreUsuario
            // 
            NombreUsuario.DataPropertyName = "NombreUsuario";
            NombreUsuario.HeaderText = "Nombre de usuario";
            NombreUsuario.MinimumWidth = 8;
            NombreUsuario.Name = "NombreUsuario";
            NombreUsuario.ReadOnly = true;
            NombreUsuario.Width = 150;
            // 
            // Contraseña
            // 
            Contraseña.DataPropertyName = "Contraseña";
            Contraseña.HeaderText = "Contraseña";
            Contraseña.MinimumWidth = 8;
            Contraseña.Name = "Contraseña";
            Contraseña.ReadOnly = true;
            Contraseña.Width = 150;
            // 
            // Mail
            // 
            Mail.DataPropertyName = "Mail";
            Mail.HeaderText = "Email";
            Mail.MinimumWidth = 8;
            Mail.Name = "Mail";
            Mail.ReadOnly = true;
            Mail.Width = 150;
            // 
            // Update
            // 
            Update.HeaderText = "Modificar";
            Update.MinimumWidth = 8;
            Update.Name = "Update";
            Update.ReadOnly = true;
            Update.Text = "Modificar";
            Update.UseColumnTextForButtonValue = true;
            Update.Width = 150;
            // 
            // Delete
            // 
            Delete.HeaderText = "Eliminar";
            Delete.MinimumWidth = 8;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Text = "Eliminar";
            Delete.UseColumnTextForButtonValue = true;
            Delete.Width = 150;
            // 
            // ABM_Usuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1286, 516);
            Controls.Add(btnNewUser);
            Controls.Add(btnBack);
            Controls.Add(dtgvUser);
            Name = "ABM_Usuario";
            Text = "Gestor de usuarios";
            Load += ABM_Usuario_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNewUser;
        private Button btnBack;
        private DataGridView dtgvUser;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn NombreUsuario;
        private DataGridViewTextBoxColumn Contraseña;
        private DataGridViewTextBoxColumn Mail;
        private DataGridViewButtonColumn Update;
        private DataGridViewButtonColumn Delete;
    }
}