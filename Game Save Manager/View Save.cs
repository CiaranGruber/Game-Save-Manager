using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramCodes;
using System.Windows.Forms;
using System.Threading;

namespace GameSaveManager
{
    public partial class ViewSave : Form
    {
        public Save Save;
        public int SaveIndex;
        Thread CheckMusicThread;

        public ViewSave(string gameName, string saveDate)
        {
            // Start up form
            InitializeComponent();
            CenterToScreen();
            NavigationClass.SaveNextForm(new string[] { "Game Settings", gameName });

            // Set the public variables for the save
            int gameIndex = FormNav.ScreenCode.Games.FindIndex(x => x.Name == gameName);
            SaveIndex = FormNav.ScreenCode.Games[gameIndex].Saves.FindIndex(x => x.Date.ToString(Save.Culture) == saveDate);
            Save = FormNav.ScreenCode.Games[gameIndex].Saves[SaveIndex];

            // Resets the music image and starts a new thread for the music
            ResetMusicImage();
            CheckMusicThread = new Thread(() => CheckMusic());
            CheckMusicThread.Start();
        }

        private void ViewSave_Load(object sender, EventArgs e)
        {
            // Sets all the values for the save
            lbl_title.Text = Save.Title;
            lbl_dateCreated.Text = "Date Created: " + Save.Date.ToString(Save.Culture);
            txt_saveData.Lines = new string[] { Save.SaveData };
            txt_notes.Lines = Save.Notes;
            lbl_saveNumber.Text = "Save Number: " + SaveIndex.ToString().PadLeft(3, '0');
            if (Save.Favourited)
            {
                img_favourited.Image = Properties.Resources.Favourited;
            }
            else
            {
                img_favourited.Image = Properties.Resources.Unfavourited;
            }
        }
        
        private void ViewSave_FormClosing(object sender, FormClosingEventArgs e)
        {
            CheckMusicThread.Abort();
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
    }
}
