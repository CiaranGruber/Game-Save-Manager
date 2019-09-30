namespace GameSaveManager
{
    partial class GameSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameSettings));
            this.pnl_header = new System.Windows.Forms.Panel();
            this.lbl_musicChoice = new System.Windows.Forms.Label();
            this.img_musicControl = new System.Windows.Forms.PictureBox();
            this.btn_addSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_changeName = new System.Windows.Forms.Button();
            this.pnl_gamesPanel = new System.Windows.Forms.Panel();
            this.lbl_saves = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pnl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_musicControl)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.pnl_header.TabIndex = 2;
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
            // btn_addSave
            // 
            this.btn_addSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_addSave.Location = new System.Drawing.Point(0, 453);
            this.btn_addSave.Name = "btn_addSave";
            this.btn_addSave.Size = new System.Drawing.Size(532, 50);
            this.btn_addSave.TabIndex = 18;
            this.btn_addSave.Text = "Add Save";
            this.btn_addSave.UseVisualStyleBackColor = true;
            this.btn_addSave.Click += new System.EventHandler(this.btn_addSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_changeName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 50);
            this.panel1.TabIndex = 19;
            // 
            // btn_changeName
            // 
            this.btn_changeName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_changeName.Location = new System.Drawing.Point(200, 25);
            this.btn_changeName.MaximumSize = new System.Drawing.Size(125, 25);
            this.btn_changeName.Name = "btn_changeName";
            this.btn_changeName.Size = new System.Drawing.Size(125, 25);
            this.btn_changeName.TabIndex = 0;
            this.btn_changeName.Text = "Change name";
            this.btn_changeName.UseVisualStyleBackColor = true;
            this.btn_changeName.Click += new System.EventHandler(this.btn_changeName_Click);
            // 
            // pnl_gamesPanel
            // 
            this.pnl_gamesPanel.AutoScroll = true;
            this.pnl_gamesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_gamesPanel.Location = new System.Drawing.Point(0, 200);
            this.pnl_gamesPanel.Name = "pnl_gamesPanel";
            this.pnl_gamesPanel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 5);
            this.pnl_gamesPanel.Size = new System.Drawing.Size(532, 253);
            this.pnl_gamesPanel.TabIndex = 26;
            // 
            // lbl_saves
            // 
            this.lbl_saves.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_saves.Font = new System.Drawing.Font("OCR A Extended", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saves.Location = new System.Drawing.Point(0, 150);
            this.lbl_saves.Name = "lbl_saves";
            this.lbl_saves.Size = new System.Drawing.Size(532, 50);
            this.lbl_saves.TabIndex = 25;
            this.lbl_saves.Text = "Saves";
            this.lbl_saves.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_title
            // 
            this.lbl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_title.Font = new System.Drawing.Font("OCR A Extended", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(0, 100);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(532, 50);
            this.lbl_title.TabIndex = 24;
            this.lbl_title.Text = "Game Settings";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // GameSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 503);
            this.Controls.Add(this.pnl_gamesPanel);
            this.Controls.Add(this.lbl_saves);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_addSave);
            this.Controls.Add(this.pnl_header);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameSettings";
            this.Text = "Game Save Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameSettings_FormClosing);
            this.Load += new System.EventHandler(this.GameSettings_Load);
            this.pnl_header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_musicControl)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.PictureBox img_musicControl;
        private System.Windows.Forms.Label lbl_musicChoice;
        private System.Windows.Forms.Button btn_addSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_changeName;
        private System.Windows.Forms.Panel pnl_gamesPanel;
        private System.Windows.Forms.Label lbl_saves;
        private System.Windows.Forms.Label lbl_title;
    }
}