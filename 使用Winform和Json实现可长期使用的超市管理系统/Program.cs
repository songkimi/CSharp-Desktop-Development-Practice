namespace 使用Winform和Json实现可长期使用的超市管理系统
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ///本练习虽然也是超市管理系统，但是侧重点不同，不再像控制台一样只使用1个json文件保存全部内容增加风险，而是采用了多json联合的机制减少了文件损坏的可能
            ///同时，不再使用嵌套集合而是将所有商品放在一个集合中，这是因为json自带的对这类集合储存的缺陷，同时，由于Linq非常方便，加上使用委托机制，管理员能及时知道快要买完的商品
            ///我们希望管理员在知道商品快没有的时候自主存货，所以尝试加入一个简单的事件广播。同时，不在像老项目一样时刻提防着没有任何对象的LIst集合会卡崩项目！
            ///同时取消了自定义折扣功能，这套功能本质是训练简单工厂模式，但由于json的特殊性，在这里实现这个功能会非常麻烦，以后尝试使用数据库的时候可以尝试，虽然我不可能再写超市管理系统了
            ///写了3次快吐了其实，但也不可否认我每次写都能学到不少东西
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //读取全局配置
            SupermarketGlobalConfig globalConfig = DataStorage.LoadlobalConfig(AppConfig.Instance.ClobalConfigFilePath);
            bool haveValidStore = false;
            if (!string.IsNullOrEmpty(globalConfig.LastsavePath))
            {
                AppConfig.Instance.CurrentStoreFolder = globalConfig.LastsavePath;
                if (AppConfig.Instance.CheckJsonComplete(globalConfig))
                {
                    //存在，使用这个超市
                    
                    haveValidStore = true;
                }
            }
            //没有有效的超市文件夹，弹出向导窗体
            if (haveValidStore == false)
            {
                创建超市 form = new 创建超市();
                if (form.ShowDialog() != DialogResult.OK)
                {
                    Application.Exit();
                    return;
                }
                //向导完成，拿到用户选/新建的超市文件夹
                string selectedFolder = form.OutputStoreFolder;
                globalConfig.LastsavePath = selectedFolder;//保存全局配置的路径
                AppConfig.Instance.CurrentStoreFolder = selectedFolder;
                DataStorage.SavelabalConfig(AppConfig.Instance.ClobalConfigFilePath, globalConfig);

            }
            GolbalData.InitGoods();
            GolbalData.Salesroot = DataStorage.Load(AppConfig.Instance.SalesJsonPath)?? new Salesroot();
            Application.Run(new Form1());
        }
    }
}