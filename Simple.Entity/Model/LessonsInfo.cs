namespace Simple.Entity.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LessonsInfo")]
    public partial class LessonsInfo
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LessonId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TeacherId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LessonYear { get; set; }

        public virtual Lessons Lessons { get; set; }

        public virtual Teachers Teachers { get; set; }
    }
}
