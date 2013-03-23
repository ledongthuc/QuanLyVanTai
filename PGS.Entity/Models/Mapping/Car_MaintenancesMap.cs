using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace PGS.Entity.Models.Mapping
{
    public class Car_MaintenancesMap : EntityTypeConfiguration<Car_Maintenances>
    {
        public Car_MaintenancesMap()
        {
            // Primary Key
            this.HasKey(t => t.MaintenanceID);

            // Properties
            this.Property(t => t.RequestPerson)
                .HasMaxLength(250);

            this.Property(t => t.MaintenanceType)
                .HasMaxLength(250);

            this.Property(t => t.Status)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Car.Maintenances");
            this.Property(t => t.MaintenanceID).HasColumnName("MaintenanceID");
            this.Property(t => t.RequestPerson).HasColumnName("RequestPerson");
            this.Property(t => t.RequestReason).HasColumnName("RequestReason");
            this.Property(t => t.CarID).HasColumnName("CarID");
            this.Property(t => t.MaintenanceBeginDate).HasColumnName("MaintenanceBeginDate");
            this.Property(t => t.MaintenanceEndDate).HasColumnName("MaintenanceEndDate");
            this.Property(t => t.MaintenanceType).HasColumnName("MaintenanceType");
            this.Property(t => t.MaintenanceCost).HasColumnName("MaintenanceCost");
            this.Property(t => t.AfterMaintenance).HasColumnName("AfterMaintenance");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.Creator).HasColumnName("Creator");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.Updator).HasColumnName("Updator");
            this.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");

            // Relationships
            this.HasOptional(t => t.Car)
                .WithMany(t => t.Car_Maintenances)
                .HasForeignKey(d => d.CarID);

        }
    }
}
