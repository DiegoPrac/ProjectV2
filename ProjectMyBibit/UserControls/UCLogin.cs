using System;
using System.Drawing;
using System.Windows.Forms;
using MyBibit.Controllers;

namespace MyBibit.UserControls
{
    public partial class UCLogin : UserControl
    {
        public UCLogin()
        {
            InitializeComponent();
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormMain main = this.FindForm() as FormMain;
            if (main != null)
                main.LoadPage(new UCRegister());
        }

        private void UCLogin_Resize(object sender, EventArgs e)
        {
            pnlLoginForm.Location = new Point(
                (int)(710f * this.Width / 1366f),
                (int)(190f * this.Height / 768f)
            );
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Username dan password harus diisi!");
                return;
            }

            bool loginBerhasil = UserController.Login(username, password);

            if (!loginBerhasil)
            {
                MessageBox.Show("Username atau password salah / akun nonaktif!");
                return;
            }

            string role = UserController.GetRole(username).Trim().ToLower();

            Session.Username = username;
            Session.Role = role;

            FormMain main = this.FindForm() as FormMain;
            if (main == null) return;

            if (role == "admin")
                main.LoadDashboardAdmin();
            else if (role == "karyawan")
                main.LoadDashboardKaryawan();
            else
                main.LoadDashboard();
        }

        private void pnlBackground_Paint(object sender, PaintEventArgs e) { }
    }
}