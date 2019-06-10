using _02Fluent_API_in__Code_First.上下文;
using _02Fluent_API_in__Code_First.实体类;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Fluent_API_in__Code_First
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var c = new SchoolContext())
            {
                Standard sta = new Standard() { StandardKey = 2, StandardName = "标准" };
                c.Standards.Add(sta);

                Student stu = new Student() { StudentKey = 1, StuName = "张三", Age = 10, Email = "adsa", For_StandardId = sta.StandardKey };
                c.Students.Add(stu);

                c.SaveChanges();
            }
            Console.WriteLine("OK");
            Console.ReadKey();
        }
    }
}
