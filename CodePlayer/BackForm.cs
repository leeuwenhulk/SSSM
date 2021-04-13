using System;
using System.Linq;
using System.Windows.Forms;

namespace CodePlayer
{
    public partial class BackForm : Form
    {
        public BackForm()
        {
            InitializeComponent();
        }

        private void BackForm_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = Common.Today;
            RefreshList();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            var item = Common.GetCode(Common.DateDecimal(dateTimePicker1.Value));
            if (item is null)
            {
                Common.InsertOrUpdateCode(Common.DateDecimal(dateTimePicker1.Value), "");
                RefreshList();
                item = Common.GetCode(Common.DateDecimal(dateTimePicker1.Value));
            }

            textBox1.Text = item.Code;
        }

        private void button_yesterday_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.AddDays(-1);
        }

        private void button_tomorrow_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.AddDays(1);
        }

        private void button_today_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = Common.Today;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            Save();
            dateTimePicker1.Value = dateTimePicker1.Value.AddDays(1);
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            var end = DateTime.Today.AddDays(1 - DateTime.Today.Day);
            Common.DeleteCodes(Common.DateDecimal(end));
            RefreshList();
        }

        private void button_clearAll_Click(object sender, EventArgs e)
        {
            Common.DeleteCodes();
            RefreshList();
        }

        private void Save()
        {
            Common.InsertOrUpdateCode(Common.DateDecimal(dateTimePicker1.Value), textBox1.Text.Trim());
            RefreshList();
        }

        private void RefreshList()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in Common.GetCodes())
            {
                dataGridView1.Rows.Add(new object[] { item.Id, item.Code });
            }
        }
    }
}
