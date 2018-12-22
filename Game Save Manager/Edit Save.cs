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
    public partial class EditSave : Form
    {
        Thread CheckMusicThread;

        public int GameIndex;

        public int SaveIndex;

        public Save Save;

        public EditSave(string gameName, string saveDate)
        {
            // Start up the form
            NavigationClass.SaveNextForm(new string[] { "Game Settings", gameName });
            InitializeComponent();
            splt_saveAndNotes.SplitterWidth = 16;
            splt_saveAndNotes.SplitterDistance = splt_saveAndNotes.Height / 2;
            CenterToScreen();

            // Get the global variables
            GameIndex = FormNav.ScreenCode.Games.FindIndex(x => x.Name == gameName);
            SaveIndex = FormNav.ScreenCode.Games[GameIndex].Saves.FindIndex(x => x.Date.ToString(Save.Culture) == saveDate);
            if (SaveIndex == -1)
            {
                Save = new Save("Save " + FormNav.ScreenCode.Games[GameIndex].Saves.Count + 1, null, false, "", new string[] { });
            }
            else
            {
                Save = FormNav.ScreenCode.Games[GameIndex].Saves[SaveIndex];
            }

            // Sets the favourited status
            if (Save.Favourited)
            {
                img_favourited.Image = Properties.Resources.Favourited;
            }
            else
            {
                img_favourited.Image = Properties.Resources.Unfavourited;
            }
        }

        private void EditSave_Load(object sender, EventArgs e)
        {
            // Sets the current given values
            lbl_title.Text = Save.Title;
            txt_saveName.Lines = new string[] { Save.Title };
            txt_saveData.Lines = new string[] { Save.SaveData };
            txt_notes.Lines = Save.Notes;
            CheckValidity();
            
            // Resets the music and starts up the music thread
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

        private void CheckValidity()
        {
            btn_saveToCollection.Enabled = Save.Title != "" && Save.SaveData != "";
        }

        private void txt_saveName_TextChanged(object sender, EventArgs e)
        {
            // Sets the title to the saveName and also the Save itself
            if (txt_saveName.Lines.Length > 0)
            {
                lbl_title.Text = txt_saveName.Lines[0];
                Save.Title = txt_saveName.Lines[0];
            }
            else
            {
                lbl_title.Text = "";
                Save.Title = "";
            }

            // Checks the validity and allows the user to save depending on this
            CheckValidity();
        }

        private void img_favourited_Click(object sender, EventArgs e)
        {
            if (Save.Favourited)
            {
                img_favourited.Image = Properties.Resources.Unfavourited;
                Save.Favourited = false;
            }
            else
            {
                img_favourited.Image = Properties.Resources.Favourited;
                Save.Favourited = true;
            }
        }

        private void btn_saveToCollection_Click(object sender, EventArgs e)
        {
            // Saves the current save to the collection by adding or editing it
            if (Save.Date == DateTime.MinValue)
            {
                FormNav.ScreenCode.Games[GameIndex].AddSave(new Save(Save.Title, DateTime.Now.ToString(Save.Culture), Save.Favourited, Save.SaveData, Save.Notes));
            }
            else
            {
                FormNav.ScreenCode.Games[GameIndex].Saves[SaveIndex] = Save;
                FormNav.ScreenCode.Save();
            }
            Close();
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_saveData_TextChanged(object sender, EventArgs e)
        {
            // Restricts textbox to one line and also sets to saveData
            if (txt_saveData.Lines.Length > 1)
            {
                txt_saveData.Lines = new string[] { string.Join("", txt_saveData.Lines) };
                txt_saveData.SelectionStart = txt_saveData.Text.Length;
            }
            else if (txt_saveData.Lines.Length > 0)
            {
                Save.SaveData = txt_saveData.Lines[0];
            }
            else
            {
                Save.SaveData = "";
            }

            // Checks the validity and allows the user to save depending on this
            CheckValidity();
        }

        private void txt_notes_TextChanged(object sender, EventArgs e)
        {
            if (txt_notes.Lines.Length > 0)
            {
                Save.Notes = txt_notes.Lines;
            }
            else
            {
                Save.Notes = new string[] { };
            }
        }

        private void EditSave_FormClosing(object sender, FormClosingEventArgs e)
        {
            CheckMusicThread.Abort();
        }
    }
}
