using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using MyBibit.Controllers;

namespace MyBibit.UserControls
{
    public partial class UCAdminDashboard : UserControl
    {
        private string kategoriAktif = "Semua";
        private Panel pnlOverlay;
        private Panel pnlLaporan;
        private Panel pnlDetail;
        private DataGridView dgvLaporan;
        private DataGridView dgvDetail;

        public UCAdminDashboard()
        {
            InitializeComponent();

            lblTanggal.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy", new CultureInfo("id-ID"));
            string namaDepan = Session.Username.Split(' ')[0];
            lblWelcome.Text = "Selamat Datang, " + namaDepan;
            lblInitial.Text = namaDepan.Substring(0, 1).ToUpper();
            txtCariBibit.TextChanged += txtCariBibit_TextChanged;

            btnSemua.Click += (s, e) => { kategoriAktif = "Semua"; LoadProduk(txtCariBibit.Text); };
            btnBuah.Click += (s, e) => { kategoriAktif = "Buah"; LoadProduk(txtCariBibit.Text); };
            btnSayur.Click += (s, e) => { kategoriAktif = "Sayur"; LoadProduk(txtCariBibit.Text); };

            btnLogout.Click += (s, e) =>
            {
                FormMain main = this.FindForm() as FormMain;
                if (main != null) main.LoadLogin();
            };

            btnLaporanPenjualan.Click += (s, e) => TampilkanPopupLaporan();

            btnKaryawan.Click += (s, e) =>
            {
                FormMain main = this.FindForm() as FormMain;
                if (main != null) main.LoadPage(new UCKaryawanAdmin());
            };

            BuatPopupLaporan();
            LoadProduk();
            LoadTotalPenjualan();
            LoadGrafikPenjualan();
        }

        private string FormatRupiah(int angka)
        {
            return "Rp " + angka.ToString("N0", new CultureInfo("id-ID"));
        }

        private void LoadTotalPenjualan()
        {
            lblTotalPenjualan.Text =
                "Total Penjualan " +
                DateTime.Now.ToString("MMMM yyyy", new CultureInfo("id-ID"));

            int total = OrderController.AmbilTotalPenjualanBulanIni();
            lblNominalPenjualan.Text = FormatRupiah(total);
        }

        private void LoadGrafikPenjualan()
        {
            DataTable dt = OrderController.AmbilPenjualanPerBulan();
            double[] values = new double[12];

            foreach (DataRow row in dt.Rows)
            {
                int bulan = Convert.ToInt32(row["bulan"]);
                double total = Convert.ToDouble(row["total"]);
                values[bulan - 1] = total;
            }

            formsPlotPenjualan.Plot.Clear();

            var bar = formsPlotPenjualan.Plot.Add.Bars(values);

            foreach (var b in bar.Bars)
            {
                b.FillColor = ScottPlot.Colors.ForestGreen;
            }

            formsPlotPenjualan.Plot.Title("Grafik Penjualan Tahun Ini");
            formsPlotPenjualan.Plot.YLabel("Total Penjualan");

            formsPlotPenjualan.Plot.Axes.Bottom.TickGenerator =
                new ScottPlot.TickGenerators.NumericManual(
                    new double[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 },
                    new string[] { "Jan", "Feb", "Mar", "Apr", "Mei", "Jun", "Jul", "Agu", "Sep", "Okt", "Nov", "Des" }
                );

            formsPlotPenjualan.Refresh();
        }

