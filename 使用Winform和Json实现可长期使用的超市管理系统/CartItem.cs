using System;
using System.Collections.Generic;
using System.Text;

namespace 使用Winform和Json实现可长期使用的超市管理系统
{
    /// <summary>
    ///  这个是用来表示顾客购买各类数量的数量的,可以转换其中的数据用来绘制资料卡片，也能用来简化显示账单的表格
    /// </summary>
    public class CartItem
    {
        public string GoodsName { get; set; }
        public decimal Price { get; set; }
        public int BuyCount { get; set; }

        
    }
    
}
