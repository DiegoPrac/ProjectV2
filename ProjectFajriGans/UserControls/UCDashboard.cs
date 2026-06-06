using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using System.Drawing;
using ProjectFajriGans.Controllers;

namespace ProjectFajriGans.UserControls
{
    public partial class UCDashboard : UserControl
    {
        public event Action PindahKeCheckout = delegate { };
        public event Action PindahKeRiwayat = delegate { };

        private int stokMangga, stokCabai, stokJambu;
        private int stokJeruk, stokAlpukat, stokRambutan;

        public int JumlahMangga => int.Parse(lblJumlah.Text);
        public int JumlahCabai => int.Parse(lblJumlahCabai.Text);
        public int JumlahJambu => int.Parse(lblJumlahJambu.Text);
        public int JumlahJeruk => int.Parse(lblJumlahJeruk.Text);
        public int JumlahAlpukat => int.Parse(lblJumlahAlpukat.Text);
        public int JumlahRambutan => int.Parse(lblJumlahRambutan.Text);

        public UCDashboard()
        {
            InitializeComponent();

            lblTanggal.Text = DateTime.Now.ToString(
                "dddd, dd MMMM yyyy",
                new CultureInfo("id-ID")
            );

            AmbilProdukDariDatabase();
            UpdateStatistik();
        }

        private string FormatRupiah(int angka)
        {
            return "Rp " + angka.ToString("N0").Replace(",", ".");
        }

        private void AmbilProdukDariDatabase()
        {
            DataTable dt = ProdukController.AmbilSemuaProduk();

            foreach (DataRow row in dt.Rows)
            {
                string nama = row["nama"].ToString();
                int stok = Convert.ToInt32(row["kuantitas"]);
                int harga = Convert.ToInt32(row["harga"]);

                if (nama == "Bibit Mangga")
                {
                    stokMangga = stok;
                    lblHargaMangga.Text = FormatRupiah(harga);
                    lblStokMangga.Text = "Stok: " + stok;
                }
                else if (nama == "Bibit Cabai")
                {
                    stokCabai = stok;
                    lblHargaCabai.Text = FormatRupiah(harga);
                    lblStokCabai.Text = "Stok: " + stok;
                }
                else if (nama == "Bibit Jambu")
                {
                    stokJambu = stok;
                    label6.Text = FormatRupiah(harga);
                    lblStokJambu.Text = "Stok: " + stok;
                }
                else if (nama == "Bibit Jeruk")
                {
                    stokJeruk = stok;
                    lblHargaJeruk.Text = FormatRupiah(harga);
                    lblStokJeruk.Text = "Stok: " + stok;
                }
                else if (nama == "Bibit Alpukat")
                {
                    stokAlpukat = stok;
                    lblHargaAlpukat.Text = FormatRupiah(harga);
                    lblStokAlpukat.Text = "Stok: " + stok;
                }
                else if (nama == "Bibit Rambutan")
                {
                    stokRambutan = stok;
                    lblHargaRambutan.Text = FormatRupiah(harga);
                    lblStokRambutan.Text = "Stok: " + stok;
                }
            }
        }

        private void UpdateStatistik()
        {
            int dipilih = JumlahMangga + JumlahCabai + JumlahJambu + JumlahJeruk + JumlahAlpukat + JumlahRambutan;
            int stokTersedia = stokMangga + stokCabai + stokJambu + stokJeruk + stokAlpukat + stokRambutan;

            int totalBibit = 0;
            if (stokMangga > 0) totalBibit++;
            if (stokCabai > 0) totalBibit++;
            if (stokJambu > 0) totalBibit++;
            if (stokJeruk > 0) totalBibit++;
            if (stokAlpukat > 0) totalBibit++;
            if (stokRambutan > 0) totalBibit++;

            lblTotalBibit.Text = totalBibit.ToString();
            lblStokTersedia.Text = stokTersedia.ToString();
            lblDipilih.Text = dipilih.ToString();
        }

