using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace PGS.Entity.Models.Mapping
{
    public class Car_DriversMap : EntityTypeConfiguration<Car_Drivers>
    {
        public Car_DriversMap()
        {
            // Primary Key
            this.HasKey(t => t.DriverID);

            // Properties
            this.Property(t => t.DriverLicense)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Car.Drivers");
            this.Property(t => t.DriverID).HasColumnName("DriverID");
            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
            this.Property(t => t.CarID).HasColumnName("CarID");
            this.Property(t => t.DriverLicense).HasColumnName("DriverLicense");
            this.Property(t => t.DriverInfo).HasColumnName("DriverInfo");
            this.Property(t => t.DriverNotes).HasColumnName("DriverNotes");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.Updator).HasColumnName("Updator");
            this.Property(t => t.UpdateDate).HasColumnName("UpdateDate");

            // Relationships
            this.HasOptional(t => t.Employee)
                .WithMany(t => t.Car_Drivers)
                .HasForeignKey(d => d.EmployeeID);

        }
    }
}
