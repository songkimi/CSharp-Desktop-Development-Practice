namespace 使用Winform和Json实现可长期使用的超市管理系统
{
    partial class SalesCard
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            LableTime = new Label();
            dataGridView1 = new DataGridView();
            TotalIncome = new Label();
            txbTotalGet = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // LableTime
            // 
            LableTime.AutoSize = true;
            LableTime.Font = new Font("Microsoft YaHei UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            LableTime.Location = new Point(3, 16);
            LableTime.Name = "LableTime";
            LableTime.Size = new Size(84, 20);
            LableTime.TabIndex = 0;
            LableTime.Text = "LableTime";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 53);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(300, 244);
            dataGridView1.TabIndex = 1;
            // 
            // TotalIncome
            // 
            TotalIncome.AutoSize = true;
            TotalIncome.Location = new Point(3, 319);
            TotalIncome.Name = "TotalIncome";
            TotalIncome.Size = new Size(82, 24);
            TotalIncome.TabIndex = 2;
            TotalIncome.Text = "总收入：";
            // 
            // txbTotalGet
            // 
            txbTotalGet.Location = new Point(79, 319);
            txbTotalGet.Name = "txbTotalGet";
            txbTotalGet.Size = new Size(150, 30);
            txbTotalGet.TabIndex = 3;
            // 
            // SalesCard
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txbTotalGet);
            Controls.Add(TotalIncome);
            Controls.Add(dataGridView1);
            Controls.Add(LableTime);
            Name = "SalesCard";
            Size = new Size(300, 455);
            Load += SalesCard_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LableTime;
        private DataGridView dataGridView1;
        private Label TotalIncome;
        private TextBox txbTotalGet;
    }
}
