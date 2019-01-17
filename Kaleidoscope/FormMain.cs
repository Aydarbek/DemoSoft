using System;
using System.Windows.Forms;

namespace Kaleidoscope
{
    public partial class FormMain : Form
    {

        Box [,] box;
        int w, h;
        public FormMain()
        {
            InitializeComponent();
            Init();
            timer.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Box.Choose_Figure();
            for (int i=0; i<w; i++)
                for (int j=0; j<h; j++)
                {
                    box[i, j].Draw_figure();
                }
        }

        public void Init()
        {
            Box.SetSize(panel1.Width, panel1.Height);
            w = panelMain.Width / panel1.Width;
            h = panelMain.Height / panel1.Height;

            box = new Box[w, h];
            for (int i=0; i<w; i++)
                for (int j=0; j<h; j++)
                {
                    int sx = 1;
                    int sy = 1;
                    Panel cell = new Panel ();
                    cell.Parent = panelMain;
                    cell.BorderStyle = System.Windows.Forms.BorderStyle.None;
                    cell.Location = new System.Drawing.Point(i * panel1.Width, j * panel1.Height);
                    cell.Size = new System.Drawing.Size(panel1.Width, panel1.Height);
                    sx = (i % 2 == 1) ? -1 : 1;
                    sy = (j % 2 == 1) ? -1 : 1;
                    box [i,j] = new Box(cell, sx, sy);
                }

            
        }


    }
}
