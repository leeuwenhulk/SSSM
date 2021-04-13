
namespace CodePlayer
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_datetime = new System.Windows.Forms.Label();
            this.label_code = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_datetime
            // 
            this.label_datetime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_datetime.AutoSize = true;
            this.label_datetime.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_datetime.Location = new System.Drawing.Point(80, 0);
            this.label_datetime.Name = "label_datetime";
            this.label_datetime.Size = new System.Drawing.Size(207, 39);
            this.label_datetime.TabIndex = 0;
            this.label_datetime.Text = "---- -- -- --:--";
            // 
            // label_code
            // 
            this.label_code.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_code.AutoSize = true;
            this.label_code.Font = new System.Drawing.Font("微软雅黑", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_code.Location = new System.Drawing.Point(145, 77);
            this.label_code.Name = "label_code";
            this.label_code.Size = new System.Drawing.Size(76, 69);
            this.label_code.TabIndex = 1;
            this.label_code.Text = "--";
            this.label_code.DoubleClick += new System.EventHandler(this.label_code_DoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 367F));
            this.tableLayoutPanel1.Controls.Add(this.label_datetime, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_code, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 8);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(367, 184);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.DoubleClick += new System.EventHandler(this.tableLayoutPanel1_DoubleClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 200);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Text = "口令";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_datetime;
        private System.Windows.Forms.Label label_code;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Timer timer1;
    }
}

