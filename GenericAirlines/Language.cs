namespace GenericAirlines
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Language")]
    public partial class Language
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Column("Language")]
        [Required]
        [StringLength(50)]
        public string Language1 { get; set; }
    }
}
