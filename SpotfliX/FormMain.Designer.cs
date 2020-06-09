namespace SpotfliX
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelPlayer = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.AddArtistButton = new System.Windows.Forms.Button();
            this.UsersButton = new System.Windows.Forms.Button();
            this.AdminAddMedia = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.panelAddMedia = new System.Windows.Forms.Panel();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.MetadataBox = new System.Windows.Forms.GroupBox();
            this.MetaGrid = new System.Windows.Forms.DataGridView();
            this.panelMediaType = new System.Windows.Forms.Panel();
            this.radioVideo = new System.Windows.Forms.RadioButton();
            this.radioSong = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.FileButton = new System.Windows.Forms.Button();
            this.BackAddMedia = new System.Windows.Forms.Button();
            this.AddMedia = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelAddArtist = new System.Windows.Forms.Panel();
            this.TestLabel = new System.Windows.Forms.Label();
            this.BackAddArtist = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ArtistNameBox = new System.Windows.Forms.TextBox();
            this.ArtistNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.panelAdmin.SuspendLayout();
            this.panelAddMedia.SuspendLayout();
            this.MetadataBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MetaGrid)).BeginInit();
            this.panelMediaType.SuspendLayout();
            this.panelAddArtist.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1922, 104);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panelPlayer
            // 
            this.panelPlayer.Controls.Add(this.axWindowsMediaPlayer1);
            this.panelPlayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPlayer.Location = new System.Drawing.Point(0, 954);
            this.panelPlayer.Name = "panelPlayer";
            this.panelPlayer.Size = new System.Drawing.Size(1922, 80);
            this.panelPlayer.TabIndex = 8;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 33);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(1922, 47);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // ProfileButton
            // 
            this.ProfileButton.AutoSize = true;
            this.ProfileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProfileButton.FlatAppearance.BorderSize = 0;
            this.ProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfileButton.ForeColor = System.Drawing.Color.Transparent;
            this.ProfileButton.Image = ((System.Drawing.Image)(resources.GetObject("ProfileButton.Image")));
            this.ProfileButton.Location = new System.Drawing.Point(907, 12);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(73, 73);
            this.ProfileButton.TabIndex = 9;
            this.ProfileButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ProfileButton.UseVisualStyleBackColor = false;
            this.ProfileButton.Click += new System.EventHandler(this.ProfileButton_Click);
            // 
            // panelAdmin
            // 
            this.panelAdmin.Controls.Add(this.AddArtistButton);
            this.panelAdmin.Controls.Add(this.UsersButton);
            this.panelAdmin.Controls.Add(this.AdminAddMedia);
            this.panelAdmin.Location = new System.Drawing.Point(457, 104);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(392, 660);
            this.panelAdmin.TabIndex = 10;
            // 
            // AddArtistButton
            // 
            this.AddArtistButton.AutoSize = true;
            this.AddArtistButton.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddArtistButton.Location = new System.Drawing.Point(86, 242);
            this.AddArtistButton.Name = "AddArtistButton";
            this.AddArtistButton.Size = new System.Drawing.Size(169, 49);
            this.AddArtistButton.TabIndex = 2;
            this.AddArtistButton.Text = "Add Artist";
            this.AddArtistButton.UseVisualStyleBackColor = true;
            // 
            // UsersButton
            // 
            this.UsersButton.AutoSize = true;
            this.UsersButton.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersButton.Location = new System.Drawing.Point(86, 326);
            this.UsersButton.Name = "UsersButton";
            this.UsersButton.Size = new System.Drawing.Size(169, 49);
            this.UsersButton.TabIndex = 1;
            this.UsersButton.Text = "Users";
            this.UsersButton.UseVisualStyleBackColor = true;
            // 
            // AdminAddMedia
            // 
            this.AdminAddMedia.AutoSize = true;
            this.AdminAddMedia.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminAddMedia.Location = new System.Drawing.Point(86, 160);
            this.AdminAddMedia.Name = "AdminAddMedia";
            this.AdminAddMedia.Size = new System.Drawing.Size(169, 49);
            this.AdminAddMedia.TabIndex = 0;
            this.AdminAddMedia.Text = "Add Media";
            this.AdminAddMedia.UseVisualStyleBackColor = true;
            // 
            // SearchBox
            // 
            this.SearchBox.AcceptsReturn = true;
            this.SearchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.SearchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.SearchBox.BackColor = System.Drawing.SystemColors.GrayText;
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.SearchBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.Location = new System.Drawing.Point(258, 104);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(150, 30);
            this.SearchBox.TabIndex = 13;
            this.SearchBox.Text = "   Search";
            this.SearchBox.Click += new System.EventHandler(this.SearchBox_Click);
            this.SearchBox.Leave += new System.EventHandler(this.SearchBox_Leave);
            // 
            // panelAddMedia
            // 
            this.panelAddMedia.Controls.Add(this.FileNameLabel);
            this.panelAddMedia.Controls.Add(this.MetadataBox);
            this.panelAddMedia.Controls.Add(this.panelMediaType);
            this.panelAddMedia.Controls.Add(this.label1);
            this.panelAddMedia.Controls.Add(this.FileButton);
            this.panelAddMedia.Controls.Add(this.BackAddMedia);
            this.panelAddMedia.Controls.Add(this.AddMedia);
            this.panelAddMedia.ForeColor = System.Drawing.Color.Black;
            this.panelAddMedia.Location = new System.Drawing.Point(1393, 110);
            this.panelAddMedia.Name = "panelAddMedia";
            this.panelAddMedia.Size = new System.Drawing.Size(504, 660);
            this.panelAddMedia.TabIndex = 11;
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileNameLabel.ForeColor = System.Drawing.Color.White;
            this.FileNameLabel.Location = new System.Drawing.Point(230, 53);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(0, 29);
            this.FileNameLabel.TabIndex = 8;
            // 
            // MetadataBox
            // 
            this.MetadataBox.AutoSize = true;
            this.MetadataBox.Controls.Add(this.MetaGrid);
            this.MetadataBox.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetadataBox.ForeColor = System.Drawing.Color.White;
            this.MetadataBox.Location = new System.Drawing.Point(26, 218);
            this.MetadataBox.Name = "MetadataBox";
            this.MetadataBox.Size = new System.Drawing.Size(449, 344);
            this.MetadataBox.TabIndex = 7;
            this.MetadataBox.TabStop = false;
            this.MetadataBox.Text = "Metadata";
            // 
            // MetaGrid
            // 
            this.MetaGrid.ColumnHeadersHeight = 34;
            this.MetaGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.MetaGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MetaGrid.Location = new System.Drawing.Point(3, 38);
            this.MetaGrid.MultiSelect = false;
            this.MetaGrid.Name = "MetaGrid";
            this.MetaGrid.RowHeadersVisible = false;
            this.MetaGrid.RowHeadersWidth = 62;
            this.MetaGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetaGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.MetaGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.MetaGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MetaGrid.RowTemplate.Height = 24;
            this.MetaGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.MetaGrid.Size = new System.Drawing.Size(443, 303);
            this.MetaGrid.TabIndex = 0;
            this.MetaGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MetaGrid_CellContentClick);
            // 
            // panelMediaType
            // 
            this.panelMediaType.Controls.Add(this.radioVideo);
            this.panelMediaType.Controls.Add(this.radioSong);
            this.panelMediaType.Location = new System.Drawing.Point(250, 120);
            this.panelMediaType.Name = "panelMediaType";
            this.panelMediaType.Size = new System.Drawing.Size(124, 92);
            this.panelMediaType.TabIndex = 6;
            // 
            // radioVideo
            // 
            this.radioVideo.AutoSize = true;
            this.radioVideo.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioVideo.ForeColor = System.Drawing.Color.White;
            this.radioVideo.Location = new System.Drawing.Point(3, 40);
            this.radioVideo.Name = "radioVideo";
            this.radioVideo.Size = new System.Drawing.Size(83, 28);
            this.radioVideo.TabIndex = 4;
            this.radioVideo.TabStop = true;
            this.radioVideo.Text = "Video";
            this.radioVideo.UseVisualStyleBackColor = true;
            this.radioVideo.CheckedChanged += new System.EventHandler(this.radioVideo_CheckedChanged);
            // 
            // radioSong
            // 
            this.radioSong.AutoSize = true;
            this.radioSong.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSong.ForeColor = System.Drawing.Color.White;
            this.radioSong.Location = new System.Drawing.Point(0, 0);
            this.radioSong.Name = "radioSong";
            this.radioSong.Size = new System.Drawing.Size(75, 28);
            this.radioSong.TabIndex = 5;
            this.radioSong.TabStop = true;
            this.radioSong.Text = "Song";
            this.radioSong.UseVisualStyleBackColor = true;
            this.radioSong.CheckedChanged += new System.EventHandler(this.radioSong_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(30, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Type of Media";
            // 
            // FileButton
            // 
            this.FileButton.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileButton.Location = new System.Drawing.Point(37, 38);
            this.FileButton.Name = "FileButton";
            this.FileButton.Size = new System.Drawing.Size(158, 54);
            this.FileButton.TabIndex = 2;
            this.FileButton.Text = "File...";
            this.FileButton.UseVisualStyleBackColor = true;
            this.FileButton.Click += new System.EventHandler(this.FileButton_Click);
            // 
            // BackAddMedia
            // 
            this.BackAddMedia.AutoSize = true;
            this.BackAddMedia.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackAddMedia.Location = new System.Drawing.Point(26, 588);
            this.BackAddMedia.Name = "BackAddMedia";
            this.BackAddMedia.Size = new System.Drawing.Size(169, 49);
            this.BackAddMedia.TabIndex = 1;
            this.BackAddMedia.Text = "Back";
            this.BackAddMedia.UseVisualStyleBackColor = true;
            // 
            // AddMedia
            // 
            this.AddMedia.AutoSize = true;
            this.AddMedia.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMedia.Location = new System.Drawing.Point(306, 588);
            this.AddMedia.Name = "AddMedia";
            this.AddMedia.Size = new System.Drawing.Size(169, 49);
            this.AddMedia.TabIndex = 0;
            this.AddMedia.Text = "Add Media";
            this.AddMedia.UseVisualStyleBackColor = true;
            this.AddMedia.Click += new System.EventHandler(this.AddMedia_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Add Media";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // panelAddArtist
            // 
            this.panelAddArtist.Controls.Add(this.TestLabel);
            this.panelAddArtist.Controls.Add(this.BackAddArtist);
            this.panelAddArtist.Controls.Add(this.button1);
            this.panelAddArtist.Controls.Add(this.ArtistNameBox);
            this.panelAddArtist.Controls.Add(this.ArtistNameLabel);
            this.panelAddArtist.Controls.Add(this.label2);
            this.panelAddArtist.Location = new System.Drawing.Point(863, 115);
            this.panelAddArtist.Name = "panelAddArtist";
            this.panelAddArtist.Size = new System.Drawing.Size(506, 654);
            this.panelAddArtist.TabIndex = 14;
            // 
            // TestLabel
            // 
            this.TestLabel.AutoSize = true;
            this.TestLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TestLabel.Location = new System.Drawing.Point(144, 315);
            this.TestLabel.Name = "TestLabel";
            this.TestLabel.Size = new System.Drawing.Size(74, 29);
            this.TestLabel.TabIndex = 8;
            this.TestLabel.Text = "label3";
            // 
            // BackAddArtist
            // 
            this.BackAddArtist.AutoSize = true;
            this.BackAddArtist.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackAddArtist.Location = new System.Drawing.Point(44, 583);
            this.BackAddArtist.Name = "BackAddArtist";
            this.BackAddArtist.Size = new System.Drawing.Size(169, 49);
            this.BackAddArtist.TabIndex = 4;
            this.BackAddArtist.Text = "Back";
            this.BackAddArtist.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(301, 583);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 49);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add Artist";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ArtistNameBox
            // 
            this.ArtistNameBox.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArtistNameBox.Location = new System.Drawing.Point(160, 104);
            this.ArtistNameBox.Name = "ArtistNameBox";
            this.ArtistNameBox.Size = new System.Drawing.Size(186, 32);
            this.ArtistNameBox.TabIndex = 7;
            // 
            // ArtistNameLabel
            // 
            this.ArtistNameLabel.AutoSize = true;
            this.ArtistNameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArtistNameLabel.ForeColor = System.Drawing.Color.White;
            this.ArtistNameLabel.Location = new System.Drawing.Point(54, 104);
            this.ArtistNameLabel.Name = "ArtistNameLabel";
            this.ArtistNameLabel.Size = new System.Drawing.Size(73, 29);
            this.ArtistNameLabel.TabIndex = 1;
            this.ArtistNameLabel.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "Add Artist";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tag";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Value";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1922, 1034);
            this.Controls.Add(this.panelAddArtist);
            this.Controls.Add(this.panelAddMedia);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.panelAdmin);
            this.Controls.Add(this.ProfileButton);
            this.Controls.Add(this.panelPlayer);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "SpotfliX";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.VisibleChanged += new System.EventHandler(this.FormMain_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelPlayer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.panelAdmin.ResumeLayout(false);
            this.panelAdmin.PerformLayout();
            this.panelAddMedia.ResumeLayout(false);
            this.panelAddMedia.PerformLayout();
            this.MetadataBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MetaGrid)).EndInit();
            this.panelMediaType.ResumeLayout(false);
            this.panelMediaType.PerformLayout();
            this.panelAddArtist.ResumeLayout(false);
            this.panelAddArtist.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelPlayer;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button UsersButton;
        private System.Windows.Forms.Button AdminAddMedia;
        private System.Windows.Forms.Panel panelAddMedia;
        private System.Windows.Forms.Button FileButton;
        private System.Windows.Forms.Button BackAddMedia;
        private System.Windows.Forms.Button AddMedia;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RadioButton radioSong;
        private System.Windows.Forms.RadioButton radioVideo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMediaType;
        private System.Windows.Forms.GroupBox MetadataBox;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.DataGridView MetaGrid;
        private System.Windows.Forms.Button AddArtistButton;
        private System.Windows.Forms.Panel panelAddArtist;
        private System.Windows.Forms.Button BackAddArtist;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ArtistNameBox;
        private System.Windows.Forms.Label ArtistNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TestLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}