
namespace NOTEBOARD
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNewNote = new System.Windows.Forms.Button();
            this.lstNotes = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.linkLblSifre = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnNewNote
            // 
            this.btnNewNote.Location = new System.Drawing.Point(424, 13);
            this.btnNewNote.Name = "btnNewNote";
            this.btnNewNote.Size = new System.Drawing.Size(118, 34);
            this.btnNewNote.TabIndex = 23;
            this.btnNewNote.Text = "YENİ NOT";
            this.btnNewNote.UseVisualStyleBackColor = true;
            this.btnNewNote.Click += new System.EventHandler(this.btnNewNote_Click);
            // 
            // lstNotes
            // 
            this.lstNotes.FormattingEnabled = true;
            this.lstNotes.ItemHeight = 25;
            this.lstNotes.Location = new System.Drawing.Point(12, 12);
            this.lstNotes.Name = "lstNotes";
            this.lstNotes.Size = new System.Drawing.Size(227, 429);
            this.lstNotes.TabIndex = 22;
            this.lstNotes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstNotes_MouseClick);
            // 
            // btnEkle
            // 
            this.btnEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEkle.Location = new System.Drawing.Point(460, 451);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(159, 39);
            this.btnEkle.TabIndex = 21;
            this.btnEkle.Text = "KAYDET";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(291, 12);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(127, 34);
            this.btnSil.TabIndex = 20;
            this.btnSil.Text = "NOT SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(245, 83);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(376, 362);
            this.txtContent.TabIndex = 19;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(245, 53);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(376, 30);
            this.txtTitle.TabIndex = 18;
            // 
            // linkLblSifre
            // 
            this.linkLblSifre.AutoSize = true;
            this.linkLblSifre.Location = new System.Drawing.Point(12, 458);
            this.linkLblSifre.Name = "linkLblSifre";
            this.linkLblSifre.Size = new System.Drawing.Size(122, 25);
            this.linkLblSifre.TabIndex = 17;
            this.linkLblSifre.TabStop = true;
            this.linkLblSifre.Text = "Şifre Değiştir";
            this.linkLblSifre.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblSifre_LinkClicked);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 502);
            this.Controls.Add(this.btnNewNote);
            this.Controls.Add(this.lstNotes);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.linkLblSifre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewNote;
        private System.Windows.Forms.ListBox lstNotes;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.LinkLabel linkLblSifre;
    }
}