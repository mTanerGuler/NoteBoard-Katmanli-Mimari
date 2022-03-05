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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
            UserService userService = new UserService();
        }
        UserService userService;
        private void btnKaydet_Click(object sender, EventArgs e)
        {

            if (txtSifre.Text != txtSifreTekrar.Text)
            {
                MessageBox.Show("Şifreler uyuşmuyor");
                return;
            }
            try
            {
                //Kullanıcı Kayıt olacak
                User user = new User()
                {
                    FirstName = txtAd.Text,
                    LastName = txtSoyad.Text,
                    UserName = txtKAdi.Text,
                };
                user.Passwords.Add(new Password()
                {

                    Text = txtSifre.Text
                });

                bool check = userService.Insert(user);
                MessageBox.Show(check ? "Kayıt gerçekleşti" : "Bilgilerinizi kontrol ediniz");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
