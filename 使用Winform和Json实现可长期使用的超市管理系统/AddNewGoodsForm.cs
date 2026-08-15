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
    /// 这个是管理员在添加新货物的时候要用到的窗体，整体代码和创建超市窗体的第二个Penal控件中布局是差不多的
    /// </summary>
    public partial class AddNewGoodsForm : Form
    {
        public AddNewGoodsForm()
        {
            InitializeComponent();
        }
        public void ClearGoodsTxb()
        {
            GoodsNameTxb.Text = string.Empty;
            GoodsNumNud.Value = 100;
            GoodsCategoriesCbb.SelectedIndex = -1;
            GoodsPriceTxb.Text = string.Empty;
        }

        private void ClearTxb_Click(object sender, EventArgs e)
        {
            ClearGoodsTxb();
        }

        private void AddNextGoods_Click(object sender, EventArgs e)
        {
            string Name = GoodsNameTxb.Text.Trim();
            int stock = (int)GoodsNumNud.Value;
            string Category = GoodsCategoriesCbb.Text.Trim();
            if (!decimal.TryParse(GoodsPriceTxb.Text.Trim(), out decimal price))
            {
                MessageBox.Show("请输入合理的价格");
                return;
            }
            lock (GolbalData.GoodsRoot)
            {
                for (int i = 0; i < stock; i++)
                {
                    Goods goods = new Goods(Guid.NewGuid().ToString("N"), Name, price, Category);
                    GolbalData.GoodsRoot.goods.Add(goods);
                }
            }
            GolbalData.SaveAndBroadcastGoods(AppConfig.Instance.GoodsJsonPath);
            ClearGoodsTxb();
        }

        private void GetLastStep_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddNewGoodsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
