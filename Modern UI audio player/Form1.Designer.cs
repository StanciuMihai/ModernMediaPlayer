
namespace Modern_UI_audio_player
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnMedia = new System.Windows.Forms.Button();
            this.panelMediaSubMenu = new System.Windows.Forms.Panel();
            this.btnOpenFiles = new System.Windows.Forms.Button();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.btnOpenDisk = new System.Windows.Forms.Button();
            this.btnOpenRecentMedia = new System.Windows.Forms.Button();
            this.btnPlaylist = new System.Windows.Forms.Button();
            this.panelPlaylistSubMenu = new System.Windows.Forms.Panel();
            this.btnExportPlaylist = new System.Windows.Forms.Button();
            this.btnImportPlaylist = new System.Windows.Forms.Button();
            this.btnManagePlaylist = new System.Windows.Forms.Button();
            this.btnNewPlaylist = new System.Windows.Forms.Button();
            this.btnEqualizer = new System.Windows.Forms.Button();
            this.btnTools = new System.Windows.Forms.Button();
            this.panelToolsSubMenu = new System.Windows.Forms.Panel();
            this.btnTheme = new System.Windows.Forms.Button();
            this.btnPreferences = new System.Windows.Forms.Button();
            this.btnEffectsAndFilters = new System.Windows.Forms.Button();
            this.btnMediaConverter = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.panelPlayer = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panelMediaSubMenu.SuspendLayout();
            this.panelPlaylistSubMenu.SuspendLayout();
            this.panelToolsSubMenu.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.btnHelp);
            this.panelSideMenu.Controls.Add(this.panelToolsSubMenu);
            this.panelSideMenu.Controls.Add(this.btnTools);
            this.panelSideMenu.Controls.Add(this.btnEqualizer);
            this.panelSideMenu.Controls.Add(this.panelPlaylistSubMenu);
            this.panelSideMenu.Controls.Add(this.btnPlaylist);
            this.panelSideMenu.Controls.Add(this.panelMediaSubMenu);
            this.panelSideMenu.Controls.Add(this.btnMedia);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 561);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(233, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // btnMedia
            // 
            this.btnMedia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMedia.FlatAppearance.BorderSize = 0;
            this.btnMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedia.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMedia.Location = new System.Drawing.Point(0, 100);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMedia.Size = new System.Drawing.Size(233, 45);
            this.btnMedia.TabIndex = 1;
            this.btnMedia.Text = "Media";
            this.btnMedia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // panelMediaSubMenu
            // 
            this.panelMediaSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelMediaSubMenu.Controls.Add(this.btnOpenRecentMedia);
            this.panelMediaSubMenu.Controls.Add(this.btnOpenDisk);
            this.panelMediaSubMenu.Controls.Add(this.btnOpenFolder);
            this.panelMediaSubMenu.Controls.Add(this.btnOpenFiles);
            this.panelMediaSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMediaSubMenu.Location = new System.Drawing.Point(0, 145);
            this.panelMediaSubMenu.Name = "panelMediaSubMenu";
            this.panelMediaSubMenu.Size = new System.Drawing.Size(233, 165);
            this.panelMediaSubMenu.TabIndex = 2;
            // 
            // btnOpenFiles
            // 
            this.btnOpenFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpenFiles.FlatAppearance.BorderSize = 0;
            this.btnOpenFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFiles.ForeColor = System.Drawing.Color.LightGray;
            this.btnOpenFiles.Location = new System.Drawing.Point(0, 0);
            this.btnOpenFiles.Name = "btnOpenFiles";
            this.btnOpenFiles.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnOpenFiles.Size = new System.Drawing.Size(233, 40);
            this.btnOpenFiles.TabIndex = 0;
            this.btnOpenFiles.Text = "Open files";
            this.btnOpenFiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenFiles.UseVisualStyleBackColor = true;
            this.btnOpenFiles.Click += new System.EventHandler(this.btnOpenFiles_Click);
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpenFolder.FlatAppearance.BorderSize = 0;
            this.btnOpenFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFolder.ForeColor = System.Drawing.Color.LightGray;
            this.btnOpenFolder.Location = new System.Drawing.Point(0, 40);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnOpenFolder.Size = new System.Drawing.Size(233, 40);
            this.btnOpenFolder.TabIndex = 1;
            this.btnOpenFolder.Text = "Open folder";
            this.btnOpenFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // btnOpenDisk
            // 
            this.btnOpenDisk.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpenDisk.FlatAppearance.BorderSize = 0;
            this.btnOpenDisk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenDisk.ForeColor = System.Drawing.Color.LightGray;
            this.btnOpenDisk.Location = new System.Drawing.Point(0, 80);
            this.btnOpenDisk.Name = "btnOpenDisk";
            this.btnOpenDisk.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnOpenDisk.Size = new System.Drawing.Size(233, 40);
            this.btnOpenDisk.TabIndex = 2;
            this.btnOpenDisk.Text = "Open disk";
            this.btnOpenDisk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenDisk.UseVisualStyleBackColor = true;
            this.btnOpenDisk.Click += new System.EventHandler(this.btnOpenDisk_Click);
            // 
            // btnOpenRecentMedia
            // 
            this.btnOpenRecentMedia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpenRecentMedia.FlatAppearance.BorderSize = 0;
            this.btnOpenRecentMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenRecentMedia.ForeColor = System.Drawing.Color.LightGray;
            this.btnOpenRecentMedia.Location = new System.Drawing.Point(0, 120);
            this.btnOpenRecentMedia.Name = "btnOpenRecentMedia";
            this.btnOpenRecentMedia.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnOpenRecentMedia.Size = new System.Drawing.Size(233, 40);
            this.btnOpenRecentMedia.TabIndex = 3;
            this.btnOpenRecentMedia.Text = "Open recent media";
            this.btnOpenRecentMedia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenRecentMedia.UseVisualStyleBackColor = true;
            this.btnOpenRecentMedia.Click += new System.EventHandler(this.btnOpenRecentMedia_Click);
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlaylist.FlatAppearance.BorderSize = 0;
            this.btnPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaylist.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPlaylist.Location = new System.Drawing.Point(0, 310);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPlaylist.Size = new System.Drawing.Size(233, 45);
            this.btnPlaylist.TabIndex = 3;
            this.btnPlaylist.Text = "Playlist Management";
            this.btnPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaylist.UseVisualStyleBackColor = true;
            this.btnPlaylist.Click += new System.EventHandler(this.btnPlaylist_Click);
            // 
            // panelPlaylistSubMenu
            // 
            this.panelPlaylistSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelPlaylistSubMenu.Controls.Add(this.btnExportPlaylist);
            this.panelPlaylistSubMenu.Controls.Add(this.btnImportPlaylist);
            this.panelPlaylistSubMenu.Controls.Add(this.btnManagePlaylist);
            this.panelPlaylistSubMenu.Controls.Add(this.btnNewPlaylist);
            this.panelPlaylistSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPlaylistSubMenu.Location = new System.Drawing.Point(0, 355);
            this.panelPlaylistSubMenu.Name = "panelPlaylistSubMenu";
            this.panelPlaylistSubMenu.Size = new System.Drawing.Size(233, 165);
            this.panelPlaylistSubMenu.TabIndex = 4;
            // 
            // btnExportPlaylist
            // 
            this.btnExportPlaylist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExportPlaylist.FlatAppearance.BorderSize = 0;
            this.btnExportPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportPlaylist.ForeColor = System.Drawing.Color.LightGray;
            this.btnExportPlaylist.Location = new System.Drawing.Point(0, 120);
            this.btnExportPlaylist.Name = "btnExportPlaylist";
            this.btnExportPlaylist.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnExportPlaylist.Size = new System.Drawing.Size(233, 40);
            this.btnExportPlaylist.TabIndex = 3;
            this.btnExportPlaylist.Text = "Export playlist";
            this.btnExportPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportPlaylist.UseVisualStyleBackColor = true;
            this.btnExportPlaylist.Click += new System.EventHandler(this.btnExportPlaylist_Click);
            // 
            // btnImportPlaylist
            // 
            this.btnImportPlaylist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImportPlaylist.FlatAppearance.BorderSize = 0;
            this.btnImportPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportPlaylist.ForeColor = System.Drawing.Color.LightGray;
            this.btnImportPlaylist.Location = new System.Drawing.Point(0, 80);
            this.btnImportPlaylist.Name = "btnImportPlaylist";
            this.btnImportPlaylist.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnImportPlaylist.Size = new System.Drawing.Size(233, 40);
            this.btnImportPlaylist.TabIndex = 2;
            this.btnImportPlaylist.Text = "Import playlist";
            this.btnImportPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportPlaylist.UseVisualStyleBackColor = true;
            this.btnImportPlaylist.Click += new System.EventHandler(this.btnImportPlaylist_Click);
            // 
            // btnManagePlaylist
            // 
            this.btnManagePlaylist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManagePlaylist.FlatAppearance.BorderSize = 0;
            this.btnManagePlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagePlaylist.ForeColor = System.Drawing.Color.LightGray;
            this.btnManagePlaylist.Location = new System.Drawing.Point(0, 40);
            this.btnManagePlaylist.Name = "btnManagePlaylist";
            this.btnManagePlaylist.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnManagePlaylist.Size = new System.Drawing.Size(233, 40);
            this.btnManagePlaylist.TabIndex = 1;
            this.btnManagePlaylist.Text = "Manage playlist";
            this.btnManagePlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManagePlaylist.UseVisualStyleBackColor = true;
            this.btnManagePlaylist.Click += new System.EventHandler(this.btnManagePlaylist_Click);
            // 
            // btnNewPlaylist
            // 
            this.btnNewPlaylist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewPlaylist.FlatAppearance.BorderSize = 0;
            this.btnNewPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewPlaylist.ForeColor = System.Drawing.Color.LightGray;
            this.btnNewPlaylist.Location = new System.Drawing.Point(0, 0);
            this.btnNewPlaylist.Name = "btnNewPlaylist";
            this.btnNewPlaylist.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnNewPlaylist.Size = new System.Drawing.Size(233, 40);
            this.btnNewPlaylist.TabIndex = 0;
            this.btnNewPlaylist.Text = "New playlist";
            this.btnNewPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewPlaylist.UseVisualStyleBackColor = true;
            this.btnNewPlaylist.Click += new System.EventHandler(this.btnNewPlaylist_Click);
            // 
            // btnEqualizer
            // 
            this.btnEqualizer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEqualizer.FlatAppearance.BorderSize = 0;
            this.btnEqualizer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEqualizer.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEqualizer.Location = new System.Drawing.Point(0, 520);
            this.btnEqualizer.Name = "btnEqualizer";
            this.btnEqualizer.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEqualizer.Size = new System.Drawing.Size(233, 45);
            this.btnEqualizer.TabIndex = 5;
            this.btnEqualizer.Text = "Equalizer";
            this.btnEqualizer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEqualizer.UseVisualStyleBackColor = true;
            this.btnEqualizer.Click += new System.EventHandler(this.btnEqualizer_Click);
            // 
            // btnTools
            // 
            this.btnTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTools.FlatAppearance.BorderSize = 0;
            this.btnTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTools.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTools.Location = new System.Drawing.Point(0, 565);
            this.btnTools.Name = "btnTools";
            this.btnTools.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTools.Size = new System.Drawing.Size(233, 45);
            this.btnTools.TabIndex = 6;
            this.btnTools.Text = "Tools";
            this.btnTools.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTools.UseVisualStyleBackColor = true;
            this.btnTools.Click += new System.EventHandler(this.btnTools_Click);
            // 
            // panelToolsSubMenu
            // 
            this.panelToolsSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelToolsSubMenu.Controls.Add(this.btnTheme);
            this.panelToolsSubMenu.Controls.Add(this.btnPreferences);
            this.panelToolsSubMenu.Controls.Add(this.btnEffectsAndFilters);
            this.panelToolsSubMenu.Controls.Add(this.btnMediaConverter);
            this.panelToolsSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolsSubMenu.Location = new System.Drawing.Point(0, 610);
            this.panelToolsSubMenu.Name = "panelToolsSubMenu";
            this.panelToolsSubMenu.Size = new System.Drawing.Size(233, 165);
            this.panelToolsSubMenu.TabIndex = 7;
            // 
            // btnTheme
            // 
            this.btnTheme.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTheme.FlatAppearance.BorderSize = 0;
            this.btnTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTheme.ForeColor = System.Drawing.Color.LightGray;
            this.btnTheme.Location = new System.Drawing.Point(0, 120);
            this.btnTheme.Name = "btnTheme";
            this.btnTheme.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnTheme.Size = new System.Drawing.Size(233, 40);
            this.btnTheme.TabIndex = 3;
            this.btnTheme.Text = "Theme";
            this.btnTheme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTheme.UseVisualStyleBackColor = true;
            this.btnTheme.Click += new System.EventHandler(this.btnTheme_Click);
            // 
            // btnPreferences
            // 
            this.btnPreferences.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPreferences.FlatAppearance.BorderSize = 0;
            this.btnPreferences.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreferences.ForeColor = System.Drawing.Color.LightGray;
            this.btnPreferences.Location = new System.Drawing.Point(0, 80);
            this.btnPreferences.Name = "btnPreferences";
            this.btnPreferences.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPreferences.Size = new System.Drawing.Size(233, 40);
            this.btnPreferences.TabIndex = 2;
            this.btnPreferences.Text = "Preferences";
            this.btnPreferences.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreferences.UseVisualStyleBackColor = true;
            this.btnPreferences.Click += new System.EventHandler(this.btnPreferences_Click);
            // 
            // btnEffectsAndFilters
            // 
            this.btnEffectsAndFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEffectsAndFilters.FlatAppearance.BorderSize = 0;
            this.btnEffectsAndFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEffectsAndFilters.ForeColor = System.Drawing.Color.LightGray;
            this.btnEffectsAndFilters.Location = new System.Drawing.Point(0, 40);
            this.btnEffectsAndFilters.Name = "btnEffectsAndFilters";
            this.btnEffectsAndFilters.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEffectsAndFilters.Size = new System.Drawing.Size(233, 40);
            this.btnEffectsAndFilters.TabIndex = 1;
            this.btnEffectsAndFilters.Text = "Effects and filters";
            this.btnEffectsAndFilters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEffectsAndFilters.UseVisualStyleBackColor = true;
            this.btnEffectsAndFilters.Click += new System.EventHandler(this.btnEffectsAndFilters_Click);
            // 
            // btnMediaConverter
            // 
            this.btnMediaConverter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMediaConverter.FlatAppearance.BorderSize = 0;
            this.btnMediaConverter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMediaConverter.ForeColor = System.Drawing.Color.LightGray;
            this.btnMediaConverter.Location = new System.Drawing.Point(0, 0);
            this.btnMediaConverter.Name = "btnMediaConverter";
            this.btnMediaConverter.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnMediaConverter.Size = new System.Drawing.Size(233, 40);
            this.btnMediaConverter.TabIndex = 0;
            this.btnMediaConverter.Text = "Media converter";
            this.btnMediaConverter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMediaConverter.UseVisualStyleBackColor = true;
            this.btnMediaConverter.Click += new System.EventHandler(this.btnMediaConverter_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHelp.Location = new System.Drawing.Point(0, 775);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHelp.Size = new System.Drawing.Size(233, 45);
            this.btnHelp.TabIndex = 8;
            this.btnHelp.Text = "Help";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // panelPlayer
            // 
            this.panelPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelPlayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPlayer.Location = new System.Drawing.Point(250, 431);
            this.panelPlayer.Name = "panelPlayer";
            this.panelPlayer.Size = new System.Drawing.Size(684, 130);
            this.panelPlayer.TabIndex = 1;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(684, 431);
            this.panelChildForm.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(239, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelPlayer);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelSideMenu.ResumeLayout(false);
            this.panelMediaSubMenu.ResumeLayout(false);
            this.panelPlaylistSubMenu.ResumeLayout(false);
            this.panelToolsSubMenu.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelMediaSubMenu;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnOpenRecentMedia;
        private System.Windows.Forms.Button btnOpenDisk;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.Button btnOpenFiles;
        private System.Windows.Forms.Button btnTools;
        private System.Windows.Forms.Button btnEqualizer;
        private System.Windows.Forms.Panel panelPlaylistSubMenu;
        private System.Windows.Forms.Button btnExportPlaylist;
        private System.Windows.Forms.Button btnImportPlaylist;
        private System.Windows.Forms.Button btnManagePlaylist;
        private System.Windows.Forms.Button btnNewPlaylist;
        private System.Windows.Forms.Button btnPlaylist;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Panel panelToolsSubMenu;
        private System.Windows.Forms.Button btnTheme;
        private System.Windows.Forms.Button btnPreferences;
        private System.Windows.Forms.Button btnEffectsAndFilters;
        private System.Windows.Forms.Button btnMediaConverter;
        private System.Windows.Forms.Panel panelPlayer;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

