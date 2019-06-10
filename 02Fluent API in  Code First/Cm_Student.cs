namespace _02Fluent_API_in__Code_First
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Demo.Cm_Student")]
    public partial class Cm_Student
    {
        [Key]
        public int StudentKey { get; set; }

        public string StuName { get; set; }

        public int Age { get; set; }

        public string Email { get; set; }

        public int For_StandardId { get; set; }

        public virtual Cm_Standard Cm_Standard { get; set; }
    }
}
