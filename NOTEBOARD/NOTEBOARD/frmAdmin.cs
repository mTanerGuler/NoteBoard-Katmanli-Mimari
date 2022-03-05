
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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
            userService = new UserService();
        }
        UserService userService;
        List<User> passiveUser;
        private void frmAdmin_Load(object sender, EventArgs e)
        {
            passiveUser = userService.GetPasiveUser();
            FillListView();
        }
        private void FillListView()
        {
            lvUsers.Items.Clear();
            ListViewItem lvi;
            foreach (User item in passiveUser)
            {
                lvi = new ListViewItem();
                lvi.Text = item.FirstName;
                lvi.SubItems.Add(item.LastName);
                lvi.SubItems.Add(item.UserName);
                lvi.SubItems.Add(item.IsActive ? "Aktif" : "Pasif");
                lvi.Tag = item.ID;
                lvUsers.Items.Add(lvi);
            }
        }

        private void lvUsers_DoubleClick(object sender, EventArgs e)
        {
            int userID =Convert.ToInt32(lvUsers.SelectedItems[0].Tag);
            userService.UserActived(userID);
            FillListView();

        }
    }
}
