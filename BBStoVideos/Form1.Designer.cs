namespace BBStoVideos
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            FolderSelector = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            VFolderSelector = new Button();
            TxtDeletor = new Button();
            folderBrowserDialog2 = new FolderBrowserDialog();
            Move = new Button();
            SorterMax = new Button();
            pictureBox1 = new PictureBox();
            Rememberity = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // FolderSelector
            // 
            FolderSelector.BackColor = Color.Azure;
            FolderSelector.ForeColor = SystemColors.ActiveBorder;
            FolderSelector.Location = new Point(3, 1);
            FolderSelector.Name = "FolderSelector";
            FolderSelector.Size = new Size(109, 37);
            FolderSelector.TabIndex = 0;
            FolderSelector.Text = "BBS Folder";
            FolderSelector.UseVisualStyleBackColor = false;
            FolderSelector.Click += button1_Click;
            // 
            // VFolderSelector
            // 
            VFolderSelector.BackColor = Color.Azure;
            VFolderSelector.ForeColor = SystemColors.ActiveBorder;
            VFolderSelector.Location = new Point(118, 1);
            VFolderSelector.Name = "VFolderSelector";
            VFolderSelector.Size = new Size(109, 37);
            VFolderSelector.TabIndex = 1;
            VFolderSelector.Text = "Video Folder";
            VFolderSelector.UseVisualStyleBackColor = false;
            VFolderSelector.Click += VFolderSelector_Click;
            // 
            // TxtDeletor
            // 
            TxtDeletor.Location = new Point(320, 103);
            TxtDeletor.Name = "TxtDeletor";
            TxtDeletor.Size = new Size(140, 61);
            TxtDeletor.TabIndex = 2;
            TxtDeletor.Text = "Delete .txt's";
            TxtDeletor.UseVisualStyleBackColor = true;
            TxtDeletor.Click += TxtDeletor_Click;
            // 
            // Move
            // 
            Move.Location = new Point(293, 208);
            Move.Name = "Move";
            Move.Size = new Size(189, 89);
            Move.TabIndex = 3;
            Move.Text = "Move to videos folder";
            Move.UseVisualStyleBackColor = true;
            Move.Click += Move_Click;
            // 
            // SorterMax
            // 
            SorterMax.Location = new Point(320, 328);
            SorterMax.Name = "SorterMax";
            SorterMax.Size = new Size(140, 52);
            SorterMax.TabIndex = 4;
            SorterMax.Text = "Sort";
            SorterMax.UseVisualStyleBackColor = true;
            SorterMax.Click += SorterMax_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(560, 195);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 243);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // Rememberity
            // 
            Rememberity.AutoSize = true;
            Rememberity.Location = new Point(233, 8);
            Rememberity.Name = "Rememberity";
            Rememberity.Size = new Size(159, 24);
            Rememberity.TabIndex = 6;
            Rememberity.Text = "Remember for next";
            Rememberity.UseVisualStyleBackColor = true;
            Rememberity.CheckedChanged += Rememberity_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(798, 450);
            Controls.Add(Rememberity);
            Controls.Add(pictureBox1);
            Controls.Add(SorterMax);
            Controls.Add(Move);
            Controls.Add(TxtDeletor);
            Controls.Add(VFolderSelector);
            Controls.Add(FolderSelector);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button FolderSelector;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button VFolderSelector;
        private Button TxtDeletor;
        private FolderBrowserDialog folderBrowserDialog2;
        private Button Move;
        private Button SorterMax;
        private PictureBox pictureBox1;
        private CheckBox Rememberity;
    }
}
