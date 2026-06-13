using System;
using System.Windows.Forms;
using MyBibit.UserControls;
using MyBibit.Database;

namespace MyBibit
{
    public partial class FormMain : Form
    {
        private UCDashboard? dashboard;

        public FormMain()
        {
            InitializeComponent();

            if (DbTest.TestConnection())
                MessageBox.Show("koneksi Postgre sukses go!");
            else
                MessageBox.Show("koneksi Postgre gagal go!");

            LoadPage(new UCLogin());
        }

        public void LoadPage(UserControl page)
        {
            Controls.Clear();
            page.Dock = DockStyle.Fill;
            Controls.Add(page);
        }

        public void LoadDashboard()
        {
            dashboard = new UCDashboard();
            dashboard.PindahKeCheckout += LoadCheckout;
            dashboard.PindahKeRiwayat += LoadRiwayat;
            LoadPage(dashboard);
        }

        public void LoadDashboardAdmin()
        {
            LoadPage(new UCAdminDashboard());
        }

        public void LoadKaryawanAdmin()
        {
            LoadPage(new UCKaryawanAdmin());
        }

        public void LoadDashboardKaryawan()
        {
            LoadPage(new UCDashboardKaryawan());
        }

        public void LoadOrderDetailKaryawan()
        {
            LoadPage(new UCOrderDetailKaryawan());
        }

        public void LoadRestockAdmin()
        {
            LoadPage(new UCRestockAdmin());
        }

        public void LoadRestockKaryawan()
        {
            LoadPage(new UCRestockKaryawan());
        }

        public void LoadLogin()
        {
            dashboard = null;
            LoadPage(new UCLogin());
        }

        public void LoadCheckout()
        {
            if (dashboard == null)
            {
                LoadDashboard();
                return;
            }

            UCCheckout checkout = new UCCheckout(dashboard.Keranjang);
            checkout.PindahKeDashboard += LoadDashboard;
            checkout.PindahKeRiwayat += LoadRiwayat;
            checkout.PembayaranBerhasil += () =>
            {
                dashboard.SelesaiPembayaran();
            };

            LoadPage(checkout);
        }

        public void LoadRiwayat()
        {
            UCRiwayat riwayat = new UCRiwayat();
            riwayat.PindahKeDashboard += LoadDashboard;
            riwayat.PindahKeCheckout += LoadCheckout;
            LoadPage(riwayat);
        }
    }
}