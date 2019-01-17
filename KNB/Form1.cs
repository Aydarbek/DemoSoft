using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KNB
{
    public partial class MainForm : Form
    {

        Random rnd = new Random();
        string Game_mode = "play"; //play - игра идёт; score - подсчёт очков;
        string user_choice = "";
        string comp_choice = "";
        int win_num = 0;
        int draw_num = 0;
        int loss_num = 0;


        public MainForm()
        {
            InitializeComponent();
            SetFrequency();
        }

        private void Show_user_picture(string pict)
        {
            picture_user_stone.Visible = pict == "stone";
            picture_user_sciss.Visible = pict == "sciss";
            picture_user_paper.Visible = pict == "paper";
            user_choice = pict;
        }

        private void Show_comp_picture(string pict)
        {
            picture_comp_stone.Visible = pict == "stone";
            picture_comp_sciss.Visible = pict == "sciss";
            picture_comp_paper.Visible = pict == "paper";
            comp_choice = pict;

        }

        private void panel_user_stone_MouseEnter(object sender, EventArgs e)
        {
            Game_start();
            Show_user_picture((((Panel)sender).Tag).ToString());
        }

        private void timer_Tick(object sender, EventArgs e)
            
        {
            if (Game_mode == "play")
                Use_comp_random();            
        }

        private void Use_comp_random ()
        {
            int n = rnd.Next(1, 4);

                switch (n)
                {
                    case 1:
                        Show_comp_picture("stone");
                        break;
                    case 2:
                        Show_comp_picture("sciss");
                        break;
                    case 3:
                        Show_comp_picture("paper");
                        break;
                }
        }

        private void Game_start()
        {
            if (Game_mode != "play")
            {
                label_status.Text = "Сделайте ваш выбор:";
                Game_mode = "play";
            }

        }

        private void Check_Result()
        {
            Game_mode = "score";
            int win = 0;
            int draw = 0;
            int loss = 0;

            if (user_choice == comp_choice)
                draw++;
            else
            {
                if (user_choice == "stone")
                {
                    if (comp_choice == "sciss")
                        win++;
                    else
                        loss++;
                }
                    
                else if (user_choice == "sciss")
                {
                    if (comp_choice == "paper")
                        win++;
                    else
                        loss++;
                }
                else if (user_choice == "paper")
                {
                    if (comp_choice == "stone")
                        win++;
                    else
                        loss++;
                }
            }

            if (win > 0)
            {
                win_num++;
                label_status.Text = "Вы выиграли! :))";
            }
            if (draw > 0)
            {
                draw_num++;
                label_status.Text = "Ничья";
            }
            if (loss > 0)
            {
                loss_num++;
                label_status.Text = "Вы проиграли ((";
            }
            Show_score();
            
        }

        void Show_score ()
        {
            label_result.Text =
            "Побед:" + win_num +
            "  Ничьих:" + draw_num +
            "  Поражений:" + loss_num;
        }

        private void picture_user_stone_MouseClick(object sender, MouseEventArgs e)
        {
            if (Game_mode == "play")
                Check_Result();
            else
                Game_start();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            SetFrequency();
        }

        private void SetFrequency()
        {
            switch (trackBar1.Value)
            {
                case 1:
                    timer.Interval = 400;
                    break;
                case 2:
                    timer.Interval = 300;
                    break;
                case 3:
                    timer.Interval = 200;
                    break;
                case 4:
                    timer.Interval = 100;
                    break;
                case 5:
                    timer.Interval = 50;
                    break;
            }

                
        }
    }
}
