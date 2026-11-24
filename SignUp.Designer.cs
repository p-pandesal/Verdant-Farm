namespace VerdantFarm
{
    partial class SignUp
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            txtUsername = new TextBox();
            label2 = new Label();
            btnLogin = new Button();
            linkLabel1 = new LinkLabel();
            txtPassword = new TextBox();
            label3 = new Label();
            btnShowPassword = new Button();
            label1 = new Label();
            txtConfirmPass = new TextBox();
            btnShowConfirmPass = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(37, 96);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(188, 23);
            txtUsername.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(37, 78);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(22, 85, 59);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(79, 235);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(104, 35);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Sign Up";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_ClickAsync;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.LinkColor = Color.FromArgb(23, 58, 116);
            linkLabel1.Location = new Point(111, 278);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(40, 15);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Log In";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(37, 150);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(135, 23);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(37, 132);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // btnShowPassword
            // 
            btnShowPassword.BackColor = Color.Transparent;
            btnShowPassword.FlatStyle = FlatStyle.Flat;
            btnShowPassword.ForeColor = Color.Gray;
            btnShowPassword.Location = new Point(178, 149);
            btnShowPassword.Name = "btnShowPassword";
            btnShowPassword.Size = new Size(47, 24);
            btnShowPassword.TabIndex = 7;
            btnShowPassword.Text = "Show";
            btnShowPassword.UseVisualStyleBackColor = false;
            btnShowPassword.Click += btnShowPassword_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(37, 186);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 9;
            label1.Text = "Confirm Password";
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.Location = new Point(37, 204);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.Size = new Size(135, 23);
            txtConfirmPass.TabIndex = 2;
            txtConfirmPass.UseSystemPasswordChar = true;
            // 
            // btnShowConfirmPass
            // 
            btnShowConfirmPass.BackColor = Color.Transparent;
            btnShowConfirmPass.FlatStyle = FlatStyle.Flat;
            btnShowConfirmPass.ForeColor = Color.Gray;
            btnShowConfirmPass.Location = new Point(178, 203);
            btnShowConfirmPass.Name = "btnShowConfirmPass";
            btnShowConfirmPass.Size = new Size(47, 24);
            btnShowConfirmPass.TabIndex = 10;
            btnShowConfirmPass.Text = "Show";
            btnShowConfirmPass.UseVisualStyleBackColor = false;
            btnShowConfirmPass.Click += btnShowConfirmPass_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 85, 59);
            panel1.BackgroundImage = Properties.Resources._360_F_230653258_1SCEgR7iyZLpxP7T8pDPqaPIfHFtl6Qd;
            panel1.Location = new Point(0, 368);
            panel1.Name = "panel1";
            panel1.Size = new Size(410, 82);
            panel1.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(213, 214, 199);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtUsername);
            panel2.Controls.Add(btnShowConfirmPass);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtConfirmPass);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(btnShowPassword);
            panel2.Controls.Add(linkLabel1);
            panel2.Location = new Point(73, 28);
            panel2.Name = "panel2";
            panel2.Size = new Size(263, 313);
            panel2.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Verdant_Farm_removebg_preview;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(85, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 79);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 250, 238);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(409, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SignUp";
            Text = "Verdant Farm";
            FormClosed += SignUp_FormClosed;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtUsername;
        private Label label2;
        private Button btnLogin;
        private LinkLabel linkLabel1;
        private TextBox txtPassword;
        private Label label3;
        private Button btnShowPassword;
        private Label label1;
        private TextBox txtConfirmPass;
        private Button btnShowConfirmPass;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}