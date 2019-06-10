namespace _02Fluent_API_in__Code_First
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Demo.Cm_Standard")]
    public partial class Cm_Standard
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cm_Standard()
        {
            Cm_Student = new HashSet<Cm_Student>();
        }

        [Key]
        public int StandardKey { get; set; }

        public string StandardName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cm_Student> Cm_Student { get; set; }
    }
}
