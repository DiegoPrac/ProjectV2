using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using MyBibit.Controllers;

namespace MyBibit.UserControls
{
    public partial class UCRiwayat : UserControl
    {
        public event Action PindahKeDashboard = delegate { };
        public event Action PindahKeCheckout = delegate { };

        public UCRiwayat()
        {
            InitializeComponent();
            string namaDepan = Session.Username.Split(' ')[0];


            lblWelcome.Text = "Selamat Datang, " + namaDepan;
            lblInitial.Text = namaDepan.Substring(0, 1).ToUpper();

            lblTanggal.Text = DateTime.Now.ToString(
                "dddd, dd MMMM yyyy",
                new CultureInfo("id-ID")
            );

            LoadRiwayat();
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

        private void LoadRiwayat()
        {
            DataTable dtAsli = RiwayatController.AmbilRiwayat(dtpAwal.Value, dtpAkhir.Value);

            DataTable dtTampil = new DataTable();
            dtTampil.Columns.Add("Foto", typeof(Image));
            dtTampil.Columns.Add("Tanggal");
            dtTampil.Columns.Add("Produk");
            dtTampil.Columns.Add("Harga");
            dtTampil.Columns.Add("Qty");
            dtTampil.Columns.Add("Total");
            dtTampil.Columns.Add("Status");

            int totalPengeluaran = 0;
            int totalItem = 0;

            foreach (DataRow row in dtAsli.Rows)
            {
                string fotoFile = row["FotoFile"].ToString();
                string pathFoto = Path.Combine(Application.StartupPath, "Images", fotoFile);

                int harga = Convert.ToInt32(row["Harga"]);
                int qty = Convert.ToInt32(row["Qty"]);
                int total = Convert.ToInt32(row["Total"]);

                dtTampil.Rows.Add(
                    BuatThumbnail(pathFoto),
                    row["Tanggal"].ToString(),
                    row["Produk"].ToString(),
                    FormatRupiah(harga),
                    qty,
                    FormatRupiah(total),
                    row["Status"].ToString()
                );

                totalPengeluaran += total;
                totalItem += qty;
            }

            dgvRiwayat.Columns.Clear();
            dgvRiwayat.AutoGenerateColumns = true;
            dgvRiwayat.DataSource = dtTampil;

            dgvRiwayat.RowTemplate.Height = 45;
            dgvRiwayat.ReadOnly = true;
            dgvRiwayat.AllowUserToAddRows = false;
            dgvRiwayat.RowHeadersVisible = false;
            dgvRiwayat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRiwayat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            lblTotalTransaksi.Text = dtAsli.Rows.Count.ToString();
            lblTotalPengeluaran.Text = FormatRupiah(totalPengeluaran);
            lblTotalPengeluaran.AutoSize = true;
            lblTotalPengeluaran.BringToFront();
            lblTransaksiSelesai.Text = totalItem.ToString();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadRiwayat();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            PindahKeDashboard();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            PindahKeCheckout();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblTransaksiSelesai_Click(object sender, EventArgs e) { }
    }
}