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
    public partial class UCCheckout : UserControl
    {
        public event Action PindahKeDashboard = delegate { };
        public event Action PembayaranBerhasil = delegate { };
        public event Action PindahKeRiwayat = delegate { };

        private Dictionary<int, int> keranjang;
        private int totalItem;
        private int totalHarga;

        public UCCheckout(Dictionary<int, int> keranjang)
        {
            InitializeComponent();

            string namaDepan = Session.Username.Split(' ')[0];
            lblWelcome.Text = "Selamat Datang, " + namaDepan;
            lblInitial.Text = namaDepan.Substring(0, 1).ToUpper();

            lblTanggal.Text = DateTime.Now.ToString(
                "dddd, dd MMMM yyyy",
                new CultureInfo("id-ID")
            );

            this.keranjang = new Dictionary<int, int>(keranjang);

            pnlOverlayQRIS.Visible = false;
            pnlQRIS.Visible = false;

            TampilkanPesanan();
        }

        private string FormatRupiah(int angka)
        {
            return "Rp " + angka.ToString("N0", new CultureInfo("id-ID"));
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

        private DataRow AmbilProduk(DataTable dtProduk, int idProduk)
        {
            foreach (DataRow row in dtProduk.Rows)
            {
                if (Convert.ToInt32(row["id"]) == idProduk)
                    return row;
            }

            return null;
        }

        private void TampilkanPesanan()
        {
            totalItem = 0;
            totalHarga = 0;

            DataTable dtProduk = ProdukController.AmbilSemuaProduk();

            DataTable dt = new DataTable();
            dt.Columns.Add("Foto", typeof(Image));
            dt.Columns.Add("Nama Tanaman");
            dt.Columns.Add("Harga");
            dt.Columns.Add("Qty");
            dt.Columns.Add("Subtotal");

            foreach (var item in keranjang)
            {
                int idProduk = item.Key;
                int qty = item.Value;

                if (qty <= 0) continue;

                DataRow produk = AmbilProduk(dtProduk, idProduk);
                if (produk == null) continue;

                string nama = produk["nama"].ToString();
                int harga = Convert.ToInt32(produk["harga"]);
                string foto = produk["foto"].ToString();

                string pathFoto = Path.Combine(Application.StartupPath, "Images", foto);

                totalItem += qty;
                totalHarga += harga * qty;

                dt.Rows.Add(
                    BuatThumbnail(pathFoto),
                    nama,
                    FormatRupiah(harga),
                    qty,
                    FormatRupiah(harga * qty)
                );
            }

            lblJumlahItem.Text = totalItem + " pot";
            lblTotalHarga.Text = FormatRupiah(totalHarga);

            dgvCheckout.Columns.Clear();
            dgvCheckout.AutoGenerateColumns = true;
            dgvCheckout.DataSource = dt;

            dgvCheckout.RowTemplate.Height = 45;
            dgvCheckout.ReadOnly = true;
            dgvCheckout.AllowUserToAddRows = false;
            dgvCheckout.AllowUserToResizeColumns = false;
            dgvCheckout.AllowUserToResizeRows = false;
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

            string pathQRIS = Path.Combine(Application.StartupPath, "Resources", "Images", "QRIS.png");

            if (File.Exists(pathQRIS))
                picQRIS.Image = Image.FromFile(pathQRIS);

            pnlOverlayQRIS.Visible = true;
            pnlQRIS.Visible = true;

            pnlQRIS.Location = new Point(
                 (this.Width - pnlQRIS.Width) / 2,
                 (this.Height - pnlQRIS.Height) / 2
            );

            pnlOverlayQRIS.BringToFront();
            pnlQRIS.BringToFront();
        }

        private void btnBatalQRIS_Click(object sender, EventArgs e)
        {
            pnlQRIS.Visible = false;
            pnlOverlayQRIS.Visible = false;
            btnBatalQRIS.Click += btnBatalQRIS_Click;
            btnSelesaiQRIS.Click += btnSelesaiQRIS_Click;
        }

        private void btnSelesaiQRIS_Click(object sender, EventArgs e)
        {
            bool berhasil = TransaksiController.SimpanTransaksi(keranjang);

            if (berhasil)
            {
                //foreach (var item in keranjang)
                //{
                //    if (item.Value > 0)
                //        ProdukController.KurangiStok(item.Key, item.Value);
                //}

                btnEwallet.Enabled = false;
                PembayaranBerhasil();

                MessageBox.Show("Pembayaran berhasil. Transaksi selesai.");

                keranjang.Clear();
                TampilkanPesanan();

                pnlQRIS.Visible = false;
                pnlOverlayQRIS.Visible = false;
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
    }
}