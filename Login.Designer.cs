namespace VerdantFarm
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnLogin = new Button();
            linkLabel1 = new LinkLabel();
            btnShowPassword = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(22, 85, 59);
            label1.Location = new Point(24, 85);
            label1.Name = "label1";
            label1.Size = new Size(214, 31);
            label1.TabIndex = 0;
            label1.Text = "VERDANT FARM";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(40, 140);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(188, 23);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(40, 190);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(135, 23);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(40, 122);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(40, 172);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(22, 85, 59);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(82, 230);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(104, 35);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.LinkColor = Color.FromArgb(23, 58, 116);
            linkLabel1.Location = new Point(111, 277);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(47, 15);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign up";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btnShowPassword
            // 
            btnShowPassword.BackColor = Color.Transparent;
            btnShowPassword.FlatStyle = FlatStyle.Flat;
            btnShowPassword.ForeColor = Color.Gray;
            btnShowPassword.Location = new Point(181, 189);
            btnShowPassword.Name = "btnShowPassword";
            btnShowPassword.Size = new Size(47, 24);
            btnShowPassword.TabIndex = 7;
            btnShowPassword.Text = "Show";
            btnShowPassword.UseVisualStyleBackColor = false;
            btnShowPassword.Click += btnShowPassword_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 85, 59);
            panel1.BackgroundImage = Properties.Resources._360_F_230653258_1SCEgR7iyZLpxP7T8pDPqaPIfHFtl6Qd;
            panel1.Location = new Point(0, 368);
            panel1.Name = "panel1";
            panel1.Size = new Size(410, 82);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(213, 214, 199);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtUsername);
            panel2.Controls.Add(btnShowPassword);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(73, 28);
            panel2.Name = "panel2";
            panel2.Size = new Size(263, 313);
            panel2.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Verdant_Farm_removebg_preview1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(85, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 79);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 250, 238);
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(409, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Verdant Farm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label2;
        private Label label3;
        private Button btnLogin;
        private LinkLabel linkLabel1;
        private Button btnShowPassword;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}
