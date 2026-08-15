using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 使用Winform和Json实现可长期使用的超市管理系统
{
    public partial class CustomerMode : Form
    {
        /// <summary>
        /// 顾客模式，支持用户使用卡片来进行购物，简直就像Jrpg游戏中购买道具的操作一样方便迅速
        /// </summary>
        public CustomerMode()
        {
            InitializeComponent();
            GolbalData.GoodsDataChanged += OnGoodsDataChanged;
        }
        GoodsRoot goodsroot = GolbalData.GoodsRoot;
        protected decimal UseNeedPay = 0;
        List<SalesItem> items = new List<SalesItem>();
        private void CustomerMode_Load(object sender, EventArgs e)
        {
            goodsroot.goods = DataStorage.Load<Goods>(AppConfig.Instance.GoodsJsonPath);
            RefreshgoodsCardUI();
        }
        StringBuilder SB = new StringBuilder();
        private void timer1_Tick(object sender, EventArgs e)
        {
            SB.Clear();
            SB.Append(DateTime.Now.ToString("yyyy-MM-dd HH:ss:tt", new System.Globalization.CultureInfo("zh-CN")));
            NowTime.Text = SB.ToString();
        }

        private void OnGoodsDataChanged()
        {
            if (this.InvokeRequired)
            {
                //当前不在UI线程，交给UI线程执行
                this.Invoke(() => RefreshgoodsCardUI());
            }
            else
            {
                RefreshgoodsCardUI();
            }
        }
        private void RefreshgoodsCardUI()
        {
            flowLayoutPanel1.Controls.Clear();
            var allNames = goodsroot.goods.Select(p => p.GoodsName).Distinct().ToList();
            foreach (var goods in allNames)
            {
                var thisGoods = goodsroot.goods.Where(p => p.GoodsName == goods).ToList();
                int Count = thisGoods.Count();
                GoodsCard card = new GoodsCard();
                card.GoodName = thisGoods[0].GoodsName;
                card.Price = thisGoods[0].Price;
                card.GNum = Count.ToString();
                card.Size = new Size(1000, 120);
                card.SetStorkMax(Count);
                flowLayoutPanel1.Controls.Add(card);
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            List<CartItem> tempCart = new List<CartItem>();
            foreach (var item in flowLayoutPanel1.Controls)
            {
                if (item is GoodsCard card)
                {
                    if (card.CustomerSelectNum > 0 || card.CustomerSelectNum <= int.Parse(card.GNum))
                    {
                        CartItem cartItem = new CartItem();
                        cartItem.GoodsName = card.GoodName;
                        cartItem.Price = card.Price;
                        cartItem.BuyCount = card.CustomerSelectNum;
                        tempCart.Add(cartItem);
                    }
                }
            }
            UseNeedPay = 0;
            foreach (var item in tempCart)
            {
                UseNeedPay += item.Price * item.BuyCount;
            }
            if (UseNeedPay == 0)
            {
                MessageBox.Show("你还没有选择任何商品");
                return;
            }
            using (PayForm payForm = new PayForm())
            {
                payForm.NeedPay = UseNeedPay;
                payForm.StartPosition = FormStartPosition.CenterScreen;
                payForm.ShowDialog(this);
                if (payForm.DialogResult != DialogResult.OK)
                {
                    MessageBox.Show("用户取消了付款");
                    return;
                }
                try
                {
                    Sales Sales = new Sales();
                    //保存购物车
                    GetItems(tempCart, items);
                    lock (GolbalData.Salesroot)
                    {
                        //保存用户购买的商品到集合
                        Sales.OrderId = GolbalData.Salesroot.NextOrderName;
                        Sales.SaleTime = DateTime.Now;
                        Sales.Price = UseNeedPay;
                        GolbalData.Salesroot.NextOrderName++;
                        Sales.Items = items;
                        GolbalData.Salesroot.Sales.Add(Sales);
                    }
                    DataStorage.Save(AppConfig.Instance.SalesJsonPath, GolbalData.Salesroot);
                    GolbalData.SaveAndBroadcastGoods(AppConfig.Instance.GoodsJsonPath);
                    ToShowCusBuy(Sales, tempCart);
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"发生了错误,{ex.Message}");
                }

            }
        }
        private void GetItems(List<CartItem> cartItems, List<SalesItem> salesItems)
        {

            List<Goods> goods = new List<Goods>();
            lock (GolbalData.GoodsRoot)
            {
                foreach (var item in cartItems)
                {
                    var tempList = goodsroot.goods.Where(p => p.GoodsName == item.GoodsName).Take(item.BuyCount).ToList();
                    goods.AddRange(tempList);
                }
                foreach (var g in goods)
                {
                    goodsroot.goods.Remove(g);
                }
            }

            foreach (var item in goods)
            {
                SalesItem salesItem = new SalesItem();
                salesItem.GoodsName = item.GoodsName;
                salesItem.GoodsId = item.GoodsId;
                salesItem.UnitPrice = item.Price;

                salesItems.Add(salesItem);
            }

        }

        public void ToShowCusBuy(Sales sales, List<CartItem> cartItems)
        {
            List<CartItem> carts = cartItems.Where(p => p.BuyCount != 0).ToList();
            using (ShowCustomerBuy show = new ShowCustomerBuy(sales, carts))
            {
                show.StartPosition = FormStartPosition.CenterScreen;
                show.ShowDialog();
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            
            
        }
        private void CustomerMode_FormClosed(object sender, FormClosedEventArgs e)
        {
            

        }
        private void CustomerMode_FormClosing(object sender, FormClosingEventArgs e)
        {
            GolbalData.GoodsDataChanged -= OnGoodsDataChanged;
        }
    }
}
