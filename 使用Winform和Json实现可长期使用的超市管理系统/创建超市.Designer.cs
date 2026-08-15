namespace 使用Winform和Json实现可长期使用的超市管理系统
{
    partial class 创建超市
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
            label2 = new Label();
            label3 = new Label();
            NameTxb = new TextBox();
            IdTxb = new TextBox();
            ClearBtn = new Button();
            AddNextBtn = new Button();
            NextStepBtn = new Button();
            label4 = new Label();
            PasswordTxb = new TextBox();
            TapLable = new Label();
            NewAdmins = new Panel();
            DbtAll = new Button();
            AddGoods = new Panel();
            GoodsNumNud = new NumericUpDown();
            label6 = new Label();
            PerviousStep = new Button();
            DelAllGoods = new Button();
            GoodsCategoriesCbb = new ComboBox();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            GetLastStep = new Button();
            GoodsNameTxb = new TextBox();
            AddNextGoods = new Button();
            GoodsPriceTxb = new TextBox();
            ClearTxb = new Button();
            saveFileDialog1 = new SaveFileDialog();
            saveFileDialog2 = new SaveFileDialog();
            saveFileDialog3 = new SaveFileDialog();
            NewAdmins.SuspendLayout();
            AddGoods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GoodsNumNud).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(160, 199);
            label1.Name = "label1";
            label1.Size = new Size(64, 24);
            label1.TabIndex = 0;
            label1.Text = "账号：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(160, 252);
            label2.Name = "label2";
            label2.Size = new Size(46, 24);
            label2.TabIndex = 1;
            label2.Text = "密码";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(323, 92);
            label3.Name = "label3";
            label3.Size = new Size(172, 24);
            label3.TabIndex = 2;
            label3.Text = "开始创建管理员信息";
            // 
            // NameTxb
            // 
            NameTxb.Location = new Point(230, 149);
            NameTxb.Name = "NameTxb";
            NameTxb.Size = new Size(396, 30);
            NameTxb.TabIndex = 3;
            // 
            // IdTxb
            // 
            IdTxb.Location = new Point(230, 196);
            IdTxb.Name = "IdTxb";
            IdTxb.Size = new Size(396, 30);
            IdTxb.TabIndex = 4;
            // 
            // ClearBtn
            // 
            ClearBtn.Location = new Point(179, 429);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(112, 34);
            ClearBtn.TabIndex = 5;
            ClearBtn.Text = "清空";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += button1_Click;
            // 
            // AddNextBtn
            // 
            AddNextBtn.Location = new Point(323, 429);
            AddNextBtn.Name = "AddNextBtn";
            AddNextBtn.Size = new Size(112, 34);
            AddNextBtn.TabIndex = 6;
            AddNextBtn.Text = "添加管理员";
            AddNextBtn.UseVisualStyleBackColor = true;
            AddNextBtn.Click += button2_Click;
            // 
            // NextStepBtn
            // 
            NextStepBtn.Location = new Point(684, 429);
            NextStepBtn.Name = "NextStepBtn";
            NextStepBtn.Size = new Size(112, 34);
            NextStepBtn.TabIndex = 7;
            NextStepBtn.Text = "下一步";
            NextStepBtn.UseVisualStyleBackColor = true;
            NextStepBtn.Click += NextStepBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(161, 149);
            label4.Name = "label4";
            label4.Size = new Size(64, 24);
            label4.TabIndex = 8;
            label4.Text = "名字：";
            // 
            // PasswordTxb
            // 
            PasswordTxb.Location = new Point(230, 249);
            PasswordTxb.Name = "PasswordTxb";
            PasswordTxb.Size = new Size(396, 30);
            PasswordTxb.TabIndex = 9;
            // 
            // TapLable
            // 
            TapLable.AutoSize = true;
            TapLable.Font = new Font("Microsoft YaHei UI", 7.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            TapLable.ForeColor = Color.Red;
            TapLable.Location = new Point(253, 282);
            TapLable.Name = "TapLable";
            TapLable.Size = new Size(373, 19);
            TapLable.TabIndex = 10;
            TapLable.Text = "密码需9-16个字符，只能且必须包含大小写字母，数字";
            TapLable.TextAlign = ContentAlignment.TopRight;
            // 
            // NewAdmins
            // 
            NewAdmins.Controls.Add(DbtAll);
            NewAdmins.Controls.Add(label4);
            NewAdmins.Controls.Add(TapLable);
            NewAdmins.Controls.Add(label1);
            NewAdmins.Controls.Add(PasswordTxb);
            NewAdmins.Controls.Add(label2);
            NewAdmins.Controls.Add(label3);
            NewAdmins.Controls.Add(NextStepBtn);
            NewAdmins.Controls.Add(NameTxb);
            NewAdmins.Controls.Add(AddNextBtn);
            NewAdmins.Controls.Add(IdTxb);
            NewAdmins.Controls.Add(ClearBtn);
            NewAdmins.Location = new Point(43, 42);
            NewAdmins.Name = "NewAdmins";
            NewAdmins.Size = new Size(828, 495);
            NewAdmins.TabIndex = 11;
            // 
            // DbtAll
            // 
            DbtAll.Location = new Point(472, 429);
            DbtAll.Name = "DbtAll";
            DbtAll.Size = new Size(184, 34);
            DbtAll.TabIndex = 11;
            DbtAll.Text = "删除已存入的管理员";
            DbtAll.UseVisualStyleBackColor = true;
            DbtAll.Click += DbtAll_Click;
            // 
            // AddGoods
            // 
            AddGoods.Controls.Add(GoodsNumNud);
            AddGoods.Controls.Add(label6);
            AddGoods.Controls.Add(PerviousStep);
            AddGoods.Controls.Add(DelAllGoods);
            AddGoods.Controls.Add(GoodsCategoriesCbb);
            AddGoods.Controls.Add(label5);
            AddGoods.Controls.Add(label7);
            AddGoods.Controls.Add(label8);
            AddGoods.Controls.Add(label9);
            AddGoods.Controls.Add(GetLastStep);
            AddGoods.Controls.Add(GoodsNameTxb);
            AddGoods.Controls.Add(AddNextGoods);
            AddGoods.Controls.Add(GoodsPriceTxb);
            AddGoods.Controls.Add(ClearTxb);
            AddGoods.Location = new Point(43, 42);
            AddGoods.Name = "AddGoods";
            AddGoods.Size = new Size(828, 495);
            AddGoods.TabIndex = 12;
            // 
            // GoodsNumNud
            // 
            GoodsNumNud.Location = new Point(248, 294);
            GoodsNumNud.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            GoodsNumNud.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            GoodsNumNud.Name = "GoodsNumNud";
            GoodsNumNud.Size = new Size(180, 30);
            GoodsNumNud.TabIndex = 13;
            GoodsNumNud.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(160, 296);
            label6.Name = "label6";
            label6.Size = new Size(82, 24);
            label6.TabIndex = 12;
            label6.Text = "进货数：";
            // 
            // PerviousStep
            // 
            PerviousStep.Location = new Point(77, 429);
            PerviousStep.Name = "PerviousStep";
            PerviousStep.Size = new Size(112, 34);
            PerviousStep.TabIndex = 11;
            PerviousStep.Text = "上一步";
            PerviousStep.UseVisualStyleBackColor = true;
            PerviousStep.Click += PerviousStep_Click;
            // 
            // DelAllGoods
            // 
            DelAllGoods.Location = new Point(341, 429);
            DelAllGoods.Name = "DelAllGoods";
            DelAllGoods.Size = new Size(184, 34);
            DelAllGoods.TabIndex = 10;
            DelAllGoods.Text = "删除已经存入的商品";
            DelAllGoods.UseVisualStyleBackColor = true;
            DelAllGoods.Click += DelAllGoods_Click;
            // 
            // GoodsCategoriesCbb
            // 
            GoodsCategoriesCbb.FormattingEnabled = true;
            GoodsCategoriesCbb.Items.AddRange(new object[] { "食品", "日用品", "电器", "床上用品", "奢侈品" });
            GoodsCategoriesCbb.Location = new Point(249, 249);
            GoodsCategoriesCbb.Name = "GoodsCategoriesCbb";
            GoodsCategoriesCbb.Size = new Size(396, 32);
            GoodsCategoriesCbb.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(161, 149);
            label5.Name = "label5";
            label5.Size = new Size(82, 24);
            label5.TabIndex = 8;
            label5.Text = "商品名：";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(179, 199);
            label7.Name = "label7";
            label7.Size = new Size(64, 24);
            label7.TabIndex = 0;
            label7.Text = "价格：";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(179, 249);
            label8.Name = "label8";
            label8.Size = new Size(50, 24);
            label8.TabIndex = 1;
            label8.Text = "类型:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(323, 92);
            label9.Name = "label9";
            label9.Size = new Size(154, 24);
            label9.TabIndex = 2;
            label9.Text = "创建超市商品信息";
            // 
            // GetLastStep
            // 
            GetLastStep.Location = new Point(684, 429);
            GetLastStep.Name = "GetLastStep";
            GetLastStep.Size = new Size(112, 34);
            GetLastStep.TabIndex = 7;
            GetLastStep.Text = "完成";
            GetLastStep.UseVisualStyleBackColor = true;
            GetLastStep.Click += GetLastStep_Click;
            // 
            // GoodsNameTxb
            // 
            GoodsNameTxb.Location = new Point(249, 149);
            GoodsNameTxb.Name = "GoodsNameTxb";
            GoodsNameTxb.Size = new Size(396, 30);
            GoodsNameTxb.TabIndex = 3;
            // 
            // AddNextGoods
            // 
            AddNextGoods.Location = new Point(544, 429);
            AddNextGoods.Name = "AddNextGoods";
            AddNextGoods.Size = new Size(112, 34);
            AddNextGoods.TabIndex = 6;
            AddNextGoods.Text = "添加下一种";
            AddNextGoods.UseVisualStyleBackColor = true;
            AddNextGoods.Click += AddNextGoods_Click;
            // 
            // GoodsPriceTxb
            // 
            GoodsPriceTxb.Location = new Point(249, 199);
            GoodsPriceTxb.Name = "GoodsPriceTxb";
            GoodsPriceTxb.Size = new Size(396, 30);
            GoodsPriceTxb.TabIndex = 4;
            // 
            // ClearTxb
            // 
            ClearTxb.Location = new Point(205, 429);
            ClearTxb.Name = "ClearTxb";
            ClearTxb.Size = new Size(112, 34);
            ClearTxb.TabIndex = 5;
            ClearTxb.Text = "清空";
            ClearTxb.UseVisualStyleBackColor = true;
            ClearTxb.Click += ClearTxb_Click;
            // 
            // 创建超市
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 553);
            Controls.Add(AddGoods);
            Controls.Add(NewAdmins);
            Name = "创建超市";
            Text = "创建超市";
            FormClosing += 创建超市_FormClosing;
            Load += 创建超市_Load;
            NewAdmins.ResumeLayout(false);
            NewAdmins.PerformLayout();
            AddGoods.ResumeLayout(false);
            AddGoods.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GoodsNumNud).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox NameTxb;
        private TextBox IdTxb;
        private Button ClearBtn;
        private Button AddNextBtn;
        private Button NextStepBtn;
        private Label label4;
        private TextBox PasswordTxb;
        private Label TapLable;
        private Panel NewAdmins;
        private Panel AddGoods;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button GetLastStep;
        private TextBox GoodsNameTxb;
        private Button AddNextGoods;
        private TextBox GoodsPriceTxb;
        private Button ClearTxb;
        private Button DbtAll;
        private SaveFileDialog saveFileDialog1;
        private ComboBox GoodsCategoriesCbb;
        private Button DelAllGoods;
        private Button PerviousStep;
        private Label label6;
        private NumericUpDown GoodsNumNud;
        private SaveFileDialog saveFileDialog2;
        private SaveFileDialog saveFileDialog3;
    }
}