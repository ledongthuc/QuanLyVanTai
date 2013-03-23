using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace PGS.Entity.Models.Mapping
{
    public class EQ_InventoryMap : EntityTypeConfiguration<EQ_Inventory>
    {
        public EQ_InventoryMap()
        {
            // Primary Key
            this.HasKey(t => t.InventoryID);

            // Properties
            // Table & Column Mappings
            this.ToTable("EQ.Inventory");
            this.Property(t => t.InventoryID).HasColumnName("InventoryID");
            this.Property(t => t.StoreID).HasColumnName("StoreID");
            this.Property(t => t.EquipmentID).HasColumnName("EquipmentID");
            this.Property(t => t.MinLevel).HasColumnName("MinLevel");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.InUseQuantity).HasColumnName("InUseQuantity");
            this.Property(t => t.VNPriceTotal).HasColumnName("VNPriceTotal");
            this.Property(t => t.InOrderQuantity).HasColumnName("InOrderQuantity");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.Updator).HasColumnName("Updator");
            this.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");
        }
    }
}
