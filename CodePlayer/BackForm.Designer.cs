
namespace CodePlayer
{
    partial class BackForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackForm));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button_yesterday = new System.Windows.Forms.Button();
            this.button_tomorrow = new System.Windows.Forms.Button();
            this.button_today = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_save = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_clearAll = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(8, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(303, 28);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker1.Location = new System.Drawing.Point(8, 8);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(228, 28);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button_yesterday
            // 
            this.button_yesterday.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_yesterday.Location = new System.Drawing.Point(236, 8);
            this.button_yesterday.Name = "button_yesterday";
            this.button_yesterday.Size = new System.Drawing.Size(75, 29);
            this.button_yesterday.TabIndex = 2;
            this.button_yesterday.Text = "前一天";
            this.button_yesterday.UseVisualStyleBackColor = true;
            this.button_yesterday.Click += new System.EventHandler(this.button_yesterday_Click);
            // 
            // button_tomorrow
            // 
            this.button_tomorrow.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_tomorrow.Location = new System.Drawing.Point(311, 8);
            this.button_tomorrow.Name = "button_tomorrow";
            this.button_tomorrow.Size = new System.Drawing.Size(75, 29);
            this.button_tomorrow.TabIndex = 3;
            this.button_tomorrow.Text = "后一天";
            this.button_tomorrow.UseVisualStyleBackColor = true;
            this.button_tomorrow.Click += new System.EventHandler(this.button_tomorrow_Click);
            // 
            // button_today
            // 
            this.button_today.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_today.Location = new System.Drawing.Point(386, 8);
            this.button_today.Name = "button_today";
            this.button_today.Size = new System.Drawing.Size(75, 29);
            this.button_today.TabIndex = 4;
            this.button_today.Text = "今天";
            this.button_today.UseVisualStyleBackColor = true;
            this.button_today.Click += new System.EventHandler(this.button_today_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_refresh.Location = new System.Drawing.Point(386, 8);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(75, 29);
            this.button_refresh.TabIndex = 5;
            this.button_refresh.Text = "刷新";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.button_yesterday);
            this.panel1.Controls.Add(this.button_tomorrow);
            this.panel1.Controls.Add(this.button_today);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8);
            this.panel1.Size = new System.Drawing.Size(469, 45);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.button_save);
            this.panel2.Controls.Add(this.button_refresh);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(8);
            this.panel2.Size = new System.Drawing.Size(469, 45);
            this.panel2.TabIndex = 8;
            // 
            // button_save
            // 
            this.button_save.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_save.Location = new System.Drawing.Point(311, 8);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 29);
            this.button_save.TabIndex = 6;
            this.button_save.Text = "修改";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button_clearAll);
            this.panel3.Controls.Add(this.button_clear);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 556);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(8);
            this.panel3.Size = new System.Drawing.Size(469, 46);
            this.panel3.TabIndex = 9;
            // 
            // button_clearAll
            // 
            this.button_clearAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_clearAll.Location = new System.Drawing.Point(158, 8);
            this.button_clearAll.Name = "button_clearAll";
            this.button_clearAll.Size = new System.Drawing.Size(150, 30);
            this.button_clearAll.TabIndex = 1;
            this.button_clearAll.Text = "清除所有数据";
            this.button_clearAll.UseVisualStyleBackColor = true;
            this.button_clearAll.Click += new System.EventHandler(this.button_clearAll_Click);
            // 
            // button_clear
            // 
            this.button_clear.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_clear.Location = new System.Drawing.Point(8, 8);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(150, 30);
            this.button_clear.TabIndex = 0;
            this.button_clear.Text = "清除非本月数据";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeight = 34;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(469, 466);
            this.dataGridView1.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "日期";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "口令";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // BackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 602);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BackForm";
            this.Text = "Back Stage";
            this.Load += new System.EventHandler(this.BackForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button_yesterday;
        private System.Windows.Forms.Button button_tomorrow;
        private System.Windows.Forms.Button button_today;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_clearAll;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}