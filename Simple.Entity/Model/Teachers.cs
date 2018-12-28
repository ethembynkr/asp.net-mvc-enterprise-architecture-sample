namespace Simple.Entity.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Teachers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Teachers()
        {
            LessonsInfo = new HashSet<LessonsInfo>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(80)]
        public string Firstname { get; set; }

        [Required]
        [StringLength(80)]
        public string Surname { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LessonsInfo> LessonsInfo { get; set; }
    }
}
