using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MindCounter
{
    public partial class MainForm : Form
    {
        int count; // попытки
        int min = 1;
        int max = 10;
        Random rnd = new Random();
        string answer;
        int count_max = 10;
        string mode = "";
        Stopwatch timer = new Stopwatch();


        public int Count_max
        {
            get { return count_max; }
            set { count_max = value; }
        }

        
        public MainForm()
        {
            InitializeComponent();
            text_max.Text = max.ToString();
        }



        private void Start(string my_mode)
        {
            mode = my_mode;
            button_plus.Visible = false;
            button_minus.Visible = false;
            button_mult.Visible = false;
            button_divs.Visible = false;
            text_max.Visible = false;
            label_think.Enabled = true;
            text_answer.Enabled = true;
            text_answer.Focus();
            text_answer.Text = "";
            progress.Visible = true;
            progress.Minimum = 0;
            progress.Maximum = count_max;
            progress.Value = 0;
            count = 0;
            try
            {
                max = Convert.ToInt16(text_max.Text);
            }
            catch
            {
                max = 10;
                text_max.Text = "10";
            }

            Think(mode);
        }

        private void Think(string arith)
        {
            int a, b;
            a = rnd.Next(min, max +1);
            b = rnd.Next(min, max +1);
            count++;

            if (arith == "plus")
            {
                label_think.Text = a.ToString() + " + " + b.ToString() + " = ";
                answer = (a + b).ToString();
            }
            if (arith == "minus")
            {
                if (a < b)
                {
                    int x = a;
                    a = b;
                    b = x;
                }
                label_think.Text = a.ToString() + " – " + b.ToString() + " = ";
                answer = (a - b).ToString();
            }
            if (arith == "mult")
            {
                label_think.Text = a.ToString() + " × " + b.ToString() + " = ";
                answer = (a * b).ToString();
            }
            if (arith == "divs")
            {
                label_think.Text = (a*b).ToString() + " : " + b.ToString() + " = ";
                answer = (a).ToString();
            }
        }

        private void text_answer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (text_answer.Text == answer)
                {                    
                    progress.Value = count;
                    if (count == count_max)
                    {
                        timer.Stop();
                        Game_win();
                        return;
                    }
                    else
                    {
                        text_answer.Text = "";
                        Think(mode);
                    }
                }
                else
                {
                    Game_over();                     
                }
            }
        }

        private void Game_over()
        {
            text_answer.Text = answer;
            Initiate();

        }

        private void Game_win()
        {
            MessageBox.Show("Вы победили!\r\nВремя: " + timer.Elapsed.ToString("ss") + 'c', "Победа!");
            Initiate();
        }

        private void Initiate ()
        {
            progress.Visible = false;
            button_plus.Visible = true;
            button_minus.Visible = true;
            button_mult.Visible = true;
            button_divs.Visible = true;
            text_max.Visible = true;
            label_think.Enabled = false;
            text_answer.Enabled = false;
            button_plus.Focus();
        }

        private void ShowTime()
        {
            timer.Stop();
        }

        private void button_plus_MouseClick(object sender, MouseEventArgs e)
        {
            Start((((Button)sender).Tag).ToString());
            timer.Start();
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_settings settings = new Form_settings();
            settings.ShowDialog();
            this.Count_max = settings.Count_max;            
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор: Айдар Ахметшин\r\nВерсия:1.0.0 \r\r\r\t 2018г.", "О программе");
        }
    }
}
