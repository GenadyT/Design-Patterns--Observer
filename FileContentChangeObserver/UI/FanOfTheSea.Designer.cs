namespace FileContentChangeObserver.UI
{
    partial class FanOfTheSea
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbxFanTypeImage = new PictureBox();
            lblFanType = new Label();
            pbxFanMoodImage = new PictureBox();
            lblTheFanMoodTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)pbxFanTypeImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxFanMoodImage).BeginInit();
            SuspendLayout();
            // 
            // pbxFanTypeImage
            // 
            pbxFanTypeImage.Location = new Point(19, 36);
            pbxFanTypeImage.Name = "pbxFanTypeImage";
            pbxFanTypeImage.Size = new Size(125, 125);
            pbxFanTypeImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxFanTypeImage.TabIndex = 0;
            pbxFanTypeImage.TabStop = false;
            // 
            // lblFanType
            // 
            lblFanType.AutoSize = true;
            lblFanType.Location = new Point(19, 10);
            lblFanType.Name = "lblFanType";
            lblFanType.Size = new Size(65, 15);
            lblFanType.TabIndex = 1;
            lblFanType.Text = "The Fan is: ";
            // 
            // pbxFanMoodImage
            // 
            pbxFanMoodImage.Location = new Point(181, 41);
            pbxFanMoodImage.Name = "pbxFanMoodImage";
            pbxFanMoodImage.Size = new Size(110, 110);
            pbxFanMoodImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxFanMoodImage.TabIndex = 2;
            pbxFanMoodImage.TabStop = false;
            // 
            // lblTheFanMoodTitle
            // 
            lblTheFanMoodTitle.AutoSize = true;
            lblTheFanMoodTitle.Location = new Point(166, 10);
            lblTheFanMoodTitle.Name = "lblTheFanMoodTitle";
            lblTheFanMoodTitle.Size = new Size(83, 15);
            lblTheFanMoodTitle.TabIndex = 3;
            lblTheFanMoodTitle.Text = "The Fan Mood";
            // 
            // FanOfTheSea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            Controls.Add(lblTheFanMoodTitle);
            Controls.Add(pbxFanMoodImage);
            Controls.Add(lblFanType);
            Controls.Add(pbxFanTypeImage);
            Name = "FanOfTheSea";
            Size = new Size(311, 171);
            ((System.ComponentModel.ISupportInitialize)pbxFanTypeImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxFanMoodImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbxFanTypeImage;
        private Label lblFanType;
        private PictureBox pbxFanMoodImage;
        private Label lblTheFanMoodTitle;
    }
}
