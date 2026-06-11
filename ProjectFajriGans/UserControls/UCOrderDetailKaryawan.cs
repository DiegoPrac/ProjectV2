using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using MyBibit.Controllers;

namespace MyBibit.UserControls
{
    public partial class UCOrderDetailKaryawan : UserControl
    {
        private bool sedangLoad = false;

        public UCOrderDetailKaryawan()
        {
            InitializeComponent();

            string namaDepan = Session.Username.Split(' ')[0];

            lblTanggal.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy", new CultureInfo("id-ID"));

            lblLogo.Text = namaDepan.Substring(0, 1).ToUpper();
            lblTitle.Text = "MyBibit";

            SetupTampilan();
            LoadOrder();
        }

        private void SetupTampilan()
        {
            pnlOverlay.Dock = DockStyle.Fill;
            pnlOverlay.BackColor = Color.FromArgb(150, 0, 0, 0);
            pnlOverlay.Visible = false;
            pnlPopupDetailOrder.Visible = false;

            dgvOrder.AutoGenerateColumns = false;
            dgvOrder.AllowUserToAddRows = false;
            dgvOrder.AllowUserToDeleteRows = false;
            dgvOrder.AllowUserToResizeColumns = false;
            dgvOrder.AllowUserToResizeRows = false;
            dgvOrder.AllowUserToOrderColumns = false;
            dgvOrder.RowHeadersVisible = false;
            dgvOrder.MultiSelect = false;
            dgvOrder.SelectionMode = DataGridViewSelectionMode.CellSelect;

            dgvOrder.ReadOnly = false;
            colTanggal.ReadOnly = true;
            colCustomer.ReadOnly = true;
            colTotalOrder.ReadOnly = true;
            colStatus.ReadOnly = false;
            colDetail.ReadOnly = true;

            dgvOrder.CurrentCellDirtyStateChanged += dgvOrder_CurrentCellDirtyStateChanged;
            dgvOrder.CellValueChanged += dgvOrder_CellValueChanged;

            dgvDetailOrder.AutoGenerateColumns = false;
            dgvDetailOrder.AllowUserToAddRows = false;
            dgvDetailOrder.AllowUserToDeleteRows = false;
            dgvDetailOrder.AllowUserToResizeColumns = false;
            dgvDetailOrder.AllowUserToResizeRows = false;
            dgvDetailOrder.AllowUserToOrderColumns = false;
            dgvDetailOrder.RowHeadersVisible = false;
            dgvDetailOrder.MultiSelect = false;
            dgvDetailOrder.ReadOnly = true;
            dgvDetailOrder.RowTemplate.Height = 80;
            dgvDetailOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            colFoto.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colFoto.Width = 120;

            colDetail.Text = "Lihat";
            colDetail.UseColumnTextForButtonValue = true;

            txtCariBibit.TextChanged += txtCariBibit_TextChanged;

            btnOrderDetail.BackColor = Color.White;
            btnOrderDetail.ForeColor = Color.FromArgb(22, 101, 52);

            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.ForeColor = Color.White;
        }

        private void LoadOrder()
        {
            sedangLoad = true;
            dgvOrder.Rows.Clear();

            DataTable dt = OrderController.AmbilSemuaOrder();

            foreach (DataRow row in dt.Rows)
            {
                int id = Convert.ToInt32(row["id"]);

                DateTime tanggal;
                if (row["tanggal"] is DateOnly tgl)
                    tanggal = tgl.ToDateTime(TimeOnly.MinValue);
                else
                    tanggal = Convert.ToDateTime(row["tanggal"]);

                string customer = row["customer"].ToString();
                int total = Convert.ToInt32(row["total_order"]);

                bool statusBool = Convert.ToBoolean(row["status"]);
                string status = statusBool ? "Selesai" : "Diproses";

                dgvOrder.Rows.Add(
                    tanggal.ToString("dd-MM-yyyy"),
                    customer,
                    "Rp " + total.ToString("N0", new CultureInfo("id-ID")),
                    status,
                    "Lihat"
                );

                dgvOrder.Rows[dgvOrder.Rows.Count - 1].Tag = id;
            }

            lblJumlahOrder.Text = dt.Rows.Count + " order ditemukan";
            sedangLoad = false;
        }

