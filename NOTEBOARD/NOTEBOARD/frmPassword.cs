using NOTEBOARD.BLL.Services;
using NOTEBOARD.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NOTEBOARD
{
    public partial class frmPassword : Form
    {
        public frmPassword(User user)
        {
            InitializeComponent();
            this.user = user;
            passwordService = new PasswordService();
        }
        User user;
        PasswordService passwordService;
        private void btnSifreDegistir_Click(object sender, EventArgs e)
        {
            Password activePassword = passwordService.GetActivePassword(user.ID);
            if (txtEskiSifre.Text != activePassword.Text)
            {
                MessageBox.Show("Lütfen şu an kullandığınız şifreyi doğru girin");
                return;
            }

            if (txtyeniSifre.Text != txtYeniSifreTekrar.Text)
            {
                MessageBox.Show("Yeni şifreler uyuşmuyor");
                return;
            }

            bool check = passwordService.Insert(new Password()
            {
                Text = txtyeniSifre.Text,
                UserID = user.ID
            });
            MessageBox.Show(check ? "Şifre Değiştirildi" : "Şifre değiştirilirken bir hata oluştu.");
        }
    }
}
