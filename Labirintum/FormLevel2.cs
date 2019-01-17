using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirintum
{
    public partial class FormLevel2 : Form
    {
        public FormLevel2()
        {
            InitializeComponent();
        }

        private void Start_Game()
        {
            Point point = labelStart.Location;
            point.Offset(labelStart.Width / 2, labelStart.Height / 2);
            Cursor.Position = PointToScreen(point);
            Sound.play_start();
            labelFlash1.Visible = true;
            labelFlash2.Visible = false;

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
            LabelKey.Visible = true;
            labelDoor.Visible = true;
        }

        private void FormLevel2_Shown(object sender, EventArgs e)
        {
            Start_Game();
        }



        private void LabelKey_MouseEnter(object sender, EventArgs e)
        {
            labelDoor.Visible = false;
            LabelKey.Visible = false;
            Sound.play_key();
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            Restart_Game();
        }

        private void labelFinish_MouseEnter(object sender, EventArgs e)
        {
            Finish_Game();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelFlash1.Visible = !labelFlash1.Visible;
            labelFlash2.Visible = !labelFlash2.Visible;
        }
    }
}
