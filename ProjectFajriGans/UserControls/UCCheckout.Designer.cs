namespace ProjectFajriGans.UserControls
{
    partial class UCCheckout
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
            lblTanggal = new Label();
            lblWelcome = new Label();
            pnlSearch = new Panel();
            txtCariBibit = new TextBox();
            picSearch = new PictureBox();
            pnlAvatar = new Panel();
            lblInitial = new Label();
            pnlSidebar = new Panel();
            picLogout = new PictureBox();
            btnLogout = new Button();
            picCheckout = new PictureBox();
            btnCheckout = new Button();
            picDashboard = new PictureBox();
            btnDashboard = new Button();
            picRiwayat = new PictureBox();
            btnRiwayat = new Button();
            lblTagline = new Label();
            lblLogo = new Label();
            picLogo = new PictureBox();
            lblCheckout = new Label();
            pnlRingkasan = new Panel();
            btnEwallet = new Button();
            btnKembali = new Button();
            pnlTotalHarga = new Panel();
            lblTotalHarga = new Label();
            lblTitleTotalHarga = new Label();
            lblJumlahItem = new Label();
            lblItemDipilih = new Label();
            dgvCheckout = new DataGridView();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSearch).BeginInit();
            pnlAvatar.SuspendLayout();
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCheckout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDashboard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRiwayat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlRingkasan.SuspendLayout();
            pnlTotalHarga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCheckout).BeginInit();
            SuspendLayout();
            // 
            // lblTanggal
            // 
            lblTanggal.BackColor = Color.Transparent;
            lblTanggal.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTanggal.ForeColor = Color.Gray;
            lblTanggal.Location = new Point(226, 15);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(200, 29);
            lblTanggal.TabIndex = 2;
            lblTanggal.Text = "Senin, 01 Juni 2026";
            // 
            // lblWelcome
            // 
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.FromArgb(44, 62, 45);
            lblWelcome.Location = new Point(226, 44);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(407, 56);
            lblWelcome.TabIndex = 3;
            lblWelcome.Text = "Selamat Datang, User ";
            // 
            // pnlSearch
            // 
            pnlSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlSearch.BackColor = Color.FromArgb(243, 247, 243);
            pnlSearch.BorderStyle = BorderStyle.FixedSingle;
            pnlSearch.Controls.Add(txtCariBibit);
            pnlSearch.Controls.Add(picSearch);
            pnlSearch.Location = new Point(1003, 40);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(250, 40);
            pnlSearch.TabIndex = 4;
            // 
            // txtCariBibit
            // 
            txtCariBibit.BorderStyle = BorderStyle.None;
            txtCariBibit.ForeColor = Color.Gray;
            txtCariBibit.Location = new Point(33, 6);
            txtCariBibit.Name = "txtCariBibit";
            txtCariBibit.Size = new Size(180, 24);
            txtCariBibit.TabIndex = 4;
            txtCariBibit.Text = "Cari bibit...";
            txtCariBibit.TextChanged += txtCariBibit_TextChanged;
            // 
            // picSearch
            // 
            picSearch.BackColor = Color.Transparent;
            picSearch.BackgroundImage = Properties.Resources.pentung;
            picSearch.BackgroundImageLayout = ImageLayout.Zoom;
            picSearch.Location = new Point(7, 11);
            picSearch.Name = "picSearch";
            picSearch.Size = new Size(16, 16);
            picSearch.TabIndex = 4;
            picSearch.TabStop = false;
            // 
            // pnlAvatar
            // 
            pnlAvatar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlAvatar.BackColor = Color.FromArgb(22, 101, 52);
            pnlAvatar.Controls.Add(lblInitial);
            pnlAvatar.Location = new Point(1270, 40);
            pnlAvatar.Name = "pnlAvatar";
            pnlAvatar.Size = new Size(40, 40);
            pnlAvatar.TabIndex = 7;
            // 
            // lblInitial
            // 
            lblInitial.AutoSize = true;
            lblInitial.BackColor = Color.Transparent;
            lblInitial.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInitial.ForeColor = Color.White;
            lblInitial.Location = new Point(5, 4);
            lblInitial.Name = "lblInitial";
            lblInitial.Size = new Size(31, 32);
            lblInitial.TabIndex = 7;
            lblInitial.Text = "U";
            lblInitial.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(18, 96, 48);
            pnlSidebar.Controls.Add(picLogout);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(picCheckout);
            pnlSidebar.Controls.Add(btnCheckout);
            pnlSidebar.Controls.Add(picDashboard);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(picRiwayat);
            pnlSidebar.Controls.Add(btnRiwayat);
            pnlSidebar.Controls.Add(lblTagline);
            pnlSidebar.Controls.Add(lblLogo);
            pnlSidebar.Controls.Add(picLogo);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(220, 1100);
            pnlSidebar.TabIndex = 8;
            // 
            // picLogout
            // 
            picLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            picLogout.BackColor = Color.Transparent;
            picLogout.BackgroundImage = Properties.Resources._out;
            picLogout.BackgroundImageLayout = ImageLayout.Zoom;
            picLogout.Location = new Point(11, 1025);
            picLogout.Name = "picLogout";
            picLogout.Size = new Size(20, 20);
            picLogout.TabIndex = 8;
            picLogout.TabStop = false;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLogout.BackColor = Color.Transparent;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(24, 1012);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(15, 0, 0, 0);
            btnLogout.Size = new Size(180, 40);
            btnLogout.TabIndex = 11;
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // picCheckout
            // 
            picCheckout.BackColor = Color.Transparent;
            picCheckout.BackgroundImage = Properties.Resources.Icon__6_;
            picCheckout.BackgroundImageLayout = ImageLayout.Zoom;
            picCheckout.Location = new Point(11, 334);
            picCheckout.Name = "picCheckout";
            picCheckout.Size = new Size(16, 16);
            picCheckout.TabIndex = 10;
            picCheckout.TabStop = false;
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = Color.Transparent;
            btnCheckout.Cursor = Cursors.Hand;
            btnCheckout.FlatAppearance.BorderSize = 0;
            btnCheckout.FlatStyle = FlatStyle.Flat;
            btnCheckout.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckout.ForeColor = Color.White;
            btnCheckout.Location = new Point(37, 321);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(180, 40);
            btnCheckout.TabIndex = 9;
            btnCheckout.Text = "Checkout";
            btnCheckout.TextAlign = ContentAlignment.MiddleLeft;
            btnCheckout.UseVisualStyleBackColor = false;
            // 
            // picDashboard
            // 
            picDashboard.BackColor = Color.Transparent;
            picDashboard.BackgroundImage = Properties.Resources.dashbos1;
            picDashboard.BackgroundImageLayout = ImageLayout.Zoom;
            picDashboard.Location = new Point(11, 232);
            picDashboard.Name = "picDashboard";
            picDashboard.Size = new Size(20, 20);
            picDashboard.TabIndex = 6;
            picDashboard.TabStop = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(37, 221);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(180, 40);
            btnDashboard.TabIndex = 3;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += MenuDashboard_Click;
            // 
            // picRiwayat
            // 
            picRiwayat.BackColor = Color.Transparent;
            picRiwayat.BackgroundImage = Properties.Resources.riwayas;
            picRiwayat.BackgroundImageLayout = ImageLayout.Zoom;
            picRiwayat.Location = new Point(11, 283);
            picRiwayat.Name = "picRiwayat";
            picRiwayat.Size = new Size(20, 20);
            picRiwayat.TabIndex = 7;
            picRiwayat.TabStop = false;
            // 
            // btnRiwayat
            // 
            btnRiwayat.BackColor = Color.Transparent;
            btnRiwayat.Cursor = Cursors.Hand;
            btnRiwayat.FlatAppearance.BorderSize = 0;
            btnRiwayat.FlatStyle = FlatStyle.Flat;
            btnRiwayat.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRiwayat.ForeColor = Color.White;
            btnRiwayat.Location = new Point(23, 271);
            btnRiwayat.Name = "btnRiwayat";
            btnRiwayat.Padding = new Padding(15, 0, 0, 0);
            btnRiwayat.Size = new Size(180, 40);
            btnRiwayat.TabIndex = 4;
            btnRiwayat.Text = "Riwayat";
            btnRiwayat.TextAlign = ContentAlignment.MiddleLeft;
            btnRiwayat.UseVisualStyleBackColor = false;
            btnRiwayat.Click += btnRiwayat_Click;
            // 
            // lblTagline
            // 
            lblTagline.AutoSize = true;
            lblTagline.BackColor = Color.Transparent;
            lblTagline.ForeColor = Color.Gainsboro;
            lblTagline.Location = new Point(37, 155);
            lblTagline.Name = "lblTagline";
            lblTagline.Size = new Size(146, 25);
            lblTagline.TabIndex = 2;
            lblTagline.Text = "Kelola Bibit Anda";
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.BackColor = Color.Transparent;
            lblLogo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(44, 103);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(139, 45);
            lblLogo.TabIndex = 1;
            lblLogo.Text = "MyBibit";
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.BackgroundImage = Properties.Resources.Dancok;
            picLogo.BackgroundImageLayout = ImageLayout.Zoom;
            picLogo.Location = new Point(82, 35);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(56, 56);
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblCheckout
            // 
            lblCheckout.AutoSize = true;
            lblCheckout.BackColor = Color.Transparent;
            lblCheckout.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCheckout.ForeColor = Color.FromArgb(44, 62, 45);
            lblCheckout.Location = new Point(260, 120);
            lblCheckout.Name = "lblCheckout";
            lblCheckout.Size = new Size(198, 54);
            lblCheckout.TabIndex = 9;
            lblCheckout.Text = "Checkout";
            // 
            // pnlRingkasan
            // 
            pnlRingkasan.BackColor = Color.White;
            pnlRingkasan.BorderStyle = BorderStyle.FixedSingle;
            pnlRingkasan.Controls.Add(btnEwallet);
            pnlRingkasan.Controls.Add(btnKembali);
            pnlRingkasan.Controls.Add(pnlTotalHarga);
            pnlRingkasan.Controls.Add(lblJumlahItem);
            pnlRingkasan.Controls.Add(lblItemDipilih);
            pnlRingkasan.Location = new Point(345, 617);
            pnlRingkasan.Name = "pnlRingkasan";
            pnlRingkasan.Size = new Size(802, 180);
            pnlRingkasan.TabIndex = 11;
            // 
            // btnEwallet
            // 
            btnEwallet.BackColor = Color.ForestGreen;
            btnEwallet.FlatStyle = FlatStyle.Flat;
            btnEwallet.ForeColor = Color.White;
            btnEwallet.Location = new Point(415, 125);
            btnEwallet.Name = "btnEwallet";
            btnEwallet.Size = new Size(300, 40);
            btnEwallet.TabIndex = 4;
            btnEwallet.Text = "E-Wallet";
            btnEwallet.UseVisualStyleBackColor = false;
            btnEwallet.Click += btnEwallet_Click;
            // 
            // btnKembali
            // 
            btnKembali.ForeColor = Color.ForestGreen;
            btnKembali.Location = new Point(95, 125);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(300, 40);
            btnKembali.TabIndex = 3;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            btnKembali.Click += btnKembali_Click;
            // 
            // pnlTotalHarga
            // 
            pnlTotalHarga.BackColor = Color.FromArgb(235, 245, 235);
            pnlTotalHarga.Controls.Add(lblTotalHarga);
            pnlTotalHarga.Controls.Add(lblTitleTotalHarga);
            pnlTotalHarga.Location = new Point(95, 55);
            pnlTotalHarga.Name = "pnlTotalHarga";
            pnlTotalHarga.Size = new Size(620, 60);
            pnlTotalHarga.TabIndex = 2;
            // 
            // lblTotalHarga
            // 
            lblTotalHarga.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotalHarga.AutoSize = true;
            lblTotalHarga.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalHarga.ForeColor = Color.FromArgb(46, 125, 50);
            lblTotalHarga.Location = new Point(464, 15);
            lblTotalHarga.Name = "lblTotalHarga";
            lblTotalHarga.Size = new Size(148, 38);
            lblTotalHarga.TabIndex = 1;
            lblTotalHarga.Text = "Rp 65.000";
            // 
            // lblTitleTotalHarga
            // 
            lblTitleTotalHarga.AutoSize = true;
            lblTitleTotalHarga.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleTotalHarga.ForeColor = Color.FromArgb(44, 62, 45);
            lblTitleTotalHarga.Location = new Point(20, 18);
            lblTitleTotalHarga.Name = "lblTitleTotalHarga";
            lblTitleTotalHarga.Size = new Size(134, 30);
            lblTitleTotalHarga.TabIndex = 0;
            lblTitleTotalHarga.Text = "Total Harga";
            // 
            // lblJumlahItem
            // 
            lblJumlahItem.AutoSize = true;
            lblJumlahItem.Location = new Point(660, 20);
            lblJumlahItem.Name = "lblJumlahItem";
            lblJumlahItem.Size = new Size(55, 25);
            lblJumlahItem.TabIndex = 1;
            lblJumlahItem.Text = "6 pot";
            // 
            // lblItemDipilih
            // 
            lblItemDipilih.AutoSize = true;
            lblItemDipilih.Location = new Point(95, 20);
            lblItemDipilih.Name = "lblItemDipilih";
            lblItemDipilih.Size = new Size(101, 25);
            lblItemDipilih.TabIndex = 0;
            lblItemDipilih.Text = "Item dipilih";
            // 
            // dgvCheckout
            // 
            dgvCheckout.AllowUserToAddRows = false;
            dgvCheckout.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCheckout.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCheckout.Location = new Point(290, 184);
            dgvCheckout.Name = "dgvCheckout";
            dgvCheckout.ReadOnly = true;
            dgvCheckout.RowHeadersVisible = false;
            dgvCheckout.RowHeadersWidth = 62;
            dgvCheckout.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCheckout.Size = new Size(900, 350);
            dgvCheckout.TabIndex = 12;
            // 
            // UCCheckout
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(242, 247, 242);
            Controls.Add(dgvCheckout);
            Controls.Add(pnlRingkasan);
            Controls.Add(lblCheckout);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlAvatar);
            Controls.Add(pnlSearch);
            Controls.Add(lblWelcome);
            Controls.Add(lblTanggal);
            Name = "UCCheckout";
            Size = new Size(1366, 1100);
            Load += UCCheckout_Load;
            Click += btnLogout_Click;
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSearch).EndInit();
            pnlAvatar.ResumeLayout(false);
            pnlAvatar.PerformLayout();
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCheckout).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDashboard).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRiwayat).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlRingkasan.ResumeLayout(false);
            pnlRingkasan.PerformLayout();
            pnlTotalHarga.ResumeLayout(false);
            pnlTotalHarga.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCheckout).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTanggal;
        private Label lblWelcome;
        private Panel pnlSearch;
        private TextBox txtCariBibit;
        private PictureBox picSearch;
        private Panel pnlAvatar;
        private Label lblInitial;
        private Panel pnlSidebar;
        private PictureBox picCheckout;
        private Button btnCheckout;
        private PictureBox picDashboard;
        private Button btnDashboard;
        private PictureBox picRiwayat;
        private Button btnLogout;
        private Button btnRiwayat;
        private Label lblTagline;
        private Label lblLogo;
        private PictureBox picLogo;
        private Label lblCheckout;
        private Panel pnlRingkasan;
        private Label lblItemDipilih;
        private Panel pnlTotalHarga;
        private Label lblJumlahItem;
        private Button btnEwallet;
        private Button btnKembali;
        private Label lblTotalHarga;
        private Label lblTitleTotalHarga;
        private PictureBox picLogout;
        private DataGridView dgvCheckout;
    }
}
