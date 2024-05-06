namespace _20200305043.FORMS
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            panel1 = new Panel();
            btnClose = new Button();
            btnUsers = new Button();
            TechTrove = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txtUser = new TextBox();
            btnUAdd = new Button();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtPwd = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnUsers);
            panel1.Controls.Add(TechTrove);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
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
            btnClose.TabIndex = 2;
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
            btnUsers.TabIndex = 3;
            btnUsers.Text = "Users";
            btnUsers.TextAlign = ContentAlignment.MiddleLeft;
            btnUsers.UseVisualStyleBackColor = true;
            // 
            // TechTrove
            // 
            TechTrove.AutoSize = true;
            TechTrove.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            TechTrove.Location = new Point(56, 284);
            TechTrove.Name = "TechTrove";
            TechTrove.Size = new Size(122, 32);
            TechTrove.TabIndex = 1;
            TechTrove.Text = "TechTrove";
            TechTrove.Click += TechTrove_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Computer_2;
            pictureBox1.Location = new Point(42, 104);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(345, 174);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 7;
            label2.Text = "Username:";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(348, 192);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(291, 23);
            txtUser.TabIndex = 8;
            // 
            // btnUAdd
            // 
            btnUAdd.Location = new Point(766, 278);
            btnUAdd.Name = "btnUAdd";
            btnUAdd.Size = new Size(75, 23);
            btnUAdd.TabIndex = 9;
            btnUAdd.Text = "Add";
            btnUAdd.UseVisualStyleBackColor = true;
            btnUAdd.Click += btnUAdd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(343, 260);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 11;
            label3.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(346, 278);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(291, 23);
            txtEmail.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(345, 357);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 13;
            label4.Text = "Password:";
            // 
            // txtPwd
            // 
            txtPwd.Location = new Point(348, 375);
            txtPwd.Name = "txtPwd";
            txtPwd.Size = new Size(291, 23);
            txtPwd.TabIndex = 14;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(981, 560);
            Controls.Add(txtPwd);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(btnUAdd);
            Controls.Add(txtUser);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Users";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Users";
            Load += Users_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label TechTrove;
        private Button btnClose;
        private Button btnUsers;
        private Label label2;
        private TextBox txtUser;
        private Button btnUAdd;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtPwd;
    }
}