namespace GenericAirlines
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Flight")]
    public partial class Flight
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Flight()
        {
            Employee = new HashSet<Employee>();
            Passenger = new HashSet<Passenger>();
        }

        public int Id { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Departure { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Arrival { get; set; }

        [Required]
        [StringLength(3)]
        public string Origin { get; set; }

        [Required]
        [StringLength(3)]
        public string Destination { get; set; }

        [Required]
        [StringLength(8)]
        public string Plane_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee> Employee { get; set; }

        public virtual Plane Plane { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Passenger> Passenger { get; set; }
    }
}
