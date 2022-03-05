using NOTEBOARD.BLL.Services;
using NOTEBOARD.Model.Entities;
using NOTEBOARD.Model.Enums;
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
    public partial class frmLogin : Form
    {
        UserService userService;
        public frmLogin()
        {
            InitializeComponent();
            userService = new UserService();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string userName = txtKullaniciAdi.Text;
            string password = txtSifre.Text;
            User user = userService.CheckLogin(userName, password);
            if (user != null)
            {
                //Login olabilir
                if (!user.IsActive)
                {
                    //bilgileri yanlış veya aktif kullanıcı değil veya kayıtlı değil 
                    MessageBox.Show("Admin sizi onaylamamış");
                    return;
                }

                switch (user.UserType)
                {
                    case UserType.Admin:
                        frmAdmin frmAdmin = new frmAdmin();
                        this.Hide();
                        frmAdmin.ShowDialog();
                        this.Show();
                        break;
                    case UserType.Standard:
                        frmMain frmMain = new frmMain(user);
                        this.Hide();
                        frmMain.ShowDialog();

                        this.Show();
                        userService = new UserService();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Lütfen bilgilerinizi kontrol edin. Eğer üye kaydınız yoksa kayıt olunuz");
            }
        }

        private void linkLblKayit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister registerForm = new frmRegister();
            this.Hide();
            registerForm.ShowDialog();
            this.Show();
        }
    }
}
