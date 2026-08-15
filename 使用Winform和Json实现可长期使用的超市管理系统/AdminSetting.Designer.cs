namespace 使用Winform和Json实现可长期使用的超市管理系统
{
    partial class AdminSetting
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
            DisplayGoodsNum = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            txbGetMessage = new TextBox();
            btnAddOthergoods = new Button();
            btnLooksales = new Button();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            AddGoods = new Button();
            DisplayGoodsNum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // DisplayGoodsNum
            // 
            DisplayGoodsNum.Controls.Add(label1);
            DisplayGoodsNum.Controls.Add(dataGridView1);
            DisplayGoodsNum.Location = new Point(236, 0);
            DisplayGoodsNum.Name = "DisplayGoodsNum";
            DisplayGoodsNum.Size = new Size(811, 508);
            DisplayGoodsNum.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 30);
            label1.Name = "label1";
            label1.Size = new Size(181, 29);
            label1.TabIndex = 1;
            label1.Text = "当前各产品余量";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 89);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(800, 396);
            dataGridView1.TabIndex = 0;
            // 
            // txbGetMessage
            // 
            txbGetMessage.Location = new Point(1053, 0);
            txbGetMessage.Multiline = true;
            txbGetMessage.Name = "txbGetMessage";
            txbGetMessage.Size = new Size(313, 816);
            txbGetMessage.TabIndex = 1;
            // 
            // btnAddOthergoods
            // 
            btnAddOthergoods.Location = new Point(46, 25);
            btnAddOthergoods.Name = "btnAddOthergoods";
            btnAddOthergoods.Size = new Size(112, 34);
            btnAddOthergoods.TabIndex = 3;
            btnAddOthergoods.Text = "添加新货";
            btnAddOthergoods.UseVisualStyleBackColor = true;
            btnAddOthergoods.Click += btnAddOthergoods_Click;
            // 
            // btnLooksales
            // 
            btnLooksales.Location = new Point(46, 89);
            btnLooksales.Name = "btnLooksales";
            btnLooksales.Size = new Size(112, 34);
            btnLooksales.TabIndex = 4;
            btnLooksales.Text = "销售额";
            btnLooksales.UseVisualStyleBackColor = true;
            btnLooksales.Click += btnLooksales_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 811);
            label2.Name = "label2";
            label2.Size = new Size(120, 24);
            label2.TabIndex = 5;
            label2.Text = "AdminName";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(46, 514);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1001, 294);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.WrapContents = false;
            // 
            // AddGoods
            // 
            AddGoods.Location = new Point(45, 451);
            AddGoods.Name = "AddGoods";
            AddGoods.Size = new Size(112, 34);
            AddGoods.TabIndex = 6;
            AddGoods.Text = "添加商品";
            AddGoods.UseVisualStyleBackColor = true;
            AddGoods.Click += AddGoods_Click;
            // 
            // AdminSetting
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1378, 844);
            Controls.Add(AddGoods);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label2);
            Controls.Add(btnLooksales);
            Controls.Add(btnAddOthergoods);
            Controls.Add(txbGetMessage);
            Controls.Add(DisplayGoodsNum);
            Name = "AdminSetting";
            Text = "管理员模式";
            FormClosing += AdminSetting_FormClosing;
            FormClosed += AdminSetting_FormClosed;
            Load += AdminSetting_Load;
            DisplayGoodsNum.ResumeLayout(false);
            DisplayGoodsNum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel DisplayGoodsNum;
        private TextBox txbGetMessage;
        private Button btnAddOthergoods;
        private Button btnLooksales;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button AddGoods;
    }
}