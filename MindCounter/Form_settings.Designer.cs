namespace MindCounter
{
    partial class Form_settings
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
            this.radio_easy = new System.Windows.Forms.RadioButton();
            this.radio_medium = new System.Windows.Forms.RadioButton();
            this.radio_hard = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radio_easy
            // 
            this.radio_easy.AutoSize = true;
            this.radio_easy.Location = new System.Drawing.Point(6, 19);
            this.radio_easy.Name = "radio_easy";
            this.radio_easy.Size = new System.Drawing.Size(74, 20);
            this.radio_easy.TabIndex = 0;
            this.radio_easy.Text = "Легкая";
            this.radio_easy.UseVisualStyleBackColor = true;
            // 
            // radio_medium
            // 
            this.radio_medium.AutoSize = true;
            this.radio_medium.Checked = true;
            this.radio_medium.Location = new System.Drawing.Point(6, 42);
            this.radio_medium.Name = "radio_medium";
            this.radio_medium.Size = new System.Drawing.Size(83, 20);
            this.radio_medium.TabIndex = 0;
            this.radio_medium.TabStop = true;
            this.radio_medium.Text = "Средняя";
            this.radio_medium.UseVisualStyleBackColor = true;
            // 
            // radio_hard
            // 
            this.radio_hard.AutoSize = true;
            this.radio_hard.Location = new System.Drawing.Point(6, 65);
            this.radio_hard.Name = "radio_hard";
            this.radio_hard.Size = new System.Drawing.Size(86, 20);
            this.radio_hard.TabIndex = 0;
            this.radio_hard.Text = "Тяжёлая";
            this.radio_hard.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio_easy);
            this.groupBox1.Controls.Add(this.radio_hard);
            this.groupBox1.Controls.Add(this.radio_medium);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 90);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сложность";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(29, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(157, 157);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radio_easy;
        private System.Windows.Forms.RadioButton radio_medium;
        private System.Windows.Forms.RadioButton radio_hard;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}