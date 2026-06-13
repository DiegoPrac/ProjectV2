using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using MyBibit.Controllers;

namespace MyBibit.UserControls
{
    public partial class UCRestockAdmin : UserControl
    {
        public UCRestockAdmin()
        {
            InitializeComponent();

            string username = string.IsNullOrEmpty(Session.Username) ? "Admin" : Session.Username;
            string namaDepan = username.Split(' ')[0];

            lblTanggal.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy", new CultureInfo("id-ID"));
            lblWelcome.Text = "Selamat Datang, " + namaDepan;
            lblInitial.Text = namaDepan.Substring(0, 1).ToUpper();

            SetupTampilan();
            LoadRestock();
        }

        private void SetupTampilan()
        {
            AturGrid(dgvRestock);
            AturGrid(dgvDetailRestock);
            AturGrid(dgvSupplier);

            dgvRestock.AutoGenerateColumns = false;
            dgvSupplier.AutoGenerateColumns = true;

            SetupKolomDetail();

            colDetail.Text = "Lihat";
            colDetail.UseColumnTextForButtonValue = true;

            pnlOverlay.Dock = DockStyle.Fill;
            pnlOverlay.BackColor = Color.FromArgb(150, 0, 0, 0);
            pnlOverlay.Visible = false;

            pnlPopupDetailRestock.Visible = false;
            pnlPopupSupplier.Visible = false;

            txtCariKaryawan.TextChanged -= txtCariKaryawan_TextChanged;
            txtCariKaryawan.TextChanged += txtCariKaryawan_TextChanged;

            dgvRestock.CellContentClick -= dgvRestock_CellContentClick;
            dgvRestock.CellContentClick += dgvRestock_CellContentClick;
        }

        private void SetupKolomDetail()
        {
            dgvDetailRestock.DataSource = null;
            dgvDetailRestock.AutoGenerateColumns = false;
            dgvDetailRestock.Columns.Clear();

            DataGridViewImageColumn colFoto = new DataGridViewImageColumn();
            colFoto.Name = "colFoto";
            colFoto.HeaderText = "Foto";
            colFoto.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colFoto.FillWeight = 70;
            dgvDetailRestock.Columns.Add(colFoto);

            dgvDetailRestock.Columns.Add("colProduk", "Produk");
            dgvDetailRestock.Columns.Add("colHarga", "Harga");
            dgvDetailRestock.Columns.Add("colKuantitas", "Kuantitas");
            dgvDetailRestock.Columns.Add("colSubtotal", "Subtotal");

            dgvDetailRestock.RowTemplate.Height = 75;
        }

