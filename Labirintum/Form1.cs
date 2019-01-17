using System;
using System.Drawing;
using System.Windows.Forms;

namespace Labirintum
{
    public partial class Labirintum : Form
    {
        public Labirintum()
        {
            InitializeComponent();
            Point point = buttonStart.Location;
            point.Offset(buttonStart.Width / 2, buttonStart.Height / 2);
            Cursor.Position = PointToScreen(point);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BoxSound_CheckedChanged(object sender, EventArgs e)
        {
            if (BoxSound.Checked)
            {
                BoxSound.Text = "Звук есть";
                Sound.Sound_On();
                Sound.play_key();
            }
            else
            {
                BoxSound.Text = "Звука нет";
                Sound.Sound_Off();
            }


        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Start_Level1();

        }

        private void Start_Level1()
        {
            FormLevel1 level1 = new FormLevel1();
            DialogResult dr = level1.ShowDialog();
            if (dr == DialogResult.OK)
                Start_Level2();
        }

        private void Start_Level2()
        {
            FormLevel2 level2 = new FormLevel2();
            DialogResult dr = level2.ShowDialog();
            if (dr == DialogResult.OK)
                Start_Level3();
        }

        private void Start_Level3()
        {
            FormLevel3 level3 = new FormLevel3();
            DialogResult dr = level3.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Sound.play_you_win();
                MessageBox.Show("Вы прошли все уровни Лабиринта!", "Ура!");
            }
        }
    }
}
