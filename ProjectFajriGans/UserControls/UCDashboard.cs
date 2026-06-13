using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using MyBibit.Controllers;

namespace MyBibit.UserControls
{
    public partial class UCDashboard : UserControl
    {
        public event Action PindahKeCheckout = delegate { };
        public event Action PindahKeRiwayat = delegate { };

        private Dictionary<int, int> keranjang = new Dictionary<int, int>();

        private string kategoriAktif = "Semua";

        public Dictionary<int, int> Keranjang => keranjang;

        // sementara biar FormMain lama nggak error
        public int JumlahMangga => 0;
        public int JumlahCabai => 0;
        public int JumlahJambu => 0;
        public int JumlahJeruk => 0;
        public int JumlahAlpukat => 0;
        public int JumlahRambutan => 0;

        public UCDashboard()
        {
            InitializeComponent();
            string namaDepan = Session.Username.Split(' ')[0];

            lblWelcome.Text = "Selamat Datang, " + namaDepan;
            lblInitial.Text = namaDepan.Substring(0, 1).ToUpper();

            this.AutoScroll = true;
            pnlContent.AutoScroll = true;

            lblTanggal.Text = DateTime.Now.ToString(
                "dddd, dd MMMM yyyy",
                new CultureInfo("id-ID")
            );

            txtCariBibit.TextChanged += txtCariBibit_TextChanged;

            btnSemua.Click += (s, e) =>
            {
                kategoriAktif = "Semua";
                LoadProduk(txtCariBibit.Text);
            };

            btnBuah.Click += (s, e) =>
            {
                kategoriAktif = "Buah";
                LoadProduk(txtCariBibit.Text);
            };

            btnSayur.Click += (s, e) =>
            {
                kategoriAktif = "Sayur";
                LoadProduk(txtCariBibit.Text);
            };

            LoadProduk();
        }

        private string FormatRupiah(int angka)
        {
            return "Rp " + angka.ToString("N0", new CultureInfo("id-ID"));
        }

        private void LoadProduk()
        {
            LoadProduk("");
        }

        private void LoadProduk(string keyword)
        
            {
            pnlContent.Controls.Clear();
            keranjang.Clear();

            DataTable dt = ProdukController.AmbilSemuaProduk();

            int totalStok = 0;
            int jumlahProduk = 0;
            int dipilih = 0;

            int x = 0;
            int y = 0;
            int kolom = 0;

            keyword = keyword.Trim().ToLower();

            foreach (DataRow row in dt.Rows)
            {
                DateTime? expired = null;

                if (row["tanggal_expired"] != DBNull.Value)
                {
                    if (row["tanggal_expired"] is DateOnly tgl)
                        expired = tgl.ToDateTime(TimeOnly.MinValue);
                    else
                        expired = Convert.ToDateTime(row["tanggal_expired"]);
                }

                if (expired != null && expired.Value.Date < DateTime.Now.Date)
                {
                    continue;
                }
                int id = Convert.ToInt32(row["id"]);
                string nama = row["nama"].ToString();
                int harga = Convert.ToInt32(row["harga"]);
                int stok = Convert.ToInt32(row["kuantitas"]);
                string foto = row["foto"].ToString();
                string kategori = row["kategori"].ToString();

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

                keranjang[id] = 0;

                Panel card = BuatCardProduk(id, nama, harga, stok, foto);
                card.Location = new Point(x, y);
                pnlContent.Controls.Add(card);

                kolom++;
                x += 330;

                if (kolom == 3)
                {
                    kolom = 0;
                    x = 0;
                    y += 300;
                }
            }

            lblTotalBibit.Text = jumlahProduk.ToString();
            lblStokTersedia.Text = totalStok.ToString();
            lblDipilih.Text = dipilih.ToString();

            lblJumlahBibit.Text = jumlahProduk + " bibit ditemukan";
        }

