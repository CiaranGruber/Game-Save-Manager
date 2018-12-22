using ProgramCodes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameSaveManager
{
    public partial class FormNav : Form
    {
        public static DisplayScreenCode ScreenCode = new DisplayScreenCode("./savefile.txt");

        public FormNav()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void FormNav_Load(object sender, EventArgs e)
        {
            NavigationClass.SaveNextForm(new string[] { "Display Screen" });
            ExtraMusic.Start();

            while (NavigationClass.GetNextForm()[0] != "null")
            {
                // Get the next form
                string[] nextForm = NavigationClass.GetNextForm();
                Form newForm;

                // Choose which form to create a new class of (dictionaries don't work due to not creating a new class when value called)
                if (nextForm[0] == "Display Screen")
                {
                    newForm = new DisplayScreen();
                }
                else if (nextForm[0] == "Game Settings")
                {
                    newForm = new GameSettings(nextForm[1]);
                }
                else if (nextForm[0] == "Edit Save")
                {
                    newForm = new EditSave(nextForm[1], nextForm[2]);
                }
                else if (nextForm[0] == "View Save")
                {
                    newForm = new ViewSave(nextForm[1], nextForm[2]);
                }
                else
                {
                    newForm = new Form();
                    NavigationClass.SaveNextForm(new string[] { "null" });
                }

                Hide();
                newForm.ShowDialog();

                // Show loading form
                CreateControl();
                Show();
                Update();
            }

            ExtraMusic.Abort();
            Close();

            File.Delete(NavigationClass.FormSaveLocation);
            ScreenCode.Save();
        }

        /// <summary>
        /// Plays the background music
        /// </summary>
        private static Thread ExtraMusic = new Thread(() => BackgroundMusic());

        /// <summary>
        /// The current song being played
        /// </summary>
        public static string CurrentSong = "None";

        /// <summary>
        /// A dictionary that has the song name as a string and the actual song itself
        /// </summary>
        public static Dictionary<string, Songs> SongNameToSong = new Dictionary<string, Songs>()
        {
            { "Für Elise", Songs.FurElise },
            { "Mary had a little lamb", Songs.MaryHadALittleLamb }
        };

        public static void ChangeMusicState()
        {
            // Either aborts the music thread or starts it up
            if (ExtraMusic.ThreadState == ThreadState.Aborted)
            {
                Random rand = new Random();
                string[] songs = SongNameToSong.Keys.ToArray();
                CurrentSong = songs[rand.Next(songs.Length)];

                ExtraMusic = new Thread(() => BackgroundMusic());
                ExtraMusic.Start();
            }
            else
            {
                ExtraMusic.Abort();
                CurrentSong = "None";
            }
        }

        private static void BackgroundMusic()
        {
            try
            {
                while (true)
                {
                    Random rand;
                    string[] songs;

                    // Choose song
                    if (CurrentSong == "None")
                    {
                        rand = new Random();
                        songs = SongNameToSong.Keys.ToArray();
                        CurrentSong = songs[rand.Next(songs.Length)];
                    }

                    // Play song
                    Music.PlaySong(SongNameToSong[CurrentSong]);
                    CurrentSong = "None";
                    Thread.Sleep(5000);
                }
            }
            catch (ThreadAbortException)
            {
                CurrentSong = "None";
            }
        }
    }
}
