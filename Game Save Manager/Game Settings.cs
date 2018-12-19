﻿using System;
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
    public partial class GameSettings : Form
    {
        Thread CheckMusicThread;

        public int gameIndex;

        public Game game;

        public GameSettings(string gameName)
        {
            NavigationClass.SaveNextForm(new string[] { "Display Screen" });

            gameIndex = FormNav.ScreenCode.Games.FindIndex(x => x.Name == gameName);
            game = FormNav.ScreenCode.Games[gameIndex];
            InitializeComponent();
            CenterToScreen();
        }

        private void GameSettings_Load(object sender, EventArgs e)
        {
            lbl_title.Text = game.Name + " Settings";
            RefreshSaves();

            ResetMusicImage();
            CheckMusicThread = new Thread(() => CheckMusic());
            CheckMusicThread.Start();
        }

        private void CheckMusic()
        {
            string outdatedSong = FormNav.CurrentSong;
            lbl_musicChoice.SetPropertyThreadSafe(() => lbl_musicChoice.Text, "Music: " + FormNav.CurrentSong);
            while (true)
            {
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

        private void RefreshSaves()
        {
            pnl_gamesPanel.Controls.Clear();
            
            foreach (Save save in game.Saves)
            {
                Panel savePanel = new Panel();
                TableLayoutPanel detailsPanel = new TableLayoutPanel();
                PictureBox favouriteBox = new PictureBox();
                Label saveName = new Label();
                Label dateCreated = new Label();
                Button viewSave = new Button();
                Button editSave = new Button();

                savePanel.Dock = DockStyle.Top;
                savePanel.Height = 50;

                if (save.Favourited)
                {
                    favouriteBox.Image = Properties.Resources.Favourited;
                }
                else
                {
                    favouriteBox.Image = Properties.Resources.Unfavourited;
                }
                favouriteBox.Width = 50;
                favouriteBox.SizeMode = PictureBoxSizeMode.Zoom;
                favouriteBox.Name = save.Date.ToString(Save.Culture);
                favouriteBox.Click += favouritedBox_Click;
                favouriteBox.Dock = DockStyle.Left;

                editSave.Text = "Edit Save";
                editSave.Width = 100;
                editSave.Name = save.Date.ToString(Save.Culture);
                editSave.Click += editSave_Click;
                editSave.Dock = DockStyle.Right;

                viewSave.Text = "View Save";
                viewSave.Width = 100;
                viewSave.Name = save.Date.ToString(Save.Culture);
                viewSave.Click += viewSave_Click;
                viewSave.Dock = DockStyle.Right;

                detailsPanel.Dock = DockStyle.Fill;

                detailsPanel.ColumnCount = 1;
                detailsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                detailsPanel.RowCount = 2;
                detailsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

                detailsPanel.Controls.Add(new Label() { Text = save.Title }, 0, 0);
                detailsPanel.Controls.Add(new Label() { Text = save.Date.ToString() }, 0, 1);

                savePanel.Controls.Add(detailsPanel);
                savePanel.Controls.Add(viewSave);
                savePanel.Controls.Add(editSave);
                savePanel.Controls.Add(favouriteBox);

                pnl_gamesPanel.Controls.Add(savePanel);
            }
        }

        private void viewSave_Click(object sender, EventArgs e)
        {
            Control control = sender as Control;
            NavigationClass.SaveNextForm(new string[] { "View Save", game.Name, control.Name });
            Close();
        }

        private void editSave_Click(object sender, EventArgs e)
        {
            Control control = sender as Control;
            NavigationClass.SaveNextForm(new string[] { "Edit Save", game.Name, control.Name });
            Close();
        }

        private void btn_addSave_Click(object sender, EventArgs e)
        {
            NavigationClass.SaveNextForm(new string[] { "Edit Save", game.Name, "" });
            Close();
        }

        private void favouritedBox_Click(object sender, EventArgs e)
        {
            PictureBox control = sender as PictureBox;
            int saveIndex = FormNav.ScreenCode.Games[gameIndex].Saves.FindIndex(x => x.Date.ToString(Save.Culture) == control.Name);

            FormNav.ScreenCode.Games[gameIndex].Saves[saveIndex].Favourited = FormNav.ScreenCode.Games[gameIndex].Saves[saveIndex].Favourited == false;

            if (FormNav.ScreenCode.Games[gameIndex].Saves[saveIndex].Favourited)
            {
                control.Image = Properties.Resources.Favourited;
            }
            else
            {
                control.Image = Properties.Resources.Unfavourited;
            }
        }

        private void GameSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            CheckMusicThread.Abort();
        }
    }
}
