namespace 使用Winform和Json实现可长期使用的超市管理系统
{
    partial class GoodsCard
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
            GoodsName = new Label();
            CustomerSelectGoodsNum = new NumericUpDown();
            GoodsPrice = new Label();
            GoodsNum = new Label();
            ((System.ComponentModel.ISupportInitialize)CustomerSelectGoodsNum).BeginInit();
            SuspendLayout();
            // 
            // GoodsName
            // 
            GoodsName.AutoSize = true;
            GoodsName.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GoodsName.Location = new Point(52, 48);
            GoodsName.Name = "GoodsName";
            GoodsName.Size = new Size(78, 32);
            GoodsName.TabIndex = 0;
            GoodsName.Text = "label1";
            // 
            // CustomerSelectGoodsNum
            // 
            CustomerSelectGoodsNum.Location = new Point(726, 53);
            CustomerSelectGoodsNum.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            CustomerSelectGoodsNum.Name = "CustomerSelectGoodsNum";
            CustomerSelectGoodsNum.Size = new Size(180, 30);
            CustomerSelectGoodsNum.TabIndex = 1;
            CustomerSelectGoodsNum.ValueChanged += CustomerSelectGoodsNum_ValueChanged;
            // 
            // GoodsPrice
            // 
            GoodsPrice.AutoSize = true;
            GoodsPrice.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GoodsPrice.Location = new Point(276, 48);
            GoodsPrice.Name = "GoodsPrice";
            GoodsPrice.Size = new Size(78, 32);
            GoodsPrice.TabIndex = 3;
            GoodsPrice.Text = "label1";
            // 
            // GoodsNum
            // 
            GoodsNum.AutoSize = true;
            GoodsNum.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GoodsNum.Location = new Point(500, 48);
            GoodsNum.Name = "GoodsNum";
            GoodsNum.Size = new Size(78, 32);
            GoodsNum.TabIndex = 4;
            GoodsNum.Text = "label1";
            // 
            // GoodsCard
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(GoodsNum);
            Controls.Add(GoodsPrice);
            Controls.Add(CustomerSelectGoodsNum);
            Controls.Add(GoodsName);
            Name = "GoodsCard";
            Size = new Size(1000, 120);
            Load += GoodsCard_Load;
            ((System.ComponentModel.ISupportInitialize)CustomerSelectGoodsNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label GoodsName;
        private NumericUpDown CustomerSelectGoodsNum;
        private Label GoodsPrice;
        private Label GoodsNum;
    }
}
