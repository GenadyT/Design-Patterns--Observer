namespace FileContentChangeObserver
{
    partial class frmMiamiCoastsForecast
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            fileSystemWatcher1 = new FileSystemWatcher();
            tbxWwwFlaticonCom = new TextBox();
            gpbxForecast = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            btnUdateTextFile = new Button();
            tbxTextArea = new TextBox();
            gpbxFansOfTheSea = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            gpbxForecast.SuspendLayout();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // tbxWwwFlaticonCom
            // 
            tbxWwwFlaticonCom.Location = new Point(0, 0);
            tbxWwwFlaticonCom.Name = "tbxWwwFlaticonCom";
            tbxWwwFlaticonCom.Size = new Size(100, 23);
            tbxWwwFlaticonCom.TabIndex = 0;
            // 
            // gpbxForecast
            // 
            gpbxForecast.Controls.Add(label2);
            gpbxForecast.Controls.Add(label1);
            gpbxForecast.Controls.Add(btnUdateTextFile);
            gpbxForecast.Controls.Add(tbxTextArea);
            gpbxForecast.Location = new Point(12, 21);
            gpbxForecast.Name = "gpbxForecast";
            gpbxForecast.Size = new Size(345, 196);
            gpbxForecast.TabIndex = 6;
            gpbxForecast.TabStop = false;
            gpbxForecast.Text = "Forecast JSON";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(18, 43);
            label2.Name = "label2";
            label2.Size = new Size(185, 15);
            label2.TabIndex = 4;
            label2.Text = "SkyCondition = \"cloudy\"/\"sunny\"";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(18, 25);
            label1.Name = "label1";
            label1.Size = new Size(181, 15);
            label1.TabIndex = 3;
            label1.Text = "SignificantHeight = \"low\"/\"high\"";
            // 
            // btnUdateTextFile
            // 
            btnUdateTextFile.BackColor = Color.FromArgb(199, 199, 199);
            btnUdateTextFile.Cursor = Cursors.Hand;
            btnUdateTextFile.FlatAppearance.BorderColor = Color.DarkBlue;
            btnUdateTextFile.FlatStyle = FlatStyle.Flat;
            btnUdateTextFile.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUdateTextFile.ForeColor = Color.DarkBlue;
            btnUdateTextFile.Location = new Point(18, 160);
            btnUdateTextFile.Name = "btnUdateTextFile";
            btnUdateTextFile.Size = new Size(311, 23);
            btnUdateTextFile.TabIndex = 1;
            btnUdateTextFile.Text = "Udate Forecast JSON And View Results..";
            btnUdateTextFile.UseVisualStyleBackColor = false;
            btnUdateTextFile.Click += btnUdateTextFile_Click;
            // 
            // tbxTextArea
            // 
            tbxTextArea.Font = new Font("Segoe UI", 10F);
            tbxTextArea.ForeColor = Color.Sienna;
            tbxTextArea.Location = new Point(18, 68);
            tbxTextArea.Multiline = true;
            tbxTextArea.Name = "tbxTextArea";
            tbxTextArea.ScrollBars = ScrollBars.Both;
            tbxTextArea.Size = new Size(311, 82);
            tbxTextArea.TabIndex = 2;
            // 
            // gpbxFansOfTheSea
            // 
            gpbxFansOfTheSea.Location = new Point(12, 244);
            gpbxFansOfTheSea.Name = "gpbxFansOfTheSea";
            gpbxFansOfTheSea.Padding = new Padding(10);
            gpbxFansOfTheSea.Size = new Size(345, 655);
            gpbxFansOfTheSea.TabIndex = 7;
            gpbxFansOfTheSea.TabStop = false;
            gpbxFansOfTheSea.Text = "The Fans Of The Miami Sea";
            // 
            // frmMiamiCoastsForecast
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 861);
            Controls.Add(gpbxFansOfTheSea);
            Controls.Add(gpbxForecast);
            Name = "frmMiamiCoastsForecast";
            Text = "Miami Coasts Forecast";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            gpbxForecast.ResumeLayout(false);
            gpbxForecast.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private TextBox tbxWwwFlaticonCom;
        private GroupBox gpbxForecast;
        private Button btnUdateTextFile;
        private TextBox tbxTextArea;
        private GroupBox gpbxFansOfTheSea;
        private Label label2;
        private Label label1;
    }
}
