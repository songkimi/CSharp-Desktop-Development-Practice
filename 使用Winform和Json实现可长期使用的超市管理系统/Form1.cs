using System.DirectoryServices.ActiveDirectory;
using System.Runtime.CompilerServices;

namespace 使用Winform和Json实现可长期使用的超市管理系统
{
    /// <summary>
    /// Form1又叫做登录界面，主要目的是帮助管理员登录账号，改变存档，创建存档，打开管理员模式以及顾客打开顾客模式，Form1窗体只能存在一个
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string SupermarketName { get; set; } = string.Empty;
        string newSupermarketName { get; set; } = string.Empty;
        SupermarketGlobalConfig superconfig;
        List<Administrators>? admins;

        private void RefreshStoreInfo()
        {
            //更新UI信息
            SupermarketName = AppConfig.Instance.CurrentStoreFolder;
            string SN = AppConfig.GetLastStoreName(SupermarketName);
            SupermarketNameLable.Text = "当前超市存档：" + SN;


        }
        private void CustomerBtn_Click(object sender, EventArgs e)
        {
            CustomerMode customerMode = new CustomerMode();
            customerMode.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            superconfig = DataStorage.LoadlobalConfig(AppConfig.Instance.ClobalConfigFilePath);
            RefreshStoreInfo();
            SelectIdpan.Visible = true;
            AdminLoginpen.Visible = false;

        }

        private void ChangeSaveBtn_Click(object sender, EventArgs e)
        {
            bool hasWorkingForm = Application.OpenForms.Cast<Form>().Any(f => f is AdminSetting || f is CustomerMode);
            if (hasWorkingForm)
            {
                MessageBox.Show("当前尚有顾客，管理员正在操作，请确认全部人员完成任务后进行此操作！");
                return;
            }
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.SelectedPath = AppConfig.Instance.StoresRootFolder;//默认选择的文件夹
            FBD.Description = "请选择你的超市存档";
            if (FBD.ShowDialog() == DialogResult.OK)
            {

                string selectPath = FBD.SelectedPath;
                bool isValid = AppConfig.Instance.CheckJsonComplete(selectPath);
                if (!isValid)
                {
                    MessageBox.Show("请选择资源完整的文件夹");
                    return;
                }
                newSupermarketName = selectPath;
                RefreshStoreInfo();
                superconfig = DataStorage.LoadlobalConfig(AppConfig.Instance.ClobalConfigFilePath);
                superconfig.LastsavePath = newSupermarketName;
                AppConfig.Instance.CurrentStoreFolder = newSupermarketName;
                DataStorage.SavelabalConfig(AppConfig.Instance.ClobalConfigFilePath, superconfig);
                selectPath = string.Empty;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool hasWorkingForm = Application.OpenForms.Cast<Form>().Any(f => f is AdminSetting || f is CustomerMode);
            if (hasWorkingForm)
            {
                MessageBox.Show("当前尚有顾客，管理员正在操作，请确认全部人员完成任务后进行此操作！");
                return;
            }
            创建超市 frm = new 创建超市();
            if (frm.ShowDialog() == DialogResult.OK)
            {

                frm.ShowDialog();
                superconfig = DataStorage.LoadlobalConfig(AppConfig.Instance.ClobalConfigFilePath);
                SupermarketName = superconfig.LastsavePath;
                AppConfig.Instance.CurrentStoreFolder = SupermarketName;
                RefreshStoreInfo();
            }

        }

        private void Adminbtn_Click(object sender, EventArgs e)
        {
            try
            {
                SelectIdpan.Visible = false;
                AdminLoginpen.Visible = true;
                admins = DataStorage.Load<Administrators>(AppConfig.Instance.AdminJsonPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"发生了错误：{ex.Message}");
            }
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            string ID = txbID.Text;
            string password = txbPassword.Text;
            if (string.IsNullOrWhiteSpace(ID) || string.IsNullOrWhiteSpace(password))
            {
                lableTip.Text = "请填入完整信息";
                return;
            }
            Administrators admin = admins.FirstOrDefault(a => a.Id == ID);
            if (admin == null || admin.Password != password)
            {
                lableTip.Text = "账号或密码错误";
                return;
            }
            AdminSetting AS = new AdminSetting();
            AS.thisadmin = admin;
            AS.Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Cleartxb();
            SelectIdpan.Visible = true;
            AdminLoginpen.Visible = false;
        }
        private void Cleartxb()
        {
            txbID.Text = string.Empty;
            txbPassword.Text = string.Empty;
        }
    }
}
