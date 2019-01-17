namespace MindCounter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label_think = new System.Windows.Forms.Label();
            this.text_answer = new System.Windows.Forms.TextBox();
            this.button_plus = new System.Windows.Forms.Button();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_mult = new System.Windows.Forms.Button();
            this.button_divs = new System.Windows.Forms.Button();
            this.text_max = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_think
            // 
            this.label_think.BackColor = System.Drawing.SystemColors.Window;
            this.label_think.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_think.Enabled = false;
            this.label_think.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_think.ForeColor = System.Drawing.Color.Black;
            this.label_think.Location = new System.Drawing.Point(12, 24);
            this.label_think.Name = "label_think";
            this.label_think.Size = new System.Drawing.Size(372, 85);
            this.label_think.TabIndex = 0;
            this.label_think.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // text_answer
            // 
            this.text_answer.Enabled = false;
            this.text_answer.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_answer.Location = new System.Drawing.Point(393, 24);
            this.text_answer.Name = "text_answer";
            this.text_answer.Size = new System.Drawing.Size(188, 85);
            this.text_answer.TabIndex = 1;
            this.text_answer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_answer_KeyDown);
            // 
            // button_plus
            // 
            this.button_plus.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_plus.Location = new System.Drawing.Point(15, 121);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(119, 41);
            this.button_plus.TabIndex = 2;
            this.button_plus.Tag = "plus";
            this.button_plus.Text = "Сложение";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_plus_MouseClick);
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(16, 121);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(565, 41);
            this.progress.TabIndex = 3;
            this.progress.Visible = false;
            // 
            // button_minus
            // 
            this.button_minus.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_minus.Location = new System.Drawing.Point(140, 121);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(119, 41);
            this.button_minus.TabIndex = 2;
            this.button_minus.Tag = "minus";
            this.button_minus.Text = "Вычитание";
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_plus_MouseClick);
            // 
            // button_mult
            // 
            this.button_mult.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_mult.Location = new System.Drawing.Point(265, 121);
            this.button_mult.Name = "button_mult";
            this.button_mult.Size = new System.Drawing.Size(119, 41);
            this.button_mult.TabIndex = 2;
            this.button_mult.Tag = "mult";
            this.button_mult.Text = "Умножение";
            this.button_mult.UseVisualStyleBackColor = true;
            this.button_mult.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_plus_MouseClick);
            // 
            // button_divs
            // 
            this.button_divs.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_divs.Location = new System.Drawing.Point(390, 121);
            this.button_divs.Name = "button_divs";
            this.button_divs.Size = new System.Drawing.Size(119, 41);
            this.button_divs.TabIndex = 2;
            this.button_divs.Tag = "divs";
            this.button_divs.Text = "Деление";
            this.button_divs.UseVisualStyleBackColor = true;
            this.button_divs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_plus_MouseClick);
            // 
            // text_max
            // 
            this.text_max.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_max.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_max.ForeColor = System.Drawing.SystemColors.WindowText;
            this.text_max.Location = new System.Drawing.Point(515, 122);
            this.text_max.Name = "text_max";
            this.text_max.Size = new System.Drawing.Size(66, 40);
            this.text_max.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 172);
            this.Controls.Add(this.text_max);
            this.Controls.Add(this.button_divs);
            this.Controls.Add(this.button_mult);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.text_answer);
            this.Controls.Add(this.label_think);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Устный счёт";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_think;
        private System.Windows.Forms.TextBox text_answer;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_mult;
        private System.Windows.Forms.Button button_divs;
        private System.Windows.Forms.TextBox text_max;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
    }
}

