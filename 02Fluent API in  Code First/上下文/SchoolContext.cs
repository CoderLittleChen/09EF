using _02Fluent_API_in__Code_First.实体类;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Fluent_API_in__Code_First.上下文
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("conStr")
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Standard> Standards { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //这里是配置数据库中的表名前缀，数据库名字在连接字符串中已经设置好
            modelBuilder.HasDefaultSchema("Fluent Api");

            //将实体类映射成数据表，参数分别是表名和表名前缀
            //modelBuilder.Entity<Student>().ToTable("Cm_Student", "Demo");
            //modelBuilder.Entity<Standard>().ToTable("Cm_Standard", "Demo");

            //手动配置主键或者复合主键
            modelBuilder.Entity<Student>().HasKey(m => m.StudentKey);
            modelBuilder.Entity<Standard>().HasKey(m => m.StandardKey);

            //配置列名  列顺序  列类型，注意这里的ColumnType指的是数据库中对应的字段类型
            modelBuilder.Entity<Student>().Property(m => m.StuName).HasColumnName("StudentName").HasColumnOrder(20).HasColumnType("nvarchar")
                .HasMaxLength(20);
            //IsRequired  映射的数据库对应字段不为Null   IsOptional表示对应的数据库字段可为Null
            modelBuilder.Entity<Standard>().Property(m => m.StandardName).IsRequired();

            //配置一对多关系+设置外键  其中Student和Standard表是一对多关系
            modelBuilder.Entity<Student>().HasRequired(m => m.Standard).WithMany(m => m.Students).HasForeignKey(m => m.For_StandardId);

            #region 将一个实体类映射成两个表
            //将一个实体映射成多个表，这里注意如果两个字表中都不包含Student表中的某个字段，比如自定义的外键
            //那么矿建将会自动创建一个表Student11，里面包含Student主键字段+被遗漏的字段
            //modelBuilder.Entity<Student>().Map( 
            //    m =>
            //    {
            //        m.Properties(p => p.StudentId);
            //        m.Properties(p => p.StuName);
            //        m.Properties(p => p.For_StandardId);
            //        m.ToTable("StudentInfo");
            //    }).Map(
            //    m =>
            //    {
            //        m.Properties(p => p.StudentId);
            //        m.Properties(p => p.Age);
            //        m.Properties(p => p.Email);
            //        m.ToTable("StudentDetails");
            //    });
            //modelBuilder.Entity<Standard>().ToTable("StandardInfo"); 
            #endregion

            //在这里面配置领域类
            base.OnModelCreating(modelBuilder);
        }
    }
}
