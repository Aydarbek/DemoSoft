using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class FormCalendar : Form
    {
        public FormCalendar()
        {
            InitializeComponent();
            ShowMonthPicture();
        }

        private void Calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            ShowMonthPicture();
        }

        private void ShowMonthPicture()
        {
            string month = Calendar.SelectionStart.Month.ToString();
            try
            {
                pictureBox.Image = Image.FromFile(@"months\" + month + ".jpg");
            }
            catch
            {
                MessageBox.Show("Папка с картинками не найдена", "Ошибка!");
            }
            
        }
    }
}
