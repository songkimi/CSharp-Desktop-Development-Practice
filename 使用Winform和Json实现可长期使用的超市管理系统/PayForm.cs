using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 使用Winform和Json实现可长期使用的超市管理系统
{
    /// <summary>
    /// 引导用户进行购买的窗体
    /// </summary>
    public partial class PayForm : Form
    {
        public PayForm()
        {
            InitializeComponent();
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public decimal NeedPay { get ; set; }
        private void PayForm_Load(object sender, EventArgs e)
        {
            txbPay.Text = NeedPay.ToString("F2");
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (TruePay.Text == string.Empty)
            {
                MessageBox.Show("请输入金额");
                return;
            }
            if (decimal.TryParse(TruePay.Text, out decimal truePay))
            {
                if (truePay >= NeedPay)
                {
                    MessageBox.Show("支付成功，将为您打印账单");
                }
                else
                {
                    MessageBox.Show("支付金额不足");
                    return;
                }
            }
            else
            {
                MessageBox.Show("请输入合法数字金额");
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }
        
    }
}