        private void BuatPopupLaporan()
        {
            pnlOverlay = new Panel();
            pnlOverlay.Dock = DockStyle.Fill;
            pnlOverlay.BackColor = Color.FromArgb(160, 0, 0, 0);
            pnlOverlay.Visible = false;
            Controls.Add(pnlOverlay);

            pnlLaporan = new Panel();
            pnlLaporan.Size = new Size(900, 500);
            pnlLaporan.BackColor = Color.White;
            pnlLaporan.Visible = false;
            Controls.Add(pnlLaporan);

            Label title = new Label();
            title.Text = "Detail Order";
            title.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            title.Location = new Point(25, 20);
            title.AutoSize = true;

            Button btnTutup = new Button();
            btnTutup.Text = "Tutup";
            btnTutup.Size = new Size(100, 35);
            btnTutup.Location = new Point(770, 20);
            btnTutup.Click += (s, e) =>
            {
                pnlLaporan.Visible = false;
                pnlOverlay.Visible = false;
            };

            dgvLaporan = new DataGridView();
            dgvLaporan.Location = new Point(25, 75);
            dgvLaporan.Size = new Size(850, 390);
            dgvLaporan.ReadOnly = true;
            dgvLaporan.AllowUserToAddRows = false;
            dgvLaporan.RowHeadersVisible = false;
            dgvLaporan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            pnlLaporan.Controls.Add(title);
            pnlLaporan.Controls.Add(btnTutup);
            pnlLaporan.Controls.Add(dgvLaporan);

            pnlDetail = new Panel();
            pnlDetail.Size = new Size(750, 420);
            pnlDetail.BackColor = Color.White;
            pnlDetail.Visible = false;
            Controls.Add(pnlDetail);

            Label titleDetail = new Label();
            titleDetail.Text = "Detail Produk Order";
            titleDetail.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            titleDetail.Location = new Point(25, 20);
            titleDetail.AutoSize = true;

            Button btnTutupDetail = new Button();
            btnTutupDetail.Text = "Kembali";
            btnTutupDetail.Size = new Size(100, 35);
            btnTutupDetail.Location = new Point(620, 20);
            btnTutupDetail.Click += (s, e) =>
            {
                pnlDetail.Visible = false;
                pnlLaporan.Visible = true;
                pnlLaporan.BringToFront();
            };

            dgvDetail = new DataGridView();
            dgvDetail.Location = new Point(25, 75);
            dgvDetail.Size = new Size(700, 310);
            dgvDetail.ReadOnly = true;
            dgvDetail.AllowUserToAddRows = false;
            dgvDetail.RowHeadersVisible = false;
            dgvDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            pnlDetail.Controls.Add(titleDetail);
            pnlDetail.Controls.Add(btnTutupDetail);
            pnlDetail.Controls.Add(dgvDetail);
        }

        private void TampilkanPopupLaporan()
        {
            pnlOverlay.Visible = true;
            pnlLaporan.Visible = true;
            pnlLaporan.Location = new Point((Width - pnlLaporan.Width) / 2, (Height - pnlLaporan.Height) / 2);

            DataTable dt = OrderController.AmbilSemuaOrderAdmin();

            dgvLaporan.Columns.Clear();
            dgvLaporan.DataSource = dt;

            if (dgvLaporan.Columns["id"] != null)
                dgvLaporan.Columns["id"].Visible = false;

            dgvLaporan.RowTemplate.Height = 35;
            dgvLaporan.AllowUserToResizeRows = false;
            dgvLaporan.AllowUserToResizeColumns = false;
            dgvLaporan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            DataGridViewButtonColumn btnLihat = new DataGridViewButtonColumn();
            btnLihat.Name = "lihat";
            btnLihat.HeaderText = "Detail Order";
            btnLihat.Text = "Lihat";
            btnLihat.UseColumnTextForButtonValue = true;
            dgvLaporan.Columns.Add(btnLihat);

            dgvLaporan.CellClick -= DgvLaporan_CellClick;
            dgvLaporan.CellClick += DgvLaporan_CellClick;

            pnlOverlay.BringToFront();
            pnlLaporan.BringToFront();
        }

        private void DgvLaporan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvLaporan.Columns[e.ColumnIndex].Name != "lihat") return;

            int idOrder = Convert.ToInt32(dgvLaporan.Rows[e.RowIndex].Cells["id"].Value);

            DataTable dtDetail = OrderController.AmbilDetailOrder(idOrder);

            DataTable dtTampil = new DataTable();
            dtTampil.Columns.Add("Foto", typeof(Image));
            dtTampil.Columns.Add("Produk");
            dtTampil.Columns.Add("Harga");
            dtTampil.Columns.Add("Qty");
            dtTampil.Columns.Add("Subtotal");

            foreach (DataRow row in dtDetail.Rows)
            {
                string foto = row["foto"].ToString();
                string pathFoto = Path.Combine(Application.StartupPath, "Images", foto);

                Image img = null;
                if (File.Exists(pathFoto))
                    img = Image.FromFile(pathFoto);

                dtTampil.Rows.Add(
                    img,
                    row["produk"].ToString(),
                    FormatRupiah(Convert.ToInt32(row["harga"])),
                    row["kuantitas"].ToString(),
                    FormatRupiah(Convert.ToInt32(row["subtotal"]))
                );
            }

            dgvDetail.DataSource = dtTampil;
            dgvDetail.RowTemplate.Height = 70;
            dgvDetail.AllowUserToResizeRows = false;
            dgvDetail.AllowUserToResizeColumns = false;

            if (dgvDetail.Columns["Foto"] is DataGridViewImageColumn imgCol)
            {
                imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            }

