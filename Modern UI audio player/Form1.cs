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
        
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }
        public static String[] paths, files;
        public static System.Windows.Forms.TextBox txtSong = new TextBox();
        bool isStopped = true;
        bool alreadyPlaying = false;
        bool repeat = false;
        bool shuffle = false;
        public int maxsongs;
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
            alreadyPlaying = false;
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
            alreadyPlaying = false;
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
            alreadyPlaying = false;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            openChildForm(new HelpForm());
            hideSubMenu();
            panelNowPlaying.Hide();
            alreadyPlaying = false;
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
            alreadyPlaying = false;

        }
        public static string vis = "Visualisation";
        private void btnPlay_Click(object sender, EventArgs e)
        {
           
            isStopped = false;
            if (alreadyPlaying == false)
            {
                if (vis == "Visualisation")
                    openChildForm(new Visualisation());
                if (vis == "Visualisation2")
                    openChildForm(new Visualisation2());
                if (vis == "Visualisation3")
                    openChildForm(new Visualisation3());
                if (vis == "Visualisation4")
                    openChildForm(new Visualisation4());
                if (vis == "Visualisation5")
                    openChildForm(new Visualisation5());
                if (vis == "Visualisation6")
                    openChildForm(new Visualisation6());
                if (vis == "Visualisation7")
                    openChildForm(new Visualisation7());
                if (vis == "Visualisation8")
                    openChildForm(new Visualisation8());
                if (vis == "Visualisation9")
                    openChildForm(new Visualisation9());
                if (vis == "Visualisation10")
                    openChildForm(new Visualisation10());
                if (vis == "Visualisation11")
                    openChildForm(new Visualisation11());
                if (vis == "Visualisation12")
                    openChildForm(new Visualisation12());
                if (vis == "Visualisation13")
                    openChildForm(new Visualisation13());
                if (vis == "Visualisation14")
                    openChildForm(new Visualisation14());
                if (vis == "Visualisation15")
                    openChildForm(new Visualisation15());
                if (vis == "Visualisation16")
                    openChildForm(new Visualisation16());
            }
            axWindowsMediaPlayer1.Ctlcontrols.play();
            btnPause.Show();
            btnPlay.Hide();
            alreadyPlaying = true;
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
            alreadyPlaying = false;
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

        private void btnNextSong_Click(object sender, EventArgs e)
        {
            if (repeat == true)
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                { BeginInvoke(new Action(() => { axWindowsMediaPlayer1.Ctlcontrols.play(); })); }
            }
            else
            {

                if (btnPlay.Visible == true)
                {
                    btnPause.Show();
                    btnPlay.Hide();

                }
                if ((listBoxSongs.SelectedIndex + 1) == maxsongs)
                {
                    listBoxSongs.SelectedIndex = 0;
                    if (shuffle == true)
                    {
                        Random r = new Random();
                        listBoxSongs.SelectedIndex = r.Next(0, (maxsongs));
                    }
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.URL = paths[listBoxSongs.SelectedIndex];
                    BeginInvoke(new Action(() => { axWindowsMediaPlayer1.Ctlcontrols.play(); }));

                }
                else
                {
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    listBoxSongs.SelectedIndex++;
                    if (shuffle == true)
                    {
                        Random r = new Random();
                        listBoxSongs.SelectedIndex = r.Next(0, (maxsongs));
                    }
                    axWindowsMediaPlayer1.URL = paths[listBoxSongs.SelectedIndex];
                    BeginInvoke(new Action(() => { axWindowsMediaPlayer1.Ctlcontrols.play(); }));

                }
            }
        }

        private void btnPreviousSong_Click(object sender, EventArgs e)
        {
            if (repeat == true)
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                { BeginInvoke(new Action(() => { axWindowsMediaPlayer1.Ctlcontrols.play(); })); }
            }
            else
            {
                if (btnPlay.Visible == true)
                {
                    btnPause.Show();
                    btnPlay.Hide();

                }
                if (listBoxSongs.SelectedIndex == 0)
                {
                    listBoxSongs.SelectedIndex = maxsongs - 1;
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.URL = paths[listBoxSongs.SelectedIndex];
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
                else
                {
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    listBoxSongs.SelectedIndex--;
                    axWindowsMediaPlayer1.URL = paths[listBoxSongs.SelectedIndex];
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
            }
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            shuffle = true;
            btnShuffle.Hide();
            btnCancelShuffle.Show();
        }

        private void btnRepeat_Click(object sender, EventArgs e)
        {
            repeat = true;
            btnRepeat.Hide();
            btnCancelRepeat.Show();
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {
            //if ((e.newState == 1) && (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsMediaEnded))
            //{
            //    if (listBoxSongs.SelectedIndex != listBoxSongs.Items.Count - 1)
            //    {
            //        BeginInvoke(new Action(() => {
            //            listBoxSongs.SelectedIndex = listBoxSongs.SelectedIndex + 1;
            //            axWindowsMediaPlayer1.Ctlcontrols.play();
            //        }));
            //        
            //    }
            // }
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {

                btnNextSong.PerformClick();
            }
            }

        private void btnCancelShuffle_Click(object sender, EventArgs e)
        {
            shuffle = false;
            btnCancelShuffle.Hide();
            btnShuffle.Show();
        }

        private void btnCancelRepeat_Click(object sender, EventArgs e)
        {
            repeat = false;
            btnCancelRepeat.Hide();
            btnRepeat.Show();
        }

        private void btnVolumeZero_Click(object sender, EventArgs e)
        {
            btnVolumeFull.Show();
            btnVolumeZero.Hide();
            panelVolumeFull.Show();
            panelVolumeZero.Hide();
            lblVolume.Text = "100%";
        }

        private void btnVolumeFull_Click(object sender, EventArgs e)
        {
            btnVolumeFull.Hide();
            btnVolumeZero.Show();
            panelVolumeFull.Hide();
            panelVolumeZero.Show();
            lblVolume.Text = "0%";
        }

        private void btnAddToPlaylist_Click(object sender, EventArgs e)
        {
            listBoxSongs.Items.Clear();
            //Code to Select Songs
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
                maxsongs = listBoxSongs.Items.Count;
            }
        }
    }
}
