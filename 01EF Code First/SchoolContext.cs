using _01EF_Code_First.多对多关系;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01EF_Code_First
{
    public class SchoolContext : DbContext
    {
        //这里有三种情况
        //1、无参数  不设置数据库连接字符串，默认生成的数据库名字为 【命名控件+Context类名】
        //2、传一个数据库连接字符串   会根据连接字符串生成指定数据库
        //3、传一个字符串，指定生成的数据库名字
        public SchoolContext() : base("Student")
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Standard> Standards { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<Activity> Activities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //在该方法内部配置领域类
            base.OnModelCreating(modelBuilder);
        }


    }
}
