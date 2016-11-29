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
        public virtual DbSet<Language> Language { get; set; }
        public virtual DbSet<Passenger> Passenger { get; set; }
        public virtual DbSet<Pilot> Pilot { get; set; }
        public virtual DbSet<Plane> Plane { get; set; }

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
                .HasMany(e => e.Attendant)
                .WithRequired(e => e.Employee)
                .HasForeignKey(e => e.Employee_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Pilot)
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
                .HasMany(e => e.Passenger)
                .WithMany(e => e.Flight)
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
                .Property(e => e.Seat_count)
                .IsFixedLength();

            modelBuilder.Entity<Plane>()
                .Property(e => e.Model)
                .IsFixedLength();

            modelBuilder.Entity<Plane>()
                .HasMany(e => e.Employee)
                .WithOptional(e => e.Plane)
                .HasForeignKey(e => e.Plane_id);

            modelBuilder.Entity<Plane>()
                .HasMany(e => e.Flight)
                .WithRequired(e => e.Plane)
                .HasForeignKey(e => e.Plane_id)
                .WillCascadeOnDelete(false);
        }
    }
}
