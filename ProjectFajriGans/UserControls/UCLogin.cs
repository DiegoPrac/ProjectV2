using System;
using System.Drawing;
using System.Windows.Forms;
using ProjectFajriGans.Controllers;

namespace ProjectFajriGans.UserControls
{
    public partial class UCLogin : UserControl
    {
        public UCLogin()
        {
            InitializeComponent();
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormMain? main = this.FindForm() as FormMain;
            if (main != null)
            {
                main.LoadPage(new UCRegister());
            }
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
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Username dan password harus diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool loginBerhasil = UserController.Login(
                txtUsername.Text,
                txtPassword.Text
            );

            if (loginBerhasil)
            {
                string role = UserController.GetRole(txtUsername.Text);

                MessageBox.Show("Login berhasil sebagai " + role, "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                FormMain? main = this.FindForm() as FormMain;

                if (main != null)
                {
                    if (role == "karyawan")
                    {
                        main.LoadDashboardKaryawan();
                    }
                    else
                    {
                        main.LoadDashboard();
                    }
                }
            }
            else
            {
                MessageBox.Show("Username atau password salah!", "Login gagal",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pnlBackground_Paint(object sender, PaintEventArgs e) { }
    }
}