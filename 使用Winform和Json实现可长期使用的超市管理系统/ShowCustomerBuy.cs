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
    /// 展示顾客的账单，管理员也能使用这个窗体来展示用户的账单
    /// </summary>
    public partial class ShowCustomerBuy : Form
    {
        public ShowCustomerBuy(Sales salesData, List<CartItem> cartitem)
        {
            InitializeComponent();
            sales = salesData;
            cartItems = cartitem;
        }

        private void btnChangeMode_Click(object sender, EventArgs e)
        {
            if (Mode)
            {
                Mode = false;
            }
            else
            {
                Mode = true;
            }
            ShowText(Mode, sales!, cartItems!);
        }
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Sales? sales { get; set; }
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<CartItem>? cartItems { get; set; }
        bool Mode = false;

        private void ShowCustomerBuy_Load(object sender, EventArgs e)
        {
            ShowText(Mode, sales!, cartItems!);
        }
        private void ShowText(bool mode, Sales sales, List<CartItem> cartItems)
        {
            txbShowBuy.Text = $"{new string(' ', 32)}账单如下{Environment.NewLine}";
            txbSomeMessage.Clear();
            string OrderID = sales.OrderId.ToString();
            string PayTime = sales.SaleTime.ToString("yyyy-MM-dd HH-ss");
            string Price = sales.Price.ToString("f2");
            txbSomeMessage.Text = $"订单编号：{sales.OrderId}      下单时间:{sales.SaleTime}     总消费{sales.Price}";
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            if (mode)
            {
                GetDataViewToCartItem(cartItems);
            }
            else
            {
                GetDataViewToSalesItem(sales.Items);
            }

        }
        /// <summary>
        /// 将购物车项集合映射并绑定到 <c>dataGridView1</c>，用于在表格中显示购物车中的商品信息。
        /// </summary>
        /// <param name="carts">要显示的购物车项列表。每个 <c>CartItem</c> 应包含 <c>GoodsName</c>、<c>Price</c> 和 <c>BuyCount</c> 属性。</param>
        /// <remarks>
        /// 此方法会：
        /// - 创建三列：商品名称、单价、购买数量，并设置列名、HeaderText、DataPropertyName、宽度和只读属性；
        /// - 将创建的列添加到 <c>dataGridView1</c> 中；
        /// - 使用 <see cref="BindingList{T}"/> 将传入的购物车列表绑定到 <c>dataGridView1.DataSource</c>，以便支持简单的数据绑定和界面展示。
        /// 
        /// 注意：
        /// - 调用该方法前通常会清空并重建 <c>dataGridView1</c> 的列与数据（见调用处逻辑）；
        /// - 方法假定传入的 <c>carts</c> 非空且其项的属性与列的 <c>DataPropertyName</c> 对应，否则界面上不会显示预期数据。
        /// </remarks>
        public void GetDataViewToCartItem(List<CartItem> carts)
        {
            DataGridViewTextBoxColumn colName = new DataGridViewTextBoxColumn();
            colName.Name = "col_GoodsName";
            colName.HeaderText = "商品名称";
            colName.DataPropertyName = "GoodsName";
            colName.Width = 400;
            colName.ReadOnly = true;

            DataGridViewTextBoxColumn colPrice = new DataGridViewTextBoxColumn();
            colPrice.Name = "col_UnitPrice";
            colPrice.HeaderText = "单价";
            colPrice.DataPropertyName = "Price";
            colPrice.Width = 400;
            colPrice.ReadOnly = true;

            DataGridViewTextBoxColumn colBuyNum = new DataGridViewTextBoxColumn();
            colBuyNum.Name = "col_BuyNum";
            colBuyNum.HeaderText = "购买数量";
            colBuyNum.DataPropertyName = "BuyCount";
            colBuyNum.Width = 400;
            colBuyNum.ReadOnly = true;

            dataGridView1.Columns.Add(colName);
            dataGridView1.Columns.Add(colPrice);
            dataGridView1.Columns.Add(colBuyNum);

            dataGridView1.DataSource = new BindingList<CartItem>(carts);
        }
        public void GetDataViewToSalesItem(List<SalesItem> sales)
        {
            DataGridViewTextBoxColumn colID = new DataGridViewTextBoxColumn();
            colID.Name = "col_GoodsID";
            colID.HeaderText = "商品编码";
            colID.DataPropertyName = "GoodsId";
            colID.Width = 400;
            colID.ReadOnly = true;

            DataGridViewTextBoxColumn colName = new DataGridViewTextBoxColumn();
            colName.Name = "col_GoodsName";
            colName.HeaderText = "商品名称";
            colName.DataPropertyName = "GoodsName";
            colName.Width = 400;
            colName.ReadOnly = true;


            DataGridViewTextBoxColumn colPrice = new DataGridViewTextBoxColumn();
            colPrice.Name = "col_UnitPrice";
            colPrice.HeaderText = "单价";
            colPrice.DataPropertyName = "UnitPrice";
            colPrice.Width = 400;
            colPrice.ReadOnly = true;


            dataGridView1.Columns.Add(colID);
            dataGridView1.Columns.Add(colName);
            dataGridView1.Columns.Add(colPrice);


            dataGridView1.DataSource = new BindingList<SalesItem>(sales);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
