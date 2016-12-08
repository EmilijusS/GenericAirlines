namespace GenericAirlines
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pilot")]
    public partial class Pilot : Employee
    {
        [Required]
        [StringLength(10)]
        public string License { get; set; }

        [Column(TypeName = "date")]
        public DateTime License_date { get; set; }

    }
}
