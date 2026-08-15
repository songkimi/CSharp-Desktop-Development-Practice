using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace 使用Winform和Json实现可长期使用的超市管理系统
{
    /// <summary>
    /// 这是自定义控件，可以展示商品名，单价，剩余数量。还支持顾客或管理员添加货物用于购买或者添加货物
    /// </summary>
    public partial class GoodsCard : UserControl
    {
        public GoodsCard()
        {
            InitializeComponent();
           
        }
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string GoodName
        {
            get => GoodsName.Text;
            set => GoodsName.Text = value;
        }
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public decimal Price
        {
            get => decimal.TryParse(GoodsPrice.Text.Replace("￥", ""), out var p) ? p : 0;
            set => GoodsPrice.Text = $"￥{value:F2}";
        }
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string GNum
        {
            get => GoodsNum.Text;
            set { GoodsNum.Text = $"{value}"; }
        }
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int CustomerSelectNum
        {
            get => (int)CustomerSelectGoodsNum.Value;
            set { CustomerSelectGoodsNum.Value = value; }
        }
        public void SetStorkMax(int MaxNum)
        {
            CustomerSelectGoodsNum.Maximum = MaxNum;
        }
        private void GoodsCard_Load(object sender, EventArgs e)
        {

        }

        private void CustomerSelectGoodsNum_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
