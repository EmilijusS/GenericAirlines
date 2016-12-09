namespace GenericAirlines
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Attendant")]
    public partial class Attendant
    {
        public byte Height { get; set; }

        [Required]
        [StringLength(6)]
        public string Gender { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Employee_id { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
