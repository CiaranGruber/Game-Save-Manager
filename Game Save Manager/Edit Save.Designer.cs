namespace GameSaveManager
{
    partial class EditSave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditSave));
            this.pnl_header = new System.Windows.Forms.Panel();
            this.lbl_musicChoice = new System.Windows.Forms.Label();
            this.img_musicControl = new System.Windows.Forms.PictureBox();
            this.pnl_title = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.splt_saveAndNotes = new System.Windows.Forms.SplitContainer();
            this.txt_saveData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_notes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_saveToCollection = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btn_quit = new System.Windows.Forms.Button();
            this.img_favourited = new System.Windows.Forms.PictureBox();
            this.txt_saveName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_musicControl)).BeginInit();
            this.pnl_title.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splt_saveAndNotes)).BeginInit();
            this.splt_saveAndNotes.Panel1.SuspendLayout();
            this.splt_saveAndNotes.Panel2.SuspendLayout();
            this.splt_saveAndNotes.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_favourited)).BeginInit();
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
            this.pnl_title.TabIndex = 6;
            // 
            // lbl_title
            // 
            this.lbl_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_title.Font = new System.Drawing.Font("OCR A Extended", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(0, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(532, 75);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Save Name";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.txt_saveName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 125);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(50, 50, 50, 0);
            this.panel1.Size = new System.Drawing.Size(532, 400);
            this.panel1.TabIndex = 8;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.splt_saveAndNotes);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(50, 102);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(432, 238);
            this.panel9.TabIndex = 8;
            // 
            // splt_saveAndNotes
            // 
            this.splt_saveAndNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splt_saveAndNotes.Location = new System.Drawing.Point(0, 0);
            this.splt_saveAndNotes.Name = "splt_saveAndNotes";
            this.splt_saveAndNotes.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splt_saveAndNotes.Panel1
            // 
            this.splt_saveAndNotes.Panel1.Controls.Add(this.txt_saveData);
            this.splt_saveAndNotes.Panel1.Controls.Add(this.label1);
            // 
            // splt_saveAndNotes.Panel2
            // 
            this.splt_saveAndNotes.Panel2.Controls.Add(this.txt_notes);
            this.splt_saveAndNotes.Panel2.Controls.Add(this.label3);
            this.splt_saveAndNotes.Size = new System.Drawing.Size(432, 238);
            this.splt_saveAndNotes.SplitterDistance = 101;
            this.splt_saveAndNotes.SplitterWidth = 16;
            this.splt_saveAndNotes.TabIndex = 0;
            // 
            // txt_saveData
            // 
            this.txt_saveData.AcceptsReturn = true;
            this.txt_saveData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_saveData.Location = new System.Drawing.Point(0, 40);
            this.txt_saveData.Multiline = true;
            this.txt_saveData.Name = "txt_saveData";
            this.txt_saveData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_saveData.Size = new System.Drawing.Size(432, 61);
            this.txt_saveData.TabIndex = 4;
            this.txt_saveData.TextChanged += new System.EventHandler(this.txt_saveData_TextChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label1.Size = new System.Drawing.Size(432, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Save Data";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_notes
            // 
            this.txt_notes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_notes.Location = new System.Drawing.Point(0, 30);
            this.txt_notes.Multiline = true;
            this.txt_notes.Name = "txt_notes";
            this.txt_notes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_notes.Size = new System.Drawing.Size(432, 91);
            this.txt_notes.TabIndex = 3;
            this.txt_notes.TextChanged += new System.EventHandler(this.txt_notes_TextChanged);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(432, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Notes";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_saveToCollection);
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Controls.Add(this.btn_quit);
            this.panel5.Controls.Add(this.img_favourited);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(50, 340);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel5.Size = new System.Drawing.Size(432, 60);
            this.panel5.TabIndex = 6;
            // 
            // btn_saveToCollection
            // 
            this.btn_saveToCollection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_saveToCollection.Location = new System.Drawing.Point(150, 10);
            this.btn_saveToCollection.Name = "btn_saveToCollection";
            this.btn_saveToCollection.Size = new System.Drawing.Size(132, 50);
            this.btn_saveToCollection.TabIndex = 3;
            this.btn_saveToCollection.Text = "Save to collection";
            this.btn_saveToCollection.UseVisualStyleBackColor = true;
            this.btn_saveToCollection.Click += new System.EventHandler(this.btn_saveToCollection_Click);
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(50, 10);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(100, 50);
            this.panel10.TabIndex = 2;
            // 
            // btn_quit
            // 
            this.btn_quit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_quit.Location = new System.Drawing.Point(282, 10);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(150, 50);
            this.btn_quit.TabIndex = 1;
            this.btn_quit.Text = "Quit";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // img_favourited
            // 
            this.img_favourited.Dock = System.Windows.Forms.DockStyle.Left;
            this.img_favourited.Image = global::GameSaveManager.Properties.Resources.Unfavourited;
            this.img_favourited.Location = new System.Drawing.Point(0, 10);
            this.img_favourited.Name = "img_favourited";
            this.img_favourited.Size = new System.Drawing.Size(50, 50);
            this.img_favourited.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_favourited.TabIndex = 0;
            this.img_favourited.TabStop = false;
            this.img_favourited.Click += new System.EventHandler(this.img_favourited_Click);
            // 
            // txt_saveName
            // 
            this.txt_saveName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_saveName.Location = new System.Drawing.Point(50, 80);
            this.txt_saveName.Name = "txt_saveName";
            this.txt_saveName.Size = new System.Drawing.Size(432, 22);
            this.txt_saveName.TabIndex = 5;
            this.txt_saveName.TextChanged += new System.EventHandler(this.txt_saveName_TextChanged);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(432, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Save Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 525);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_title);
            this.Controls.Add(this.pnl_header);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditSave";
            this.Text = "Game Save Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditSave_FormClosing);
            this.Load += new System.EventHandler(this.EditSave_Load);
            this.pnl_header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_musicControl)).EndInit();
            this.pnl_title.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.splt_saveAndNotes.Panel1.ResumeLayout(false);
            this.splt_saveAndNotes.Panel1.PerformLayout();
            this.splt_saveAndNotes.Panel2.ResumeLayout(false);
            this.splt_saveAndNotes.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splt_saveAndNotes)).EndInit();
            this.splt_saveAndNotes.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_favourited)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label lbl_musicChoice;
        private System.Windows.Forms.PictureBox img_musicControl;
        private System.Windows.Forms.Panel pnl_title;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.SplitContainer splt_saveAndNotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_notes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox img_favourited;
        private System.Windows.Forms.TextBox txt_saveName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_saveToCollection;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.TextBox txt_saveData;
        private System.Windows.Forms.Panel panel10;
    }
}