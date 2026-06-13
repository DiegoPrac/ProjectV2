namespace MyBibit.UserControls
{
    partial class UCOrderDetailKaryawan
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
            pnlSidebar = new Panel();
            pictureBox1 = new PictureBox();
            btnRestock = new Button();
            lblLogo = new Label();
            picLogout = new PictureBox();
            btnLogout = new Button();
            picRiwayat = new PictureBox();
            picDashboard = new PictureBox();
            btnDashboard = new Button();
            btnOrderDetail = new Button();
            lblTagline = new Label();
            picLogo = new PictureBox();
            lblTanggal = new Label();
            lblOrder = new Label();
            pnlAvatar = new Panel();
            lblTitle = new Label();
            pnlSearch = new Panel();
            txtCariBibit = new TextBox();
            picSearch = new PictureBox();
            lblJumlahOrder = new Label();
            pnlContent = new Panel();
            pnlOrderContainer = new Panel();
            lblJudulOrder = new Label();
            dgvOrder = new DataGridView();
            colTanggal = new DataGridViewTextBoxColumn();
            colCustomer = new DataGridViewTextBoxColumn();
            colTotalOrder = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewComboBoxColumn();
            colDetail = new DataGridViewButtonColumn();
            pnlOverlay = new Panel();
            pnlPopupDetailOrder = new Panel();
            lblTotalDetailOrder = new Label();
            btnTutupDetail = new Button();
            dgvDetailOrder = new DataGridView();
            colFoto = new DataGridViewImageColumn();
            colProduk = new DataGridViewTextBoxColumn();
            colHarga = new DataGridViewTextBoxColumn();
            colQty = new DataGridViewTextBoxColumn();
            colSubtotal = new DataGridViewTextBoxColumn();
            lblDetailOrder = new Label();
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRiwayat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDashboard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlAvatar.SuspendLayout();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSearch).BeginInit();
            pnlContent.SuspendLayout();
            pnlOrderContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            pnlOverlay.SuspendLayout();
            pnlPopupDetailOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetailOrder).BeginInit();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(18, 96, 48);
            pnlSidebar.Controls.Add(pictureBox1);
            pnlSidebar.Controls.Add(btnRestock);
            pnlSidebar.Controls.Add(lblLogo);
            pnlSidebar.Controls.Add(picLogout);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(picRiwayat);
            pnlSidebar.Controls.Add(picDashboard);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(btnOrderDetail);
            pnlSidebar.Controls.Add(lblTagline);
            pnlSidebar.Controls.Add(picLogo);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(220, 1500);
            pnlSidebar.TabIndex = 16;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Restock;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(11, 331);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // btnRestock
            // 
            btnRestock.BackColor = Color.Transparent;
            btnRestock.Cursor = Cursors.Hand;
            btnRestock.FlatAppearance.BorderSize = 0;
            btnRestock.FlatStyle = FlatStyle.Flat;
            btnRestock.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRestock.ForeColor = Color.White;
            btnRestock.Location = new Point(21, 319);
            btnRestock.Name = "btnRestock";
            btnRestock.Padding = new Padding(15, 0, 0, 0);
            btnRestock.Size = new Size(160, 40);
            btnRestock.TabIndex = 17;
            btnRestock.Text = "Restock";
            btnRestock.TextAlign = ContentAlignment.MiddleLeft;
            btnRestock.UseVisualStyleBackColor = false;
            btnRestock.Click += btnRestock_Click;
            // 
            // lblLogo
            // 
            lblLogo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblLogo.AutoSize = true;
            lblLogo.BackColor = Color.Transparent;
            lblLogo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(44, 103);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(139, 45);
            lblLogo.TabIndex = 12;
            lblLogo.Text = "MyBibit";
            // 
            // picLogout
            // 
            picLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            picLogout.BackColor = Color.Transparent;
            picLogout.BackgroundImage = Properties.Resources._out;
            picLogout.BackgroundImageLayout = ImageLayout.Zoom;
            picLogout.Location = new Point(11, 1425);
            picLogout.Name = "picLogout";
            picLogout.Size = new Size(20, 20);
            picLogout.TabIndex = 11;
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
            btnLogout.Location = new Point(24, 1412);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(15, 0, 0, 0);
            btnLogout.Size = new Size(180, 40);
            btnLogout.TabIndex = 10;
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
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
            // btnOrderDetail
            // 
            btnOrderDetail.BackColor = Color.Transparent;
            btnOrderDetail.Cursor = Cursors.Hand;
            btnOrderDetail.FlatAppearance.BorderSize = 0;
            btnOrderDetail.FlatStyle = FlatStyle.Flat;
            btnOrderDetail.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOrderDetail.ForeColor = Color.White;
            btnOrderDetail.Location = new Point(21, 271);
            btnOrderDetail.Name = "btnOrderDetail";
            btnOrderDetail.Padding = new Padding(15, 0, 0, 0);
            btnOrderDetail.Size = new Size(160, 40);
            btnOrderDetail.TabIndex = 4;
            btnOrderDetail.Text = "Order Detail";
            btnOrderDetail.TextAlign = ContentAlignment.MiddleLeft;
            btnOrderDetail.UseVisualStyleBackColor = false;
            btnOrderDetail.Click += btnOrderDetail_Click;
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
            // lblTanggal
            // 
            lblTanggal.BackColor = Color.Transparent;
            lblTanggal.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTanggal.ForeColor = Color.Gray;
            lblTanggal.Location = new Point(251, 15);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(200, 29);
            lblTanggal.TabIndex = 17;
            lblTanggal.Text = "Senin, 01 Juni 2026";
            // 
            // lblOrder
            // 
            lblOrder.BackColor = Color.Transparent;
            lblOrder.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrder.ForeColor = Color.FromArgb(44, 62, 45);
            lblOrder.Location = new Point(251, 44);
            lblOrder.Name = "lblOrder";
            lblOrder.Size = new Size(472, 56);
            lblOrder.TabIndex = 18;
            lblOrder.Text = "Order";
            // 
            // pnlAvatar
            // 
            pnlAvatar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlAvatar.BackColor = Color.FromArgb(22, 101, 52);
            pnlAvatar.Controls.Add(lblTitle);
            pnlAvatar.Location = new Point(1929, 40);
            pnlAvatar.Name = "pnlAvatar";
            pnlAvatar.Size = new Size(40, 40);
            pnlAvatar.TabIndex = 20;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(5, 4);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(31, 32);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "U";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlSearch
            // 
            pnlSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlSearch.BackColor = Color.FromArgb(243, 247, 243);
            pnlSearch.BorderStyle = BorderStyle.FixedSingle;
            pnlSearch.Controls.Add(txtCariBibit);
            pnlSearch.Controls.Add(picSearch);
            pnlSearch.Location = new Point(1662, 40);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(250, 40);
            pnlSearch.TabIndex = 21;
            // 
            // txtCariBibit
            // 
            txtCariBibit.BorderStyle = BorderStyle.None;
            txtCariBibit.ForeColor = Color.Gray;
            txtCariBibit.Location = new Point(33, 6);
            txtCariBibit.Name = "txtCariBibit";
            txtCariBibit.PlaceholderText = "Cari Bibit...";
            txtCariBibit.Size = new Size(180, 24);
            txtCariBibit.TabIndex = 4;
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
            // lblJumlahOrder
            // 
            lblJumlahOrder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblJumlahOrder.AutoSize = true;
            lblJumlahOrder.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblJumlahOrder.ForeColor = Color.DarkSeaGreen;
            lblJumlahOrder.Location = new Point(1091, 16);
            lblJumlahOrder.Name = "lblJumlahOrder";
            lblJumlahOrder.Size = new Size(174, 28);
            lblJumlahOrder.TabIndex = 25;
            lblJumlahOrder.Text = "0 order ditemukan";
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(242, 247, 242);
            pnlContent.Controls.Add(pnlOrderContainer);
            pnlContent.Location = new Point(251, 170);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1450, 660);
            pnlContent.TabIndex = 26;
            // 
            // pnlOrderContainer
            // 
            pnlOrderContainer.BackColor = Color.White;
            pnlOrderContainer.Controls.Add(lblJudulOrder);
            pnlOrderContainer.Controls.Add(dgvOrder);
            pnlOrderContainer.Controls.Add(lblJumlahOrder);
            pnlOrderContainer.Location = new Point(105, 62);
            pnlOrderContainer.Name = "pnlOrderContainer";
            pnlOrderContainer.Size = new Size(1280, 520);
            pnlOrderContainer.TabIndex = 27;
            // 
            // lblJudulOrder
            // 
            lblJudulOrder.AutoSize = true;
            lblJudulOrder.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudulOrder.Location = new Point(25, 10);
            lblJudulOrder.Name = "lblJudulOrder";
            lblJudulOrder.Size = new Size(185, 38);
            lblJudulOrder.TabIndex = 28;
            lblJudulOrder.Text = "Daftar Order";
            // 
            // dgvOrder
            // 
            dgvOrder.AllowUserToAddRows = false;
            dgvOrder.AllowUserToDeleteRows = false;
            dgvOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Columns.AddRange(new DataGridViewColumn[] { colTanggal, colCustomer, colTotalOrder, colStatus, colDetail });
            dgvOrder.Location = new Point(24, 51);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersVisible = false;
            dgvOrder.RowHeadersWidth = 62;
            dgvOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrder.Size = new Size(1231, 450);
            dgvOrder.TabIndex = 0;
            dgvOrder.CellContentClick += dgvOrder_CellContentClick;
            // 
            // colTanggal
            // 
            colTanggal.HeaderText = "Tanggal";
            colTanggal.MinimumWidth = 8;
            colTanggal.Name = "colTanggal";
            // 
            // colCustomer
            // 
            colCustomer.HeaderText = "Customer";
            colCustomer.MinimumWidth = 8;
            colCustomer.Name = "colCustomer";
            // 
            // colTotalOrder
            // 
            colTotalOrder.HeaderText = "Total Order";
            colTotalOrder.MinimumWidth = 8;
            colTotalOrder.Name = "colTotalOrder";
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.Items.AddRange(new object[] { "Diproses", "Selesai" });
            colStatus.MinimumWidth = 8;
            colStatus.Name = "colStatus";
            // 
            // colDetail
            // 
            colDetail.HeaderText = "Detail Order";
            colDetail.MinimumWidth = 8;
            colDetail.Name = "colDetail";
            // 
            // pnlOverlay
            // 
            pnlOverlay.BackColor = Color.FromArgb(150, 0, 0, 0);
            pnlOverlay.Controls.Add(pnlPopupDetailOrder);
            pnlOverlay.Dock = DockStyle.Fill;
            pnlOverlay.Location = new Point(220, 0);
            pnlOverlay.Name = "pnlOverlay";
            pnlOverlay.Size = new Size(1780, 1500);
            pnlOverlay.TabIndex = 28;
            pnlOverlay.Visible = false;
            // 
            // pnlPopupDetailOrder
            // 
            pnlPopupDetailOrder.BackColor = Color.White;
            pnlPopupDetailOrder.Controls.Add(lblTotalDetailOrder);
            pnlPopupDetailOrder.Controls.Add(btnTutupDetail);
            pnlPopupDetailOrder.Controls.Add(dgvDetailOrder);
            pnlPopupDetailOrder.Controls.Add(lblDetailOrder);
            pnlPopupDetailOrder.Location = new Point(350, 150);
            pnlPopupDetailOrder.Name = "pnlPopupDetailOrder";
            pnlPopupDetailOrder.Size = new Size(950, 550);
            pnlPopupDetailOrder.TabIndex = 0;
            pnlPopupDetailOrder.Visible = false;
            // 
            // lblTotalDetailOrder
            // 
            lblTotalDetailOrder.AutoSize = true;
            lblTotalDetailOrder.Location = new Point(700, 450);
            lblTotalDetailOrder.Name = "lblTotalDetailOrder";
            lblTotalDetailOrder.Size = new Size(154, 25);
            lblTotalDetailOrder.TabIndex = 1;
            lblTotalDetailOrder.Text = "Total : Rp 100.000";
            // 
            // btnTutupDetail
            // 
            btnTutupDetail.Location = new Point(780, 490);
            btnTutupDetail.Name = "btnTutupDetail";
            btnTutupDetail.Size = new Size(120, 40);
            btnTutupDetail.TabIndex = 2;
            btnTutupDetail.Text = "Tutup";
            btnTutupDetail.UseVisualStyleBackColor = true;
            btnTutupDetail.Click += btnTutupDetail_Click;
            // 
            // dgvDetailOrder
            // 
            dgvDetailOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetailOrder.Columns.AddRange(new DataGridViewColumn[] { colFoto, colProduk, colHarga, colQty, colSubtotal });
            dgvDetailOrder.Location = new Point(25, 70);
            dgvDetailOrder.Name = "dgvDetailOrder";
            dgvDetailOrder.RowHeadersWidth = 62;
            dgvDetailOrder.Size = new Size(900, 360);
            dgvDetailOrder.TabIndex = 1;
            // 
            // colFoto
            // 
            colFoto.HeaderText = "Foto";
            colFoto.MinimumWidth = 8;
            colFoto.Name = "colFoto";
            colFoto.Width = 150;
            // 
            // colProduk
            // 
            colProduk.HeaderText = "Produk";
            colProduk.MinimumWidth = 8;
            colProduk.Name = "colProduk";
            colProduk.Width = 150;
            // 
            // colHarga
            // 
            colHarga.HeaderText = "Harga";
            colHarga.MinimumWidth = 8;
            colHarga.Name = "colHarga";
            colHarga.Width = 150;
            // 
            // colQty
            // 
            colQty.HeaderText = "Qty";
            colQty.MinimumWidth = 8;
            colQty.Name = "colQty";
            colQty.Width = 150;
            // 
            // colSubtotal
            // 
            colSubtotal.HeaderText = "Subtotal";
            colSubtotal.MinimumWidth = 8;
            colSubtotal.Name = "colSubtotal";
            colSubtotal.Width = 150;
            // 
            // lblDetailOrder
            // 
            lblDetailOrder.AutoSize = true;
            lblDetailOrder.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetailOrder.Location = new Point(25, 20);
            lblDetailOrder.Name = "lblDetailOrder";
            lblDetailOrder.Size = new Size(204, 45);
            lblDetailOrder.TabIndex = 0;
            lblDetailOrder.Text = "Detail Order";
            // 
            // UCOrderDetailKaryawan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlSearch);
            Controls.Add(pnlAvatar);
            Controls.Add(lblOrder);
            Controls.Add(lblTanggal);
            Controls.Add(pnlContent);
            Controls.Add(pnlOverlay);
            Controls.Add(pnlSidebar);
            Name = "UCOrderDetailKaryawan";
            Size = new Size(2000, 1500);
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRiwayat).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDashboard).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlAvatar.ResumeLayout(false);
            pnlAvatar.PerformLayout();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSearch).EndInit();
            pnlContent.ResumeLayout(false);
            pnlOrderContainer.ResumeLayout(false);
            pnlOrderContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            pnlOverlay.ResumeLayout(false);
            pnlPopupDetailOrder.ResumeLayout(false);
            pnlPopupDetailOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetailOrder).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private PictureBox picRiwayat;
        private PictureBox picDashboard;
        private Button btnDashboard;
        private Button btnOrderDetail;
        private Label lblTagline;
        private PictureBox picLogo;
        private Button btnLogout;
        private PictureBox picLogout;
        private Label lblTanggal;
        private Label lblOrder;
        private Panel pnlAvatar;
        private Label lblTitle;
        private Panel pnlSearch;
        private TextBox txtCariBibit;
        private PictureBox picSearch;
        private Label lblJumlahOrder;
        private Panel pnlContent;
        private Panel pnlOrderContainer;
        private Label lblJudulOrder;
        private DataGridView dgvOrder;
        private Panel pnlOverlay;
        private Panel pnlPopupDetailOrder;
        private Label lblDetailOrder;
        private Label lblTotalDetailOrder;
        private Button btnTutupDetail;
        private DataGridView dgvDetailOrder;
        private DataGridViewImageColumn colFoto;
        private DataGridViewTextBoxColumn colProduk;
        private DataGridViewTextBoxColumn colHarga;
        private DataGridViewTextBoxColumn colQty;
        private DataGridViewTextBoxColumn colSubtotal;
        private DataGridViewTextBoxColumn colTanggal;
        private DataGridViewTextBoxColumn colCustomer;
        private DataGridViewTextBoxColumn colTotalOrder;
        private DataGridViewComboBoxColumn colStatus;
        private DataGridViewButtonColumn colDetail;
        private Label lblLogo;
        private Button btnRestock;
        private PictureBox pictureBox1;
    }
}