        private Panel BuatCardProduk(int id, string nama, int harga, int stok, string foto)
        {
            Panel card = new Panel();
            card.Size = new Size(300, 270);
            card.BackColor = Color.White;
            card.BorderStyle = BorderStyle.FixedSingle;

            PictureBox pic = new PictureBox();
            pic.Location = new Point(0, 0);
            pic.Size = new Size(300, 140);
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.BackColor = Color.FromArgb(245, 248, 245);

            string pathFoto = Path.Combine(Application.StartupPath, "Images", foto);
            if (File.Exists(pathFoto))
                pic.Image = Image.FromFile(pathFoto);

            Label lblStok = new Label();
            lblStok.Text = "Stok: " + stok;
            lblStok.AutoSize = true;
            lblStok.BackColor = Color.White;
            lblStok.ForeColor = Color.Green;
            lblStok.Location = new Point(220, 10);

            Label lblNama = new Label();
            lblNama.Text = nama;
            lblNama.AutoSize = true;
            lblNama.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblNama.ForeColor = Color.FromArgb(30, 50, 35);
            lblNama.Location = new Point(18, 155);

            Label lblHarga = new Label();
            lblHarga.Text = FormatRupiah(harga);
            lblHarga.AutoSize = true;
            lblHarga.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblHarga.ForeColor = Color.Green;
            lblHarga.Location = new Point(18, 190);

            Button btnMinus = new Button();
            btnMinus.Text = "-";
            btnMinus.Size = new Size(30, 30);
            btnMinus.Location = new Point(18, 225);
            btnMinus.BackColor = Color.FromArgb(235, 245, 235);
            btnMinus.FlatStyle = FlatStyle.Flat;

            Label lblJumlah = new Label();
            lblJumlah.Text = "0";
            lblJumlah.AutoSize = true;
            lblJumlah.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblJumlah.Location = new Point(65, 230);

            Button btnPlus = new Button();
            btnPlus.Text = "+";
            btnPlus.Size = new Size(30, 30);
            btnPlus.Location = new Point(100, 225);
            btnPlus.BackColor = Color.FromArgb(22, 101, 52);
            btnPlus.ForeColor = Color.White;
            btnPlus.FlatStyle = FlatStyle.Flat;

            btnPlus.Click += (s, e) =>
            {
                int jumlah = int.Parse(lblJumlah.Text);
                if (jumlah >= stok) return;

                jumlah++;
                lblJumlah.Text = jumlah.ToString();
                keranjang[id] = jumlah;
                UpdateDipilih();
            };

            btnMinus.Click += (s, e) =>
            {
                int jumlah = int.Parse(lblJumlah.Text);
                if (jumlah <= 0) return;

                jumlah--;
                lblJumlah.Text = jumlah.ToString();
                keranjang[id] = jumlah;
                UpdateDipilih();
            };

            card.Controls.Add(pic);
            pic.Controls.Add(lblStok);
            card.Controls.Add(lblNama);
            card.Controls.Add(lblHarga);
            card.Controls.Add(btnMinus);
            card.Controls.Add(lblJumlah);
            card.Controls.Add(btnPlus);

            lblStok.BringToFront();

            return card;
        }

        private void UpdateDipilih()
        {
            int total = 0;

            foreach (var item in keranjang)
            {
                total += item.Value;
            }

            lblDipilih.Text = total.ToString();
        }

        public void SelesaiPembayaran()
        {
            LoadProduk();
        }

        private void txtCariBibit_TextChanged(object sender, EventArgs e)
        {
            LoadProduk(txtCariBibit.Text);
        }

        private void MenuCheckout_Click(object sender, EventArgs e) => PindahKeCheckout();

        private void btnRiwayat_Click(object sender, EventArgs e)
        {
            PindahKeRiwayat();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picCart_Load(object sender, EventArgs e) { }
        private void lblInitial_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void pictureBox3_Click(object sender, EventArgs e) { }
        private void lblTanggal_Click(object sender, EventArgs e) { }
        private void lblWelcome_Click(object sender, EventArgs e) { }
    }
}