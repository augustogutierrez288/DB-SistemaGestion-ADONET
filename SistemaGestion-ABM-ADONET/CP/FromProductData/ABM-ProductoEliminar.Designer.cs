﻿namespace SistemaGestion_ABM_ADONET.CP
{
    partial class ABM_ProductoEliminar
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
            txtCos = new TextBox();
            txtStock = new TextBox();
            txtIdUs = new TextBox();
            txtPreV = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtDes = new TextBox();
            label1 = new Label();
            btnDeleteProduct = new Button();
            SuspendLayout();
            // 
            // txtCos
            // 
            txtCos.Location = new Point(206, 96);
            txtCos.Name = "txtCos";
            txtCos.Size = new Size(150, 31);
            txtCos.TabIndex = 22;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(206, 205);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(150, 31);
            txtStock.TabIndex = 21;
            // 
            // txtIdUs
            // 
            txtIdUs.Location = new Point(206, 262);
            txtIdUs.Name = "txtIdUs";
            txtIdUs.Size = new Size(150, 31);
            txtIdUs.TabIndex = 20;
            // 
            // txtPreV
            // 
            txtPreV.Location = new Point(206, 147);
            txtPreV.Name = "txtPreV";
            txtPreV.Size = new Size(150, 31);
            txtPreV.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 265);
            label5.Name = "label5";
            label5.Size = new Size(95, 25);
            label5.TabIndex = 18;
            label5.Text = "ID Usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 211);
            label4.Name = "label4";
            label4.Size = new Size(55, 25);
            label4.TabIndex = 17;
            label4.Text = "Stock";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 164);
            label3.Name = "label3";
            label3.Size = new Size(134, 25);
            label3.TabIndex = 16;
            label3.Text = "Precio de Venta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 102);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 15;
            label2.Text = "Costo";
            // 
            // txtDes
            // 
            txtDes.Location = new Point(206, 35);
            txtDes.Name = "txtDes";
            txtDes.Size = new Size(150, 31);
            txtDes.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 41);
            label1.Name = "label1";
            label1.Size = new Size(121, 25);
            label1.TabIndex = 13;
            label1.Text = "Descripciones";
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Location = new Point(44, 336);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(185, 64);
            btnDeleteProduct.TabIndex = 12;
            btnDeleteProduct.Text = "Eliminar producto";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // ABM_ProductoEliminar
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
            Controls.Add(btnDeleteProduct);
            Name = "ABM_ProductoEliminar";
            Text = "Eliminar producto";
            Load += ABM_ProductoEliminar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCos;
        private TextBox txtStock;
        private TextBox txtIdUs;
        private TextBox txtPreV;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtDes;
        private Label label1;
        private Button btnDeleteProduct;
    }
}