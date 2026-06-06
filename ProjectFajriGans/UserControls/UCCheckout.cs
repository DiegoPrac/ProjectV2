using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using ProjectFajriGans.Controllers;

namespace ProjectFajriGans.UserControls
{
    public partial class UCCheckout : UserControl
    {
        public event Action PindahKeDashboard = delegate { };
        public event Action PembayaranBerhasil = delegate { };
        public event Action PindahKeRiwayat = delegate { };

        private int totalItem;
        private int totalHarga;
        private int mangga, cabai, jambu, jeruk, alpukat, rambutan;

        public UCCheckout(int mangga, int cabai, int jambu, int jeruk, int alpukat, int rambutan)
        {
            InitializeComponent();

            lblTanggal.Text = DateTime.Now.ToString(
                "dddd, dd MMMM yyyy",
                new CultureInfo("id-ID")
            );

            this.mangga = mangga;
            this.cabai = cabai;
            this.jambu = jambu;
            this.jeruk = jeruk;
            this.alpukat = alpukat;
            this.rambutan = rambutan;

            TampilkanPesanan();
        }

        private string FormatRupiah(int angka)
        {
            return "Rp " + angka.ToString("N0").Replace(",", ".");
        }

        private Image BuatThumbnail(string path)
        {
            Bitmap bmp = new Bitmap(55, 40);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);

                if (File.Exists(path))
                {
                    using (Image img = Image.FromFile(path))
                    {
                        g.DrawImage(img, 5, 3, 45, 34);
                    }
                }
            }

            return bmp;
        }

        private string AmbilFotoProduk(DataTable dtProduk, string namaProduk)
        {
            foreach (DataRow row in dtProduk.Rows)
            {
                if (row["nama"].ToString() == namaProduk)
                {
                    return row["foto"].ToString();
                }
            }

            return "";
        }

        private void TambahRow(DataTable dt, DataTable dtProduk, string nama, int harga, int qty)
        {
            if (qty > 0)
            {
                string fotoFile = AmbilFotoProduk(dtProduk, nama);
                string pathFoto = Path.Combine(Application.StartupPath, "Resources", "Images", fotoFile);

                dt.Rows.Add(
                    BuatThumbnail(pathFoto),
                    nama,
                    FormatRupiah(harga),
                    qty,
                    FormatRupiah(harga * qty)
                );
            }
        }

        private void TampilkanPesanan()
        {
            totalItem = mangga + cabai + jambu + jeruk + alpukat + rambutan;

            totalHarga =
                mangga * 15000 +
                cabai * 8000 +
                jambu * 12000 +
                jeruk * 10000 +
                alpukat * 20000 +
                rambutan * 13000;

            lblJumlahItem.Text = totalItem + " pot";
            lblTotalHarga.Text = FormatRupiah(totalHarga);

            DataTable dtProduk = ProdukController.AmbilSemuaProduk();

            DataTable dt = new DataTable();
            dt.Columns.Add("Foto", typeof(Image));
            dt.Columns.Add("Nama Tanaman");
            dt.Columns.Add("Harga");
            dt.Columns.Add("Qty");
            dt.Columns.Add("Subtotal");

            TambahRow(dt, dtProduk, "Bibit Mangga", 15000, mangga);
            TambahRow(dt, dtProduk, "Bibit Cabai", 8000, cabai);
            TambahRow(dt, dtProduk, "Bibit Jambu", 12000, jambu);
            TambahRow(dt, dtProduk, "Bibit Jeruk", 10000, jeruk);
            TambahRow(dt, dtProduk, "Bibit Alpukat", 20000, alpukat);
            TambahRow(dt, dtProduk, "Bibit Rambutan", 13000, rambutan);

            dgvCheckout.Columns.Clear();
            dgvCheckout.AutoGenerateColumns = true;
            dgvCheckout.DataSource = dt;

            dgvCheckout.RowTemplate.Height = 45;
            dgvCheckout.ReadOnly = true;
            dgvCheckout.AllowUserToAddRows = false;
            dgvCheckout.RowHeadersVisible = false;
            dgvCheckout.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCheckout.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnEwallet_Click(object sender, EventArgs e)
        {
            if (totalItem <= 0)
            {
                MessageBox.Show("Tidak ada item yang dibeli.");
                return;
            }

            bool berhasil = TransaksiController.SimpanTransaksi(
                mangga, cabai, jambu, jeruk, alpukat, rambutan
            );

            if (berhasil)
            {
                if (mangga > 0) ProdukController.KurangiStok(1, mangga);
                if (cabai > 0) ProdukController.KurangiStok(2, cabai);
                if (jambu > 0) ProdukController.KurangiStok(3, jambu);
                if (jeruk > 0) ProdukController.KurangiStok(4, jeruk);
                if (alpukat > 0) ProdukController.KurangiStok(5, alpukat);
                if (rambutan > 0) ProdukController.KurangiStok(6, rambutan);

                btnEwallet.Enabled = false;
                PembayaranBerhasil();

                MessageBox.Show("Pembayaran berhasil. Transaksi selesai.");

                mangga = cabai = jambu = jeruk = alpukat = rambutan = 0;
                TampilkanPesanan();
            }
            else
            {
                MessageBox.Show("Transaksi gagal disimpan.");
            }
        }

        private void MenuDashboard_Click(object sender, EventArgs e) => PindahKeDashboard();
        private void btnKembali_Click(object sender, EventArgs e) => PindahKeDashboard();
        private void btnRiwayat_Click(object sender, EventArgs e) => PindahKeRiwayat();
        private void btnLogout_Click(object sender, EventArgs e) => Application.Exit();

        private void UCCheckout_Load(object sender, EventArgs e) { }
        private void pnlSidebar_Paint(object sender, PaintEventArgs e) { }
        private void pnlDaftarPesanan_Paint(object sender, PaintEventArgs e) { }
        private void txtCariBibit_TextChanged(object sender, EventArgs e) { }
    }
}