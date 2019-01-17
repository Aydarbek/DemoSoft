namespace KNB
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel_user_stone = new System.Windows.Forms.Panel();
            this.picture_user_stone = new System.Windows.Forms.PictureBox();
            this.panel_user_sciss = new System.Windows.Forms.Panel();
            this.picture_user_sciss = new System.Windows.Forms.PictureBox();
            this.panel_user_paper = new System.Windows.Forms.Panel();
            this.picture_user_paper = new System.Windows.Forms.PictureBox();
            this.panel_comp = new System.Windows.Forms.Panel();
            this.picture_comp_stone = new System.Windows.Forms.PictureBox();
            this.picture_comp_sciss = new System.Windows.Forms.PictureBox();
            this.picture_comp_paper = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label_status = new System.Windows.Forms.Label();
            this.label_result = new System.Windows.Forms.Label();
            this.label_Comp = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel_user_stone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_user_stone)).BeginInit();
            this.panel_user_sciss.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_user_sciss)).BeginInit();
            this.panel_user_paper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_user_paper)).BeginInit();
            this.panel_comp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_comp_stone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_comp_sciss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_comp_paper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_user_stone
            // 
            this.panel_user_stone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_user_stone.Controls.Add(this.picture_user_stone);
            this.panel_user_stone.Location = new System.Drawing.Point(28, 69);
            this.panel_user_stone.Name = "panel_user_stone";
            this.panel_user_stone.Size = new System.Drawing.Size(150, 150);
            this.panel_user_stone.TabIndex = 0;
            this.panel_user_stone.Tag = "stone";
            this.panel_user_stone.MouseEnter += new System.EventHandler(this.panel_user_stone_MouseEnter);
            // 
            // picture_user_stone
            // 
            this.picture_user_stone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture_user_stone.Image = global::KNB.Properties.Resources.User_stone;
            this.picture_user_stone.Location = new System.Drawing.Point(0, 0);
            this.picture_user_stone.Name = "picture_user_stone";
            this.picture_user_stone.Size = new System.Drawing.Size(148, 148);
            this.picture_user_stone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_user_stone.TabIndex = 1;
            this.picture_user_stone.TabStop = false;
            this.picture_user_stone.Visible = false;
            this.picture_user_stone.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picture_user_stone_MouseClick);
            // 
            // panel_user_sciss
            // 
            this.panel_user_sciss.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_user_sciss.Controls.Add(this.picture_user_sciss);
            this.panel_user_sciss.Location = new System.Drawing.Point(223, 69);
            this.panel_user_sciss.Name = "panel_user_sciss";
            this.panel_user_sciss.Size = new System.Drawing.Size(150, 150);
            this.panel_user_sciss.TabIndex = 0;
            this.panel_user_sciss.Tag = "sciss";
            this.panel_user_sciss.MouseEnter += new System.EventHandler(this.panel_user_stone_MouseEnter);
            // 
            // picture_user_sciss
            // 
            this.picture_user_sciss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture_user_sciss.Image = global::KNB.Properties.Resources.User_Sciss;
            this.picture_user_sciss.Location = new System.Drawing.Point(0, 0);
            this.picture_user_sciss.Name = "picture_user_sciss";
            this.picture_user_sciss.Size = new System.Drawing.Size(148, 148);
            this.picture_user_sciss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_user_sciss.TabIndex = 1;
            this.picture_user_sciss.TabStop = false;
            this.picture_user_sciss.Visible = false;
            this.picture_user_sciss.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picture_user_stone_MouseClick);
            // 
            // panel_user_paper
            // 
            this.panel_user_paper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_user_paper.Controls.Add(this.picture_user_paper);
            this.panel_user_paper.Location = new System.Drawing.Point(412, 69);
            this.panel_user_paper.Name = "panel_user_paper";
            this.panel_user_paper.Size = new System.Drawing.Size(150, 150);
            this.panel_user_paper.TabIndex = 0;
            this.panel_user_paper.Tag = "paper";
            this.panel_user_paper.MouseEnter += new System.EventHandler(this.panel_user_stone_MouseEnter);
            // 
            // picture_user_paper
            // 
            this.picture_user_paper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture_user_paper.Image = global::KNB.Properties.Resources.User_paper;
            this.picture_user_paper.Location = new System.Drawing.Point(0, 0);
            this.picture_user_paper.Name = "picture_user_paper";
            this.picture_user_paper.Size = new System.Drawing.Size(148, 148);
            this.picture_user_paper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_user_paper.TabIndex = 1;
            this.picture_user_paper.TabStop = false;
            this.picture_user_paper.Visible = false;
            this.picture_user_paper.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picture_user_stone_MouseClick);
            // 
            // panel_comp
            // 
            this.panel_comp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_comp.Controls.Add(this.picture_comp_stone);
            this.panel_comp.Controls.Add(this.picture_comp_sciss);
            this.panel_comp.Controls.Add(this.picture_comp_paper);
            this.panel_comp.Location = new System.Drawing.Point(637, 69);
            this.panel_comp.Name = "panel_comp";
            this.panel_comp.Size = new System.Drawing.Size(150, 150);
            this.panel_comp.TabIndex = 1;
            // 
            // picture_comp_stone
            // 
            this.picture_comp_stone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture_comp_stone.Image = global::KNB.Properties.Resources.Comp_stone;
            this.picture_comp_stone.Location = new System.Drawing.Point(0, 0);
            this.picture_comp_stone.Name = "picture_comp_stone";
            this.picture_comp_stone.Size = new System.Drawing.Size(148, 148);
            this.picture_comp_stone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_comp_stone.TabIndex = 2;
            this.picture_comp_stone.TabStop = false;
            this.picture_comp_stone.Visible = false;
            // 
            // picture_comp_sciss
            // 
            this.picture_comp_sciss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture_comp_sciss.Image = global::KNB.Properties.Resources.Comp_Sciss;
            this.picture_comp_sciss.Location = new System.Drawing.Point(0, 0);
            this.picture_comp_sciss.Name = "picture_comp_sciss";
            this.picture_comp_sciss.Size = new System.Drawing.Size(148, 148);
            this.picture_comp_sciss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_comp_sciss.TabIndex = 2;
            this.picture_comp_sciss.TabStop = false;
            this.picture_comp_sciss.Visible = false;
            // 
            // picture_comp_paper
            // 
            this.picture_comp_paper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture_comp_paper.Image = global::KNB.Properties.Resources.Comp_paper;
            this.picture_comp_paper.Location = new System.Drawing.Point(0, 0);
            this.picture_comp_paper.Name = "picture_comp_paper";
            this.picture_comp_paper.Size = new System.Drawing.Size(148, 148);
            this.picture_comp_paper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_comp_paper.TabIndex = 2;
            this.picture_comp_paper.TabStop = false;
            this.picture_comp_paper.Visible = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 200;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label_status
            // 
            this.label_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_status.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_status.Location = new System.Drawing.Point(28, 9);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(534, 51);
            this.label_status.TabIndex = 2;
            this.label_status.Text = "Сделайте ваш выбор:";
            this.label_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_result
            // 
            this.label_result.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_result.Location = new System.Drawing.Point(29, 245);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(533, 46);
            this.label_result.TabIndex = 2;
            this.label_result.Text = "Побед: 0  Ничьих: 0  Поражений: 0";
            this.label_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Comp
            // 
            this.label_Comp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Comp.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Comp.Location = new System.Drawing.Point(635, 9);
            this.label_Comp.Name = "label_Comp";
            this.label_Comp.Size = new System.Drawing.Size(152, 51);
            this.label_Comp.TabIndex = 2;
            this.label_Comp.Text = "Выбор компьютера:";
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(792, 70);
            this.trackBar1.Maximum = 5;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar1.Size = new System.Drawing.Size(45, 148);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Value = 3;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 300);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label_Comp);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.panel_comp);
            this.Controls.Add(this.panel_user_paper);
            this.Controls.Add(this.panel_user_sciss);
            this.Controls.Add(this.panel_user_stone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Камень - Ножницы - Бумага";
            this.panel_user_stone.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_user_stone)).EndInit();
            this.panel_user_sciss.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_user_sciss)).EndInit();
            this.panel_user_paper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_user_paper)).EndInit();
            this.panel_comp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_comp_stone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_comp_sciss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_comp_paper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_user_stone;
        private System.Windows.Forms.Panel panel_user_sciss;
        private System.Windows.Forms.Panel panel_user_paper;
        private System.Windows.Forms.PictureBox picture_user_stone;
        private System.Windows.Forms.PictureBox picture_user_paper;
        private System.Windows.Forms.PictureBox picture_user_sciss;
        private System.Windows.Forms.Panel panel_comp;
        private System.Windows.Forms.PictureBox picture_comp_stone;
        private System.Windows.Forms.PictureBox picture_comp_sciss;
        private System.Windows.Forms.PictureBox picture_comp_paper;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Label label_Comp;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

