using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace PGS.Entity.Models.Mapping
{
    public class EQ_Order_DetailsMap : EntityTypeConfiguration<EQ_Order_Details>
    {
        public EQ_Order_DetailsMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("EQ.Order.Details");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.OrderID).HasColumnName("OrderID");
            this.Property(t => t.RequestID).HasColumnName("RequestID");
            this.Property(t => t.EquipmentID).HasColumnName("EquipmentID");
            this.Property(t => t.RequestQuantity).HasColumnName("RequestQuantity");
            this.Property(t => t.OrderQuantity).HasColumnName("OrderQuantity");
            this.Property(t => t.VNPrice).HasColumnName("VNPrice");
            this.Property(t => t.Updator).HasColumnName("Updator");
            this.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");

            // Relationships
            this.HasOptional(t => t.EQ_Orders)
                .WithMany(t => t.EQ_Order_Details)
                .HasForeignKey(d => d.OrderID);
            this.HasOptional(t => t.Equipment)
                .WithMany(t => t.EQ_Order_Details)
                .HasForeignKey(d => d.EquipmentID);

        }
    }
}
