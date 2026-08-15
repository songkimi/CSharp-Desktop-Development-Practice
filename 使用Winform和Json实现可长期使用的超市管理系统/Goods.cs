using System;
using System.Collections.Generic;
using System.Text;

namespace 使用Winform和Json实现可长期使用的超市管理系统
{
    /// <summary>
    /// 创建了一个商品集合，只有创建新存档的时候才需要用上
    /// </summary>
    public class GoodsRoot
    {
        public List<Goods> goods = new List<Goods>();
    }

    public class Goods
    {
        public string GoodsId { get; set; }
        public string GoodsName { get; set; }
        public decimal Price { get; set; }
        public string Category {  get; set; }
        
        public Goods(string goodsid, string goodsname, decimal price, string category)
        {
            this.GoodsId = goodsid;
            this.GoodsName = goodsname;
            this.Price = price;
            this.Category = category;
        }
    }
}
