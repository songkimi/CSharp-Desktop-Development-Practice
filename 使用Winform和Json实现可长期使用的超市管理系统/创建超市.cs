using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace 使用Winform和Json实现可长期使用的超市管理系统
{
    public partial class 创建超市 : Form
    {
        /// <summary>
        /// 当检测到用户没一个能用的超市存档的时候这个窗体会被打开，作为向导帮助用户新建一个自己的超市，当然，通过Form1创建窗体也是来到这里
        /// </summary>
        public AdminRoot adminRoot = new AdminRoot();
        public GoodsRoot goodsRoot = new GoodsRoot();
        public bool _isCreateFinished = false;
        SupermarketGlobalConfig globalConfig = DataStorage.LoadlobalConfig(AppConfig.Instance.ClobalConfigFilePath);

        public string OutputStoreFolder { get; private set; } = string.Empty;
        string storesRoot = null;
        public 创建超市()
        {
            InitializeComponent();
        }
        private void 创建超市_Load(object sender, EventArgs e)
        {
            string str = Application.StartupPath;
            storesRoot = Path.Combine(str, "stores");
            if (!Directory.Exists(storesRoot))
            {
                Directory.CreateDirectory(storesRoot);
            }
            NewAdmins.Visible = true;
            AddGoods.Visible = false;

        }
        //NewAdmins
        private void button1_Click(object sender, EventArgs e)
        {
            ClearAdmText();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Name = NameTxb.Text.Trim();
            string Id = IdTxb.Text.Trim();
            string Password = PasswordTxb.Text.Trim();
            string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])[A-Za-z0-9]{9,16}$";
            if (Name == string.Empty || Id == string.Empty || Password == string.Empty)
            {
                TapLable.Text = "请输入完整的管理员信息";
                return;
            }
            bool isExist = adminRoot.ads.Any(a => a.Id == Id);
            if (isExist)
            {
                TapLable.Text = "该管理员账号ID已存在!";
                return;
            }
            if (!Regex.IsMatch(Password, pattern))
            {
                TapLable.Text = "密码需要9-16个字符，必须包含大小写，数字";
                return;
            }

            Administrators administrators = new Administrators(Id, Name, Password);
            adminRoot.ads.Add(administrators);
            ClearAdmText();

        }

        private void NextStepBtn_Click(object sender, EventArgs e)
        {
            if (adminRoot.ads.Count == 0)
            {
                MessageBox.Show("请先添加管理员");
                return;
            }


            FolderBrowserDialog folderDig = new FolderBrowserDialog();
            folderDig.SelectedPath = storesRoot;
            folderDig.Description = "请选择新建超市的数据存放文件夹";
            if (folderDig.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            this.OutputStoreFolder = folderDig.SelectedPath;
            if (Path.GetFullPath(OutputStoreFolder) == Path.GetFullPath(storesRoot))
            {
                MessageBox.Show("请在stores文件夹内部创建子文件夹作为超市存档，请不要直接选择stores！");
                OutputStoreFolder = string.Empty;
                return;
            }
            if (!Directory.Exists(OutputStoreFolder))
            {
                Directory.CreateDirectory(OutputStoreFolder);
            }
            string adminFile = Path.Combine(OutputStoreFolder, "Administrators.json");
            try
            {
                DataStorage.Save(adminFile, adminRoot.ads);
                NewAdmins.Visible = false;
                AddGoods.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"发生了错误：{ex.Message}");
            }

        }
        public void ClearAdmText()
        {
            IdTxb.Text = string.Empty;
            NameTxb.Text = string.Empty;
            PasswordTxb.Text = string.Empty;
        }

        private void DbtAll_Click(object sender, EventArgs e)
        {
            if (adminRoot.ads.Count == 0)
            {
                MessageBox.Show("您还没有存入任何管理员信息");
                return;
            }
            DialogResult res = MessageBox.Show("真的要删除已经存入的管理员吗？", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                adminRoot.ads.Clear();
            }
            else
            {
                return;
            }
        }

        private void ClearTxb_Click(object sender, EventArgs e)
        {
            ClearGoodsTxb();
        }

        private void DelAllGoods_Click(object sender, EventArgs e)
        {
            if (adminRoot.ads.Count == 0)
            {
                MessageBox.Show("您的超市不存在商品");
                return;
            }
            goodsRoot.goods.Clear();
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
            for (int i = 0; i < stock; i++)
            {
                Goods goods = new Goods(Guid.NewGuid().ToString("N"), Name, price, Category);
                goodsRoot.goods.Add(goods);
            }
            ClearGoodsTxb();
        }
        public Salesroot salesroot = new Salesroot();
        private void GetLastStep_Click(object sender, EventArgs e)
        {
            if (goodsRoot.goods.Count == 0)
            {
                MessageBox.Show("开店最少需要一种商品");
                return;
            }
            ;
            try
            {

                string goodsPath = Path.Combine(OutputStoreFolder, "Goods.json");
                string salesPath = Path.Combine(OutputStoreFolder, "Sales.json");
                DataStorage.Save(goodsPath, goodsRoot.goods);
                DataStorage.Save(salesPath, salesroot);
                _isCreateFinished = true;
                string selectedFolder = this.OutputStoreFolder;
                globalConfig.LastsavePath = selectedFolder;//保存全局配置的路径
                AppConfig.Instance.CurrentStoreFolder = selectedFolder;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"发生了错误：{ex.Message}");
            }
            ClearGoodsTxb();
        }

        public void ClearGoodsTxb()
        {
            GoodsNameTxb.Text = string.Empty;
            GoodsNumNud.Value = 100;
            GoodsCategoriesCbb.SelectedIndex = -1;
            GoodsPriceTxb.Text = string.Empty;
        }

        private void PerviousStep_Click(object sender, EventArgs e)
        {
            NewAdmins.Visible = true;
            AddGoods.Visible = false;
        }

        private void 创建超市_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isCreateFinished)
            {
                if (Directory.Exists(OutputStoreFolder))
                {
                    try
                    {
                        Directory.Delete(OutputStoreFolder, true);
                    }
                    catch
                    {

                    }
                }
            }
        }
    }
}
