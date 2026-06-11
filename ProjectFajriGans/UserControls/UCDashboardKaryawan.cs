using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using MyBibit.Controllers;

namespace MyBibit.UserControls
{
    public partial class UCDashboardKaryawan : UserControl
    {
        private string fotoPath = "";
        private bool modeEdit = false;
        private int idProdukEdit = 0;
        private string fotoLama = "";
        private string kategoriAktif = "Semua";

        public UCDashboardKaryawan()
        {
            InitializeComponent();

            lblTanggal.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy", new CultureInfo("id-ID"));

            string namaDepan = Session.Username.Split(' ')[0];
            lblWelcome.Text = "Selamat Datang, " + namaDepan;
            lblInitial.Text = namaDepan.Substring(0, 1).ToUpper();

            this.AutoScroll = true;

            SetupPopupStyle();

            pnlOverlay.Visible = false;
            pnlPopupProduk.Visible = false;

            LoadProdukAktif();

            txtCariBibit.TextChanged += txtCariBibit_TextChanged;

            btnSemua.Click += (s, e) =>
            {
                kategoriAktif = "Semua";
                LoadProdukAktif(txtCariBibit.Text);
            };

            btnBuah.Click += (s, e) =>
            {
                kategoriAktif = "Buah";
                LoadProdukAktif(txtCariBibit.Text);
            };

            btnSayur.Click += (s, e) =>
            {
                kategoriAktif = "Sayur";
                LoadProdukAktif(txtCariBibit.Text);
            };
        }

        private DateTime? AmbilExpired(DataRow row)
        {
            if (row["tanggal_expired"] == DBNull.Value)
                return null;

            if (row["tanggal_expired"] is DateOnly tgl)
                return tgl.ToDateTime(TimeOnly.MinValue);

            return Convert.ToDateTime(row["tanggal_expired"]);
        }

        private void LoadProdukAktif(string keyword = "")
        {
            pnlDaftarProduk.Controls.Clear();
            pnlDaftarProduk.AutoScroll = true;

            DataTable dt = ProdukController.AmbilSemuaProduk();

            int totalStok = 0;
            int x = 0, y = 0, kolom = 0, jumlahTampil = 0;

            keyword = keyword.Trim().ToLower();

            foreach (DataRow row in dt.Rows)
            {
                int id = Convert.ToInt32(row["id"]);
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
                jumlahTampil++;

                Panel card = BuatCardProduk(id, nama, harga, stok, foto, expired);
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

            lblJumlahBibit.Text = jumlahTampil + " bibit ditemukan";
            lblTotalBibit.Text = jumlahTampil.ToString();
            lblStokTersedia.Text = totalStok.ToString();
        }

        private void LoadProdukAktif()
        {
            LoadProdukAktif("");
        }

        private Panel BuatCardProduk(int id, string nama, int harga, int stok, string foto, DateTime? expired)
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

            if (!string.IsNullOrEmpty(foto))
            {
                string pathFoto = Path.Combine(Application.StartupPath, "Images", foto);
                if (File.Exists(pathFoto))
                    pic.Image = Image.FromFile(pathFoto);
            }

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
            lblStok.Font = new Font("Segoe UI", 10);
            lblStok.Location = new Point(220, 10);

            Label lblNama = new Label();
            lblNama.Text = nama;
            lblNama.AutoSize = true;
            lblNama.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblNama.ForeColor = Color.FromArgb(30, 50, 35);
            lblNama.Location = new Point(18, 180);

            Label lblHarga = new Label();
            lblHarga.Text = "Rp " + harga.ToString("N0", new CultureInfo("id-ID"));
            lblHarga.AutoSize = true;
            lblHarga.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblHarga.ForeColor = Color.Green;
            lblHarga.Location = new Point(18, 215);

            Button btnHapus = new Button();
            btnHapus.Text = "Hapus";
            btnHapus.Size = new Size(75, 35);
            btnHapus.Location = new Point(10, 245);
            btnHapus.BackColor = Color.FromArgb(235, 245, 235);
            btnHapus.ForeColor = Color.FromArgb(120, 170, 120);
            btnHapus.FlatStyle = FlatStyle.Flat;
            btnHapus.Click += (s, e) => HapusProduk(id);

            Button btnEdit = new Button();
            btnEdit.Text = "Edit";
            btnEdit.Size = new Size(70, 35);
            btnEdit.Location = new Point(220, 245);
            btnEdit.BackColor = Color.FromArgb(22, 101, 52);
            btnEdit.ForeColor = Color.White;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Click += (s, e) => TampilkanPopupEdit(id);

            card.Controls.Add(pic);
            pic.Controls.Add(lblStatusExpired);
            pic.Controls.Add(lblStok);

            card.Controls.Add(lblNama);
            card.Controls.Add(lblHarga);
            card.Controls.Add(btnHapus);
            card.Controls.Add(btnEdit);

            lblStatusExpired.BringToFront();
            lblStok.BringToFront();

            return card;
        }

