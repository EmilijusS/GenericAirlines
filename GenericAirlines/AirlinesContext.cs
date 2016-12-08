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

        public virtual DbSet<Attendant> Attendant { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Flight> Flight { get; set; }
        public virtual DbSet<Passenger> Passenger { get; set; }
        public virtual DbSet<Pilot> Pilot { get; set; }
        public virtual DbSet<Plane> Plane { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attendant>()
                .Property(e => e.Gender)
                .IsFixedLength();

            modelBuilder.Entity<Flight>()
                .Property(e => e.Origin)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Flight>()
                .Property(e => e.Destination)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Flight>()
                .Property(e => e.Plane_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Flight>()
                .HasMany(e => e.Employee)
                .WithOptional(e => e.Flight)
                .HasForeignKey(e => e.Flight_id);

            modelBuilder.Entity<Flight>()
                .HasMany(e => e.Passenger)
                .WithMany(e => e.Flight)
                .Map(m => m.ToTable("Ticket").MapLeftKey("Flight_id").MapRightKey("Passenger_email"));

            modelBuilder.Entity<Pilot>()
                .Property(e => e.License)
                .IsFixedLength();

            modelBuilder.Entity<Plane>()
                .Property(e => e.Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Plane>()
                .Property(e => e.Model)
                .IsFixedLength();

            modelBuilder.Entity<Plane>()
                .HasMany(e => e.Flight)
                .WithRequired(e => e.Plane)
                .HasForeignKey(e => e.Plane_id)
                .WillCascadeOnDelete(false);
        }
    }
}
