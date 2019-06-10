using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01EF_Code_First.多对多关系
{
    public class Activity
    {
        [Key]
        public int ActivityId { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }
        public List<Trip> Trips { get; set; }
    }
}