        private void txtCariBibit_TextChanged(object sender, EventArgs e)
        {
            LoadProdukAktif(txtCariBibit.Text);
        }

        private void SetupPopupStyle()
        {
            pnlOverlay.Dock = DockStyle.Fill;
            pnlOverlay.BackColor = Color.FromArgb(180, 0, 0, 0);
            pnlPopupProduk.Size = new Size(420, 680);
            pnlPopupProduk.BackColor = Color.White;
            pnlPopupProduk.BorderStyle = BorderStyle.FixedSingle;
            picProduk.SizeMode = PictureBoxSizeMode.Zoom;
            btnPilihFoto.Visible = true;
            btnPilihFoto.Text = "+";
        }

        private void TampilkanPopupCreate()
        {
            modeEdit = false;
            idProdukEdit = 0;
            fotoLama = "";
            fotoPath = "";
            txtNamaProduk.Clear();
            txtHargaProduk.Clear();
            txtStokProduk.Clear();
            picProduk.Image = null;
            TampilkanPopup();
        }

        private void TampilkanPopupEdit(int idProduk)
        {
            DataTable dt = ProdukController.AmbilProdukById(idProduk);
            if (dt.Rows.Count == 0) return;

            DataRow row = dt.Rows[0];

            modeEdit = true;
            idProdukEdit = idProduk;
            fotoLama = row["foto"].ToString();
            fotoPath = "";

            txtNamaProduk.Text = row["nama"].ToString();
            txtHargaProduk.Text = row["harga"].ToString();
            txtStokProduk.Text = row["kuantitas"].ToString();

            cmbKategori.SelectedIndex = Convert.ToInt32(row["id_kategori"]) == 1 ? 0 : 1;

            if (row["tanggal_expired"] != DBNull.Value)
            {
                if (row["tanggal_expired"] is DateOnly tgl)
                    dtpExpired.Value = tgl.ToDateTime(TimeOnly.MinValue);
                else
                    dtpExpired.Value = Convert.ToDateTime(row["tanggal_expired"]);
            }
            else
            {
                dtpExpired.Value = DateTime.Now;
            }

            picProduk.Image = null;

            if (!string.IsNullOrEmpty(fotoLama))
            {
                string pathFoto = Path.Combine(Application.StartupPath, "Images", fotoLama);
                if (File.Exists(pathFoto))
                    picProduk.Image = Image.FromFile(pathFoto);
            }

            TampilkanPopup();
        }

        private void TampilkanPopup()
        {
            pnlPopupProduk.Location = new Point(
                (Width - pnlPopupProduk.Width) / 2 - 70,
                (Height - pnlPopupProduk.Height) / 2
            );

            pnlOverlay.Visible = true;
            pnlPopupProduk.Visible = true;
            pnlOverlay.BringToFront();
            pnlPopupProduk.BringToFront();
        }

