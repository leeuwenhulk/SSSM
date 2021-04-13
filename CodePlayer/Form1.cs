using System;
using System.Windows.Forms;

namespace CodePlayer
{
    public partial class Form1 : Form
    {
        private DateTime nextMinutes;

        public Form1()
        {
            InitializeComponent();
            nextMinutes = DateTime.Now;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            ShowBackStage();
        }

        private void tableLayoutPanel1_DoubleClick(object sender, EventArgs e)
        {
            ShowBackStage();
        }

        private void label_code_DoubleClick(object sender, EventArgs e)
        {
            ShowBackStage();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now >= nextMinutes)
            {
                label_datetime.Text = DateTime.Now.ToString("yyyy MM dd HH:mm");
                label_code.Text = Common.GetCode(Common.TodayDecimal)?.Code;
                nextMinutes = DateTime.Parse(label_datetime.Text).AddMinutes(1);
            }
        }

        private void ShowBackStage()
        {
            new BackForm().ShowDialog();
            nextMinutes = DateTime.Now;
        }
    }
}
