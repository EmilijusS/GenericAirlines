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
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<Passenger> Passengers { get; set; }
        public virtual DbSet<Pilot> Pilots { get; set; }
        public virtual DbSet<Plane> Planes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attendant>()
                .Property(e => e.Gender)
                .IsFixedLength();

            modelBuilder.Entity<Employee>()
                .Property(e => e.PersonalId)
                .IsFixedLength();

            modelBuilder.Entity<Employee>()
                .Property(e => e.Plane_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Languages)
                .WithRequired(e => e.Employee)
                .HasForeignKey(e => e.Employee_id)
                .WillCascadeOnDelete(false);

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
                .HasMany(e => e.Passengers)
                .WithMany(e => e.Flights)
                .Map(m => m.ToTable("Travels").MapLeftKey("Flight_id").MapRightKey("Passenger_id"));

            modelBuilder.Entity<Passenger>()
                .Property(e => e.PersonalId)
                .IsFixedLength();

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
                .HasMany(e => e.Employees)
                .WithOptional(e => e.Plane)
                .HasForeignKey(e => e.Plane_id);

            modelBuilder.Entity<Plane>()
                .HasMany(e => e.Flights)
                .WithRequired(e => e.Plane)
                .HasForeignKey(e => e.Plane_id)
                .WillCascadeOnDelete(false);
        }
    }
}
