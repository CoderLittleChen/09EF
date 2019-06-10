using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Fluent_API_in__Code_First.实体类
{
    public class Student
    {
        //EF中默认会将带有ID Id的字段设置为主键，若想明确指定，可以用[Key]属性
        public int StudentKey { get; set; }
        public string StuName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        //自定义外键，也可以通过Fluent Api来配置外键
        //[ForeignKey("Standard")]
        public int For_StandardId { get; set; }
        public Standard Standard { get; set; }
    }
}
