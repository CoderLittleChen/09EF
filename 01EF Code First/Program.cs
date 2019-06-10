using _01EF_Code_First.多对多关系;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01EF_Code_First
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var c = new SchoolContext())
            {
                //这里赋值  两个表之间的引用属性  导航属性  不用赋值   只是用来表示两表之间的关系是一对多
                Standard sta = new Standard() { StandardId = 11, StandardName = "cmm" };
                c.Standards.Add(sta);

                Student stu = new Student() { StudnetID1 = 1, StudentID2 = 2, StudentID3 = 3, StudentName = "cm", Height = 172, Weight = 120, DateOfBirth = DateTime.Now, };
                c.Students.Add(stu);

                Trip trip = new Trip() { TripId = 1, StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(2), CostUSD = 2.30M };
                c.Trips.Add(trip);

                Activity activity = new Activity() { ActivityId = 1, Name = "旅游" };
                c.Activities.Add(activity);

                c.SaveChanges();
            }
            Console.WriteLine("OK");
            Console.ReadKey();
        }
    }
}
