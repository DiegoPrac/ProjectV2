namespace ProjectFajriGans.UserControls
{
    partial class UCLogin
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
            pnlBackground = new Panel();
            pnlLoginForm = new Panel();
            linkRegister = new LinkLabel();
            btnLogin = new Button();
            txtPassword = new TextBox();
            lblPassword = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblWelcome = new Label();
            lblLogin = new Label();
            pnlBackground.SuspendLayout();
            pnlLoginForm.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBackground
            // 
            pnlBackground.BackgroundImage = Properties.Resources.Register_David_Canitik;
            pnlBackground.BackgroundImageLayout = ImageLayout.Stretch;
            pnlBackground.Controls.Add(pnlLoginForm);
            pnlBackground.Dock = DockStyle.Fill;
            pnlBackground.Location = new Point(0, 0);
            pnlBackground.Name = "pnlBackground";
            pnlBackground.Size = new Size(1366, 768);
            pnlBackground.TabIndex = 0;
            pnlBackground.Paint += pnlBackground_Paint;
            pnlBackground.Resize += UCLogin_Resize;
            // 
            // pnlLoginForm
            // 
            pnlLoginForm.BackColor = Color.White;
            pnlLoginForm.Controls.Add(linkRegister);
            pnlLoginForm.Controls.Add(btnLogin);
            pnlLoginForm.Controls.Add(txtPassword);
            pnlLoginForm.Controls.Add(lblPassword);
            pnlLoginForm.Controls.Add(lblUsername);
            pnlLoginForm.Controls.Add(txtUsername);
            pnlLoginForm.Controls.Add(lblWelcome);
            pnlLoginForm.Controls.Add(lblLogin);
            pnlLoginForm.Location = new Point(674, 190);
            pnlLoginForm.Name = "pnlLoginForm";
            pnlLoginForm.Size = new Size(360, 430);
            pnlLoginForm.TabIndex = 0;
            // 
            // linkRegister
            // 
            linkRegister.AutoSize = true;
            linkRegister.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkRegister.LinkColor = Color.FromArgb(44, 118, 55);
            linkRegister.Location = new Point(62, 385);
            linkRegister.Name = "linkRegister";
            linkRegister.Size = new Size(234, 25);
            linkRegister.TabIndex = 7;
            linkRegister.TabStop = true;
            linkRegister.Text = "Belum punya akun? Register";
            linkRegister.VisitedLinkColor = Color.FromArgb(44, 118, 55);
            linkRegister.LinkClicked += linkRegister_LinkClicked;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(51, 140, 58);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(20, 330);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(320, 38);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Masuk";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(20, 250);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Masukkan password";
            txtPassword.Size = new Size(320, 31);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.FromArgb(44, 118, 55);
            lblPassword.Location = new Point(20, 220);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(87, 25);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.FromArgb(44, 118, 55);
            lblUsername.Location = new Point(20, 125);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(91, 25);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Location = new Point(20, 155);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Masukkan username";
            txtUsername.Size = new Size(320, 31);
            txtUsername.TabIndex = 2;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.Gray;
            lblWelcome.Location = new Point(20, 74);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(288, 25);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Selamat datang kembali di MyBibit";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.FromArgb(34, 52, 40);
            lblLogin.Location = new Point(20, 25);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(114, 48);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login";
            // 
            // UCLogin
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(pnlBackground);
            Name = "UCLogin";
            Size = new Size(1366, 768);
            pnlBackground.ResumeLayout(false);
            pnlLoginForm.ResumeLayout(false);
            pnlLoginForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBackground;
        private Panel pnlLoginForm;
        private Label lblLogin;
        private Label lblWelcome;
        private Label lblPassword;
        private Label lblUsername;
        private TextBox txtUsername;
        private Button btnLogin;
        private TextBox txtPassword;
        private LinkLabel linkRegister;
    }
}