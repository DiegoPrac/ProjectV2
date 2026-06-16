namespace MyBibit.UserControls
{
    partial class UCRestockAdmin
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
            picLogout = new PictureBox();
            btnLogout = new Button();
            picKaryawan = new PictureBox();
            picDashboard = new PictureBox();
            btnDashboard = new Button();
            btnKaryawan = new Button();
            lblTagline = new Label();
            lblLogo = new Label();
            picLogo = new PictureBox();
            lblTanggal = new Label();
            lblWelcome = new Label();
            pnlSearch = new Panel();
            txtCariKaryawan = new TextBox();
            picSearch = new PictureBox();
            pnlAvatar = new Panel();
            lblInitial = new Label();
            pnlOrderContainer = new Panel();
            lblJudulOrder = new Label();
            dgvRestock = new DataGridView();
            colTanggal = new DataGridViewTextBoxColumn();
            colKaryawan = new DataGridViewTextBoxColumn();
            colTotalRestock = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colDetail = new DataGridViewButtonColumn();
            lblJumlahOrder = new Label();
            pnlOverlay = new Panel();
            btnTutupSupplier = new Button();
            pnlPopupDetailRestock = new Panel();
            dgvDetailRestock = new DataGridView();
            lblJudulDetailRestock = new Label();
            btnTutupDetail = new Button();
            pnlFooter = new Panel();
            btnSupplier = new Button();
            pnlPopupSupplier = new Panel();
            lblJudulSupplier = new Label();
            dgvSupplier = new DataGridView();
            colFoto = new DataGridViewImageColumn();
            colProduk = new DataGridViewTextBoxColumn();
            colHarga = new DataGridViewTextBoxColumn();
            colKuantitas = new DataGridViewTextBoxColumn();
            colSubtotal = new DataGridViewTextBoxColumn();
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picKaryawan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDashboard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSearch).BeginInit();
            pnlAvatar.SuspendLayout();
            pnlOrderContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRestock).BeginInit();
            pnlPopupDetailRestock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetailRestock).BeginInit();
            pnlFooter.SuspendLayout();
            pnlPopupSupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSupplier).BeginInit();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(18, 96, 48);
            pnlSidebar.Controls.Add(pictureBox1);
            pnlSidebar.Controls.Add(btnRestock);
            pnlSidebar.Controls.Add(picLogout);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(picKaryawan);
            pnlSidebar.Controls.Add(picDashboard);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(btnKaryawan);
            pnlSidebar.Controls.Add(lblTagline);
            pnlSidebar.Controls.Add(lblLogo);
            pnlSidebar.Controls.Add(picLogo);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(220, 3000);
            pnlSidebar.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Restock;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(11, 331);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.TabIndex = 16;
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
            btnRestock.TabIndex = 15;
            btnRestock.Text = "Restock";
            btnRestock.TextAlign = ContentAlignment.MiddleLeft;
            btnRestock.UseVisualStyleBackColor = false;
            btnRestock.Click += btnRestock_Click;
            // 
            // picLogout
            // 
            picLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            picLogout.BackColor = Color.Transparent;
            picLogout.BackgroundImage = Properties.Resources._out;
            picLogout.BackgroundImageLayout = ImageLayout.Zoom;
            picLogout.Location = new Point(11, 2925);
            picLogout.Name = "picLogout";
            picLogout.Size = new Size(20, 20);
            picLogout.TabIndex = 14;
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
            btnLogout.Location = new Point(24, 2912);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(15, 0, 0, 0);
            btnLogout.Size = new Size(180, 40);
            btnLogout.TabIndex = 13;
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // picKaryawan
            // 
            picKaryawan.BackColor = Color.Transparent;
            picKaryawan.BackgroundImage = Properties.Resources.out__1_;
            picKaryawan.BackgroundImageLayout = ImageLayout.Zoom;
            picKaryawan.Location = new Point(11, 283);
            picKaryawan.Name = "picKaryawan";
            picKaryawan.Size = new Size(20, 20);
            picKaryawan.TabIndex = 7;
            picKaryawan.TabStop = false;
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
            // btnKaryawan
            // 
            btnKaryawan.BackColor = Color.Transparent;
            btnKaryawan.Cursor = Cursors.Hand;
            btnKaryawan.FlatAppearance.BorderSize = 0;
            btnKaryawan.FlatStyle = FlatStyle.Flat;
            btnKaryawan.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKaryawan.ForeColor = Color.White;
            btnKaryawan.Location = new Point(21, 271);
            btnKaryawan.Name = "btnKaryawan";
            btnKaryawan.Padding = new Padding(15, 0, 0, 0);
            btnKaryawan.Size = new Size(160, 40);
            btnKaryawan.TabIndex = 4;
            btnKaryawan.Text = "Karyawan";
            btnKaryawan.TextAlign = ContentAlignment.MiddleLeft;
            btnKaryawan.UseVisualStyleBackColor = false;
            btnKaryawan.Click += btnKaryawan_Click;
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
            // lblTanggal
            // 
            lblTanggal.BackColor = Color.Transparent;
            lblTanggal.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTanggal.ForeColor = Color.Gray;
            lblTanggal.Location = new Point(251, 15);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(200, 29);
            lblTanggal.TabIndex = 20;
            lblTanggal.Text = "Senin, 01 Juni 2026";
            // 
            // lblWelcome
            // 
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.FromArgb(44, 62, 45);
            lblWelcome.Location = new Point(251, 44);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(472, 56);
            lblWelcome.TabIndex = 21;
            lblWelcome.Text = "Selamat Datang, Admin";
            // 
            // pnlSearch
            // 
            pnlSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlSearch.BackColor = Color.FromArgb(243, 247, 243);
            pnlSearch.BorderStyle = BorderStyle.FixedSingle;
            pnlSearch.Controls.Add(txtCariKaryawan);
            pnlSearch.Controls.Add(picSearch);
            pnlSearch.Location = new Point(3662, 40);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(250, 40);
            pnlSearch.TabIndex = 45;
            // 
            // txtCariKaryawan
            // 
            txtCariKaryawan.BorderStyle = BorderStyle.None;
            txtCariKaryawan.ForeColor = Color.Gray;
            txtCariKaryawan.Location = new Point(33, 6);
            txtCariKaryawan.Name = "txtCariKaryawan";
            txtCariKaryawan.PlaceholderText = "Cari Bibit...";
            txtCariKaryawan.Size = new Size(180, 24);
            txtCariKaryawan.TabIndex = 4;
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
            pnlAvatar.Location = new Point(3929, 40);
            pnlAvatar.Name = "pnlAvatar";
            pnlAvatar.Size = new Size(40, 40);
            pnlAvatar.TabIndex = 44;
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
            // pnlOrderContainer
            // 
            pnlOrderContainer.BackColor = Color.White;
            pnlOrderContainer.Controls.Add(lblJudulOrder);
            pnlOrderContainer.Controls.Add(dgvRestock);
            pnlOrderContainer.Controls.Add(lblJumlahOrder);
            pnlOrderContainer.Location = new Point(251, 155);
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
            lblJudulOrder.Size = new Size(211, 38);
            lblJudulOrder.TabIndex = 28;
            lblJudulOrder.Text = "Daftar Restock";
            // 
            // dgvRestock
            // 
            dgvRestock.AllowUserToAddRows = false;
            dgvRestock.AllowUserToDeleteRows = false;
            dgvRestock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRestock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRestock.Columns.AddRange(new DataGridViewColumn[] { colTanggal, colKaryawan, colTotalRestock, colStatus, colDetail });
            dgvRestock.Location = new Point(24, 51);
            dgvRestock.Name = "dgvRestock";
            dgvRestock.ReadOnly = true;
            dgvRestock.RowHeadersVisible = false;
            dgvRestock.RowHeadersWidth = 62;
            dgvRestock.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvRestock.Size = new Size(1231, 450);
            dgvRestock.TabIndex = 0;
            dgvRestock.CellContentClick += dgvRestock_CellContentClick;
            // 
            // colTanggal
            // 
            colTanggal.HeaderText = "Tanggal";
            colTanggal.MinimumWidth = 8;
            colTanggal.Name = "colTanggal";
            colTanggal.ReadOnly = true;
            // 
            // colKaryawan
            // 
            colKaryawan.HeaderText = "Karyawan";
            colKaryawan.MinimumWidth = 8;
            colKaryawan.Name = "colKaryawan";
            colKaryawan.ReadOnly = true;
            // 
            // colTotalRestock
            // 
            colTotalRestock.HeaderText = "Total Restock";
            colTotalRestock.MinimumWidth = 8;
            colTotalRestock.Name = "colTotalRestock";
            colTotalRestock.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 8;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // colDetail
            // 
            colDetail.HeaderText = "Detail";
            colDetail.MinimumWidth = 8;
            colDetail.Name = "colDetail";
            colDetail.ReadOnly = true;
            // 
            // lblJumlahOrder
            // 
            lblJumlahOrder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblJumlahOrder.AutoSize = true;
            lblJumlahOrder.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblJumlahOrder.ForeColor = Color.DarkSeaGreen;
            lblJumlahOrder.Location = new Point(2171, 16);
            lblJumlahOrder.Name = "lblJumlahOrder";
            lblJumlahOrder.Size = new Size(174, 28);
            lblJumlahOrder.TabIndex = 25;
            lblJumlahOrder.Text = "0 order ditemukan";
            // 
            // pnlOverlay
            // 
            pnlOverlay.BackColor = Color.Gray;
            pnlOverlay.Location = new Point(1684, 331);
            pnlOverlay.Name = "pnlOverlay";
            pnlOverlay.Size = new Size(472, 305);
            pnlOverlay.TabIndex = 46;
            // 
            // btnTutupSupplier
            // 
            btnTutupSupplier.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTutupSupplier.BackColor = Color.Gray;
            btnTutupSupplier.ForeColor = Color.DarkGreen;
            btnTutupSupplier.Location = new Point(877, 3);
            btnTutupSupplier.Name = "btnTutupSupplier";
            btnTutupSupplier.Size = new Size(112, 34);
            btnTutupSupplier.TabIndex = 49;
            btnTutupSupplier.Text = "Tutup";
            btnTutupSupplier.UseVisualStyleBackColor = false;
            btnTutupSupplier.Click += btnTutupSupplier_Click;
            // 
            // pnlPopupDetailRestock
            // 
            pnlPopupDetailRestock.Controls.Add(dgvDetailRestock);
            pnlPopupDetailRestock.Controls.Add(lblJudulDetailRestock);
            pnlPopupDetailRestock.Controls.Add(btnTutupDetail);
            pnlPopupDetailRestock.Location = new Point(226, 700);
            pnlPopupDetailRestock.Name = "pnlPopupDetailRestock";
            pnlPopupDetailRestock.Size = new Size(1000, 520);
            pnlPopupDetailRestock.TabIndex = 47;
            // 
            // dgvDetailRestock
            // 
            dgvDetailRestock.AllowUserToAddRows = false;
            dgvDetailRestock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetailRestock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetailRestock.Columns.AddRange(new DataGridViewColumn[] { colFoto, colProduk, colHarga, colKuantitas, colSubtotal });
            dgvDetailRestock.Location = new Point(40, 80);
            dgvDetailRestock.Name = "dgvDetailRestock";
            dgvDetailRestock.ReadOnly = true;
            dgvDetailRestock.RowHeadersVisible = false;
            dgvDetailRestock.RowHeadersWidth = 62;
            dgvDetailRestock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetailRestock.Size = new Size(920, 360);
            dgvDetailRestock.TabIndex = 49;
            // 
            // lblJudulDetailRestock
            // 
            lblJudulDetailRestock.AutoSize = true;
            lblJudulDetailRestock.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudulDetailRestock.Location = new Point(40, 39);
            lblJudulDetailRestock.Name = "lblJudulDetailRestock";
            lblJudulDetailRestock.Size = new Size(204, 38);
            lblJudulDetailRestock.TabIndex = 29;
            lblJudulDetailRestock.Text = "Detail Restock";
            // 
            // btnTutupDetail
            // 
            btnTutupDetail.BackColor = Color.Gray;
            btnTutupDetail.ForeColor = Color.DarkGreen;
            btnTutupDetail.Location = new Point(850, 25);
            btnTutupDetail.Name = "btnTutupDetail";
            btnTutupDetail.Size = new Size(112, 34);
            btnTutupDetail.TabIndex = 48;
            btnTutupDetail.Text = "Tutup";
            btnTutupDetail.UseVisualStyleBackColor = false;
            btnTutupDetail.Click += btnTutupDetail_Click;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.White;
            pnlFooter.Controls.Add(btnSupplier);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(220, 2910);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(3780, 90);
            pnlFooter.TabIndex = 48;
            // 
            // btnSupplier
            // 
            btnSupplier.BackColor = Color.FromArgb(164, 190, 164);
            btnSupplier.FlatAppearance.BorderSize = 0;
            btnSupplier.FlatStyle = FlatStyle.Flat;
            btnSupplier.ForeColor = Color.White;
            btnSupplier.Location = new Point(1610, 30);
            btnSupplier.Name = "btnSupplier";
            btnSupplier.Size = new Size(112, 34);
            btnSupplier.TabIndex = 3;
            btnSupplier.Text = "Supplier";
            btnSupplier.UseVisualStyleBackColor = false;
            btnSupplier.Click += btnSupplier_Click;
            // 
            // pnlPopupSupplier
            // 
            pnlPopupSupplier.Controls.Add(lblJudulSupplier);
            pnlPopupSupplier.Controls.Add(btnTutupSupplier);
            pnlPopupSupplier.Controls.Add(dgvSupplier);
            pnlPopupSupplier.Location = new Point(1222, 760);
            pnlPopupSupplier.Name = "pnlPopupSupplier";
            pnlPopupSupplier.Size = new Size(1012, 618);
            pnlPopupSupplier.TabIndex = 49;
            // 
            // lblJudulSupplier
            // 
            lblJudulSupplier.AutoSize = true;
            lblJudulSupplier.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudulSupplier.Location = new Point(34, 3);
            lblJudulSupplier.Name = "lblJudulSupplier";
            lblJudulSupplier.Size = new Size(126, 38);
            lblJudulSupplier.TabIndex = 49;
            lblJudulSupplier.Text = "Supplier";
            // 
            // dgvSupplier
            // 
            dgvSupplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSupplier.Location = new Point(34, 43);
            dgvSupplier.Name = "dgvSupplier";
            dgvSupplier.RowHeadersWidth = 62;
            dgvSupplier.Size = new Size(955, 552);
            dgvSupplier.TabIndex = 0;
            // 
            // colFoto
            // 
            colFoto.HeaderText = "Foto";
            colFoto.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colFoto.MinimumWidth = 8;
            colFoto.Name = "colFoto";
            colFoto.ReadOnly = true;
            // 
            // colProduk
            // 
            colProduk.HeaderText = "Produk";
            colProduk.MinimumWidth = 8;
            colProduk.Name = "colProduk";
            colProduk.ReadOnly = true;
            // 
            // colHarga
            // 
            colHarga.HeaderText = "Harga";
            colHarga.MinimumWidth = 8;
            colHarga.Name = "colHarga";
            colHarga.ReadOnly = true;
            // 
            // colKuantitas
            // 
            colKuantitas.HeaderText = "Kuantitas";
            colKuantitas.MinimumWidth = 8;
            colKuantitas.Name = "colKuantitas";
            colKuantitas.ReadOnly = true;
            // 
            // colSubtotal
            // 
            colSubtotal.HeaderText = "Subtotal";
            colSubtotal.MinimumWidth = 8;
            colSubtotal.Name = "colSubtotal";
            colSubtotal.ReadOnly = true;
            // 
            // UCRestockAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlPopupSupplier);
            Controls.Add(pnlFooter);
            Controls.Add(pnlPopupDetailRestock);
            Controls.Add(pnlOverlay);
            Controls.Add(pnlOrderContainer);
            Controls.Add(pnlAvatar);
            Controls.Add(pnlSearch);
            Controls.Add(lblWelcome);
            Controls.Add(lblTanggal);
            Controls.Add(pnlSidebar);
            Name = "UCRestockAdmin";
            Size = new Size(4000, 3000);
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)picKaryawan).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDashboard).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSearch).EndInit();
            pnlAvatar.ResumeLayout(false);
            pnlAvatar.PerformLayout();
            pnlOrderContainer.ResumeLayout(false);
            pnlOrderContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRestock).EndInit();
            pnlPopupDetailRestock.ResumeLayout(false);
            pnlPopupDetailRestock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetailRestock).EndInit();
            pnlFooter.ResumeLayout(false);
            pnlPopupSupplier.ResumeLayout(false);
            pnlPopupSupplier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSupplier).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private PictureBox picKaryawan;
        private PictureBox picDashboard;
        private Button btnDashboard;
        private Button btnKaryawan;
        private Label lblTagline;
        private Label lblLogo;
        private PictureBox picLogo;
        private Button btnLogout;
        private PictureBox picLogout;
        private PictureBox pictureBox1;
        private Button btnRestock;
        private Label lblTanggal;
        private Label lblWelcome;
        private Panel pnlSearch;
        private TextBox txtCariKaryawan;
        private PictureBox picSearch;
        private Panel pnlAvatar;
        private Label lblInitial;
        private Panel pnlOrderContainer;
        private Label lblJudulOrder;
        private DataGridView dgvRestock;
        private Label lblJumlahOrder;
        private Panel pnlOverlay;
        private Panel pnlPopupDetailRestock;
        private Button btnTutupDetail;
        private Panel pnlFooter;
        private Button btnSupplier;
        private Panel pnlPopupSupplier;
        private Button btnTutupSupplier;
        private DataGridView dgvSupplier;
        private DataGridViewTextBoxColumn colTanggal;
        private DataGridViewTextBoxColumn colKaryawan;
        private DataGridViewTextBoxColumn colTotalRestock;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewButtonColumn colDetail;
        private Label lblJudulDetailRestock;
        private Label lblJudulSupplier;
        private DataGridView dgvDetailRestock;
        private DataGridViewImageColumn colFoto;
        private DataGridViewTextBoxColumn colProduk;
        private DataGridViewTextBoxColumn colHarga;
        private DataGridViewTextBoxColumn colKuantitas;
        private DataGridViewTextBoxColumn colSubtotal;
    }
}
