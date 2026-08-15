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
    /// 又是一个自定义控件，这个卡片主要用来展示一个月总的各个商品的销量及总收入
    /// </summary>
    public partial class SalesCard : UserControl
    {
        public SalesCard()
        {
            InitializeComponent();
        }
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Date { get => LableTime.Text; set => LableTime.Text = value; }
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<CartItem> cartItems { get; set; } = new List<CartItem>();
        string totalCome =string.Empty;
        private void SalesCard_Load(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn colName = new DataGridViewTextBoxColumn();
            colName.Name = "col_GoodsName";
            colName.HeaderText = "商品名";
            colName.DataPropertyName = "GoodsName";
            colName.Width = 100;
            colName.ReadOnly = true;

            DataGridViewTextBoxColumn colPrice = new DataGridViewTextBoxColumn();
            colPrice.Name = "col_Price";
            colPrice.HeaderText = "单价";
            colPrice.DataPropertyName = "Price";
            colPrice.Width = 100;
            colPrice.ReadOnly = true;

            DataGridViewTextBoxColumn colBuyNum = new DataGridViewTextBoxColumn();
            colBuyNum.Name = "col_BuyNum";
            colBuyNum.HeaderText = "购买数量";
            colBuyNum.DataPropertyName = "BuyCount";
            colBuyNum.Width = 100;
            colBuyNum.ReadOnly = true;

            dataGridView1.Columns.Add(colName);
            dataGridView1.Columns.Add(colPrice);
            dataGridView1.Columns.Add(colBuyNum);

            dataGridView1.DataSource = new BindingList<CartItem>(cartItems);
            decimal colparice = 0;
            foreach (var item in cartItems)
            {
                colparice += item.Price * item.BuyCount;  
            }
            txbTotalGet.Text = colparice.ToString("f2");
        }
    }
}
