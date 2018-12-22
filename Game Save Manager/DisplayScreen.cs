using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgramCodes;
using System.Threading;

namespace GameSaveManager
{
    public partial class DisplayScreen : Form
    {
        Thread CheckMusicThread;

        public DisplayScreen()
        {
            // Start up the form
            NavigationClass.SaveNextForm(new string[] { "null" });
            InitializeComponent();
            CenterToScreen();
            splitContainer1.SplitterDistance = splitContainer1.Width / 2;
        }

        private void DisplayScreen_Load(object sender, EventArgs e)
        {
            RefreshAll();

            // Resets the music settings
            ResetMusicImage();
            CheckMusicThread = new Thread(() => CheckMusic());
            CheckMusicThread.Start();
        }

        private void CheckMusic()
        {
            string outdatedSong = FormNav.CurrentSong;

            // Sets the label for displaying the current music
            lbl_musicChoice.SetPropertyThreadSafe(() => lbl_musicChoice.Text, "Music: " + FormNav.CurrentSong);
            while (true)
            {
                // If the music has changed (checked every 500ms), change the label as well
                if (outdatedSong != FormNav.CurrentSong)
                {
                    lbl_musicChoice.SetPropertyThreadSafe(() => lbl_musicChoice.Text, "Music: " + FormNav.CurrentSong);
                    outdatedSong = FormNav.CurrentSong;
                }
                Thread.Sleep(500);
            }
        }

        private void ResetMusicImage()
        {
            // Sets the music image to muted/unmuted depending on if a song is being played
            if (FormNav.CurrentSong != "None")
            {
                img_musicControl.Image = Properties.Resources.Music_Unmuted;
            }
            else
            {
                img_musicControl.Image = Properties.Resources.Music_Muted;
            }
            img_musicControl.Update();
        }

        private void img_musicControl_Click(object sender, EventArgs e)
        {
            FormNav.ChangeMusicState();
            ResetMusicImage();
        }

        private void RefreshAll()
        {
            // Enable/disable functions
            btn_removeGame.Enabled = FormNav.ScreenCode.Games.Count > 0;
            cBo_removeGame.Enabled = FormNav.ScreenCode.Games.Count > 0;
            cBo_gameSelector.Enabled = FormNav.ScreenCode.Games.Count > 0;
            btn_gameSettings.Enabled = FormNav.ScreenCode.Games.Count > 0;

            // Change Combo box values
            cBo_gameSelector.Items.Clear();
            cBo_removeGame.Items.Clear();
            if (FormNav.ScreenCode.Games.Count > 0)
            {
                cBo_gameSelector.Items.AddRange(FormNav.ScreenCode.Games.Select(x => x.Name).ToArray());
                cBo_removeGame.Items.AddRange(FormNav.ScreenCode.Games.Select(x => x.Name).ToArray());
            }
        }

        private void btn_addGame_Click(object sender, EventArgs e)
        {
            FormNav.ScreenCode.AddGame(txt_gameName.Text, txt_gameLink.Text);
            RefreshAll();
        }

        private void btn_removeGame_Click(object sender, EventArgs e)
        {
            if (cBo_removeGame.SelectedItem != null && MessageBox.Show("Are you absolutely certain that you wish to wipe this game and all its saves?", "Just checking...", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Deletes the game and refreshes the screen
                FormNav.ScreenCode.RemoveGame(cBo_removeGame.SelectedItem.ToString());
                cBo_removeGame.SelectedItem = null;

                // Resets the combo boxes
                if (cBo_gameSelector.SelectedItem == cBo_removeGame.SelectedItem)
                {
                    cBo_gameSelector.SelectedItem = null;
                    RefreshAll();
                }
            }
        }

        private void btn_gameSettings_Click(object sender, EventArgs e)
        {
            // Only closes if something is selected
            if (cBo_gameSelector.SelectedItem != null)
            {
                NavigationClass.SaveNextForm(new string[] { "Game Settings", cBo_gameSelector.SelectedItem.ToString() });
                Close();
            }
        }

        private void DisplayScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            CheckMusicThread.Abort();
        }
    }
}
