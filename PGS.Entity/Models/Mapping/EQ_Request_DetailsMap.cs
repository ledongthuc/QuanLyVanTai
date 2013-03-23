using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace PGS.Entity.Models.Mapping
{
    public class EQ_Request_DetailsMap : EntityTypeConfiguration<EQ_Request_Details>
    {
        public EQ_Request_DetailsMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("EQ.Request.Details");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.RequestID).HasColumnName("RequestID");
            this.Property(t => t.EquipmentID).HasColumnName("EquipmentID");
            this.Property(t => t.InStockQuantity).HasColumnName("InStockQuantity");
            this.Property(t => t.RequestedQuantity).HasColumnName("RequestedQuantity");
            this.Property(t => t.ApprovedQuantity).HasColumnName("ApprovedQuantity");
            this.Property(t => t.NotYetOrderQuantity).HasColumnName("NotYetOrderQuantity");
            this.Property(t => t.NotYetInputQuantity).HasColumnName("NotYetInputQuantity");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.Updator).HasColumnName("Updator");
            this.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");

            // Relationships
            this.HasOptional(t => t.EQ_Requests)
                .WithMany(t => t.EQ_Request_Details)
                .HasForeignKey(d => d.RequestID);
            this.HasOptional(t => t.Equipment)
                .WithMany(t => t.EQ_Request_Details)
                .HasForeignKey(d => d.EquipmentID);

        }
    }
}
