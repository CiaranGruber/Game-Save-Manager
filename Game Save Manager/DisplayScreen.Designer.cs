namespace GameSaveManager
{
    partial class DisplayScreen
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
            this.pnl_header = new System.Windows.Forms.Panel();
            this.lbl_musicChoice = new System.Windows.Forms.Label();
            this.img_musicControl = new System.Windows.Forms.PictureBox();
            this.pnl_title = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_addGame = new System.Windows.Forms.Button();
            this.txt_gameLink = new System.Windows.Forms.TextBox();
            this.lbl_gameLink = new System.Windows.Forms.Label();
            this.txt_gameName = new System.Windows.Forms.TextBox();
            this.lbl_gameName = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_removeGame = new System.Windows.Forms.Button();
            this.cBo_removeGame = new System.Windows.Forms.ComboBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lbl_settingsAndSaves = new System.Windows.Forms.Label();
            this.cBo_gameSelector = new System.Windows.Forms.ComboBox();
            this.btn_gameSettings = new System.Windows.Forms.Button();
            this.pnl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_musicControl)).BeginInit();
            this.pnl_title.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.Controls.Add(this.lbl_musicChoice);
            this.pnl_header.Controls.Add(this.img_musicControl);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(532, 50);
            this.pnl_header.TabIndex = 1;
            // 
            // lbl_musicChoice
            // 
            this.lbl_musicChoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_musicChoice.Font = new System.Drawing.Font("OCR A Extended", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_musicChoice.Location = new System.Drawing.Point(0, 0);
            this.lbl_musicChoice.Name = "lbl_musicChoice";
            this.lbl_musicChoice.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lbl_musicChoice.Size = new System.Drawing.Size(482, 50);
            this.lbl_musicChoice.TabIndex = 3;
            this.lbl_musicChoice.Text = "Music:";
            this.lbl_musicChoice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // img_musicControl
            // 
            this.img_musicControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.img_musicControl.Image = global::GameSaveManager.Properties.Resources.Music_Unmuted;
            this.img_musicControl.Location = new System.Drawing.Point(482, 0);
            this.img_musicControl.Name = "img_musicControl";
            this.img_musicControl.Size = new System.Drawing.Size(50, 50);
            this.img_musicControl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_musicControl.TabIndex = 2;
            this.img_musicControl.TabStop = false;
            this.img_musicControl.Click += new System.EventHandler(this.img_musicControl_Click);
            // 
            // pnl_title
            // 
            this.pnl_title.Controls.Add(this.lbl_title);
            this.pnl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_title.Location = new System.Drawing.Point(0, 50);
            this.pnl_title.Name = "pnl_title";
            this.pnl_title.Size = new System.Drawing.Size(532, 75);
            this.pnl_title.TabIndex = 2;
            // 
            // lbl_title
            // 
            this.lbl_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_title.Font = new System.Drawing.Font("OCR A Extended", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(0, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(532, 75);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Game Save Manager";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 125);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(100, 50, 100, 0);
            this.panel1.Size = new System.Drawing.Size(532, 250);
            this.panel1.TabIndex = 6;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btn_addGame);
            this.panel8.Controls.Add(this.txt_gameLink);
            this.panel8.Controls.Add(this.lbl_gameLink);
            this.panel8.Controls.Add(this.txt_gameName);
            this.panel8.Controls.Add(this.lbl_gameName);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(100, 50);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(332, 150);
            this.panel8.TabIndex = 9;
            // 
            // btn_addGame
            // 
            this.btn_addGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_addGame.Location = new System.Drawing.Point(0, 104);
            this.btn_addGame.Name = "btn_addGame";
            this.btn_addGame.Size = new System.Drawing.Size(332, 46);
            this.btn_addGame.TabIndex = 4;
            this.btn_addGame.Text = "Add Game";
            this.btn_addGame.UseVisualStyleBackColor = true;
            this.btn_addGame.Click += new System.EventHandler(this.btn_addGame_Click);
            // 
            // txt_gameLink
            // 
            this.txt_gameLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_gameLink.Location = new System.Drawing.Point(0, 82);
            this.txt_gameLink.Name = "txt_gameLink";
            this.txt_gameLink.Size = new System.Drawing.Size(332, 22);
            this.txt_gameLink.TabIndex = 3;
            // 
            // lbl_gameLink
            // 
            this.lbl_gameLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_gameLink.Location = new System.Drawing.Point(0, 52);
            this.lbl_gameLink.Name = "lbl_gameLink";
            this.lbl_gameLink.Size = new System.Drawing.Size(332, 30);
            this.lbl_gameLink.TabIndex = 2;
            this.lbl_gameLink.Text = "Link to game";
            this.lbl_gameLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_gameName
            // 
            this.txt_gameName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_gameName.Location = new System.Drawing.Point(0, 30);
            this.txt_gameName.Name = "txt_gameName";
            this.txt_gameName.Size = new System.Drawing.Size(332, 22);
            this.txt_gameName.TabIndex = 1;
            // 
            // lbl_gameName
            // 
            this.lbl_gameName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_gameName.Location = new System.Drawing.Point(0, 0);
            this.lbl_gameName.Name = "lbl_gameName";
            this.lbl_gameName.Size = new System.Drawing.Size(332, 30);
            this.lbl_gameName.TabIndex = 0;
            this.lbl_gameName.Text = "Game Name";
            this.lbl_gameName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.splitContainer1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(100, 200);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(332, 50);
            this.panel4.TabIndex = 8;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_removeGame);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.cBo_removeGame);
            this.splitContainer1.Panel2.Controls.Add(this.panel7);
            this.splitContainer1.Size = new System.Drawing.Size(332, 50);
            this.splitContainer1.SplitterDistance = 163;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_removeGame
            // 
            this.btn_removeGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_removeGame.Location = new System.Drawing.Point(0, 0);
            this.btn_removeGame.Name = "btn_removeGame";
            this.btn_removeGame.Size = new System.Drawing.Size(163, 50);
            this.btn_removeGame.TabIndex = 2;
            this.btn_removeGame.Text = "Remove Game";
            this.btn_removeGame.UseVisualStyleBackColor = true;
            this.btn_removeGame.Click += new System.EventHandler(this.btn_removeGame_Click);
            // 
            // cBo_removeGame
            // 
            this.cBo_removeGame.Dock = System.Windows.Forms.DockStyle.Top;
            this.cBo_removeGame.FormattingEnabled = true;
            this.cBo_removeGame.Location = new System.Drawing.Point(0, 12);
            this.cBo_removeGame.Name = "cBo_removeGame";
            this.cBo_removeGame.Size = new System.Drawing.Size(165, 24);
            this.cBo_removeGame.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(165, 12);
            this.panel7.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.AutoSize = true;
            this.panel9.Controls.Add(this.btn_gameSettings);
            this.panel9.Controls.Add(this.cBo_gameSelector);
            this.panel9.Controls.Add(this.lbl_settingsAndSaves);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 375);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(100, 25, 100, 0);
            this.panel9.Size = new System.Drawing.Size(532, 134);
            this.panel9.TabIndex = 7;
            // 
            // lbl_settingsAndSaves
            // 
            this.lbl_settingsAndSaves.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_settingsAndSaves.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_settingsAndSaves.Location = new System.Drawing.Point(100, 25);
            this.lbl_settingsAndSaves.Name = "lbl_settingsAndSaves";
            this.lbl_settingsAndSaves.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.lbl_settingsAndSaves.Size = new System.Drawing.Size(332, 35);
            this.lbl_settingsAndSaves.TabIndex = 6;
            this.lbl_settingsAndSaves.Text = "Settings and Saves";
            this.lbl_settingsAndSaves.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cBo_gameSelector
            // 
            this.cBo_gameSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.cBo_gameSelector.FormattingEnabled = true;
            this.cBo_gameSelector.Location = new System.Drawing.Point(100, 60);
            this.cBo_gameSelector.Name = "cBo_gameSelector";
            this.cBo_gameSelector.Size = new System.Drawing.Size(332, 24);
            this.cBo_gameSelector.TabIndex = 8;
            // 
            // btn_gameSettings
            // 
            this.btn_gameSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_gameSettings.Location = new System.Drawing.Point(100, 84);
            this.btn_gameSettings.Name = "btn_gameSettings";
            this.btn_gameSettings.Size = new System.Drawing.Size(332, 50);
            this.btn_gameSettings.TabIndex = 9;
            this.btn_gameSettings.Text = "Game Settings";
            this.btn_gameSettings.UseVisualStyleBackColor = true;
            this.btn_gameSettings.Click += new System.EventHandler(this.btn_gameSettings_Click);
            // 
            // DisplayScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 578);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_title);
            this.Controls.Add(this.pnl_header);
            this.Name = "DisplayScreen";
            this.Text = "Game Save Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DisplayScreen_FormClosing);
            this.Load += new System.EventHandler(this.DisplayScreen_Load);
            this.pnl_header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_musicControl)).EndInit();
            this.pnl_title.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.PictureBox img_musicControl;
        private System.Windows.Forms.Panel pnl_title;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btn_addGame;
        private System.Windows.Forms.TextBox txt_gameLink;
        private System.Windows.Forms.Label lbl_gameLink;
        private System.Windows.Forms.TextBox txt_gameName;
        private System.Windows.Forms.Label lbl_gameName;
        private System.Windows.Forms.Label lbl_musicChoice;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_removeGame;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cBo_removeGame;
        private System.Windows.Forms.Button btn_gameSettings;
        private System.Windows.Forms.ComboBox cBo_gameSelector;
        private System.Windows.Forms.Label lbl_settingsAndSaves;
    }
}

