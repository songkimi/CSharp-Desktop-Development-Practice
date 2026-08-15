using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 使用Winform和Json实现可长期使用的超市管理系统
{
    public partial class ShowSales : Form
    {
        /// <summary>
        /// 有点复杂的销量展示窗体，但跟原来使用控制台会简单一些，写这么多是因为窗体能展示更多内容所以丰富了这类功能，这里也能结合GDI+来绘制销量曲线，这是一个十分简单且重复枯燥的活，我不干了
        /// </summary>
        public ShowSales()
        {
            InitializeComponent();
        }
        DateTime OlderlistTime = DateTime.MinValue;
        DateTime Newtime = DateTime.MinValue;
        Dictionary<string, Sales> Dicsales = new Dictionary<string, Sales>();
        private void ShowSales_Load(object sender, EventArgs e)
        {
            Sales firstBill = null;
            Sales lastBill = null;
            lock (GolbalData.Salesroot)
            {
                firstBill = GolbalData.Salesroot.Sales.Where(s => s.OrderId == 1).FirstOrDefault()!;
                lastBill = GolbalData.Salesroot.Sales.OrderByDescending(s => s.SaleTime).FirstOrDefault()!;
            }
            OlderlistTime = firstBill.SaleTime; Newtime = lastBill.SaleTime;
            if (firstBill == null || lastBill == null)
            {
                MessageBox.Show("当前没有任何账单");
                Close();
            }
            panel1.Visible = false;
            label8.Text = $"{firstBill!.SaleTime.ToString("yyyy-MM-dd")} ~ {lastBill!.SaleTime.ToString("yyyy-MM-dd")}";
            GetYearMonethBills();
        }
        /// <summary>
        /// 将系统内所有销售记录按月分组，并为每个月生成一张销量卡片（SalesCard）
        /// </summary>
        public void GetYearMonethBills()
        {
            lock (GolbalData.Salesroot)
            {
                var groupByMonth = GolbalData.Salesroot.Sales.GroupBy(s => new { s.SaleTime.Year, s.SaleTime.Month }).ToList();
                foreach (var group in groupByMonth)
                {
                    DateTime MonthOrderTime = group.Min(x => x.SaleTime);
                    DateTime MonthLastTime = group.Max(x => x.SaleTime);
                    DrawsalesCard(MonthOrderTime, MonthLastTime, group.ToList());
                }
            }
        }
        //用来画每一月的账单条
        public void DrawsalesCard(DateTime first, DateTime end, List<Sales> sales)
        {
            string TimeMessage = $"{first.ToString("yyyy-MM-dd")}-{first.ToString("yyyy-MM-dd")}";
            var allItems = sales.SelectMany(s => s.Items);
            var goodsGroup = allItems.GroupBy(s => s.GoodsName).ToList();
            decimal totle = 0;
            List<CartItem> cartItems = new List<CartItem>();
            foreach (var good in goodsGroup)
            {
                totle += good.Count() * good.ToList()[0].UnitPrice;
                cartItems.Add(new CartItem { GoodsName = good.Key, BuyCount = good.Count(), Price = good.ToList()[0].UnitPrice });
            }
            try
            {
                SalesCard salesCard = new SalesCard();
                salesCard.Date = TimeMessage;
                salesCard.cartItems = cartItems;
                flowLayoutPanel1.Controls.Add(salesCard);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"绘制卡片时出现错误：{ex.Message}");
            }
        }

        private void btnSelectOneDay_Click(object sender, EventArgs e)
        {
            //已删除控件
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            dateTimePicker_Start.Value = e.Start.Date;
            dateTimePicker_End.Value = e.End.Date;
        }

        private void btnRangeQuery_Click(object sender, EventArgs e)
        {
            Dicsales.Clear();
            listBox1.Items.Clear();
            //Action( bool a = dateTimePicker_Start.Value > dateTimePicker_End.Value => { MessageBox.Show("请保证起始日期大于结束日期"); return; })
            if (dateTimePicker_Start.Value > dateTimePicker_End.Value)
            {
                MessageBox.Show("请保证起始日期早于结束日期"); return;
            }
            if (dateTimePicker_Start.Value < OlderlistTime || dateTimePicker_Start.Value > Newtime || dateTimePicker_End.Value > Newtime || dateTimePicker_End.Value < OlderlistTime)
            {
                if(dateTimePicker_Start.Value < OlderlistTime || dateTimePicker_Start.Value > Newtime) dateTimePicker_Start.Value = OlderlistTime;
                if(dateTimePicker_End.Value >  Newtime || dateTimePicker_End.Value < OlderlistTime) dateTimePicker_End.Value = Newtime;
                MessageBox.Show($"将为您更正查询范围并查询处于边缘的数据，具体范围是{dateTimePicker_Start.Value} ~ {dateTimePicker_End.Value}");
            }
            List<Sales> queryResult = null;
            if (dateTimePicker_Start.Value == dateTimePicker_End.Value)
            {
                DateTime OnlyOneTime = dateTimePicker_Start.Value;

                lock (GolbalData.Salesroot)
                {
                    queryResult = GolbalData.Salesroot.Sales.Where(s => s.SaleTime >= OnlyOneTime && s.SaleTime < OnlyOneTime.AddDays(1)).ToList();
                }

            }
            else
            {
                DateTime StartTime = dateTimePicker_Start.Value;
                DateTime Endtime = dateTimePicker_End.Value;
                lock (GolbalData.Salesroot)
                {
                    queryResult = GolbalData.Salesroot.Sales.Where(s => s.SaleTime >= StartTime && s.SaleTime < Endtime.AddDays(1)).ToList();
                }
            }
            if (queryResult.Count != 0)
            {
                foreach (Sales s in queryResult)
                {
                    Dicsales.Add(new string($"账单编号：{s.OrderId},具体日期{s.SaleTime:yyyy-MM-dd HH:mm:ss}"), s);
                    listBox1.Items.Add($"账单编号：{s.OrderId},具体日期{s.SaleTime:yyyy-MM-dd HH:mm:ss}");
                }
                panel1.Visible = true;
            }

        }

        private void btnOKQuery_Click(object sender, EventArgs e)
        {
            string select = listBox1.SelectedItem?.ToString();
            if (select != string.Empty)
            {
                if (Dicsales.TryGetValue(select, out Sales sales))
                {
                    var salesDispose = sales.Items.GroupBy(p => p.GoodsName).Select(g => new
                    {
                        GoodsName = g.Key,
                        ItemsList = g.ToList()
                    }).ToList();
                    List<CartItem> cartItems = new List<CartItem>();
                    foreach(var s in salesDispose)
                    {
                        CartItem item = new CartItem();
                        item.GoodsName = s.GoodsName;
                        item.Price = s.ItemsList[0].UnitPrice;
                        item.BuyCount = s.ItemsList.Count;
                        cartItems.Add(item);
                    }
                    ShowCustomerBuy SCB = new ShowCustomerBuy(sales, cartItems);
                        SCB.Show();
                    
                }
                
            }
        }

    } 
}
