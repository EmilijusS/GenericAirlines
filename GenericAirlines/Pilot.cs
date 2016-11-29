namespace GenericAirlines
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pilot")]
    public partial class Pilot
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string License { get; set; }

        [Column(TypeName = "date")]
        public DateTime License_date { get; set; }

        public int Employee_id { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
