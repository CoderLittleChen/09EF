using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _05EF_Code_First2.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public string Sex { get; set; }
    }


    public class Course
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }

    public class Score
    {
        [Key]
        public int Id { get; set; }



    }

}