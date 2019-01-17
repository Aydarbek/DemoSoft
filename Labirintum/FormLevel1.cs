using System;
using System.Drawing;
using System.Windows.Forms;

namespace Labirintum
{
    public partial class FormLevel1 : Form
    {
        int box_left = 8;
        public FormLevel1()
        {
            InitializeComponent();
        }

        private void Start_Game()
        {
            Point point = labelStart.Location;
            point.Offset(labelStart.Width / 2, labelStart.Height / 2);
            Cursor.Position = PointToScreen(point);
            Sound.play_start();
            labelBox1.Visible = true;
            labelBox2.Visible = true;
            labelBox3.Visible = true;
            labelBox4.Visible = true;
            labelBox5.Visible = true;
            labelBox6.Visible = true;
            labelBox7.Visible = true;
            labelBox8.Visible = true;
            box_left = 8;


        }

        private void Finish_Game()
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Restart_Game()
        {
            Sound.play_fail();
            DialogResult dr = MessageBox.Show("Выходить за рамки лабиринта нельзя!\r\nБудем ещё раз играть?", "Вы проиграли",
                MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
                {
                Start_Game();
                }
            else
            {
                this.DialogResult = DialogResult.Abort;
            }
        }

        private void FormLevel1_Shown(object sender, EventArgs e)
        {
            Start_Game();
        }

        private void labelFinish_MouseEnter(object sender, EventArgs e)
        {
            if (box_left==0)
                Finish_Game();
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            Restart_Game();
        }

        private void label9_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).Visible = false;
            Sound.play_key();
            box_left -= 1;
        }
    }
}
