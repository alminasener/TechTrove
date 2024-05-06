namespace _20200305043.FORMS
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            panel1 = new Panel();
            btnClose = new Button();
            btnUsers = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtBrand = new TextBox();
            btnBAdd = new Button();
            label3 = new Label();
            txtProduct = new TextBox();
            btnPAdd = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnUsers);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(234, 560);
            panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.Location = new Point(56, 431);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(123, 41);
            btnClose.TabIndex = 0;
            btnClose.Text = "Log Out";
            btnClose.TextAlign = ContentAlignment.MiddleLeft;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnUsers
            // 
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnUsers.Location = new Point(56, 389);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(123, 36);
            btnUsers.TabIndex = 0;
            btnUsers.Text = "Users";
            btnUsers.TextAlign = ContentAlignment.MiddleLeft;
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(56, 284);
            label1.Name = "label1";
            label1.Size = new Size(122, 32);
            label1.TabIndex = 0;
            label1.Text = "TechTrove";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Computer_2;
            pictureBox1.Location = new Point(42, 104);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(401, 202);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(291, 23);
            txtBrand.TabIndex = 2;
            // 
            // btnBAdd
            // 
            btnBAdd.Location = new Point(737, 202);
            btnBAdd.Name = "btnBAdd";
            btnBAdd.Size = new Size(75, 23);
            btnBAdd.TabIndex = 4;
            btnBAdd.Text = "Add";
            btnBAdd.UseVisualStyleBackColor = true;
            btnBAdd.Click += btnBAdd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(398, 299);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 1;
            label3.Text = "Product:";
            // 
            // txtProduct
            // 
            txtProduct.Location = new Point(401, 317);
            txtProduct.Name = "txtProduct";
            txtProduct.Size = new Size(291, 23);
            txtProduct.TabIndex = 3;
            // 
            // btnPAdd
            // 
            btnPAdd.Location = new Point(737, 317);
            btnPAdd.Name = "btnPAdd";
            btnPAdd.Size = new Size(75, 23);
            btnPAdd.TabIndex = 5;
            btnPAdd.Text = "Add";
            btnPAdd.UseVisualStyleBackColor = true;
            btnPAdd.Click += btnPAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(398, 184);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 1;
            label2.Text = "Brand:";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(981, 560);
            Controls.Add(btnPAdd);
            Controls.Add(txtProduct);
            Controls.Add(label3);
            Controls.Add(btnBAdd);
            Controls.Add(txtBrand);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TechTrove";
            Load += Main_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnClose;
        private Button btnUsers;
        private TextBox txtBrand;
        private Button btnBAdd;
        private Label label3;
        private TextBox txtProduct;
        private Button btnPAdd;
        private Label label2;
    }
}