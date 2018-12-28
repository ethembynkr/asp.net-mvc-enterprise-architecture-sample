namespace Simple.Entity.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Students
    {
        public int Id { get; set; }

        [Required]
        [StringLength(80)]
        public string Firstname { get; set; }

        [Required]
        [StringLength(80)]
        public string Surname { get; set; }
    }
}
