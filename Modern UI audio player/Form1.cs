using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modern_UI_audio_player
{
    public partial class Form1 : Form
    {
        //private Mp3Player mp3Player = new Mp3Player();
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }
        public static String[] paths, files;
        public static System.Windows.Forms.TextBox txtSong = new TextBox();
        bool isStopped = true;
        private void customizeDesign()
        {
            panelMediaSubMenu.Visible = false;
            panelPlaylistSubMenu.Visible = false;
            panelToolsSubMenu.Visible = false;

        }
        private void hideSubMenu()
        {
            if (panelMediaSubMenu.Visible == true)
                panelMediaSubMenu.Visible = false;
            if (panelPlaylistSubMenu.Visible == true)
                panelPlaylistSubMenu.Visible = false;
            if (panelToolsSubMenu.Visible == true)
                panelToolsSubMenu.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false )
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }

        }



        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubMenu);

        }

        private void btnOpenFiles_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2());
            hideSubMenu();
            panelNowPlaying.Hide();
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnOpenDisk_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnOpenRecentMedia_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnNewPlaylist_Click(object sender, EventArgs e)
        {
            panelNowPlaying.Show();
            panelNowPlaying.BringToFront();
            hideSubMenu();
        }

        private void btnManagePlaylist_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnImportPlaylist_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnExportPlaylist_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnMediaConverter_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnEffectsAndFilters_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnPreferences_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnTheme_Click(object sender, EventArgs e)
        {
            openChildForm(new VisualisationSelector());
            hideSubMenu();
            panelNowPlaying.Hide();
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPlaylistSubMenu);
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            showSubMenu(panelToolsSubMenu);
        }

        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
            hideSubMenu();
            panelNowPlaying.Hide();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            openChildForm(new HelpForm());
            hideSubMenu();
            panelNowPlaying.Hide();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Hide(); // Replaced Close with Hide for testing purposes
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            panelNowPlaying.Show();
            panelNowPlaying.BringToFront();
           
        }
        public static string vis = "Visualisation";
        private void btnPlay_Click(object sender, EventArgs e)
        {
            isStopped = false;
            if (vis == "Visualisation")
            openChildForm(new Visualisation());
            if (vis == "Visualisation2")
                openChildForm(new Visualisation2());
            
            axWindowsMediaPlayer1.Ctlcontrols.play();
            btnPause.Show();
            btnPlay.Hide();
        }

        
        private void btnStop_Click(object sender, EventArgs e)
        {
            if (isStopped == false)
            {
                activeForm.Hide(); //Replaced Close with Hide for testing purposes
                //Application.OpenForms[vis].Close();
                isStopped = true;
            }
            panelNowPlaying.Hide();
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            btnPause.Hide();
            btnPlay.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelNowPlaying.Hide();
        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = paths[listBoxSongs.SelectedIndex];
            Thread.Sleep(10);
            axWindowsMediaPlayer1.Ctlcontrols.stop();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBoxSongs.Items.Clear();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            btnPause.Hide();
            btnPlay.Show();

        }

        private void btnAddToPlaylist_Click(object sender, EventArgs e)
        {
            listBoxSongs.Items.Clear();
            //Code to SElect Songs
            OpenFileDialog ofd = new OpenFileDialog();
            //Code to select multiple files
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames; //Save the names of the track in files array
                paths = ofd.FileNames; //Save the paths of the tracks in path array
                //Display the music titles in listbox
                for (int i = 0; i < files.Length; i++)
                {
                    listBoxSongs.Items.Add(files[i]); //Display Songs in Listbox
                }
            }
        }
    }
}
