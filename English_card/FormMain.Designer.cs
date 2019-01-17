namespace English_card
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.labelEng = new System.Windows.Forms.Label();
            this.labelRus = new System.Windows.Forms.Label();
            this.labelVideo = new System.Windows.Forms.Label();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox.Location = new System.Drawing.Point(82, 68);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(240, 240);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPrev.Location = new System.Drawing.Point(12, 165);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(64, 43);
            this.buttonPrev.TabIndex = 1;
            this.buttonPrev.Text = "<<";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNext.Location = new System.Drawing.Point(328, 165);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(64, 43);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.Text = ">>";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // labelEng
            // 
            this.labelEng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelEng.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelEng.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEng.ForeColor = System.Drawing.Color.Red;
            this.labelEng.Location = new System.Drawing.Point(82, 30);
            this.labelEng.Name = "labelEng";
            this.labelEng.Size = new System.Drawing.Size(240, 45);
            this.labelEng.TabIndex = 3;
            this.labelEng.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelEng.Click += new System.EventHandler(this.labelEng_Click);
            // 
            // labelRus
            // 
            this.labelRus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelRus.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRus.ForeColor = System.Drawing.Color.Blue;
            this.labelRus.Location = new System.Drawing.Point(82, 301);
            this.labelRus.Name = "labelRus";
            this.labelRus.Size = new System.Drawing.Size(240, 45);
            this.labelRus.TabIndex = 4;
            this.labelRus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelRus.Click += new System.EventHandler(this.labelRus_Click);
            // 
            // labelVideo
            // 
            this.labelVideo.AutoSize = true;
            this.labelVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelVideo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVideo.Location = new System.Drawing.Point(328, 43);
            this.labelVideo.Name = "labelVideo";
            this.labelVideo.Size = new System.Drawing.Size(73, 18);
            this.labelVideo.TabIndex = 5;
            this.labelVideo.Text = "+ Video";
            this.labelVideo.Visible = false;
            this.labelVideo.Click += new System.EventHandler(this.labelVideo_Click);
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(82, 70);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(240, 238);
            this.player.TabIndex = 6;
            this.player.Visible = false;
            this.player.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.player_PlayStateChange);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 399);
            this.Controls.Add(this.player);
            this.Controls.Add(this.labelVideo);
            this.Controls.Add(this.labelRus);
            this.Controls.Add(this.labelEng);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "English cards";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label labelEng;
        private System.Windows.Forms.Label labelRus;
        private System.Windows.Forms.Label labelVideo;
        private AxWMPLib.AxWindowsMediaPlayer player;
    }
}

