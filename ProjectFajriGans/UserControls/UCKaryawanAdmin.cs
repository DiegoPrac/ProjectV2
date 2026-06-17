using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MyBibit.Controllers;

namespace MyBibit.UserControls
{
    public partial class UCKaryawanAdmin : UserControl
    {
        private int idTerpilih = -1;

        public UCKaryawanAdmin()
        {
            InitializeComponent();

            string namaDepan = Session.Username.Split(' ')[0];
            lblWelcome.Text = "Selamat Datang, " + namaDepan;
            lblInitial.Text = namaDepan.Substring(0, 1).ToUpper();

            SetupDgv();
            LoadKaryawan();

            txtCariKaryawan.TextChanged += txtCariKaryawan_TextChanged;

            btnTambahKaryawan.Click += btnTambahKaryawan_Click;
            btnEditKaryawan.Click += btnEditKaryawan_Click;
            btnNonaktifkan.Click += btnNonaktifkan_Click;
            btnHapusKaryawan.Click += btnHapusKaryawan_Click;
            btnKembali.Click += btnKembali_Click;

            btnLogout.Click += (s, e) =>
            {
                FormMain main = this.FindForm() as FormMain;
                if (main != null) main.LoadLogin();
            };

            btnDashboard.Click += (s, e) =>
            {
                FormMain main = this.FindForm() as FormMain;
                if (main != null) main.LoadDashboardAdmin();
            };
        }

        private void SetupDgv()
        {
            dgvKaryawan.Location = new Point(230, 330);
            dgvKaryawan.Size = new Size(710, 155);
            dgvKaryawan.RowTemplate.Height = 40;
            dgvKaryawan.ScrollBars = ScrollBars.Vertical;

            btnEditKaryawan.Location = new Point(280, 500);
            btnNonaktifkan.Location = new Point(400, 500);
            btnHapusKaryawan.Location = new Point(530, 500);
            btnKembali.Location = new Point(650, 500);
            btnTambahKaryawan.Location = new Point(723, 31);

            dgvKaryawan.ReadOnly = true;
            dgvKaryawan.AllowUserToAddRows = false;
            dgvKaryawan.AllowUserToDeleteRows = false;
            dgvKaryawan.AllowUserToResizeRows = false;
            dgvKaryawan.RowHeadersVisible = false;
            dgvKaryawan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKaryawan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadKaryawan()
        {
            dgvKaryawan.DataSource = UserController.AmbilKaryawan();

            if (dgvKaryawan.Columns["id"] != null)
                dgvKaryawan.Columns["id"].Visible = false;
        }

        private void AmbilIdTerpilih()
        {
            if (dgvKaryawan.CurrentRow == null)
            {
                idTerpilih = -1;
                return;
            }

            idTerpilih = Convert.ToInt32(dgvKaryawan.CurrentRow.Cells["id"].Value);
        }

        private void btnTambahKaryawan_Click(object sender, EventArgs e)
        {
            string username = Microsoft.VisualBasic.Interaction.InputBox("Username:", "Tambah Karyawan");
            if (username == "") return;

            string password = Microsoft.VisualBasic.Interaction.InputBox("Password:", "Tambah Karyawan");
            if (password == "") return;

            string alamat = Microsoft.VisualBasic.Interaction.InputBox("Alamat:", "Tambah Karyawan");
            string noTelp = Microsoft.VisualBasic.Interaction.InputBox("No Telepon:", "Tambah Karyawan");

            UserController.TambahKaryawan(username, password, alamat, noTelp);
            MessageBox.Show("Karyawan berhasil ditambahkan.");
            LoadKaryawan();
        }

        private void btnEditKaryawan_Click(object sender, EventArgs e)
        {
            AmbilIdTerpilih();
            if (idTerpilih == -1) return;

            string usernameLama = dgvKaryawan.CurrentRow.Cells["Username"].Value.ToString();
            string alamatLama = dgvKaryawan.CurrentRow.Cells["Alamat"].Value.ToString();
            string telpLama = dgvKaryawan.CurrentRow.Cells["No Telepon"].Value.ToString();

            string usernameBaru = Microsoft.VisualBasic.Interaction.InputBox("Edit username:", "Edit Karyawan", usernameLama);
            if (usernameBaru == "") return;

            string passwordBaru = Microsoft.VisualBasic.Interaction.InputBox("Password baru, kosongkan jika tidak diubah:", "Edit Karyawan");
            string alamatBaru = Microsoft.VisualBasic.Interaction.InputBox("Edit alamat:", "Edit Karyawan", alamatLama);
            string telpBaru = Microsoft.VisualBasic.Interaction.InputBox("Edit no telepon:", "Edit Karyawan", telpLama);

            UserController.EditKaryawan(idTerpilih, usernameBaru, passwordBaru, alamatBaru, telpBaru);
            MessageBox.Show("Data karyawan berhasil diedit.");
            LoadKaryawan();
        }

        private void btnNonaktifkan_Click(object sender, EventArgs e)
        {
            AmbilIdTerpilih();
            if (idTerpilih == -1) return;

            string statusSekarang = dgvKaryawan.CurrentRow.Cells["Status"].Value.ToString();
            bool statusBaru = statusSekarang != "Aktif";

            UserController.UpdateStatusKaryawan(idTerpilih, statusBaru);
            MessageBox.Show(statusBaru ? "Akun diaktifkan." : "Akun dinonaktifkan.");
            LoadKaryawan();
        }

        private void btnHapusKaryawan_Click(object sender, EventArgs e)
        {
            AmbilIdTerpilih();
            if (idTerpilih == -1) return;

            if (MessageBox.Show("Yakin hapus karyawan ini?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UserController.HapusKaryawan(idTerpilih);
                MessageBox.Show("Karyawan berhasil dihapus.");
                LoadKaryawan();
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            FormMain main = this.FindForm() as FormMain;
            if (main != null) main.LoadDashboardAdmin();
        }

        private void txtCariKaryawan_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtCariKaryawan.Text.Trim().Replace("'", "''");

            if (dgvKaryawan.DataSource is DataTable dt)
            {
                dt.DefaultView.RowFilter =
                    $"Convert([Username], 'System.String') LIKE '%{keyword}%' OR " +
                    $"Convert([Alamat], 'System.String') LIKE '%{keyword}%' OR " +
                    $"Convert([No Telepon], 'System.String') LIKE '%{keyword}%' OR " +
                    $"Convert([Status], 'System.String') LIKE '%{keyword}%'";
            }
        }

        private void btnRestock_Click(object sender, EventArgs e)
        {
            FormMain main = this.FindForm() as FormMain;
            if (main != null)
                main.LoadRestockAdmin();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }
    }
}