        private void AturGrid(DataGridView dgv)
        {
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToOrderColumns = false;
            dgv.RowHeadersVisible = false;
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgv.BackgroundColor = Color.White;
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(22, 101, 52);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        private void LoadRestock()
        {
            dgvRestock.Rows.Clear();

            DataTable dt = RestockController.AmbilSemuaRestock();

            foreach (DataRow row in dt.Rows)
            {
                int id = Convert.ToInt32(row["id"]);

                DateTime tanggal;
                if (row["tanggal"] is DateOnly tgl)
                    tanggal = tgl.ToDateTime(TimeOnly.MinValue);
                else
                    tanggal = Convert.ToDateTime(row["tanggal"]);

                string karyawan = row["karyawan"].ToString();
                int total = Convert.ToInt32(row["total_restock"]);
                bool statusBool = Convert.ToBoolean(row["status"]);

                dgvRestock.Rows.Add(
                    tanggal.ToString("dd-MM-yyyy"),
                    karyawan,
                    "Rp " + total.ToString("N0", new CultureInfo("id-ID")),
                    statusBool ? "Selesai" : "Proses",
                    "Lihat"
                );

                dgvRestock.Rows[dgvRestock.Rows.Count - 1].Tag = id;
            }

            lblJumlahOrder.Text = dt.Rows.Count + " restock ditemukan";
        }

        private void TampilkanDetailRestock(int idRestock)
        {
            pnlPopupSupplier.Visible = false;

            SetupKolomDetail();
            dgvDetailRestock.Rows.Clear();

            DataTable dt = RestockController.AmbilDetailRestock(idRestock);

            foreach (DataRow row in dt.Rows)
            {
                string produk = row["produk"].ToString();
                string foto = row["foto"].ToString();
                int harga = Convert.ToInt32(row["harga"]);
                int qty = Convert.ToInt32(row["kuantitas"]);
                int subtotal = Convert.ToInt32(row["subtotal"]);

                Image gambar = null;

                if (!string.IsNullOrEmpty(foto))
                {
                    string pathFoto = Path.Combine(Application.StartupPath, "Images", foto);
                    if (File.Exists(pathFoto))
                        gambar = Image.FromFile(pathFoto);
                }

                dgvDetailRestock.Rows.Add(
                    gambar,
                    produk,
                    "Rp " + harga.ToString("N0", new CultureInfo("id-ID")),
                    qty,
                    "Rp " + subtotal.ToString("N0", new CultureInfo("id-ID"))
                );
            }

            pnlPopupDetailRestock.Location = new Point(
                (this.Width - pnlPopupDetailRestock.Width) / 2,
                (this.Height - pnlPopupDetailRestock.Height) / 2
            );

            pnlOverlay.Visible = true;
            pnlPopupDetailRestock.Visible = true;
            pnlOverlay.BringToFront();
            pnlPopupDetailRestock.BringToFront();
            btnTutupDetail.BringToFront();
        }

        private void TampilkanSupplier()
        {
            pnlPopupDetailRestock.Visible = false;

            dgvSupplier.DataSource = RestockController.AmbilSupplier();
            dgvSupplier.ClearSelection();
            dgvSupplier.CurrentCell = null;

            pnlPopupSupplier.Location = new Point(
                (this.Width - pnlPopupSupplier.Width) / 2,
                (this.Height - pnlPopupSupplier.Height) / 2
            );

            pnlOverlay.Visible = true;
            pnlPopupSupplier.Visible = true;
            pnlOverlay.BringToFront();
            pnlPopupSupplier.BringToFront();
            btnTutupSupplier.BringToFront();
        }

        private void btnTutupDetail_Click(object sender, EventArgs e)
        {
            pnlPopupDetailRestock.Visible = false;
            pnlPopupSupplier.Visible = false;
            pnlOverlay.Visible = false;
        }

        private void btnTutupSupplier_Click(object sender, EventArgs e)
        {
            pnlPopupSupplier.Visible = false;
            pnlPopupDetailRestock.Visible = false;
            pnlOverlay.Visible = false;
        }

        private void dgvRestock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvRestock.Columns[e.ColumnIndex].Name == "colDetail")
            {
                int idRestock = Convert.ToInt32(dgvRestock.Rows[e.RowIndex].Tag);
                TampilkanDetailRestock(idRestock);
            }
        }

        private void btnTutupDetailRestock_Click(object sender, EventArgs e)
        {
            pnlOverlay.Visible = false;
            pnlPopupDetailRestock.Visible = false;
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            TampilkanSupplier();
        }


        private void btnRestock_Click(object sender, EventArgs e)
        {
            LoadRestock();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FormMain main = this.FindForm() as FormMain;
            if (main != null) main.LoadDashboardAdmin();
        }

        private void btnKaryawan_Click(object sender, EventArgs e)
        {
            FormMain main = this.FindForm() as FormMain;
            if (main != null) main.LoadKaryawanAdmin();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormMain main = this.FindForm() as FormMain;
            if (main != null) main.LoadLogin();
        }

        private void btnDashboard_click(object sender, EventArgs e)
        {
            btnDashboard_Click(sender, e);
        }

        private void txtCariKaryawan_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtCariKaryawan.Text.Trim().ToLower();
            int jumlah = 0;

            dgvRestock.CurrentCell = null;

            foreach (DataGridViewRow row in dgvRestock.Rows)
            {
                if (row.IsNewRow) continue;

                string tanggal = row.Cells["colTanggal"].Value?.ToString().ToLower() ?? "";
                string karyawan = row.Cells["colKaryawan"].Value?.ToString().ToLower() ?? "";
                string total = row.Cells["colTotalRestock"].Value?.ToString().ToLower() ?? "";
                string status = row.Cells["colStatus"].Value?.ToString().ToLower() ?? "";

                bool cocok = tanggal.Contains(keyword) ||
                             karyawan.Contains(keyword) ||
                             total.Contains(keyword) ||
                             status.Contains(keyword);

                row.Visible = cocok;
                if (cocok) jumlah++;
            }

            lblJumlahOrder.Text = jumlah + " restock ditemukan";
        }
    }
}