namespace SistemaGestion_ABM_ADONET.CP
{
    partial class ABM_Producto
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
            dtgvProducts = new DataGridView();
            btnBack = new Button();
            btnNewProduct = new Button();
            Id = new DataGridViewTextBoxColumn();
            Descripciones = new DataGridViewTextBoxColumn();
            Costo = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            IdUsuario = new DataGridViewTextBoxColumn();
            Modificar = new DataGridViewButtonColumn();
            Eliminar = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dtgvProducts).BeginInit();
            SuspendLayout();
            // 
            // dtgvProducts
            // 
            dtgvProducts.AllowUserToAddRows = false;
            dtgvProducts.AllowUserToDeleteRows = false;
            dtgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvProducts.Columns.AddRange(new DataGridViewColumn[] { Id, Descripciones, Costo, PrecioVenta, Stock, IdUsuario, Modificar, Eliminar });
            dtgvProducts.Location = new Point(12, 75);
            dtgvProducts.Name = "dtgvProducts";
            dtgvProducts.ReadOnly = true;
            dtgvProducts.RowHeadersWidth = 62;
            dtgvProducts.RowTemplate.Height = 33;
            dtgvProducts.Size = new Size(1264, 409);
            dtgvProducts.TabIndex = 0;
            dtgvProducts.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(60, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(172, 44);
            btnBack.TabIndex = 1;
            btnBack.Text = "Volver";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnNewProduct
            // 
            btnNewProduct.Location = new Point(1104, 12);
            btnNewProduct.Name = "btnNewProduct";
            btnNewProduct.Size = new Size(172, 44);
            btnNewProduct.TabIndex = 2;
            btnNewProduct.Text = "Cargar producto";
            btnNewProduct.UseVisualStyleBackColor = true;
            btnNewProduct.Click += btnNewProduct_Click;
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
            // Descripciones
            // 
            Descripciones.DataPropertyName = "Descripciones";
            Descripciones.HeaderText = "Descripciones";
            Descripciones.MinimumWidth = 8;
            Descripciones.Name = "Descripciones";
            Descripciones.ReadOnly = true;
            Descripciones.Width = 150;
            // 
            // Costo
            // 
            Costo.DataPropertyName = "Costo";
            Costo.HeaderText = "Costo";
            Costo.MinimumWidth = 8;
            Costo.Name = "Costo";
            Costo.ReadOnly = true;
            Costo.Width = 150;
            // 
            // PrecioVenta
            // 
            PrecioVenta.DataPropertyName = "PrecioVenta";
            PrecioVenta.HeaderText = "Precio de venta";
            PrecioVenta.MinimumWidth = 8;
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.ReadOnly = true;
            PrecioVenta.Width = 150;
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
            // IdUsuario
            // 
            IdUsuario.DataPropertyName = "IdUsuario";
            IdUsuario.HeaderText = "ID Usuario";
            IdUsuario.MinimumWidth = 8;
            IdUsuario.Name = "IdUsuario";
            IdUsuario.ReadOnly = true;
            IdUsuario.Width = 150;
            // 
            // Modificar
            // 
            Modificar.HeaderText = "Modificar";
            Modificar.MinimumWidth = 8;
            Modificar.Name = "Modificar";
            Modificar.ReadOnly = true;
            Modificar.Text = "Modificar";
            Modificar.UseColumnTextForButtonValue = true;
            Modificar.Width = 150;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.MinimumWidth = 8;
            Eliminar.Name = "Eliminar";
            Eliminar.ReadOnly = true;
            Eliminar.Text = "Eliminar";
            Eliminar.UseColumnTextForButtonValue = true;
            Eliminar.Width = 150;
            // 
            // ABM_Producto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1374, 532);
            Controls.Add(btnNewProduct);
            Controls.Add(btnBack);
            Controls.Add(dtgvProducts);
            Name = "ABM_Producto";
            Text = "Gestor de productos";
            Load += ABM_Producto_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgvProducts;
        private Button btnBack;
        private Button btnNewProduct;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Descripciones;
        private DataGridViewTextBoxColumn Costo;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn IdUsuario;
        private DataGridViewButtonColumn Modificar;
        private DataGridViewButtonColumn Eliminar;
    }
}