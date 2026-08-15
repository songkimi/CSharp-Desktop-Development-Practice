using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Web;
using System.Windows.Forms;

namespace 使用Winform和Json实现可长期使用的超市管理系统
{
    /// <summary>
    /// 管理员操作主界面。提供：库存总览、批量补货、新增商品品类、查看历史销售报表等功能。
    /// </summary>
    public partial class AdminSetting : Form
    {
        public AdminSetting()
        {
            InitializeComponent();
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Administrators thisadmin { get; set; }
        List<NowGoodsNum> GoodsItems = new List<NowGoodsNum>();


        private void AdminSetting_Load(object sender, EventArgs e)
        {
            GetNowitems();
            DataViewshow();
            RefreshGridData();
            GolbalData.GoodsDataChanged += OnGoodsDataChanged;
            RefreshgoodsCardUI();
            label2.Text = "当前操作员：" + thisadmin.Name;
        }
        public void GetNowitems()
        {
            GoodsItems.Clear();
            List<string> GoodsName = GolbalData.GoodsRoot.goods.Select(p => p.GoodsName).Distinct().ToList();
            foreach (var gn in GoodsName)
            {
                NowGoodsNum now = new NowGoodsNum();
                var GoodsItem = GolbalData.GoodsRoot.goods.Where(p => p.GoodsName == gn).ToList();
                now.GoodsName = gn;
                now.Price = GoodsItem[0].Price;
                now.NowGount = GoodsItem.Count;
                GoodsItems.Add(now);
            }
        }
        public void DataViewshow()
        {
            dataGridView1.Columns.Clear();

            DataGridViewTextBoxColumn colName = new DataGridViewTextBoxColumn();
            colName.Name = "col_Name";
            colName.HeaderText = "商品名";
            colName.DataPropertyName = "GoodsName";
            colName.Width = 266;
            colName.ReadOnly = true;

            DataGridViewTextBoxColumn colPrice = new DataGridViewTextBoxColumn();
            colPrice.Name = "col_Price";
            colPrice.HeaderText = "单价";
            colPrice.DataPropertyName = "Price";
            colPrice.Width = 266;
            colPrice.ReadOnly = true;

            DataGridViewTextBoxColumn colNum = new DataGridViewTextBoxColumn();
            colNum.Name = "col_GoodsNum";
            colNum.HeaderText = "余量";
            colNum.DataPropertyName = "NowGount";
            colNum.Width = 268;
            colNum.ReadOnly = true;

            dataGridView1.Columns.Add(colName);
            dataGridView1.Columns.Add(colPrice);
            dataGridView1.Columns.Add(colNum);




        }
        public void RefreshGridData()
        {
            dataGridView1.DataSource = new BindingList<NowGoodsNum>(GoodsItems);
        }
        public void OnGoodsDataChanged()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(() => RefreshgoodsCardUI);
            }
            else
            {
                RefreshgoodsCardUI();
            }
        }
        public void RefreshgoodsCardUI()
        {
            GetNowitems();
            RefreshGridData();
            var SoldOutSoon = GoodsItems.Where(p => p.NowGount <= 10).ToList();
            if (SoldOutSoon.Count > 0)
            {
                foreach (var item in SoldOutSoon)
                {
                    txbGetMessage.AppendText($"{item.GoodsName}仅剩下{item.NowGount}件，请及时补货{Environment.NewLine}");
                }

            }
            flowLayoutPanel1.Controls.Clear();
            var allNames = GolbalData.GoodsRoot.goods.Select(p => p.GoodsName).Distinct().ToList();
            foreach (var goods in allNames)
            {
                var thisGoods = GolbalData.GoodsRoot.goods.Where(p => p.GoodsName == goods).ToList();
                int Count = thisGoods.Count();
                GoodsCard card = new GoodsCard();
                card.GoodName = thisGoods[0].GoodsName;
                card.Price = thisGoods[0].Price;
                card.GNum = Count.ToString();
                card.Size = new Size(1000, 120);
                card.SetStorkMax(1000);
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void AdminSetting_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            
        }

        private void AddGoods_Click(object sender, EventArgs e)
        {
            foreach (var items in flowLayoutPanel1.Controls)
            {
                if (items is GoodsCard goods)
                {
                    int AddNum = goods.CustomerSelectNum;
                    if (AddNum > 0)
                    {
                        Goods OldGoods = GolbalData.GoodsRoot.goods.FirstOrDefault(p => p.GoodsName == goods.GoodName)!;
                        for (int i = 0; i < AddNum; i++)
                        {
                            Goods newGood = new Goods(Guid.NewGuid().ToString("N"), goods.GoodName, goods.Price, OldGoods.Category);
                            GolbalData.GoodsRoot.goods.Add(newGood);
                        }
                        txbGetMessage.AppendText($"已经添加{AddNum}件{goods.GoodName}{Environment.NewLine}");
                    }
                }
            }
            GolbalData.SaveAndBroadcastGoods(AppConfig.Instance.GoodsJsonPath);
        }

        private void btnAddOthergoods_Click(object sender, EventArgs e)
        {
            AddNewGoodsForm addNews = new AddNewGoodsForm();
            addNews.ShowDialog();
        }

        private void btnNowGoods_Click(object sender, EventArgs e)
        {

        }

        private void btnLooksales_Click(object sender, EventArgs e)
        {
            ShowSales SS = new ShowSales();
            SS.Show();

        }

        private void AdminSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            GolbalData.GoodsDataChanged -= OnGoodsDataChanged;
        }
    }
}
