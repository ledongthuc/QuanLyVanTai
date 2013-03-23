using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace PGS.Entity.Models.Mapping
{
    public class EQ_Input_DetailsMap : EntityTypeConfiguration<EQ_Input_Details>
    {
        public EQ_Input_DetailsMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("EQ.Input.Details");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.InputID).HasColumnName("InputID");
            this.Property(t => t.OrderID).HasColumnName("OrderID");
            this.Property(t => t.ContractID).HasColumnName("ContractID");
            this.Property(t => t.RequestID).HasColumnName("RequestID");
            this.Property(t => t.EquipmentID).HasColumnName("EquipmentID");
            this.Property(t => t.OrderQuantity).HasColumnName("OrderQuantity");
            this.Property(t => t.InputQuantity).HasColumnName("InputQuantity");
            this.Property(t => t.NotYetOutputQuantity).HasColumnName("NotYetOutputQuantity");
            this.Property(t => t.VNPrice).HasColumnName("VNPrice");
            this.Property(t => t.Updator).HasColumnName("Updator");
            this.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");

            // Relationships
            this.HasOptional(t => t.EQ_Inputs)
                .WithMany(t => t.EQ_Input_Details)
                .HasForeignKey(d => d.InputID);

        }
    }
}
