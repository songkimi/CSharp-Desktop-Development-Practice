namespace 使用Winform和Json实现可长期使用的超市管理系统
{
    partial class ShowSales
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
            monthCalendar1 = new MonthCalendar();
            dateTimePicker_Start = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            dateTimePicker_End = new DateTimePicker();
            label4 = new Label();
            btnRangeQuery = new Button();
            panel1 = new Panel();
            listBox1 = new ListBox();
            btnOKQuery = new Button();
            label6 = new Label();
            label5 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label7 = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(18, 18);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            monthCalendar1.DateSelected += monthCalendar1_DateSelected;
            // 
            // dateTimePicker_Start
            // 
            dateTimePicker_Start.Location = new Point(82, 326);
            dateTimePicker_Start.Name = "dateTimePicker_Start";
            dateTimePicker_Start.Size = new Size(300, 30);
            dateTimePicker_Start.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 283);
            label2.Name = "label2";
            label2.Size = new Size(190, 24);
            label2.TabIndex = 6;
            label2.Text = "设置时间跨度灵活查询";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 331);
            label3.Name = "label3";
            label3.Size = new Size(64, 24);
            label3.TabIndex = 7;
            label3.Text = "起始：";
            // 
            // dateTimePicker_End
            // 
            dateTimePicker_End.Location = new Point(82, 379);
            dateTimePicker_End.Name = "dateTimePicker_End";
            dateTimePicker_End.Size = new Size(300, 30);
            dateTimePicker_End.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 379);
            label4.Name = "label4";
            label4.Size = new Size(64, 24);
            label4.TabIndex = 9;
            label4.Text = "结束：";
            // 
            // btnRangeQuery
            // 
            btnRangeQuery.Location = new Point(12, 432);
            btnRangeQuery.Name = "btnRangeQuery";
            btnRangeQuery.Size = new Size(112, 34);
            btnRangeQuery.TabIndex = 10;
            btnRangeQuery.Text = "查询";
            btnRangeQuery.UseVisualStyleBackColor = true;
            btnRangeQuery.Click += btnRangeQuery_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(btnOKQuery);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(411, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(858, 419);
            panel1.TabIndex = 11;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(106, 79);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(604, 316);
            listBox1.TabIndex = 4;
            // 
            // btnOKQuery
            // 
            btnOKQuery.Location = new Point(716, 357);
            btnOKQuery.Name = "btnOKQuery";
            btnOKQuery.Size = new Size(112, 34);
            btnOKQuery.TabIndex = 3;
            btnOKQuery.Text = "确定";
            btnOKQuery.UseVisualStyleBackColor = true;
            btnOKQuery.Click += btnOKQuery_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 79);
            label6.Name = "label6";
            label6.Size = new Size(100, 24);
            label6.TabIndex = 2;
            label6.Text = "查询账单：";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label5.Location = new Point(3, 6);
            label5.Name = "label5";
            label5.Size = new Size(110, 31);
            label5.TabIndex = 0;
            label5.Text = "查询结果";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(411, 432);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(858, 362);
            flowLayoutPanel1.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 493);
            label7.Name = "label7";
            label7.Size = new Size(136, 24);
            label7.TabIndex = 13;
            label7.Text = "允许查询区间：";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 541);
            label8.Name = "label8";
            label8.Size = new Size(94, 24);
            label8.TabIndex = 14;
            label8.Text = "timeisnull";
            // 
            // ShowSales
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1281, 794);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(btnRangeQuery);
            Controls.Add(label4);
            Controls.Add(dateTimePicker_End);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateTimePicker_Start);
            Controls.Add(monthCalendar1);
            Name = "ShowSales";
            Text = "展示销售额";
            Load += ShowSales_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private DateTimePicker dateTimePicker_Start;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker_End;
        private Label label4;
        private Button btnRangeQuery;
        private Panel panel1;
        private Label label5;
        private Label label6;
        private Button btnOKQuery;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label7;
        private Label label8;
        private ListBox listBox1;
    }
}