        private void TampilkanDetailOrder(int idOrder)
        {
            dgvDetailOrder.Rows.Clear();

            DataTable dt = OrderController.AmbilDetailOrder(idOrder);
            int total = 0;

            foreach (DataRow row in dt.Rows)
            {
                string produk = row["produk"].ToString();
                string foto = row["foto"].ToString();
                int harga = Convert.ToInt32(row["harga"]);
                int qty = Convert.ToInt32(row["kuantitas"]);
                int subtotal = Convert.ToInt32(row["subtotal"]);

                total += subtotal;

                Image gambar = null;

                if (!string.IsNullOrEmpty(foto))
                {
                    string pathFoto = Path.Combine(Application.StartupPath, "Images", foto);

                    if (File.Exists(pathFoto))
                        gambar = Image.FromFile(pathFoto);
                }

                dgvDetailOrder.Rows.Add(
                    gambar,
                    produk,
                    "Rp " + harga.ToString("N0", new CultureInfo("id-ID")),
                    qty,
                    "Rp " + subtotal.ToString("N0", new CultureInfo("id-ID"))
                );
            }

            lblTotalDetailOrder.Text = "Total : Rp " + total.ToString("N0", new CultureInfo("id-ID"));

            pnlPopupDetailOrder.Location = new Point(
                (this.Width - pnlPopupDetailOrder.Width) / 2,
                (this.Height - pnlPopupDetailOrder.Height) / 2
            );

            pnlOverlay.Visible = true;
            pnlPopupDetailOrder.Visible = true;
            pnlOverlay.BringToFront();
            pnlPopupDetailOrder.BringToFront();
        }

        private void dgvOrder_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvOrder.IsCurrentCellDirty)
                dgvOrder.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dgvOrder_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (sedangLoad) return;
            if (e.RowIndex < 0) return;

            if (dgvOrder.Columns[e.ColumnIndex].Name == "colStatus")
            {
                int idOrder = Convert.ToInt32(dgvOrder.Rows[e.RowIndex].Tag);
                string statusBaru = dgvOrder.Rows[e.RowIndex].Cells["colStatus"].Value.ToString();

                bool status = statusBaru == "Selesai";

                OrderController.UpdateStatusOrder(idOrder, status);
                MessageBox.Show("Status berhasil diupdate!");
            }
        }

        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvOrder.Columns[e.ColumnIndex].Name == "colDetail")
            {
                int idOrder = Convert.ToInt32(dgvOrder.Rows[e.RowIndex].Tag);
                TampilkanDetailOrder(idOrder);
            }
        }

        private void btnTutupDetail_Click(object sender, EventArgs e)
        {
            pnlOverlay.Visible = false;
            pnlPopupDetailOrder.Visible = false;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FormMain main = this.FindForm() as FormMain;
            if (main != null) main.LoadDashboardKaryawan();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormMain main = this.FindForm() as FormMain;
            if (main != null) main.LoadLogin();
        }

        private void btnOrderDetail_Click(object sender, EventArgs e)
        {
            LoadOrder();
        }

        private void txtCariBibit_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtCariBibit.Text.Trim().ToLower();

            dgvOrder.CurrentCell = null;

            int jumlah = 0;

            foreach (DataGridViewRow row in dgvOrder.Rows)
            {
                if (row.IsNewRow) continue;

                string tanggal = row.Cells["colTanggal"].Value?.ToString()?.ToLower() ?? "";
                string customer = row.Cells["colCustomer"].Value?.ToString()?.ToLower() ?? "";
                string total = row.Cells["colTotalOrder"].Value?.ToString()?.ToLower() ?? "";
                string status = row.Cells["colStatus"].Value?.ToString()?.ToLower() ?? "";

                bool cocok =
                    tanggal.Contains(keyword) ||
                    customer.Contains(keyword) ||
                    total.Contains(keyword) ||
                    status.Contains(keyword);

                row.Visible = cocok;

                if (cocok)
                    jumlah++;
            }

            lblJumlahOrder.Text = jumlah + " order ditemukan";
        }
    }
}