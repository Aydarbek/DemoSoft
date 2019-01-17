using System;
using System.Drawing;
using System.Windows.Forms;

namespace Labirintum
{
    public partial class FormLevel3 : Form
    {
        int box_left = 8;
        public FormLevel3()
        {
            InitializeComponent();
        }

        private void Start_Game()
        {
            Point point = labelStart.Location;
            point.Offset(labelStart.Width / 2, labelStart.Height / 2);
            Cursor.Position = PointToScreen(point);
            Sound.play_start();
            labelBox10.Visible = true;
            labelBox11.Visible = true;
            labelBox12.Visible = true;
            labelBox13.Visible = true;
            labelBox14.Visible = true;
            labelBox15.Visible = true;
            labelBox16.Visible = true;
            labelBox17.Visible = true;
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
            labelKey1.Visible = true;
            labelDoor1.Visible = true;
            labelKey2.Visible = true;
            labelDoor2.Visible = true;
        }

        private void FormLevel3_Shown(object sender, EventArgs e)
        {
            Start_Game();
        }

        private void labelFinish_MouseEnter(object sender, EventArgs e)
        {
            if (box_left == 0)
                Finish_Game();
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            Restart_Game();
        }

        private void labelKey1_MouseEnter(object sender, EventArgs e)
        {
            Sound.play_key();
            labelKey1.Visible = false;
            labelDoor1.Visible = false;
        }


        private void labelKey2_MouseEnter_1(object sender, EventArgs e)
        {
            Sound.play_key();
            labelKey2.Visible = false;
            labelDoor2.Visible = false;
        }

        private void labelBox10_MouseEnter(object sender, EventArgs e)
        {
            Sound.play_key();
            ((Label)sender).Visible = false;
            box_left -= 1;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelFlash1.Visible = !labelFlash1.Visible;
            labelFlash2.Visible = !labelFlash2.Visible;
            labelFlash3.Visible = !labelFlash3.Visible;
            labelFlash4.Visible = !labelFlash4.Visible;
            labelFlash5.Visible = !labelFlash5.Visible;
            labelFlash6.Visible = !labelFlash6.Visible;
        }
    }
}
