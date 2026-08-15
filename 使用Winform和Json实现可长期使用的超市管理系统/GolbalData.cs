using System;
using System.Collections.Generic;
using System.Text;

namespace 使用Winform和Json实现可长期使用的超市管理系统
{
    /// <summary>
    /// 全局数据容器和事件管理器（单例模式）。
    /// 负责维护程序运行期间唯一的 <see cref="GoodsRoot"/> 和 <see cref="Salesroot"/> 实例，
    /// 并提供“保存后广播”机制，使所有订阅了 <see cref="GoodsDataChanged"/> 事件的窗体自动刷新 UI。
    /// </summary>
    internal static class GolbalData
    {
        /// <summary>
        /// 商品数据变更事件（观察者模式）。
        /// 任何对 <see cref="GoodsRoot"/> 的修改（增删改）都应调用 <see cref="SaveAndBroadcastGoods"/> 来触发此事件。
        /// 订阅此事件的窗体（如 <see cref="AdminSetting"/>、<see cref="CustomerMode"/>）应在其 Load 事件中订阅，
        /// 并在 FormClosing 或 FormClosed 中取消订阅，避免内存泄漏。
        /// </summary>
        public static event Action GoodsDataChanged;

        /// <summary>
        /// 全局唯一的商品根容器。所有对商品的访问必须通过此属性。
        /// </summary>
        public static GoodsRoot GoodsRoot {  get; set; }
        /// <summary>
        /// 全局唯一的销售记录根容器。所有订单数据均存储于此。
        /// </summary>
        public static Salesroot Salesroot { get; set; }

        /// <summary>
        /// 在程序启动时调用一次，从 JSON 文件加载商品数据到内存。
        /// 如果商品 JSON 文件不存在，则初始化为空列表。
        /// </summary>
        /// <remarks>
        /// 此方法应在 <see cref="Program.Main"/> 中调用，确保所有窗体启动时数据已就绪。
        /// </remarks>
        public static void InitGoods()
        {
            GoodsRoot = new GoodsRoot();
                //尝试加载json,不存在返回空集合
            var list = GoodsRoot.goods = DataStorage.Load<Goods>(AppConfig.Instance.GoodsJsonPath);
            GoodsRoot.goods = list ?? new List<Goods>();
        }
        /// <summary>
        /// 将当前内存中的商品数据持久化到 JSON 文件，并触发 <see cref="GoodsDataChanged"/> 事件，通知所有订阅者更新 UI。
        /// </summary>
        /// <param name="FilePath">商品数据 JSON 文件的完整路径（通常来自 <see cref="AppConfig.GoodsJsonPath"/>）。</param>
        /// <remarks>
        /// 此方法是“保存即广播”的核心，任何对商品的修改都应通过此方法保存，以保持 UI 同步。
        /// </remarks>
        /// <exception cref="Exception">当序列化或磁盘写入失败时，会向上抛出异常。</exception>
        public static void SaveAndBroadcastGoods(string FilePath)
        {
            //写入磁盘json
            DataStorage.Save(FilePath, GoodsRoot.goods);
            //触发广播
            GoodsDataChanged?.Invoke();
        }
    }
}
