namespace 使用Winform和Json实现可长期使用的超市管理系统
{
    partial class AddNewGoodsForm
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
            GoodsNumNud = new NumericUpDown();
            label6 = new Label();
            GoodsCategoriesCbb = new ComboBox();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            GetLastStep = new Button();
            GoodsNameTxb = new TextBox();
            AddNextGoods = new Button();
            GoodsPriceTxb = new TextBox();
            ClearTxb = new Button();
            ((System.ComponentModel.ISupportInitialize)GoodsNumNud).BeginInit();
            SuspendLayout();
            // 
            // GoodsNumNud
            // 
            GoodsNumNud.Location = new Point(340, 324);
            GoodsNumNud.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            GoodsNumNud.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            GoodsNumNud.Name = "GoodsNumNud";
            GoodsNumNud.Size = new Size(180, 30);
            GoodsNumNud.TabIndex = 27;
            GoodsNumNud.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(252, 326);
            label6.Name = "label6";
            label6.Size = new Size(82, 24);
            label6.TabIndex = 26;
            label6.Text = "进货数：";
            // 
            // GoodsCategoriesCbb
            // 
            GoodsCategoriesCbb.FormattingEnabled = true;
            GoodsCategoriesCbb.Items.AddRange(new object[] { "食品", "日用品", "电器", "床上用品", "奢侈品" });
            GoodsCategoriesCbb.Location = new Point(341, 279);
            GoodsCategoriesCbb.Name = "GoodsCategoriesCbb";
            GoodsCategoriesCbb.Size = new Size(396, 32);
            GoodsCategoriesCbb.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(253, 179);
            label5.Name = "label5";
            label5.Size = new Size(82, 24);
            label5.TabIndex = 22;
            label5.Text = "商品名：";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(271, 229);
            label7.Name = "label7";
            label7.Size = new Size(64, 24);
            label7.TabIndex = 14;
            label7.Text = "价格：";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(271, 279);
            label8.Name = "label8";
            label8.Size = new Size(50, 24);
            label8.TabIndex = 15;
            label8.Text = "类型:";
            // 
            // GetLastStep
            // 
            GetLastStep.Location = new Point(642, 459);
            GetLastStep.Name = "GetLastStep";
            GetLastStep.Size = new Size(112, 34);
            GetLastStep.TabIndex = 21;
            GetLastStep.Text = "完成";
            GetLastStep.UseVisualStyleBackColor = true;
            GetLastStep.Click += GetLastStep_Click;
            // 
            // GoodsNameTxb
            // 
            GoodsNameTxb.Location = new Point(341, 179);
            GoodsNameTxb.Name = "GoodsNameTxb";
            GoodsNameTxb.Size = new Size(396, 30);
            GoodsNameTxb.TabIndex = 17;
            // 
            // AddNextGoods
            // 
            AddNextGoods.Location = new Point(459, 459);
            AddNextGoods.Name = "AddNextGoods";
            AddNextGoods.Size = new Size(112, 34);
            AddNextGoods.TabIndex = 20;
            AddNextGoods.Text = "添加下一种";
            AddNextGoods.UseVisualStyleBackColor = true;
            AddNextGoods.Click += AddNextGoods_Click;
            // 
            // GoodsPriceTxb
            // 
            GoodsPriceTxb.Location = new Point(341, 229);
            GoodsPriceTxb.Name = "GoodsPriceTxb";
            GoodsPriceTxb.Size = new Size(396, 30);
            GoodsPriceTxb.TabIndex = 18;
            // 
            // ClearTxb
            // 
            ClearTxb.Location = new Point(297, 459);
            ClearTxb.Name = "ClearTxb";
            ClearTxb.Size = new Size(112, 34);
            ClearTxb.TabIndex = 19;
            ClearTxb.Text = "清空";
            ClearTxb.UseVisualStyleBackColor = true;
            ClearTxb.Click += ClearTxb_Click;
            // 
            // AddNewGoodsForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 614);
            Controls.Add(GoodsNumNud);
            Controls.Add(label6);
            Controls.Add(GoodsCategoriesCbb);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(GetLastStep);
            Controls.Add(GoodsNameTxb);
            Controls.Add(AddNextGoods);
            Controls.Add(GoodsPriceTxb);
            Controls.Add(ClearTxb);
            Name = "AddNewGoodsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "添加新商品";
            Load += AddNewGoodsForm_Load;
            ((System.ComponentModel.ISupportInitialize)GoodsNumNud).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown GoodsNumNud;
        private Label label6;
        private ComboBox GoodsCategoriesCbb;
        private Label label5;
        private Label label7;
        private Label label8;
        private Button GetLastStep;
        private TextBox GoodsNameTxb;
        private Button AddNextGoods;
        private TextBox GoodsPriceTxb;
        private Button ClearTxb;
    }
}