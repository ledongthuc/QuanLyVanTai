using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace PGS.Entity.Models.Mapping
{
    public class Car_SchedulesMap : EntityTypeConfiguration<Car_Schedules>
    {
        public Car_SchedulesMap()
        {
            // Primary Key
            this.HasKey(t => t.ScheduleID);

            // Properties
            this.Property(t => t.Subject)
                .HasMaxLength(250);

            this.Property(t => t.RequestPerson)
                .HasMaxLength(250);

            this.Property(t => t.Status)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Car.Schedules");
            this.Property(t => t.ScheduleID).HasColumnName("ScheduleID");
            this.Property(t => t.Subject).HasColumnName("Subject");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.RequestPerson).HasColumnName("RequestPerson");
            this.Property(t => t.CarID).HasColumnName("CarID");
            this.Property(t => t.DriverID).HasColumnName("DriverID");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.StartTime).HasColumnName("StartTime");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.EndTime).HasColumnName("EndTime");
            this.Property(t => t.DistanceUsed).HasColumnName("DistanceUsed");
            this.Property(t => t.BenzinUsed).HasColumnName("BenzinUsed");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.Creator).HasColumnName("Creator");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.Updator).HasColumnName("Updator");
            this.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");

            // Relationships
            this.HasOptional(t => t.Car_Drivers)
                .WithMany(t => t.Car_Schedules)
                .HasForeignKey(d => d.DriverID);
            this.HasOptional(t => t.Car)
                .WithMany(t => t.Car_Schedules)
                .HasForeignKey(d => d.CarID);

        }
    }
}
