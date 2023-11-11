namespace SistemaGestion_ABM_ADONET.CP
{
    partial class ABM_ProductoAlta
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
            btnAddProduct = new Button();
            label1 = new Label();
            txtDes = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtPreV = new TextBox();
            txtIdUs = new TextBox();
            txtStock = new TextBox();
            txtCos = new TextBox();
            SuspendLayout();
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(33, 338);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(185, 64);
            btnAddProduct.TabIndex = 0;
            btnAddProduct.Text = "Guardar";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 43);
            label1.Name = "label1";
            label1.Size = new Size(121, 25);
            label1.TabIndex = 1;
            label1.Text = "Descripciones";
            // 
            // txtDes
            // 
            txtDes.Location = new Point(195, 37);
            txtDes.Name = "txtDes";
            txtDes.Size = new Size(210, 31);
            txtDes.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 104);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 3;
            label2.Text = "Costo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 166);
            label3.Name = "label3";
            label3.Size = new Size(134, 25);
            label3.TabIndex = 4;
            label3.Text = "Precio de Venta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 213);
            label4.Name = "label4";
            label4.Size = new Size(55, 25);
            label4.TabIndex = 5;
            label4.Text = "Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 267);
            label5.Name = "label5";
            label5.Size = new Size(95, 25);
            label5.TabIndex = 6;
            label5.Text = "ID Usuario";
            // 
            // txtPreV
            // 
            txtPreV.Location = new Point(195, 149);
            txtPreV.Name = "txtPreV";
            txtPreV.Size = new Size(210, 31);
            txtPreV.TabIndex = 8;
            // 
            // txtIdUs
            // 
            txtIdUs.Location = new Point(195, 264);
            txtIdUs.Name = "txtIdUs";
            txtIdUs.Size = new Size(210, 31);
            txtIdUs.TabIndex = 9;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(195, 207);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(210, 31);
            txtStock.TabIndex = 10;
            // 
            // txtCos
            // 
            txtCos.Location = new Point(195, 98);
            txtCos.Name = "txtCos";
            txtCos.Size = new Size(210, 31);
            txtCos.TabIndex = 11;
            // 
            // ABM_ProductoAlta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCos);
            Controls.Add(txtStock);
            Controls.Add(txtIdUs);
            Controls.Add(txtPreV);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtDes);
            Controls.Add(label1);
            Controls.Add(btnAddProduct);
            Name = "ABM_ProductoAlta";
            Text = "Cargar producto";
            Load += ABM_ProductoAlta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddProduct;
        private Label label1;
        private TextBox txtDes;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtPreV;
        private TextBox txtIdUs;
        private TextBox txtStock;
        private TextBox txtCos;
    }
}