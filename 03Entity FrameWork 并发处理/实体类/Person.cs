using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Entity_FrameWork_并发处理.实体类
{
    public class Person
    {
        public int PersonId { get; set; }
        public int SocialSecurityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
