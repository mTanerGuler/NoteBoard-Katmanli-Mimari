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
    public partial class frmMain : Form
    {
        NoteService noteService;
        public frmMain(User user)
        {
            InitializeComponent();
            this.user = user;
            noteService = new NoteService();
        }
        User user;

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtHide();
            List<Note> notes = noteService.GetById(user.ID);
            lstNotes.DataSource = notes;
            lstNotes.DisplayMember = "Title";
            lstNotes.ValueMember = "ID";
        }
        void txtHide()
        {
            txtContent.Hide();
            txtTitle.Hide();
        }
        void txtClear()
        {
            txtContent.Clear();
            txtTitle.Clear();
        }
        void txtShow()
        {
            txtContent.Show();
            txtTitle.Show();
        }
        private void btnNewNote_Click(object sender, EventArgs e)
        {
            lstNotes.SelectedIndex = -1;
            txtShow();
            txtClear();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            bool check;
            if (lstNotes.SelectedIndex == -1)
            {

                //addNote
                check = noteService.Insert(new Note()
                {
                    Content = txtContent.Text,
                    Title = txtTitle.Text,
                    UserID = user.ID
                });
                MessageBox.Show(check ? "Ekleme başarılı" : "Ekleme başarısız");
                txtClear();
                txtHide();
            }
            else
            {
                //UpdateNote 

                int noteID = Convert.ToInt32(lstNotes.SelectedValue);
                check = noteService.Update(new Note()
                {
                    ID = noteID,
                    Content = txtContent.Text,
                    Title = txtTitle.Text
                });
                MessageBox.Show(check ? "Güncelleme başarılı" : "Güncelleme başarısız");
            }
        }

        private void lstNotes_MouseClick(object sender, MouseEventArgs e)
        {
            txtShow();
            int noteID = Convert.ToInt32(lstNotes.SelectedValue);
            Note note = noteService.GetByNoteId(noteID);
            txtTitle.Text = note.Title;
            txtContent.Text = note.Content;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int noteID = Convert.ToInt32(lstNotes.SelectedValue);
            bool check = noteService.Delete(noteID);
            MessageBox.Show(check ? "Silme başarılı" : "Silme başarısız");
        }

        private void linkLblSifre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPassword frmPassword = new frmPassword(user);
            frmPassword.ShowDialog();
        }
    }
}
