using System;
using System.Windows.Forms;
using MyBibit.UserControls;
using MyBibit.Database;
using System.Collections.Generic;

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

        public void LoadDashboardKaryawan()
        {
            UCDashboardKaryawan dashboardKaryawan = new UCDashboardKaryawan();
            LoadPage(dashboardKaryawan);
        }

        public void LoadDashboardAdmin()
        {
            UCAdminDashboard admin = new UCAdminDashboard();
            LoadPage(admin);
        }

        public void LoadOrderDetailKaryawan()
        {
            UCOrderDetailKaryawan orderDetail = new UCOrderDetailKaryawan();
            LoadPage(orderDetail);
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