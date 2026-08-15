using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace 使用Winform和Json实现可长期使用的超市管理系统
{
    /// <summary>
    /// 提供通用的 JSON 序列化/反序列化功能，负责所有数据文件的读写操作。
    /// 针对 <see cref="Salesroot"/> 提供了独立的重载，因为其结构为嵌套集合。
    /// </summary>
    public static class DataStorage
    {
        private static readonly JsonSerializerOptions JsonOpt = new JsonSerializerOptions {WriteIndented = true};// 格式化 JSON，便于人工查看和版本对比
        // --------- 保存功能 --------- //

        /// <summary>
        /// 将泛型列表序列化为 JSON 并保存到指定文件。
        /// </summary>
        /// <typeparam name="T">列表中元素的类型（如 <see cref="Goods"/>、<see cref="Administrators"/>）。</typeparam>
        /// <param name="Path">目标文件的完整物理路径（包含文件名和扩展名）。</param>
        /// <param name="values">要保存的列表实例。</param>
        /// <exception cref="IOException">当文件被占用或磁盘空间不足时抛出。</exception>
        /// <exception cref="UnauthorizedAccessException">当程序对目标路径没有写入权限时抛出。</exception>
        /// <exception cref="JsonException">当序列化过程中遇到循环引用或不支持的类型时抛出。</exception>
        public static void Save<T>(string Path,List<T> values)
        {

            try
            {

                string Json = JsonSerializer.Serialize(values, JsonOpt);
                File.WriteAllText(Path, Json);
            }
            catch (Exception ex)
            {
                throw ex;//throw会将ex返回给调用方法的地方
            }

        }
        /// <summary>
        /// 将 <see cref="Salesroot"/> 对象序列化为 JSON 并保存到指定文件。
        /// 此重载用于处理包含嵌套集合（订单项）的特殊结构。
        /// </summary>
        /// <param name="Path">目标文件的完整物理路径。</param>
        /// <param name="sales">要保存的 <see cref="Salesroot"/> 实例。</param>
        /// <exception cref="IOException">当文件被占用或磁盘空间不足时抛出。</exception>
        /// <exception cref="UnauthorizedAccessException">当程序没有写入权限时抛出。</exception>
        /// <exception cref="JsonException">当序列化过程中出现错误时抛出。</exception>
        public static void Save(string Path, Salesroot sales)
        {
            try
            {

                string Json = JsonSerializer.Serialize(sales, JsonOpt);
                File.WriteAllText(Path, Json);
            }
            catch (Exception ex)
            {
                throw ex;//throw会将ex返回给调用方法的地方
            }
        }
        // --------- 载入功能 --------- //

        /// <summary>
        /// 从 JSON 文件反序列化一个泛型列表。
        /// </summary>
        /// <typeparam name="T">列表元素的类型（如 <see cref="Goods"/>、<see cref="Administrators"/>）。</typeparam>
        /// <param name="filePath">要读取的 JSON 文件的完整物理路径。</param>
        /// <returns>
        /// 如果文件存在且内容有效，返回反序列化后的列表；
        /// 如果文件不存在，返回一个新的空列表（不会抛出异常）；
        /// 如果反序列化结果为 null，也返回空列表。
        /// </returns>
        /// <remarks>
        /// 此方法不会因文件不存在而抛出异常，而是返回空列表，便于调用方简化判空逻辑。
        /// </remarks>
        public static List<T> Load<T>(string filePath)
        {
            if (!File.Exists(filePath))
            {
                //文件不存在，返回空集合
                return new List<T>();
            }
            string jsonText = File.ReadAllText(filePath);
            List<T>? result = JsonSerializer.Deserialize<List<T>>(jsonText,JsonOpt);
            //反序列得到null时返回空集合
            return result ?? new List<T>();
        }
        /// <summary>
        /// 从 JSON 文件反序列化 <see cref="Salesroot"/> 对象。
        /// 此重载专门用于包含嵌套订单数据的结构。
        /// </summary>
        /// <param name="Path">要读取的 JSON 文件的完整物理路径。</param>
        /// <returns>
        /// 如果文件存在且内容有效，返回反序列化后的 <see cref="Salesroot"/>；
        /// 如果文件不存在，返回一个新的 <see cref="Salesroot"/> 实例（不会抛出异常）；
        /// 如果反序列化结果为 null，也返回新实例。
        /// </returns>
        public static Salesroot Load(string Path)
        {
            if (!File.Exists(Path))
            {
                return new Salesroot();
            }
            string Json = File.ReadAllText(Path);
            Salesroot salesroot = JsonSerializer.Deserialize<Salesroot>(Json);
            return salesroot ?? new Salesroot();
        }



        // --------- 全局配置 --------- //

        /// <summary>
        /// 从指定路径加载全局配置文件（<see cref="SupermarketGlobalConfig"/>）。
        /// </summary>
        /// <param name="CongigPath">全局配置文件的完整物理路径。</param>
        /// <returns>
        /// 如果文件存在且有效，返回反序列化后的配置对象；
        /// 如果文件不存在，返回一个全新的 <see cref="SupermarketGlobalConfig"/> 实例（不会抛出异常）。
        /// </returns>
        /// <remarks>
        /// 此方法用于读取记录“最近使用的超市存档路径”的全局配置。
        /// </remarks>
        public static SupermarketGlobalConfig LoadlobalConfig(string CongigPath)
        {
            if (!File.Exists(CongigPath))
            {
                //文件不存在，返回全新空配置
                return new SupermarketGlobalConfig();
            }
            string jsonText = File.ReadAllText(CongigPath);
            return JsonSerializer.Deserialize<SupermarketGlobalConfig>(jsonText)!;
        }
        /// <summary>
        /// 将全局配置对象序列化并保存到指定文件。
        /// </summary>
        /// <param name="ConfigPath">目标文件的完整物理路径。</param>
        /// <param name="config">要保存的 <see cref="SupermarketGlobalConfig"/> 实例。</param>
        /// <exception cref="IOException">当文件写入失败时抛出。</exception>
        public static void SavelabalConfig(string ConfigPath, SupermarketGlobalConfig config)
        {
            string jsonText = JsonSerializer.Serialize(config, JsonOpt);
            File.WriteAllText(ConfigPath, jsonText);
        }

    }
}
