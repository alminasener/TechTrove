namespace _20200305043.FORMS
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            picClose = new PictureBox();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label3 = new Label();
            picHide = new PictureBox();
            picShow = new PictureBox();
            btnLogIn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picShow).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Computer;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(47, 22);
            label1.Name = "label1";
            label1.Size = new Size(98, 13);
            label1.TabIndex = 0;
            label1.Text = "TechTrove | Log In";
            // 
            // picClose
            // 
            picClose.Image = Properties.Resources.Exit;
            picClose.Location = new Point(520, 12);
            picClose.Name = "picClose";
            picClose.Size = new Size(32, 32);
            picClose.SizeMode = PictureBoxSizeMode.Zoom;
            picClose.TabIndex = 2;
            picClose.TabStop = false;
            picClose.Click += picClose_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Logo;
            pictureBox3.Location = new Point(177, 34);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(200, 200);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(134, 271);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 0;
            label2.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(137, 289);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(291, 23);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(137, 340);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(269, 23);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(134, 322);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 0;
            label3.Text = "Password:";
            // 
            // picHide
            // 
            picHide.Cursor = Cursors.Hand;
            picHide.Image = Properties.Resources.Eye_Close;
            picHide.Location = new Point(405, 340);
            picHide.Name = "picHide";
            picHide.Size = new Size(23, 23);
            picHide.SizeMode = PictureBoxSizeMode.Zoom;
            picHide.TabIndex = 8;
            picHide.TabStop = false;
            picHide.Visible = false;
            picHide.Click += picHide_Click;
            // 
            // picShow
            // 
            picShow.Cursor = Cursors.Hand;
            picShow.Image = Properties.Resources.Eye_Open;
            picShow.Location = new Point(405, 340);
            picShow.Name = "picShow";
            picShow.Size = new Size(23, 23);
            picShow.SizeMode = PictureBoxSizeMode.Zoom;
            picShow.TabIndex = 9;
            picShow.TabStop = false;
            picShow.Click += picShow_Click;
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.FromArgb(22, 67, 108);
            btnLogIn.FlatAppearance.BorderSize = 0;
            btnLogIn.FlatStyle = FlatStyle.Flat;
            btnLogIn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogIn.ForeColor = Color.White;
            btnLogIn.Location = new Point(137, 425);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(291, 38);
            btnLogIn.TabIndex = 3;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(567, 560);
            Controls.Add(btnLogIn);
            Controls.Add(txtPassword);
            Controls.Add(picShow);
            Controls.Add(picHide);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(picClose);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TechTrove | Log In";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHide).EndInit();
            ((System.ComponentModel.ISupportInitialize)picShow).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox picClose;
        private PictureBox pictureBox3;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label3;
        private PictureBox picHide;
        private PictureBox picShow;
        private Button btnLogIn;
    }
}