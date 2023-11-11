namespace SistemaGestion_ABM_ADONET.CP
{
    partial class ABM_Venta
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
            btnNewSale = new Button();
            btnBack = new Button();
            dtgvSale = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Comentarios = new DataGridViewTextBoxColumn();
            IdUsuario = new DataGridViewTextBoxColumn();
            Update = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dtgvSale).BeginInit();
            SuspendLayout();
            // 
            // btnNewSale
            // 
            btnNewSale.Location = new Point(664, 12);
            btnNewSale.Name = "btnNewSale";
            btnNewSale.Size = new Size(172, 44);
            btnNewSale.TabIndex = 5;
            btnNewSale.Text = "Cargar Venta";
            btnNewSale.UseVisualStyleBackColor = true;
            btnNewSale.Click += btnNewSale_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(29, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(172, 44);
            btnBack.TabIndex = 4;
            btnBack.Text = "Volver";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dtgvSale
            // 
            dtgvSale.AllowUserToAddRows = false;
            dtgvSale.AllowUserToDeleteRows = false;
            dtgvSale.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvSale.Columns.AddRange(new DataGridViewColumn[] { Id, Comentarios, IdUsuario, Update, Delete });
            dtgvSale.Location = new Point(29, 76);
            dtgvSale.Name = "dtgvSale";
            dtgvSale.ReadOnly = true;
            dtgvSale.RowHeadersWidth = 62;
            dtgvSale.RowTemplate.Height = 33;
            dtgvSale.Size = new Size(807, 427);
            dtgvSale.TabIndex = 3;
            dtgvSale.CellContentClick += dtgvSale_CellContentClick;
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
            // Comentarios
            // 
            Comentarios.DataPropertyName = "Comentarios";
            Comentarios.HeaderText = "Comentarios";
            Comentarios.MinimumWidth = 8;
            Comentarios.Name = "Comentarios";
            Comentarios.ReadOnly = true;
            Comentarios.Width = 150;
            // 
            // IdUsuario
            // 
            IdUsuario.DataPropertyName = "IdUsuario";
            IdUsuario.HeaderText = "ID Usuario";
            IdUsuario.MinimumWidth = 8;
            IdUsuario.Name = "IdUsuario";
            IdUsuario.ReadOnly = true;
            IdUsuario.Width = 150;
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
            // ABM_Venta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 515);
            Controls.Add(btnNewSale);
            Controls.Add(btnBack);
            Controls.Add(dtgvSale);
            Name = "ABM_Venta";
            Text = "Gestor de ventas";
            Load += ABM_Venta_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvSale).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNewSale;
        private Button btnBack;
        private DataGridView dtgvSale;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Comentarios;
        private DataGridViewTextBoxColumn IdUsuario;
        private DataGridViewButtonColumn Update;
        private DataGridViewButtonColumn Delete;
    }
}