using System;
using System.Collections.Generic;
using System.Text;

namespace 使用Winform和Json实现可长期使用的超市管理系统
{
    /// <summary>
    /// 管理员模式会用到的类，用来展示对应商品的余量，重要的是通过这些窗体来绘制GoodsCard辅助管理员快速添加货物
    /// </summary>
    public class NowGoodsNum
    {
        public string GoodsName { get; set; }
        public decimal Price { get; set; }
        public int NowGount { get; set; }
    }
}
