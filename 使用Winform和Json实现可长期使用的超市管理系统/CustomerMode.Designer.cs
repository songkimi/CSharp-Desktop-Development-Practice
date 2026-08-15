namespace 使用Winform和Json实现可长期使用的超市管理系统
{
    partial class CustomerMode
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            NowTime = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            TryPay = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // NowTime
            // 
            NowTime.AutoSize = true;
            NowTime.Location = new Point(12, 811);
            NowTime.Name = "NowTime";
            NowTime.Size = new Size(0, 24);
            NowTime.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(158, 95);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1000, 656);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.WrapContents = false;
            // 
            // TryPay
            // 
            TryPay.Location = new Point(1046, 768);
            TryPay.Name = "TryPay";
            TryPay.Size = new Size(112, 34);
            TryPay.TabIndex = 2;
            TryPay.Text = "结账";
            TryPay.UseVisualStyleBackColor = true;
            TryPay.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(199, 38);
            label1.Name = "label1";
            label1.Size = new Size(86, 31);
            label1.TabIndex = 3;
            label1.Text = "商品名";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label2.Location = new Point(455, 38);
            label2.Name = "label2";
            label2.Size = new Size(62, 31);
            label2.TabIndex = 4;
            label2.Text = "单价";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label3.Location = new Point(675, 39);
            label3.Name = "label3";
            label3.Size = new Size(110, 31);
            label3.TabIndex = 5;
            label3.Text = "商品数量";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label4.Location = new Point(976, 39);
            label4.Name = "label4";
            label4.Size = new Size(110, 31);
            label4.TabIndex = 6;
            label4.Text = "购买数量";
            // 
            // CustomerMode
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1378, 844);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TryPay);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(NowTime);
            Name = "CustomerMode";
            Text = "顾客模式";
            FormClosing += CustomerMode_FormClosing;
            FormClosed += CustomerMode_FormClosed;
            Load += CustomerMode_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label NowTime;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button TryPay;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}