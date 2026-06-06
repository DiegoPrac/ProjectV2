using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ProjectFajriGans.Controllers;

namespace ProjectFajriGans.UserControls
{
    public partial class UCDashboardKaryawan : UserControl
    {
        public UCDashboardKaryawan()
        {
            InitializeComponent();
            LoadProdukAktif();
            RapikanCardProduk();
        }

        private void LoadProdukAktif()
        {
            pnlBibitMangga.Visible = false;
            pnlBibitCabai.Visible = false;
            pnlBibitJambu.Visible = false;
            pnlBibitJeruk.Visible = false;
            pnlBibitAlpukat.Visible = false;
            pnlBibitRambutan.Visible = false;

            DataTable dt = ProdukController.AmbilSemuaProduk();

            foreach (DataRow row in dt.Rows)
            {
                string nama = row["nama"].ToString();

                if (nama == "Bibit Mangga") pnlBibitMangga.Visible = true;
                else if (nama == "Bibit Cabai") pnlBibitCabai.Visible = true;
                else if (nama == "Bibit Jambu") pnlBibitJambu.Visible = true;
                else if (nama == "Bibit Jeruk") pnlBibitJeruk.Visible = true;
                else if (nama == "Bibit Alpukat") pnlBibitAlpukat.Visible = true;
                else if (nama == "Bibit Rambutan") pnlBibitRambutan.Visible = true;
            }

            lblJumlahBibit.Text = dt.Rows.Count + " bibit ditemukan";
            lblTotalBibit.Text = dt.Rows.Count.ToString();
        }

        private void RapikanCardProduk()
        {
            Panel[] cards =
            {
                pnlBibitMangga,
                pnlBibitCabai,
                pnlBibitJambu,
                pnlBibitJeruk,
                pnlBibitAlpukat,
                pnlBibitRambutan
            };

            int startX = 285;
            int startY = 330;
            int jarakX = 330;
            int jarakY = 355;

            int kolom = 0;
            int baris = 0;

            foreach (Panel card in cards)
            {
                if (!card.Visible) continue;

                card.Location = new Point(startX + kolom * jarakX, startY + baris * jarakY);

                kolom++;

                if (kolom == 3)
                {
                    kolom = 0;
                    baris++;
                }
            }
        }

        private void HapusProduk(int idProduk, object sender)
        {
            DialogResult result = MessageBox.Show(
                "Yakin hapus produk?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                ProdukController.HapusProduk(idProduk);

                Button btn = sender as Button;

                if (btn?.Parent != null)
                    btn.Parent.Visible = false;

                RapikanCardProduk();
                LoadProdukAktif();
                RapikanCardProduk();

                MessageBox.Show("Produk berhasil dihapus.");
            }
        }

        private void btnHapusMangga_Click(object sender, EventArgs e) => HapusProduk(1, sender);
        private void btnHapusCabai_Click(object sender, EventArgs e) => HapusProduk(2, sender);
        private void btnHapusJambu_Click(object sender, EventArgs e) => HapusProduk(3, sender);
        private void btnHapusJeruk_Click(object sender, EventArgs e) => HapusProduk(4, sender);
        private void btnHapusAlpukat_Click(object sender, EventArgs e) => HapusProduk(5, sender);
        private void btnHapusRambutan_Click(object sender, EventArgs e) => HapusProduk(6, sender);

        private void btnEditMangga_Click(object sender, EventArgs e) { }
        private void btnEditCabai_Click(object sender, EventArgs e) { }
        private void btnEditJambu_Click(object sender, EventArgs e) { }
        private void btnEditJeruk_Click(object sender, EventArgs e) { }
        private void btnEditAlpukat_Click(object sender, EventArgs e) { }
        private void btnEditRambutan_Click(object sender, EventArgs e) { }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}