namespace GameSaveManager
{
    partial class ViewSave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewSave));
            this.pnl_header = new System.Windows.Forms.Panel();
            this.lbl_musicChoice = new System.Windows.Forms.Label();
            this.img_musicControl = new System.Windows.Forms.PictureBox();
            this.pnl_title = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_saveNumber = new System.Windows.Forms.Label();
            this.img_favourited = new System.Windows.Forms.PictureBox();
            this.lbl_dateCreated = new System.Windows.Forms.Label();
            this.pnl_body = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txt_saveData = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_saveDataTitle = new System.Windows.Forms.Label();
            this.txt_notes = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbl_notesTitle = new System.Windows.Forms.Label();
            this.pnl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_musicControl)).BeginInit();
            this.pnl_title.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_favourited)).BeginInit();
            this.pnl_body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.pnl_header.TabIndex = 3;
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
            this.pnl_title.TabIndex = 4;
            // 
            // lbl_title
            // 
            this.lbl_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_title.Font = new System.Drawing.Font("OCR A Extended", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(0, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(532, 75);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Save Title";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_saveNumber);
            this.panel1.Controls.Add(this.img_favourited);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 478);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 75);
            this.panel1.TabIndex = 5;
            // 
            // lbl_saveNumber
            // 
            this.lbl_saveNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_saveNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saveNumber.Location = new System.Drawing.Point(75, 0);
            this.lbl_saveNumber.Name = "lbl_saveNumber";
            this.lbl_saveNumber.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lbl_saveNumber.Size = new System.Drawing.Size(457, 75);
            this.lbl_saveNumber.TabIndex = 1;
            this.lbl_saveNumber.Text = "Save Number:";
            this.lbl_saveNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // img_favourited
            // 
            this.img_favourited.Dock = System.Windows.Forms.DockStyle.Left;
            this.img_favourited.Location = new System.Drawing.Point(0, 0);
            this.img_favourited.Name = "img_favourited";
            this.img_favourited.Size = new System.Drawing.Size(75, 75);
            this.img_favourited.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_favourited.TabIndex = 0;
            this.img_favourited.TabStop = false;
            // 
            // lbl_dateCreated
            // 
            this.lbl_dateCreated.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_dateCreated.Location = new System.Drawing.Point(0, 125);
            this.lbl_dateCreated.Name = "lbl_dateCreated";
            this.lbl_dateCreated.Size = new System.Drawing.Size(532, 17);
            this.lbl_dateCreated.TabIndex = 7;
            this.lbl_dateCreated.Text = "Date Created: ";
            this.lbl_dateCreated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_body
            // 
            this.pnl_body.AutoScroll = true;
            this.pnl_body.Controls.Add(this.splitContainer1);
            this.pnl_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_body.Location = new System.Drawing.Point(0, 142);
            this.pnl_body.Name = "pnl_body";
            this.pnl_body.Padding = new System.Windows.Forms.Padding(50, 50, 50, 5);
            this.pnl_body.Size = new System.Drawing.Size(532, 336);
            this.pnl_body.TabIndex = 8;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(50, 50);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.txt_saveData);
            this.splitContainer1.Panel1.Controls.Add(this.panel6);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_saveDataTitle);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.txt_notes);
            this.splitContainer1.Panel2.Controls.Add(this.panel7);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_notesTitle);
            this.splitContainer1.Size = new System.Drawing.Size(432, 281);
            this.splitContainer1.SplitterDistance = 111;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 4;
            // 
            // txt_saveData
            // 
            this.txt_saveData.BackColor = System.Drawing.SystemColors.Control;
            this.txt_saveData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_saveData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_saveData.Location = new System.Drawing.Point(0, 33);
            this.txt_saveData.Multiline = true;
            this.txt_saveData.Name = "txt_saveData";
            this.txt_saveData.ReadOnly = true;
            this.txt_saveData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_saveData.ShortcutsEnabled = false;
            this.txt_saveData.Size = new System.Drawing.Size(432, 78);
            this.txt_saveData.TabIndex = 5;
            this.txt_saveData.Text = "Save Data Description";
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 23);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(432, 10);
            this.panel6.TabIndex = 1;
            // 
            // lbl_saveDataTitle
            // 
            this.lbl_saveDataTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_saveDataTitle.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saveDataTitle.Location = new System.Drawing.Point(0, 0);
            this.lbl_saveDataTitle.Name = "lbl_saveDataTitle";
            this.lbl_saveDataTitle.Size = new System.Drawing.Size(432, 23);
            this.lbl_saveDataTitle.TabIndex = 0;
            this.lbl_saveDataTitle.Text = "Save Data";
            this.lbl_saveDataTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_notes
            // 
            this.txt_notes.BackColor = System.Drawing.SystemColors.Control;
            this.txt_notes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_notes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_notes.Location = new System.Drawing.Point(0, 33);
            this.txt_notes.Multiline = true;
            this.txt_notes.Name = "txt_notes";
            this.txt_notes.ReadOnly = true;
            this.txt_notes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_notes.ShortcutsEnabled = false;
            this.txt_notes.Size = new System.Drawing.Size(432, 127);
            this.txt_notes.TabIndex = 6;
            this.txt_notes.Text = "Notes";
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 23);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(432, 10);
            this.panel7.TabIndex = 4;
            // 
            // lbl_notesTitle
            // 
            this.lbl_notesTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_notesTitle.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_notesTitle.Location = new System.Drawing.Point(0, 0);
            this.lbl_notesTitle.Name = "lbl_notesTitle";
            this.lbl_notesTitle.Size = new System.Drawing.Size(432, 23);
            this.lbl_notesTitle.TabIndex = 3;
            this.lbl_notesTitle.Text = "Notes on Save";
            this.lbl_notesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 553);
            this.Controls.Add(this.pnl_body);
            this.Controls.Add(this.lbl_dateCreated);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_title);
            this.Controls.Add(this.pnl_header);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewSave";
            this.Text = "Game Save Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewSave_FormClosing);
            this.Load += new System.EventHandler(this.ViewSave_Load);
            this.pnl_header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_musicControl)).EndInit();
            this.pnl_title.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_favourited)).EndInit();
            this.pnl_body.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label lbl_musicChoice;
        private System.Windows.Forms.PictureBox img_musicControl;
        private System.Windows.Forms.Panel pnl_title;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_saveNumber;
        private System.Windows.Forms.PictureBox img_favourited;
        private System.Windows.Forms.Label lbl_dateCreated;
        private System.Windows.Forms.Panel pnl_body;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txt_saveData;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbl_saveDataTitle;
        private System.Windows.Forms.TextBox txt_notes;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lbl_notesTitle;
    }
}