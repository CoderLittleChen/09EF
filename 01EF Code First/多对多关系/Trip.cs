using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01EF_Code_First.多对多关系
{
    public class Trip
    {
        [Key]
        public int TripId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal CostUSD { get; set; }
        public byte[] RowVersion { get; set; }
        public List<Activity> Activities { get; set; }
    }
}
