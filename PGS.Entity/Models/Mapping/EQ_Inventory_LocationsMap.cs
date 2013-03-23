using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace PGS.Entity.Models.Mapping
{
    public class EQ_Inventory_LocationsMap : EntityTypeConfiguration<EQ_Inventory_Locations>
    {
        public EQ_Inventory_LocationsMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("EQ.Inventory.Locations");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.InventoryID).HasColumnName("InventoryID");
            this.Property(t => t.LocationID).HasColumnName("LocationID");
            this.Property(t => t.EquipmentID).HasColumnName("EquipmentID");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Updator).HasColumnName("Updator");
            this.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");

            // Relationships
            this.HasOptional(t => t.EQ_Inventory)
                .WithMany(t => t.EQ_Inventory_Locations)
                .HasForeignKey(d => d.InventoryID);

        }
    }
}
