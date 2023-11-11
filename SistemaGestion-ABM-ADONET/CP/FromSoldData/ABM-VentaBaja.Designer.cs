namespace SistemaGestion_ABM_ADONET.CP.FromSoldData
{
    partial class ABM_VentaBaja
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
            txtIDUser = new TextBox();
            label2 = new Label();
            button1 = new Button();
            txtCommit = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtIDUser
            // 
            txtIDUser.Location = new Point(163, 104);
            txtIDUser.Name = "txtIDUser";
            txtIDUser.Size = new Size(380, 31);
            txtIDUser.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 110);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 8;
            label2.Text = "ID Usuario";
            // 
            // button1
            // 
            button1.Location = new Point(28, 193);
            button1.Name = "button1";
            button1.Size = new Size(158, 59);
            button1.TabIndex = 7;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtCommit
            // 
            txtCommit.Location = new Point(163, 31);
            txtCommit.Name = "txtCommit";
            txtCommit.Size = new Size(380, 31);
            txtCommit.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 37);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 5;
            label1.Text = "Comentario";
            // 
            // ABM_VentaBaja
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(txtIDUser);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(txtCommit);
            Controls.Add(label1);
            Name = "ABM_VentaBaja";
            Text = "Eliminar venta";
            Load += ABM_VentaBaja_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIDUser;
        private Label label2;
        private Button button1;
        private TextBox txtCommit;
        private Label label1;
    }
}