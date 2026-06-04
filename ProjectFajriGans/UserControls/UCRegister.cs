using System;
using System.Drawing;
using System.Windows.Forms;
using ProjectFajriGans;
using ProjectFajriGans.Models;
using ProjectFajriGans.Controllers;

namespace ProjectFajriGans.UserControls
{
    public partial class UCRegister : UserControl
    {
        public UCRegister()
        {
            InitializeComponent();
            dtpTanggalLahir.MaxDate = DateTime.Now.AddYears(-17);
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormMain? main = this.FindForm() as FormMain;
            if (main != null)
            {
                main.LoadPage(new UCLogin());
            }
        }

        private void UCRegister_Resize(object sender, EventArgs e)
        {
            pnlRegisterForm.Location = new Point(
                (int)(710f * this.Width / 1366f),
                (int)(190f * this.Height / 768f)
            );
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" ||
                txtPassword.Text == "" ||
                txtAlamat.Text == "" ||
                txtNoTelepon.Text == "")
            {
                MessageBox.Show("Semua data harus diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                User user = new User
                {
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                    Alamat = txtAlamat.Text,
                    NoTelepon = txtNoTelepon.Text,
                    TanggalLahir = dtpTanggalLahir.Value
                };

                UserController.Register(user);

                MessageBox.Show("Registrasi berhasil!", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                FormMain? main = this.FindForm() as FormMain;
                if (main != null)
                {
                    main.LoadPage(new UCLogin());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}