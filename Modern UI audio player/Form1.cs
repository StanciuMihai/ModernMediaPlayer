using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modern_UI_audio_player
{
    public partial class Form1 : Form
    {
        private Mp3Player mp3Player = new Mp3Player();
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }
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
            hideSubMenu();
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
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            openChildForm(new HelpForm());
            hideSubMenu();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
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
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Mp3 Files| *.mp3";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    mp3Player.open(ofd.FileName);
                }
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            openChildForm(new Visualisation());
            mp3Player.play();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Visualisation"].Close();
            mp3Player.stop();
        }
    }
}
