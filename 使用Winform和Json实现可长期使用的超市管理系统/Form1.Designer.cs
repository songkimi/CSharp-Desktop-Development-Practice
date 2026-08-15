namespace 使用Winform和Json实现可长期使用的超市管理系统
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ChangeSaveBtn = new Button();
            SelectIdpan = new Panel();
            button1 = new Button();
            Adminbtn = new Button();
            CustomerBtn = new Button();
            label1 = new Label();
            SupermarketNameLable = new Label();
            AdminLoginpen = new Panel();
            lableTip = new Label();
            label4 = new Label();
            btnReturn = new Button();
            btnJoin = new Button();
            txbPassword = new TextBox();
            label3 = new Label();
            txbID = new TextBox();
            label2 = new Label();
            SelectIdpan.SuspendLayout();
            AdminLoginpen.SuspendLayout();
            SuspendLayout();
            // 
            // ChangeSaveBtn
            // 
            ChangeSaveBtn.Location = new Point(995, 612);
            ChangeSaveBtn.Name = "ChangeSaveBtn";
            ChangeSaveBtn.Size = new Size(139, 34);
            ChangeSaveBtn.TabIndex = 0;
            ChangeSaveBtn.Text = "切换超市存档";
            ChangeSaveBtn.TextAlign = ContentAlignment.TopCenter;
            ChangeSaveBtn.UseVisualStyleBackColor = true;
            ChangeSaveBtn.Click += ChangeSaveBtn_Click;
            // 
            // SelectIdpan
            // 
            SelectIdpan.Controls.Add(button1);
            SelectIdpan.Controls.Add(Adminbtn);
            SelectIdpan.Controls.Add(CustomerBtn);
            SelectIdpan.Controls.Add(label1);
            SelectIdpan.Controls.Add(ChangeSaveBtn);
            SelectIdpan.Location = new Point(73, 71);
            SelectIdpan.Name = "SelectIdpan";
            SelectIdpan.Size = new Size(1137, 649);
            SelectIdpan.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(995, 572);
            button1.Name = "button1";
            button1.Size = new Size(139, 34);
            button1.TabIndex = 5;
            button1.Text = "新建超市存档";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Adminbtn
            // 
            Adminbtn.Location = new Point(646, 275);
            Adminbtn.Name = "Adminbtn";
            Adminbtn.Size = new Size(112, 34);
            Adminbtn.TabIndex = 4;
            Adminbtn.Text = "我是管理员";
            Adminbtn.UseVisualStyleBackColor = true;
            Adminbtn.Click += Adminbtn_Click;
            // 
            // CustomerBtn
            // 
            CustomerBtn.Location = new Point(350, 275);
            CustomerBtn.Name = "CustomerBtn";
            CustomerBtn.Size = new Size(112, 34);
            CustomerBtn.TabIndex = 3;
            CustomerBtn.Text = "我是顾客";
            CustomerBtn.UseVisualStyleBackColor = true;
            CustomerBtn.Click += CustomerBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(333, 157);
            label1.Name = "label1";
            label1.Size = new Size(494, 31);
            label1.TabIndex = 2;
            label1.Text = "请选择您的身份，我们将更好的为您提供服务";
            // 
            // SupermarketNameLable
            // 
            SupermarketNameLable.AutoSize = true;
            SupermarketNameLable.Location = new Point(12, 9);
            SupermarketNameLable.Name = "SupermarketNameLable";
            SupermarketNameLable.Size = new Size(118, 24);
            SupermarketNameLable.TabIndex = 1;
            SupermarketNameLable.Text = "当前超市名称";
            // 
            // AdminLoginpen
            // 
            AdminLoginpen.Controls.Add(lableTip);
            AdminLoginpen.Controls.Add(label4);
            AdminLoginpen.Controls.Add(btnReturn);
            AdminLoginpen.Controls.Add(btnJoin);
            AdminLoginpen.Controls.Add(txbPassword);
            AdminLoginpen.Controls.Add(label3);
            AdminLoginpen.Controls.Add(txbID);
            AdminLoginpen.Controls.Add(label2);
            AdminLoginpen.Location = new Point(73, 71);
            AdminLoginpen.Name = "AdminLoginpen";
            AdminLoginpen.Size = new Size(1137, 649);
            AdminLoginpen.TabIndex = 3;
            // 
            // lableTip
            // 
            lableTip.AutoSize = true;
            lableTip.Location = new Point(394, 331);
            lableTip.Name = "lableTip";
            lableTip.Size = new Size(0, 24);
            lableTip.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label4.Location = new Point(475, 143);
            label4.Name = "label4";
            label4.Size = new Size(213, 37);
            label4.TabIndex = 6;
            label4.Text = "管理员登录界面";
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(433, 358);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(112, 34);
            btnReturn.TabIndex = 5;
            btnReturn.Text = "返回";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnJoin
            // 
            btnJoin.Location = new Point(636, 358);
            btnJoin.Name = "btnJoin";
            btnJoin.Size = new Size(112, 34);
            btnJoin.TabIndex = 4;
            btnJoin.Text = "登录";
            btnJoin.UseVisualStyleBackColor = true;
            btnJoin.Click += btnJoin_Click;
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(394, 284);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(385, 30);
            txbPassword.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(323, 284);
            label3.Name = "label3";
            label3.Size = new Size(64, 24);
            label3.TabIndex = 2;
            label3.Text = "密码：";
            // 
            // txbID
            // 
            txbID.Location = new Point(394, 232);
            txbID.Name = "txbID";
            txbID.Size = new Size(385, 30);
            txbID.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(323, 236);
            label2.Name = "label2";
            label2.Size = new Size(50, 24);
            label2.TabIndex = 0;
            label2.Text = "账号:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1378, 844);
            Controls.Add(AdminLoginpen);
            Controls.Add(SelectIdpan);
            Controls.Add(SupermarketNameLable);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            SelectIdpan.ResumeLayout(false);
            SelectIdpan.PerformLayout();
            AdminLoginpen.ResumeLayout(false);
            AdminLoginpen.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ChangeSaveBtn;
        private Panel SelectIdpan;
        private Label SupermarketNameLable;
        private Label label1;
        private Button CustomerBtn;
        private Button Adminbtn;
        private Button button1;
        private Panel AdminLoginpen;
        private Label lableTip;
        private Label label4;
        private Button btnReturn;
        private Button btnJoin;
        private TextBox txbPassword;
        private Label label3;
        private TextBox txbID;
        private Label label2;
    }
}
