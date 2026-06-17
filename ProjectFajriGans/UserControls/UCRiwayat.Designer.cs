namespace MyBibit.UserControls
{
    partial class UCRiwayat
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
            lblTitleTotalTransaksi = new Label();
            dgvRiwayat = new DataGridView();
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
            pnlAvatar = new Panel();
            lblInitial = new Label();
            lblWelcome = new Label();
            lblTanggal = new Label();
            dtpAwal = new DateTimePicker();
            dtpAkhir = new DateTimePicker();
            pnlTotalTransaksi = new Panel();
            lblKetTotalTransaksi = new Label();
            lblTotalTransaksi = new Label();
            pnlTotalPendapatan = new Panel();
            lblKetTotalPengeluaran = new Label();
            lblTotalPengeluaran = new Label();
            lblTitleTotalPengeluaran = new Label();
            pnlTransaksiSelesai = new Panel();
            lblKetTransaksiSelesai = new Label();
            lblTransaksiSelesai = new Label();
            lblTitleTransaksiSelesai = new Label();
            label1 = new Label();
            btnFilter = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayat).BeginInit();
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCheckout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDashboard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRiwayat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlAvatar.SuspendLayout();
            pnlTotalTransaksi.SuspendLayout();
            pnlTotalPendapatan.SuspendLayout();
            pnlTransaksiSelesai.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitleTotalTransaksi
            // 
            lblTitleTotalTransaksi.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitleTotalTransaksi.Location = new Point(12, 14);
            lblTitleTotalTransaksi.Name = "lblTitleTotalTransaksi";
            lblTitleTotalTransaksi.Size = new Size(250, 35);
            lblTitleTotalTransaksi.TabIndex = 2;
            lblTitleTotalTransaksi.Text = "Total Transaksi";
            // 
            // dgvRiwayat
            // 
            dgvRiwayat.AllowUserToAddRows = false;
            dgvRiwayat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRiwayat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRiwayat.BackgroundColor = Color.White;
            dgvRiwayat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRiwayat.Location = new Point(350, 410);
            dgvRiwayat.Name = "dgvRiwayat";
            dgvRiwayat.ReadOnly = true;
            dgvRiwayat.RowHeadersVisible = false;
            dgvRiwayat.RowHeadersWidth = 62;
            dgvRiwayat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRiwayat.Size = new Size(800, 420);
            dgvRiwayat.TabIndex = 0;
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
            pnlSidebar.TabIndex = 9;
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
            picLogout.TabIndex = 16;
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
            btnLogout.TabIndex = 17;
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
            btnCheckout.Click += btnCheckout_Click;
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
            btnDashboard.Click += btnDashboard_Click;
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
            // pnlAvatar
            // 
            pnlAvatar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlAvatar.BackColor = Color.FromArgb(22, 101, 52);
            pnlAvatar.Controls.Add(lblInitial);
            pnlAvatar.Location = new Point(1270, 40);
            pnlAvatar.Name = "pnlAvatar";
            pnlAvatar.Size = new Size(40, 40);
            pnlAvatar.TabIndex = 15;
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
            // lblWelcome
            // 
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.FromArgb(44, 62, 45);
            lblWelcome.Location = new Point(226, 44);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(407, 56);
            lblWelcome.TabIndex = 11;
            lblWelcome.Text = "Selamat Datang, User ";
            // 
            // lblTanggal
            // 
            lblTanggal.BackColor = Color.Transparent;
            lblTanggal.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTanggal.ForeColor = Color.Gray;
            lblTanggal.Location = new Point(226, 15);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(200, 29);
            lblTanggal.TabIndex = 10;
            lblTanggal.Text = "Senin, 01 Juni 2026";
            // 
            // dtpAwal
            // 
            dtpAwal.Format = DateTimePickerFormat.Short;
            dtpAwal.Location = new Point(350, 350);
            dtpAwal.Name = "dtpAwal";
            dtpAwal.Size = new Size(220, 31);
            dtpAwal.TabIndex = 17;
            // 
            // dtpAkhir
            // 
            dtpAkhir.Format = DateTimePickerFormat.Short;
            dtpAkhir.Location = new Point(590, 350);
            dtpAkhir.Name = "dtpAkhir";
            dtpAkhir.Size = new Size(220, 31);
            dtpAkhir.TabIndex = 18;
            // 
            // pnlTotalTransaksi
            // 
            pnlTotalTransaksi.BackColor = Color.White;
            pnlTotalTransaksi.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalTransaksi.Controls.Add(lblKetTotalTransaksi);
            pnlTotalTransaksi.Controls.Add(lblTotalTransaksi);
            pnlTotalTransaksi.Controls.Add(lblTitleTotalTransaksi);
            pnlTotalTransaksi.Location = new Point(250, 140);
            pnlTotalTransaksi.Name = "pnlTotalTransaksi";
            pnlTotalTransaksi.Size = new Size(280, 141);
            pnlTotalTransaksi.TabIndex = 20;
            // 
            // lblKetTotalTransaksi
            // 
            lblKetTotalTransaksi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKetTotalTransaksi.Location = new Point(12, 111);
            lblKetTotalTransaksi.Name = "lblKetTotalTransaksi";
            lblKetTotalTransaksi.Size = new Size(89, 28);
            lblKetTotalTransaksi.TabIndex = 4;
            lblKetTotalTransaksi.Text = "transaksi";
            // 
            // lblTotalTransaksi
            // 
            lblTotalTransaksi.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalTransaksi.Location = new Point(12, 60);
            lblTotalTransaksi.Name = "lblTotalTransaksi";
            lblTotalTransaksi.Size = new Size(250, 51);
            lblTotalTransaksi.TabIndex = 3;
            lblTotalTransaksi.Text = "0";
            // 
            // pnlTotalPendapatan
            // 
            pnlTotalPendapatan.BackColor = Color.White;
            pnlTotalPendapatan.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalPendapatan.Controls.Add(lblKetTotalPengeluaran);
            pnlTotalPendapatan.Controls.Add(lblTotalPengeluaran);
            pnlTotalPendapatan.Controls.Add(lblTitleTotalPengeluaran);
            pnlTotalPendapatan.Location = new Point(623, 140);
            pnlTotalPendapatan.Name = "pnlTotalPendapatan";
            pnlTotalPendapatan.Size = new Size(280, 141);
            pnlTotalPendapatan.TabIndex = 21;
            // 
            // lblKetTotalPengeluaran
            // 
            lblKetTotalPengeluaran.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKetTotalPengeluaran.Location = new Point(12, 111);
            lblKetTotalPengeluaran.Name = "lblKetTotalPengeluaran";
            lblKetTotalPengeluaran.Size = new Size(112, 28);
            lblKetTotalPengeluaran.TabIndex = 4;
            lblKetTotalPengeluaran.Text = "keseluruhan";
            // 
            // lblTotalPengeluaran
            // 
            lblTotalPengeluaran.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPengeluaran.Location = new Point(12, 60);
            lblTotalPengeluaran.Name = "lblTotalPengeluaran";
            lblTotalPengeluaran.Size = new Size(250, 51);
            lblTotalPengeluaran.TabIndex = 3;
            lblTotalPengeluaran.Text = "Rp 0";
            // 
            // lblTitleTotalPengeluaran
            // 
            lblTitleTotalPengeluaran.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitleTotalPengeluaran.Location = new Point(12, 14);
            lblTitleTotalPengeluaran.Name = "lblTitleTotalPengeluaran";
            lblTitleTotalPengeluaran.Size = new Size(250, 35);
            lblTitleTotalPengeluaran.TabIndex = 2;
            lblTitleTotalPengeluaran.Text = "Total Pengeluaran";
            // 
            // pnlTransaksiSelesai
            // 
            pnlTransaksiSelesai.BackColor = Color.White;
            pnlTransaksiSelesai.BorderStyle = BorderStyle.FixedSingle;
            pnlTransaksiSelesai.Controls.Add(lblKetTransaksiSelesai);
            pnlTransaksiSelesai.Controls.Add(lblTransaksiSelesai);
            pnlTransaksiSelesai.Controls.Add(lblTitleTransaksiSelesai);
            pnlTransaksiSelesai.Location = new Point(1000, 140);
            pnlTransaksiSelesai.Name = "pnlTransaksiSelesai";
            pnlTransaksiSelesai.Size = new Size(280, 141);
            pnlTransaksiSelesai.TabIndex = 21;
            // 
            // lblKetTransaksiSelesai
            // 
            lblKetTransaksiSelesai.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKetTransaksiSelesai.Location = new Point(12, 111);
            lblKetTransaksiSelesai.Name = "lblKetTransaksiSelesai";
            lblKetTransaksiSelesai.Size = new Size(89, 28);
            lblKetTransaksiSelesai.TabIndex = 4;
            lblKetTransaksiSelesai.Text = "item";
            // 
            // lblTransaksiSelesai
            // 
            lblTransaksiSelesai.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTransaksiSelesai.Location = new Point(12, 60);
            lblTransaksiSelesai.Name = "lblTransaksiSelesai";
            lblTransaksiSelesai.Size = new Size(250, 51);
            lblTransaksiSelesai.TabIndex = 3;
            lblTransaksiSelesai.Text = "0";
            // 
            // lblTitleTransaksiSelesai
            // 
            lblTitleTransaksiSelesai.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitleTransaksiSelesai.Location = new Point(12, 14);
            lblTitleTransaksiSelesai.Name = "lblTitleTransaksiSelesai";
            lblTitleTransaksiSelesai.Size = new Size(250, 35);
            lblTitleTransaksiSelesai.TabIndex = 2;
            lblTitleTransaksiSelesai.Text = "Transaksi Selesai";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(350, 320);
            label1.Name = "label1";
            label1.Size = new Size(150, 25);
            label1.TabIndex = 22;
            label1.Text = "Filter Periode";
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.ForestGreen;
            btnFilter.Cursor = Cursors.Hand;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(830, 350);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(120, 35);
            btnFilter.TabIndex = 3;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // UCRiwayat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 242, 238);
            Controls.Add(pnlSidebar);
            Controls.Add(label1);
            Controls.Add(pnlTransaksiSelesai);
            Controls.Add(pnlTotalPendapatan);
            Controls.Add(pnlTotalTransaksi);
            Controls.Add(dtpAkhir);
            Controls.Add(dtpAwal);
            Controls.Add(pnlAvatar);
            Controls.Add(lblWelcome);
            Controls.Add(lblTanggal);
            Controls.Add(btnFilter);
            Controls.Add(dgvRiwayat);
            Name = "UCRiwayat";
            Size = new Size(1366, 1100);
            ((System.ComponentModel.ISupportInitialize)dgvRiwayat).EndInit();
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCheckout).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDashboard).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRiwayat).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlAvatar.ResumeLayout(false);
            pnlAvatar.PerformLayout();
            pnlTotalTransaksi.ResumeLayout(false);
            pnlTotalPendapatan.ResumeLayout(false);
            pnlTransaksiSelesai.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label lblTitleTotalTransaksi;
        private DataGridView dgvRiwayat;
        private Panel pnlSidebar;
        private Button btnLogout;
        private PictureBox picCheckout;
        private Button btnCheckout;
        private PictureBox picDashboard;
        private Button btnDashboard;
        private PictureBox picRiwayat;
        private Button btnRiwayat;
        private Label lblTagline;
        private Label lblLogo;
        private PictureBox picLogo;
        private Panel pnlAvatar;
        private Label lblInitial;
        private Label lblWelcome;
        private Label lblTanggal;
        private PictureBox picLogout;
        private DateTimePicker dtpAwal;
        private DateTimePicker dtpAkhir;
        private Panel pnlTotalTransaksi;
        private Label lblTotalTransaksi;
        private Label lblKetTotalTransaksi;
        private Panel pnlTotalPendapatan;
        private Label lblKetTotalPengeluaran;
        private Label lblTotalPengeluaran;
        private Label lblTitleTotalPengeluaran;
        private Panel pnlTransaksiSelesai;
        private Label lblKetTransaksiSelesai;
        private Label lblTransaksiSelesai;
        private Label lblTitleTransaksiSelesai;
        private Label label1;
        private Button btnFilter;
    }
}
