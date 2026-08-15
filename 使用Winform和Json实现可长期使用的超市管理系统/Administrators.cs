using System;
using System.Collections.Generic;
using System.Text;

namespace 使用Winform和Json实现可长期使用的超市管理系统
{
    /// <summary>
    /// 管理员的类，还有一个管理员的集合
    /// </summary>
    public class Administrators
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        
        public Administrators(string id,string name,string password)
        {
            this.Id = id;
            this.Name = name;
            this.Password = password;
        }
    }
    public class AdminRoot
    {
        public List<Administrators> ads = new List<Administrators>();
        
    }
}
