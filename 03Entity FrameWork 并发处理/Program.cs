using _03Entity_FrameWork_并发处理.上下文;
using _03Entity_FrameWork_并发处理.实体类;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Entity_FrameWork_并发处理
{
    class Program
    {
        static void Main(string[] args)
        {
            //新增一条记录保存在数据库中
            Person person = new Person() { PersonId = 1, FirstName = "张", LastName = "三", SocialSecurityNumber = 213 };
            using (var s = new PersonContext())
            {
                s.Persons.Add(person);
                s.SaveChanges();
            }
            //取第一条记录，并修改一个字段的值，暂时不保存
            var c = new PersonContext();
            var p1 = c.Persons.FirstOrDefault();
            p1.FirstName = "李";
            //在创建一个Context，同样取第一条记录，修改字段并保存
            using (var cc = new PersonContext())
            {
                var p2 = cc.Persons.FirstOrDefault();
                p2.FirstName = "王";
                cc.SaveChanges();
            }
            try
            {
                c.SaveChanges();
                Console.WriteLine("保存成功");
            }
            catch (DbUpdateConcurrencyException ex)
            {
                Console.WriteLine(ex.Entries.First().Entity.GetType().Name+"保存失败");
            }
            Console.ReadKey();

        }
    }
}
