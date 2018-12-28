namespace Simple.Entity.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Lessons
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lessons()
        {
            LessonsInfo = new HashSet<LessonsInfo>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string LessonName { get; set; }

        [Required]
        [StringLength(250)]
        public string LessonDescription { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LessonsInfo> LessonsInfo { get; set; }
    }
}
