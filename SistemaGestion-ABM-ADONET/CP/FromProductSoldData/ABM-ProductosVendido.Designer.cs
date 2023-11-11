namespace SistemaGestion_ABM_ADONET.CP
{
    partial class ABM_ProductosVendidos
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
            btnNewProductSold = new Button();
            btnBack = new Button();
            dtgvProductSold = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            IdProducto = new DataGridViewTextBoxColumn();
            IdVenta = new DataGridViewTextBoxColumn();
            Update = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dtgvProductSold).BeginInit();
            SuspendLayout();
            // 
            // btnNewProductSold
            // 
            btnNewProductSold.Location = new Point(823, 21);
            btnNewProductSold.Name = "btnNewProductSold";
            btnNewProductSold.Size = new Size(172, 44);
            btnNewProductSold.TabIndex = 5;
            btnNewProductSold.Text = "Cargar Producto V.";
            btnNewProductSold.UseVisualStyleBackColor = true;
            btnNewProductSold.Click += btnNewProductSold_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(32, 21);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(172, 44);
            btnBack.TabIndex = 4;
            btnBack.Text = "Volver";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dtgvProductSold
            // 
            dtgvProductSold.AllowUserToAddRows = false;
            dtgvProductSold.AllowUserToDeleteRows = false;
            dtgvProductSold.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvProductSold.Columns.AddRange(new DataGridViewColumn[] { Id, Stock, IdProducto, IdVenta, Update, Delete });
            dtgvProductSold.Location = new Point(32, 91);
            dtgvProductSold.Name = "dtgvProductSold";
            dtgvProductSold.ReadOnly = true;
            dtgvProductSold.RowHeadersWidth = 62;
            dtgvProductSold.RowTemplate.Height = 33;
            dtgvProductSold.Size = new Size(963, 339);
            dtgvProductSold.TabIndex = 3;
            dtgvProductSold.CellContentClick += dtgvProductSold_CellContentClick;
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
            // Stock
            // 
            Stock.DataPropertyName = "Stock";
            Stock.HeaderText = "Stock";
            Stock.MinimumWidth = 8;
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            Stock.Width = 150;
            // 
            // IdProducto
            // 
            IdProducto.DataPropertyName = "IdProducto";
            IdProducto.HeaderText = "ID Producto";
            IdProducto.MinimumWidth = 8;
            IdProducto.Name = "IdProducto";
            IdProducto.ReadOnly = true;
            IdProducto.Width = 150;
            // 
            // IdVenta
            // 
            IdVenta.DataPropertyName = "IdVenta";
            IdVenta.HeaderText = "ID Venta";
            IdVenta.MinimumWidth = 8;
            IdVenta.Name = "IdVenta";
            IdVenta.ReadOnly = true;
            IdVenta.Width = 150;
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
            // ABM_ProductosVendidos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1027, 476);
            Controls.Add(btnNewProductSold);
            Controls.Add(btnBack);
            Controls.Add(dtgvProductSold);
            Name = "ABM_ProductosVendidos";
            Text = "Gestor de productos vendidos";
            Load += ABM_ProductosVendidos_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvProductSold).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNewProductSold;
        private Button btnBack;
        private DataGridView dtgvProductSold;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn IdVenta;
        private DataGridViewButtonColumn Update;
        private DataGridViewButtonColumn Delete;
    }
}