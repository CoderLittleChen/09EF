using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04RedisDemo
{
    public class RedisHelper
    {
        #region 注释
        //new一个redis客户端对象
        //private static RedisClient redisCli = null;
        //public void Dispose()
        //{
        //    redisCli.Dispose();
        //}
        //5种数据类型     String List Hash（键值对） Set  SortSet
        //public static void CreateClient(string hostIP, int port, string password)
        //{
        //    if (redisCli != null)
        //    {
        //        redisCli = new RedisClient(hostIP, port, password);
        //    }
        //}

        //public static void CreateClient(string hostIP, int port)
        //{
        //    if (redisCli != null)
        //    {
        //        redisCli = new RedisClient(hostIP, port);
        //    }
        //} 
        #endregion

        private static readonly PooledRedisClientManager pool = null;
        private static readonly string[] writeHosts = null;
        private static readonly string[] readHosts = null;
        //public static int RedisMaxReadPool = configurationmanager;

    }
}
