namespace 使用Winform和Json实现可长期使用的超市管理系统
{
    partial class ShowCustomerBuy
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
            txbShowBuy = new TextBox();
            btnChangeMode = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            txbSomeMessage = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txbShowBuy
            // 
            txbShowBuy.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txbShowBuy.Location = new Point(197, 65);
            txbShowBuy.Multiline = true;
            txbShowBuy.Name = "txbShowBuy";
            txbShowBuy.ScrollBars = ScrollBars.Vertical;
            txbShowBuy.Size = new Size(1027, 44);
            txbShowBuy.TabIndex = 0;
            txbShowBuy.Text = "1234567890123456789012345678901234567890123456789012345678901234567890\r\n";
            // 
            // btnChangeMode
            // 
            btnChangeMode.Location = new Point(338, 694);
            btnChangeMode.Name = "btnChangeMode";
            btnChangeMode.Size = new Size(112, 34);
            btnChangeMode.TabIndex = 1;
            btnChangeMode.Text = "更改样式";
            btnChangeMode.UseVisualStyleBackColor = true;
            btnChangeMode.Click += btnChangeMode_Click;
            // 
            // button1
            // 
            button1.Location = new Point(889, 694);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "结束购物";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(107, 115);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1200, 500);
            dataGridView1.TabIndex = 3;
            // 
            // txbSomeMessage
            // 
            txbSomeMessage.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            txbSomeMessage.Location = new Point(107, 621);
            txbSomeMessage.Name = "txbSomeMessage";
            txbSomeMessage.Size = new Size(797, 38);
            txbSomeMessage.TabIndex = 4;
            txbSomeMessage.Text = "1234567890123456789012345678901234567890";
            // 
            // ShowCustomerBuy
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1447, 822);
            Controls.Add(txbSomeMessage);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(btnChangeMode);
            Controls.Add(txbShowBuy);
            Name = "ShowCustomerBuy";
            Text = "展示账单";
            Load += ShowCustomerBuy_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbShowBuy;
        private Button btnChangeMode;
        private Button button1;
        private DataGridView dataGridView1;
        private TextBox txbSomeMessage;
    }
}