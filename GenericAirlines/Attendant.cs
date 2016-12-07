namespace GenericAirlines
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Attendant")]
    public partial class Attendant : Employee
    {
        public byte Height { get; set; }

        [Required]
        [StringLength(6)]
        public string Gender { get; set; }
    }
}
