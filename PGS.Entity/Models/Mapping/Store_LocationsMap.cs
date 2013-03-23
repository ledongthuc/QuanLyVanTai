using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace PGS.Entity.Models.Mapping
{
    public class Store_LocationsMap : EntityTypeConfiguration<Store_Locations>
    {
        public Store_LocationsMap()
        {
            // Primary Key
            this.HasKey(t => t.LocationID);

            // Properties
            this.Property(t => t.Location)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("Store.Locations");
            this.Property(t => t.LocationID).HasColumnName("LocationID");
            this.Property(t => t.StoreID).HasColumnName("StoreID");
            this.Property(t => t.Location).HasColumnName("Location");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.Updator).HasColumnName("Updator");
            this.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");

            // Relationships
            this.HasOptional(t => t.Store)
                .WithMany(t => t.Store_Locations)
                .HasForeignKey(d => d.StoreID);

        }
    }
}
