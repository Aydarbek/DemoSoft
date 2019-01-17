using System;
using System.Windows.Forms;
using System.Drawing;

namespace Kaleidoscope
{
    class Box
    {
        int sx = 1;
        int sy = 1;
        static int width, height;
        Graphics graph;
        

        public enum figures { line, circle};

        static figures figure;
        static int line_x1;
        static int line_y1;
        static int line_x2;
        static int line_y2;
        static Color color;

        static int circle_x;
        static int circle_y;
        static int circle_r;

        static Random rand = new Random();

        public Box (Panel panel, int sx, int sy)
        {
            this.sx = sx;
            this.sy = sy;
            graph = panel.CreateGraphics();

        }

        public static void SetSize(int w, int h)

        {
            width = w;
            height = h;
        }

        static public void Choose_Figure()
        {
            int f = rand.Next(0, Enum.GetNames(typeof(figures)).Length);
            figure = (figures)f;
            color = Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256));
            switch (figure)
            {
                case (figures.line):
                    {
                        line_x1 = rand.Next(0, width);
                        line_y1 = rand.Next(0, height);
                        line_x2 = rand.Next(0, width);
                        line_y2 = rand.Next(0, height);
                        break;
                    }

                case (figures.circle):
                    {
                        circle_x = rand.Next(0, width);
                        circle_y = rand.Next(0, height);
                        circle_r = rand.Next(0, width / 4);
                        break;
                    }


            }
        }

        private void Draw_line()
        {
            Pen pen = new Pen(color);
            graph.DrawLine(pen, cx(line_x1), cy (line_y1), cx (line_x2), cy (line_y2));
        }


        private void Draw_circle()
        {
            Brush brush = new SolidBrush(color);
            graph.FillEllipse(brush, cx (circle_x) - circle_r, cy (circle_y) - circle_r, circle_r * 2, circle_r * 2);
        }

        public void Draw_figure()
        {
            switch (figure)
            {
                case (figures.line):
                    {
                        Draw_line();
                        break;
                    }
                case (figures.circle):
                    {
                        Draw_circle();
                        break;
                    }
            }
        }

        private int cx (int x)
        {
            return sx == 1 ? x : width - x;
        }

        private int cy(int y)
        {
            return sy == 1 ? y : height - y;
        }
        

    }
}

