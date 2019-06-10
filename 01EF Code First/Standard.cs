using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01EF_Code_First
{
    public class Standard
    {
        //[Key]
        public int StandardId { get; set; }
        public string StandardName { get; set; }
        //[InverseProperty("CurrentStandard")]

        public ICollection<Student> CurrentStudents { get; set; }
        //[InverseProperty("PreviousStandard")]
        public ICollection<Student> PreviousStudents { get; set; }

    }
}
