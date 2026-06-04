using System;
using System.Windows.Forms;
using ProjectFajriGans.Controllers;

namespace ProjectFajriGans.UserControls
{
    public partial class UCCheckout : UserControl
    {
        public event Action PindahKeDashboard = delegate { };
        public event Action PembayaranBerhasil = delegate { };

        private int totalItem;
        private int totalHarga;

        private int mangga, cabai, jambu, jeruk, alpukat, rambutan;

        public UCCheckout(int mangga, int cabai, int jambu, int jeruk, int alpukat, int rambutan)
        {
            InitializeComponent();

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

            lblQtyMangga.Text = mangga.ToString();
            lblSubtotalMangga.Text = FormatRupiah(mangga * 15000);
            picManggaCheckout.Visible = lblManggaCheckout.Visible = lblHargaManggaCheckout.Visible =
                lblQtyMangga.Visible = lblSubtotalMangga.Visible = mangga > 0;

            lblQtyCabai.Text = cabai.ToString();
            lblSubtotalCabai.Text = FormatRupiah(cabai * 8000);
            piCabaiCheckout.Visible = lblCabaiCheckout.Visible = lblHargaCabaiCheckout.Visible =
                lblQtyCabai.Visible = lblSubtotalCabai.Visible = cabai > 0;

            lblQtyJambu.Text = jambu.ToString();
            lblSubtotalJambu.Text = FormatRupiah(jambu * 12000);
            pictureBox2.Visible = lblJambuCheckout.Visible = lblHargaJambuCheckout.Visible =
                lblQtyJambu.Visible = lblSubtotalJambu.Visible = jambu > 0;

            lblQtyJeruk.Text = jeruk.ToString();
            lblSubtotalJeruk.Text = FormatRupiah(jeruk * 10000);
            picJerukCheckout.Visible = lblJerukCheckout.Visible = lblHargaJerukCheckout.Visible =
                lblQtyJeruk.Visible = lblSubtotalJeruk.Visible = jeruk > 0;

            lblQtyAlpukat.Text = alpukat.ToString();
            lblSubtotalAlpukat.Text = FormatRupiah(alpukat * 20000);
            picAlpukatCheckout.Visible = lblAlpukatCheckout.Visible = lblHargaAlpukatCheckout.Visible =
                lblQtyAlpukat.Visible = lblSubtotalAlpukat.Visible = alpukat > 0;

            lblQtyRambutan.Text = rambutan.ToString();
            lblSubtotalRambutan.Text = FormatRupiah(rambutan * 13000);
            picRambutanCheckout.Visible = lblRambutanCheckout.Visible = lblHargaRambutanCheckout.Visible =
                lblQtyRambutan.Visible = lblSubtotalRambutan.Visible = rambutan > 0;
        }

        private void btnEwallet_Click(object sender, EventArgs e)
        {
            if (totalItem <= 0)
            {
                MessageBox.Show("Tidak ada item yang dibeli.");
                return;
            }

            bool berhasil = TransaksiController.SimpanTransaksi(totalItem, totalHarga);

            if (berhasil)
            {
                if (mangga > 0) BibitController.KurangiStok("Bibit Mangga", mangga);
                if (cabai > 0) BibitController.KurangiStok("Bibit Cabai", cabai);
                if (jambu > 0) BibitController.KurangiStok("Bibit Jambu", jambu);
                if (jeruk > 0) BibitController.KurangiStok("Bibit Jeruk", jeruk);
                if (alpukat > 0) BibitController.KurangiStok("Bibit Alpukat", alpukat);
                if (rambutan > 0) BibitController.KurangiStok("Bibit Rambutan", rambutan);

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

        private void UCCheckout_Load(object sender, EventArgs e) { }
        private void pnlSidebar_Paint(object sender, PaintEventArgs e) { }
        private void pnlDaftarPesanan_Paint(object sender, PaintEventArgs e) { }
    }
}