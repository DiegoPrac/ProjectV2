using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProjectFajriGans.Controllers;

namespace ProjectFajriGans.UserControls
{
    public partial class UCDashboard : UserControl
    {
        public event Action PindahKeCheckout = delegate { };

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
            AmbilStokDariDatabase();
            UpdateStatistik();
        }

        private void AmbilStokDariDatabase()
        {
            Dictionary<string, int> stok = BibitController.AmbilSemuaStok();

            stokMangga = stok["Bibit Mangga"];
            stokCabai = stok["Bibit Cabai"];
            stokJambu = stok["Bibit Jambu"];
            stokJeruk = stok["Bibit Jeruk"];
            stokAlpukat = stok["Bibit Alpukat"];
            stokRambutan = stok["Bibit Rambutan"];
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
            lblDipilih.Text = dipilih.ToString();
            lblStokTersedia.Text = stokTersedia.ToString();

            lblStokMangga.Text = "Stok: " + stokMangga;
            lblStokCabai.Text = "Stok: " + stokCabai;
            lblStokJambu.Text = "Stok: " + stokJambu;
            lblStokJeruk.Text = "Stok: " + stokJeruk;
            lblStokAlpukat.Text = "Stok: " + stokAlpukat;
            lblStokRambutan.Text = "Stok: " + stokRambutan;
        }

        public void SelesaiPembayaran()
        {
            AmbilStokDariDatabase();

            lblJumlah.Text = "0";
            lblJumlahCabai.Text = "0";
            lblJumlahJambu.Text = "0";
            lblJumlahJeruk.Text = "0";
            lblJumlahAlpukat.Text = "0";
            lblJumlahRambutan.Text = "0";

            UpdateStatistik();
        }

        private void TambahJumlah(Label label, int stokAsli)
        {
            int jumlah = int.Parse(label.Text);
            if (jumlah >= stokAsli) return;

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

        private void picCart_Load(object sender, EventArgs e) { }
        private void lblInitial_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void pictureBox3_Click(object sender, EventArgs e) { }
        private void lblTanggal_Click(object sender, EventArgs e) { }
        private void lblWelcome_Click(object sender, EventArgs e) { }
    }
}