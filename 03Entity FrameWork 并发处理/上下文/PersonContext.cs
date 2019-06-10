using _03Entity_FrameWork_并发处理.实体类;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Entity_FrameWork_并发处理.上下文
{
    public class PersonContext : DbContext
    {
        public PersonContext() : base("conStr")
        {

        }
        public DbSet<Person> Persons { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //配置Timestemp属性字段  在Fluent Api中IsRowVersion方法等同于数据注解中的[Timestemp]特性
            //可以用来表示表中某行字段是否被新增或者修改
            modelBuilder.Entity<Person>().Property(m => m.RowVersion).IsRowVersion();
            base.OnModelCreating(modelBuilder); 
        }
    }
}
