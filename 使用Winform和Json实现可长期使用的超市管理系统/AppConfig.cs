using System;
using System.Collections.Generic;
using System.Text;

namespace 使用Winform和Json实现可长期使用的超市管理系统
{
    /// <summary>
    /// 全局配置管理类（单例模式）。负责提供,计算所有数据文件的 JSON 路径，
    /// 以及校验指定文件夹是否包含完整的超市存档（Administrators.json, Goods.json, Sales.json）。
    /// </summary>
    public class AppConfig
    {
        
        public static AppConfig Instance { get; } = new AppConfig();//单例模式
        public string ClobalConfigFilePath { get; set; } = string.Empty;//全局配置文件
        public string StoresRootFolder {  get; set; } = string.Empty;//所有超市存放的总文件夹
        public string CurrentStoreFolder {  get; set; } = string.Empty;//【内存变量，不存json】当前正在使用的超市文件夹

        public string AdminJsonPath => Path.Combine(CurrentStoreFolder, "Administrators.json");
        
        public string GoodsJsonPath => Path.Combine(CurrentStoreFolder, "Goods.json");

        public string SalesJsonPath => Path.Combine(CurrentStoreFolder, "Sales.json");

        public AppConfig()
        {
            //尝试计算路径
            string appBase = Application.StartupPath;
            ClobalConfigFilePath = Path.Combine(appBase, "Supermarket_global.json");
            StoresRootFolder = Path.Combine(appBase, "stores");
            if (!Directory.Exists(StoresRootFolder))
            {
                Directory.CreateDirectory(StoresRootFolder);
            }
        }
        //判断文件夹是否合理(1个重载)
        public bool CheckJsonComplete(SupermarketGlobalConfig config)
        {
            if (string.IsNullOrEmpty(config.LastsavePath))
            {
                return false;
            }
            string storeFolder = config.LastsavePath;
            if (!Directory.Exists(storeFolder))
            {
                return false;
            }
            List<string> requiredFiles = new List<string>()
            {
                "Administrators.json","Goods.json","Sales.json"
            };
            foreach (string file in requiredFiles)
            {
                string FillPath = Path.Combine(CurrentStoreFolder, file);
                if (!File.Exists(FillPath))
                {
                    return false;
                }
            }
            return true;
        }
        public bool CheckJsonComplete(string config)
        {
            if (string.IsNullOrEmpty(config))
            {
                return false;
            }
            string storeFolder = config;
            if (!Directory.Exists(storeFolder))
            {
                return false;
            }
            List<string> requiredFiles = new List<string>()
            {
                "Administrators.json","Goods.json","Sales.json"
            };
            foreach (string file in requiredFiles)
            {
                string FillPath = Path.Combine(CurrentStoreFolder, file);
                if (!File.Exists(FillPath))
                {
                    return false;
                }
            }
            return true;
        }
        //得到用户的超市名字
        public static string GetLastStoreName(string storeName)
        {
            if (string.IsNullOrEmpty(storeName)) return "";
            //去除末尾多余\/
            string trimPath = storeName.TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);
            return Path.GetFileName(trimPath);
            
        }
    }
    public class SupermarketGlobalConfig
    {
        public string LastsavePath {  get; set; } = string.Empty;
        
        public SupermarketGlobalConfig()
        {

        }
    }
}
