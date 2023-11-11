namespace SistemaGestion_ABM_ADONET.CP
{
    partial class Home
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
            lblTitleHome = new Label();
            btnProduct = new Button();
            lblSubtitleHome = new Label();
            btnProductSold = new Button();
            btnUsers = new Button();
            btnSale = new Button();
            btnSignoff = new Button();
            SuspendLayout();
            // 
            // lblTitleHome
            // 
            lblTitleHome.AutoSize = true;
            lblTitleHome.Location = new Point(336, 59);
            lblTitleHome.Name = "lblTitleHome";
            lblTitleHome.Size = new Size(65, 25);
            lblTitleHome.TabIndex = 0;
            lblTitleHome.Text = "INICIO";
            // 
            // btnProduct
            // 
            btnProduct.Location = new Point(189, 194);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(160, 34);
            btnProduct.TabIndex = 1;
            btnProduct.Text = "Productos";
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click;
            // 
            // lblSubtitleHome
            // 
            lblSubtitleHome.AutoSize = true;
            lblSubtitleHome.Location = new Point(130, 106);
            lblSubtitleHome.Name = "lblSubtitleHome";
            lblSubtitleHome.Size = new Size(495, 25);
            lblSubtitleHome.TabIndex = 2;
            lblSubtitleHome.Text = "Selecciona que producto de la base de datos quieres trabajar";
            // 
            // btnProductSold
            // 
            btnProductSold.Location = new Point(395, 194);
            btnProductSold.Name = "btnProductSold";
            btnProductSold.Size = new Size(160, 34);
            btnProductSold.TabIndex = 3;
            btnProductSold.Text = "Productos V.";
            btnProductSold.UseVisualStyleBackColor = true;
            btnProductSold.Click += btnProductSold_Click;
            // 
            // btnUsers
            // 
            btnUsers.Location = new Point(189, 283);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(160, 34);
            btnUsers.TabIndex = 4;
            btnUsers.Text = "Usuarios";
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnSale
            // 
            btnSale.Location = new Point(395, 283);
            btnSale.Name = "btnSale";
            btnSale.Size = new Size(160, 34);
            btnSale.TabIndex = 5;
            btnSale.Text = "Ventas";
            btnSale.UseVisualStyleBackColor = true;
            btnSale.Click += btnSale_Click;
            // 
            // btnSignoff
            // 
            btnSignoff.Location = new Point(285, 369);
            btnSignoff.Name = "btnSignoff";
            btnSignoff.Size = new Size(160, 34);
            btnSignoff.TabIndex = 6;
            btnSignoff.Text = "Cerrar Sesion";
            btnSignoff.UseVisualStyleBackColor = true;
            btnSignoff.Click += btnSignoff_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSignoff);
            Controls.Add(btnSale);
            Controls.Add(btnUsers);
            Controls.Add(btnProductSold);
            Controls.Add(lblSubtitleHome);
            Controls.Add(btnProduct);
            Controls.Add(lblTitleHome);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitleHome;
        private Button btnProduct;
        private Label lblSubtitleHome;
        private Button btnProductSold;
        private Button btnUsers;
        private Button btnSale;
        private Button btnSignoff;
    }
}