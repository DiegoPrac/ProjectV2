namespace MyBibit.UserControls
{
    partial class UCRegister
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlBackground = new Panel();
            pnlRegisterForm = new Panel();
            linkLogin = new LinkLabel();
            btnDaftar = new Button();
            dtpTanggalLahir = new DateTimePicker();
            lblTanggalLahir = new Label();
            txtNoTelepon = new TextBox();
            lblNoTelepon = new Label();
            txtAlamat = new TextBox();
            lblAlamat = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUsername = new TextBox();
            lblUsername = new Label();
            lblWelcomeRegister = new Label();
            lblRegister = new Label();
            pnlBackground.SuspendLayout();
            pnlRegisterForm.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBackground
            // 
            pnlBackground.BackgroundImage = Properties.Resources.Register_David_Canitik;
            pnlBackground.BackgroundImageLayout = ImageLayout.Stretch;
            pnlBackground.Controls.Add(pnlRegisterForm);
            pnlBackground.Dock = DockStyle.Fill;
            pnlBackground.Location = new Point(0, 0);
            pnlBackground.Name = "pnlBackground";
            pnlBackground.Size = new Size(1366, 768);
            pnlBackground.TabIndex = 0;
            pnlBackground.Resize += UCRegister_Resize;
            // 
            // pnlRegisterForm
            // 
            pnlRegisterForm.Controls.Add(linkLogin);
            pnlRegisterForm.Controls.Add(btnDaftar);
            pnlRegisterForm.Controls.Add(dtpTanggalLahir);
            pnlRegisterForm.Controls.Add(lblTanggalLahir);
            pnlRegisterForm.Controls.Add(txtNoTelepon);
            pnlRegisterForm.Controls.Add(lblNoTelepon);
            pnlRegisterForm.Controls.Add(txtAlamat);
            pnlRegisterForm.Controls.Add(lblAlamat);
            pnlRegisterForm.Controls.Add(txtPassword);
            pnlRegisterForm.Controls.Add(lblPassword);
            pnlRegisterForm.Controls.Add(txtUsername);
            pnlRegisterForm.Controls.Add(lblUsername);
            pnlRegisterForm.Controls.Add(lblWelcomeRegister);
            pnlRegisterForm.Controls.Add(lblRegister);
            pnlRegisterForm.Location = new Point(674, 188);
            pnlRegisterForm.Name = "pnlRegisterForm";
            pnlRegisterForm.Size = new Size(360, 466);
            pnlRegisterForm.TabIndex = 0;
            // 
            // linkLogin
            // 
            linkLogin.ActiveLinkColor = Color.ForestGreen;
            linkLogin.AutoSize = true;
            linkLogin.LinkColor = Color.FromArgb(44, 118, 55);
            linkLogin.Location = new Point(71, 434);
            linkLogin.Name = "linkLogin";
            linkLogin.Size = new Size(216, 25);
            linkLogin.TabIndex = 13;
            linkLogin.TabStop = true;
            linkLogin.Text = "Sudah punya akun? Login";
            linkLogin.VisitedLinkColor = Color.FromArgb(44, 118, 55);
            linkLogin.LinkClicked += linkLogin_LinkClicked;
            // 
            // btnDaftar
            // 
            btnDaftar.BackColor = Color.FromArgb(51, 140, 58);
            btnDaftar.FlatAppearance.BorderSize = 0;
            btnDaftar.FlatStyle = FlatStyle.Flat;
            btnDaftar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDaftar.ForeColor = Color.White;
            btnDaftar.Location = new Point(20, 390);
            btnDaftar.Name = "btnDaftar";
            btnDaftar.Size = new Size(320, 38);
            btnDaftar.TabIndex = 12;
            btnDaftar.Text = "Daftar";
            btnDaftar.UseVisualStyleBackColor = false;
            btnDaftar.Click += btnDaftar_Click;
            // 
            // dtpTanggalLahir
            // 
            dtpTanggalLahir.Format = DateTimePickerFormat.Short;
            dtpTanggalLahir.Location = new Point(20, 345);
            dtpTanggalLahir.Name = "dtpTanggalLahir";
            dtpTanggalLahir.Size = new Size(320, 31);
            dtpTanggalLahir.TabIndex = 11;
            // 
            // lblTanggalLahir
            // 
            lblTanggalLahir.AutoSize = true;
            lblTanggalLahir.ForeColor = Color.FromArgb(44, 118, 55);
            lblTanggalLahir.Location = new Point(20, 320);
            lblTanggalLahir.Name = "lblTanggalLahir";
            lblTanggalLahir.Size = new Size(115, 25);
            lblTanggalLahir.TabIndex = 10;
            lblTanggalLahir.Text = "Tanggal Lahir";
            // 
            // txtNoTelepon
            // 
            txtNoTelepon.Location = new Point(20, 283);
            txtNoTelepon.Name = "txtNoTelepon";
            txtNoTelepon.PlaceholderText = "Masukkan no telepon";
            txtNoTelepon.Size = new Size(320, 31);
            txtNoTelepon.TabIndex = 9;
            // 
            // lblNoTelepon
            // 
            lblNoTelepon.AutoSize = true;
            lblNoTelepon.ForeColor = Color.FromArgb(44, 118, 55);
            lblNoTelepon.Location = new Point(20, 260);
            lblNoTelepon.Name = "lblNoTelepon";
            lblNoTelepon.Size = new Size(102, 25);
            lblNoTelepon.TabIndex = 8;
            lblNoTelepon.Text = "No Telepon";
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(20, 223);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.PlaceholderText = "Masukkan alamat";
            txtAlamat.Size = new Size(320, 31);
            txtAlamat.TabIndex = 7;
            // 
            // lblAlamat
            // 
            lblAlamat.AutoSize = true;
            lblAlamat.ForeColor = Color.FromArgb(44, 118, 55);
            lblAlamat.Location = new Point(20, 200);
            lblAlamat.Name = "lblAlamat";
            lblAlamat.Size = new Size(68, 25);
            lblAlamat.TabIndex = 6;
            lblAlamat.Text = "Alamat";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(20, 163);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Masukkan password";
            txtPassword.Size = new Size(320, 31);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.ForeColor = Color.FromArgb(44, 118, 55);
            lblPassword.Location = new Point(20, 140);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(87, 25);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Location = new Point(20, 103);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Masukkan username";
            txtUsername.Size = new Size(320, 31);
            txtUsername.TabIndex = 3;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.ForeColor = Color.FromArgb(44, 118, 55);
            lblUsername.Location = new Point(20, 80);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(91, 25);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username";
            // 
            // lblWelcomeRegister
            // 
            lblWelcomeRegister.AutoSize = true;
            lblWelcomeRegister.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcomeRegister.ForeColor = Color.Gray;
            lblWelcomeRegister.Location = new Point(20, 57);
            lblWelcomeRegister.Name = "lblWelcomeRegister";
            lblWelcomeRegister.Size = new Size(196, 25);
            lblWelcomeRegister.TabIndex = 1;
            lblWelcomeRegister.Text = "Buat akun baru MyBibit";
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegister.ForeColor = Color.FromArgb(28, 57, 38);
            lblRegister.Location = new Point(20, 10);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(157, 48);
            lblRegister.TabIndex = 0;
            lblRegister.Text = "Register";
            // 
            // UCRegister
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            Controls.Add(pnlBackground);
            Name = "UCRegister";
            Size = new Size(1366, 768);
            pnlBackground.ResumeLayout(false);
            pnlRegisterForm.ResumeLayout(false);
            pnlRegisterForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBackground;
        private Panel pnlRegisterForm;
        private Label lblRegister;
        private Label lblWelcomeRegister;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtUsername;
        private Label lblUsername;
        private TextBox txtNoTelepon;
        private Label lblNoTelepon;
        private TextBox txtAlamat;
        private Label lblAlamat;
        private Label lblTanggalLahir;
        private DateTimePicker dtpTanggalLahir;
        private LinkLabel linkLogin;
        private Button btnDaftar;
    }
}
