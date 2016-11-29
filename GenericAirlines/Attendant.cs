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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public byte Height { get; set; }

        [Required]
        [StringLength(6)]
        public string Gender { get; set; }

        public int Employee_id { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
