namespace 使用Winform和Json实现可长期使用的超市管理系统
{
    partial class PayForm
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
            label1 = new Label();
            txbPay = new TextBox();
            label2 = new Label();
            label3 = new Label();
            TruePay = new TextBox();
            btnPay = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(169, 104);
            label1.Name = "label1";
            label1.Size = new Size(154, 24);
            label1.TabIndex = 0;
            label1.Text = "本次购买需支付：";
            // 
            // txbPay
            // 
            txbPay.Location = new Point(310, 104);
            txbPay.Name = "txbPay";
            txbPay.ReadOnly = true;
            txbPay.Size = new Size(150, 30);
            txbPay.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(479, 107);
            label2.Name = "label2";
            label2.Size = new Size(28, 24);
            label2.TabIndex = 2;
            label2.Text = "元";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(223, 172);
            label3.Name = "label3";
            label3.Size = new Size(100, 24);
            label3.TabIndex = 3;
            label3.Text = "支付金额：";
            // 
            // TruePay
            // 
            TruePay.Location = new Point(310, 169);
            TruePay.Name = "TruePay";
            TruePay.Size = new Size(150, 30);
            TruePay.TabIndex = 4;
            // 
            // btnPay
            // 
            btnPay.Location = new Point(267, 261);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(112, 34);
            btnPay.TabIndex = 5;
            btnPay.Text = "支付";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // PayForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 371);
            Controls.Add(btnPay);
            Controls.Add(TruePay);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txbPay);
            Controls.Add(label1);
            Name = "PayForm";
            Text = "确定支付";
            Load += PayForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txbPay;
        private Label label2;
        private Label label3;
        private TextBox TruePay;
        private Button btnPay;
    }
}