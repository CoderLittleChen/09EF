using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _04RedisDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 5种数据类型读写练习
            ////这里注意项目运行先要打开Redis服务
            //RedisClient redisCli = new RedisClient("127.0.0.1", 6379);
            ////添加String类型的数据
            ////redisCli.Set("location", "Just Test");
            ////string location = Encoding.Default.GetString(redisCli.Get("location"));
            ////Console.WriteLine(location);

            ////测试String字符串
            ////redisCli.Set("str", "HelloWord");
            ////byte[] buffer = redisCli.Get("str");
            ////string value = Encoding.Default.GetString(buffer);
            ////Console.WriteLine(value);

            ////测试Hash类型（存储单个对象，可以记载一个完成的实体的信息）   键值对
            ////设置Hash值
            ////redisCli.SetEntryInHash("1", "user", "cm");
            ////redisCli.SetEntryInHash("2", "user", "mc");
            ////redisCli.SetEntryInHash("1", "test", "demo");
            //////long count = redisCli.GetHashCount("1");
            ////List<string> listKeys = redisCli.GetHashKeys("1");
            ////List<string> listValues = redisCli.GetHashValues("1");
            ////for (int i = 0; i < listValues.Count; i++)
            ////{
            ////    Console.Write(listValues[i]+"  ");
            ////}
            ////Console.WriteLine(listKeys.Count);


            ////测试list类型
            //redisCli.AddItemToList("1", "cm");
            ////这个方法的参数  listIndex是怎么来的？
            //Console.WriteLine(redisCli.GetItemFromList("1", 0));

            ////ThreadPool.QueueUserWorkItem

            //Console.ReadKey(); 


            string idCard = "142202199610140316";
            string birthday = idCard.Substring(6, 8);
            //这里的ToDateTime函数  要求参数有格式限制
            //DateTime dateTime = Convert.ToDateTime(birthday);


            DateTime dateTime = DateTime.ParseExact(birthday,"yyyyMMdd",System.Globalization.CultureInfo.CurrentCulture);
            Console.WriteLine(dateTime.ToLongDateString());
            Console.ReadKey();

            #endregion

        }
    }
}