            pnlDetail.Location = new Point((Width - pnlDetail.Width) / 2, (Height - pnlDetail.Height) / 2);
            pnlLaporan.Visible = false;
            pnlDetail.Visible = true;
            pnlDetail.BringToFront();
        }
        private DateTime? AmbilExpired(DataRow row)
        {
            if (row["tanggal_expired"] == DBNull.Value)
                return null;

            if (row["tanggal_expired"] is DateOnly tgl)
                return tgl.ToDateTime(TimeOnly.MinValue);

            return Convert.ToDateTime(row["tanggal_expired"]);
        }

        private void LoadProduk(string keyword = "")
        {
            pnlDaftarProduk.Controls.Clear();
            pnlDaftarProduk.AutoScroll = true;

            DataTable dt = ProdukController.AmbilSemuaProduk();

            int totalStok = 0;
            int jumlahProduk = 0;
            int x = 0, y = 0, kolom = 0;

            keyword = keyword.Trim().ToLower();

            foreach (DataRow row in dt.Rows)
            {
                string nama = row["nama"].ToString();
                int harga = Convert.ToInt32(row["harga"]);
                int stok = Convert.ToInt32(row["kuantitas"]);
                string foto = row["foto"].ToString();
                string kategori = row["kategori"].ToString();
                DateTime? expired = AmbilExpired(row);

                bool cocokSearch =
                    keyword == "" ||
                    nama.ToLower().Contains(keyword) ||
                    harga.ToString().Contains(keyword) ||
                    stok.ToString().Contains(keyword);

                bool cocokKategori =
                    kategoriAktif == "Semua" ||
                    kategori == kategoriAktif;

                if (!cocokSearch || !cocokKategori) continue;

                totalStok += stok;
                jumlahProduk++;

                Panel card = BuatCardProduk(nama, harga, stok, foto, expired);
                card.Location = new Point(x, y);
                pnlDaftarProduk.Controls.Add(card);

                kolom++;
                x += 330;

                if (kolom == 3)
                {
                    kolom = 0;
                    x = 0;
                    y += 335;
                }
            }

            lblTotalBibit.Text = jumlahProduk.ToString();
            lblStokTersedia.Text = totalStok.ToString();
            lblJumlahBibit.Text = jumlahProduk + " bibit ditemukan";
        }

        private Panel BuatCardProduk(string nama, int harga, int stok, string foto, DateTime? expired)
        {
            Panel card = new Panel();
            card.Size = new Size(300, 290);
            card.BackColor = Color.White;
            card.BorderStyle = BorderStyle.FixedSingle;

            PictureBox pic = new PictureBox();
            pic.Location = new Point(0, 0);
            pic.Size = new Size(300, 160);
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.BackColor = Color.FromArgb(245, 248, 245);

            string pathFoto = Path.Combine(Application.StartupPath, "Images", foto);
            if (File.Exists(pathFoto))
                pic.Image = Image.FromFile(pathFoto);

            Label lblStatusExpired = new Label();
            lblStatusExpired.AutoSize = true;
            lblStatusExpired.BackColor = Color.White;
            lblStatusExpired.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            lblStatusExpired.Location = new Point(18, 10);

            if (expired == null)
            {
                lblStatusExpired.Text = "Tidak Ada Exp";
                lblStatusExpired.ForeColor = Color.Gray;
            }
            else if (expired.Value.Date < DateTime.Now.Date)
            {
                lblStatusExpired.Text = "Expired";
                lblStatusExpired.ForeColor = Color.Red;
            }
            else if ((expired.Value.Date - DateTime.Now.Date).TotalDays <= 30)
            {
                lblStatusExpired.Text = "Hampir Expired";
                lblStatusExpired.ForeColor = Color.Orange;
            }
            else
            {
                lblStatusExpired.Text = "Aman";
                lblStatusExpired.ForeColor = Color.Green;
            }

            Label lblStok = new Label();
            lblStok.Text = "Stok: " + stok;
            lblStok.AutoSize = true;
            lblStok.BackColor = Color.White;
            lblStok.ForeColor = stok <= 0 ? Color.Red : Color.Green;
            lblStok.Location = new Point(220, 10);

            Label lblNama = new Label();
            lblNama.Text = nama;
            lblNama.AutoSize = true;
            lblNama.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblNama.Location = new Point(18, 180);

            Label lblHarga = new Label();
            lblHarga.Text = FormatRupiah(harga);
            lblHarga.AutoSize = true;
            lblHarga.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblHarga.ForeColor = Color.Green;
            lblHarga.Location = new Point(18, 215);

            card.Controls.Add(pic);
            pic.Controls.Add(lblStatusExpired);
            pic.Controls.Add(lblStok);
            card.Controls.Add(lblNama);
            card.Controls.Add(lblHarga);

            lblStatusExpired.BringToFront();
            lblStok.BringToFront();

            return card;
        } 

        private void txtCariBibit_TextChanged(object sender, EventArgs e)
        {
            LoadProduk(txtCariBibit.Text);
        }

        private void lblWelcome_Click(object sender, EventArgs e) { }
    }
}