        private void TutupPopupProduk()
        {
            pnlOverlay.Visible = false;
            pnlPopupProduk.Visible = false;
        }

        private string SimpanFotoKeFolder()
        {
            if (fotoPath == "")
                return fotoLama;

            string folderImages = Path.Combine(Application.StartupPath, "Images");
            if (!Directory.Exists(folderImages))
                Directory.CreateDirectory(folderImages);

            string namaFoto = Guid.NewGuid() + Path.GetExtension(fotoPath);
            File.Copy(fotoPath, Path.Combine(folderImages, namaFoto), true);

            return namaFoto;
        }

        private void HapusProduk(int idProduk)
        {
            if (MessageBox.Show("Yakin hapus produk?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ProdukController.HapusProduk(idProduk);
                LoadProdukAktif();
                MessageBox.Show("Produk berhasil dihapus.");
            }
        }

        private void btnTambahProduk_Click(object sender, EventArgs e)
        {
            TampilkanPopupCreate();
        }

        private void btnPilihFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fotoPath = ofd.FileName;
                picProduk.Image = Image.FromFile(fotoPath);
            }
        }

        private void btnSimpanProduk_Click(object sender, EventArgs e)
        {
            if (txtNamaProduk.Text == "" || txtHargaProduk.Text == "" || txtStokProduk.Text == "")
            {
                MessageBox.Show("Nama, harga, dan stok wajib diisi!");
                return;
            }

            if (!int.TryParse(txtHargaProduk.Text, out int harga))
            {
                MessageBox.Show("Harga harus angka!");
                return;
            }

            if (!int.TryParse(txtStokProduk.Text, out int stok))
            {
                MessageBox.Show("Stok harus angka!");
                return;
            }

            if (stok < 0)
            {
                MessageBox.Show("Stok tidak boleh minus!");
                return;
            }

            string namaFoto = SimpanFotoKeFolder();
            int idKategori = cmbKategori.Text == "Buah" ? 1 : 2;
            DateTime expired = dtpExpired.Value.Date;

            if (modeEdit)
            {
                ProdukController.UpdateProduk(idProdukEdit, txtNamaProduk.Text, harga, stok, namaFoto, idKategori, expired);
                MessageBox.Show("Produk berhasil diupdate.");
            }
            else
            {
                ProdukController.TambahProduk(txtNamaProduk.Text, harga, stok, namaFoto, idKategori, expired);
                MessageBox.Show("Produk berhasil ditambahkan.");
            }

            TutupPopupProduk();
            LoadProdukAktif();
        }

        private void btnBatalProduk_Click(object sender, EventArgs e)
        {
            TutupPopupProduk();
        }

        private void btnOrderDetail_Click(object sender, EventArgs e)
        {
            ((FormMain)this.FindForm()).LoadOrderDetailKaryawan();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ((FormMain)this.FindForm()).LoadLogin();
        }

        private void pnlOverlay_Paint(object sender, PaintEventArgs e) { }

        private void btnHapusJeruk_Click(object sender, EventArgs e) { }
        private void btnHapusJambu_Click(object sender, EventArgs e) { }
        private void btnHapusAlpukat_Click(object sender, EventArgs e) { }
        private void btnHapusRambutan_Click(object sender, EventArgs e) { }
        private void btnHapusCabai_Click(object sender, EventArgs e) { }
        private void btnHapusMangga_Click(object sender, EventArgs e) { }

        private void btnEditJeruk_Click(object sender, EventArgs e) { }
        private void btnEditJambu_Click(object sender, EventArgs e) { }
        private void btnEditAlpukat_Click(object sender, EventArgs e) { }
        private void btnEditRambutan_Click(object sender, EventArgs e) { }
        private void btnEditCabai_Click(object sender, EventArgs e) { }
        private void btnEditMangga_Click(object sender, EventArgs e) { }
    }
}