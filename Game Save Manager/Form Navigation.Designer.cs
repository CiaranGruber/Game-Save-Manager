namespace GameSaveManager
{
    partial class FormNav
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
            this.lbl_loading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_loading
            // 
            this.lbl_loading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_loading.Font = new System.Drawing.Font("Monotxt_IV25", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loading.Location = new System.Drawing.Point(0, 0);
            this.lbl_loading.Name = "lbl_loading";
            this.lbl_loading.Size = new System.Drawing.Size(300, 100);
            this.lbl_loading.TabIndex = 0;
            this.lbl_loading.Text = "Loading...";
            this.lbl_loading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormNav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 100);
            this.Controls.Add(this.lbl_loading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNav";
            this.Text = "FormNav";
            this.Load += new System.EventHandler(this.FormNav_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_loading;
    }
}