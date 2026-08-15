using System;
using System.Collections.Generic;
using System.Text;

namespace 使用Winform和Json实现可长期使用的超市管理系统
{
    /// <summary>
    /// 表示一笔销售订单及其包含的商品明细
    /// </summary>
    public class Salesroot
    {
        public int NextOrderName { get; set; } = 1;
        public List<Sales> Sales { get; set; } = new List<Sales>();
    }

    public class Sales
    {
        public int OrderId { get; set; } 
        public DateTime SaleTime {  get; set; }
        public decimal Price { get; set; }

        public List<SalesItem> Items { get; set; } = new List<SalesItem>();
    }
    
    public class SalesItem
    {
        public  string GoodsId {  get; set; }
        public string GoodsName { get; set; }
        public decimal UnitPrice {  get; set; }

    }
}
