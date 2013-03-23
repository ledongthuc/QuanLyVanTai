using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace PGS.Entity.Models.Mapping
{
    public class CarMap : EntityTypeConfiguration<Car>
    {
        public CarMap()
        {
            // Primary Key
            this.HasKey(t => t.CarID);

            // Properties
            this.Property(t => t.CarModel)
                .HasMaxLength(250);

            this.Property(t => t.CarName)
                .HasMaxLength(250);

            this.Property(t => t.CarNumber)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Cars");
            this.Property(t => t.CarID).HasColumnName("CarID");
            this.Property(t => t.CarModel).HasColumnName("CarModel");
            this.Property(t => t.CarName).HasColumnName("CarName");
            this.Property(t => t.CarNumber).HasColumnName("CarNumber");
            this.Property(t => t.CarDescription).HasColumnName("CarDescription");
            this.Property(t => t.CarNoms).HasColumnName("CarNoms");
            this.Property(t => t.BoughtDate).HasColumnName("BoughtDate");
            this.Property(t => t.KMRuns).HasColumnName("KMRuns");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.Creator).HasColumnName("Creator");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.Updator).HasColumnName("Updator");
            this.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");
        }
    }
}
