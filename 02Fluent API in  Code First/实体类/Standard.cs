using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Fluent_API_in__Code_First.实体类
{
    public class Standard
    {
        public int StandardKey { get; set; }
        public string StandardName { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
