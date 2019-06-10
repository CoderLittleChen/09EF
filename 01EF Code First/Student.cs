using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01EF_Code_First
{
    //这里设置表名
    [Table("StudentInfo")]
    public class Student
    {
        public Student()
        {
        }
        //[key]表示主键，复合主键需要加上Column(Order=1)特性
        //这里注意：单个主键 EF Code First创建的是自动增长的，复合主键不是
        [Key]
        [Column(Order = 1)]
        public int StudnetID1 { get; set; }
        [Key]
        [Column(Order = 2)]
        public int StudentID2 { get; set; }
        [Key]
        [Column(Order = 3)]
        public int StudentID3 { get; set; }


        [Column("Name", TypeName = "nvarchar")]
        //这里当MaxLength和StringLength同时存在的时候，映射的字段显示的MaxLength
        [MaxLength(200)]
        [StringLength(30)]
        public string StudentName { get; set; }

        //表示不映射,Code First默认的约定是 为所有带有get set属性选择器的属性创建数据列
        [NotMapped()]
        public DateTime? DateOfBirth { get; set; }
        public byte[] Photo { get; set; }
        //表示非空字段
        [Required]
        public decimal Height { get; set; }
        public float Weight { get; set; }

        #region 一对多关系  自定义外键第一种方式
        //[ForeignKey("Standard")]
        //public int For_StandardId { get; set; }
        //public virtual Standard Standard { get; set; } 
        #endregion


        #region 一对多关系，自定义外键第二种方式
        //public int For_StandardId { get; set; }
        //[ForeignKey("For_StandardId")]
        //public virtual Standard CurrentStandard { get; set; }
        #endregion


        //对同一个实体多个引用   没有对应关系生成四个外键，通过反转特性【InverseProperty】来标识对应的引用
        //具体这个反转特性可以写在Student实体类中，也可以写在Standard类中   
        [InverseProperty("CurrentStudents")]
        public virtual Standard CurrentStandard { get; set; }
        [InverseProperty("PreviousStudents")]
        public virtual Standard PreviousStandard { get; set; }

    }
}
