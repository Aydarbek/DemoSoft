using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MindCounter
{
    public partial class Form_settings : Form
    {
        int count_max;

        public int Count_max
        {
            get { return count_max; }
            set { count_max = value; }
        }
        public Form_settings()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (radio_easy.Checked)
            {
                Count_max = 5;
            }

            if (radio_medium.Checked)
            {
                Count_max = 10;
            }

            if (radio_hard.Checked)
            {
                Count_max = 15;
            }

            Close();
        }
    }
}