        public void SelesaiPembayaran()
        {
            AmbilProdukDariDatabase();

            lblJumlah.Text = "0";
            lblJumlahCabai.Text = "0";
            lblJumlahJambu.Text = "0";
            lblJumlahJeruk.Text = "0";
            lblJumlahAlpukat.Text = "0";
            lblJumlahRambutan.Text = "0";

            UpdateStatistik();
        }

        private void TambahJumlah(Label label, int stok)
        {
            int jumlah = int.Parse(label.Text);
            if (jumlah >= stok) return;

            label.Text = (jumlah + 1).ToString();
            UpdateStatistik();
        }

        private void KurangJumlah(Label label)
        {
            int jumlah = int.Parse(label.Text);
            if (jumlah <= 0) return;

            label.Text = (jumlah - 1).ToString();
            UpdateStatistik();
        }

        private void btnPlus_Click(object sender, EventArgs e) => TambahJumlah(lblJumlah, stokMangga);
        private void btnMinus_Click(object sender, EventArgs e) => KurangJumlah(lblJumlah);

        private void btnPlusCabai_Click(object sender, EventArgs e) => TambahJumlah(lblJumlahCabai, stokCabai);
        private void btnMinusCabai_Click(object sender, EventArgs e) => KurangJumlah(lblJumlahCabai);

        private void btnPlusJambu_Click(object sender, EventArgs e) => TambahJumlah(lblJumlahJambu, stokJambu);
        private void btnMinusJambu_Click(object sender, EventArgs e) => KurangJumlah(lblJumlahJambu);

        private void btnPlusJeruk_Click(object sender, EventArgs e) => TambahJumlah(lblJumlahJeruk, stokJeruk);
        private void btnMinusJeruk_Click(object sender, EventArgs e) => KurangJumlah(lblJumlahJeruk);

        private void btnPlusAlpukat_Click(object sender, EventArgs e) => TambahJumlah(lblJumlahAlpukat, stokAlpukat);
        private void btnMinusAlpukat_Click(object sender, EventArgs e) => KurangJumlah(lblJumlahAlpukat);

        private void btnPlusRambutan_Click(object sender, EventArgs e) => TambahJumlah(lblJumlahRambutan, stokRambutan);
        private void btnMinusRambutan_Click(object sender, EventArgs e) => KurangJumlah(lblJumlahRambutan);

        private void MenuCheckout_Click(object sender, EventArgs e) => PindahKeCheckout();

        private void btnRiwayat_Click(object sender, EventArgs e)
        {
            PindahKeRiwayat();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtCariBibit_TextChanged(object sender, EventArgs e)
        {
            string cari = txtCariBibit.Text.Trim().ToLower();

            lblNamaMangga.BackColor = cari != "" && "bibit mangga".Contains(cari) ? Color.LightGreen : Color.Transparent;
            lblNamaCabai.BackColor = cari != "" && "bibit cabai".Contains(cari) ? Color.LightGreen : Color.Transparent;
            lblNamaJambu.BackColor = cari != "" && "bibit jambu".Contains(cari) ? Color.LightGreen : Color.Transparent;
            lblNamaJeruk.BackColor = cari != "" && "bibit jeruk".Contains(cari) ? Color.LightGreen : Color.Transparent;
            lblNamaAlpukat.BackColor = cari != "" && "bibit alpukat".Contains(cari) ? Color.LightGreen : Color.Transparent;
            lblNamaRambutan.BackColor = cari != "" && "bibit rambutan".Contains(cari) ? Color.LightGreen : Color.Transparent;
        }

        private void picCart_Load(object sender, EventArgs e) { }
        private void lblInitial_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void pictureBox3_Click(object sender, EventArgs e) { }
        private void lblTanggal_Click(object sender, EventArgs e) { }
        private void lblWelcome_Click(object sender, EventArgs e) { }
    }
}