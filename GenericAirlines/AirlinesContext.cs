namespace GenericAirlines
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AirlinesContext : DbContext
    {
        public AirlinesContext()
            : base("name=AirlinesContext")
        {
        }

        public virtual DbSet<Attendant> Attendants { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Flight> Flights { get; set; }
        public virtual DbSet<Passenger> Passengers { get; set; }
        public virtual DbSet<Pilot> Pilots { get; set; }
        public virtual DbSet<Plane> Planes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasOptional(e => e.Attendant)
                .WithRequired(e => e.Employee);

            modelBuilder.Entity<Employee>()
                .HasOptional(e => e.Pilot)
                .WithRequired(e => e.Employee);

            modelBuilder.Entity<Flight>()
                .Property(e => e.Origin)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Flight>()
                .Property(e => e.Destination)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Flight>()
                .HasMany(e => e.Employees)
                .WithOptional(e => e.Flight)
                .HasForeignKey(e => e.Flight_id);

            modelBuilder.Entity<Flight>()
                .HasMany(e => e.Passengers)
                .WithMany(e => e.Flights)
                .Map(m => m.ToTable("Ticket").MapLeftKey("Flight_id").MapRightKey("Passenger_email"));

            modelBuilder.Entity<Pilot>()
                .Property(e => e.License)
                .IsFixedLength();

            modelBuilder.Entity<Plane>()
                .HasMany(e => e.Flights)
                .WithRequired(e => e.Plane)
                .HasForeignKey(e => e.Plane_id)
                .WillCascadeOnDelete(false);
        }
    }
}
