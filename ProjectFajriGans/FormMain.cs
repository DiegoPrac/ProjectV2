using System;
using System.Windows.Forms;
using ProjectFajriGans.UserControls;
using ProjectFajriGans.Database;

namespace ProjectFajriGans
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
            if (dashboard == null)
            {
                dashboard = new UCDashboard();
                dashboard.PindahKeCheckout += LoadCheckout;
            }

            LoadPage(dashboard);
        }

        public void LoadCheckout()
        {
            if (dashboard == null)
            {
                LoadDashboard();
                return;
            }

            UCCheckout checkout = new UCCheckout(
                dashboard.JumlahMangga,
                dashboard.JumlahCabai,
                dashboard.JumlahJambu,
                dashboard.JumlahJeruk,
                dashboard.JumlahAlpukat,
                dashboard.JumlahRambutan
            );

            checkout.PindahKeDashboard += LoadDashboard;

            checkout.PembayaranBerhasil += () =>
            {
                dashboard.SelesaiPembayaran();
            };

            LoadPage(checkout);
        }
    }
}