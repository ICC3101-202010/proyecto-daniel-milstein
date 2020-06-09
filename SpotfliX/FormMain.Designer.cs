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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelPlayer = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.panelAdmin = new System.Windows.Forms.Panel();
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
            this.panelShowMedia = new System.Windows.Forms.Panel();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MediaGrid = new System.Windows.Forms.DataGridView();
            this.spotflixBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArtistCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShowMediaButton = new System.Windows.Forms.Button();
            this.BackMediaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.panelAdmin.SuspendLayout();
            this.panelAddMedia.SuspendLayout();
            this.MetadataBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MetaGrid)).BeginInit();
            this.panelMediaType.SuspendLayout();
            this.panelShowMedia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MediaGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spotflixBindingSource)).BeginInit();
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
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
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
            this.panelAdmin.Controls.Add(this.ShowMediaButton);
            this.panelAdmin.Controls.Add(this.UsersButton);
            this.panelAdmin.Controls.Add(this.AdminAddMedia);
            this.panelAdmin.Location = new System.Drawing.Point(457, 104);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(392, 660);
            this.panelAdmin.TabIndex = 10;
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
            this.AdminAddMedia.Click += new System.EventHandler(this.AdminAddMedia_Click);
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
            this.panelAddMedia.Visible = false;
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
            this.MetadataBox.Location = new System.Drawing.Point(3, 207);
            this.MetadataBox.Name = "MetadataBox";
            this.MetadataBox.Size = new System.Drawing.Size(498, 360);
            this.MetadataBox.TabIndex = 7;
            this.MetadataBox.TabStop = false;
            this.MetadataBox.Text = "Metadata";
            // 
            // MetaGrid
            // 
            this.MetaGrid.AllowUserToAddRows = false;
            this.MetaGrid.AllowUserToDeleteRows = false;
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
            this.MetaGrid.RowTemplate.Height = 26;
            this.MetaGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.MetaGrid.Size = new System.Drawing.Size(492, 319);
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
            this.BackAddMedia.Click += new System.EventHandler(this.BackAddMedia_Click);
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
            // panelShowMedia
            // 
            this.panelShowMedia.Controls.Add(this.BackMediaButton);
            this.panelShowMedia.Controls.Add(this.MediaGrid);
            this.panelShowMedia.Location = new System.Drawing.Point(863, 115);
            this.panelShowMedia.Name = "panelShowMedia";
            this.panelShowMedia.Size = new System.Drawing.Size(506, 654);
            this.panelShowMedia.TabIndex = 14;
            this.panelShowMedia.Visible = false;
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
            // MediaGrid
            // 
            this.MediaGrid.AllowUserToAddRows = false;
            this.MediaGrid.AllowUserToDeleteRows = false;
            this.MediaGrid.AllowUserToOrderColumns = true;
            this.MediaGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.MediaGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MediaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MediaGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameCol,
            this.ArtistCol});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MediaGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.MediaGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MediaGrid.Location = new System.Drawing.Point(0, 0);
            this.MediaGrid.MultiSelect = false;
            this.MediaGrid.Name = "MediaGrid";
            this.MediaGrid.ReadOnly = true;
            this.MediaGrid.RowHeadersVisible = false;
            this.MediaGrid.RowHeadersWidth = 62;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.MediaGrid.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.MediaGrid.RowTemplate.Height = 24;
            this.MediaGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MediaGrid.Size = new System.Drawing.Size(506, 654);
            this.MediaGrid.TabIndex = 0;
            this.MediaGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MediaGrid_MouseDoubleClick);
            // 
            // spotflixBindingSource
            // 
            this.spotflixBindingSource.DataSource = typeof(Proyecto.Spotflix);
            // 
            // NameCol
            // 
            this.NameCol.HeaderText = "Name";
            this.NameCol.MinimumWidth = 8;
            this.NameCol.Name = "NameCol";
            this.NameCol.ReadOnly = true;
            this.NameCol.Width = 81;
            // 
            // ArtistCol
            // 
            this.ArtistCol.HeaderText = "Artist";
            this.ArtistCol.MinimumWidth = 8;
            this.ArtistCol.Name = "ArtistCol";
            this.ArtistCol.ReadOnly = true;
            this.ArtistCol.Width = 73;
            // 
            // ShowMediaButton
            // 
            this.ShowMediaButton.AutoSize = true;
            this.ShowMediaButton.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowMediaButton.Location = new System.Drawing.Point(86, 240);
            this.ShowMediaButton.Name = "ShowMediaButton";
            this.ShowMediaButton.Size = new System.Drawing.Size(188, 49);
            this.ShowMediaButton.TabIndex = 2;
            this.ShowMediaButton.Text = "Show Media";
            this.ShowMediaButton.UseVisualStyleBackColor = true;
            this.ShowMediaButton.Click += new System.EventHandler(this.ShowMediaButton_Click);
            // 
            // BackMediaButton
            // 
            this.BackMediaButton.AutoSize = true;
            this.BackMediaButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BackMediaButton.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackMediaButton.Location = new System.Drawing.Point(0, 605);
            this.BackMediaButton.Name = "BackMediaButton";
            this.BackMediaButton.Size = new System.Drawing.Size(506, 49);
            this.BackMediaButton.TabIndex = 2;
            this.BackMediaButton.Text = "Back";
            this.BackMediaButton.UseVisualStyleBackColor = true;
            this.BackMediaButton.Click += new System.EventHandler(this.BackMediaButton_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1922, 1034);
            this.Controls.Add(this.panelShowMedia);
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
            this.panelShowMedia.ResumeLayout(false);
            this.panelShowMedia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MediaGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spotflixBindingSource)).EndInit();
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
        private System.Windows.Forms.Panel panelShowMedia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button ShowMediaButton;
        private System.Windows.Forms.DataGridView MediaGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtistCol;
        private System.Windows.Forms.BindingSource spotflixBindingSource;
        private System.Windows.Forms.Button BackMediaButton;
    }
}