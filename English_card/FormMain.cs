using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace English_card
{
    public partial class FormMain : Form
    {
        Dictionary dict;
        int curr = 0;
        public FormMain()
        {
            InitializeComponent();
            dict = new Dictionary();
            ShowCard();
        }

        public void ShowCard()
        {
            if (dict.Image (curr) != "")            
                pictureBox.Image = Image.FromFile(dict.Image(curr));
            labelEng.Text = dict.English(curr);
            labelRus.Text = dict.Russian(curr);
            labelVideo.Visible = dict.Video(curr) !="";
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (curr <= 0) return;
            curr--;
            ShowCard();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (curr >= dict.Total()-1) return;
            curr++;
            ShowCard();
        }

        private void play_mp3 (string filename)
        {
            if (filename == "") return;
            player.Visible = false;
            player.URL = filename;
        }

        private void play_mp4(string filename)
        {
            if (filename == "") return;
            player.Visible = true;
            player.uiMode = "none";
            player.URL = filename;
        }

        private void labelEng_Click(object sender, EventArgs e)
        {
            play_mp3(dict.Audio_eng(curr));
        }

        private void labelRus_Click(object sender, EventArgs e)
        {
            play_mp3(dict.Audio_rus(curr));
        }

        private void labelVideo_Click(object sender, EventArgs e)
        {
            play_mp4(dict.Video(curr));
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            play_mp4(dict.Video(curr));
        }

        private void player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 1)
                player.Visible = false;
        }
    }
}
