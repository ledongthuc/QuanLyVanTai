using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace PGS.Entity.Models.Mapping
{
    public class EQ_Quote_DetailsMap : EntityTypeConfiguration<EQ_Quote_Details>
    {
        public EQ_Quote_DetailsMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("EQ.Quote.Details");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.QuoteID).HasColumnName("QuoteID");
            this.Property(t => t.RequestID).HasColumnName("RequestID");
            this.Property(t => t.EquipmentID).HasColumnName("EquipmentID");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Updator).HasColumnName("Updator");
            this.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");

            // Relationships
            this.HasOptional(t => t.EQ_Quotes)
                .WithMany(t => t.EQ_Quote_Details)
                .HasForeignKey(d => d.QuoteID);
            this.HasOptional(t => t.Equipment)
                .WithMany(t => t.EQ_Quote_Details)
                .HasForeignKey(d => d.EquipmentID);

        }
    }
}
