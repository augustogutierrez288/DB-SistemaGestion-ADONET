namespace SistemaGestion_ABM_ADONET.CP.FromProductSoldData
{
    partial class ABM_ProductoVendidoModificacion
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
            txtIdProducto = new TextBox();
            txtIdVenta = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtStock = new TextBox();
            label1 = new Label();
            btnUpdateProductSold = new Button();
            SuspendLayout();
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(201, 107);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(308, 31);
            txtIdProducto.TabIndex = 29;
            // 
            // txtIdVenta
            // 
            txtIdVenta.Location = new Point(201, 169);
            txtIdVenta.Name = "txtIdVenta";
            txtIdVenta.Size = new Size(308, 31);
            txtIdVenta.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 175);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 27;
            label3.Text = "ID Venta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 113);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 26;
            label2.Text = "ID Producto";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(201, 46);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(308, 31);
            txtStock.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 52);
            label1.Name = "label1";
            label1.Size = new Size(55, 25);
            label1.TabIndex = 24;
            label1.Text = "Stock";
            // 
            // btnUpdateProductSold
            // 
            btnUpdateProductSold.Location = new Point(39, 273);
            btnUpdateProductSold.Name = "btnUpdateProductSold";
            btnUpdateProductSold.Size = new Size(185, 64);
            btnUpdateProductSold.TabIndex = 23;
            btnUpdateProductSold.Text = "Guardar";
            btnUpdateProductSold.UseVisualStyleBackColor = true;
            btnUpdateProductSold.Click += btnUpdateProductSold_Click;
            // 
            // ABM_ProductoVendidoModificacion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(txtIdProducto);
            Controls.Add(txtIdVenta);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtStock);
            Controls.Add(label1);
            Controls.Add(btnUpdateProductSold);
            Name = "ABM_ProductoVendidoModificacion";
            Text = "Modificar producto vendido";
            Load += ABM_ProductoVendidoModificacion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdProducto;
        private TextBox txtIdVenta;
        private Label label3;
        private Label label2;
        private TextBox txtStock;
        private Label label1;
        private Button btnUpdateProductSold;
    }
}